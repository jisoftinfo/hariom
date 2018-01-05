Public Class frmDebitNoteReport


    Private Sub frmQuickSalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Public Sub viewprint(ByVal Code As String)

        Dim ds As New DataSet
        Dim t As DataTable = ds.Tables.Add("DebitNote")
        Dim DNT As DataTable
        Dim CompanyName, PanNo As String

        t.Columns.Add("DNCode", System.Type.GetType("System.String"))
        t.Columns.Add("MillName", System.Type.GetType("System.String"))
        t.Columns.Add("BillingName", System.Type.GetType("System.String"))
        t.Columns.Add("Address", System.Type.GetType("System.String"))
        t.Columns.Add("PeridFrom", System.Type.GetType("System.DateTime"))
        t.Columns.Add("PeriodTo", System.Type.GetType("System.DateTime"))
        t.Columns.Add("BillDate", System.Type.GetType("System.DateTime"))
        t.Columns.Add("Amount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("ExMillAmount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("CommissionPer", System.Type.GetType("System.Decimal"))
        t.Columns.Add("CommissionAmt", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TaxPer", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TaxAmount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TotalAmount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("Type", System.Type.GetType("System.String"))
        t.Columns.Add("CompanyName", System.Type.GetType("System.String"))
        t.Columns.Add("TotalKg", System.Type.GetType("System.Decimal"))
        t.Columns.Add("NoOfBags", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TotAmt", System.Type.GetType("System.Decimal"))
        t.Columns.Add("ServiceTax", System.Type.GetType("System.Decimal"))

        Dim TotAmt, TotalKg, NoOfBags As String
        TotAmt = db.DebitNote.Data("Amount", "DNCode='" + Code + "'")
        TotalKg = db.DebitNote.Data("TotalKg", "DNCode='" + Code + "'")
        NoOfBags = db.DebitNote.Data("NoOfBags", "DNCode='" + Code + "'")

        CompanyName = db.DebitNote.Data("CompanyName", "DNCode='" + Code + "'")
        PanNo = db.CompanyInfo.Data("PanNo", "CompanyName='" + CompanyName + "'")


        Dim r As DataRow
        r = t.NewRow()
        r("DNCode") = Code
        r("MillName") = frmDebitTransaction.cmbMillName.Text
        r("BillingName") = "Mill"
        r("Address") = frmDebitTransaction.txtAddressLine.Text
        r("PeridFrom") = frmDebitTransaction.dtpFDate.Value.ToString()
        r("PeriodTo") = frmDebitTransaction.dtpTDate.Value.ToString()
        r("Amount") = frmDebitTransaction.txtAmount.Text
        r("BillDate") = frmDebitTransaction.dtpBillDate.Value.ToString()
        r("ExMillAmount") = frmDebitTransaction.txtExMillAmt.Text
        r("CommissionPer") = frmDebitTransaction.txtComPer.Text
        r("CommissionAmt") = frmDebitTransaction.txtComAmt.Text
        r("TaxPer") = frmDebitTransaction.cmbTaxPer.Text
        r("TaxAmount") = frmDebitTransaction.txtTaxAmt.Text
        r("TotalAmount") = frmDebitTransaction.txtTotalAmount.Text
        r("BillingName") = frmDebitTransaction.txtBillingName.Text
        r("Type") = frmDebitTransaction.cmbType.Text
        r("CompanyName") = frmDebitTransaction.cmbCompany.Text
        r("TotalKg") = frmDebitTransaction.txtTotalKg.Text
        r("NoOfBags") = frmDebitTransaction.txtNoOfBags.Text
        r("ServiceTax") = frmDebitTransaction.cmbTaxPer.Text
        r("TotalKg") = Val(TotalKg)
        r("NoOfBags") = Val(NoOfBags)
        r("TotAmt") = Val(TotAmt)

        t.Rows.Add(r)
        'DNT = db.DebitNodeDetials.Grid("DNDId, DNDCode, DNCode, SNo, MWDate, Invoice, (select partyname from party where partycode=(select PartyName from millworking where millworking.MWCode=DebitNodeDetials.MWCode)) as PartyName,'' as MillName, NoOfBags, Weight, TotalKg, Rate, Amount, [Count], MWCode", "DNCode='" + frmDebitTransaction.txtCode.Text + "'", "MWDate").ToTable("DebitNodeDetials")
        DNT = db.DebitNodeDetials.Grid("DNDId, DNDCode, DNCode, SNo, MWDate, Invoice, (select BillingName from millworking where millworking.MWCode=DebitNodeDetials.MWCode) as PartyName,'' as MillName, NoOfBags, Weight, TotalKg, Rate, Amount, [Count], MWCode", "DNCode='" + frmDebitTransaction.txtCode.Text + "'", "MWDate").ToTable("DebitNodeDetials")
        ds.Tables.Add(DNT)
        Dim PV As New Hashtable
        PV.Add("ComWord", "(RUPEES " + Number_to_Word.numtoword(frmDebitTransaction.txtComAmt.Text) + ")")
        PV.Add("AmountWord", "(RUPEES " + Number_to_Word.numtoword(frmDebitTransaction.txtTotalAmount.Text) + ")")
        PV.Add("PanNo", PanNo)
        ReportView(CrystalReportViewer1, "InventoryReport\cryDebitNote.rpt", ds, PV)

    End Sub

    Private Sub frmDebitNoteReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
        
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        frmDebitTransaction.SearchCodeIndex -= 1
        If frmDebitTransaction.SearchCodeIndex < 0 Then
            MsgDialog.ShowMsgDlg("Bill is Reached Begin", Me.Text, "I")
            frmDebitTransaction.SearchCodeIndex = 0
        Else
            frmDebitTransaction.txtSearchBox.Text = frmDebitTransaction.Arr_SearchCodes(frmDebitTransaction.SearchCodeIndex)
            frmDebitTransaction.ViewForm()
            viewprint(frmDebitTransaction.txtCode.Text)
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmDebitTransaction.SearchCodeIndex += 1
        If frmDebitTransaction.SearchCodeIndex >= frmDebitTransaction.Arr_SearchCodes.Count Then
            MsgDialog.ShowMsgDlg("Bill is Reached Last", Me.Text, "I")
            frmDebitTransaction.SearchCodeIndex = frmDebitTransaction.Arr_SearchCodes.Count
        Else
            frmDebitTransaction.txtSearchBox.Text = frmDebitTransaction.Arr_SearchCodes(frmDebitTransaction.SearchCodeIndex)
            frmDebitTransaction.ViewForm()
            viewprint(frmDebitTransaction.txtCode.Text)
        End If
    End Sub

End Class