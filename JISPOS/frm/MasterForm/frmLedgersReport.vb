Public Class frmLedgersReport
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
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
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


        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTLedger As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        Dim OrderBy As String
        OrderBy = ""
        If cmbOrderBy.Text = "Ledger Name" Then
            OrderBy = "LedgerName"
        ElseIf cmbOrderBy.Text = "Address" Then
            OrderBy = "Address"
        ElseIf cmbOrderBy.Text = "Credit Days" Then
            OrderBy = "CreditDays"
        ElseIf cmbOrderBy.Text = "Credit Limits" Then
            OrderBy = "CreditLimit"
        End If

        If OrderBy <> "" And rbnDescending.Checked = True Then
            OrderBy += " desc"
        End If
        DTLedger = db.Ledger.Grid("*", WQry, OrderBy).ToTable("Ledger")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTLedger)
        ReportView(CrystalReportViewer1, "Master\cryLedgers.rpt", ds)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLedgerName.Enter, txtAddress.Enter, txtMailId.Enter, txtMobile.Enter, cmbOrderBy.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLedgerName.Leave, txtAddress.Leave, txtMailId.Leave, txtMobile.Leave, cmbOrderBy.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub
End Class