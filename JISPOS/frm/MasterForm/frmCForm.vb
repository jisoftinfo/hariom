Imports System.IO
Public Class frmCForm

    Dim tb As JISTable = db.EForm

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbMillName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbMillName, "Please Enter the Mill Name")
            cmbMillName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbMillName, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtCode.Enter, txtId.Enter, cmbMillName.Enter, txtCourierName.Enter, txtCourierNo.Enter, txtCFormNo.Enter, txtAmount.Enter, txtE1FormNo.Enter, cmbStatus.Enter, cmbPartyName.Enter, txtMonth.Enter, lblCAmount.Enter, txtCAmount.Enter, cmbBillingName.Enter, cmbYear.Enter, txtE1Amount.Enter, cmbPeriodFrom.Enter, cmbE1Status.Enter, txtE3Form.Enter, txtE2FormNo.Enter, txtCourierNo3.Enter, txtCourierNo1.Enter, txtCourier3.Enter, txtCourier1.Enter, txtC2FormNo.Enter, txtC2Amount.Enter, txtC1FormNo.Enter, txtC1Amount.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "cmbMillName" Then List_Datas(cmbMillName, db.Mill.Column("MillName"))
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If
        If sender.name = cmbBillingName.Name Then
            List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
        End If
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtId.Leave, txtCode.Leave, txtCourierName.Leave, txtCourierNo.Leave, txtCFormNo.Leave, txtAmount.Leave, cmbMillName.Leave, txtE1FormNo.Leave, cmbStatus.Leave, cmbPartyName.Leave, txtMonth.Leave, lblCAmount.Leave, txtCAmount.Leave, cmbBillingName.Leave, cmbYear.Leave, txtE1Amount.Leave, cmbPeriodFrom.Leave, cmbE1Status.Leave, txtE3Form.Leave, txtE2FormNo.Leave, txtCourierNo3.Leave, txtCourierNo1.Leave, txtCourier3.Leave, txtCourier1.Leave, txtC2FormNo.Leave, txtC2Amount.Leave, txtC1FormNo.Leave, txtC1Amount.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtMillCode, txtPartyCode, cmbBillingName, cmbPeriodFrom, cmbYear, txtAmount, txtCFormNo, txtCAmount, dtpReceiveDate, dtpSendDate, txtCourierName, txtCourierNo, txtE1FormNo, txtE1Amount, dtpE1SentDate, cmbStatus, cmbE1Status, txtC1FormNo, txtC1Amount, txtCourier1, txtCourierNo1, txtE2FormNo, dtpSendDate1, txtC2FormNo, txtC2Amount, txtCourier3, txtCourierNo3, txtE3Form, dtpSendDate2)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmCNoReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

                If ctl.Name = cmbMillName.Name Then
                    FormShow(frmCustomers)
                End If
            ElseIf ctl.Text = "@" Then
                If ctl.Name = cmbMillName.Text Then
                    FormShow(frmCustomers)
                End If
            Else
                Me.SelectNextControl(ctl, True, True, True, True)
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

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        ViewForm()
    End Sub


    Sub NewForm()
        tb.NewRecord()
        'picFrame.BackgroundImage = Nothing
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            txtSearchBox.Text = txtSearchBox.Text.Replace("'", "''")
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            If File.Exists(Application.StartupPath + "\Images\ItemMaster\" + txtCode.Text + ".jpg") Then

                Dim buffer As Byte() = File.ReadAllBytes(Application.StartupPath + "\Images\ItemMaster\" + txtCode.Text + ".jpg")
                Dim stream As MemoryStream = New MemoryStream(buffer)

                Dim bm As Bitmap = CType(Bitmap.FromStream(stream), Bitmap)

                ' picFrame.BackgroundImage = bm.Clone
                stream.Dispose()
                bm.Dispose()
                'picFrame.BackgroundImageLayout = ImageLayout.Stretch
            Else
                'picFrame.BackgroundImage = Nothing
            End If
            ' txtFile.Text = ""

            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            cmbMillName.Text = cmbMillName.Text.Replace("'", "''")
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                
                For i As Integer = 0 To dgvDetails.Rows.Count - 1
                    If dgvDetails.Item("MWCode", i).Value = Nothing Then Exit For
                    Dim Id, Code As String
                    Id = db.CFormDetails.NewId()
                    Code = db.CFormDetails.NewCode()
                    db.CFormDetails.SaveRecord(Id, Code, txtCode.Text, i + 1, dgvDetails.Item("MWCode", i).Value.ToString(), dgvDetails.Item("Amount", i).Value.ToString(), dgvDetails.Item("MWDate", i).Value.ToString())
                Next
                NewForm()
            End If


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

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FormShow(frmCNosearch)
    End Sub

    Private Sub cmbMillName_TextChanged1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.TextChanged, cmbPeriodFrom.TextChanged, cmbYear.TextChanged
        Dim M As String
        M = ""
        Try
            If cmbPeriodFrom.Text = "Apr - Jun" Then
                M = "'Aril','May','June'"
            ElseIf cmbPeriodFrom.Text = "" Then

            ElseIf cmbPeriodFrom.Text = "" Then

            ElseIf cmbPeriodFrom.Text = "" Then


            End If
            txtAmount.Text = db.MillWorking.Data("Amount", "MillName='" + cmbMillName.Text + "' And Month in(" + M + ") And Year='" + cmbYear.Text + "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpPeriodFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriodFrom.TextChanged, cmbYear.TextChanged
        Try

            txtAmount.Text = db.MillWorking.Data("Amount", "MillName='" + cmbMillName.Text + "' And Month='" + cmbPeriodFrom.Text + "' And Year='" + cmbYear.Text + "'")
            Dim DV As New DataView
            DV = db.MillWorking.Grid("MWCode,Amount,MWDate", "MillName='" + cmbMillName.Text + "' And Month='" + cmbPeriodFrom.Text + "' And Year='" + cmbYear.Text + "'")
            dgvDetails.DataSource = DV
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.TextChanged
        Try
            If cmbStatus.Text = "Finished" Then
                lblC1FormNo.Visible = False
                txtC1FormNo.Visible = False
                lblC1Amount.Visible = False
                txtC1Amount.Visible = False
                lblCourier1.Visible = False
                txtCourier1.Visible = False
                lblCourierNo1.Visible = False
                txtCourierNo1.Visible = False
                lblE2FormNo.Visible = False
                txtE2FormNo.Visible = False
                lblE2Date.Visible = False
                dtpSendDate1.Visible = False
                lblC2FormNo.Visible = False
                txtC2FormNo.Visible = False
                lblC2Amount.Visible = False
                txtC2Amount.Visible = False
                lblCourier3.Visible = False
                txtCourier3.Visible = False
                lblCourierNo3.Visible = False
                txtCourierNo3.Visible = False
                lblE3FormNo.Visible = False
                txtE3Form.Visible = False
                lblE3Date.Visible = False
                dtpSendDate2.Visible = False
            Else
                lblC1FormNo.Visible = True
                txtC1FormNo.Visible = True
                lblC1Amount.Visible = True
                txtC1Amount.Visible = True
                lblCourier1.Visible = True
                txtCourier1.Visible = True
                lblCourierNo1.Visible = True
                txtCourierNo1.Visible = True
                lblE2FormNo.Visible = True
                txtE2FormNo.Visible = True
                lblE2Date.Visible = True
                dtpSendDate1.Visible = True
                lblC2FormNo.Visible = True
                txtC2FormNo.Visible = True
                lblC2Amount.Visible = True
                txtC2Amount.Visible = True
                lblCourier3.Visible = True
                txtCourier3.Visible = True
                lblCourierNo3.Visible = True
                txtCourierNo3.Visible = True
                lblE3FormNo.Visible = True
                txtE3Form.Visible = True
                lblE3Date.Visible = True
                dtpSendDate2.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbMillName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.TextChanged
        txtMillCode.Text = db.Mill.Data("MillCode", "MillName='" + cmbMillName.Text + "'")
    End Sub

    Private Sub txtMillName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMillCode.TextChanged
        cmbMillName.Text = db.Mill.Data("MillName", "MillCode='" + txtMillCode.Text + "'")
    End Sub

    Private Sub cmbPartyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyName.TextChanged
        txtPartyCode.Text = db.Party.Data("PartyCode", "PartyName='" + cmbPartyName.Text + "'")
    End Sub

    Private Sub txtPartyCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPartyCode.TextChanged
        cmbPartyName.Text = db.Party.Data("PartyName", "PartyCode='" + txtPartyCode.Text + "'")
    End Sub
End Class