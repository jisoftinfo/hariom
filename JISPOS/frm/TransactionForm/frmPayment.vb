Public Class frmPayment
    Dim ItemState As String = "New"

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbPaymentTo.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPaymentTo, "Please Enter the Payment TO")
            cmbPaymentTo.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPaymentTo, "")

        End If
        If cmbPayName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPayName, "Please Enter the Name")
            cmbPayName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPayName, "")
        End If
        If cmbPayMode.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPayMode, "Please Enter the Paymode")
            cmbPayMode.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPayMode, "")
        End If

        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, dtpDate.Enter, cmbPaymentTo.Enter, cmbPayName.Enter, txtPayAmount.Enter, cmbPayMode.Enter, txtNarration.Enter, txtSearchBox.Enter, txtSNo.Enter, txtAmount.Enter, cmbRefType.Enter, cmbRefNo.Enter, txtName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, db.Payment.Codes())
        If sender.Name = "cmbPayName" Then
            If cmbPaymentTo.Text = "Suppliers" Then
                List_Datas(cmbPayName, db.Mill.Column("MillName"))
            ElseIf cmbPaymentTo.Text = "Banks" Then
                List_Datas(cmbPayName, db.Banks.UserCodes())
            ElseIf cmbPaymentTo.Text = "Account Heads" Then
                List_Datas(cmbPayName, db.Ledger.Column("LedgerName", "not ledgername in (SELECT LedgerName FROM Customer UNION SELECT LedgerName FROM Supplier UNION SELECT LedgerName FROM Banks)"))
            ElseIf cmbPaymentTo.Text = "Customers" Then
                List_Datas(cmbPayName, db.Party.Column("PartyName"))
            End If

        End If

        'If sender.Name = cmbPayMode.Name Then
        '    cmbPayMode.Items.Clear()
        '    cmbPayMode.Items.Add("CASH")
        '    List_Datas(cmbPayMode, db.Banks.UserCodes(), True)
        'End If

        If sender.Name = cmbRefNo.Name Then
            cmbRefNo.Items.Clear()
            If cmbRefType.Text = "AgainstRef" Then List_Datas(cmbRefNo, GetBillNo("Payment", cmbPayName.Text))
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, dtpDate.Leave, cmbPaymentTo.Leave, cmbPayName.Leave, txtPayAmount.Leave, cmbPayMode.Leave, txtNarration.Leave, txtSearchBox.Leave, txtSNo.Leave, txtAmount.Leave, cmbRefType.Leave, cmbRefNo.Leave, txtName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        db.Payment.SetControls(txtId, txtCode, dtpDate, cmbPaymentTo, cmbPayName, cmbPayMode, txtPayAmount, txtName, txtNarration)

        SetFormStyle(Me)

        NewForm()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmPaymentReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then
                'If ctl.Name = cmbPayMode.Name Then
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
        If e.KeyChar = Chr(13) Then
            Dim ctl As Control = Me.ActiveControl
            If TypeOf ctl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctl, TextBox)
                If txt.Multiline = False Then e.KeyChar = ChrW(0)
            Else
                e.KeyChar = ChrW(0)
            End If
        End If
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
        pnlForm.Top = t
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
        DeleteForm()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub

    Sub NewForm()

        dgvDetails.Rows.Clear()
        db.Payment.NewRecord()
        cmbPaymentTo.Focus()
        ErrorProvider1.Clear()
    End Sub
    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = db.Payment.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                txtSearchBox.Text = ""
            End If
            ErrorProvider1.Clear()
        End If
    End Sub
    Sub SaveAllRecord()
        Dim arr As New ArrayList
        arr = db.Payment.Codes()
        For i As Integer = 0 To arr.Count - 1
            txtSearchBox.Text = arr(i)
            ViewForm()
            SaveForm()
        Next
    End Sub
    Sub saveForm()

        If FormValidate() Then
            Dim str As String = ""
            str = db.Payment.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                Dim id, code, GroupName As String
                GroupName = ""
                
                db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
                '  db.PaymentDetails.DeleteRecordByUserCode(txtCode.Text)

                Dim GName As String = ""
                If cmbPaymentTo.Text = "Account Heads" Then

                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode
                    AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), "Expensive", "Payment", txtNarration.Text, "Yes", 0, txtPayAmount.Text, GroupName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, "Expensive", txtCode.Text, txtPDNarration.Text)


                    If cmbPayMode.Text = "Cash" Then
                        GName = "Cash-in-hand"
                        id = db.LedgerReport.NewId()
                        code = db.LedgerReport.NewCode
                        AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), cmbPayName.Text, "Cash", txtNarration.Text, "Yes", txtPayAmount.Text, 0, GName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, "Cash", txtCode.Text, txtPDNarration.Text)

                        id = db.LedgerReport.NewId()
                        code = db.LedgerReport.NewCode
                        AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), "Cash", cmbPayName.Text, txtNarration.Text, "Yes", 0, txtPayAmount.Text, GName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, "Cash", txtCode.Text, txtPDNarration.Text)

                    Else
                        GName = db.Banks.Data("Groupname", "AcNo='" + cmbPayName.Text + "'")
                        id = db.LedgerReport.NewId()
                        code = db.LedgerReport.NewCode
                        AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), cmbPayName.Text, "Payment", txtNarration.Text, "Yes", txtPayAmount.Text, 0, GName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, cmbPayMode.Text, txtCode.Text, txtPDNarration.Text)

                    End If

                    'Else
                    '    id = db.LedgerReport.NewId()
                    '    code = db.LedgerReport.NewCode
                    '    AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), cmbPayName.Text, "Payment", txtNarration.Text, "Yes", 0, txtPayAmount.Text, GroupName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, cmbPayName.Text, txtCode.Text, txtPDNarration.Text)

                End If
                If cmbPayMode.Text = "Cash" Then
                    GName = "Cash-in-hand"
                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode
                    AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), cmbPayName.Text, "Cash", txtNarration.Text, "Yes", txtPayAmount.Text, 0, GName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, "Cash", txtCode.Text, txtPDNarration.Text)

                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode
                    AddLedger(id, code, txtCode.Text, "Payment", dtpDate.Value.ToString(), "Cash", cmbPayName.Text, txtNarration.Text, "Yes", 0, txtPayAmount.Text, GName, dtpDate.Value.ToString(), cmbPayMode.Text, cmbPayName.Text, cmbRefNo.Text, "Cash", txtCode.Text, txtPDNarration.Text)
                End If

            End If
            NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If db.Payment.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        'db.PaymentDetails.DeleteRecordByUserCode(txtCode.Text)
        db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
        str = db.Payment.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub

    Public Sub cmbPaymentTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayMode.TextChanged, cmbPayName.TextChanged

        If cmbPayMode.Text = "CASH" Then
            txtNarration.Text = "Payment To_" + cmbPayName.Text
        ElseIf cmbPaymentTo.Text = "Account Heads" Then
            txtNarration.Text = "Payment TO:  " + cmbPayName.Text

        Else
            txtNarration.Text = "TO Bank No:  " + cmbPayMode.Text
        End If
    End Sub

    Private Sub cmbPaymentTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaymentTo.SelectedIndexChanged
        If cmbPaymentTo.Text = "Account Heads" Then
            lblName.Enabled = True
            txtName.Enabled = True
        Else
            lblName.Enabled = False
            txtName.Enabled = False
            txtName.Text = ""
        End If
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmDebitSearch)
    End Sub
End Class