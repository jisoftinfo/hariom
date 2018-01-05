Public Class frmLDR_CashLedger

    Dim db As New DBLib


    Private Sub frmLDR_CashLedger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmLDR_CashLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmLDR_CashLedger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If txtLedgerType.Text <> "Customer" And txtLedgerType.Text <> "Supplier" And txtLedgerType.Text <> "Staff" And txtLedgerType.Text <> "Bank" And txtLedgerType.Text <> "Mill" Then
            'cmbLedgerName.Text = "Expensive"
            'cmbLedgerName.Visible = False
            'lblLedgerName.Visible = False
            cmbLedgerName.Text = "Cash"
            'cmbArea.Visible = False
            'lblArea.Visible = False
        End If
        SetFormStyle(Me)
        

    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Enter, dtpTDate.Enter, cmbLedgerName.Enter, cmbArea.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
       
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
        If sender.Name = cmbLedgerName.Name Then
            List_Datas(cmbLedgerName, db.Mill.Column("MillName"))
        End If

    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Leave, dtpTDate.Leave, cmbLedgerName.Leave, cmbArea.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub txtLedgerType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLedgerType.TextChanged
        If txtLedgerType.Text.ToLower() = "cash" Then
            lblLedgerName.Visible = False
            cmbLedgerName.Visible = False
            cmbLedgerName.Text = "Cash"
        Else
            lblLedgerName.Visible = True
            cmbLedgerName.Visible = True
            cmbLedgerName.Text = ""
            lblLedgerName.Text = txtLedgerType.Text + " Name"
        End If
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
ViewReport()

    End Sub
    Sub ViewReport()
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)


        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTLedgerReport As New DataTable()

        Dim CrAmt, DrAmt As Double
        CrAmt = 0
        DrAmt = 0
        If cmbLedgerName.Text.Trim() = "" Then cmbLedgerName.Text = " "
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")        
        DTLedgerReport = db.GetLedgerReport(dtpFDate.Value.ToString(), dtpTDate.Value.ToString(), cmbLedgerName.Text, CrAmt, DrAmt).ToTable("LedgerReport")
        'If txtLedgerType.Text = "Supplier" Or txtLedgerType.Text = "Customer" Or txtLedgerType.Text = "Ledger" Then
        '    DTLedgerReport = db.GetLedgerReport(dtpFDate.Value.ToString(), dtpTDate.Value.ToString(), cmbLedgerName.Text, CrAmt, DrAmt).ToTable("LedgerReport")
        'Else
        '    DTLedgerReport = db.CashLedgerReport(dtpFDate.Value.ToString(), dtpTDate.Value.ToString(), cmbLedgerName.Text, CrAmt, DrAmt).ToTable("LedgerReport")
        'End If


        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTLedgerReport)

        Dim ParameterValues As New Hashtable()
        ParameterValues.Clear()
        ParameterValues.Add("CrOpAmt", CrAmt)
        ParameterValues.Add("DrOpAmt", DrAmt)
        ParameterValues.Add("FromDate", dtpFDate.Value)
        ParameterValues.Add("ToDate", dtpTDate.Value)
        'ParameterValues.Add("Supplier", txtLedgerType.Text)
        'If txtLedgerType.Text = "Supplier" Or txtLedgerType.Text = "Customer" Then
        '    ReportView(CrystalReportViewer1, "LedgerReport\cryCustomer_SupplierLedger.rpt", ds, ParameterValues)
        'Else
        '    ReportView(CrystalReportViewer1, "LedgerReport\CashLedger.rpt", ds, ParameterValues)
        'End If

        ReportView(CrystalReportViewer1, "LedgerReport\cryLedgerReport.rpt", ds, ParameterValues)
    End Sub
    
End Class