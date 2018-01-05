Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmDebitNoteSearch

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                If TypeOf ctl Is TextBox Then
                    Dim txt As TextBox = DirectCast(ctl, TextBox)
                    If txt.Multiline = True Then
                        If txt.Text.EndsWith(vbCrLf) Then
                            Me.SelectNextControl(ctl, True, True, True, True)
                        End If
                    Else
                        Me.SelectNextControl(ctl, True, True, True, True)
                    End If
                Else
                    Me.SelectNextControl(ctl, True, True, True, True)
                End If


            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If

    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = Chr(13) Then
            Dim ctl As Control = Me.ActiveControl
            If TypeOf ctl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctl, TextBox)
                If txt.Multiline = False Then e.KeyChar = ChrW(0)
            Else
                e.KeyChar = ChrW(0)
            End If
        End If

    End Sub


    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        Dim dv As New DataView
        ViewSearch()
    End Sub

    Sub ViewSearch()

        Dim WQry As String = ""
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()

        If cbxPeriod.Checked = True Then
            WQry = "PeridFrom>=#" + SDate + "# and  PeridFrom<=#" + EDate + "# and PeriodTo>=#" + SDate + "# and PeriodTo<=#" + EDate + "#"
        End If


        If cmbMillName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " MillName Like '"
            If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If cmbCompany.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "CompanyName Like '"
            If rbnSuffixCompany.Checked = True Or rbnInfixCompany.Checked = True Then WQry += "%"
            WQry += cmbCompany.Text
            If rbnPrefixCompany.Checked = True Or rbnInfixCompany.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If cmbQuarter.Text.Trim <> "" Then
            WQry += "BillQuarter='" + cmbQuarter.Text + "'"
        End If
        frmDebitTransaction.Arr_SearchCodes = db.ViewDebitNote.Column("DNCode", WQry)
        dgvDebitNoteMill.DataSource = db.ViewDebitNote.Grid("DNCode, CompanyName, MillName, BillDate, FORMAT(PeridFrom, 'dd/MM/yyyy') + ' - ' + format(PeriodTo, 'dd/MM/yyyy') AS Period, iif(type='Amount' or type ='ExMillAmount',format(CommissionPer,'0.00')+'%',iif(type='Kg', Format(CommissionPer,'0.00/Kg'),Format(CommissionPer,'0/Bag'))) as CommissionPer, NoOfBags, TotalKg, Amount, ExMillAmount, CommissionAmt, TaxAmount, TotalAmount", WQry)
        dgvDebitNoteMill.Columns("DNCode").Width = 70
        dgvDebitNoteMill.Columns("CompanyName").Width = 200
        dgvDebitNoteMill.Columns("MillName").Width = 300
        dgvDebitNoteMill.Columns("BillDate").Width = 90
        dgvDebitNoteMill.Columns("Period").Width = 150
        dgvDebitNoteMill.Columns("CommissionPer").Width = 50
        dgvDebitNoteMill.Columns("NoOfBags").Width = 50
        dgvDebitNoteMill.Columns("TotalKg").Width = 60
        dgvDebitNoteMill.Columns("Amount").Width = 80
        dgvDebitNoteMill.Columns("ExMillAmount").Width = 80
        dgvDebitNoteMill.Columns("CommissionAmt").Width = 90
        dgvDebitNoteMill.Columns("TaxAmount").Width = 60
        dgvDebitNoteMill.Columns("TotalAmount").Width = 90

        dgvDebitNoteMill.Columns("DNCode").HeaderText = "CODE"
        dgvDebitNoteMill.Columns("CompanyName").HeaderText = "COMPANY NAME"
        dgvDebitNoteMill.Columns("MillName").HeaderText = "MILL NAME"
        dgvDebitNoteMill.Columns("BillDate").HeaderText = "BILL DATE"
        dgvDebitNoteMill.Columns("CommissionPer").HeaderText = "COMM RATE"
        dgvDebitNoteMill.Columns("NoOfBags").HeaderText = "BAGS"
        dgvDebitNoteMill.Columns("TotalKg").HeaderText = "KG"
        dgvDebitNoteMill.Columns("Amount").HeaderText = "AMOUNT"
        dgvDebitNoteMill.Columns("ExMillAmount").HeaderText = "EX.MILL AMOUNT"
        dgvDebitNoteMill.Columns("CommissionAmt").HeaderText = "COMMISSION"
        dgvDebitNoteMill.Columns("TaxAmount").HeaderText = "SERVICE TAX"
        dgvDebitNoteMill.Columns("TotalAmount").HeaderText = "TOTAL AMOUNT"


        dgvDebitNoteMill.Columns("CommissionPer").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("NoOfBags").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("TotalKg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("ExMillAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("CommissionAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("TaxAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDebitNoteMill.Columns("TotalAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dgvDebitNoteMill.Columns("BILLDATE").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvDebitNoteSummery.DataSource = db.ViewDebitNote.Grid("CompanyName,sum(CommissionAmt) as COMMISSION,sum(TaxAmount) as TAX,sum(TotalAmount) as AMOUNT", WQry, "CompanyName", "CompanyName")
        dgvDebitNoteSummery.Columns("CompanyName").Width = 300
        dgvDebitNoteSummery.Columns("COMMISSION").Width = 100
        dgvDebitNoteSummery.Columns("TAX").Width = 100
        dgvDebitNoteSummery.Columns("AMOUNT").Width = 100

    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub CTRL_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuarter.Enter, cmbMillName.Enter, cmbCompany.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbMillName.Name Then List_Datas(cmbMillName, db.Mill.UserCodes())
        If sender.name = cmbCompany.Name Then List_Datas(cmbCompany, db.CompanyInfo.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbQuarter.Leave, cmbMillName.Leave, cmbCompany.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDebitNoteMill.DoubleClick
        Try
            frmDebitTransaction.txtSearchBox.Text = dgvDebitNoteMill.SelectedRows(0).Cells(0).Value()
            frmDebitTransaction.SearchCodeIndex = dgvDebitNoteMill.SelectedRows(0).Index
            frmDebitTransaction.btnSearch1_Click(sender, e)
            FormShow(frmDebitTransaction)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCustomerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        ExportDataGridView(dgvDebitNoteMill)
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

            For i = 0 To dgv.RowCount - 2
                CCol = 1
                For j = 0 To dgv.ColumnCount - 1
                    If dgv.Columns(j).Visible = True Then
                        If IsDate(dgv(j, i).Value) Then
                            xlWorkSheet.Cells(i + 2, CCol).value = String.Format("{0:dd/MM/yyyy}", dgv(j, i).Value)
                        Else
                            xlWorkSheet.Cells(i + 2, CCol).value = dgv(j, i).Value.ToString()
                        End If

                        xlWorkSheet.Cells(i + 2, CCol).Interior.Color = RGB(dgv.Rows(i).DefaultCellStyle.BackColor.R, dgv.Rows(i).DefaultCellStyle.BackColor.G, dgv.Rows(i).DefaultCellStyle.BackColor.B)

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

    Private Sub btnBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBill.Click
        btnBill.Enabled = False
        Try
            frmDebitTransaction.txtSearchBox.Text = dgvDebitNoteMill.SelectedRows(0).Cells(0).Value()
            frmDebitTransaction.SearchCodeIndex = 0
            frmDebitTransaction.btnSearch1_Click(sender, e)
            Dim f As New frmDebitNoteReport
            f.viewprint(frmDebitTransaction.txtCode.Text)
            'f.CrystalReportViewer1.RefreshReport()
            f.Show()
        Catch ex As Exception

        End Try
        btnBill.Enabled = True
    End Sub

    Private Sub cmbMillName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMillName.KeyUp, cmbCompany.KeyUp
        If sender.Name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName", "MillName like '%" + sender.Text + "%'"))
        End If
        If sender.name = cmbCompany.Name Then
            List_Datas(cmbCompany, db.CompanyInfo.Column("CompanyName", "CompanyName like '%" + sender.Text + "%'"))
        End If
        sender.SelectionStart = sender.Text.Length + 1
    End Sub
End Class

