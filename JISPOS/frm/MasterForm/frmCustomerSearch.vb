Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmCustomerSearch


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
        dgvCustomerSearch.AllowUserToResizeRows = True
        dgvCustomerSearch.AllowUserToResizeColumns = True
        dgvCustomerSearch.Columns("PartyName").Width = 300
        dgvCustomerSearch.Columns("BillingName").Width = 250
        dgvCustomerSearch.Columns("Address").Width = 250
        dgvCustomerSearch.Columns("ShortName").Width = 250
        dgvCustomerSearch.Columns("EmailId").Width = 300
        dgvCustomerSearch.Columns("Person").Width = 250
        dgvCustomerSearch.Columns("Department").Width = 300
        dgvCustomerSearch.Columns("Designation").Width = 300
        dgvCustomerSearch.Columns("ContactNo").Width = 300

        dgvCustomerSearch.Columns("PartyCode").Visible = False
    End Sub

    Sub ViewSearch()

        Dim WQry As String = ""

        If CmbCustomerName.Text.Trim <> "" Then
            WQry += "PartyName='" + CmbCustomerName.Text + "'"
        End If


        If txtAddress.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "AddressLine1 Like '"
            If rbnSuffixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += txtAddress.Text
            If rbnPrefixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtAddress2.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "AddressLine2 Like '"
            If rbnSuffixAddress2.Checked = True Or rbnInfixAddress2.Checked = True Then WQry += "%"
            WQry += txtAddress2.Text
            If rbnPrefixAddress2.Checked = True Or rbnInfixAddress2.Checked = True Then WQry += "%"
            WQry += "'"
        End If


        If txtMobile.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "MobileNo Like '"
            If rbnSuffixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += txtMobile.Text
            If rbnPrefixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtMailId.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "EmailId Like '"
            If rbnSuffixMailId.Checked = True Or rbnInfixMailId.Checked = True Then WQry += "%"
            WQry += txtMailId.Text
            If rbnPrefixMailId.Checked = True Or rbnInfixMailId.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        Dim DV As New DataView
        dgvCustomerSearch.Rows.Clear()
        DV = db.Party.Grid("PartyCode,PartyName,LedgerName,AddressLine1,ShortName,EmailId,Person1,PMobile1,Person2,PMobile2,Person3,PMobile3,Person4,PMobile4,Department1,Designation1,Department2,Designation2,Department3,Designation3,Department4,Designation4", WQry, "PartyName")

        ProgressBar1.Visible = True
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = DV.Count + 1

        For i As Integer = 0 To DV.Count - 1

            dgvCustomerSearch.Rows.Add()
            ProgressBar1.Value = i
            Application.DoEvents()
            dgvCustomerSearch.Item("PartyCode", i).Value = DV.Item(i)("PartyCode").ToString()
            dgvCustomerSearch.Item("PartyName", i).Value = DV.Item(i)("PartyName").ToString()
            dgvCustomerSearch.Item("BillingName", i).Value = DV.Item(i)("LedgerName").ToString()
            dgvCustomerSearch.Item("Address", i).Value = DV.Item(i)("AddressLine1").ToString()
            dgvCustomerSearch.Item("ShortName", i).Value = DV.Item(i)("ShortName").ToString()
            dgvCustomerSearch.Item("EMailId", i).Value = DV.Item(i)("EmailId").ToString()
            dgvCustomerSearch.Item("Person", i).Value = DV.Item(i)("Person1").ToString()
            If DV.Item(i)("Person2").ToString <> "" Then
                dgvCustomerSearch.Item("Person", i).Value += vbCrLf
                dgvCustomerSearch.Item("Person", i).Value += DV.Item(i)("Person2").ToString()
            End If

            If DV.Item(i)("Person3").ToString <> "" Then
                dgvCustomerSearch.Item("Person", i).Value += vbCrLf
                dgvCustomerSearch.Item("Person", i).Value += DV.Item(i)("Person3").ToString()
            End If
            If DV.Item(i)("Person4").ToString <> "" Then
                dgvCustomerSearch.Item("Person", i).Value += vbCrLf
                dgvCustomerSearch.Item("Person", i).Value += DV.Item(i)("Person4").ToString()
            End If

            dgvCustomerSearch.Item("Department", i).Value = DV.Item(i)("Department1").ToString()
            If DV.Item(i)("Department2").ToString <> "" Then
                dgvCustomerSearch.Item("Department", i).Value += vbCrLf
                dgvCustomerSearch.Item("Department", i).Value += DV.Item(i)("Department2").ToString()
            End If

            If DV.Item(i)("Department3").ToString <> "" Then
                dgvCustomerSearch.Item("Department", i).Value += vbCrLf
                dgvCustomerSearch.Item("Department", i).Value += DV.Item(i)("Department3").ToString()
            End If
            If DV.Item(i)("Department4").ToString <> "" Then
                dgvCustomerSearch.Item("Department", i).Value += vbCrLf
                dgvCustomerSearch.Item("Department", i).Value += DV.Item(i)("Department4").ToString()
            End If
            dgvCustomerSearch.Item("Designation", i).Value = DV.Item(i)("Designation1").ToString()
            If DV.Item(i)("Designation2").ToString <> "" Then
                dgvCustomerSearch.Item("Designation", i).Value += vbCrLf
                dgvCustomerSearch.Item("Designation", i).Value += DV.Item(i)("Designation2").ToString()
            End If

            If DV.Item(i)("Designation3").ToString <> "" Then
                dgvCustomerSearch.Item("Designation", i).Value += vbCrLf
                dgvCustomerSearch.Item("Designation", i).Value += DV.Item(i)("Designation3").ToString()
            End If
            If DV.Item(i)("Designation4").ToString <> "" Then
                dgvCustomerSearch.Item("Designation", i).Value += vbCrLf
                dgvCustomerSearch.Item("Designation", i).Value += DV.Item(i)("Designation4").ToString()
            End If
            dgvCustomerSearch.Item("ContactNo", i).Value = DV.Item(i)("PMobile1").ToString()

            If DV.Item(i)("PMobile2").ToString <> "" Then
                dgvCustomerSearch.Item("ContactNo", i).Value += vbCrLf
                dgvCustomerSearch.Item("ContactNo", i).Value += DV.Item(i)("PMobile2").ToString()
            End If

            If DV.Item(i)("PMobile3").ToString <> "" Then
                dgvCustomerSearch.Item("ContactNo", i).Value += vbCrLf
                dgvCustomerSearch.Item("ContactNo", i).Value += DV.Item(i)("PMobile3").ToString()
            End If
            If DV.Item(i)("PMobile4").ToString <> "" Then
                dgvCustomerSearch.Item("ContactNo", i).Value += vbCrLf
                dgvCustomerSearch.Item("ContactNo", i).Value += DV.Item(i)("PMobile4").ToString()
            End If

        Next

        ProgressBar1.Visible = False


    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Enter, txtMobile.Enter, txtMailId.Enter, txtAddress2.Enter, CmbCustomerName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = CmbCustomerName.Name Then
            List_Datas(CmbCustomerName, db.Party.Column("PartyName"))
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave, txtMobile.Leave, txtMailId.Leave, txtAddress2.Leave, CmbCustomerName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.DoubleClick
        Try
            frmCustomers.txtSearchBox.Text = dgvCustomerSearch.SelectedRows(0).Cells(0).Value()
            frmCustomers.btnSearch1_Click(sender, e)
            FormShow(frmCustomers)
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

    Private Sub cmbCustomerName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerName.KeyUp
        If sender.Name = CmbCustomerName.Name Then
            List_Datas(CmbCustomerName, db.Party.Column("PartyName", "PartyName like '%" + sender.Text + "%'"))
        End If

        sender.SelectionStart = sender.Text.Length + 1
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

            For i = 0 To dgv.RowCount - 1
                CCol = 1
                For j = 0 To dgv.ColumnCount - 1
                    If dgv.Columns(j).Visible = True Then
                        If IsDate(dgv(j, i).Value) Then
                            xlWorkSheet.Cells(i + 2, CCol).value = String.Format("{0:dd/MM/yyyy}", dgv(j, i).Value)
                        Else
                            xlWorkSheet.Cells(i + 2, CCol).value = dgv(j, i).Value.ToString()
                        End If
                        dgvSetBackColor(dgvCustomerSearch)
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
