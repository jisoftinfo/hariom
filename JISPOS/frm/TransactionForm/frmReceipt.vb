Public Class frmReceipt

    Dim ItemState As String = "New"

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbReceiptFrom.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbReceiptFrom, "Please Enter the Receipt TO")
            cmbReceiptFrom.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbReceiptFrom, "")

        End If
        If cmbReceiptName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbReceiptName, "Please Enter the Name")
            cmbReceiptName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbReceiptName, "")
        End If
        If cmbReceiptMode.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbReceiptMode, "Please Enter the Paymode")
            cmbReceiptMode.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbReceiptMode, "")
        End If

        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, dtpDate.Enter, cmbReceiptFrom.Enter, cmbReceiptName.Enter, txtPayAmount.Enter, cmbReceiptMode.Enter, txtNarration.Enter, txtSearchBox.Enter, txtSNo.Enter, txtAmount.Enter, cmbRefType.Enter, cmbRefNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, db.Receipt.Codes())
        If sender.Name = cmbReceiptName.Name Then
            If cmbReceiptFrom.Text = "Customers" Then
                List_Datas(cmbReceiptName, db.Party.Column("PartyName"))
                'ElseIf cmbReceiptFrom.Text = "Banks" Then
                '    List_Datas(cmbReceiptName, db.Banks.UserCodes())
            ElseIf cmbReceiptFrom.Text = "Suppliers" Then
                List_Datas(cmbReceiptName, db.Mill.Column("MillName"))
            End If

        End If

        If sender.Name = cmbReceiptMode.Name Then
            cmbReceiptMode.Items.Clear()
            cmbReceiptMode.Items.Add("Cash")
            '  List_Datas(cmbReceiptMode, db.Banks.UserCodes(), True)
        End If

        If sender.Name = cmbRefNo.Name Then
            cmbRefNo.Items.Clear()
            If cmbRefType.Text = "AgainstRef" Then List_Datas(cmbRefNo, GetBillNo("Receipt", cmbReceiptName.Text))
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, dtpDate.Leave, cmbReceiptFrom.Leave, cmbReceiptName.Leave, txtPayAmount.Leave, cmbReceiptMode.Leave, txtNarration.Leave, txtSearchBox.Leave, txtSNo.Leave, txtAmount.Leave, cmbRefType.Leave, cmbRefNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        db.Receipt.SetControls(txtId, txtCode, dtpDate, cmbReceiptFrom, cmbReceiptName, cmbReceiptMode, txtPayAmount, txtDetails, txtNarration)
        SetFormStyle(Me)
        NewForm()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmReceiptReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then
                'If ctl.Name = cmbReceiptMode.Name Then
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
        DeleteForm()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub

    Private Sub dgvDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDetails.MouseDown
        dgvDetails.ContextMenuStrip = Nothing
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If dgvDetails.Item(0, dgvDetails.CurrentRow.Index).Value <> Nothing Then
                    dgvDetails.ContextMenuStrip = ContextMenuStrip1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetails_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvDetails.RowsAdded
        If dgvDetails.Rows.Count > 9 Then
            dgvDetails.Width = 565
        Else
            dgvDetails.Width = 547
        End If
    End Sub

    Private Sub dgvDetails_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvDetails.RowsRemoved
        If dgvDetails.Rows.Count > 9 Then
            dgvDetails.Width = 565
        Else
            dgvDetails.Width = 547
        End If
    End Sub


    Sub NewForm()

        dgvDetails.Rows.Clear()
        db.Receipt.NewRecord()
        cmbReceiptFrom.Focus()
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = db.Receipt.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                txtSearchBox.Text = ""
                'Dim dv As New DataView
                'dv = db.ReceiptDetails.Grid("*", "ReceiptCode='" + txtCode.Text + "'")
                'dgvDetails.Rows.Clear()
                'For i As Integer = 0 To dv.Count - 1
                '    dgvDetails.Rows.Add()
                '    dgvDetails.Item("SNo", i).Value = dv.Item(i)("sno").ToString()
                '    dgvDetails.Item("RefType", i).Value = dv.Item(i)("RefType").ToString()
                '    dgvDetails.Item("RefNo", i).Value = dv.Item(i)("RefNo").ToString()
                '    dgvDetails.Item("Amount", i).Value = dv.Item(i)("Amount").ToString()
                '    dgvDetails.Item("JournalCode", i).Value = dv.Item(i)("JournalCode").ToString()
                '    dgvDetails.Item("Narration", i).Value = dv.Item(i)("Narration").ToString()
                'Next
            End If
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveAllRecord()
        Dim arr As New ArrayList
        arr = db.Receipt.Codes()
        For i As Integer = 0 To arr.Count - 1
            txtSearchBox.Text = arr(i)
            ViewForm()
            SaveForm()
        Next
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = db.Receipt.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                Dim id, code As String
                
                db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
                ' db.ReceiptDetails.DeleteRecordByUserCode(txtCode.Text)
                id = db.LedgerReport.NewId()
                code = db.LedgerReport.NewCode
                AddLedger(id, code, txtCode.Text, "Receipt", dtpDate.Value.ToString(), cmbReceiptName.Text, "Receipt", txtNarration.Text, "Yes", 0, txtPayAmount.Text, "", dtpDate.Value.ToString(), cmbReceiptName.Text, cmbReceiptMode.Text, cmbRefNo.Text, cmbReceiptName.Text, txtCode.Text)

                Dim GName As String = ""
                If cmbReceiptMode.Text = "Cash" Then
                    GName = "Cash-in-hand"
                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode
                    AddLedger(id, code, txtCode.Text, "Receipt", dtpDate.Value.ToString(), cmbReceiptMode.Text, "Receipt", txtNarration.Text, "Yes", txtPayAmount.Text, 0, GName, dtpDate.Value.ToString(), cmbReceiptName.Text, cmbReceiptMode.Text, cmbRefNo.Text, "Cash ", txtCode.Text)

                End If

            End If
            NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If db.Receipt.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
        str = db.Receipt.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub
     
    Private Sub cmbReceiptMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReceiptMode.SelectedIndexChanged, cmbReceiptName.TextChanged
        If cmbReceiptMode.Text = "Cash" Then
            txtNarration.Text = "Receipt TO_" + cmbReceiptName.Text
        Else
            txtNarration.Text = "Receipt TO Bank No:" + cmbReceiptMode.Text
        End If
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmCreditSearch)
    End Sub
End Class