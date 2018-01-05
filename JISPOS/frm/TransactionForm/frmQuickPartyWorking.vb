Public Class frmQuickPartyWorking
    Dim db As New DBLib

    Private Sub frmQuickSalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmQuickSalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub
    Public Sub viewprint(ByVal Code As String)
        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTSales As New DataTable()
        Dim DTSalesDetails As New DataTable()


        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")
        DTSales = db.PartyWorking.Grid("*", "PartyCode='" + Code + "'").ToTable("PartyWorking")
        DTSalesDetails = db.PartyWorkingDetails.Grid("*", "PartyCode='" + Code + "'").ToTable("PartyWorkingDetails")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTSales)
        ds.Tables.Add(DTSalesDetails)
        'Dim MComName As String = GetMasterCompanyName()

        'If CompName = "Run Sports" Then
        '    ReportView(CrystalReportViewer1, "Transaction\cryQuickSales_RunSports.rpt", ds)
        'ElseIf CompName = "Live Sports" Then
        '    ReportView(CrystalReportViewer1, "Transaction\cryQuickSales.rpt", ds)

        'ElseIf CompName = "Meen" Then
        ReportView(CrystalReportViewer1, "Transaction\cryQuickSales.rpt", ds)
        'End If


    End Sub
End Class