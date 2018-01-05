Public Class frmMultipleSMSSending

    Private Sub frmMultipleSMSSending_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmMultipleSMSSending_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        dgvDetails.RowHeadersVisible = True
        dgvDetails.AllowUserToAddRows = True
        dgvDetails.AllowUserToDeleteRows = True
        dgvDetails.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("RMobileNo", i).Value <> "" Then
                db.SMSSending.SaveRecord(db.SMSSending.NewId(), db.SMSSending.NewCode(), dgvDetails.Item("RMobileNo", i).Value, txtMsg.Text, Now.ToString(), "UnSent", dgvDetails.Item("RName", i).Value.ToString())
            End If
        Next
        MsgBox("Message Sending Successfully")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dgvDetails.Rows.Clear()
        txtMsg.Text = ""
    End Sub
End Class