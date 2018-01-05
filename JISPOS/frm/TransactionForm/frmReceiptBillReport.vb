Public Class frmReceiptBillReport
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub
 
    Public Sub ViewSearch(ByVal code As String)

        Dim ds As New DataSet
        Dim DTReceiptBill As New DataTable()

        Dim WQry As String

        WQry = " ReceiptBillCode = '" + code + "'"

        DTReceiptBill = db.ReceiptBill.Grid("*", WQry, "ReceiptBillCode").ToTable("ReceiptBill")
        ds.Clear()
        ds.Tables.Add(DTReceiptBill)
        Dim MComName As String = GetMasterCompanyName()

        If MComName = "Run Sports" Then
            ReportView(CrystalReportViewer1, "Transaction\cryReceiptBill_RunSports.rpt", ds)
        ElseIf MComName = "Live Sports" Then
            ReportView(CrystalReportViewer1, "Transaction\cryReceiptBill.rpt", ds)
        End If

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("{ESCAPE}")
    End Sub

    Public Sub viewprint(ByVal Code As String)
        Dim ds As New DataSet

        Dim DTRcpt As New DataTable()
        DTRcpt = db.ReceiptBill.Grid("*", "ReceiptBillCode='" + Code + "'").ToTable("ReceiptBill")

        ds.Clear()

        ds.Tables.Add(DTRcpt)

        ReportView(CrystalReportViewer1, "Transaction\cryReceiptBill.rpt", ds)

    End Sub

End Class