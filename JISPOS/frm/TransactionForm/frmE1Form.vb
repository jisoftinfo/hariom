Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmE1Form

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
        dgvCFormQua.EditMode = DataGridViewEditMode.EditOnEnter
        dgvCFormQua.AllowUserToResizeColumns = True
        dgvCFormQua.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvCFormQua.AllowUserToAddRows = True
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ' btnSearch.Enabled = False
        Dim WQry As String = ""
        WQry += "CFormNo<>''"

        If cmbPartyName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PartyName like '"
            If rbnSuffixParty.Checked = True Or rbnInfixParty.Checked = True Then WQry += "%"
            WQry += cmbPartyName.Text
            If rbnPrefixParty.Checked = True Or rbnInfixParty.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If cmbMillName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName like '"
            If rbnSuffixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixMill.Checked = True Or rbnInfixMill.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If cmbBillingName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "BillingName like '"
            If rbnSuffixBillingName.Checked = True Or rbnInfixBillingName.Checked = True Then WQry += "%"
            WQry += cmbBillingName.Text
            If rbnPrefixBillingName.Checked = True Or rbnInfixBillingName.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        If cmbStatus.Text.Trim <> "" Then

            If WQry <> "" Then WQry += " and "
            WQry += "EStatus='" + cmbStatus.Text + "'"
        End If

        If cmbMonth.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "QCode=" + (cmbMonth.SelectedIndex + 1).ToString + ""
        End If

        If cmbYear.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "YearCode='" + cmbYear.Text + "'"
        End If

        If cmbCountGroup.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "CountGroup='" + cmbCountGroup.Text + "'"
        End If

        Dim dv As New DataView

        dv = db.ViewCFormMaster.Grid("MillName, CountGroup,PartyName, BillingName, YearCode, PName, QCode,Amount,EStatus, Status, StatusColor,Format(CRDate,'dd/MM/yyyy') as CRDate,CFormNo, CFormAmount,Format(CFormSendDate,'dd/MM/yyyy') as CSendDate,CourierName,CourierNo,EFormNo, EFormAmount,Format(ESDate,'dd/MM/yyyy') as ESDate,Format(E1SendDate,'dd/MM/yyyy') as E1SendDate, CFormNo2, CFormAmount2,Format(CFormSendDate2,'dd/MM/yyyy') as CRDate2,CourierName2,CourierNo2,EFormNo2, EFormAmount2,Format(E1SendDate2,'dd/MM/yyyy') as E1ReceiveDate2,Format(ESDate2,'dd/MM/yyyy') as ESDate2, CFormNo3, EFormNo3,EFormAmount3,CFormAmount3,Format(CFormSendDate3,'dd/MM/yyyy') as CRDate3,CourierName3,CourierNo3, Narration,Format(E1SendDate3,'dd/MM/yyyy') as E1ReceiveDate3,Format(ESDate3,'dd/MM/yyyy') as ESDate3,Format(CFormSendDate2,'dd/MM/yyyy') as CFormSendDate2,Format(CFormSendDate3,'dd/MM/yyyy') as CFormSendDate3,ENarration,E1StatusColor", WQry, "MillName, PartyName, BillingName, YearCode, QCode")

        dgvCFormQua.DataSource = dv
        dgvCFormQua.Columns("ENarration").Width = 300
        dgvCFormQua.Columns("MillName").HeaderText = "Mill Name"
        dgvCFormQua.Columns("CountGroup").HeaderText = "Count Group"
        dgvCFormQua.Columns("PartyName").HeaderText = "Party Name"
        dgvCFormQua.Columns("BillingName").HeaderText = "Billing Name"
        dgvCFormQua.Columns("YearCode").HeaderText = "Year"
        dgvCFormQua.Columns("PName").HeaderText = "Period"
        dgvCFormQua.Columns("QCode").HeaderText = "Quarter"
        dgvCFormQua.Columns("ENarration").HeaderText = "Narration"
        dgvCFormQua.Columns("StatusColor").Visible = False
        dgvCFormQua.Columns("E1StatusColor").Visible = False
        dgvCFormQua.Columns("Status").Visible = False
        dgvCFormQua.Columns("Amount").Visible = False
        dgvCFormQua.Columns("Narration").Visible = False
        dgvCFormQua.Columns("CFormNo").HeaderText = "C Form No"
        dgvCFormQua.Columns("EStatus").HeaderText = "Status"
        dgvCFormQua.Columns("CFormAmount").HeaderText = "C Form Amount"
        dgvCFormQua.Columns("EFormNo").HeaderText = "E1 Form No"
        dgvCFormQua.Columns("EFormAmount").HeaderText = "E1 Form Amount"
        dgvCFormQua.Columns("ESDate").HeaderText = "E1 Receive Date"
        dgvCFormQua.Columns("CFormNo2").HeaderText = "C Form No 2"
        dgvCFormQua.Columns("CFormAmount2").HeaderText = "C Form Amount 2"
        dgvCFormQua.Columns("CRDate2").HeaderText = "C Form Send Date2"
        dgvCFormQua.Columns("EFormNo2").HeaderText = "E1 Form No 2"
        dgvCFormQua.Columns("EFormAmount2").HeaderText = "E1 Form Amount 2"
        dgvCFormQua.Columns("CFormNo3").HeaderText = "C Form No 3"
        dgvCFormQua.Columns("CFormAmount3").HeaderText = "C Form Amount 3"
        dgvCFormQua.Columns("CRDate3").HeaderText = "C Form Send Date 3"
        dgvCFormQua.Columns("CSendDate").HeaderText = "C Form Send Date"
        dgvCFormQua.Columns("CourierName").HeaderText = "Courier Name"
        dgvCFormQua.Columns("CourierNo").HeaderText = "Courier No"
        dgvCFormQua.Columns("CourierName2").HeaderText = "Courier Name 2"
        dgvCFormQua.Columns("CourierNo2").HeaderText = "Courier No 2"
        dgvCFormQua.Columns("ESDate2").HeaderText = "E1 Send Date 2"
        dgvCFormQua.Columns("CourierName3").HeaderText = "Courier Name 3"
        dgvCFormQua.Columns("CourierNo3").HeaderText = "Courier No 3"
        dgvCFormQua.Columns("CRDate").Visible = False
        dgvCFormQua.Columns("EFormNo3").Visible = False
        dgvCFormQua.Columns("EFormAmount3").Visible = False
        dgvCFormQua.Columns("ESDate3").HeaderText = "E1 Send Date 3"
        dgvCFormQua.Columns("E1SendDate").HeaderText = "E1 Send Date"
        dgvCFormQua.Columns("E1ReceiveDate2").HeaderText = "E1 Receive Date 2"
        dgvCFormQua.Columns("E1ReceiveDate3").HeaderText = "E1 Receive Date 3"
        dgvCFormQua.Columns("CFormSendDate2").Visible = False
        dgvCFormQua.Columns("CFormSendDate3").Visible = False

        'dgvCFormQua.Columns("MillName").ReadOnly = True
        'dgvCFormQua.Columns("PartyName").ReadOnly = True
        'dgvCFormQua.Columns("BillingName").ReadOnly = True
        'dgvCFormQua.Columns("YearCode").ReadOnly = True
        'dgvCFormQua.Columns("PName").ReadOnly = True
        'dgvCFormQua.Columns("QCode").ReadOnly = True
        'dgvCFormQua.Columns("ENarration").ReadOnly = True
        'dgvCFormQua.Columns("CFormNo").ReadOnly = True
        'dgvCFormQua.Columns("CFormAmount").ReadOnly = True
        'dgvCFormQua.Columns("CFormNo2").ReadOnly = True
        'dgvCFormQua.Columns("CFormAmount2").ReadOnly = True
        'dgvCFormQua.Columns("CRDate2").ReadOnly = True
        'dgvCFormQua.Columns("CFormNo3").ReadOnly = True
        'dgvCFormQua.Columns("CFormAmount3").ReadOnly = True
        'dgvCFormQua.Columns("CRDate3").ReadOnly = True
        'dgvCFormQua.Columns("CSendDate").ReadOnly = True
        'dgvCFormQua.Columns("CourierName").ReadOnly = True
        'dgvCFormQua.Columns("CourierNo").ReadOnly = True
        'dgvCFormQua.Columns("CourierName2").ReadOnly = True
        'dgvCFormQua.Columns("CourierNo2").ReadOnly = True
        'dgvCFormQua.Columns("CourierName3").ReadOnly = True
        'dgvCFormQua.Columns("CourierNo3").ReadOnly = True


        For i As Integer = 0 To dgvCFormQua.Rows.Count - 2
            If Val(dgvCFormQua.Item("EFormAmount", i).Value.ToString) = 0 Then
                dgvCFormQua.Item("ESDate", i).Value = ""
            End If
            If Val(dgvCFormQua.Item("EFormAmount2", i).Value.ToString) = 0 Then
                dgvCFormQua.Item("ESDate2", i).Value = ""
            End If
            If Val(dgvCFormQua.Item("CFormAmount2", i).Value.ToString) = 0 Then
                dgvCFormQua.Item("CRDate2", i).Value = ""
            End If
            If Val(dgvCFormQua.Item("CFormAmount3", i).Value.ToString) = 0 Then
                dgvCFormQua.Item("CRDate3", i).Value = ""
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CRDate2", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("CRDate2", i).Value = ""
            Else
                dgvCFormQua.Item("CRDate2", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CRDate2", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CRDate3", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("CRDate3", i).Value = ""
            Else
                dgvCFormQua.Item("CRDate3", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CRDate3", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CSendDate", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("CSendDate", i).Value = ""
            Else
                dgvCFormQua.Item("CSendDate", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CSendDate", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("ESDate", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("ESDate", i).Value = ""
            Else
                dgvCFormQua.Item("ESDate", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("ESDate", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("ESDate2", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("ESDate2", i).Value = ""
            Else
                dgvCFormQua.Item("ESDate2", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("ESDate2", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("ESDate3", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("ESDate3", i).Value = ""
            Else
                dgvCFormQua.Item("ESDate3", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("ESDate3", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("E1SendDate", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("E1SendDate", i).Value = ""
            Else
                dgvCFormQua.Item("E1SendDate", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("E1SendDate", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("E1ReceiveDate2", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("E1ReceiveDate2", i).Value = ""
            Else
                dgvCFormQua.Item("E1ReceiveDate2", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("E1ReceiveDate2", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("E1ReceiveDate3", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("E1ReceiveDate3", i).Value = ""
            Else
                dgvCFormQua.Item("E1ReceiveDate3", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("E1ReceiveDate3", i).Value.ToString)
            End If

            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CFormSendDate2", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("CFormSendDate2", i).Value = ""
            Else
                dgvCFormQua.Item("CFormSendDate2", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CFormSendDate2", i).Value.ToString)
            End If


            If String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CFormSendDate3", i).Value.ToString) = "01/01/1990" Then
                dgvCFormQua.Item("CFormSendDate3", i).Value = ""
            Else
                dgvCFormQua.Item("CFormSendDate3", i).Value = String.Format("{0:dd/MM/yyyy}", dgvCFormQua.Item("CFormSendDate3", i).Value.ToString)
            End If

            If dgvCFormQua.Item("EStatus", i).Value.ToString = "" Then
                dgvCFormQua.Item("EStatus", i).Value = "P"
            End If
            If Val(dgvCFormQua.Item("QCode", i).Value.ToString) = 1 Then
                dgvCFormQua.Item("QCode", i).Value = "1st"
            ElseIf Val(dgvCFormQua.Item("QCode", i).Value.ToString) = 2 Then
                dgvCFormQua.Item("QCode", i).Value = "2nd"
            ElseIf Val(dgvCFormQua.Item("QCode", i).Value.ToString) = 3 Then
                dgvCFormQua.Item("QCode", i).Value = "3rd"
            ElseIf Val(dgvCFormQua.Item("QCode", i).Value.ToString) = 4 Then
                dgvCFormQua.Item("QCode", i).Value = "4th"
            End If


        Next
        dgvSetE1BackColor(dgvCFormQua)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub


    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyName.Enter, cmbYear.Enter, cmbMonth.Enter, cmbMillName.Enter, cmbStatus.Enter, cmbBillingName.Enter, cmbCountGroup.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName"))
        End If
        If sender.Name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If

        If sender.Name = cmbCountGroup.Name Then
            List_Datas(cmbCountGroup, db.CountGroup.UserCodes())
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

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyName.Leave, cmbMonth.Leave, cmbYear.Leave, cmbMillName.Leave, cmbStatus.Leave, cmbBillingName.Leave, cmbCountGroup.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim MillName, PartyName, BillingName, YearCode, PName, QCode, Amount, Status, Narration, StatusColor, E1StatusColor, CFormNo, CFormAmount, CRDate, EFormNo, EFormAmount, ESDate, CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2, CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3, EStatus, CSendDate, CourierName, CourierNo, CourierName2, CourierNo2, CourierName3, CourierNo3, CFormSendDate2, CFormSendDate3, ENarration, E1SendDate, E1SendDate2, E1SendDate3 As String
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = dgvCFormQua.Rows.Count


        For i As Integer = 0 To dgvCFormQua.Rows.Count - 2
            ProgressBar1.Value = i
            Application.DoEvents()
            MillName = dgvCFormQua.Item("MillName", i).Value.ToString
            PartyName = dgvCFormQua.Item("PartyName", i).Value.ToString
            BillingName = dgvCFormQua.Item("BillingName", i).Value.ToString
            YearCode = dgvCFormQua.Item("YearCode", i).Value.ToString
            PName = dgvCFormQua.Item("PName", i).Value.ToString
            QCode = dgvCFormQua.Item("QCode", i).Value.ToString
            If QCode = "1st" Then
                QCode = "1"
            ElseIf QCode = "2nd" Then
                QCode = "2"
            ElseIf QCode = "3rd" Then
                QCode = "3"
            Else
                QCode = "4"

            End If
            Amount = dgvCFormQua.Item("Amount", i).Value.ToString
            Status = dgvCFormQua.Item("Status", i).Value.ToString
            Narration = dgvCFormQua.Item("Narration", i).Value.ToString
            StatusColor = dgvCFormQua.Item("StatusColor", i).Value.ToString
            E1StatusColor = dgvCFormQua.Item("E1StatusColor", i).Value.ToString
            CFormNo = dgvCFormQua.Item("CFormNo", i).Value.ToString
            CFormAmount = dgvCFormQua.Item("CFormAmount", i).Value.ToString
            CRDate = dgvCFormQua.Item("CRDate", i).Value.ToString
            EFormNo = dgvCFormQua.Item("EFormNo", i).Value.ToString
            EFormAmount = dgvCFormQua.Item("EFormAmount", i).Value.ToString
            ESDate = dgvCFormQua.Item("ESDate", i).Value.ToString
            CSendDate = dgvCFormQua.Item("CSendDate", i).Value.ToString
            CourierName = dgvCFormQua.Item("CourierName", i).Value.ToString
            CourierNo = dgvCFormQua.Item("CourierNo", i).Value.ToString
            ENarration = dgvCFormQua.Item("ENarration", i).Value.ToString
            CFormNo2 = dgvCFormQua.Item("CFormNo2", i).Value.ToString
            CFormAmount2 = dgvCFormQua.Item("CFormAmount2", i).Value.ToString
            CRDate2 = dgvCFormQua.Item("CRDate2", i).Value.ToString
            EFormNo2 = dgvCFormQua.Item("EFormNo2", i).Value.ToString
            EFormAmount2 = dgvCFormQua.Item("EFormAmount2", i).Value.ToString
            ESDate2 = dgvCFormQua.Item("ESDate2", i).Value.ToString

            CFormNo3 = dgvCFormQua.Item("CFormNo3", i).Value.ToString
            CFormAmount3 = dgvCFormQua.Item("CFormAmount3", i).Value.ToString
            CRDate3 = dgvCFormQua.Item("CRDate3", i).Value.ToString
            EFormNo3 = dgvCFormQua.Item("EFormNo3", i).Value.ToString
            EFormAmount3 = dgvCFormQua.Item("EFormAmount3", i).Value.ToString
            ESDate3 = dgvCFormQua.Item("ESDate3", i).Value.ToString
            EStatus = dgvCFormQua.Item("EStatus", i).Value.ToString()
            CourierName2 = dgvCFormQua.Item("CourierName2", i).Value.ToString()
            CourierNo2 = dgvCFormQua.Item("CourierNo2", i).Value.ToString()
            CourierName3 = dgvCFormQua.Item("CourierName3", i).Value.ToString()
            CourierNo3 = dgvCFormQua.Item("CourierNo3", i).Value.ToString()

            E1SendDate = dgvCFormQua.Item("E1SendDate", i).Value.ToString
            E1SendDate2 = dgvCFormQua.Item("E1ReceiveDate2", i).Value.ToString
            E1SendDate3 = dgvCFormQua.Item("E1ReceiveDate3", i).Value.ToString

            If Split(ESDate, " ").Length > 0 Then
                ESDate = Split(ESDate, " ")(0)
            End If
            If Split(ESDate, "/").Length = 3 Then
                ESDate = (New Date(Split(ESDate, "/")(2), Split(ESDate, "/")(1), Split(ESDate, "/")(0))).ToString()
            Else
                ESDate = "1/1/1990"
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

            If Split(CSendDate, " ").Length > 0 Then
                CSendDate = Split(CSendDate, " ")(0)
            End If
            If Split(CSendDate, "/").Length = 3 Then
                CSendDate = (New Date(Split(CSendDate, "/")(2), Split(CSendDate, "/")(1), Split(CSendDate, "/")(0))).ToString()
            Else
                CSendDate = "1/1/1990"
            End If
            CFormSendDate2 = dgvCFormQua.Item("CFormSendDate2", i).Value.ToString
            If Split(CFormSendDate2, " ").Length > 0 Then
                CFormSendDate2 = Split(CFormSendDate2, " ")(0)
            End If
            If Split(CFormSendDate2, "/").Length = 3 Then
                CFormSendDate2 = (New Date(Split(CFormSendDate2, "/")(2), Split(CFormSendDate2, "/")(1), Split(CFormSendDate2, "/")(0))).ToString()
            Else
                CFormSendDate2 = "1/1/1990"
            End If
            CFormSendDate3 = dgvCFormQua.Item("CFormSendDate3", i).Value.ToString
            If Split(CFormSendDate3, " ").Length > 0 Then
                CFormSendDate3 = Split(CFormSendDate3, " ")(0)
            End If
            If Split(CFormSendDate3, "/").Length = 3 Then
                CFormSendDate3 = (New Date(Split(CFormSendDate3, "/")(2), Split(CFormSendDate3, "/")(1), Split(CFormSendDate3, "/")(0))).ToString()
            Else
                CFormSendDate3 = "1/1/1990"
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
                dgvCFormQua.Item("E1StatusColor", e.RowIndex).Value = cdBox.Color.ToArgb
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
            ProgressBar1.Value = 1
            ProgressBar1.Maximum = dgv.RowCount + 1

            Dim CCol As Integer = 1

            Try
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
                    ProgressBar1.Value += 1
                    Application.DoEvents()
                Next

                xlWorkSheet.Cells.Borders.LineStyle = 1
                xlWorkBook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlExcel5, misValue, misValue, ReadOnlyRecommended:=False, CreateBackup:=False)

                xlWorkBook.Close(True)
                xlApp.Quit()

                releaseObject(xlWorkSheet)
                releaseObject(xlWorkBook)
                releaseObject(xlApp)
                ProgressBar1.Visible = False
                If (MsgBox("Process completed, Would you like to open file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                    Process.Start(SaveFileDialog1.FileName)
                End If

            Catch ex As Exception

            End Try
            
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
        dgvSetE1BackColor(dgvCFormQua)
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

    Private Sub Label1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
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

End Class