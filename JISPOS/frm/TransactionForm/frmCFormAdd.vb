Public Class frmCFormAdd
    Dim tb As JISTable = db.CFormMaster

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbMillName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbMillName, "Please Select the Mill Name")
            cmbMillName.Focus()
            RValue = False
            'ElseIf tb.State = "New" And tb.ExistUserCode(txtCustomerName.Text) And db.Ledger.ExistUserCode(txtCustomerName.Text) Then
            '    ErrorProvider1.SetError(txtCustomerName, txtCustomerName.Text + " is Already Exist. Please Enter the New Customer Name")
            '    txtCustomerName.Focus()
            '    RValue = False
        Else
            ErrorProvider1.SetError(cmbMillName, "")
        End If

        Return RValue
    End Function

    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtId.Enter, txtCode.Enter, txtNarration.Enter, txtEFormNo.Enter, txtEFormAmount.Enter, txtE1FormNo2.Enter, txtE1FormAmount2.Enter, txtCFormNo3.Enter, txtCFormNo2.Enter, txtCFormNo.Enter, txtCFormAmount3.Enter, txtCFormAmount2.Enter, txtCFormAmount.Enter, txtAmount.Enter, cmbYear.Enter, cmbStatus.Enter, cmbPeriod.Enter, cmbPartyName.Enter, cmbMillName.Enter, cmbBillingName.Enter, cmbQuarter.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtId.Leave, txtCode.Leave, txtNarration.Leave, txtEFormNo.Leave, txtEFormAmount.Leave, txtE1FormNo2.Leave, txtE1FormAmount2.Leave, txtCFormNo3.Leave, txtCFormNo2.Leave, txtCFormNo.Leave, txtCFormAmount3.Leave, txtCFormAmount2.Leave, txtCFormAmount.Leave, txtAmount.Leave, cmbYear.Leave, cmbStatus.Leave, cmbPeriod.Leave, cmbPartyName.Leave, cmbMillName.Leave, cmbBillingName.Leave, cmbQuarter.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, cmbMillName, cmbPartyName, cmbBillingName, cmbYear, cmbQuarter, txtAmount, cmbStatus, txtNarration, txtStatusColor, txtCFormNo, txtCFormAmount, dtpCReceiveDate, txtEFormNo, txtEFormAmount, dtpE1SendDate, txtCFormNo2, txtCFormAmount2, dtpCReceiveDate2, txtE1FormNo2, txtE1FormAmount2, dtpE1SendDate2, txtCFormNo3, txtCFormAmount3, dtpCReceiveDate3, txtE1FormNo3, txtE1FormAmount3, dtpE1SendDate3, dtpCReceiveDate3, txtCourierName, txtCourierNo, txtEStatus, txtCourierName2, txtCourierNo2, txtCourierName3, txtCourierNo3)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmCustomersReport)
    End Sub

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

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = NumericCheckwithsingledot(sender, e.KeyChar, False)
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
        'SaveAllRecord()
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

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ' ViewForm()
        FormShow(frmCustomerSearch)
    End Sub


    Sub NewForm()
        tb.NewRecord()
        cmbMillName.Focus()
        ' txtCustomerName.ReadOnly = False
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            'txtBil.ReadOnly = True
            ErrorProvider1.Clear()
        End If
    End Sub
    Sub SaveAllRecord()
        Dim arr As New ArrayList
        arr = tb.UserCodes()
        For i As Integer = 0 To arr.Count - 1
            txtSearchBox.Text = arr(i)
            ViewForm()
            SaveForm()
        Next
    End Sub
    Sub SaveForm()
        If FormValidate() Then
            'txtBil.Text = txtCustomerName.Text
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then

                NewForm()
            End If
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = tb.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, Me.Text, "I")
        If str = "Deleted" Then
            NewForm()
        End If
    End Sub

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        ViewForm()
    End Sub


End Class