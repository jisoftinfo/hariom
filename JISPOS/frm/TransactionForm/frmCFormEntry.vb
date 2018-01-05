Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmCFormEntry
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
    Private Sub dgvSearch_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCFormQua.ColumnHeaderMouseClick
        'For i As Integer = 0 To dgvCFormQua.RowCount - 1
        '    dgvCFormQua.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgvCFormQua.Item("StatusColor", i).Value.ToString()))
        'Next
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
        dgvCFormQua.EditMode = DataGridViewEditMode.EditOnEnter
        dgvCFormQua.AllowUserToResizeColumns = True
        dgvCFormQua.Columns("Narration").Width = 300
        dgvCFormQua.Columns("BillDate").HeaderText = "Invoice Date"
        dgvCFormQua.Columns("Invoice").HeaderText = "Invoice No"
        dgvCFormQua.Columns("BillAmount").HeaderText = "Invoice Amount"
        dgvCFormQua.Columns("NoOfBags").HeaderText = "No Of Bags"
        dgvCFormQua.Columns("PName").Width = 80
        dgvCFormQua.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnSearch.Enabled = False
        Dim WQry As String = ""

        If cmbPartyName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PartyName ='" + cmbPartyName.Text + "'"
        End If

        If cmbMillName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName='" + cmbMillName.Text + "'"
            'If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            'WQry += cmbMillName.Text
            'If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            'WQry += "'"
        End If

        If cmbBillingName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "BillingName='" + cmbBillingName.Text + "'"
            'If rbnSuffixBillingName.Checked = True Or rbnInfixBillingName.Checked = True Then WQry += "%"
            'WQry += cmbBillingName.Text
            'If rbnPrefixBillingName.Checked = True Or rbnInfixBillingName.Checked = True Then WQry += "%"
            'WQry += "'"
        End If



        If cmbMonth.Text.Trim <> "" Then

            If WQry <> "" Then WQry += " and "
            WQry += "QCode=" + (cmbMonth.SelectedIndex + 1).ToString + ""
        End If

        If cmbYear.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "YearCode='" + cmbYear.Text + "'"

        End If

        Dim dv As New DataView
        dgvCFormQua.Columns("PName").Width = 80

        dv = db.ViewMillWorking.Grid("MillName, PartyName, BillingName, YearCode, PName, QCode, SUM(Amount) AS Amount,'' as CFormNo,'' as CFormAmount,'' as CRDate,'' as Status,'' as EFormNo,'' as EFormAmount,'' as ESDate,'' as CFormNo2,'' as CFormAmount2,'' as CRDate2,'' as EFormNo2,'' as EFormAmount2,'' as ESDate2,'' as CFormNo3,'' as CFormAmount3,'' as CRDate3,'' as EFormNo3,'' as EFormAmount3,'' as ESDate3,'' as Narrration,'-1' as StatusColor,'-1' as E1StatusColor", WQry, "PartyName, MillName,BillingName, YearCode, QCode", "PartyName,MillName,  BillingName, YearCode, QCode, PName")
        dgvCFormQua.Rows.Clear()
        If dv.Count = 0 Then Exit Sub
        Dim MillName, PartyName, BillingName, YearCode, PName As String
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = dv.Count - 1
        Dim dgi As Integer = -1

        For i As Integer = 0 To dv.Count - 1
            ProgressBar1.Value = i

            MillName = dv.Item(i)("MillName").ToString
            PartyName = dv.Item(i)("PartyName").ToString
            BillingName = dv.Item(i)("BillingName").ToString
            YearCode = dv.Item(i)("YearCode").ToString
            PName = dv.Item(i)("PName").ToString

            WQry = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
            Dim arr As New ArrayList
            arr = db.CFormMaster.Row("Status, Narration, StatusColor, CFormNo, CFormAmount, CRDate, EFormNo, EFormAmount, ESDate,CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2,CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3,CFormSendDate,CourierName,CourierNo,EStatus,CourierName2,CourierNo2,CourierName3,CourierNo3,CFormSendDate2,CFormSendDate3,ENarration,E1SendDate,E1SendDate2,E1SendDate3,E1StatusColor", WQry)
            If arr.Count = 0 And cmbStatus.Text <> "P" And cmbStatus.Text <> "" Then
                Continue For
            End If
            If cmbStatus.Text <> "" And arr.Count > 0 Then
                If arr(0) <> cmbStatus.Text Then
                    Continue For
                End If
            End If
            dgvCFormQua.Rows.Add()
            dgi += 1

            dgvCFormQua.Columns("Narration").Width = 300
            dgvCFormQua.Item("MillName", dgi).Value = MillName
            dgvCFormQua.Item("PartyName", dgi).Value = PartyName
            dgvCFormQua.Item("BillingName", dgi).Value = BillingName
            dgvCFormQua.Item("QCode", dgi).Value = dv.Item(i)("QCode").ToString

            dgvCFormQua.Item("Status", dgi).Value = "P"
            dgvCFormQua.Item("Narration", dgi).Value = ""
            dgvCFormQua.Item("StatusColor", dgi).Value = "-1"
            dgvCFormQua.Item("CFormNo", dgi).Value = ""
            dgvCFormQua.Item("CFormAmount", dgi).Value = ""
            dgvCFormQua.Item("CRDate", dgi).Value = ""
            dgvCFormQua.Item("EFormNo", dgi).Value = ""
            dgvCFormQua.Item("EFormAmount", dgi).Value = ""
            dgvCFormQua.Item("ESDate", dgi).Value = ""
            dgvCFormQua.Item("CFormNo2", dgi).Value = ""
            dgvCFormQua.Item("CFormAmount2", dgi).Value = ""
            dgvCFormQua.Item("CRDate2", dgi).Value = ""
            dgvCFormQua.Item("EFormNo2", dgi).Value = ""
            dgvCFormQua.Item("EFormAmount2", dgi).Value = ""
            dgvCFormQua.Item("ESDate2", dgi).Value = ""
            dgvCFormQua.Item("CFormNo3", dgi).Value = ""
            dgvCFormQua.Item("CFormAmount3", dgi).Value = ""
            dgvCFormQua.Item("CRDate3", dgi).Value = ""
            dgvCFormQua.Item("EFormNo3", dgi).Value = ""
            dgvCFormQua.Item("EFormAmount3", dgi).Value = ""
            dgvCFormQua.Item("ESDate3", dgi).Value = ""
            dgvCFormQua.Item("CFormSendDate", dgi).Value = ""
            dgvCFormQua.Item("CourierName", dgi).Value = ""
            dgvCFormQua.Item("CourierNo", dgi).Value = ""
            dgvCFormQua.Item("CourierName2", dgi).Value = ""
            dgvCFormQua.Item("CourierNo2", dgi).Value = ""
            dgvCFormQua.Item("CourierName3", dgi).Value = ""
            dgvCFormQua.Item("CourierNo3", dgi).Value = ""
            dgvCFormQua.Item("CFormSendDate2", dgi).Value = ""
            dgvCFormQua.Item("CFormSendDate3", dgi).Value = ""
            dgvCFormQua.Item("ENarration", dgi).Value = ""

            If arr.Count > 0 Then
                dgvCFormQua.Item("Status", dgi).Value = arr(0)
                dgvCFormQua.Item("Narration", dgi).Value = arr(1)
                dgvCFormQua.Item("StatusColor", dgi).Value = arr(2)
                dgvCFormQua.Item("E1StatusColor", dgi).Value = arr(35)
                dgvCFormQua.Item("CFormNo", dgi).Value = arr(3)
                dgvCFormQua.Item("CFormAmount", dgi).Value = arr(4).ToString()

                If String.Format("{0:dd/MM/yyyy}", arr(5)) = "01/01/1990" Then
                    dgvCFormQua.Item("CRDate", dgi).Value = ""
                Else
                    dgvCFormQua.Item("CRDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(5))
                End If

                dgvCFormQua.Item("EFormNo", dgi).Value = arr(6)
                dgvCFormQua.Item("EFormAmount", dgi).Value = arr(7)

                If String.Format("{0:dd/MM/yyyy}", arr(8)) = "01/01/1990" Then
                    dgvCFormQua.Item("ESDate", dgi).Value = ""
                Else

                    dgvCFormQua.Item("ESDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(8))
                End If

                dgvCFormQua.Item("CFormNo2", dgi).Value = arr(9)
                dgvCFormQua.Item("CFormAmount2", dgi).Value = arr(10)

                If String.Format("{0:dd/MM/yyyy}", arr(11)) = "01/01/1990" Then
                    dgvCFormQua.Item("CRDate2", dgi).Value = ""
                Else

                    dgvCFormQua.Item("CRDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(11))
                End If

                dgvCFormQua.Item("EFormAmount2", dgi).Value = arr(13)

                dgvCFormQua.Item("EFormNo2", dgi).Value = arr(12)

                If String.Format("{0:dd/MM/yyyy}", arr(14)) = "01/01/1990" Then
                    dgvCFormQua.Item("ESDate2", dgi).Value = ""
                Else

                    dgvCFormQua.Item("ESDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(14))
                End If


                dgvCFormQua.Item("CFormNo3", dgi).Value = arr(15)
                dgvCFormQua.Item("CFormAmount3", dgi).Value = arr(16)

                If String.Format("{0:dd/MM/yyyy}", arr(17)) = "01/01/1990" Then
                    dgvCFormQua.Item("CRDate3", dgi).Value = ""
                Else

                    dgvCFormQua.Item("CRDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(17))
                End If

                dgvCFormQua.Item("EFormNo3", dgi).Value = arr(18)
                dgvCFormQua.Item("EFormAmount3", dgi).Value = arr(19)

                If String.Format("{0:dd/MM/yyyy}", arr(20)) = "01/01/1990" Then
                    dgvCFormQua.Item("ESDate3", dgi).Value = ""
                Else

                    dgvCFormQua.Item("ESDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(20))
                End If

                dgvCFormQua.Item("CourierNo", dgi).Value = arr(23)
                dgvCFormQua.Item("CourierName", dgi).Value = arr(22)

                If String.Format("{0:dd/MM/yyyy}", arr(21)) = "01/01/1990" Then
                    dgvCFormQua.Item("CFormSendDate", dgi).Value = ""
                Else
                    dgvCFormQua.Item("CFormSendDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(21))
                End If

                If String.Format("{0:dd/MM/yyyy}", arr(5)) = "01/01/1990" Then
                    dgvCFormQua.Item("CFormSendDate2", dgi).Value = ""
                Else
                    dgvCFormQua.Item("CFormSendDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(29))
                End If

                If String.Format("{0:dd/MM/yyyy}", arr(5)) = "01/01/1990" Then
                    dgvCFormQua.Item("CFormSendDate3", dgi).Value = ""
                Else
                    dgvCFormQua.Item("CFormSendDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(30))
                End If

                If arr(25) = "" Then
                    dgvCFormQua.Item("CourierNo2", dgi).Value = ""
                    dgvCFormQua.Item("CourierName2", dgi).Value = ""
                Else
                    dgvCFormQua.Item("CourierNo2", dgi).Value = arr(25)
                    dgvCFormQua.Item("CourierName2", dgi).Value = arr(26)
                End If
                If arr(27) = "" Then
                    dgvCFormQua.Item("CourierNo3", dgi).Value = ""
                    dgvCFormQua.Item("CourierName3", dgi).Value = ""
                Else
                    dgvCFormQua.Item("CourierNo3", dgi).Value = arr(27)
                    dgvCFormQua.Item("CourierName3", dgi).Value = arr(28)
                End If

                If arr(31) = "" Then
                    dgvCFormQua.Item("ENarration", dgi).Value = ""
                Else
                    dgvCFormQua.Item("ENarration", dgi).Value = arr(31)
                End If

                If String.Format("{0:dd/MM/yyyy}", arr(32)) = "01/01/1990" Then
                    dgvCFormQua.Item("E1SendDate", dgi).Value = ""
                Else
                    dgvCFormQua.Item("E1SendDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(32))
                End If

                If String.Format("{0:dd/MM/yyyy}", arr(33)) = "01/01/1990" Then
                    dgvCFormQua.Item("E1SendDate2", dgi).Value = ""
                Else
                    dgvCFormQua.Item("E1SendDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(33))
                End If

                If String.Format("{0:dd/MM/yyyy}", arr(34)) = "01/01/1990" Then
                    dgvCFormQua.Item("E1SendDate3", dgi).Value = ""
                Else
                    dgvCFormQua.Item("E1SendDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(34))
                End If

                dgvCFormQua.Item("EStatus", dgi).Value = arr(24)
            End If
            If rbnDetails.Checked = True Then
                WQry = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
                Dim dvDetails As New DataView
                dvDetails = db.ViewMillWorking.Grid("MWDate as BillDate,Invoice,NoOfBags,Amount", WQry, "MWDate")
                For j As Integer = 0 To dvDetails.Count - 1
                    dgvCFormQua.Item("BillDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", dvDetails.Item(j)("BillDate"))
                    dgvCFormQua.Item("Invoice", dgi).Value = dvDetails.Item(j)("Invoice").ToString
                    dgvCFormQua.Item("NoOfBags", dgi).Value = dvDetails.Item(j)("NoOfBags").ToString
                    dgvCFormQua.Item("BillAmount", dgi).Value = dvDetails.Item(j)("Amount").ToString
                    dgvCFormQua.Rows.Add()
                    dgi += 1
                Next
            End If
            dgvCFormQua.Item("YearCode", dgi).Value = YearCode
            dgvCFormQua.Item("PName", dgi).Value = PName
            dgvCFormQua.Item("Amount", dgi).Value = dv.Item(i)("Amount").ToString
        Next
        If rbnDetails.Checked = True Then
            dgvCFormQua.Columns("BillDate").Visible = True
            dgvCFormQua.Columns("Invoice").Visible = True
            dgvCFormQua.Columns("NoOfBags").Visible = True
            dgvCFormQua.Columns("BillAmount").Visible = True
            btnSave.Enabled = False
            For j As Integer = 0 To dgvCFormQua.Columns.Count - 1
                dgvCFormQua.Columns(j).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        Else
            dgvCFormQua.Columns("BillDate").Visible = False
            dgvCFormQua.Columns("Invoice").Visible = False
            dgvCFormQua.Columns("NoOfBags").Visible = False
            dgvCFormQua.Columns("BillAmount").Visible = False
            btnSave.Enabled = True
            For j As Integer = 0 To dgvCFormQua.Columns.Count - 1
                dgvCFormQua.Columns(j).SortMode = DataGridViewColumnSortMode.Automatic
            Next
        End If
        dgvSetBackColor(dgvCFormQua)
        ProgressBar1.Visible = False
        btnSearch.Enabled = True

        dgvCFormQua.Columns("YearCode").DefaultCellStyle.BackColor = Color.Red
        dgvCFormQua.Columns("PName").DefaultCellStyle.BackColor = Color.Red
        dgvCFormQua.Columns("Amount").DefaultCellStyle.BackColor = Color.Red
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyName.Enter, cmbYear.Enter, cmbMonth.Enter, cmbMillName.Enter, cmbStatus.Enter, cmbBillingName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName"))
        End If
        If sender.Name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If


        If sender.Name = cmbBillingName.Name Then
            If cmbPartyName.Text = "" Then
                List_Datas(cmbBillingName, db.Party.Column("LedgerName"))
            Else
                List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
            End If

        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyName.Leave, cmbMonth.Leave, cmbYear.Leave, cmbMillName.Leave, cmbStatus.Leave, cmbBillingName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim MillName, PartyName, BillingName, YearCode, PName, QCode, Amount, Status, EStatus, Narration, StatusColor, E1StatusColor, CFormNo, CFormAmount, CSendDate, CourierNo, CourierName, CRDate, EFormNo, EFormAmount, ESDate, CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2, CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3, CourierName2, CourierNo2, CourierName3, CourierNo3, CFormSendDate2, CFormSendDate3, ENarration, E1SendDate, E1SendDate2, E1SendDate3 As String
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = dgvCFormQua.Rows.Count

        For i As Integer = 0 To dgvCFormQua.Rows.Count - 1
            ProgressBar1.Value = i
            Application.DoEvents()

            QCode = dgvCFormQua.Item("QCode", i).Value.ToString
            PName = dgvCFormQua.Item("PName", i).Value.ToString
            'StatusColor = dgvCFormQua.Item("StatusColor", i).Value.ToString
            'E1StatusColor = dgvCFormQua.Item("E1StatusColor", i).Value.ToString

            If dgvCFormQua.Item("E1StatusColor", i).Value Is Nothing Then
                E1StatusColor = ""
            Else
                E1StatusColor = dgvCFormQua.Item("E1StatusColor", i).Value.ToString
            End If

            If dgvCFormQua.Item("StatusColor", i).Value Is Nothing Then
                StatusColor = ""
            Else
                StatusColor = dgvCFormQua.Item("StatusColor", i).Value.ToString
            End If

            If dgvCFormQua.Item("MillName", i).Value Is Nothing Then
                MillName = ""
            Else
                MillName = dgvCFormQua.Item("MillName", i).Value.ToString
            End If

            If dgvCFormQua.Item("PartyName", i).Value Is Nothing Then
                PartyName = ""
            Else
                PartyName = dgvCFormQua.Item("PartyName", i).Value.ToString
            End If

            If dgvCFormQua.Item("BillingName", i).Value Is Nothing Then
                BillingName = ""
            Else
                BillingName = dgvCFormQua.Item("BillingName", i).Value.ToString
            End If

            If dgvCFormQua.Item("YearCode", i).Value Is Nothing Then
                YearCode = ""
            Else
                YearCode = dgvCFormQua.Item("YearCode", i).Value.ToString
            End If

            If dgvCFormQua.Item("Amount", i).Value Is Nothing Then
                Amount = ""
            Else
                Amount = dgvCFormQua.Item("Amount", i).Value.ToString
            End If
            If dgvCFormQua.Item("Status", i).Value Is Nothing Then
                Status = ""
            Else
                Status = dgvCFormQua.Item("Status", i).Value.ToString
            End If
            If dgvCFormQua.Item("EStatus", i).Value Is Nothing Then
                EStatus = ""
            Else
                EStatus = dgvCFormQua.Item("EStatus", i).Value.ToString
            End If

            If dgvCFormQua.Item("Narration", i).Value Is Nothing Then
                Narration = ""
            Else
                Narration = dgvCFormQua.Item("Narration", i).Value.ToString
            End If

            If dgvCFormQua.Item("CFormNo", i).Value Is Nothing Then
                CFormNo = ""
            Else
                CFormNo = dgvCFormQua.Item("CFormNo", i).Value.ToString
            End If

            If dgvCFormQua.Item("CFormAmount", i).Value Is Nothing Then
                CFormAmount = ""
            Else
                CFormAmount = dgvCFormQua.Item("CFormAmount", i).Value.ToString
            End If

            If dgvCFormQua.Item("CourierNo", i).Value Is Nothing Then
                CourierNo = ""
            Else
                CourierNo = dgvCFormQua.Item("CourierNo", i).Value.ToString
            End If

            If dgvCFormQua.Item("CourierName", i).Value Is Nothing Then
                CourierName = ""
            Else
                CourierName = dgvCFormQua.Item("CourierName", i).Value.ToString
            End If
            If dgvCFormQua.Item("EFormNo", i).Value Is Nothing Then
                EFormNo = ""
            Else
                EFormNo = dgvCFormQua.Item("EFormNo", i).Value.ToString
            End If
            If dgvCFormQua.Item("EFormAmount", i).Value Is Nothing Then
                EFormAmount = ""
            Else
                EFormAmount = dgvCFormQua.Item("EFormAmount", i).Value.ToString
            End If
            If dgvCFormQua.Item("CFormNo2", i).Value Is Nothing Then
                CFormNo2 = ""
            Else
                CFormNo2 = dgvCFormQua.Item("CFormNo2", i).Value.ToString
            End If
            If dgvCFormQua.Item("CFormAmount2", i).Value Is Nothing Then
                CFormAmount2 = ""
            Else
                CFormAmount2 = dgvCFormQua.Item("CFormAmount2", i).Value.ToString
            End If
            If dgvCFormQua.Item("EFormNo2", i).Value Is Nothing Then
                EFormNo2 = ""
            Else
                EFormNo2 = dgvCFormQua.Item("EFormNo2", i).Value.ToString
            End If
            If dgvCFormQua.Item("EFormAmount2", i).Value Is Nothing Then
                EFormAmount2 = ""
            Else
                EFormAmount2 = dgvCFormQua.Item("EFormAmount2", i).Value.ToString
            End If
            If dgvCFormQua.Item("CFormNo3", i).Value Is Nothing Then
                CFormNo3 = ""
            Else
                CFormNo3 = dgvCFormQua.Item("CFormNo3", i).Value.ToString
            End If
            If dgvCFormQua.Item("CFormAmount3", i).Value Is Nothing Then
                CFormAmount3 = ""
            Else
                CFormAmount3 = dgvCFormQua.Item("CFormAmount3", i).Value.ToString
            End If
            If dgvCFormQua.Item("EFormNo3", i).Value Is Nothing Then
                EFormNo3 = ""
            Else
                EFormNo3 = dgvCFormQua.Item("EFormNo3", i).Value.ToString
            End If

            If dgvCFormQua.Item("EFormAmount3", i).Value Is Nothing Then
                EFormAmount3 = ""
            Else
                EFormAmount3 = dgvCFormQua.Item("EFormAmount3", i).Value.ToString
            End If

            If dgvCFormQua.Item("CourierName2", i).Value Is Nothing Then
                CourierName2 = ""
            Else
                CourierName2 = dgvCFormQua.Item("CourierName2", i).Value.ToString
            End If

            If dgvCFormQua.Item("CourierName2", i).Value Is Nothing Then
                CourierName2 = ""
            Else
                CourierName2 = dgvCFormQua.Item("CourierName2", i).Value.ToString
            End If

            If dgvCFormQua.Item("CourierNo2", i).Value Is Nothing Then
                CourierNo2 = ""
            Else
                CourierNo2 = dgvCFormQua.Item("CourierNo2", i).Value.ToString
            End If
            If dgvCFormQua.Item("CourierName3", i).Value Is Nothing Then
                CourierName3 = ""
            Else
                CourierName3 = dgvCFormQua.Item("CourierName3", i).Value.ToString
            End If

            If dgvCFormQua.Item("CourierNo3", i).Value Is Nothing Then
                CourierNo3 = ""
            Else
                CourierNo3 = dgvCFormQua.Item("CourierNo3", i).Value.ToString
            End If

            If dgvCFormQua.Item("ENarration", i).Value Is Nothing Then
                ENarration = ""
            Else
                ENarration = dgvCFormQua.Item("ENarration", i).Value.ToString
            End If

            If dgvCFormQua.Item("CFormSendDate", i).Value Is Nothing Then
                CSendDate = ""
            Else
                CSendDate = dgvCFormQua.Item("CFormSendDate", i).Value.ToString
            End If

            If dgvCFormQua.Item("CFormSendDate2", i).Value Is Nothing Then
                CFormSendDate2 = ""
            Else
                CFormSendDate2 = dgvCFormQua.Item("CFormSendDate2", i).Value.ToString
            End If

            If dgvCFormQua.Item("CFormSendDate3", i).Value Is Nothing Then
                CFormSendDate3 = ""
            Else
                CFormSendDate3 = dgvCFormQua.Item("CFormSendDate3", i).Value.ToString
            End If

            If dgvCFormQua.Item("CRDate", i).Value Is Nothing Then
                CRDate = ""
            Else
                CRDate = dgvCFormQua.Item("CRDate", i).Value.ToString
            End If

            'If dgvCFormQua.Item("ESDate", i).Value Is Nothing Then
            '    ESDate = ""
            'Else
            '    ESDate = dgvCFormQua.Item(" ESDate", i).Value.ToString
            'End If

            If dgvCFormQua.Item("CRDate2", i).Value Is Nothing Then
                CRDate2 = ""
            Else
                CRDate2 = dgvCFormQua.Item("CRDate2", i).Value.ToString
            End If

            If dgvCFormQua.Item("CRDate2", i).Value Is Nothing Then
                CRDate2 = ""
            Else
                CRDate2 = dgvCFormQua.Item("CRDate2", i).Value.ToString
            End If

            If dgvCFormQua.Item("ESDate2", i).Value Is Nothing Then
                ESDate2 = ""
            Else
                ESDate2 = dgvCFormQua.Item("ESDate2", i).Value.ToString
            End If

            If dgvCFormQua.Item("CRDate3", i).Value Is Nothing Then
                CRDate3 = ""
            Else
                CRDate3 = dgvCFormQua.Item("CRDate3", i).Value.ToString
            End If


            If dgvCFormQua.Item("ESDate3", i).Value Is Nothing Then
                ESDate3 = ""
            Else
                ESDate3 = dgvCFormQua.Item("ESDate3", i).Value.ToString
            End If

            If dgvCFormQua.Item("E1SendDate", i).Value Is Nothing Then
                E1SendDate = ""
            Else
                E1SendDate = dgvCFormQua.Item("E1SendDate", i).Value.ToString
            End If

            If dgvCFormQua.Item("E1SendDate2", i).Value Is Nothing Then
                E1SendDate2 = ""
            Else
                E1SendDate2 = dgvCFormQua.Item("E1SendDate2", i).Value.ToString
            End If

            If dgvCFormQua.Item("E1SendDate3", i).Value Is Nothing Then
                E1SendDate3 = ""
            Else
                E1SendDate3 = dgvCFormQua.Item("E1SendDate3", i).Value.ToString
            End If

            ' ESDate = dgvCFormQua.Item("ESDate", i).Value.ToString
            'CRDate2 = dgvCFormQua.Item("CRDate2", i).Value.ToString
            'ESDate2 = dgvCFormQua.Item("ESDate2", i).Value.ToString
            'CRDate3 = dgvCFormQua.Item("CRDate3", i).Value.ToString
            'ESDate3 = dgvCFormQua.Item("ESDate3", i).Value.ToString
            ' E1SendDate = dgvCFormQua.Item("E1SendDate", i).Value.ToString
            ' E1SendDate = dgvCFormQua.Item("E1SendDate", i).Value.ToString
            'E1SendDate2 = dgvCFormQua.Item("E1SendDate2", i).Value.ToString
            ' E1SendDate3 = dgvCFormQua.Item("E1SendDate3", i).Value.ToString


            If Split(ESDate, " ").Length > 0 Then
                ESDate = Split(ESDate, " ")(0)
            End If
            If Split(ESDate, "/").Length = 3 Then
                ESDate = (New Date(Split(ESDate, "/")(2), Split(ESDate, "/")(1), Split(ESDate, "/")(0))).ToString()
            Else
                ESDate = "1/1/1990"
            End If

            If Split(CSendDate, " ").Length > 0 Then
                CSendDate = Split(CSendDate, " ")(0)
            End If
            If Split(CSendDate, "/").Length = 3 Then
                CSendDate = (New Date(Split(CSendDate, "/")(2), Split(CSendDate, "/")(1), Split(CSendDate, "/")(0))).ToString()
            Else
                CSendDate = "1/1/1990"
            End If


            If Split(CFormSendDate2, " ").Length > 0 Then
                CFormSendDate2 = Split(CFormSendDate2, " ")(0)
            End If

            If Split(CFormSendDate2, "/").Length = 3 Then
                CFormSendDate2 = (New Date(Split(CFormSendDate2, "/")(2), Split(CFormSendDate2, "/")(1), Split(CFormSendDate2, "/")(0))).ToString()
            Else
                CFormSendDate2 = "1/1/1990"
            End If


            If Split(CFormSendDate3, " ").Length > 0 Then
                CFormSendDate3 = Split(CFormSendDate3, " ")(0)
            End If
            If Split(CFormSendDate3, "/").Length = 3 Then
                CFormSendDate3 = (New Date(Split(CFormSendDate3, "/")(2), Split(CFormSendDate3, "/")(1), Split(CFormSendDate3, "/")(0))).ToString()
            Else
                CFormSendDate3 = "1/1/1990"
            End If


            If Split(CRDate, " ").Length > 0 Then
                CRDate = Split(CRDate, " ")(0)
            End If
            If Split(CRDate, "/").Length = 3 Then
                CRDate = (New Date(Split(CRDate, "/")(2), Split(CRDate, "/")(1), Split(CRDate, "/")(0))).ToString()
            Else
                CRDate = "1/1/1990"
            End If


            If Split(ESDate2, " ").Length > 0 Then
                ESDate2 = Split(ESDate2, " ")(0)
            End If
            If Split(ESDate2, "/").Length = 3 Then
                ESDate2 = (New Date(Split(ESDate2, "/")(2), Split(ESDate2, "/")(1), Split(ESDate2, "/")(0))).ToString()
            Else
                ESDate2 = "1/1/1990"
            End If

            If Split(CRDate2, " ").Length > 0 Then
                CRDate2 = Split(CRDate2, " ")(0)
            End If
            If Split(CRDate2, "/").Length = 3 Then
                CRDate2 = (New Date(Split(CRDate2, "/")(2), Split(CRDate2, "/")(1), Split(CRDate2, "/")(0))).ToString()
            Else
                CRDate2 = "1/1/1990"
            End If

            If Split(ESDate3, " ").Length > 0 Then
                ESDate3 = Split(ESDate3, " ")(0)
            End If
            If Split(ESDate3, "/").Length = 3 Then
                ESDate3 = (New Date(Split(ESDate3, "/")(2), Split(ESDate3, "/")(1), Split(ESDate3, "/")(0))).ToString()
            Else
                ESDate3 = "1/1/1990"
            End If

            If Split(CRDate3, " ").Length > 0 Then
                CRDate3 = Split(CRDate3, " ")(0)
            End If
            If Split(CRDate3, "/").Length = 3 Then
                CRDate3 = (New Date(Split(CRDate3, "/")(2), Split(CRDate3, "/")(1), Split(CRDate3, "/")(0))).ToString()
            Else
                CRDate3 = "1/1/1990"
            End If

            If Split(E1SendDate, " ").Length > 0 Then
                E1SendDate = Split(E1SendDate, " ")(0)
            End If
            If Split(E1SendDate, "/").Length = 3 Then
                E1SendDate = (New Date(Split(E1SendDate, "/")(2), Split(E1SendDate, "/")(1), Split(E1SendDate, "/")(0))).ToString()
            Else
                E1SendDate = "1/1/1990"
            End If

            If Split(E1SendDate2, " ").Length > 0 Then
                E1SendDate2 = Split(E1SendDate2, " ")(0)
            End If
            If Split(E1SendDate2, "/").Length = 3 Then
                E1SendDate2 = (New Date(Split(E1SendDate2, "/")(2), Split(E1SendDate2, "/")(1), Split(E1SendDate2, "/")(0))).ToString()
            Else
                E1SendDate2 = "1/1/1990"
            End If
            If Split(E1SendDate3, " ").Length > 0 Then
                E1SendDate3 = Split(E1SendDate3, " ")(0)
            End If
            If Split(E1SendDate3, "/").Length = 3 Then
                E1SendDate3 = (New Date(Split(E1SendDate3, "/")(2), Split(E1SendDate3, "/")(1), Split(E1SendDate3, "/")(0))).ToString()
            Else
                E1SendDate3 = "1/1/1990"
            End If
            Dim WQry As String = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
            Dim CFId, CFCode As String
            Dim Arr As New ArrayList

            Arr = db.CFormMaster.Row("CFId,CFCode", WQry)
            If Arr.Count > 0 Then
                CFId = Arr(0)
                CFCode = Arr(1)
            Else
                CFId = db.CFormMaster.NewId
                CFCode = db.CFormMaster.NewCode
            End If
            db.CFormMaster.SaveRecord(CFId, CFCode, MillName, PartyName, BillingName, YearCode, PName, QCode, Amount, Status, Narration, StatusColor, CFormNo, CFormAmount, CRDate, EFormNo, EFormAmount, ESDate, CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2, CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3, CSendDate, CourierName, CourierNo, EStatus, CourierName2, CourierNo2, CourierName3, CourierNo3, CFormSendDate2, CFormSendDate3, ENarration, E1SendDate, E1SendDate2, E1SendDate3, E1StatusColor)

        Next
        ProgressBar1.Visible = False
        MsgBox("Saved Successfully")
    End Sub

    Private Sub dgvSearch_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCFormQua.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim cdBox As New ColorDialog
            If cdBox.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgvCFormQua.Rows(e.RowIndex).DefaultCellStyle.BackColor = cdBox.Color
                dgvCFormQua.Item("StatusColor", e.RowIndex).Value = cdBox.Color.ToArgb
            End If
        End If
    End Sub
    Private Sub dgvCFormQua_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCFormQua.RowEnter
        Dim WQry As String = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", dgvCFormQua.Item("MillName", e.RowIndex).Value, dgvCFormQua.Item("PartyName", e.RowIndex).Value, dgvCFormQua.Item("BillingName", e.RowIndex).Value, dgvCFormQua.Item("YearCode", e.RowIndex).Value, dgvCFormQua.Item("PName", e.RowIndex).Value)

        dgvCFormMon.DataSource = db.ViewMillWorking.Grid("MillName, PartyName, BillingName, YearCode, Format(MWDate, 'MMMM') AS [Month], Format(MWDate, 'MM') AS MCode, SUM(Amount) AS Amount", WQry, "MillName, PartyName, BillingName, YearCode, Format(MWDate, 'MM')", "MillName, PartyName, BillingName, YearCode, Format(MWDate, 'MMMM'), Format(MWDate, 'MM')")
        dgvDetails.DataSource = db.ViewMillWorking.Grid("MWDate as BillDate,Invoice,Amount", WQry)

        dgvCFormMon.Columns("MillName").Visible = False
        dgvCFormMon.Columns("PartyName").Visible = False
        dgvCFormMon.Columns("BillingName").Visible = False
        dgvCFormMon.Columns("YearCode").Visible = False
        dgvCFormMon.Columns("MCode").Visible = False

        dgvDetails.Columns("BillDate").DefaultCellStyle.Format = "dd/MM/yyyy"


    End Sub

    Private Sub dgvCFormQua_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvCFormQua.RowsAdded
        'dgvCFormQua.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgvCFormQua.Item("StatusColor", e.RowIndex).Value.ToString()))
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        ExportDataGridView(dgvCFormQua)
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
            ProgressBar1.Visible = True
            ProgressBar1.Maximum = dgv.Rows.Count
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
                            If dgv(j, i).Value Is Nothing Then
                                xlWorkSheet.Cells(i + 2, CCol).value = ""
                            Else
                                xlWorkSheet.Cells(i + 2, CCol).value = dgv(j, i).Value.ToString()
                            End If

                        End If

                        xlWorkSheet.Cells(i + 2, CCol).Interior.Color = RGB(dgv.Rows(i).DefaultCellStyle.BackColor.R, dgv.Rows(i).DefaultCellStyle.BackColor.G, dgv.Rows(i).DefaultCellStyle.BackColor.B)

                        CCol = CCol + 1
                    End If

                Next
            Next
            xlWorkSheet.Cells.Borders.LineStyle = 1

            ' xlWorkBook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            '  Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            'xlWorkBook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, ReadOnlyRecommended:=False, CreateBackup:=False)
            xlWorkBook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlExcel5, misValue, misValue, ReadOnlyRecommended:=False, CreateBackup:=False)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)
            ProgressBar1.Visible = False
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

    Private Sub dgvCFormQua_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCFormQua.Sorted
        dgvSetBackColor(dgvCFormQua)
    End Sub

    Private Sub btnMailSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailSend.Click
        Me.Enabled = False
        Try
            Dim ObjEM As New JISEMail()
            Dim AttFiles As New ArrayList
            Dim EmailId, Subject, Message As String
            EmailId = db.Party.Data("EMailId", "PartyName='" + cmbPartyName.Text + "'")
            Subject = "PENDING C FORM DETAIL FROM (HARI OM YARN AGENCY)"
            Message = ""
            Message += "<html><b>SUBJECT : PENDING C FORM DETAIL FROM (HARI OM YARN AGENCY)</b><br/>"
            Message += "<font style='Color:blue'/><b>DINESH TULSYAN<br/>HARIOM YARN AGENCY<br/>2/569,VAGAI ST.,GOMATHIPURAM 6TH MAIN ROAD.<br/>MADURAI -625020<br/>TAMILNADU<br/>tulsyandinesh@gmail.com,Cell +9345213033, 8220010234 Ph :  0452-4516303, 4383033,4250752, 82206-60044</b></font>"
            Message += "<br/><br/><b>Sir,WE ARE SENDING PENDING C FORM DETAIL.PLS CHECK PLS SEND ALL C FORM TO OUR MADURAI ADDRESS.</b><br/>"
            Message += "<table width='800px' height='70px' border='1px'><th>Billing Name</th><th>Mill Name</th><th>Bill Date</th><th>Invoice</th><th>No Of Bags</th><th>Bill Amount</th>"
            If dgvCFormQua.RowCount <> 0 Then
                If rbnSummary.Checked = True Then

                    For i As Integer = 0 To dgvCFormQua.RowCount - 1
                        If dgvCFormQua.Item("Status", i).Value.ToString = "P" Then
                            Continue For
                        End If
                        Message += String.Format("Billing Name : {1}{0}Mill Name : {2}{0}Year{3}{0}Period{4}{0}Amount{5}{0}", "<br/>", dgvCFormQua.Item("BillingName", i).Value.ToString(), dgvCFormQua.Item("MillName", i).Value.ToString(), dgvCFormQua.Item("YearCode", i).Value.ToString(), dgvCFormQua.Item("PName", i).Value.ToString(), dgvCFormQua.Item("Amount", i).Value.ToString())
                    Next
                    Dim arr() As String
                    arr = EmailId.Split(",")
                    For j As Integer = 0 To arr.Count - 1
                        MsgBox(ObjEM.SendMail(arr(j), Subject, Message, AttFiles))
                    Next
                Else

                    For i As Integer = 0 To dgvCFormQua.RowCount - 1
                        Dim BillingName, MillName, BillDate, Invoice, NoOfBags, BillAmount As String
                        BillingName = dgvCFormQua.Item("BillingName", i).Value
                        MillName = dgvCFormQua.Item("MillName", i).Value
                        BillDate = dgvCFormQua.Item("BillDate", i).Value
                        Invoice = dgvCFormQua.Item("Invoice", i).Value
                        NoOfBags = dgvCFormQua.Item("NoOfBags", i).Value
                        BillAmount = dgvCFormQua.Item("BillAmount", i).Value
                        If BillingName Is Nothing Then
                            BillingName = ""
                        ElseIf MillName Is Nothing Then
                            MillName = ""
                        ElseIf BillDate Is Nothing Then
                            BillDate = ""
                        ElseIf Invoice Is Nothing Then
                            Invoice = ""
                        ElseIf NoOfBags Is Nothing Then
                            NoOfBags = ""
                        ElseIf BillAmount Is Nothing Then
                            BillAmount = "."
                        End If
                        Message += "<tr>"


                        'Message += String.Format("Billing Name : {1}{0}Mill Name : {2}{0}Bill Date;{3}{0}Invoice:{4}{0}No Of Bags:{5}{0}Bill Amount:{6}{0}", vbCrLf, BillingName, MillName, BillDate, Invoice, NoOfBags, BillAmount)

                        Message += "<td width='250px'>" + BillingName + "</td>"
                        Message += "<td width='200px'>" + MillName + "</td>"
                        Message += "<td width='100px'>" + BillDate + "</td>"
                        Message += "<td width='50px'>" + Invoice + "</td>"
                        Message += "<td width='50px'>" + NoOfBags + "</td>"
                        Message += "<td width='100px'>" + BillAmount + "</td></tr>"

                    Next
                    Dim arr() As String
                    arr = EmailId.Split(",")
                    For j As Integer = 0 To arr.Count - 1
                        Message += "</table><br/>"
                        Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"
                        MsgBox(ObjEM.SendMail(arr(j), Subject, Message, AttFiles))
                    Next
                End If

            Else
                MsgBox("No Data In List")
            End If

        Catch ex As Exception

        End Try
        Me.Enabled = True
    End Sub

    Private Sub btnAutoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoEmail.Click
        FormShow(frmAutoEmail)
    End Sub

    Private Sub dgvCFormQua_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCFormQua.SelectionChanged
        Try
            Dim tot As Long = 0
            For i As Integer = 0 To dgvCFormQua.SelectedCells.Count - 1
                If IsNumeric(dgvCFormQua.SelectedCells(i).Value) Then
                    tot = tot + dgvCFormQua.SelectedCells(i).Value
                End If
            Next
            Label1.Text = tot
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        If Val(Label1.Text) = 0 Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub cmbPartyName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPartyName.KeyUp, cmbMillName.KeyUp
        If sender.Name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName", "MillName like '%" + sender.Text + "%'"))
        End If
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName", "PartyName like '%" + sender.Text + "%'"))
        End If
        If sender.name = cmbBillingName.Name Then
            List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
        End If
        sender.SelectionStart = sender.Text.Length + 1
    End Sub

    Private Sub chkMillPayment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMillPayment.CheckedChanged
        If chkMillPayment.Checked = True Then
            dgvCFormQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            dgvCFormQua.SelectionMode = DataGridViewSelectionMode.CellSelect
        End If
    End Sub
End Class
