Public Class frmAutoGeneration

    Dim db As New DBLib()
    Dim IsSearDataAdded As Boolean = False
    Sub NewForm()
        db.AutoGeneration.NewRecord()
        txtTableName.Focus()
        txtTableName.ReadOnly = False
        ErrorProvider1.Clear()
    End Sub
    Sub ViewForm(ByVal Code As String)
        Dim str As String = ""
        str = db.AutoGeneration.ViewRecordByUserCode(Code)
        If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
        txtTableName.ReadOnly = True
        ErrorProvider1.Clear()
    End Sub
    Sub List()
        List_Datas(txtSearchBox, db.AutoGeneration.UserCodes())
    End Sub
    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtTableName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtTableName, "Please Enter the TableName")
            txtTableName.Focus()
            RValue = False
     
        ElseIf db.AutoGeneration.State = "New" And db.AutoGeneration.ExistUserCode(txtTableName.Text) Then
            ErrorProvider1.SetError(txtTableName, txtTableName.Text + " is Already Exist. Please Enter the New TableName")
            txtTableName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtTableName, "")
        End If
        If txtPreFix.Text = "" Then
            ErrorProvider1.SetError(txtPreFix, "Please Enter the PreFix")
            txtPreFix.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtPreFix, "")
        End If
        If txtKeySize.Text = "" Then
            ErrorProvider1.SetError(txtKeySize, "Please Enter the keysize")
            txtKeySize.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtKeySize, "")
        End If
        If txtStartFrom.Text = "" Then
            ErrorProvider1.SetError(txtStartFrom, "Please Enter the StartFrom")
            txtStartFrom.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtStartFrom, "")
        End If
        Return RValue
    End Function

    Private Sub frmAutoGeneration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmAutoGeneration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        db.AutoGeneration.SetControls(txtId, txtCode, txtTableName, txtPreFix, txtKeySize, txtStartFrom)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub frmAutoGeneration_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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

    Private Sub txtId_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtId.Enter, txtTableName.Enter, txtPreFix.Enter, txtKeySize.Enter, txtSearchBox.Enter, txtStartFrom.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtId.Leave, txtTableName.Leave, txtPreFix.Leave, txtKeySize.Leave, txtSearchBox.Leave, txtStartFrom.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If FormValidate() Then
            Dim str As String = ""
            str = db.AutoGeneration.SaveRecord()
            If str.ToLower.Trim() = "inserted" Then txtSearchBox.AutoCompleteCustomSource.Add(txtTableName.Text)
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then NewForm()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then
            If db.AutoGeneration.Delete(txtId.Text) Then
                txtSearchBox.AutoCompleteCustomSource.Remove(txtTableName.Text)
                MsgDialog.ShowMsgDlg("Deleted", Me.Text, "I")
                NewForm()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            ViewForm(txtSearchBox.Text)
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmAutoGenerationReport)
    End Sub

    Private Sub txtSearchBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.TextChanged
        If IsSearDataAdded = False Then
            List()
            IsSearDataAdded = True

        End If
    End Sub
End Class