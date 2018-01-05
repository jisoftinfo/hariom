Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmPendingBillParty
    Dim db As New DBLib

    'Private Sub frmINV_SalesReport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    btnSearch_Click(sender, e)
    'End Sub

    Private Sub frmINV_SalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmINV_SalesReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmINV_SalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()


        dtpFDate2.Value = New Date(dtpFDate2.Value.Year, dtpFDate2.Value.Month, dtpFDate2.Value.Day, 0, 0, 0)
        dtpTDate2.Value = New Date(dtpTDate2.Value.Year, dtpTDate2.Value.Month, dtpTDate2.Value.Day, 23, 59, 59)
        Dim SDate2 As String = dtpFDate2.Value.ToString()
        Dim EDate2 As String = dtpTDate2.Value.ToString()


        Dim WQry As String

        WQry = "MWCode not in (select MWCode from DebitNoteDetailsParty) and MillName<>''"

        If cbxPendingPeriod.Checked = True Then
            WQry += " and MWDate>=#" + SDate + "# and MWDate<=#" + EDate + "#"
        End If

        If cmbMillName.Text.Trim <> "" Then
            WQry += " and PartyName Like '"
            If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        dgvPending.DataSource = db.ViewMillWorking.Grid("PartyName,Sum(NoOfBags) as Bags,sum(TotalKg) as KG,sum(Amount) as Amount", WQry, "PartyName", "PartyName")


        If cbxBillPeriod.Checked = True Then
            WQry = "DNCode in (select DNCode from DebitNoteDetailsParty where MWCode in (select MWCode from millworking where MWDate>=#" + SDate2 + "# and MWDate<=#" + EDate2 + "#))"
        Else
            WQry = "DNCode in (select DNCode from DebitNoteDetailsParty)"
        End If

        If cmbMillName.Text.Trim <> "" Then
            WQry += " and MillName Like '"
            If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        s.DataSource = db.ViewDebitNoteParty.Grid("DNCode, CompanyName, MillName as PartyName, BillDate, FORMAT(PeridFrom, 'dd/MM/yyyy') + ' - ' + format(PeriodTo, 'dd/MM/yyyy') AS Period, iif(type='Amount' or type ='ExMillAmount',format(CommissionPer,'0.00')+'%',iif(type='Kg', Format(CommissionPer,'0/Kg'),Format(CommissionPer,'0/Bag'))) as CommissionPer, NoOfBags, TotalKg, Amount, ExMillAmount, CommissionAmt, TaxAmount, TotalAmount", WQry)

        s.Columns("DNCode").Width = 70
        s.Columns("CompanyName").Width = 200
        s.Columns("PartyName").Width = 300
        s.Columns("BillDate").Width = 90
        s.Columns("Period").Width = 150
        s.Columns("CommissionPer").Width = 50
        s.Columns("NoOfBags").Width = 50
        s.Columns("TotalKg").Width = 60
        s.Columns("Amount").Width = 80
        s.Columns("ExMillAmount").Width = 80
        s.Columns("CommissionAmt").Width = 90
        s.Columns("TaxAmount").Width = 60
        s.Columns("TotalAmount").Width = 90


        s.Columns("DNCode").HeaderText = "CODE"
        s.Columns("CompanyName").HeaderText = "COMPANY NAME"
        s.Columns("PartyName").HeaderText = "PARTY NAME"
        s.Columns("BillDate").HeaderText = "BILL DATE"
        s.Columns("CommissionPer").HeaderText = "COMM RATE"
        s.Columns("NoOfBags").HeaderText = "BAGS"
        s.Columns("TotalKg").HeaderText = "KG"
        s.Columns("Amount").HeaderText = "AMOUNT"
        s.Columns("ExMillAmount").HeaderText = "EX.MILL AMOUNT"
        s.Columns("CommissionAmt").HeaderText = "COMMISSION"
        s.Columns("TaxAmount").HeaderText = "SERVICE TAX"
        s.Columns("TotalAmount").HeaderText = "TOTAL AMOUNT"


        s.Columns("CommissionPer").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("NoOfBags").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("TotalKg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("ExMillAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("CommissionAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("TaxAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        s.Columns("TotalAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        s.Columns("BILLDATE").DefaultCellStyle.Format = "dd/MM/yyyy"


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMillName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbMillName.Name Then List_Datas(cmbMillName, db.Party.Column("PartyName"))
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMillName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        ExportDataGridView(dgvPending)
        Me.Enabled = True
    End Sub
    Sub ExportDataGridView(ByVal dgv As DataGridView)
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Int16, j As Int16

            xlApp = New Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            Dim CCol As Integer = 1

            For j = 0 To dgv.ColumnCount - 1
                If dgv.Columns(j).Visible = True Then
                    xlWorkSheet.Cells(1, CCol) = dgv.Columns(j).HeaderText
                    xlWorkSheet.Cells(1, CCol).ColumnWidth = dgv.Columns(j).Width / 10
                    xlWorkSheet.Cells(1, CCol).Font.Bold = True
                    CCol = CCol + 1
                End If
            Next

            For i = 0 To dgv.RowCount - 1
                CCol = 1
                For j = 0 To dgv.ColumnCount - 1
                    If dgv.Columns(j).Visible = True Then
                        If IsDate(dgv(j, i).Value) Then
                            xlWorkSheet.Cells(i + 2, CCol).value = String.Format("{0:dd/MM/yyyy}", dgv(j, i).Value)
                        Else
                            xlWorkSheet.Cells(i + 2, CCol).value = dgv(j, i).Value.ToString()
                        End If
                        dgvSetBackColor(dgvPending)
                        'xlWorkSheet.Cells(i + 2, CCol).Interior.Color = RGB(dgv.Rows(i).DefaultCellStyle.BackColor.R, dgv.Rows(i).DefaultCellStyle.BackColor.G, dgv.Rows(i).DefaultCellStyle.BackColor.B)

                        CCol = CCol + 1
                    End If

                Next
            Next
            xlWorkSheet.Cells.Borders.LineStyle = 1

            xlWorkBook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
             Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            If (MsgBox("Process completed, Would you like to open file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Process.Start(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

End Class