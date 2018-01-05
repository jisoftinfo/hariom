Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmPartyPaymentDebitNote

    Dim FNames() As String = {"TDSAmt", "TDSyr", "Status", "StatusColor", "Narration", "OpBal", "RDate1", "RAmt1", "RCNo1", "RDate2", "RAmt2", "RCNo2", "RDate3", "RAmt3", "RCNo3"}
    Dim FNamesDGV() As String = {"TDS", "TDSYr", "Status", "StatusColor", "Narration", "OpBal", "ClrDt1", "Amt1", "Chq1", "ClrDt2", "Amt2", "Chq2", "ClrDt3", "Amt3", "Chq3"}
    Dim FValues(FNames.Length - 1) As String

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
        dgvCustomerSearch.EditMode = DataGridViewEditMode.EditOnEnter
        dgvCustomerSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvCustomerSearch.AllowUserToResizeColumns = True
        ViewSearch()
    End Sub
    Sub ViewSearch()

        Dim WQry As String = ""
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()

        If cmbPartylName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName='" + cmbPartylName.Text + "'"
        End If

        If cmbCompanyName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "CompanyName='" + cmbCompanyName.Text + "'"
        End If

        If cmbStatus.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "Status='" + cmbStatus.Text + "'"
        End If


        If cbxPeriod.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry = "PeridFrom>=#" + SDate + "# and  PeridFrom<=#" + EDate + "# and PeriodTo>=#" + SDate + "# and PeriodTo<=#" + EDate + "#"
        End If

        Dim dv As New DataView
        dv = db.ViewDebitNoteParty.Grid("DNCode,FORMAT(BillDate, 'dd/MM/yyyy') as BillDate,MillName,CompanyName,FORMAT(PeridFrom, 'dd/MM/yyyy') + ' - ' + format(PeriodTo, 'dd/MM/yyyy') AS Period,iif(type='Amount' or type ='ExMillAmount',format(CommissionPer,'0.00')+'%',iif(type='Kg', Format(CommissionPer,'0.00/Kg'),Format(CommissionPer,'0/Bag'))) as CommissionPer,CommissionAmt as Comm,TaxAmount as Tax,TotalAmount as Total, TDSAmt as TDS,TotalAmount-TDSAmt as Bal,OpBal,(TotalAmount-TDSAmt)+OpBal as TotalBal, ((TotalAmount-TDSAmt)+OpBal)-RAmt1-RAmt2-RAmt3 as BalAmt,TDSYr,Status,iif(RAmt1=0,'',format(RDate1,'dd/MM/yyyy')) As ClrDt1,iif(RAmt1=0,'',RAmt1) As Amt1,RCNo1 as Chq1,iif(RAmt2=0,'',format(RDate2,'dd/MM/yyyy')) As ClrDt2,iif(RAmt2=0,'',RAmt2) As Amt2,RCNo2 as Chq2,iif(RAmt3=0,'',format(RDate3,'dd/MM/yyyy')) As ClrDt3,iif(RAmt3=0,'',RAmt3) As Amt3,RCNo3 as Chq3,StatusColor,Narration", WQry)

        'dgvCustomerSearch.DataSource = dv
        dgvCustomerSearch.Rows.Clear()
        For i As Integer = 0 To dv.Count - 1
            dgvCustomerSearch.Rows.Add()
            dgvCustomerSearch.Item("DNCode", i).Value = dv.Item(i)("DNCode").ToString()
            dgvCustomerSearch.Item("BillDate", i).Value = dv.Item(i)("BillDate").ToString()
            dgvCustomerSearch.Item("MillName", i).Value = dv.Item(i)("MillName").ToString()
            dgvCustomerSearch.Item("CompanyName", i).Value = dv.Item(i)("CompanyName").ToString()
            dgvCustomerSearch.Item("Year", i).Value = Now.Year & "-" & Now.Year + 1
            dgvCustomerSearch.Item("Period", i).Value = dv.Item(i)("Period").ToString()
            dgvCustomerSearch.Item("CommissionRate", i).Value = dv.Item(i)("CommissionPer").ToString()
            dgvCustomerSearch.Item("Commission", i).Value = dv.Item(i)("Comm").ToString()
            dgvCustomerSearch.Item("Tax", i).Value = dv.Item(i)("Tax").ToString()
            dgvCustomerSearch.Item("Total", i).Value = dv.Item(i)("Total").ToString()
            dgvCustomerSearch.Item("TDS", i).Value = dv.Item(i)("TDS").ToString()
            dgvCustomerSearch.Item("Bal", i).Value = dv.Item(i)("Bal").ToString()
            dgvCustomerSearch.Item("OpBal", i).Value = dv.Item(i)("OpBal").ToString()
            dgvCustomerSearch.Item("TotalBal", i).Value = dv.Item(i)("TotalBal").ToString()
            dgvCustomerSearch.Item("BalAmt", i).Value = dv.Item(i)("BalAmt").ToString()
            dgvCustomerSearch.Item("TDSYr", i).Value = dv.Item(i)("TDSYr").ToString()
            dgvCustomerSearch.Item("Status", i).Value = dv.Item(i)("Status").ToString()
            'dgvCustomerSearch.Item("ClrDt1", i).Value = dv.Item(i)("ClrDt1").ToString()
            If dv.Item(i)("ClrDt1").ToString() = "01/01/1990" Then
                dgvCustomerSearch.Item("ClrDt1", i).Value = ""
            Else
                dgvCustomerSearch.Item("ClrDt1", i).Value = dv.Item(i)("ClrDt1").ToString()
            End If
            dgvCustomerSearch.Item("Amt1", i).Value = dv.Item(i)("Amt1").ToString()
            dgvCustomerSearch.Item("Chq1", i).Value = dv.Item(i)("Chq1").ToString()
            dgvCustomerSearch.Item("ClrDt2", i).Value = dv.Item(i)("ClrDt2").ToString()
            dgvCustomerSearch.Item("Amt2", i).Value = dv.Item(i)("Amt2").ToString()
            dgvCustomerSearch.Item("Chq2", i).Value = dv.Item(i)("Chq2").ToString()
            dgvCustomerSearch.Item("ClrDt3", i).Value = dv.Item(i)("ClrDt3").ToString()
            dgvCustomerSearch.Item("Amt3", i).Value = dv.Item(i)("Amt3").ToString()
            dgvCustomerSearch.Item("Chq3", i).Value = dv.Item(i)("Chq3").ToString()
            dgvCustomerSearch.Item("StatusColor", i).Value = dv.Item(i)("StatusColor").ToString()
            dgvCustomerSearch.Item("Narration", i).Value = dv.Item(i)("Narration").ToString()
        Next


        dgvCustomerSearch.Columns("BillDate").DefaultCellStyle.Format = "dd/MM/yyyy"  

        For i As Integer = 0 To dgvCustomerSearch.Columns.Count - 1
            If FNamesDGV.Contains(dgvCustomerSearch.Columns(i).Name) Then
                dgvCustomerSearch.Columns(i).ReadOnly = False
            Else
                dgvCustomerSearch.Columns(i).ReadOnly = True
            End If

        Next
        dgvCustomerSearch.Columns("STATUS").ReadOnly = False
        dgvSetBackColor(dgvCustomerSearch)

        dgvDebitNoteSummery.DataSource = db.ViewDebitNoteParty.Grid("CompanyName,sum(CommissionAmt) as COMMISSION,sum(TaxAmount) as TAX,sum(TotalAmount) as AMOUNT", WQry, "CompanyName", "CompanyName")
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

    Private Sub CTRL_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartylName.Enter, cmbCompanyName.Enter, cmbStatus.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.name = cmbCompanyName.Name Then List_Datas(cmbCompanyName, db.CompanyInfo.Column("CompanyName"))
        If sender.name = cmbPartylName.Name Then List_Datas(cmbPartylName, db.Party.Column("PartyName"))

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartylName.Leave, cmbCompanyName.Leave, cmbStatus.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frmCustomerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Code As String
        Dim wqry As String

        ProgressBar1.Visible = True
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = dgvCustomerSearch.RowCount + 1
        For i As Integer = 0 To dgvCustomerSearch.Rows.Count - 1
            ProgressBar1.Value = i
            Application.DoEvents()
            Code = dgvCustomerSearch.Item("DNCode", i).Value.ToString()
            wqry = "DNCode ='" + Code + "'"

            For j As Integer = 0 To FNames.Length - 1
                FValues(j) = If(dgvCustomerSearch.Item(FNamesDGV(j), i).Value Is Nothing, "", dgvCustomerSearch.Item(FNamesDGV(j), i).Value)
                'FValues(j) = dgvCustomerSearch.Item(FNamesDGV(j), i).Value.ToString()
                If "RDate1,RDate2,RDate3".Contains(FNames(j)) Then
                    If Split(FValues(j), " ").Length > 0 Then
                        FValues(j) = Split(FValues(j), " ")(0)
                    End If
                    If Split(FValues(j), "/").Length = 3 Then
                        FValues(j) = (New Date(Split(FValues(j), "/")(2), Split(FValues(j), "/")(1), Split(FValues(j), "/")(0))).ToString()
                    Else
                        FValues(j) = "1/1/1990"
                    End If
                End If
            Next

            db.DebitNoteParty.Save(FNames, FValues, wqry)
        Next
        ProgressBar1.Visible = False
        MsgDialog.ShowMsgDlg("Saved", "Saved", "I")
    End Sub

    Private Sub dgvCustomerSearch_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomerSearch.CellEndEdit
        Try
            dgvCustomerSearch.Item("Bal", e.RowIndex).Value = Val(dgvCustomerSearch.Item("Total", e.RowIndex).Value.ToString()) - Val(dgvCustomerSearch.Item("TDS", e.RowIndex).Value.ToString())
            dgvCustomerSearch.Item("TotalBal", e.RowIndex).Value = Val(dgvCustomerSearch.Item("Bal", e.RowIndex).Value.ToString()) + Val(dgvCustomerSearch.Item("OpBal", e.RowIndex).Value.ToString())
            dgvCustomerSearch.Item("BalAmt", e.RowIndex).Value = Val(dgvCustomerSearch.Item("TotalBal", e.RowIndex).Value.ToString()) - (Val(dgvCustomerSearch.Item("Amt1", e.RowIndex).Value.ToString()) + Val(dgvCustomerSearch.Item("Amt2", e.RowIndex).Value.ToString()) + Val(dgvCustomerSearch.Item("Amt3", e.RowIndex).Value.ToString()))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgv_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvCustomerSearch.RowsAdded
        Try
            'sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(Val(sender.Item("StatusColor", e.RowIndex).Value.ToString()))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomerSearch.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Dim cdBox As New ColorDialog
            If cdBox.ShowDialog = Windows.Forms.DialogResult.OK Then
                sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = cdBox.Color
                sender.Item("StatusColor", e.RowIndex).Value = cdBox.Color.ToArgb
            End If
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        ExportDataGridView(dgvCustomerSearch)
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

    Private Sub dgvCustomerSearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.SelectionChanged
        Dim tot As Integer = 0
        For i As Integer = 0 To dgvCustomerSearch.SelectedCells.Count - 1
            If IsNumeric(dgvCustomerSearch.SelectedCells(i).Value) Then
                tot = tot + dgvCustomerSearch.SelectedCells(i).Value
            End If
        Next
        Label1.Text = tot
    End Sub

    Private Sub dgvCustomerSearch_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.Sorted
        dgvSetBackColor(dgvCustomerSearch)
    End Sub

    Private Sub cmbPartylName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPartylName.KeyUp, cmbCompanyName.KeyUp
        If sender.Name = cmbPartylName.Name Then
            List_Datas(cmbPartylName, db.Party.Column("PartyName", "PartyName like '%" + sender.Text + "%'"))
        End If
        If sender.name = cmbCompanyName.Name Then
            List_Datas(cmbCompanyName, db.CompanyInfo.Column("CompanyName", "CompanyName like '%" + sender.Text + "%'"))
        End If
        sender.SelectionStart = sender.Text.Length + 1
    End Sub

    Private Sub chkPartyPayment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPartyPayment.CheckedChanged
        If chkPartyPayment.Checked = True Then
            dgvCustomerSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            dgvCustomerSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        End If
    End Sub
End Class