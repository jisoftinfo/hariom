Public Class frmSuppliers
    Dim tb As JISTable = db.Mill

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtSupplierName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtSupplierName, "Please Enter the Supplier Name")
            txtSupplierName.Focus()
            RValue = False
        ElseIf tb.State = "New" And tb.ExistUserCode(txtSupplierName.Text) Then
            ErrorProvider1.SetError(txtSupplierName, txtSupplierName.Text + " is Already Exist. Please Enter the New Supplier Name")
            txtSupplierName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtSupplierName, "")
        End If
        Return RValue
    End Function

    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtTinNo.Enter, txtSupplierName.Enter, txtPhNo.Enter, txtMobileNo.Enter, txtId.Enter, txtEmailId.Enter, txtCST.Enter, txtCode.Enter, txtBillingName.Enter, txtAddressLine.Enter, txtAddressline2.Enter, txtDueDays.Enter, txtOpBal.Enter, cmbCountGroup.Enter, txtShortName.Enter, txtDesignation4.Enter, txtDesignation3.Enter, txtDesignation2.Enter, txtDesignation1.Enter, txtDepartment4.Enter, txtDepartment3.Enter, txtDepartment2.Enter, txtDepartment1.Enter, txtPerson4.Enter, txtPerson3.Enter, txtPerson2.Enter, txtPerson1.Enter, txtMobileNo4.Enter, txtMobileNo3.Enter, txtMobileNo2.Enter, txtMobileNo1.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = txtSearchBox.Name Then List_Datas(txtSearchBox, db.Mill.UserCodes())
        If sender.Name = cmbCountGroup.Name Then
            List_Datas(cmbCountGroup, db.CountGroup.UserCodes())
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

    End Sub

    Private Sub txtCNo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(e.KeyChar) = 124 Or Asc(e.KeyChar) = 36 Or Asc(e.KeyChar) = 94 Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsLetter(e.KeyChar) = True) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtOpBalance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) = 124 Or Asc(e.KeyChar) = 36 Or Asc(e.KeyChar) = 94 Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsLetter(e.KeyChar) = True) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtTinNo.Leave, txtSupplierName.Leave, txtPhNo.Leave, txtMobileNo.Leave, txtId.Leave, txtEmailId.Leave, txtCST.Leave, txtCode.Leave, txtBillingName.Leave, txtAddressLine.Leave, txtAddressline2.Leave, txtDueDays.Leave, txtOpBal.Leave, cmbCountGroup.Leave, txtShortName.Leave, txtDesignation4.Leave, txtDesignation3.Leave, txtDesignation2.Leave, txtDesignation1.Leave, txtDepartment4.Leave, txtDepartment3.Leave, txtDepartment2.Leave, txtDepartment1.Leave, txtPerson4.Leave, txtPerson3.Leave, txtPerson2.Leave, txtPerson1.Leave, txtMobileNo4.Leave, txtMobileNo3.Leave, txtMobileNo2.Leave, txtMobileNo1.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub frmSuppliers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
        tb.SetControls(txtId, txtCode, txtBillingName, txtSupplierName, txtAddressLine, txtAddressline2, txtMobileNo, txtPhNo, txtCST, txtTinNo, txtEmailId, txtDueDays, txtOpBal, txtPerson1, txtPerson2, txtPerson3, txtPerson4, txtMobileNo1, txtMobileNo2, txtMobileNo3, txtMobileNo4, cmbCountGroup, txtShortName, txtDepartment1, txtDepartment2, txtDepartment3, txtDepartment4, txtDesignation1, txtDesignation2, txtDesignation3, txtDesignation4)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmSuppliersReport)
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
        tb.NewRecord()
        txtSupplierName.Focus()
        'txtSupplierName.ReadOnly = False
        txtOpBal.Text = "0"
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            ' txtSupplierName.ReadOnly = True
            ErrorProvider1.Clear()
        End If
    End Sub
    Sub SaveAllRecord()
        Dim arr As New ArrayList
        arr = tb.UserCodes()
        For i As Integer = 0 To arr.Count - 1
            txtSearchBox.Text = arr(i)
            ViewForm()
            SaveForm()
        Next
    End Sub
    Sub SaveForm()
        If FormValidate() Then
            txtBillingName.Text = txtSupplierName.Text
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                Dim id, code, Note As String

                Dim Arr As New ArrayList
                Arr = db.Ledger.Row("LedgerId,LedgerCode,Note", "LedgerName='" + txtBillingName.Text + "'")

                If Arr.Count Then
                    id = Arr(0).ToString()
                    code = Arr(1).ToString()
                    Note = Arr(2).ToString()
                Else
                    id = db.Ledger.NewId
                    code = db.Ledger.NewCode()
                    Note = ""
                End If

                db.Ledger.SaveRecord(id, code, txtBillingName.Text.ToString(), txtBillingName.Text.ToString(), txtAddressLine.Text.ToString(), txtPhNo.Text, txtMobileNo.Text, txtEmailId.Text.ToString(), 0, 0, Note)
                NewForm()
            End If
        End If
    End Sub

    Sub DeleteForm()

        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = tb.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, Me.Text, "I")
        If str = "Deleted" Then
            db.Ledger.Delete("LedgerName='" + txtBillingName.Text + "'")
            NewForm()
        End If
    End Sub

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmSupplierSearch)
    End Sub
End Class