Module Module1
    Public Stock_Opening As String = "'Products'"
    Public Stock_Inward As String = "'Purchase','ProccessReceipt','Opening Stock','SalesReturn'"
    Public Stock_Outward As String = "'Sales','ProccessIssue','PurchaseReturn'"

    Public CompName As String
    Public UserName As String
    Public UserType As String
    Public Sub dgvSetBackColor(ByVal dgv As DataGridView, Optional ByVal SColor As String = "StatusColor")
        Try
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Item("StatusColor", i).Value <> 0 Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgv.Item(SColor, i).Value.ToString()))
                Else
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Sub dgvSetE1BackColor(ByVal dgv As DataGridView, Optional ByVal SColor As String = "E1StatusColor")
        Try
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Item("E1StatusColor", i).Value <> 0 Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgv.Item(SColor, i).Value.ToString()))
                Else
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Function GetBillNo(ByVal JType As String, ByVal SupplierName As String) As ArrayList
        Try
            Dim RValue As New ArrayList
            Dim dv As DataView = GetBillInfo(JType, SupplierName)
            For i As Integer = 0 To dv.Count - 1
                RValue.Add(dv.Item(i)(0).ToString())
            Next
            Return RValue
        Catch e As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetBillInfo(ByVal JType As String, ByVal SupplierName As String) As DataView
        Dim Qry As String = ""
        If JType = "Payment" Then
            If SupplierName.Trim() <> "" Then SupplierName = " and (LFrom=N'" + SupplierName + "')"
            Qry = "SELECT Code, TotalAmount, PaidAmount, TotalAmount - PaidAmount AS BalanceAmount FROM (SELECT LReport2.RefNo AS Code, LReport2.DRAmount AS TotalAmount, ISNULL ((SELECT SUM(LReport1.CRAmount) AS Expr1 FROM LedgerReport AS LReport1 WHERE (LReport1.RefNo = LReport2.RefNo)), 0) AS PaidAmount FROM LedgerReport AS LReport2 WHERE (LTo = 'Credit')" + SupplierName + ") AS LReport where TotalAmount-PaidAmount>0"
            Return db.ExecuteQuery(Qry)
        Else
            If SupplierName.Trim() <> "" Then SupplierName = " and (LTo=N'" + SupplierName + "')"
            Qry = "SELECT Code, TotalAmount, PaidAmount, TotalAmount - PaidAmount AS BalanceAmount FROM (SELECT LReport2.RefNo AS Code, LReport2.CRAmount AS TotalAmount, ISNULL ((SELECT SUM(LReport1.DRAmount) AS Expr1 FROM LedgerReport AS LReport1 WHERE (LReport1.RefNo = LReport2.RefNo)), 0) AS PaidAmount FROM LedgerReport AS LReport2 WHERE (LFrom = 'Credit')" + SupplierName + ") AS LReport where TotalAmount-PaidAmount>0"
            Return db.ExecuteQuery(Qry)
        End If
    End Function

    Public Function AddLedger(ByVal LReportId As String, ByVal LReportCode As String, ByVal VoucherNo As String, ByVal VoucherType As String, ByVal LDate As String, ByVal LedgerName As String, ByVal Particulars As String, ByVal Narration As String, ByVal ACType As String, ByVal DRAmount As String, ByVal CRAmount As String, ByVal GroupName As String, ByVal PaymentDate As String, Optional ByVal LFrom As String = "", Optional ByVal LTo As String = "", Optional ByVal RefNo As String = "", Optional ByVal FU1 As String = "", Optional ByVal FU2 As String = "", Optional ByVal FU3 As String = "") As String
        Return db.LedgerReport.SaveRecord(LReportId, LReportCode, VoucherNo, VoucherType, LDate, LedgerName, Particulars, Narration, ACType, DRAmount, CRAmount, GroupName, PaymentDate, LFrom, LTo, RefNo, FU1, FU2, FU3)
    End Function
End Module
