Public Class frmScheduledEMail
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

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtSubject.Enter, txtMessage.Enter, cmbType.Enter, cmbGroupName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtSubject.Leave, txtMessage.Leave, cmbType.Leave, cmbGroupName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtSubject, txtMessage, cmbType, chkSunday, chkMonday, chkTuesday, chkWednesday, chkThursday, chkFriday, chkSaturday, cmbGroupName)
        SetFormStyle(Me)
        NewForm()
        'dgvDetails.RowHeadersVisible = True
        dgvDetails.AllowUserToAddRows = True
        dgvDetails.AllowUserToDeleteRows = True
        dgvDetails.EditMode = DataGridViewEditMode.EditOnEnter
        dgvDate.AllowUserToDeleteRows = True
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
        dgvDetails.Rows.Clear()
        lstAttachedFiles.Items.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            Dim dv As New DataView
            dv = db.ScheduledEMailId.Grid("*", "MasterCode='" + txtCode.Text + "'")
            dgvDetails.Rows.Clear()
            For i As Integer = 0 To dv.Count - 1
                dgvDetails.Rows.Add()
                dgvDetails.Item("RName", i).Value = dv.Item(i)("SName").ToString()
                dgvDetails.Item("REMailId", i).Value = dv.Item(i)("EMailId").ToString()
            Next

            dv = db.ScheduledEMailDate.Grid("*", "MasterCode='" + txtCode.Text + "'")
            dgvDate.Rows.Clear()
            For i As Integer = 0 To dv.Count - 1
                dgvDate.Rows.Add()
                dgvDate.Item("SDate", i).Value = dv.Item(i)("SDate").ToString()
                dgvDate.Item("STime", i).Value = dv.Item(i)("STime").ToString()
            Next
            dv = db.ScheduledEmailAttach.Grid("*", "MasterCode='" + txtCode.Text + "'")
            lstAttachedFiles.Items.Clear()
            Dim FileName As String
            For i As Integer = 0 To dv.Count - 1
                FileName = dv.Item(i)("FileName").ToString()
                lstAttachedFiles.Items.Add(FileName)
            Next

            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            db.ScheduledEMailId.DeleteRecordByUserCode(txtCode.Text)
            db.ScheduledEMailDate.DeleteRecordByUserCode(txtCode.Text)
            db.ScheduledEmailAttach.DeleteRecordByUserCode(txtCode.Text)
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
                If SMobileNo <> "" Then
                    db.ScheduledEMailId.SaveRecord(db.ScheduledEMailId.NewId(), db.ScheduledEMailId.NewCode(), txtCode.Text, SName, SMobileNo)

                End If
            Next
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
            For K As Integer = 0 To lstAttachedFiles.Items.Count - 1
                db.ScheduledEmailAttach.SaveRecord(db.ScheduledEmailAttach.NewId(), db.ScheduledEmailAttach.NewCode(), txtCode.Text, lstAttachedFiles.Items(K))
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
        FormShow(frmScheduledEMailSearch)
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

    Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser.Click
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                lstAttachedFiles.Items.Add(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lstAttachedFiles.Items.Remove(lstAttachedFiles.SelectedItem)
    End Sub

    Private Sub btnEmailSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailSent.Click
        FormShow(frmEMail)
    End Sub

    Private Sub btnPartywiseEmailSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartywiseEmailSent.Click
        FormShow(frmPartywiseEMail)
    End Sub

    Private Sub btnMillwiseEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMillwiseEmail.Click
        FormShow(frmMillwiseEMail)
    End Sub
End Class