Public Class frmScheduledSMSSearch
    Private Sub frmUnitsOfMeasurementSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ViewSearch()
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

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        Dim dv As New DataView
        rbnInfixCustomer.Checked = True
        rbnInfixMobile.Checked = True
        ViewSearch()
        dgvUOM.AllowUserToResizeColumns = True
    End Sub

    Sub ViewSearch()
        Dim WQry As String = ""

        If txtMobileNo.Text.Trim <> "" Then
            WQry += "MobileNo Like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += txtMobileNo.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        dgvUOM.DataSource = db.ScheduledSMS.Grid("SMSCode,SMSType,(select top 1 SName from ScheduledSMSMobileNo where ScheduledSMSMobileNo.MasterCode =ScheduledSMS.SMSCode ) as  ReceiverName,(select top 1 MobileNo from ScheduledSMSMobileNo where ScheduledSMSMobileNo.MasterCode =ScheduledSMS.SMSCode ) as  MobileNo,(select top 1 SDate from ScheduledSMSDate where ScheduledSMSDate.MasterCode =ScheduledSMS.SMSCode ) as  SendDate,(select top 1 STime from ScheduledSMSDate where ScheduledSMSDate.MasterCode =ScheduledSMS.SMSCode ) as  SendTime, Message", WQry)
        dgvUOM.Columns("SMSCode").Width = 100
        dgvUOM.Columns("Message").Width = 900


        'dgvUOM.Columns("SMSCode").Visible = False

        dgvUOM.Columns("SMSType").HeaderText = "SMS Type"
        dgvUOM.Columns("ReceiverName").HeaderText = "Receiver Name"
        dgvUOM.Columns("SendDate").HeaderText = "Send Date"
        dgvUOM.Columns("SendDate").DefaultCellStyle.Format = "dd/MM/yyyy"
     End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobileNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUOM.DoubleClick
        Try
            frmScheduledSMS.txtSearchBox.Text = dgvUOM.SelectedRows(0).Cells(0).Value()
            frmScheduledSMS.ViewForm()
            FormShow(frmScheduledSMS)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmUnitsOfMeasurementSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub
End Class