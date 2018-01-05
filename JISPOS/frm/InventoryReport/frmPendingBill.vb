Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmPendingBill

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

        WQry = "MWCode not in (select MWCode from DebitNodeDetials) and MillName<>''"

        If cbxPendingPeriod.Checked = True Then
            WQry += " and MWDate>=#" + SDate + "# and MWDate<=#" + EDate + "#"
        End If

        If cmbMillName.Text.Trim <> "" Then
            WQry += " and MillName Like '"
            If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        dgvPending.DataSource = db.ViewMillWorking.Grid("MillName,Sum(NoOfBags) as Bags,sum(TotalKg) as KG,sum(Amount) as Amount", WQry, "millname", "MillName")


        If cbxBillPeriod.Checked = True Then
            WQry = "DNCode in (select DNCode from DebitnodeDetials where MWCode in (select MWCode from millworking where MWDate>=#" + SDate2 + "# and MWDate<=#" + EDate2 + "#))"
        Else
            WQry = "DNCode in (select DNCode from DebitnodeDetials)"
        End If

        If cmbMillName.Text.Trim <> "" Then
            WQry += " and MillName Like '"
            If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        dgvDetails.DataSource = db.ViewDebitNote.Grid("DNCode, CompanyName, MillName, BillDate, FORMAT(PeridFrom, 'dd/MM/yyyy') + ' - ' + format(PeriodTo, 'dd/MM/yyyy') AS Period, iif(type='Amount' or type ='ExMillAmount',format(CommissionPer,'0.00')+'%',iif(type='Kg', Format(CommissionPer,'0/Kg'),Format(CommissionPer,'0/Bag'))) as CommissionPer, NoOfBags, TotalKg, Amount, ExMillAmount, CommissionAmt, TaxAmount, TotalAmount", WQry)

        dgvDetails.Columns("DNCode").Width = 70
        dgvDetails.Columns("CompanyName").Width = 200
        dgvDetails.Columns("MillName").Width = 300
        dgvDetails.Columns("BillDate").Width = 90
        dgvDetails.Columns("Period").Width = 150
        dgvDetails.Columns("CommissionPer").Width = 50
        dgvDetails.Columns("NoOfBags").Width = 50
        dgvDetails.Columns("TotalKg").Width = 60
        dgvDetails.Columns("Amount").Width = 80
        dgvDetails.Columns("ExMillAmount").Width = 80
        dgvDetails.Columns("CommissionAmt").Width = 90
        dgvDetails.Columns("TaxAmount").Width = 60
        dgvDetails.Columns("TotalAmount").Width = 90


        dgvDetails.Columns("DNCode").HeaderText = "CODE"
        dgvDetails.Columns("CompanyName").HeaderText = "COMPANY NAME"
        dgvDetails.Columns("MillName").HeaderText = "MILL NAME"
        dgvDetails.Columns("BillDate").HeaderText = "BILL DATE"
        dgvDetails.Columns("CommissionPer").HeaderText = "COMM RATE"
        dgvDetails.Columns("NoOfBags").HeaderText = "BAGS"
        dgvDetails.Columns("TotalKg").HeaderText = "KG"
        dgvDetails.Columns("Amount").HeaderText = "AMOUNT"
        dgvDetails.Columns("ExMillAmount").HeaderText = "EX.MILL AMOUNT"
        dgvDetails.Columns("CommissionAmt").HeaderText = "COMMISSION"
        dgvDetails.Columns("TaxAmount").HeaderText = "SERVICE TAX"
        dgvDetails.Columns("TotalAmount").HeaderText = "TOTAL AMOUNT"


        dgvDetails.Columns("CommissionPer").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("NoOfBags").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("TotalKg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("ExMillAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("CommissionAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("TaxAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns("TotalAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dgvDetails.Columns("BILLDATE").DefaultCellStyle.Format = "dd/MM/yyyy"


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMillName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbMillName.Name Then List_Datas(cmbMillName, db.Mill.Column("MillName"))
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

    Private Sub pnlToolBar_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class