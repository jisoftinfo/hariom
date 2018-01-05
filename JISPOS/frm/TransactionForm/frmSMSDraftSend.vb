Public Class frmSMSDraftSend

    Dim ItemState As String = "New"
    Dim tb As JISTable = db.SMSDraft

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtMessage.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtMessage, "Please Enter the Message")
            txtMessage.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtMessage, "")
        End If

        If txtPhoneNo.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtPhoneNo, "Please Enter the Phone No")
            txtPhoneNo.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtPhoneNo, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtCode.Enter, txtId.Enter, txtMessage.Enter, txtPhoneNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtId.Leave, txtCode.Leave, txtMessage.Leave, txtPhoneNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        db.SMSDraft.SetControls(txtId, txtCode, txtMessage, txtPhoneNo)

        SetFormStyle(Me)

    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then
                
            Else
                If TypeOf ctl Is TextBox Then
                    Dim txt As TextBox = DirectCast(ctl, TextBox)
                    If txt.Multiline = False Then
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

    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

        'l = (pnlContent.Width - pnlForm.Width) / 2
        'If l < 0 Then l = 0

        't = (pnlContent.Height - pnlForm.Height) / 2
        'If t < 0 Then t = 0

        'pnlForm.Left = l
        'pnlForm.Top = t
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DeleteForm()
    End Sub

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = db.SMSDraft.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                txtSearchBox.Text = ""

            End If

            ErrorProvider1.Clear()
        End If
    End Sub
   
    Sub SaveForm()
        If FormValidate() Then

            Dim str As String = ""
            Dim saveresult As String

            str = db.SMSDraft.SaveRecord()
            saveresult = str
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
            End If
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")

        End If
    End Sub

    Sub DeleteForm()
        If db.SMSDraft.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = db.SMSDraft.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
    End Sub

    Private Sub btnSendSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendSMS.Click
        Dim webClient As New System.Net.WebClient
        Dim SMSURL As String
        Dim result As String
        Dim Receiver As String
        Dim Msg As String
        Dim DCode As String

        Receiver = txtPhoneNo.Text
        Msg = txtMessage.Text
        DCode = txtCode.Text

        SMSURL = String.Format("http://enterprise.liveair.in/httpapi/httpapi?token=a511a63dbdbf7402f979368e55dad627&sender={0}&number={1}&route={2}&type={3}&sms={4}", "hariom", Receiver, "2", "1", Msg)

        result = webClient.DownloadString(SMSURL)

        If result Then
            MsgBox("Message Sending Successfully")
            db.SMSDraft.Delete("DraftCode='" + DCode + "'")
            Me.Close()
            frmSMSDraft.Show()
        End If

    End Sub
End Class