Public Class frmSupplierBalanceLedger
    Dim db As New DBLib

    Private Sub frmSupplierBalanceLedger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmSupplierBalanceLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
        btnSearch.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SType As String = ""



        Dim ds As New DataSet
        'Dim DTCompanyDetails As New DataTable()
        Dim DTsupplierBalance As New DataTable()
        'Dim DTPurchaseDetails As New DataTable()


        ' DTCompanyDetails = db.CompanyDetails.Grid().ToTable("CompanyDetails")
        DTsupplierBalance = db.GetSupplierBalanceledger(dtpFDate.Value.ToString(), dtpTDate.Value.ToString()).ToTable("SupplierBalanceLedger")
        'DTPurchaseDetails = db.GetpurchaseDetailswisereport(dtpFDate.Value.ToString(), dtpTDate.Value.ToString()).ToTable("PurchaseDetails")

        ds.Clear()
        'ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTsupplierBalance)
        ' ds.Tables.Add(DTPurchaseDetails)

        ReportView(CrystalReportViewer1, "LedgerReport\crySupplierBalanceLedger.rpt", ds)
    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
End Class