Public Class frmUserAccount

    Dim tb As JISTable = db.UserAccount

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtComapny.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtComapny, "Please Enter the Company name")
            txtComapny.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtComapny, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtUserName.Enter, txtPassword.Enter, txtComapny.Enter, cmbType.Enter, cmbSearchBox.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "cmbSearchBox" Then List_Datas(cmbSearchBox, tb.Column("UserName", "CompanyName='" + CompName + "'"))
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtUserName.Leave, txtPassword.Leave, txtComapny.Leave, cmbType.Leave, cmbSearchBox.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtComapny, txtUserName, txtPassword, cmbType)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        'FormShow(frmUnitsReport) 
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


        pnlForm.Left = l
        pnlForm.Top = t
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
        txtComapny.ReadOnly = False
        txtComapny.Text = CompName
        ErrorProvider1.Clear()
        txtUserName.Focus()
        dgvDetails.DataSource = db.UserAccount.Grid("UserName,UserType", "CompanyName='" + CompName + "'")
    End Sub

    Sub ViewForm()
        If cmbSearchBox.Text.Trim() = "" Then
            cmbSearchBox.Focus()
        Else
            Dim str As String = ""
            Dim Code As String = db.UserAccount.Data("UserCode", "CompanyName='" + CompName + "' and UserName='" + cmbSearchBox.Text + "'")
            str = tb.ViewRecordByCode(Code)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else cmbSearchBox.Text = ""
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = tb.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub

    Private Sub dgvDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellContentClick

    End Sub

    Private Sub dgvDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDetails.Click
        cmbSearchBox.Text = dgvDetails.SelectedRows(0).Cells(0).Value.ToString()
        ViewForm()
    End Sub
End Class