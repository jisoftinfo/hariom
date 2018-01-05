Public Class frmPartyWorkingReport
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtTotalAmountTo.Enter, txtTotalAmountFrom.Enter, cmbCustomerName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name = cmbCustomerName.Name Then
            List_Datas(cmbCustomerName, db.Party.Column("PartyName"))
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtTotalAmountTo.Leave, txtTotalAmountFrom.Leave, cmbCustomerName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
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
        Dim DTSales As New DataTable()
        dtpOrderDateFrom.Value = New Date(dtpOrderDateFrom.Value.Year, dtpOrderDateFrom.Value.Month, dtpOrderDateFrom.Value.Day, 0, 0, 0)
        dtpOrderDateTo.Value = New Date(dtpOrderDateTo.Value.Year, dtpOrderDateTo.Value.Month, dtpOrderDateTo.Value.Day, 23, 59, 59)

        Dim SalesType As String = ""
        Dim SDate As String = dtpOrderDateFrom.Value.ToString()
        Dim EDate As String = dtpOrderDateTo.Value.ToString()

        Dim WQry As String

        Dim TotalAmtFrom, TotalAmtTo As Long
        TotalAmtFrom = 0
        TotalAmtTo = 99999999

        If txtTotalAmountFrom.Text.Trim <> "" Then TotalAmtFrom = Val(txtTotalAmountFrom.Text)
        If txtTotalAmountTo.Text.Trim <> "" Then TotalAmtTo = Val(txtTotalAmountTo.Text)

        WQry = "SalesDate between  '" + SDate + "' And '" + EDate + "' and TotalAmount>='" + TotalAmtFrom.ToString() + "' and TotalAmount<='" + TotalAmtTo.ToString() + "'"

        If cmbCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "CustomerName Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += cmbCustomerName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If rbnCash.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry += "SalesType = 'cash' "

        End If
        If rbnCredit.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry += "SalesType != 'cash' "

        End If
        DTSales = db.PartyWorking.Grid("*", WQry, "SalesCode").ToTable("Sales")
        ds.Clear()
        ds.Tables.Add(DTSales)
        ReportView(CrystalReportViewer1, "Transaction\crySalesView.rpt", ds)

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

End Class