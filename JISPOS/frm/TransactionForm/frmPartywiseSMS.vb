Public Class frmPartywiseSMS
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

        If txtCustomerName.Text.Trim <> "" Then
            WQry += "PartyName Like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += txtCustomerName.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If


        If txtAddress.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "AddressLine1 Like '"
            If rbnSuffixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += txtAddress.Text
            If rbnPrefixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtAddress2.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "AddressLine2 Like '"
            If rbnSuffixAddress2.Checked = True Or rbnInfixAddress2.Checked = True Then WQry += "%"
            WQry += txtAddress2.Text
            If rbnPrefixAddress2.Checked = True Or rbnInfixAddress2.Checked = True Then WQry += "%"
            WQry += "'"
        End If


        If txtMobile.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "MobileNo Like '"
            If rbnSuffixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += txtMobile.Text
            If rbnPrefixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtMailId.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "EmailId Like '"
            If rbnSuffixMailId.Checked = True Or rbnInfixMailId.Checked = True Then WQry += "%"
            WQry += txtMailId.Text
            If rbnPrefixMailId.Checked = True Or rbnInfixMailId.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        dgvCustomerSearch.DataSource = db.Party.Grid("PartyCode as Code,PartyName as PartyName,LedgerName as BillingName,AddressLine1,AddressLine2,MobileNo,EmailId", WQry)
        dgvCustomerSearch.Columns("Code").Width = 100
        dgvCustomerSearch.Columns("PartyName").Width = 200
        dgvCustomerSearch.Columns("BillingName").Width = 200
        dgvCustomerSearch.Columns("AddressLine1").Width = 200
        dgvCustomerSearch.Columns("AddressLine2").Width = 180
        dgvCustomerSearch.Columns("MobileNo").Width = 100
        dgvCustomerSearch.Columns("EmailId").Width = 150
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Enter, txtMobile.Enter, txtMailId.Enter, txtCustomerName.Enter, txtAddress2.Enter, txtMsg.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave, txtMobile.Leave, txtMailId.Leave, txtCustomerName.Leave, txtAddress2.Leave, txtMsg.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.DoubleClick
        Try
            frmCustomers.txtSearchBox.Text = dgvCustomerSearch.SelectedRows(0).Cells(0).Value()
            frmCustomers.btnSearch1_Click(sender, e)
            FormShow(frmCustomers)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCustomerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            For i As Integer = 0 To dgvCustomerSearch.SelectedRows.Count - 1
                Dim PhNo As String
                PhNo = dgvCustomerSearch.SelectedRows(i).Cells("MobileNo").Value.ToString().Trim()
                If PhNo <> "" Then
                    Dim arr() As String
                    arr = PhNo.Split(",")
                    For j As Integer = 0 To arr.Count - 1
                        db.SMSSending.SaveRecord(db.SMSSending.NewId(), db.SMSSending.NewCode(), arr(j), txtMsg.Text, Now.ToString(), "UnSent")
                    Next

                End If
            Next
            txtMsg.Text = ""
        Catch ex As Exception

        End Try
    End Sub
End Class