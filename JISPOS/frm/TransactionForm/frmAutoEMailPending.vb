Public Class frmAutoEMailPending
    Dim tb As JISTable = db.AutoEMailPending

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        'If txtMobileNo.Text.Trim() = "" Then
        '    ErrorProvider1.SetError(txtMobileNo, "Please Enter the MobileNo")
        '    txtMobileNo.Focus()
        '    RValue = False
        'Else
        '    ErrorProvider1.SetError(txtMobileNo, "")
        'End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, cmbType.Enter, cmbGroupName.Enter, cmbPendingType.Enter, cmbPartyName.Enter, cmbYear.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, cmbType.Leave, cmbGroupName.Leave, cmbPendingType.Leave, cmbPartyName.Leave, cmbYear.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, cmbPartyName, cmbPendingType, cmbType, chkSunday, chkMonday, chkTuesday, chkWednesday, chkThursday, chkFriday, chkSaturday, cmbGroupName, chk1st, chk2nd, chk3rd, chk4th, cmbYear)
        SetFormStyle(Me)
        NewForm()
        'dgvDetails.RowHeadersVisible = True
        'dgvDetails.AllowUserToAddRows = True
        dgvDetails.AllowUserToDeleteRows = True
        'dgvDetails.EditMode = DataGridViewEditMode.EditOnEnter
        dgvDate.AllowUserToDeleteRows = True
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmAutoEmailReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                Me.SelectNextControl(ctl, True, True, True, True)
            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If

    End Sub

    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l, t As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

        l = (pnlContent.Width - pnlForm.Width) / 2
        If l < 0 Then l = 0

        t = (pnlContent.Height - pnlForm.Height) / 2
        If t < 0 Then t = 0


        pnlForm.Left = l
        'pnlForm.Top = t
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewForm()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteForm()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub

    Sub NewForm()
        tb.NewRecord()
        ErrorProvider1.Clear()
        dgvDate.Rows.Clear()
        dgvDetails.Rows.Clear()

    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            Dim dv As New DataView
            dv = db.AutoEMailPendingEMailId.Grid("*", "MasterCode='" + txtCode.Text + "'")
            dgvDetails.Rows.Clear()
            For i As Integer = 0 To dv.Count - 1
                dgvDetails.Rows.Add()
                dgvDetails.Item("RName", i).Value = dv.Item(i)("SName").ToString()
                dgvDetails.Item("REMailId", i).Value = dv.Item(i)("EMailId").ToString()
            Next

            dv = db.AutoEMailPendingDate.Grid("*", "MasterCode='" + txtCode.Text + "'")
            dgvDate.Rows.Clear()
            For i As Integer = 0 To dv.Count - 1
                dgvDate.Rows.Add()
                dgvDate.Item("SDate", i).Value = dv.Item(i)("SDate").ToString()
                dgvDate.Item("STime", i).Value = dv.Item(i)("STime").ToString()
            Next
            
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            db.AutoEMailPendingEMailId.DeleteRecordByUserCode(txtCode.Text)
            db.AutoEMailPendingDate.DeleteRecordByUserCode(txtCode.Text)
            'db.ScheduledEmailAttach.DeleteRecordByUserCode(txtCode.Text)
            For i As Integer = 0 To dgvDetails.Rows.Count - 1
                Dim SName, SMobileNo As String

                SName = ""
                SMobileNo = ""

                If dgvDetails.Item("RName", i).Value Is Nothing Then
                    SName = ""
                Else
                    SName = dgvDetails.Item("RName", i).Value
                End If

                If dgvDetails.Item("REMailId", i).Value Is Nothing Then
                    SMobileNo = ""
                Else
                    SMobileNo = dgvDetails.Item("REMailId", i).Value
                End If

                db.AutoEMailPendingEMailId.SaveRecord(db.AutoEMailPendingEMailId.NewId(), db.AutoEMailPendingEMailId.NewCode(), txtCode.Text, SName, SMobileNo)

            Next
            For j As Integer = 0 To dgvDate.Rows.Count - 1
                Dim FValues, STime As String
                STime = ""
                FValues = dgvDate.Item(0, j).Value.ToString()
                If Split(FValues, " ").Length > 0 Then

                    FValues = Split(FValues, " ")(0)
                End If
                If Split(FValues, "/").Length = 3 Then
                    FValues = Split(FValues, "/")(2) + "/" + Split(FValues, "/")(1) + "/" + Split(FValues, "/")(0) + " " + dgvDate.Item("STime", j).Value.ToString()
                Else
                    FValues = "1/1/1990"
                End If

                If dgvDate.Item("STime", j).Value Is Nothing Then
                    STime = ""
                Else
                    STime = dgvDate.Item("STime", j).Value
                End If

                'db.AutoEMailPendingDate.SaveRecord(db.AutoEMailPendingDate.NewId(), db.AutoEMailPendingDate.NewCode(), txtCode.Text, FValues, dgvDate.Item("STime", j).Value.ToString())
                db.AutoEMailPendingDate.SaveRecord(db.AutoEMailPendingDate.NewId(), db.AutoEMailPendingDate.NewCode(), txtCode.Text, FValues, dgvDate.Item("STime", j).Value)
            Next
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = tb.DeleteRecord()
        db.AutoEMailPendingDate.DeleteRecordByUserCode(txtCode.Text)
        db.AutoEMailPendingEMailId.DeleteRecordByUserCode(txtCode.Text)
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmAutoEmailPendingSerach)
    End Sub

    Private Sub cmbType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.TextChanged

        If cmbType.Text = "SetDate" Then
            pnlWeakly.Visible = False
            dgvDate.Columns("SDate").Visible = True
        ElseIf cmbType.Text = "Weekly" Then
            pnlWeakly.Visible = True
            dgvDate.Columns("SDate").Visible = False
        Else
            pnlWeakly.Visible = False
        End If
        dtpSDate.Visible = dgvDate.Columns("SDate").Visible
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt, tm As String
        dt = dtpSDate.Value.ToString("dd/MM/yyyy")
        tm = dtpTime.Value.ToString("hh:mm tt")


        Dim i As Integer
        'For i = 0 To dgvDate.RowCount - 1
        '    If dgvDate.Item(0, i).Value.ToString() = dt And dgvDate.Item(0, i).Value.ToString() <> "" Then
        '        Exit For
        '    End If
        'Next
        'If i = dgvDate.RowCount Then
        '    dgvDate.Rows.Add()
        'End If

        dgvDate.Rows.Add()
        i = dgvDate.RowCount - 1
        dgvDate.Item(0, i).Value = dt
        dgvDate.Item(1, i).Value = tm
    End Sub

    Sub CFormPendingEmail()
        Dim WQry As String = ""
        Dim QCode As String = ""
        If chk1st.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "1"
        End If
        If chk2nd.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "2"
        End If

        If chk3rd.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "3"
        End If

        If chk4th.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "4"
        End If

        If cmbPartyName.Text <> "ALL" Then
            WQry = "PartyName in (Select SName from AutoEMailPendingEMailId where MasterCode='" + txtCode.Text + "' ) and YearCode='" + cmbYear.Text + "' and QCode in ( " + QCode + ")"
        End If

       
        Dim dv As New DataView

        dv = db.ViewMillWorking.Grid("MillName, PartyName, BillingName, YearCode, PName, QCode, SUM(Amount) AS Amount,'' as CFormNo,'' as CFormAmount,'' as CRDate,'' as Status,'' as EFormNo,'' as EFormAmount,'' as ESDate,'' as CFormNo2,'' as CFormAmount2,'' as CRDate2,'' as EFormNo2,'' as EFormAmount2,'' as ESDate2,'' as CFormNo3,'' as CFormAmount3,'' as CRDate3,'' as EFormNo3,'' as EFormAmount3,'' as ESDate3,'' as Narrration,'-1' as StatusColor", WQry, "PartyName, MillName,  BillingName, YearCode, QCode", "PartyName, MillName,  BillingName, YearCode, QCode, PName")
        dgvCFormQua.Rows.Clear()
        If dv.Count = 0 Then Exit Sub
        Dim MillName, PartyName, BillingName, YearCode, PName As String
        
        Dim dgi As Integer = -1
        ProgressBar1.Maximum = dv.Count

        For i As Integer = 0 To dv.Count - 1
            ProgressBar1.Value = i
            Application.DoEvents()
            MillName = dv.Item(i)("MillName").ToString
            PartyName = dv.Item(i)("PartyName").ToString
            BillingName = dv.Item(i)("BillingName").ToString
            YearCode = dv.Item(i)("YearCode").ToString
            PName = dv.Item(i)("PName").ToString

            WQry = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
            Dim arr As New ArrayList
            arr = db.CFormMaster.Row("Status, Narration, StatusColor, CFormNo, CFormAmount, CRDate, EFormNo, EFormAmount, ESDate,CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2,CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3,CFormSendDate,CourierName,CourierNo,EStatus,CourierName2,CourierNo2,CourierName3,CourierNo3,CFormSendDate2,CFormSendDate3,ENarration,E1SendDate,E1SendDate2,E1SendDate3", WQry)
            If arr.Count > 0 Then
                If arr(0) <> "P" Then
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

            dgvCFormQua.Item("YearCode", dgi).Value = YearCode
            dgvCFormQua.Item("PName", dgi).Value = PName
            dgvCFormQua.Item("Amount", dgi).Value = dv.Item(i)("Amount").ToString
        Next


        CFormPendingEMailSend()


    End Sub

    Sub CFormPendingEMailSend()
        Try
            Dim ObjEM As New JISEMail()
            Dim AttFiles As New ArrayList
            Dim Subject, Message, EmailId As String
            Dim BillingName, MillName, PartyName, InvoiceDate, InvoiceNo, InvoiceAmount, Year, Period As String

            PartyName = ""
            Message = ""
            Subject = "PENDING C FORM DETAIL FROM (HARI OM YARN AGENCY)"

            For i As Integer = 0 To dgvCFormQua.RowCount - 1
                If dgvCFormQua.Item("PartyName", i).Value <> "" Then
                    If dgvCFormQua.Item("PartyName", i).Value <> PartyName Then
                        If Message <> "" Then

                            'Mail Footer

                            Message += "</table><br/>"
                            Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"

                            Dim arr() As String
                            EmailId = db.Party.Data("EMailId", "LedgerName='" + PartyName + "'")
                            arr = EmailId.Split(",")
                            For k As Integer = 0 To arr.Count - 1
                                ObjEM.SendMail(arr(k), Subject, Message, AttFiles)
                            Next
                        End If
                        PartyName = dgvCFormQua.Item("PartyName", i).Value

                        'Mail Header
                        Message = "<html>"
                        Message += "<font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/><b>DINESH TULSYAN<br/>HARIOM YARN AGENCY<br/>2/569,VAGAI ST.,GOMATHIPURAM 6TH MAIN ROAD.<br/>MADURAI -625020<br/>TAMILNADU<br/></b></font>"
                        Message += "<br/>tulsyandinesh@gmail.com"
                        Message += "<br/><br/><font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/>Cell +9345213033, 8220010234</font>"
                        Message += "<br/><font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/>Ph :  0452-4516303, 4383033,4250752, 82206-60044</font>"
                        Message += "<hr/>"
                        Message += "<b>Sir,</b><br/>"
                        Message += "<p style='margin-left:50px'>WE ARE SENDING PENDING C FORM DETAIL.PLS CHECK PLS SEND ALL C FORM TO OUR MADURAI ADDRESS</p><br/>"
                        Message += "<table width='800px' height='70px' border='1px'><tr><th>Billing Name</th><th>Mill Name</th><th>Invoice Date</th><th>Invoice No</th><th>Invoice Amount</th><th>Year</th><th>Period</th><th>Amount</th></tr>"
                    End If
                End If

                Message += "<tr><td width='250px'>" + dgvCFormQua.Item("BillingName", i).Value + "</td>"
                Message += "<td width='200px'>" + dgvCFormQua.Item("MillName", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("BillDate", i).Value + "</td>"
                Message += "<td width='50px'>" + dgvCFormQua.Item("Invoice", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("BillAmount", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("YearCode", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("PName", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("Amount", i).Value + "</td></tr>"

            Next

            If Message <> "" Then

                'Mail Footer

                Message += "</table><br/>"
                Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"

                Dim arr() As String
                EmailId = db.Party.Data("EMailId", "LedgerName='" + PartyName + "'")
                arr = EmailId.Split(",")
                For k As Integer = 0 To arr.Count - 1
                    ObjEM.SendMail(arr(k), Subject, Message, AttFiles)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub OldCFormPendingEmail()
        Try
            Dim ObjEM As New JISEMail()
            Dim AttFiles As New ArrayList
            Dim Subject, Message, EmailId As String
            Dim BillingName, MillName, PartyName, InvoiceDate, InvoiceNo, InvoiceAmount, Year, Period As String

            Subject = "PENDING C FORM DETAIL FROM (HARI OM YARN AGENCY)"
            Message = ""
            Message += "<tr>"

            'Message += String.Format("Billing Name : {1}{0}Mill Name : {2}{0}Bill Date;{3}{0}Invoice:{4}{0}No Of Bags:{5}{0}Bill Amount:{6}{0}", vbCrLf, BillingName, MillName, BillDate, Invoice, NoOfBags, BillAmount)
            Message = ""
            Message += "<html>"
            Message += "<font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/><b>DINESH TULSYAN<br/>HARIOM YARN AGENCY<br/>2/569,VAGAI ST.,GOMATHIPURAM 6TH MAIN ROAD.<br/>MADURAI -625020<br/>TAMILNADU<br/></b></font>"
            Message += "<br/>tulsyandinesh@gmail.com"
            Message += "<br/><br/><font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/>Cell +9345213033, 8220010234</font>"
            Message += "<br/><font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/>Ph :  0452-4516303, 4383033,4250752, 82206-60044</font>"
            Message += "<hr/>"
            Message += "<b>Sir,</b><br/>"
            Message += "<p style='margin-left:50px'>WE ARE SENDING PENDING C FORM DETAIL.PLS CHECK PLS SEND ALL C FORM TO OUR MADURAI ADDRESS</p><br/>"
            Message += "<table width='800px' height='70px' border='1px'><th>Billing Name</th><th>Mill Name</th><th>Invoice Date</th><th>Invoice No</th><th>Invoice Amount</th><th>Year</th><th>Period</th>"

            If dgvDetails.RowCount <> 0 Then
                Dim WQry As String

                Dim dv As New DataView

                For i As Integer = 0 To dgvDetails.RowCount - 1


                    PartyName = dgvDetails.Item(0, i).Value
                    EmailId = dgvDetails.Item(1, i).Value

                    WQry = "PartyName = '" + PartyName + "' and Status = 'P'"

                    dv = db.ViewMillWorking.Grid("BillingName, MillName,MWDate As InvoiceDate,Invoice as InvoiceNo, SUM(Amount) AS InvoiceAmount,YearCode,PName", WQry, "MillName,BillingName,MWDate,Invoice,YearCode,PName", "MillName, BillingName,MWDate,Invoice,YearCode,PName")

                    For j As Integer = 0 To dv.Count - 1
                        BillingName = dv.Item(j)(0)
                        MillName = dv.Item(j)(1)
                        InvoiceDate = dv.Item(j)(2)
                        InvoiceNo = dv.Item(j)(3)
                        InvoiceAmount = dv.Item(j)(4)
                        Year = dv.Item(j)(5)
                        Period = dv.Item(j)(6)

                        If BillingName Is Nothing Then
                            BillingName = ""
                        End If
                        If MillName Is Nothing Then
                            MillName = ""
                        End If

                        If InvoiceDate Is Nothing Then
                            InvoiceDate = ""
                        End If
                        If InvoiceNo Is Nothing Then
                            InvoiceNo = ""
                        End If

                        If InvoiceAmount Is Nothing Then
                            InvoiceAmount = ""
                        End If

                        If Year Is Nothing Then
                            Year = ""
                        End If

                        If Period Is Nothing Then
                            Period = ""
                        End If


                        Message += "<tr><td width='250px'>" + BillingName + "</td>"
                        Message += "<td width='200px'>" + MillName + "</td>"
                        Message += "<td width='100px'>" + InvoiceDate + "</td>"
                        Message += "<td width='50px'>" + InvoiceNo + "</td>"
                        Message += "<td width='100px'>" + InvoiceAmount + "</td>"
                        Message += "<td width='100px'>" + Year + "</td>"
                        Message += "<td width='100px'>" + Period + "</td></tr>"


                    Next



                    Message += "</table><br/>"
                    Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"
                    Dim arr() As String
                    arr = EmailId.Split(",")
                    For k As Integer = 0 To arr.Count - 1
                        ObjEM.SendMail(arr(k), Subject, Message, AttFiles)
                    Next

                Next


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEmailSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailSent.Click
        Me.Enabled = False
        pnlPStaus.Visible = True
        Try
            If cmbPendingType.Text = "C Form" Then
                CFormPendingEmail()
            ElseIf cmbPendingType.Text = "E Form" Then
                EFormPendingEmail()
            ElseIf cmbPendingType.Text = "Party Payment" Then
                PartPendingEmail()
            ElseIf cmbPendingType.Text = "Mill Payment" Then
                MillPendingEmail()
            End If
        Catch ex As Exception

        End Try        
        pnlPStaus.Visible = False
        Me.Enabled = True
    End Sub
    'Sub EFormPendingEmail()
    '    Dim WQry As String = ""

    '    If cmbPartyName.Text <> "ALL" Then
    '        WQry = "MillName in (Select SName from AutoEMailPendingEMailId where MasterCode='" + txtCode.Text + "' )"
    '    End If


    '    Dim dv As New DataView

    '    dv = db.ViewMillWorking.Grid("MillName, PartyName, BillingName, YearCode, PName, QCode, SUM(Amount) AS Amount,'' as CFormNo,'' as CFormAmount,'' as CRDate,'' as Status,'' as EFormNo,'' as EFormAmount,'' as ESDate,'' as CFormNo2,'' as CFormAmount2,'' as CRDate2,'' as EFormNo2,'' as EFormAmount2,'' as ESDate2,'' as CFormNo3,'' as CFormAmount3,'' as CRDate3,'' as EFormNo3,'' as EFormAmount3,'' as ESDate3,'' as Narrration,'-1' as StatusColor", WQry, "MillName, PartyName, BillingName, YearCode, QCode", "MillName, PartyName, BillingName, YearCode, QCode, PName")
    '    dgvCFormQua.Rows.Clear()
    '    If dv.Count = 0 Then Exit Sub
    '    Dim MillName, PartyName, BillingName, YearCode, PName As String

    '    Dim dgi As Integer = -1

    '    For i As Integer = 0 To dv.Count - 1

    '        MillName = dv.Item(i)("MillName").ToString
    '        PartyName = dv.Item(i)("PartyName").ToString
    '        BillingName = dv.Item(i)("BillingName").ToString
    '        YearCode = dv.Item(i)("YearCode").ToString
    '        PName = dv.Item(i)("PName").ToString

    '        WQry = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
    '        Dim arr As New ArrayList
    '        arr = db.CFormMaster.Row("Status, Narration, StatusColor, CFormNo, CFormAmount, CRDate, EFormNo, EFormAmount, ESDate,CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2,CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3,CFormSendDate,CourierName,CourierNo,EStatus,CourierName2,CourierNo2,CourierName3,CourierNo3,CFormSendDate2,CFormSendDate3,ENarration,E1SendDate,E1SendDate2,E1SendDate3", WQry)
    '        If arr.Count > 0 Then
    '            If arr(0) <> "P" Then
    '                Continue For
    '            End If
    '        End If
    '        dgvCFormQua.Rows.Add()
    '        dgi += 1

    '        dgvCFormQua.Columns("Narration").Width = 300
    '        dgvCFormQua.Item("MillName", dgi).Value = MillName
    '        dgvCFormQua.Item("PartyName", dgi).Value = PartyName
    '        dgvCFormQua.Item("BillingName", dgi).Value = BillingName
    '        dgvCFormQua.Item("QCode", dgi).Value = dv.Item(i)("QCode").ToString

    '        dgvCFormQua.Item("Status", dgi).Value = "P"
    '        dgvCFormQua.Item("Narration", dgi).Value = ""
    '        dgvCFormQua.Item("StatusColor", dgi).Value = "-1"
    '        dgvCFormQua.Item("CFormNo", dgi).Value = ""
    '        dgvCFormQua.Item("CFormAmount", dgi).Value = ""
    '        dgvCFormQua.Item("CRDate", dgi).Value = ""
    '        dgvCFormQua.Item("EFormNo", dgi).Value = ""
    '        dgvCFormQua.Item("EFormAmount", dgi).Value = ""
    '        dgvCFormQua.Item("ESDate", dgi).Value = ""
    '        dgvCFormQua.Item("CFormNo2", dgi).Value = ""
    '        dgvCFormQua.Item("CFormAmount2", dgi).Value = ""
    '        dgvCFormQua.Item("CRDate2", dgi).Value = ""
    '        dgvCFormQua.Item("EFormNo2", dgi).Value = ""
    '        dgvCFormQua.Item("EFormAmount2", dgi).Value = ""
    '        dgvCFormQua.Item("ESDate2", dgi).Value = ""
    '        dgvCFormQua.Item("CFormNo3", dgi).Value = ""
    '        dgvCFormQua.Item("CFormAmount3", dgi).Value = ""
    '        dgvCFormQua.Item("CRDate3", dgi).Value = ""
    '        dgvCFormQua.Item("EFormNo3", dgi).Value = ""
    '        dgvCFormQua.Item("EFormAmount3", dgi).Value = ""
    '        dgvCFormQua.Item("ESDate3", dgi).Value = ""
    '        dgvCFormQua.Item("CFormSendDate", dgi).Value = ""
    '        dgvCFormQua.Item("CourierName", dgi).Value = ""
    '        dgvCFormQua.Item("CourierNo", dgi).Value = ""
    '        dgvCFormQua.Item("CourierName2", dgi).Value = ""
    '        dgvCFormQua.Item("CourierNo2", dgi).Value = ""
    '        dgvCFormQua.Item("CourierName3", dgi).Value = ""
    '        dgvCFormQua.Item("CourierNo3", dgi).Value = ""
    '        dgvCFormQua.Item("CFormSendDate2", dgi).Value = ""
    '        dgvCFormQua.Item("CFormSendDate3", dgi).Value = ""
    '        dgvCFormQua.Item("ENarration", dgi).Value = ""

    '        If arr.Count > 0 Then
    '            dgvCFormQua.Item("Status", dgi).Value = arr(0)
    '            dgvCFormQua.Item("Narration", dgi).Value = arr(1)
    '            dgvCFormQua.Item("StatusColor", dgi).Value = arr(2)
    '            dgvCFormQua.Item("CFormNo", dgi).Value = arr(3)
    '            dgvCFormQua.Item("CFormAmount", dgi).Value = arr(4).ToString()

    '            If String.Format("{0:dd/MM/yyyy}", arr(5)) = "01/01/1990" Then
    '                dgvCFormQua.Item("CRDate", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("CRDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(5))
    '            End If

    '            dgvCFormQua.Item("EFormNo", dgi).Value = arr(6)
    '            dgvCFormQua.Item("EFormAmount", dgi).Value = arr(7)

    '            If String.Format("{0:dd/MM/yyyy}", arr(8)) = "01/01/1990" Then
    '                dgvCFormQua.Item("ESDate", dgi).Value = ""
    '            Else

    '                dgvCFormQua.Item("ESDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(8))
    '            End If

    '            dgvCFormQua.Item("CFormNo2", dgi).Value = arr(9)
    '            dgvCFormQua.Item("CFormAmount2", dgi).Value = arr(10)

    '            If String.Format("{0:dd/MM/yyyy}", arr(11)) = "01/01/1990" Then
    '                dgvCFormQua.Item("CRDate2", dgi).Value = ""
    '            Else

    '                dgvCFormQua.Item("CRDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(11))
    '            End If

    '            dgvCFormQua.Item("EFormAmount2", dgi).Value = arr(13)

    '            dgvCFormQua.Item("EFormNo2", dgi).Value = arr(12)

    '            If String.Format("{0:dd/MM/yyyy}", arr(14)) = "01/01/1990" Then
    '                dgvCFormQua.Item("ESDate2", dgi).Value = ""
    '            Else

    '                dgvCFormQua.Item("ESDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(14))
    '            End If


    '            dgvCFormQua.Item("CFormNo3", dgi).Value = arr(15)
    '            dgvCFormQua.Item("CFormAmount3", dgi).Value = arr(16)

    '            If String.Format("{0:dd/MM/yyyy}", arr(17)) = "01/01/1990" Then
    '                dgvCFormQua.Item("CRDate3", dgi).Value = ""
    '            Else

    '                dgvCFormQua.Item("CRDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(17))
    '            End If

    '            dgvCFormQua.Item("EFormNo3", dgi).Value = arr(18)
    '            dgvCFormQua.Item("EFormAmount3", dgi).Value = arr(19)

    '            If String.Format("{0:dd/MM/yyyy}", arr(20)) = "01/01/1990" Then
    '                dgvCFormQua.Item("ESDate3", dgi).Value = ""
    '            Else

    '                dgvCFormQua.Item("ESDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(20))
    '            End If

    '            dgvCFormQua.Item("CourierNo", dgi).Value = arr(23)
    '            dgvCFormQua.Item("CourierName", dgi).Value = arr(22)

    '            If String.Format("{0:dd/MM/yyyy}", arr(21)) = "01/01/1990" Then
    '                dgvCFormQua.Item("CFormSendDate", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("CFormSendDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(21))
    '            End If

    '            If String.Format("{0:dd/MM/yyyy}", arr(5)) = "01/01/1990" Then
    '                dgvCFormQua.Item("CFormSendDate2", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("CFormSendDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(29))
    '            End If

    '            If String.Format("{0:dd/MM/yyyy}", arr(5)) = "01/01/1990" Then
    '                dgvCFormQua.Item("CFormSendDate3", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("CFormSendDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(30))
    '            End If

    '            If arr(25) = "" Then
    '                dgvCFormQua.Item("CourierNo2", dgi).Value = ""
    '                dgvCFormQua.Item("CourierName2", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("CourierNo2", dgi).Value = arr(25)
    '                dgvCFormQua.Item("CourierName2", dgi).Value = arr(26)
    '            End If
    '            If arr(27) = "" Then
    '                dgvCFormQua.Item("CourierNo3", dgi).Value = ""
    '                dgvCFormQua.Item("CourierName3", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("CourierNo3", dgi).Value = arr(27)
    '                dgvCFormQua.Item("CourierName3", dgi).Value = arr(28)
    '            End If

    '            If arr(31) = "" Then
    '                dgvCFormQua.Item("ENarration", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("ENarration", dgi).Value = arr(31)
    '            End If

    '            If String.Format("{0:dd/MM/yyyy}", arr(32)) = "01/01/1990" Then
    '                dgvCFormQua.Item("E1SendDate", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("E1SendDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(32))
    '            End If

    '            If String.Format("{0:dd/MM/yyyy}", arr(33)) = "01/01/1990" Then
    '                dgvCFormQua.Item("E1SendDate2", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("E1SendDate2", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(33))
    '            End If

    '            If String.Format("{0:dd/MM/yyyy}", arr(34)) = "01/01/1990" Then
    '                dgvCFormQua.Item("E1SendDate3", dgi).Value = ""
    '            Else
    '                dgvCFormQua.Item("E1SendDate3", dgi).Value = String.Format("{0:dd/MM/yyyy}", arr(34))
    '            End If

    '            dgvCFormQua.Item("EStatus", dgi).Value = arr(24)
    '        End If

    '        WQry = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
    '        Dim dvDetails As New DataView
    '        dvDetails = db.ViewMillWorking.Grid("MWDate as BillDate,Invoice,NoOfBags,Amount", WQry, "MWDate")
    '        For j As Integer = 0 To dvDetails.Count - 1
    '            dgvCFormQua.Item("BillDate", dgi).Value = String.Format("{0:dd/MM/yyyy}", dvDetails.Item(j)("BillDate"))
    '            dgvCFormQua.Item("Invoice", dgi).Value = dvDetails.Item(j)("Invoice").ToString
    '            dgvCFormQua.Item("NoOfBags", dgi).Value = dvDetails.Item(j)("NoOfBags").ToString
    '            dgvCFormQua.Item("BillAmount", dgi).Value = dvDetails.Item(j)("Amount").ToString
    '            dgvCFormQua.Rows.Add()
    '            dgi += 1
    '        Next

    '        dgvCFormQua.Item("YearCode", dgi).Value = YearCode
    '        dgvCFormQua.Item("PName", dgi).Value = PName
    '        dgvCFormQua.Item("Amount", dgi).Value = dv.Item(i)("Amount").ToString
    '    Next


    '    EFormPendingEMailSend()

    'End Sub

    Sub EFormPendingEmail()

        Dim WQry As String = ""
        Dim QCode As String = ""
        If chk1st.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "1"
        End If
        If chk2nd.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "2"
        End If

        If chk3rd.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "3"
        End If

        If chk4th.Checked = True Then
            If QCode <> "" Then QCode += ","
            QCode += "4"
        End If

        'If cmbPartyName.Text <> "ALL" Then
        '    WQry = "PartyName in (Select SName from AutoEMailPendingEMailId where MasterCode='" + txtCode.Text + "' ) and YearCode='" + cmbYear.Text + "' and QCode in ( " + QCode + ")"
        'End If


        If cmbPartyName.Text <> "ALL" Then
            If QCode <> "" And cmbYear.Text <> "" Then
                WQry = "MillName in (Select SName from AutoEMailPendingEMailId where MasterCode='" + txtCode.Text + "' ) and YearCode='" + cmbYear.Text + "' and QCode in ( " + QCode + ")"
            ElseIf cmbYear.Text <> "" Then
                WQry = "MillName='" + cmbPartyName.Text + "' and YearCode='" + cmbYear.Text + "' and QCode in (1,2,3,4)"
            Else

                WQry = "MillName='" + cmbPartyName.Text + "' and YearCode=' 2014 -  2015' and QCode in (1,2,3,4)"
            End If

        End If

        'Dim WQry As String = ""

        ' If cmbPartyName.Text <> "ALL" Then
        'WQry = "MillName in (Select SName from AutoEMailPendingEMailId where MasterCode='" + txtCode.Text + "' )"
        ' End If


        Dim dv As New DataView

        dv = db.ViewMillWorking.Grid("MillName, PartyName, BillingName, YearCode, PName, QCode, SUM(Amount) AS Amount,'' as CFormNo,'' as CFormAmount,'' as CRDate,'' as Status,'' as EFormNo,'' as EFormAmount,'' as ESDate,'' as CFormNo2,'' as CFormAmount2,'' as CRDate2,'' as EFormNo2,'' as EFormAmount2,'' as ESDate2,'' as CFormNo3,'' as CFormAmount3,'' as CRDate3,'' as EFormNo3,'' as EFormAmount3,'' as ESDate3,'' as Narrration,'-1' as StatusColor", WQry, "MillName, PartyName, BillingName, YearCode, QCode", "MillName, PartyName, BillingName, YearCode, QCode, PName")
        dgvCFormQua.Rows.Clear()
        If dv.Count = 0 Then Exit Sub
        Dim MillName, PartyName, BillingName, YearCode, PName As String

        Dim dgi As Integer = -1

        For i As Integer = 0 To dv.Count - 1

            MillName = dv.Item(i)("MillName").ToString
            PartyName = dv.Item(i)("PartyName").ToString
            BillingName = dv.Item(i)("BillingName").ToString
            YearCode = dv.Item(i)("YearCode").ToString
            PName = dv.Item(i)("PName").ToString

            WQry = String.Format("MillName='{0}' and PartyName='{1}' and BillingName='{2}' and YearCode='{3}' and PName='{4}'", MillName, PartyName, BillingName, YearCode, PName)
            Dim arr As New ArrayList
            arr = db.CFormMaster.Row("Status, Narration, StatusColor, CFormNo, CFormAmount, CRDate, EFormNo, EFormAmount, ESDate,CFormNo2, CFormAmount2, CRDate2, EFormNo2, EFormAmount2, ESDate2,CFormNo3, CFormAmount3, CRDate3, EFormNo3, EFormAmount3, ESDate3,CFormSendDate,CourierName,CourierNo,EStatus,CourierName2,CourierNo2,CourierName3,CourierNo3,CFormSendDate2,CFormSendDate3,ENarration,E1SendDate,E1SendDate2,E1SendDate3", WQry)
            If arr.Count > 0 Then
                If arr(0) <> "P" Then
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

            dgvCFormQua.Item("YearCode", dgi).Value = YearCode
            dgvCFormQua.Item("PName", dgi).Value = PName
            dgvCFormQua.Item("Amount", dgi).Value = dv.Item(i)("Amount").ToString
        Next


        EFormPendingEMailSend()

    End Sub

    Sub PartPendingEmail()

    End Sub
    Sub MillPendingEmail()

    End Sub
    Private Sub cmbPendingType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPendingType.TextChanged

        cmbPartyName.Items.Clear()
        cmbPartyName.Items.Add("ALL")



        If cmbPendingType.Text = "E Form" Or cmbPendingType.Text = "Mill Payment" Then
            lblPartyName.Text = "Mill Name"
            List_Datas(cmbPartyName, db.Mill.UserCodes(), True)
        ElseIf cmbPendingType.Text = "C Form" Or cmbPendingType.Text = "Party Payment" Then
            lblPartyName.Text = "Party Name"
            List_Datas(cmbPartyName, db.Party.UserCodes(), True)
        End If

    End Sub

    Private Sub btnMPName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMPName.Click
        Dim i As Integer

        If cmbPartyName.Text = "ALL" Then
            dgvDetails.Rows.Clear()

            Dim dv As New DataView

            dv = db.Party.Grid("LedgerName,EMailId")
            For i = 0 To dv.Count - 1
                dgvDetails.Rows.Add()
                dgvDetails.Item(0, i).Value = dv.Item(i)(0).ToString
                dgvDetails.Item(1, i).Value = dv.Item(i)(1).ToString
            Next
        Else

    
            For i = 0 To dgvDetails.RowCount - 1
                If dgvDetails.Item(0, dgvDetails.RowCount - 1).Value = cmbPartyName.Text Then
                    Exit For
                End If
            Next
            If i = dgvDetails.RowCount Then
                dgvDetails.Rows.Add()
                dgvDetails.Item(0, dgvDetails.RowCount - 1).Value = cmbPartyName.Text


                If cmbPendingType.Text = "E Form" Or cmbPendingType.Text = "Mill Payment" Then
                    dgvDetails.Item(1, dgvDetails.RowCount - 1).Value = db.Mill.Data("EMailId", "LedgerName='" + cmbPartyName.Text + "'")
                ElseIf cmbPendingType.Text = "C Form" Or cmbPendingType.Text = "Party Payment" Then
                    dgvDetails.Item(1, dgvDetails.RowCount - 1).Value = db.Party.Data("EMailId", "LedgerName='" + cmbPartyName.Text + "'")
                End If
            End If
        End If
        

    End Sub
    Sub EFormPendingEMailSend()
        Try
            Dim ObjEM As New JISEMail()
            Dim AttFiles As New ArrayList
            Dim Subject, Message, EmailId As String
            Dim BillingName, MillName, PartyName, InvoiceDate, InvoiceNo, InvoiceAmount, Year, Period As String

            PartyName = ""
            Message = ""
            Subject = "PENDING E FORM DETAIL FROM (HARI OM YARN AGENCY)"

            For i As Integer = 0 To dgvCFormQua.RowCount - 1
                If dgvCFormQua.Item("MillName", i).Value <> "" Then
                    If dgvCFormQua.Item("MillName", i).Value <> PartyName Then
                        If Message <> "" Then

                            'Mail Footer

                            Message += "</table><br/>"
                            Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"

                            Dim arr() As String
                            EmailId = db.Mill.Data("EMailId", "LedgerName='" + PartyName + "'")
                            arr = EmailId.Split(",")
                            For k As Integer = 0 To arr.Count - 1
                                ObjEM.SendMail(arr(k), Subject, Message, AttFiles)
                            Next
                        End If
                        PartyName = dgvCFormQua.Item("PartyName", i).Value

                        MillName = dgvCFormQua.Item("MillName", i).Value
                        'Mail Header
                        Message = "<html>"
                        Message += "<font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/><b>DINESH TULSYAN<br/>HARIOM YARN AGENCY<br/>2/569,VAGAI ST.,GOMATHIPURAM 6TH MAIN ROAD.<br/>MADURAI -625020<br/>TAMILNADU<br/></b></font>"
                        Message += "<br/>tulsyandinesh@gmail.com"
                        Message += "<br/><br/><font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/>Cell +9345213033, 8220010234</font>"
                        Message += "<br/><font style='Color:blue;font-family:arial black,sans-serif;font-Size:10pt;font-weight:bold;line-height:20px'/>Ph :  0452-4516303, 4383033,4250752, 82206-60044</font>"
                        Message += "<hr/>"
                        Message += "<b>Sir,</b><br/>"
                        Message += "<p style='margin-left:50px'>WE ARE SENDING PENDING C FORM DETAIL.PLS CHECK PLS SEND ALL C FORM TO OUR MADURAI ADDRESS</p><br/>"
                        Message += "<table width='800px' height='70px' border='1px'><th>Billing Name</th><th>Mill Name</th><th>Invoice Date</th><th>Invoice No</th><th>Invoice Amount</th><th>Year</th><th>Period</th>"
                    End If
                End If

                Message += "<tr><td width='250px'>" + dgvCFormQua.Item("BillingName", i).Value + "</td>"
                Message += "<td width='200px'>" + dgvCFormQua.Item("MillName", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("BillDate", i).Value + "</td>"
                Message += "<td width='50px'>" + dgvCFormQua.Item("Invoice", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("BillAmount", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("YearCode", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("PName", i).Value + "</td>"
                Message += "<td width='100px'>" + dgvCFormQua.Item("Amount", i).Value + "</td></tr>"

            Next

            If Message <> "" Then

                'Mail Footer

                Message += "</table><br/>"
                Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"

                Dim arr() As String
                EmailId = db.Mill.Data("EMailId", "LedgerName='" + MillName + "'")
                arr = EmailId.Split(",")
                For k As Integer = 0 To arr.Count - 1
                    ObjEM.SendMail(arr(k), Subject, Message, AttFiles)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class