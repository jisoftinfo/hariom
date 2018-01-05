Public Class frmReceiptReport
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
        ViewSearch()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()
        Dim ds As New DataSet
        Dim DTReceipt As New DataTable()
        Dim DTCompanyDetails As New DataTable()

        dtpBillDateFrom.Value = New Date(dtpBillDateFrom.Value.Year, dtpBillDateFrom.Value.Month, dtpBillDateFrom.Value.Day, 0, 0, 0)
        dtpBillDateTo.Value = New Date(dtpBillDateTo.Value.Year, dtpBillDateTo.Value.Month, dtpBillDateTo.Value.Day, 23, 59, 59)

        Dim PType As String = ""
        Dim SDate As String = dtpBillDateFrom.Value.ToString()
        Dim EDate As String = dtpBillDateTo.Value.ToString()

        Dim WQry As String

        Dim BillAmtFrom, BillAmtTo As Long
        BillAmtFrom = 0
        BillAmtTo = 99999999

        If txtBillAmountFrom.Text.Trim <> "" Then BillAmtFrom = Val(txtBillAmountFrom.Text)
        If txtBillAmountTo.Text.Trim <> "" Then BillAmtTo = Val(txtBillAmountTo.Text)

        WQry = "ReceiptDate between  '" + SDate + "' And '" + EDate + "' and ReceiptAmount>='" + BillAmtFrom.ToString() + "' and ReceiptAmount<='" + BillAmtTo.ToString() + "'"

        If cmbPaymentTo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptFrom ='" + cmbPaymentTo.Text + "'"
        End If


        If cmbReceiptName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "Fromm ='" + cmbReceiptName.Text + "'"
        End If

        If cmbReceiptMode.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptTo='" + cmbReceiptMode.Text + "'"
        End If


        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        Dim OrderBy As String
        OrderBy = ""
        If cmbOrderBy.Text = "Receipt Name" Then
            OrderBy = "Fromm"
        ElseIf cmbOrderBy.Text = "Receipt Amount" Then
            OrderBy = "ReceiptAmount"
        ElseIf cmbOrderBy.Text = "Receipt Date" Then
            OrderBy = "ReceiptDate"
        End If

        If OrderBy <> "" And rbnDescending.Checked = True Then
            OrderBy += " desc"
        End If

        DTReceipt = db.Receipt.Grid("*", WQry, OrderBy).ToTable("Receipt")
        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTReceipt)

        ReportView(CrystalReportViewer1, "Transaction\cryReceiptReport.rpt", ds)
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Enter, txtBillAmountFrom.Enter, cmbReceiptName.Enter, cmbReceiptMode.Enter, cmbPaymentTo.Enter, cmbOrderBy.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbReceiptName.Name Then
            If cmbPaymentTo.Text = "Suppliers" Then
                List_Datas(cmbReceiptName, db.Mill.Column("MillName"))
            ElseIf cmbPaymentTo.Text = "Banks" Then
                List_Datas(cmbReceiptName, db.Banks.UserCodes())
            ElseIf cmbPaymentTo.Text = "Account Heads" Then
                List_Datas(cmbReceiptName, db.Ledger.Column("LedgerName", "not ledgername in (SELECT LedgerName FROM Customer UNION SELECT LedgerName FROM Supplier UNION SELECT LedgerName FROM Banks)"))
            ElseIf cmbPaymentTo.Text = "Customers" Then
                List_Datas(cmbReceiptName, db.Party.Column("PartyName"))
            End If
        End If
        If sender.Name = cmbReceiptMode.Name Then
            cmbReceiptMode.Items.Clear()
            cmbReceiptMode.Items.Add("CASH")
            List_Datas(cmbReceiptMode, db.Banks.UserCodes(), True)
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Leave, txtBillAmountFrom.Leave, cmbReceiptName.Leave, cmbReceiptMode.Leave, cmbPaymentTo.Leave, cmbOrderBy.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

End Class