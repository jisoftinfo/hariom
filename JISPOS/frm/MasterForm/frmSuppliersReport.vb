Public Class frmSuppliersReport
    Dim db As New DBLib

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

    Private Sub frmCustomersReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        Dim WQry As String = ""

        If txtCustomerName.Text.Trim <> "" Then
            WQry += "LedgerName Like '"
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


        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTSupplier As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        Dim OrderBy As String
        OrderBy = ""
        If cmbOrderBy.Text = "Ledger Name" Then
            OrderBy = "LedgerName"
        ElseIf cmbOrderBy.Text = "Tin No" Then
            OrderBy = "TinNo"
        ElseIf cmbOrderBy.Text = "CST" Then
            OrderBy = "CST"
        End If

        If OrderBy <> "" And rbnDescending.Checked = True Then
            OrderBy += " desc"
        End If
        DTSupplier = db.Mill.Grid("*", WQry, OrderBy).ToTable("Supplier")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTSupplier)
        ReportView(CrystalReportViewer1, "Master\crySuppliers.rpt", ds)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.Enter, txtAddress.Enter, txtMailId.Enter, txtMobile.Enter, cmbOrderBy.Enter, txtAddress2.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.Leave, txtAddress.Leave, txtMailId.Leave, txtMobile.Leave, cmbOrderBy.Leave, txtAddress2.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

End Class