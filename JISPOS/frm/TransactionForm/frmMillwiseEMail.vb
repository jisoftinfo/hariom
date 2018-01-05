Public Class frmMillwiseEMail
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
            WQry += "MillName Like '"
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

        dgvCustomerSearch.DataSource = db.Mill.Grid("MillName,AddressLine1,MobileNo,EmailId,AddressLine2", WQry)
        dgvCustomerSearch.Columns("MillName").Width = 250
        dgvCustomerSearch.Columns("AddressLine1").Width = 250
        dgvCustomerSearch.Columns("MobileNo").Width = 100
        dgvCustomerSearch.Columns("EmailId").Width = 200
        dgvCustomerSearch.Columns("AddressLine2").Width = 180
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Enter, txtMobile.Enter, txtMailId.Enter, txtCustomerName.Enter, txtAddress2.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave, txtMobile.Leave, txtMailId.Leave, txtCustomerName.Leave, txtAddress2.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.DoubleClick
        Try
            frmSuppliers.txtSearchBox.Text = dgvCustomerSearch.SelectedRows(0).Cells(0).Value()
            frmSuppliers.btnSearch_Click(sender, e)
            FormShow(frmSuppliers)
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
        Me.Enabled = False
        Try
            Dim ObjEM As New JISEMail()
            Dim AttFiles As New ArrayList

            Dim counter As New Integer
            For counter = 0 To lstAttachedFiles.Items.Count - 1
                AttFiles.Add(lstAttachedFiles.Items(counter))
            Next

            For i As Integer = 0 To dgvCustomerSearch.SelectedRows.Count - 1
                Dim EMail As String
                EMail = dgvCustomerSearch.SelectedRows(i).Cells("EmailId").Value.ToString().Trim()
                If EMail <> "" Then
                    Dim arr() As String
                    arr = EMail.Split(",")
                    For j As Integer = 0 To arr.Count - 1
                        ObjEM.SendMail(arr(j), txtSubject.Text, rtxtMessage.Text, AttFiles)
                    Next
                End If
            Next

        Catch ex As Exception

        End Try
        Me.Enabled = True
    End Sub

    Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser.Click
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                lstAttachedFiles.Items.Add(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lstAttachedFiles.Items.Remove(lstAttachedFiles.SelectedItem)
    End Sub


End Class