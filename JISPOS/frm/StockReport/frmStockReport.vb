Public Class frmStockReport
    Dim db As New DBLib

    Private Sub frmINV_PurchaseReport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnSearch_Click(sender, e)
    End Sub

    Private Sub frmINV_PurchaseReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmINV_PurchaseReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmINV_PurchaseReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        cmbGroupName.Focus()


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()

        Dim Qry As String
        
        Qry = "SELECT  ProductName, OpeningInward - OpeningOutWard AS Opening, Inward, OutWard, OpeningInward - OpeningOutWard + Inward - OutWard AS Closing" _
                           & " FROM (SELECT  ProductName, " _
                           & " ISNULL((SELECT  SUM(Qunatity) AS Expr1 FROM     Stock AS Stock_0 WHERE  (Stock_0.ProductName = stock.ProductName) And (SDate <  '" + SDate + "') AND (VoucherType IN (" + Stock_Inward + "," + Stock_Opening + "))), 0) AS OpeningInward, " _
                           & " ISNULL((SELECT  SUM(Qunatity) AS Expr1 FROM     Stock AS Stock_1 WHERE  (Stock_1.ProductName = stock.ProductName) And (SDate <  '" + SDate + "') AND (VoucherType IN (" + Stock_Outward + "))), 0) AS OpeningOutWard, " _
                           & " ISNULL((SELECT  SUM(Qunatity) AS Expr1 FROM     Stock AS Stock_2 WHERE  (Stock_2.ProductName = stock.ProductName) And (SDate >= '" + SDate + "') AND (SDate <= '" + EDate + "') AND (VoucherType IN (" + Stock_Inward + "," + Stock_Opening + "))), 0) AS Inward, " _
                           & " ISNULL((SELECT  SUM(Qunatity) AS Expr1 FROM     Stock AS Stock_3 WHERE  (Stock_3.ProductName = stock.ProductName) And (SDate >= '" + SDate + "') AND (SDate <= '" + EDate + "') AND (VoucherType IN (" + Stock_Outward + "))), 0) AS OutWard" _
                           & " FROM stock where GroupName ='" + cmbGroupName.Text + "' or ProductName ='" + cmbItemName.Text + "' group by stock.productname) AS StockReport "
        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTStock As New DataTable()

        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")
        DTStock = JISDbTransaction.ExecuteQuery(Qry).ToTable("StockInven")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTStock)

        ReportView(CrystalReportViewer1, "StockReport\cryStockNew.rpt", ds)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Enter, dtpTDate.Enter, cmbNarration.Enter, cmbItemName.Enter, cmbGroupName.Enter

        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbItemName.Name Then List_Datas(cmbItemName, db.StockInwards.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
        If sender.name = cmbGroupName.Name Then List_Datas(cmbGroupName, db.Products.Column("GroupName"))
        If sender.name = cmbItemName.Name Then List_Datas(cmbItemName, db.Products.Column("ProductName", "GroupName='" + cmbGroupName.Text + "'"))

    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Leave, dtpTDate.Leave, cmbNarration.Leave, cmbItemName.Leave, cmbGroupName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frmINV_PurchaseReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub

    Private Sub dtpFDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFDate.ValueChanged

    End Sub
    Private Sub lblFDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFDate.Click

    End Sub
End Class