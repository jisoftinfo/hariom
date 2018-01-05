Public Class frmPartyPaymentReport

    Private Sub frmPartyPaymentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)

    End Sub
    Sub ViewPrint(ByVal WQry As String)
        Dim ds As New DataSet
        Dim DTMillWorking As New DataTable()

        DTMillWorking = db.MillWorking.Grid("MWCode as 'Code',MWDate as 'Date',Invoice,MillName, PartyName,BillingName,NoOfBags as 'Bags',Count,Amount,(Amount-Recev0-Recev1-Recev2-Recev3) as Balance,(CASE WHEN RecevDate0='1/1/1990' THEN '' ELSE CONVERT(varchar(20),RecevDate0,103) END) as 'Recev Date1',Recev0 as 'Recev1',(CASE WHEN RecevDate1='1/1/1990' THEN '' ELSE CONVERT(varchar(20),RecevDate1,103) END) as 'Recev Date2',Recev1 as 'Recev2',(CASE WHEN RecevDate3='1/1/1990' THEN '' ELSE CONVERT(varchar(20),RecevDate3,103) END) as 'Recev Date3',Recev2 as 'Recev3',(CASE WHEN RecevDate3='1/1/1990' THEN '' ELSE CONVERT(varchar(20),RecevDate3,103) END) as 'Recev Date4',Recev3 as 'Recev4',Status", WQry, "MWCode").ToTable("MillWorking1")
        ds.Clear()
        ds.Tables.Add(DTMillWorking)

        ReportView(CrystalReportViewer1, "InventoryReport\cryMillWorkingExport.rpt", ds)
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
End Class