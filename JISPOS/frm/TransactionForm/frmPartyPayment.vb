
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq


Public Class frmPartyPayment
    
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
        dgvSearch.Columns("SMSSelect").Visible = False
        dgvSearch.ClearSelection()
        dgvSearch.EditMode = DataGridViewEditMode.EditOnEnter
        'ViewSearch()
    End Sub

    Sub ViewSearch()
        dgvSearch.ClearSelection()
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
            ElseIf cmbMonth.Text.Trim() = "March" Then
                TmpSDate = "3/1/2015 12:00:00 AM"
                TmpEDate = "3/31/2015 11:59:59 PM"
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
                TmpSDate = "01/1/2015 12:00:00 AM"
                TmpEDate = "01/31/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "February" Then
                TmpSDate = "02/1/2015 12:00:00 AM"
                TmpEDate = "02/10/2015 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MWDate>=#" + TmpSDate + "# and  MWDate<=#" + TmpEDate + "# "
            End If

        End If


        If cmbYear.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " [Year]='" + cmbYear.Text + "' "
        End If

        If cmbStatus.Text.Trim <> "" And cmbStatus.Text <> "Due Date" Then
            If WQry <> "" Then WQry += " and "
            WQry += " Status='" + cmbStatus.Text + "' "
        End If

        If cmbCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName Like '%"
            WQry += cmbCustomerName.Text

            WQry += "%'"
        End If
        If cmbPartyName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " PartyName Like '%" + cmbPartyName.Text + "%'"
        End If

        If cmbBillingName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " BillingName Like '%" + cmbBillingName.Text + "%'"
        End If


        Dim dv As DataView
        dv = db.ViewMillWorking.Grid("MWCode as Code,'1/1/1900'as DueDate,MWDate,Invoice,PartyName,BillingName,MillName, NoOfBags as Bags,Count,Amount,(Amount-Recev0-Recev1-Recev2-Recev3) as Balance,Status,Format(RecevDate0,'dd/MM/yyyy') as RecevDate0,Recev0,Format(RecevDate1,'dd/MM/yyyy') as RecevDate1,Recev1,Format(RecevDate2,'dd/MM/yyyy') as RecevDate2,Recev2,Format(RecevDate3,'dd/MM/yyyy')as RecevDate3,Recev3,Narration,StatusColor", WQry)
        dgvSearch.DataSource = dv

        dgvSearch.AllowUserToResizeColumns = True
        dgvSearch.Columns("MillName").HeaderText = "Mill Name"
        dgvSearch.Columns("PartyName").HeaderText = "Party Name"
        dgvSearch.Columns("BillingName").HeaderText = "Billing Name"
        dgvSearch.Columns("MWDate").HeaderText = "Invoice Date"
        dgvSearch.Columns("RecevDate0").HeaderText = "Date"
        dgvSearch.Columns("RecevDate1").HeaderText = "Date"
        dgvSearch.Columns("RecevDate2").HeaderText = "Date"
        dgvSearch.Columns("Recev0").HeaderText = "Amount"
        dgvSearch.Columns("Recev1").HeaderText = "Amount"
        dgvSearch.Columns("Recev2").HeaderText = "Amount"
        dgvSearch.Columns("RecevDate3").Visible = False
        dgvSearch.Columns("Recev3").Visible = False

        dgvSearch.Columns("Code").Width = 100
        dgvSearch.Columns("MWDate").Width = 100
        dgvSearch.Columns("Invoice").Width = 70
        dgvSearch.Columns("MillName").Width = 200
        dgvSearch.Columns("PartyName").Width = 200
        dgvSearch.Columns("BillingName").Width = 200
        dgvSearch.Columns("Bags").Width = 50
        dgvSearch.Columns("Status").Width = 70
        dgvSearch.Columns("Count").Width = 70
        dgvSearch.Columns("Amount").Width = 100
        dgvSearch.Columns("Narration").Width = 250
        dgvSearch.Columns("SMSSelect").Width = 60
        dgvSearch.Columns("SMSSelect").Visible = True
        dgvSearch.Columns("SMSSelect").DisplayIndex = 12
        'dgvSearch.Columns("Invoice").Width = 100
        dgvSearch.Columns("Code").ReadOnly = True
        dgvSearch.Columns("MillName").ReadOnly = True
        dgvSearch.Columns("PartyName").ReadOnly = True
        dgvSearch.Columns("BillingName").ReadOnly = True
        dgvSearch.Columns("Bags").ReadOnly = True
        dgvSearch.Columns("Amount").ReadOnly = True
        dgvSearch.Columns("StatusColor").Visible = False


        Dim MName As String
        Dim status As String
        Dim DueDay As Integer
        Dim mwdate As Date
        Dim dueDate As Date

        Dim TotAmt, RegAmt, BalAmt As Integer
        TotAmt = 0
        RegAmt = 0
        ProgressBar1.Visible = True
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = dgvSearch.RowCount + 1
        Dim i As Integer = 0
        While (i < dgvSearch.RowCount)
            MName = dgvSearch.Item("MillName", i).Value.ToString()
            status = dgvSearch.Item("Status", i).Value.ToString()
            mwdate = dgvSearch.Item("MWDate", i).Value.ToString()
            DueDay = Val(db.Mill.Data("DueDays", "MillName='" + MName + "'"))
            dueDate = DateAdd(DateInterval.Day, DueDay, mwdate)
            If cmbStatus.Text = "Due Date" Then
                If Not (dueDate < Now And status = "P") Then
                    dgvSearch.Rows.RemoveAt(i)
                    Continue While
                End If
            End If
            dgvSearch.Item("DueDate", i).Value = String.Format("{0:dd/MM/yyyy}", dueDate)
            If dgvSearch.Item("Recev1", i).Value = 0 Then
                dgvSearch.Item("RecevDate1", i).Value = ""
            End If
            If dgvSearch.Item("Recev2", i).Value = 0 Then
                dgvSearch.Item("RecevDate2", i).Value = ""
            End If
            If dgvSearch.Item("Recev3", i).Value = 0 Then
                dgvSearch.Item("RecevDate3", i).Value = ""
            End If
            If dgvSearch.Item("Recev0", i).Value = 0 Then
                dgvSearch.Item("RecevDate0", i).Value = ""
            End If
            TotAmt += Val(dgvSearch.Item("Amount", i).Value)
            BalAmt += Val(dgvSearch.Item("Balance", i).Value)
            dgvSearch.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgvSearch.Item("StatusColor", i).Value.ToString()))
            'dgvSearch.Columns("Balance").DefaultForeColor = Color.Red
            dgvSearch.Rows(i).Cells("Balance").Style.ForeColor = Color.Red
            i = i + 1
            ProgressBar1.Value += 1
            Application.DoEvents()
        End While
        ProgressBar1.Visible = False
        RegAmt = TotAmt - BalAmt

        txtTotalAmount.Text = TotAmt
        txtReceivAmount.Text = RegAmt
        txtBalance.Text = BalAmt
        dgvSearch.Columns("MWDate").DefaultCellStyle.Format = "dd/MM/yyyy"
       dgvSearch.Columns("StatusColor").Visible = False
       dgvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect

        dgvSearch.Columns("DueDate").DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub CTRL_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBillingName.Enter, cmbCustomerName.Enter, cmbMonth.Enter, cmbPartyName.Enter, cmbYear.Enter, cmbStatus.Enter
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
    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.Leave, cmbCustomerName.Leave, cmbBillingName.Leave, cmbPartyName.Leave, cmbYear.Leave, cmbStatus.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub
    Private Sub frmProductsearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim FNames() As String = {"Status", "RecevDate0", "Recev0", "RecevDate1", "Recev1", "RecevDate2", "Recev2", "RecevDate3", "Recev3", "Narration", "StatusColor"}
        Dim FValues() As String = {"", "", "", "", "", "", "", "", "", "", ""}
        Dim Code As String
        Dim wqry As String

        ProgressBar1.Visible = True
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = dgvSearch.RowCount + 1
        For i As Integer = 0 To dgvSearch.Rows.Count - 1
            ProgressBar1.Value = i
            Application.DoEvents()
            Code = dgvSearch.Item("Code", i).Value.ToString()
            wqry = "MWCode ='" + Code + "'"

            For j As Integer = 0 To FNames.Length - 1
                FValues(j) = dgvSearch.Item(12 + j, i).Value.ToString()
                If FNames(j) = "RecevDate0" Or FNames(j) = "RecevDate1" Or FNames(j) = "RecevDate2" Or FNames(j) = "RecevDate3" Then
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

            db.MillWorking.Save(FNames, FValues, wqry)
        Next
        ProgressBar1.Visible = False
        MsgDialog.ShowMsgDlg("Saved", "Saved", "I")
        ' ViewSearch()
    End Sub

    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        dgvSearch.Columns("SMSSelect").Visible = False
        ExportDataGridView(dgvSearch)
        Me.Enabled = True
        dgvSearch.Columns("SMSSelect").Visible = True
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


    Private Sub dgvSearch_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim cdBox As New ColorDialog
            If cdBox.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgvSearch.Rows(e.RowIndex).DefaultCellStyle.BackColor = cdBox.Color
                dgvSearch.Item("StatusColor", e.RowIndex).Value = cdBox.Color.ToArgb
            End If
        End If
    End Sub

    Private Sub dgvSearch_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearch.ColumnHeaderMouseClick
        For i As Integer = 0 To dgvSearch.RowCount - 1
            dgvSearch.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgvSearch.Item("StatusColor", i).Value.ToString()))
        Next
    End Sub

    Public Class SMSMSG
        Public InvoiceDate As Date
        Public Balance As Double
        Public PhNo As String
        Public MillName As String
        Public BillingName As String
        Public CPerson As String
        Public PDepartment As String
        Sub New(ByVal InvDate As Date, ByVal BalAmt As Double, ByVal PhoneNo As String, ByVal MName As String, ByVal BName As String, ByVal Person As String, ByVal PDept As String)
            InvoiceDate = InvDate
            Balance = BalAmt
            PhNo = PhoneNo
            MillName = MName
            BillingName = BName
            CPerson = Person
            PDepartment = PDept
        End Sub
    End Class

    Private Sub btnSMSSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSSend.Click
        
        Dim PartyName, BillingName, MillName, PhNo, Msg, InvoiceDate, Balance, MillCode, PShortName, MShortName, CPerson, PDept As String

        Dim SMSList As New List(Of SMSMSG)
        Dim smsMsg As SMSMSG
        Dim webClient As New System.Net.WebClient
        Dim SMSURL As String
        Dim result As String

        For i As Integer = 0 To dgvSearch.RowCount - 1

            If dgvSearch.Item("SMSSelect", i).Value = True Then
                PartyName = dgvSearch.Item("PartyName", i).Value.ToString()
                BillingName = dgvSearch.Item("BillingName", i).Value.ToString()
                MillCode = dgvSearch.Item("Code", i).Value.ToString()
                MillName = dgvSearch.Item("MillName", i).Value.ToString()
                MShortName = db.Mill.Data("ShortName", "MillName='" + MillName + "'").ToLower
                PhNo = db.Party.Data("PMobile1", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                PShortName = db.Party.Data("ShortName", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'").ToLower
                CPerson = db.Party.Data("Person1", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'").ToLower
                'InvoiceDate = String.Format("{0:dd.MM}", dgvSearch.Item("MWDate", i).Value)
                InvoiceDate = dgvSearch.Item("MWDate", i).Value
                Balance = dgvSearch.Item("Balance", i).Value.ToString()
                Msg = String.Format("{0}-{1}{2}{3} -  {4}", PShortName, MShortName, vbCrLf, InvoiceDate, Balance)
                If PhNo.Trim() <> "" Then
                    smsMsg = New SMSMSG(InvoiceDate, Balance, PhNo, MillName, BillingName, CPerson, PDept)
                    SMSList.Add(smsMsg)
                End If

                'SMSURL = String.Format("http://enterprise.liveair.in/httpapi/httpapi?token=a511a63dbdbf7402f979368e55dad627&sender={0}&number={1}&route={2}&type={3}&sms={4}", "hariom", PhNo, "2", "1", Msg)

                'result = webClient.DownloadString(SMSURL)

                'If result Then
                'MsgBox("Message Sending Successfully")
                'End If

            End If

        Next

        Dim BillingNameLst = From sms In SMSList Group By BName = sms.BillingName, MName = sms.MillName Into RegionalSMS = Group Select BName, MName, RegionalSMS

        Dim PhoneNo, PMsg As String

        For Each PartyPayment In BillingNameLst
            PMsg = String.Format("{0}-{1}{2}", PartyPayment.BName, PartyPayment.MName, vbCrLf)
            PhoneNo = PartyPayment.RegionalSMS.FirstOrDefault().PhNo
            For Each sms In PartyPayment.RegionalSMS
                PMsg += String.Format("{0:dd.MM}-{1}{2}", sms.InvoiceDate, sms.Balance, vbCrLf)
            Next
            SMSURL = String.Format("http://enterprise.liveair.in/httpapi/httpapi?token=a511a63dbdbf7402f979368e55dad627&sender={0}&number={1}&route={2}&type={3}&sms={4}", "hariom", PhoneNo, "2", "1", PMsg)

            result = webClient.DownloadString(SMSURL)
        Next

    End Sub

    Private Sub dgvSearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSearch.SelectionChanged
        Try
            Dim tot As Long = 0
            For i As Integer = 0 To dgvSearch.SelectedCells.Count - 1
                If IsNumeric(dgvSearch.SelectedCells(i).Value) Then
                    tot = tot + dgvSearch.SelectedCells(i).Value
                End If
            Next
            Label1.Text = tot
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellEndEdit
        Dim ColName As String
        ColName = dgvSearch.Columns(e.ColumnIndex).Name
        If ColName = "Recev0" Or ColName = "Recev1" Or ColName = "Recev2" Then
            Dim amt, amt1, amt2, amt3 As Single

            If dgvSearch.Item("Amount", e.RowIndex).Value Is Nothing Then
                amt = 0
            Else
                amt = Val(dgvSearch.Item("Amount", e.RowIndex).Value.ToString())
            End If

            If dgvSearch.Item("Recev0", e.RowIndex).Value Is Nothing Then
                amt1 = 0
            Else
                amt1 = Val(dgvSearch.Item("Recev0", e.RowIndex).Value.ToString())
            End If

            If dgvSearch.Item("Recev1", e.RowIndex).Value Is Nothing Then
                amt2 = 0
            Else
                amt2 = Val(dgvSearch.Item("Recev1", e.RowIndex).Value.ToString())
            End If

            If dgvSearch.Item("Recev2", e.RowIndex).Value Is Nothing Then
                amt3 = 0
            Else
                amt3 = Val(dgvSearch.Item("Recev2", e.RowIndex).Value.ToString())
            End If
            dgvSearch.Item("Balance", e.RowIndex).Value = amt - (amt1 + amt2 + amt3)
        End If
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

    Private Sub btnSMSDraft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSDraft.Click
        Dim PartyName, BillingName, MillName, PhNo, PhNo1, PhNo2, PhNo3, MobileNo, Msg, InvoiceDate, Balance, MillCode, PShortName, MShortName As String
        Dim Person1, Person2, Person3, Person4, ContactPerson As String
        Dim Department1, Department2, Department3, Department4, PartyDept As String

        Dim SMSList As New List(Of SMSMSG)
        Dim smsMsg As SMSMSG
        Dim webClient As New System.Net.WebClient
        Dim SMSURL As String
        Dim result As String

        For i As Integer = 0 To dgvSearch.RowCount - 1

            If dgvSearch.Item("SMSSelect", i).Value = True Then
                PartyName = dgvSearch.Item("PartyName", i).Value.ToString()
                BillingName = dgvSearch.Item("BillingName", i).Value.ToString()
                MillCode = dgvSearch.Item("Code", i).Value.ToString()
                MillName = dgvSearch.Item("MillName", i).Value.ToString()
                MShortName = db.Mill.Data("ShortName", "MillName='" + MillName + "'").ToLower
                PhNo = db.Party.Data("PMobile1", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                PhNo1 = db.Party.Data("PMobile2", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                PhNo2 = db.Party.Data("PMobile3", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                PhNo3 = db.Party.Data("PMobile4", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")

                Person1 = db.Party.Data("Person1", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                Person2 = db.Party.Data("Person2", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                Person3 = db.Party.Data("Person3", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                Person4 = db.Party.Data("Person4", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")

                Department1 = db.Party.Data("Department1", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                Department2 = db.Party.Data("Department2", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                Department3 = db.Party.Data("Department3", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")
                Department4 = db.Party.Data("Department4", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'")

                MobileNo = ""
                If PhNo.Trim() <> "" Then
                    MobileNo = PhNo
                End If
                If PhNo.Trim() <> "" And PhNo1.Trim() <> "" Then
                    MobileNo = PhNo + "," + vbCrLf + PhNo1
                End If

                If PhNo.Trim() <> "" And PhNo1.Trim() <> "" And PhNo2.Trim() <> "" Then
                    MobileNo = PhNo + "," + vbCrLf + PhNo1 + "," + vbCrLf + PhNo2
                End If

                If PhNo.Trim() <> "" And PhNo1.Trim() <> "" And PhNo2.Trim() <> "" And PhNo3.Trim() <> "" Then
                    MobileNo = PhNo + "," + vbCrLf + PhNo1 + "," + vbCrLf + PhNo2 + "," + vbCrLf + PhNo3
                End If

                ContactPerson = ""
                If Person1.Trim() <> "" Then
                    ContactPerson = Person1
                End If

                If Person1.Trim() <> "" And Person2.Trim() <> "" Then
                    ContactPerson = Person1 + vbCrLf + Person2
                End If

                If Person1.Trim() <> "" And Person2.Trim() <> "" And Person3.Trim() <> "" Then
                    ContactPerson = Person1 + vbCrLf + Person2 + vbCrLf + Person3
                End If
                If Person1.Trim() <> "" And Person2.Trim() <> "" And Person3.Trim() <> "" And Person4.Trim() <> "" Then
                    ContactPerson = Person1 + vbCrLf + Person2 + vbCrLf + Person3 + vbCrLf + Person4
                End If

                PartyDept = ""
                If Department1.Trim() <> "" Then
                    PartyDept = Department1
                End If

                If Department1.Trim() <> "" And Department2.Trim() <> "" Then
                    PartyDept = Department1 + vbCrLf + Department2
                End If
                If Department1.Trim() <> "" And Department2.Trim() <> "" And Department3.Trim() <> "" Then
                    PartyDept = Department1 + vbCrLf + Department2 + vbCrLf + Department3
                End If

                If Department1.Trim() <> "" And Department2.Trim() <> "" And Department3.Trim() <> "" And Department4.Trim() <> "" Then
                    PartyDept = Department1 + vbCrLf + Department2 + vbCrLf + Department3 + vbCrLf + Department4
                End If

                PShortName = db.Party.Data("ShortName", "PartyName='" + PartyName + "' and LedgerName='" + BillingName + "'").ToLower
                'InvoiceDate = String.Format("{0:dd.MM}", dgvSearch.Item("MWDate", i).Value)
                InvoiceDate = dgvSearch.Item("MWDate", i).Value
                Balance = dgvSearch.Item("Balance", i).Value.ToString()
                Msg = String.Format("{0}-{1}{2}{3} -  {4}", PShortName, MShortName, vbCrLf, InvoiceDate, Balance)
                If MobileNo.Trim() <> "" Then
                    smsMsg = New SMSMSG(InvoiceDate, Balance, MobileNo, MShortName, PShortName, ContactPerson, PartyDept)
                    SMSList.Add(smsMsg)
                End If

            End If

        Next

        Dim BillingNameLst = From sms In SMSList Group By BName = sms.BillingName, MName = sms.MillName Into RegionalSMS = Group Select BName, MName, RegionalSMS

        Dim PhoneNo, PMsg, LPerson, Dept As String
        Dim DId, DCode, Qry, Res As String
        For Each PartyPayment In BillingNameLst
            PMsg = String.Format("{0}-{1}{2}", PartyPayment.BName, PartyPayment.MName, vbCrLf)
            PhoneNo = PartyPayment.RegionalSMS.FirstOrDefault().PhNo
            LPerson = PartyPayment.RegionalSMS.FirstOrDefault().CPerson
            Dept = PartyPayment.RegionalSMS.FirstOrDefault().PDepartment

            For Each sms In PartyPayment.RegionalSMS
                PMsg += String.Format("{0:dd.MM}-{1}{2}", sms.InvoiceDate, sms.Balance, vbCrLf)
            Next
            DId = db.SMSDraft.Data("Max(DraftId)")
            If DId = "" Then
                DId = 1
            Else
                DId = DId + 1
            End If
            DCode = db.SMSDraft.NewCode()
            Qry = String.Format("insert into SMSDraft values({0},'{1}','{2}','{3}','{4}','{5}')", DId, DCode, PMsg, PhoneNo, LPerson, Dept)

            Res = db.ExecuteQuery(Qry)

        Next
        Dim f As New frmSMSDraft()
        f.Show()
        f.BringToFront()

    End Sub


    Private Sub chkForSMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForSMS.CheckedChanged
        Try
            If chkForSMS.Checked = True Then
                dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Else
                dgvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvSearch.MouseDown
        dgvSearch.MultiSelect = True
      
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Try
            For i As Integer = 0 To dgvSearch.SelectedRows.Count - 1
                dgvSearch.Item("SMSSelect", i).Value = True
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class