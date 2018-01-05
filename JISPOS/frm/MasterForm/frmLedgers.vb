Public Class frmLedgers
    Dim tb As JISTable = db.Ledger
    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtLedgerName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtLedgerName, "Please Enter the Ledger Name")
            txtLedgerName.Focus()
            RValue = False
        ElseIf db.Ledger.State = "New" And db.Ledger.ExistUserCode(txtLedgerName.Text) Then
            ErrorProvider1.SetError(txtLedgerName, txtLedgerName.Text + " is Already Exist. Please Enter the New Symbol")
            txtLedgerName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtLedgerName, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtLedgerName.Enter, txtNote.Enter, txtPhoneNo.Enter, txtMobile.Enter, txtMailId.Enter, txtId.Enter, txtCreditLimits.Enter, txtCreditDays.Enter, txtBillingName.Enter, txtAddress.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtLedgerName.Leave, txtNote.Leave, txtPhoneNo.Leave, txtMobile.Leave, txtMailId.Leave, txtId.Leave, txtCreditLimits.Leave, txtCreditDays.Leave, txtBillingName.Leave, txtAddress.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub txtOpeningBalance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) = 124 Or Asc(e.KeyChar) = 36 Or Asc(e.KeyChar) = 94 Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsLetter(e.KeyChar) = True) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmLedgers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtLedgerName, txtBillingName, txtAddress, txtPhoneNo, txtMobile, txtMailId, txtCreditDays, txtCreditLimits, txtNote)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmLedgersReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                If TypeOf ctl Is TextBox Then
                    Dim txt As TextBox = DirectCast(ctl, TextBox)
                    If txt.Multiline = True Then
                        If txt.Text.EndsWith(vbCrLf) Then
                            Me.SelectNextControl(ctl, True, True, True, True)
                        End If
                    Else
                        Me.SelectNextControl(ctl, True, True, True, True)
                    End If
                Else
                    Me.SelectNextControl(ctl, True, True, True, True)
                End If


            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
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
        ' pnlForm.Top = t
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewForm()
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub


    Sub NewForm()
        tb.NewRecord()
        txtLedgerName.Focus()
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByUserCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            txtLedgerName.ReadOnly = True
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")

            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
                Dim id, code As String

                id = db.LedgerReport.NewId()
                code = db.LedgerReport.NewCode()
                'If cmbOPType.Text.ToLower = "cr" Then
                '    AddLedger(id, code, txtCode.Text, "Ledger", Now.ToString(), txtLedgerName.Text, "Opening Balance", "", "Yes", 0, txtOpeningBalance.Text, cmbGroupName.Text, Now.ToString())
                'Else
                '    AddLedger(id, code, txtCode.Text, "Ledger", Now.ToString(), txtLedgerName.Text, "Opening Balance", "", "Yes", txtOpeningBalance.Text, 0, cmbGroupName.Text, Now.ToString())
                'End If
                NewForm()
            End If
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = tb.DeleteRecord()
        If str = "Deleted" Then
            db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
            NewForm()
        End If
        If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmLedgersSearch)
    End Sub

End Class