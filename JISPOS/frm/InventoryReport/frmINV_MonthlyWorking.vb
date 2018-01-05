Public Class frmINV_MonthlyWorking
    Dim db As New DBLib

    Private Sub frmINV_SalesReport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnSearch_Click(sender, e)
    End Sub

    Private Sub frmINV_SalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmINV_SalesReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmINV_SalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        

        Dim PType As String = ""
       
        
        Dim WQry As String = ""

        If cmbCustomerName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " MillName='" + cmbCustomerName.Text + "'"
        End If

        If cmbPartyName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " PartyName='" + cmbPartyName.Text + "'"
        End If

        If cmbBillingName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " BillingName='" + cmbBillingName.Text + "'"
        End If

        If cmbYear.Text.Trim <> "" Then
            If cmbYear.Text = "2014 - 2015" Then
                If WQry <> "" Then WQry += " and "
                WQry += " Month='" + cmbYearNew.Text + "' and Year='" + cmbYear.Text + "'"
            Else
                If WQry <> "" Then WQry += " and "
                WQry += " Month='" + cmbMonth.Text + "' and Year='" + cmbYear.Text + "'"
            End If

        End If

        

        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTMillWorking As New DataTable()

        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")
        DTMillWorking = db.ViewMillWorking.Grid("*", WQry).ToTable("MillWorking")
        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTMillWorking)

        ReportView(CrystalReportViewer1, "InventoryReport\cryMonthlyWorking.rpt", ds)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCustomerName.Enter, cmbPartyName.Enter, cmbMonth.Enter, cmbBillingName.Enter, cmbYear.Enter, cmbYearNew.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbCustomerName.Name Then List_Datas(cmbCustomerName, db.Mill.Column("MillName"))
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If
        If sender.name = cmbBillingName.Name Then
            List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyName.Leave, cmbCustomerName.Leave, cmbMonth.Leave, cmbBillingName.Leave, cmbYear.Leave, cmbYearNew.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    'Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged
    '    If txtYear.Text <> "2014" Then
    '        cmbMonth.Visible = True
    '    End If


    'End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        If cmbYear.Text <> "2014 - 2016" Then
            cmbMonth.Visible = False
            cmbYearNew.Visible = True
        End If
    End Sub
End Class