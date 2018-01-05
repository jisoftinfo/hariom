Public Class frmSMSSentReport

    Private Sub frmSMSSentReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        dgvDetails.DataSource = db.SMSSending.Grid("SName, SendDate,SPerson, MobileNo, Message,Status", "", "SendDate desc")
        dgvDetails.Columns("SPerson").HeaderText = "Person"
        dgvDetails.Columns("SName").Width = 200
        dgvDetails.Columns("SPerson").Width = 200
        dgvDetails.Columns("MobileNo").Width = 150
        dgvDetails.Columns("Message").Width = 700
        dgvDetails.Columns("SendDate").Width = 150

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

    Private Sub dgvDetails_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellDoubleClick
        'FormShow(frmMultipleSMSSending)
        'frmMultipleSMSSending.dgvDetails.Rows.Add()
        'frmMultipleSMSSending.dgvDetails.Item("RName", 0).Value = dgvDetails("RName", e.RowIndex).Value.ToString()
        ' frmMultipleSMSSending.dgvDetails.Item("RMobileNo", 0).Value = dgvDetails("MobileNo", e.RowIndex).Value.ToString()
        'frmMultipleSMSSending.txtMsg.Text = dgvDetails("Message", e.RowIndex).Value.ToString()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
End Class
