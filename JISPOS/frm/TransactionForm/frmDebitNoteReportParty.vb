Public Class frmDebitNoteReportParty

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
        TotAmt = db.DebitNoteParty.Data("Amount", "DNCode='" + frmPartyDebitNote.txtCode.Text + "'")
        TotalKg = db.DebitNoteParty.Data("TotalKg", "DNCode='" + frmPartyDebitNote.txtCode.Text + "'")
        NoOfBags = db.DebitNoteParty.Data("NoOfBags", "DNCode='" + frmPartyDebitNote.txtCode.Text + "'")
        Dim r As DataRow
        r = t.NewRow()
        r("DNCode") = frmPartyDebitNote.txtCode.Text
        r("MillName") = frmPartyDebitNote.cmbPartyName.Text
        r("BillingName") = "Party"
        r("Address") = frmPartyDebitNote.txtAddressLine.Text
        r("PeridFrom") = frmPartyDebitNote.dtpFDate.Value.ToString()
        r("PeriodTo") = frmPartyDebitNote.dtpTDate.Value.ToString()
        r("Amount") = frmPartyDebitNote.txtAmount.Text
        r("BillDate") = frmPartyDebitNote.dtpBillDate.Value.ToString()
        r("ExMillAmount") = frmPartyDebitNote.txtExMillAmt.Text
        r("CommissionPer") = frmPartyDebitNote.txtComPer.Text
        r("CommissionAmt") = frmPartyDebitNote.txtComAmt.Text
        r("TaxPer") = frmPartyDebitNote.cmbTaxPer.Text
        r("TaxAmount") = frmPartyDebitNote.txtTaxAmt.Text
        r("TotalAmount") = frmPartyDebitNote.txtTotalAmount.Text
        r("BillingName") = frmPartyDebitNote.txtBillingName.Text
        r("Type") = frmPartyDebitNote.cmbType.Text
        r("CompanyName") = frmPartyDebitNote.cmbCompany.Text
        r("TotalKg") = Val(TotalKg)
        r("NoOfBags") = Val(NoOfBags)
        r("TotAmt") = Val(TotAmt)
        r("ServiceTax") = frmPartyDebitNote.cmbTaxPer.Text
        t.Rows.Add(r)

        CompanyName = db.DebitNoteParty.Data("CompanyName", "DNCode='" + Code + "'")
        PanNo = db.CompanyInfo.Data("PanNo", "CompanyName='" + CompanyName + "'")

        DNT = db.DebitNoteDetailsParty.Grid("DNDId, DNDCode, DNCode, SNo, MWDate, Invoice, (select BillingName from MillWorking where MWCode=DebitNoteDetailsParty.MWCode) as PartyName,(select MillName from Mill where Millcode= (select MillName from MillWorking where MWCode=DebitNoteDetailsParty.MWCode) ) as MillName, NoOfBags, Weight, TotalKg, Rate, Amount, [Count], MWCode", "DNCode='" + frmPartyDebitNote.txtCode.Text + "'", "MWDate").ToTable("DebitNodeDetials")
        ds.Tables.Add(DNT)
        Dim PV As New Hashtable
        PV.Add("ComWord", "(RUPESSS " + Number_to_Word.numtoword(frmPartyDebitNote.txtComAmt.Text) + ")")
        PV.Add("AmountWord", "(RUPEES " + Number_to_Word.numtoword(frmPartyDebitNote.txtTotalAmount.Text) + ")")
        PV.Add("PanNo", PanNo)
        ReportView(CrystalReportViewer1, "InventoryReport\cryDebitNoteParty.rpt", ds, PV)

    End Sub
    Private Sub frmDebitNoteReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        frmPartyDebitNote.SearchCodeIndex -= 1
        If frmPartyDebitNote.SearchCodeIndex < 0 Then
            MsgDialog.ShowMsgDlg("Bill is Reached Begin", Me.Text, "I")
            frmPartyDebitNote.SearchCodeIndex = 0
        Else
            frmPartyDebitNote.txtSearchBox.Text = frmPartyDebitNote.Arr_SearchCodes(frmPartyDebitNote.SearchCodeIndex)
            frmPartyDebitNote.ViewForm()
            viewprint(frmPartyDebitNote.txtCode.Text)
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmPartyDebitNote.SearchCodeIndex += 1
        If frmPartyDebitNote.SearchCodeIndex >= frmPartyDebitNote.Arr_SearchCodes.Count Then
            MsgDialog.ShowMsgDlg("Bill is Reached Last", Me.Text, "I")
            frmPartyDebitNote.SearchCodeIndex = frmPartyDebitNote.Arr_SearchCodes.Count
        Else
            frmPartyDebitNote.txtSearchBox.Text = frmPartyDebitNote.Arr_SearchCodes(frmPartyDebitNote.SearchCodeIndex)
            frmPartyDebitNote.ViewForm()
            viewprint(frmPartyDebitNote.txtCode.Text)
        End If
    End Sub

End Class