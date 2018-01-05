Public Class frmAutoEmail
    Dim tb As JISTable = db.ScheduledEMail

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

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, cmbType.Enter, cmbGroupName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, cmbType.Leave, cmbGroupName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtSubject, txtMessage, cmbType, chkSunday, chkMonday, chkTuesday, chkWednesday, chkThursday, chkFriday, chkSaturday, cmbGroupName)
        SetFormStyle(Me)
        NewForm()
        'dgvDetails.RowHeadersVisible = True
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmScheduledEmailReport)
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
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String
            str = ""
            
            Dim dv As New DataView
            dv = db.ScheduledEMailId.Grid("*", "MasterCode='" + txtCode.Text + "'")
            dv = db.ScheduledEMailDate.Grid("*", "MasterCode='" + txtCode.Text + "'")
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
            Dim Message, Subject As String

            str = tb.ViewRecordByCode(txtSearchBox.Text)
            Subject = "PENDING C FORM DETAIL FROM (HARI OM YARN AGENCY)"
            Message = ""
            Message += "<html><b>SUBJECT : PENDING C FORM DETAIL FROM (HARI OM YARN AGENCY)</b><br/>"
            Message += "<font style='Color:blue'/><b>DINESH TULSYAN<br/>HARIOM YARN AGENCY<br/>2/569,VAGAI ST.,GOMATHIPURAM 6TH MAIN ROAD.<br/>MADURAI -625020<br/>TAMILNADU<br/>tulsyandinesh@gmail.com,Cell +9345213033, 8220010234 Ph :  0452-4516303, 4383033,4250752, 82206-60044</b></font>"
            Message += "<br/><br/><b>Sir,WE ARE SENDING PENDING C FORM DETAIL.PLS CHECK PLS SEND ALL C FORM TO OUR MADURAI ADDRESS.</b><br/>"
            Message += "<table width='800px' height='70px' border='1px'><th>Billing Name</th><th>Mill Name</th><th>Bill Date</th><th>Invoice</th><th>No Of Bags</th><th>Bill Amount</th>"
            If frmCFormEntry.dgvCFormQua.RowCount <> 0 Then
                For i As Integer = 0 To frmCFormEntry.dgvCFormQua.RowCount - 1
                    Dim BillingName, MillName, BillDate, Invoice, NoOfBags, BillAmount As String
                    BillingName = frmCFormEntry.dgvCFormQua.Item("BillingName", i).Value
                    MillName = frmCFormEntry.dgvCFormQua.Item("MillName", i).Value
                    BillDate = frmCFormEntry.dgvCFormQua.Item("BillDate", i).Value
                    Invoice = frmCFormEntry.dgvCFormQua.Item("Invoice", i).Value
                    NoOfBags = frmCFormEntry.dgvCFormQua.Item("NoOfBags", i).Value
                    BillAmount = frmCFormEntry.dgvCFormQua.Item("BillAmount", i).Value
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
                    Message += "</table><br/>"
                    Message += "<font style='Color:blue'><b><br/><br/>Regards <br/> DINESH TULSYAN <br/>HARIOM YARN AGENCY</b></font></html>"
                Next

            End If

            txtSubject.Text = Subject
            txtMessage.Text = Message

            str = tb.SaveRecord()

            db.ScheduledEMailId.DeleteRecordByUserCode(txtCode.Text)
            db.ScheduledEMailDate.DeleteRecordByUserCode(txtCode.Text)

            For j As Integer = 0 To dgvDate.Rows.Count - 1
                Dim FValues As String

                FValues = dgvDate.Item(0, j).Value.ToString()
                If Split(FValues, " ").Length > 0 Then

                    FValues = Split(FValues, " ")(0)
                End If
                If Split(FValues, "/").Length = 3 Then
                    FValues = Split(FValues, "/")(2) + "/" + Split(FValues, "/")(1) + "/" + Split(FValues, "/")(0) + " " + dgvDate.Item("STime", j).Value.ToString()
                Else
                    FValues = "1/1/1990"
                End If
                db.ScheduledEMailDate.SaveRecord(db.ScheduledEMailDate.NewId(), db.ScheduledEMailDate.NewCode(), txtCode.Text, FValues, dgvDate.Item("STime", j).Value)
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
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        FormShow(frmAutoEmailSearch)
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

End Class