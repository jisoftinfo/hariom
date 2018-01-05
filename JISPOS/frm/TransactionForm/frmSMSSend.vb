Public Class frmSMSSend

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        db.SMSSending.SaveRecord(db.SMSSending.NewId(), db.SMSSending.NewCode(), txtMobileNo.Text, txtMsg.Text, Now.ToString(), "UnSent")
        txtMobileNo.Text = ""
        txtMsg.Text = ""
        txtMobileNo.Focus()
    End Sub

    Private Sub frmSMSSend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
        dgvDetails.Columns("RType").Width = cmbType.Width
        dgvDetails.Columns("RName").Width = cmbName.Width
        dgvDetails.Columns("RMobileNo").Width = cmbMobileNo.Width
        dgvDetails.RowHeadersVisible = False
        dgvDetails.ColumnHeadersVisible = False
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

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.Enter, cmbName.Enter, cmbMobileNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name = cmbName.Name Then
            If cmbType.Text = "Mill" Then
                List_Datas(cmbName, db.Mill.Column("MillName"))
            ElseIf cmbType.Text = "Party" Then
                List_Datas(cmbName, db.Party.Column("PartyName"))
            End If
        End If
        'If sender.Name = cmbMobileNo.Name Then
        '    If cmbType.Text = "Mill" Then
        '        List_Datas(cmbMobileNo, db.Mill.Column("MobileNO"))

        '    ElseIf cmbType.Text = "Party" Then
        '        List_Datas(cmbMobileNo, db.Party.Column("MobileNO"))
        '    End If
        'End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.Leave, cmbName.Leave, cmbMobileNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub


    Private Sub cmbMobileNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMobileNo.KeyDown
        'SaveItem()
    End Sub

    Private Sub cmbName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbName.TextChanged
        Try
            If cmbType.Text = "Mill" Then
                cmbMobileNo.Text = db.Mill.Data("MobileNo", "MillName='" + cmbName.Text + "'")
            Else
                cmbMobileNo.Text = db.Party.Data("MobileNo", "PartyName='" + cmbName.Text + "'")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub NewItem()
        cmbType.Text = ""
        cmbName.Text = ""
        cmbMobileNo.Text = ""
        cmbType.Focus()
       
    End Sub
    'Sub SaveItem()

    '    If i = dgvDetails.Rows.Count Then dgvDetails.Rows.Add()

    '    Dim i As Integer = dgvDetails.CurrentRow.Index
    '    dgvDetails.Item("RType", i).Value = cmbType.Text
    '    dgvDetails.Item("RName", i).Value = cmbName.Text
    '    dgvDetails.Item("RMobileNo", i).Value = cmbMobileNo.Text
    'End Sub
    Sub ViewItem()
        Dim i As Integer = dgvDetails.CurrentRow.Index
        cmbType.Text = dgvDetails.Item("RType", i).Value
        cmbName.Text = dgvDetails.Item("RName", i).Value
        cmbMobileNo.Text = dgvDetails.Item("RMobileNo", i).Value
    End Sub
    Sub DeleteItem()
        dgvDetails.Rows.Remove(dgvDetails.CurrentRow)
        NewItem()
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NewItem()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        ViewItem()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgDialog.ShowMsgDlg("Do you Delete this Item?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then
            DeleteItem()
            MsgDialog.ShowMsgDlg("Deleted", Me.Text, "I")
        End If
    End Sub
End Class