Public Class DBLib

    Inherits DBTBOBJ

    Sub New()
        MyBase.New()
    End Sub
    Public Function GetBankLedgerReport(ByVal SDate As String, ByVal EDate As String, ByRef CrAmt As Double, ByRef DrAmt As Double, ByVal Bank As String) As DataView


        Dim WQry As String = "LDate < '" + SDate + "' and FU1='" + Bank + "' "

        CrAmt = Val(db.LedgerReport.Data("sum(CrAmount)", WQry))
        DrAmt = Val(db.LedgerReport.Data("sum(DrAmount)", WQry))

        If CrAmt > DrAmt Then
            CrAmt = CrAmt - DrAmt
            DrAmt = 0
        Else
            DrAmt = DrAmt - CrAmt
            CrAmt = 0
        End If

        WQry = "LDate between '" + SDate + "'and '" + EDate + "' and FU1='" + Bank + "' "


        Return db.LedgerReport.Grid("*", WQry, "LDate")

    End Function
    Public Function GetSalesWiseBill(ByVal SDate As String, ByVal EDate As String, ByVal CustomerName As String) As DataView
        Dim Qry As String = ""

        If CustomerName.Trim() <> "" Then
            Qry = "select sales.salescode,sales.salesdate,sales.customername,sales.totalamount,isnull(sum(receiptdetails.amount),0)as Paidamount from sales join receiptdetails on sales.salescode=receiptdetails.refno where sales.salesdate between '" + SDate + "' and '" + EDate + "' and sales.customername=N'" + CustomerName + "' group by sales.salescode,sales.salesdate,sales.customername,sales.totalamount"
        End If
        Return ExecuteQuery(Qry)
    End Function
    Public Function GetCustomerBalanceledger(ByVal SDate As String, ByVal EDate As String) As DataView

        Dim Qry As String

        'Qry = "select Billingname,(Bbalance+Abalance)as salesBalance,(RBbalance+RAbalance)as receiptbalance,((Bbalance+Abalance)-(RBbalance+RAbalance))as Balance  from (select Billingname,isnull((select sum(totalamount) from sales where customername=customer.Billingname and ptype='Credit' and convert(varchar, convert(datetime, salesdate), 103) < '" + SDate + "'),0)as Bbalance,isnull((select sum(totalamount) from sales where customername=customer.Billingname and ptype='Credit' and  convert(varchar, convert(datetime, salesdate), 103) between '" + SDate + "' and '" + EDate + "'),0)as Abalance,isnull((select sum(receiptamount) from receipt where receiptname=customer.Billingname  and convert(varchar, convert(datetime, ReceiptDate), 103) < '" + SDate + "'),0)as RBbalance,isnull((select sum(receiptamount) from Receipt where receiptname=customer.Billingname and convert(varchar, convert(datetime, receiptDate), 103) between '" + SDate + "' and '" + EDate + "'),0)as RAbalance from customer)as balancegroup"
        Qry = "select Billingname,(Bbalance+Abalance)as salesBalance,(RBbalance+RAbalance)as receiptbalance,((Bbalance+Abalance)-(RBbalance+RAbalance))as Balance  from (select Billingname,isnull((select sum(totalamount) from sales where customername=customer.Billingname and stype='Credit' and salesdate < '" + SDate + "'),0)as Bbalance,isnull((select sum(totalamount) from sales where customername=customer.Billingname and stype='Credit' and  salesdate between '" + SDate + "' and '" + EDate + "'),0)as Abalance,isnull((select sum(receiptamount) from receipt where receiptname=customer.Billingname  and ReceiptDate < '" + SDate + "'),0)as RBbalance,isnull((select sum(receiptamount) from Receipt where receiptname=customer.Billingname and ReceiptDate between '" + SDate + "' and '" + EDate + "'),0)as RAbalance from customer)as balancegroup"


        Return ExecuteQuery(Qry)
    End Function
    Public Function GetDayBookLedgerReport(ByVal SDate As String, ByVal EDate As String, ByRef CrAmt As Double, ByRef DrAmt As Double) As DataView

        ' Dim WQry As String = "convert(varchar, convert(datetime, LDate), 103) < '" + SDate + "' and voucherType in ('purchase','payment','sales','Receipt') and Ledgername not in ('Round Off','CASH') "
        Dim WQry As String = "LDate < '" + SDate + "' and voucherType in ('purchase','payment','sales','Receipt') and Ledgername not in ('Round Off','CASH') and FU1 in ('Cash','')"
        'If LedgerNames.Trim() <> "" Then WQry = WQry + " and ledgername='" + LedgerNames + "'"
        CrAmt = Val(db.LedgerReport.Data("sum(CrAmount)", WQry))
        DrAmt = Val(db.LedgerReport.Data("sum(DrAmount)", WQry))

        If CrAmt > DrAmt Then
            CrAmt = CrAmt - DrAmt
            DrAmt = 0
        Else
            DrAmt = DrAmt - CrAmt
            CrAmt = 0
        End If

        WQry = "LDate between '" + SDate + "'and '" + EDate + "' and voucherType in ('purchase','payment','sales','Receipt') and Ledgername not in ('Round Off','CASH') and FU1 in ('Cash','')"
        'If LedgerNames.Trim() <> "" Then WQry = WQry + " and LedgerName='" + LedgerNames + "'"

        Return db.LedgerReport.Grid("*", WQry, "LDate")

    End Function
    Public Function GetPurchaseWiseBill(ByVal SDate As String, ByVal EDate As String, ByVal SupplierName As String) As DataView
        Dim Qry As String = ""

        If SupplierName.Trim() <> "" Then
            Qry = "select Purchasenew.pcode as purchasecode,Purchasenew.pdate as purcahsedate,Purchasenew.Psupname as suppliername,Purchasenew.Pamt as totalamount,isnull(sum(Paymentdetails.amount),0)as Paidamount from Purchasenew join Paymentdetails on Purchasenew.Pcode=Paymentdetails.refno where Purchasenew.Pdate   between '" + SDate + "' and '" + EDate + "' and Purchasenew.Psupname=N'" + SupplierName + "' group by Purchasenew.Pcode,Purchasenew.Pdate,Purchasenew.Psupname,Purchasenew.Pamt"
        End If
        Return ExecuteQuery(Qry)
    End Function
    Public Function GetSupplierBalanceledger(ByVal SDate As String, ByVal EDate As String) As DataView

        Dim Qry As String

        'Qry = "select Billingname,(Bbalance+Abalance)as purBalance,(PBbalance+PAbalance)as paybalance,((Bbalance+Abalance)-(PBbalance+PAbalance))as Balance  from (select Billingname,isnull((select sum(totalamount) from purchase where suppliername=supplier.Billingname and ptype='Credit' and convert(varchar, convert(datetime, purcahsedate), 103) < '" + SDate + "'),0)as Bbalance,isnull((select sum(totalamount) from purchase where suppliername=supplier.Billingname and ptype='Credit' and  convert(varchar, convert(datetime, purcahsedate), 103) between '" + SDate + "' and '" + EDate + "'),0)as Abalance,isnull((select sum(payamount) from payment where payname=supplier.Billingname and convert(varchar, convert(datetime, paymentDate), 103) < '" + SDate + "'),0)as PBbalance,isnull((select sum(Payamount) from payment where payname=supplier.Billingname and convert(varchar, convert(datetime, paymentDate), 103) between '" + SDate + "' and '" + EDate + "'),0)as PAbalance from supplier)as balancegroup"
        Qry = "select Billingname,(Bbalance+Abalance)as purBalance,(PBbalance+PAbalance)as paybalance,((Bbalance+Abalance)-(PBbalance+PAbalance))as Balance  from (select Billingname,isnull((select sum(totalamount) from purchase where suppliername=supplier.Billingname and ptype='Credit' and purcahsedate < '" + SDate + "'),0)as Bbalance,isnull((select sum(totalamount) from purchase where suppliername=supplier.Billingname and ptype='Credit' and  purcahsedate between '" + SDate + "' and '" + EDate + "'),0)as Abalance,isnull((select sum(payamount) from payment where payname=supplier.Billingname and paymentDate < '" + SDate + "'),0)as PBbalance,isnull((select sum(Payamount) from payment where payname=supplier.Billingname and paymentDate between '" + SDate + "' and '" + EDate + "'),0)as PAbalance from supplier)as balancegroup"

        Return ExecuteQuery(Qry)
    End Function
    Public Function GetLedgerReport(ByVal SDate As String, ByVal EDate As String, ByVal LedgerNames As String, ByRef CrAmt As Double, ByRef DrAmt As Double) As DataView

        Dim WQry As String = "LDate  <#" + SDate + "#"
        If LedgerNames.Trim() <> "" Then WQry = WQry + " and ledgername='" + LedgerNames + "'" Else WQry = WQry + " and ledgername='No Record'"

        CrAmt = Val(db.LedgerReport.Data("sum(CrAmount)", WQry))
        DrAmt = Val(db.LedgerReport.Data("sum(DrAmount)", WQry))

        If CrAmt > DrAmt Then
            CrAmt = CrAmt - DrAmt
            DrAmt = 0
        Else
            DrAmt = DrAmt - CrAmt
            CrAmt = 0
        End If

        WQry = "LDate between #" + SDate + "# and #" + EDate + "#"
        If LedgerNames.Trim() <> "" Then WQry = WQry + " and ledgername='" + LedgerNames + "'" Else WQry = WQry + " and ledgername='No Record'"

        Return db.LedgerReport.Grid("*", WQry, "LDate")

    End Function
    Public Function CashLedgerReport(ByVal SDate As String, ByVal EDate As String, ByVal LedgerNames As String, ByRef CrAmt As Double, ByRef DrAmt As Double) As DataView

        Dim WQry As String = "LDate  <'" + SDate + "'"
        If LedgerNames.Trim() <> "" Then WQry = WQry + " and FU1=N'" + LedgerNames + "'" Else WQry = WQry + " and FU1=N'No reocord'"

        CrAmt = Val(db.LedgerReport.Data("sum(CrAmount)", WQry))
        DrAmt = Val(db.LedgerReport.Data("sum(DrAmount)", WQry))

        If CrAmt > DrAmt Then
            CrAmt = CrAmt - DrAmt
            DrAmt = 0
        Else
            DrAmt = DrAmt - CrAmt
            CrAmt = 0
        End If

        WQry = "LDate between '" + SDate + "' and '" + EDate + "'"
        If LedgerNames.Trim() <> "" Then WQry = WQry + " and FU1=N'" + LedgerNames + "'" Else WQry = WQry + " and FU1=N'No reocord'"

        Return db.LedgerReport.Grid("*", WQry, "LDate")

    End Function
    Public Function GetsalesTotalAmount(ByVal SalesCode As String) As DataView
        Dim Qry As String

        Qry = "select (sales.totalAmount)- sum(Receiptdetails.Amount)as balanceAmount from Receiptdetails inner join sales on Receiptdetails.refno =sales.salescode where sales.salescode='" + SalesCode + "' group by sales.totalAmount"
        Return ExecuteQuery(Qry)
    End Function
End Class
