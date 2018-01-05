Public Class frmLedgersSearch
    Private Sub frmCustomerSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
        ViewSearch()
    End Sub

    Sub ViewSearch()
        Dim WQry As String = ""

        If txtLedgerName.Text.Trim <> "" Then
            WQry += "LedgerName Like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += txtLedgerName.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If


        If txtAddress.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "Address Like '"
            If rbnSuffixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += txtAddress.Text
            If rbnPrefixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtMobile.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "Mobile Like '"
            If rbnSuffixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += txtMobile.Text
            If rbnPrefixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtMailId.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "MailId Like '"
            If rbnSuffixMailId.Checked = True Or rbnInfixMailId.Checked = True Then WQry += "%"
            WQry += txtMailId.Text
            If rbnPrefixMailId.Checked = True Or rbnInfixMailId.Checked = True Then WQry += "%"
            WQry += "'"
        End If


        If txtBillingName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "BillingName Like '"
            If rbnSufBillingName.Checked = True Or rbnInBillingName.Checked = True Then WQry += "%"
            WQry += txtBillingName.Text
            If rbnPreBillingName.Checked = True Or rbnInBillingName.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        dgvLedgerSearch.DataSource = db.Ledger.Grid("LedgerName,BillingName,Address,Mobile,MailId", WQry)

        dgvLedgerSearch.Width = 900
        dgvLedgerSearch.Columns("LedgerName").Width = 175
        dgvLedgerSearch.Columns("BillingName").Width = 175
        dgvLedgerSearch.Columns("Address").Width = 220
        dgvLedgerSearch.Columns("Mobile").Width = 100
        dgvLedgerSearch.Columns("MailId").Width = 175
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Enter, txtMobile.Enter, txtMailId.Enter, txtLedgerName.Enter, txtBillingName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave, txtMobile.Leave, txtMailId.Leave, txtLedgerName.Leave, txtBillingName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLedgerSearch.DoubleClick
        Try
            frmLedgers.txtSearchBox.Text = dgvLedgerSearch.SelectedRows(0).Cells(0).Value()
            frmLedgers.ViewForm()
            FormShow(frmLedgers)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmLedgersSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub

End Class