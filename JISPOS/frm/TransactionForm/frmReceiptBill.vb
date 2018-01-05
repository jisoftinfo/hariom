Public Class frmReceiptBill
    Dim tb As JISTable = db.ReceiptBill

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbCustomerName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbCustomerName, "Please Enter the Reciver Name")
            cmbCustomerName.Focus()
            RValue = False

        Else
            ErrorProvider1.SetError(cmbCustomerName, "")
        End If
        If cmbMode.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbMode, "Please Enter the Type Of Mode")
            cmbMode.Focus()
            RValue = False

        Else
            ErrorProvider1.SetError(cmbMode, "")
        End If

        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtNarration.Enter, txtChequeno.Enter, txtBankName.Enter, txtAmount.Enter, dtpDate.Enter, cmbMode.Enter, cmbCustomerName.Enter, txtSearchBox.Enter, txtChkdate.Enter

        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.Codes())
        If sender.name = cmbCustomerName.Name Then List_Datas(cmbCustomerName, db.Party.Column("PartyName"))
        If sender.name = cmbMode.Name Then List_Datas(cmbMode, db.Banks.UserCodes())
        cmbMode.Items.Add("CASH")
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtNarration.Leave, txtChequeno.Leave, txtBankName.Leave, txtAmount.Leave, dtpDate.Leave, cmbMode.Leave, cmbCustomerName.Leave, txtSearchBox.Leave, txtChkdate.Leave

        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, cmbCustomerName, dtpDate, cmbMode, txtAmount, txtBankName, txtChequeno, txtChkdate, txtNarration)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        If db.ReceiptBill.State = "New" Then Exit Sub
        Dim f As New frmReceiptBillReport
        f.viewprint(txtCode.Text)
        f.CrystalReportViewer1.RefreshReport()
        f.ShowDialog()
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then
                'If ctl.Name = cmbMode.Name Then
                '    FormShow(frmBanks)
                'End If
            ElseIf ctl.Text = "@" Then

            Else
                Me.SelectNextControl(ctl, True, True, True, True)
            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If

    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub
    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l, t As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

        l = (pnlContent.Width - pnlForm.Width) / 2
        If l < 0 Then l = 0

        t = (pnlContent.Height - pnlForm.Height) / 2
        If t < 0 Then t = 0


        pnlForm.Left = l
        'pnlForm.Top = t
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewForm()
        'SaveAllRecord()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Type = "Admin" Then DeleteForm()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub


    Sub NewForm()
        tb.NewRecord()
        cmbCustomerName.Focus()
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveAllRecord()
        Dim arr As New ArrayList
        arr = tb.Codes()
        For i As Integer = 0 To arr.Count - 1
            txtSearchBox.Text = arr(i)
            ViewForm()
            SaveForm()
        Next
    End Sub

    Sub SaveForm()
        If Type <> "Admin" And db.ReceiptBill.State <> "New" Then Exit Sub
        If FormValidate() Then
            Dim str As String = ""
            Dim saveresult As String
            str = tb.SaveRecord()
            saveresult = str
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then

                Dim id, code, GroupName As String
                GroupName = ""
                db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
                id = db.LedgerReport.NewId()
                code = db.LedgerReport.NewCode
                AddLedger(id, code, txtCode.Text, "Receipt", dtpDate.Value.ToString(), cmbCustomerName.Text, "Receipt", txtNarration.Text, "Yes", txtAmount.Text, 0, GroupName, dtpDate.Value.ToString(), cmbCustomerName.Text, cmbMode.Text, txtNarration.Text, " ", txtCode.Text)

                If cmbMode.Text = "CASH" Then
                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode
                    AddLedger(id, code, txtCode.Text, "Receipt", dtpDate.Value.ToString(), "Cash", "Receipt", txtNarration.Text, "Yes", 0, txtAmount.Text, GroupName, dtpDate.Value.ToString(), cmbCustomerName.Text, cmbMode.Text, txtNarration.Text, "Cash ", txtCode.Text)
                Else
                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode
                    AddLedger(id, code, txtCode.Text, "Receipt", dtpDate.Value.ToString(), cmbMode.Text, "Receipt", txtNarration.Text, "Yes", 0, txtAmount.Text, GroupName, dtpDate.Value.ToString(), cmbCustomerName.Text, cmbMode.Text, txtNarration.Text, cmbMode.Text, txtCode.Text)
                End If
            End If
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")

            If saveresult.ToLower = "inserted" And ckbisprint.Checked = True Then
                Dim f As New frmReceiptBillReport
                f.viewprint(txtCode.Text)
                f.CrystalReportViewer1.RefreshReport()
                f.Show()
                f.CrystalReportViewer1.PrintReport()


            End If

            NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
        str = tb.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub
     
    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        If Val(txtAmount.Text) <> 0 Then
            lblvalue.Text = "Rs." & Val(txtAmount.Text)
            lblwords.Text = Number_to_Word.numtoword(txtAmount.Text)
        Else
            lblvalue.Text = ""
            lblwords.Text = ""
        End If
    End Sub

     
    Private Sub cmbMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMode.SelectedIndexChanged
        If cmbMode.Text = "CASH" Then
            lblChkdate.Enabled = False
            txtChkdate.Enabled = False
            txtChequeno.Enabled = False
            lblCashNo.Enabled = False
            lblBankname.Enabled = False
            txtBankName.Enabled = False
            txtChequeno.Text = ""
            txtBankName.Text = ""
            txtChkdate.Text = ""
        Else
            lblChkdate.Enabled = True
            txtChkdate.Enabled = True
            txtChequeno.Enabled = True
            lblCashNo.Enabled = True
            lblBankname.Enabled = True
            txtBankName.Enabled = True
            txtChequeno.Text = ""
            txtBankName.Text = ""
            txtChkdate.Text = ""
            txtBankName.Text = db.Banks.Data("BankName", "AcNo='" + cmbMode.Text + "'")
        End If
    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        e.KeyChar = NumericCheckwithsingledot(sender, e.KeyChar, False)
    End Sub
    Private Sub cmbMode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMode.TextChanged, txtBankName.TextChanged, cmbCustomerName.TextChanged
        If cmbMode.Text = "CASH" Then
            txtNarration.Text = "Receipt TO:" + cmbCustomerName.Text
        Else
            txtNarration.Text = "Receipt TO Bank No:" + txtBankName.Text
        End If
    End Sub
    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmReceiptBillSearch)
    End Sub

End Class