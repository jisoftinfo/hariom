Public Class frmTaxMaster
    Dim tb As JISTable = db.TaxMaster
    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtTaxValue.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtTaxValue, "Please Enter the Tax Value")
            txtTaxValue.Focus()
            RValue = False
        ElseIf tb.State = "New" And tb.ExistUserCode(txtTaxValue.Text) Then
            ErrorProvider1.SetError(txtTaxValue, txtTaxValue.Text + " is Already Exist. Please Enter the New Tax Value")
            txtTaxValue.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtTaxValue, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtTaxValue.Enter, txtNarration.Enter, txtSearchBox.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtTaxValue.Leave, txtNarration.Leave, txtSearchBox.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtTaxValue, txtNarration)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmTaxMasterReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                Me.SelectNextControl(ctl, True, True, True, True)
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


        'pnlForm.Left = l
        'pnlForm.Top = t
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
        txtTaxValue.ReadOnly = False
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByUserCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            txtTaxValue.ReadOnly = True
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()

            If str.ToLower.Trim() = "inserted" Then
                txtSearchBox.AutoCompleteCustomSource.Add(txtTaxValue.Text)
                Dim id, code As String
                If Val(txtTaxValue.Text) = 0 Then
                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Purchase Excemption", "Purchase Account", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Inter-state Purchase", "Purchase Account", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Sales Excemption", "Sales Account", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Inter-state Sales", "Sales Account", 0, txtTaxValue.Text, "", "")

                Else
                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Input Tax @ " + txtTaxValue.Text, "Duties and Taxes", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Output Tax @ " + txtTaxValue.Text, "Duties and Taxes", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Purchase @ " + txtTaxValue.Text, "Purchase Account", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Sales Return @ " + txtTaxValue.Text, "Purchase Account", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Sales @ " + txtTaxValue.Text, "Sales Account", 0, txtTaxValue.Text, "", "")

                    id = db.Ledger.NewId()
                    code = db.Ledger.NewCode()
                    db.Ledger.SaveRecord(id, code, "Purchase Return @ " + txtTaxValue.Text, "Sales Account", 0, txtTaxValue.Text, "", "")

                End If

            End If



            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        'If db.Stock.ExistData("TaxPercentage", txtTaxValue.Text) Then
        '    MsgDialog.ShowMsgDlg("Transaction Made, Cannot be Deleted", "DELETE", "I")
        '    Exit Sub
        'End If
        Dim str As String
        str = tb.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub

    Private Sub txtTaxValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTaxValue.KeyPress
        If (Asc(e.KeyChar) = 124 Or Asc(e.KeyChar) = 36 Or Asc(e.KeyChar) = 94 Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsLetter(e.KeyChar) = True) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub

End Class