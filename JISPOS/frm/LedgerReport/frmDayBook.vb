Public Class frmDayBook
    Dim db As New DBLib

    Private Sub frmDayBook_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmDayBook_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmDayBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
        btnSearch.Focus()
        'dtpFDate.Format = DateTimePickerFormat.Custom
        'dtpFDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim ds As New DataSet
        'Dim DTCompanyDetails As New DataTable()
        Dim DTLedgerReport As New DataTable()

        Dim CrAmt, DrAmt As Double
        CrAmt = 0
        DrAmt = 0
        'If cmbLedgerName.Text.Trim() = "" Then cmbLedgerName.Text = " "
        'DTCompanyDetails = db.CompanyDetails.Grid().ToTable("CompanyDetails")
        DTLedgerReport = db.GetDayBookLedgerReport(dtpFDate.Value.ToString(), dtpTDate.Value.ToString(), CrAmt, DrAmt).ToTable("LedgerReport")

        ds.Clear()
        'ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTLedgerReport)

        Dim ParameterValues As New Hashtable()
        ParameterValues.Clear()
        ParameterValues.Add("CrOpBal", CrAmt)
        ParameterValues.Add("DrOpBal", DrAmt)
        ParameterValues.Add("FromDate", dtpFDate.Value.ToString("dd/MM/yyyy"))


        ReportView(CrystalReportViewer1, "LedgerReport\cryDayBook.rpt", ds, ParameterValues)
    End Sub
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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Enter, dtpTDate.Enter, cmbLedgerName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
        If sender.Name = cmbLedgerName.Name Then List_Datas(cmbLedgerName, db.Supplier.UserCodes())

    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Leave, dtpTDate.Leave, cmbLedgerName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub txtLedgerType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLedgerType.TextChanged
        If txtLedgerType.Text.ToLower() = "cash" Then
            lblLedgerName.Visible = False
            cmbLedgerName.Visible = False
            cmbLedgerName.Text = "Cash"
        Else
            lblLedgerName.Visible = True
            cmbLedgerName.Visible = True
            cmbLedgerName.Text = ""
            lblLedgerName.Text = txtLedgerType.Text + " Name"
        End If
    End Sub

    Private Sub dtpFDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFDate.ValueChanged
        dtpTDate.Value = dtpFDate.Value.ToString()

    End Sub
End Class