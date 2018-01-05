Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmMillWorkingSearch
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, cmbCustomerName.Enter, cmbBillingName.Enter, cmbPartyName.Enter, cmbStatus.Enter, cmbYear.Enter, cmbMonth.Enter, txtInvoice.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name = cmbCustomerName.Name Then
            List_Datas(cmbCustomerName, db.Mill.Column("MillName"))
        End If
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If
        If sender.name = cmbBillingName.Name Then
            List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, cmbCustomerName.Leave, cmbBillingName.Leave, cmbPartyName.Leave, cmbStatus.Leave, cmbYear.Leave, cmbMonth.Leave, txtInvoice.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        dgvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        'lblValue.Font = New System.Drawing.Font("Arial", 25.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'lblWords.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ViewSearch()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()

        'MsgBox(Year(Now) - 1 & " _ " & Year(Now))
        Dim SalesType As String = ""
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()
        Dim WQry As String
        WQry = ""
        If cbxPeriod.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry = "MWDate>=#" + SDate + "# and  MWDate<=#" + EDate + "# "
        End If
        If cmbStatus.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry = " Status='" + cmbStatus.Text + "' "
        End If

        If cmbCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += cmbCustomerName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        If cmbPartyName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " PartyName='" + cmbPartyName.Text + "'"
        End If

        If cmbBillingName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " BillingName='" + cmbBillingName.Text + "'"
        End If

        If cmbMonth.Text.Trim() <> "" Then
            Dim TmpSDate, TmpEDate As String
            If cmbMonth.Text.Trim() = "April" Then
                TmpSDate = "4/1/2015 12:00:00 AM"
                TmpEDate = "4/30/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "May" Then
                TmpSDate = "5/1/2015 12:00:00 AM"
                TmpEDate = "5/31/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "June" Then
                TmpSDate = "6/1/2015 12:00:00 AM"
                TmpEDate = "6/30/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "July" Then
                TmpSDate = "7/1/2015 12:00:00 AM"
                TmpEDate = "7/31/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "August" Then
                TmpSDate = "8/1/2015 12:00:00 AM"
                TmpEDate = "8/31/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "September" Then
                TmpSDate = "9/1/2015 12:00:00 AM"
                TmpEDate = "9/30/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "October" Then
                TmpSDate = "10/1/2015 12:00:00 AM"
                TmpEDate = "10/31/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "November" Then
                TmpSDate = "11/1/2015 12:00:00 AM"
                TmpEDate = "11/30/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "December" Then
                TmpSDate = "12/1/2015 12:00:00 AM"
                TmpEDate = "12/31/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "January" Then
                TmpSDate = "01/1/2016 12:00:00 AM"
                TmpEDate = "01/31/2016 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "February" Then
                TmpSDate = "02/1/2016 12:00:00 AM"
                TmpEDate = "02/29/2016 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "March" Then
                TmpSDate = "03/1/2016 12:00:00 AM"
                TmpEDate = "03/31/2016 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            End If

        End If

        If cmbYear.Text.Trim <> "" Then
            Dim TmpSDate, TmpEDate As String
            If cmbYear.Text.Trim() = "2015 - 2016" Then
                TmpSDate = "4/1/2015 12:00:00 AM"
                TmpEDate = "4/30/2016 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2014 - 2015" Then
                TmpSDate = "4/1/2014 12:00:00 AM"
                TmpEDate = "4/30/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2016 - 2017" Then
                TmpSDate = "4/1/2016 12:00:00 AM"
                TmpEDate = "4/30/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2017 - 2018" Then
                TmpSDate = "4/1/2017 12:00:00 AM"
                TmpEDate = "4/30/2018 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2018 - 2019" Then
                TmpSDate = "4/1/2018 12:00:00 AM"
                TmpEDate = "4/30/2019 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2019 - 2020" Then
                TmpSDate = "4/1/2019 12:00:00 AM"
                TmpEDate = "4/30/2020 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2021 - 2022" Then
                TmpSDate = "4/1/2021 12:00:00 AM"
                TmpEDate = "4/30/2022 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2022 - 2023" Then
                TmpSDate = "4/1/2022 12:00:00 AM"
                TmpEDate = "4/30/2023 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2023 - 2024" Then
                TmpSDate = "4/1/2023 12:00:00 AM"
                TmpEDate = "4/30/2024 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbYear.Text = "2024 - 2025" Then
                TmpSDate = "4/1/2024 12:00:00 AM"
                TmpEDate = "4/30/2025 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            End If
        End If


        If cmbYear.Text.Trim <> "" And cmbMonth.Text <> "" Then
            Dim TmpSDate, TmpEDate As String
            If cmbYear.Text = "2015 - 2016" Then
                If cmbMonth.Text.Trim() = "April" Then
                    TmpSDate = "4/1/2015 12:00:00 AM"
                    TmpEDate = "4/30/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "May" Then
                    TmpSDate = "5/1/2015 12:00:00 AM"
                    TmpEDate = "5/31/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "June" Then
                    TmpSDate = "6/1/2015 12:00:00 AM"
                    TmpEDate = "6/30/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "July" Then
                    TmpSDate = "7/1/2015 12:00:00 AM"
                    TmpEDate = "7/31/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "August" Then
                    TmpSDate = "8/1/2015 12:00:00 AM"
                    TmpEDate = "8/31/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "September" Then
                    TmpSDate = "9/1/2015 12:00:00 AM"
                    TmpEDate = "9/30/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "October" Then
                    TmpSDate = "10/1/2015 12:00:00 AM"
                    TmpEDate = "10/31/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "November" Then
                    TmpSDate = "11/1/2015 12:00:00 AM"
                    TmpEDate = "11/30/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "December" Then
                    TmpSDate = "12/1/2015 12:00:00 AM"
                    TmpEDate = "12/31/2015 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "January" Then
                    TmpSDate = "01/1/2016 12:00:00 AM"
                    TmpEDate = "01/31/2016 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "February" Then
                    TmpSDate = "02/1/2016 12:00:00 AM"
                    TmpEDate = "02/10/2016 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                ElseIf cmbMonth.Text.Trim() = "March" Then
                    TmpSDate = "3/1/2016 12:00:00 AM"
                    TmpEDate = "3/31/2016 11:59:59 PM"
                    If WQry <> "" Then WQry += " and "
                    WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
                End If
            End If
            
        End If

        If txtInvoice.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " Invoice='" + txtInvoice.Text + "' "
        End If

        Dim dv As DataView
        dv = db.ViewMillWorking.Grid("MWCode as Code, MWDate,Invoice, MillName, PartyName,BillingName,NoOfBags,Weight,TotalKg,Rate,Amount,count,StatusColor", WQry)
        dgvSearch.DataSource = dv
        dgvSearch.Columns("Code").Width = 70
        dgvSearch.Columns("Code").HeaderText = "CODE"
        dgvSearch.Columns("MWDate").Width = 70
        dgvSearch.Columns("MWDate").HeaderText = "DATE"
        dgvSearch.Columns("Invoice").Width = 70
        dgvSearch.Columns("Invoice").HeaderText = "INVOICE NO"
        dgvSearch.Columns("MillName").Width = 300
        dgvSearch.Columns("MillName").HeaderText = "MILL NAME"
        dgvSearch.Columns("PartyName").Width = 300
        dgvSearch.Columns("PartyName").HeaderText = "PARTY NAME"
        dgvSearch.Columns("BillingName").Width = 300
        dgvSearch.Columns("BillingName").HeaderText = "BILLING NAME"
        dgvSearch.Columns("NoOfBags").Width = 50
        dgvSearch.Columns("NoOfBags").HeaderText = "NO OF BAGS"
        dgvSearch.Columns("Weight").Width = 50
        dgvSearch.Columns("Weight").HeaderText = "WEIGHT"
        dgvSearch.Columns("TotalKg").Width = 50
        dgvSearch.Columns("TotalKg").HeaderText = "TOTAL KG"
        dgvSearch.Columns("Rate").Width = 50
        dgvSearch.Columns("Rate").HeaderText = "RATE"
        dgvSearch.Columns("Amount").Width = 100
        dgvSearch.Columns("Amount").HeaderText = "AMOUNT"
        dgvSearch.Columns("count").Width = 100
        dgvSearch.Columns("count").HeaderText = "COUNT"
        dgvSearch.Columns("StatusColor").Visible = False
        dgvSetBackColor(dgvSearch, "StatusColor")
        Dim TotalAmt As Long
        TotalAmt = Val(db.PartyWorking.Data("Sum(Amount)", WQry))
        If TotalAmt = 0 Then
            'lblValue.Text = ""
            'lblWords.Text = ""
        Else
            'lblValue.Text = "Rs. " & TotalAmt.ToString
            'lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If
        dgvSearch.Columns("MWDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim NoOfBag As Integer
        NoOfBag = 0
        Dim j As Integer = 0

        While (j < dgvSearch.RowCount)
            NoOfBag += Val(dgvSearch.Item("NoOfBags", j).Value)
            j = j + 1
            Application.DoEvents()
        End While

        txtTotalNoBag.Text = NoOfBag

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmMillWorking.txtSearchBox.Text = txtCode.Text
            frmMillWorking.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbSalesCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.TextChanged
        ViewSearch()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        ExportDataGridView(dgvSearch)
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
                        dgvSetBackColor(dgvSearch)
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

    Private Sub dgvSearch_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSearch.Sorted
        dgvSetBackColor(dgvSearch)
    End Sub

    Private Sub cmbCustomerName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCustomerName.KeyUp, cmbPartyName.KeyUp
        If sender.Name = cmbCustomerName.Name Then
            List_Datas(cmbCustomerName, db.Mill.Column("MillName", "MillName like '%" + sender.Text + "%'"))
        End If
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName", "PartyName like '%" + sender.Text + "%'"))
        End If
        If sender.name = cmbBillingName.Name Then
            List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
        End If
        sender.SelectionStart = sender.Text.Length + 1
    End Sub

    Private Sub dgvSearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSearch.SelectionChanged
        Try
            Dim tot As Long = 0
            For i As Integer = 0 To dgvSearch.SelectedCells.Count - 1
                If IsNumeric(dgvSearch.SelectedCells(i).Value) Then
                    tot = tot + dgvSearch.SelectedCells(i).Value
                End If
            Next
            lbTotal.Text = tot

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSearch.CheckedChanged
        If chkSearch.Checked = True Then
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            dgvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        End If
    End Sub
End Class