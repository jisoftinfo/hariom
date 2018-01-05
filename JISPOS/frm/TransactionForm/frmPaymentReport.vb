Public Class frmPaymentReport
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
        Dim DTPayment As New DataTable()
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

        WQry = "PaymentDate between  '" + SDate + "' And '" + EDate + "' and PayAmount>='" + BillAmtFrom.ToString() + "' and PayAmount<='" + BillAmtTo.ToString() + "'"

        If cmbPaymentTo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PaymentTo ='" + cmbPaymentTo.Text + "'"
        End If


        If cmbPayName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PayName ='" + cmbPayName.Text + "'"
        End If

        If cmbPayMode.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "paymentfrom='" + cmbPayMode.Text + "'"
        End If



        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        Dim OrderBy As String
        OrderBy = ""
        If cmbOrderBy.Text = "Pay Name" Then
            OrderBy = "PayName"
        ElseIf cmbOrderBy.Text = "Pay Amount" Then
            OrderBy = "PayAmount"
        ElseIf cmbOrderBy.Text = "Payment Date" Then
            OrderBy = "PaymentDate"
        End If

        If OrderBy <> "" And rbnDescending.Checked = True Then
            OrderBy += " desc"
        End If

        DTPayment = db.Payment.Grid("*", WQry, OrderBy).ToTable("Payment")
        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTPayment)
        ReportView(CrystalReportViewer1, "Transaction\cryPaymentReport.rpt", ds)

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Enter, txtBillAmountFrom.Enter, cmbPayName.Enter, cmbPayMode.Enter, cmbPaymentTo.Enter, cmbOrderBy.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name = cmbPayName.Name Then
            If cmbPaymentTo.Text = "Suppliers" Then
                List_Datas(cmbPayName, db.Mill.Column("MillName"))
            ElseIf cmbPaymentTo.Text = "Banks" Then
                List_Datas(cmbPayName, db.Banks.UserCodes())
            ElseIf cmbPaymentTo.Text = "Account Heads" Then
                List_Datas(cmbPayName, db.Ledger.Column("LedgerName", "not ledgername in (SELECT LedgerName FROM Customer UNION SELECT LedgerName FROM Supplier UNION SELECT LedgerName FROM Banks)"))
            ElseIf cmbPaymentTo.Text = "Customers" Then
                List_Datas(cmbPayName, db.Party.UserCodes("PartyName"))
            End If
        End If
        If sender.Name = cmbPayMode.Name Then
            cmbPayMode.Items.Clear()
            cmbPayMode.Items.Add("CASH")
            List_Datas(cmbPayMode, db.Banks.UserCodes(), True)
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Leave, txtBillAmountFrom.Leave, cmbPayName.Leave, cmbPayMode.Leave, cmbPaymentTo.Leave, cmbOrderBy.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub



End Class