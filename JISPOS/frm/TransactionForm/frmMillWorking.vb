Public Class frmMillWorking
    Dim ItemState As String = "New"
    Dim tb As JISTable = db.MillWorking

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbMillName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbMillName, "Please Enter the Mill Name")
            cmbMillName.Focus()
            RValue = False
        ElseIf Not db.Mill.ExistUserCode(cmbMillName.Text.Trim()) Then
            ErrorProvider1.SetError(cmbMillName, "Mill Name does not Exist")
            cmbMillName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbMillName, "")
        End If

        If cmbPartyName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPartyName, "Please Enter the Party Name")
            cmbPartyName.Focus()
            RValue = False
        ElseIf Not db.Party.ExistData("PartyName", cmbPartyName.Text.Trim()) Then
            ErrorProvider1.SetError(cmbPartyName, "Party Name does not Exist")
            cmbPartyName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPartyName, "")
        End If
        Dim tmpCode As String
        tmpCode = db.ViewMillWorking.Data("MWCode", String.Format("Invoice='{0}' and MillName='{1}' and PartyName='{2}'", txtInvoiceNo.Text, cmbMillName.Text, cmbPartyName.Text))
        If txtInvoiceNo.Text <> "" And cmbMillName.Text <> "" And cmbPartyName.Text <> "" And tmpCode <> "" And tmpCode <> txtCode.Text Then
            ErrorProvider1.SetError(txtInvoiceNo, "Invoice No Already Exist")
            txtInvoiceNo.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtInvoiceNo, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtCode.Enter, txtId.Enter, cmbMillName.Enter, txtNoOfBags.Enter, txtWeight.Enter, txtInvoiceNo.Enter, txtAmount.Enter, txtTotalKg.Enter, cmbPartyName.Enter, txtRate.Enter, txtCount.Enter, cmbBillingName.Enter, txtYear.Enter, txtMonth.Enter, txtItemAmount.Enter, txtRec0.Enter, txtTotalAmount.Enter, txtReceivAmount.Enter, txtRec3.Enter, txtRec2.Enter, txtRec1.Enter, txtBalance.Enter, cmbStatus.Enter, txtConNo.Enter, txtTransportName.Enter, txtLRNo.Enter, txtConNo4.Enter, txtConNo3.Enter, txtConNo2.Enter, txtActualBags4.Enter, txtActualBags3.Enter, txtActualBags2.Enter, txtActualBags.Enter, txtTransport.Enter, txtLorryNo.Enter, txtLorryFreight.Enter
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

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtId.Leave, txtCode.Leave, txtNoOfBags.Leave, txtWeight.Leave, txtInvoiceNo.Leave, txtAmount.Leave, cmbMillName.Leave, txtTotalKg.Leave, cmbPartyName.Leave, txtRate.Leave, txtCount.Leave, cmbBillingName.Leave, txtYear.Leave, txtMonth.Leave, txtItemAmount.Leave, txtRec0.Leave, txtTotalAmount.Leave, txtReceivAmount.Leave, txtRec3.Leave, txtRec2.Leave, txtRec1.Leave, txtBalance.Leave, cmbStatus.Leave, txtConNo.Leave, txtTransportName.Leave, txtLRNo.Leave, txtConNo4.Leave, txtConNo3.Leave, txtConNo2.Leave, txtActualBags4.Leave, txtActualBags3.Leave, txtActualBags2.Leave, txtActualBags.Leave, txtTransport.Leave, txtLorryNo.Leave, txtLorryFreight.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        db.MillWorking.SetControls(txtId, txtCode, dtpDate, txtInvoiceNo, txtMillCode, txtPartyCode, txtNoOfBags, txtWeight, txtTotalKg, txtRate, txtAmount, txtCount, txtMonth, txtYear, cmbBillingName, txtRec0, txtRec1, txtRec2, txtRec3, dtpRecDate0, dtpRecDate1, dtpRecDate2, dtpRecDate3, cmbStatus, txtNarration, cmbColor, txtConNo, txtActualBags, txtConNo2, txtConNo3, txtConNo4, txtActualBags2, txtActualBags3, txtActualBags4, txtStatusMC, txtTransport, txtLorryNo, txtLorryFreight)
        db.MillWorkingDetails.SetControls(txtpdid, txtpdcode, txtPCode, txtSNo, dtpReceivedDate, txtItemAmount)
        db.SubMillWorking.SetControls(txtSMId, txtSMCode, txtCode, txtConNo, txtConNo2, txtConNo3, txtConNo4)
        SetFormStyle(Me)

        dgvDetails.Columns("SNo").Width = txtSNo.Width
        dgvDetails.Columns("ReceivedDate").Width = dtpReceivedDate.Width - 5
        dgvDetails.Columns("Amount").Width = txtItemAmount.Width

        dgvDetails.ColumnHeadersVisible = False
        dgvDetails.RowHeadersVisible = False
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmMilWorkingReport)
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
        ErrorProvider1.Clear()

        dgvDetails.Rows.Clear()
        db.MillWorking.NewRecord()
        txtBalance.Text = ""
        cmbStatus.Text = "P"
        cmbMillName.Text = ""
        cmbPartyName.Text = ""

        NewItem()
        picColor.BackColor = Color.White
        cmbColor.Text = picColor.BackColor.ToArgb
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = db.MillWorking.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                txtSearchBox.Text = ""
                picColor.BackColor = Color.FromArgb(Val(cmbColor.Text))

                Dim dv As New DataView

                dv = db.MillWorkingDetails.Grid("*", "MWCode='" + txtCode.Text + "'")
                dgvDetails.Rows.Clear()
                For i As Integer = 0 To dv.Count - 1
                    dgvDetails.Rows.Add()
                    dgvDetails.Item("SNo", i).Value = dv.Item(i)("sno").ToString()
                    dgvDetails.Item("ReceivedDate", i).Value = dv.Item(i)("RecdDate").ToString()
                    dgvDetails.Item("Amount", i).Value = dv.Item(i)("Amount").ToString()

                Next
            End If
            FindTotalAmount()
            NewItem()
            ErrorProvider1.Clear()
        End If
    End Sub
    Sub ViewItem(ByVal i As Integer)
        ItemState = "Edit"
        txtSNo.Text = dgvDetails.Item("SNo", i).Value
        dtpReceivedDate.Text = dgvDetails.Item("ReceivedDate", i).Value
        txtItemAmount.Text = dgvDetails.Item("Amount", i).Value
        txtPCode.Text = txtCode.Text
    End Sub
    Sub SaveForm()
        If FormValidate() Then

            Dim str As String = ""
            Dim saveresult As String
            
            str = db.MillWorking.SaveRecord()
            saveresult = str
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                db.SubMillWorking.SaveRecord()
                db.MillWorkingDetails.DeleteRecordByUserCode(txtCode.Text)

                For i As Integer = 0 To dgvDetails.Rows.Count - 1
                    If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
                    db.MillWorkingDetails.NewRecord()
                    ViewItem(i)

                    db.MillWorkingDetails.SaveRecord()

                Next


            End If
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If db.MillWorking.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str, MWCode As String
        MWCode = txtCode.Text
        If (db.DebitNodeDetials.ExistData("MWCode", MWCode)) Then
            str = "This Data Connected In Mill Debit Note.Can not be delete"
            MsgDialog.ShowMsgDlg(str, "NOT DELETE", "I")
        ElseIf (db.DebitNoteDetailsParty.ExistData("MWCode", MWCode)) Then
            str = "This Data Connected In Party Debit Note.Can not be delete"
            MsgDialog.ShowMsgDlg(str, "NOT DELETE", "I")
        Else
            db.MillWorkingDetails.DeleteRecordByUserCode(txtCode.Text)
            db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
            str = db.MillWorking.DeleteRecord()
            MsgDialog.ShowMsgDlg(str, "DELETE", "I")
            NewForm()
        End If
        
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FormShow(frmMillWorkingSearch)
    End Sub


    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        Try
            txtMonth.Text = String.Format("{0:MMMM}", dtpDate.Value)
            'MsgBox(String.Format("{}", dtpDate.Value))
            txtYear.Text = String.Format("{0:yyyy}", dtpDate.Value) & " - " & String.Format("{0:yyyy}", dtpDate.Value) + 1
            ' txtYear.Text = Now.Year() & " - " & Now.Year + 1

        Catch ex As Exception

        End Try

    End Sub
    Sub NewItem()
        ItemState = "New"
        db.MillWorkingDetails.NewRecord()

        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("SNo", i).Value = Nothing Then
                txtSNo.Text = i + 1
                Exit For
            End If
        Next
        If Val(txtSNo.Text) = 0 Then txtSNo.Text = 1
        txtPCode.Text = txtCode.Text
        ErrorProvider1.Clear()
    End Sub
    Sub FindTotalAmount()
        Dim IAmt As Double
        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
            IAmt = IAmt + Val(dgvDetails.Item("Amount", i).Value)
        Next

    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NewItem()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        ViewItem(dgvDetails.CurrentRow.Index)
    End Sub
    Sub DeleteItem()
        dgvDetails.Rows.Remove(dgvDetails.CurrentRow)
        Try
            For i As Integer = dgvDetails.CurrentRow.Index To dgvDetails.Rows.Count - 1
                If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
                dgvDetails.Item("SNo", i).Value = i + 1
            Next
        Catch ex As Exception

        End Try

        NewItem()
        FindTotalAmount()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgDialog.ShowMsgDlg("Do you Delete this Item?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then
            DeleteItem()
            MsgDialog.ShowMsgDlg("Deleted", Me.Text, "I")
        End If
    End Sub
    Sub SaveItem()

        If txtItemAmount.Text.Trim() = "" Then
            MsgDialog.ShowMsgDlg("Please Enter The Amount", Me.Text, "I")
            txtItemAmount.Focus()
            Exit Sub
        ElseIf Val(txtItemAmount.Text) < 0 Then
            MsgDialog.ShowMsgDlg("Please Enter The Amount as Positive", Me.Text, "I")
            txtItemAmount.Focus()
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("Amount", i).Value = Nothing Then Exit For
        Next
        If i = dgvDetails.Rows.Count Then dgvDetails.Rows.Add()

        dgvDetails.Item("SNo", i).Value = i + 1
        dgvDetails.Item("ReceivedDate", i).Value = dtpReceivedDate.Text
        dgvDetails.Item("Amount", i).Value = txtItemAmount.Text

        FindTotalAmount()
        NewItem()
        txtItemAmount.Focus()
    End Sub

    Private Sub txtItemAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveItem()
            txtSNo.Focus()
        End If
    End Sub

    Private Sub txtTotalAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        Try
            txtTotalAmount.Text = txtAmount.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvDetails_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvDetails.RowsAdded
        If dgvDetails.Rows.Count > 5 Then
            dgvDetails.Width = 412
        Else
            dgvDetails.Width = 394
        End If
    End Sub

    Private Sub dgvDetails_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvDetails.RowsRemoved
        If dgvDetails.Rows.Count > 5 Then
            dgvDetails.Width = 412
        Else
            dgvDetails.Width = 394
        End If
    End Sub

    Private Sub txtRec0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRec3.TextChanged, txtRec2.TextChanged, txtRec1.TextChanged, txtRec0.TextChanged
        txtReceivAmount.Text = Val(txtRec0.Text) + Val(txtRec1.Text) + Val(txtRec2.Text) + Val(txtRec3.Text)
    End Sub

    Private Sub txtTotalAmount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmount.TextChanged, txtReceivAmount.TextChanged
        txtBalance.Text = Val(txtTotalAmount.Text) - Val(txtReceivAmount.Text)
    End Sub


    Private Sub picColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picColor.Click
        Dim CDBox As New ColorDialog
        If CDBox.ShowDialog() Then
            cmbColor.Text = CDBox.Color.ToArgb.ToString
            picColor.BackColor = CDBox.Color
        End If
    End Sub

    Private Sub cmbMillName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.TextChanged
        If cmbMillName.Focused = True Then txtMillCode.Text = db.Mill.Data("MillCode", "MillName='" + cmbMillName.Text + "'")
    End Sub

    Private Sub txtMillName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMillCode.TextChanged
        If txtMillCode.Text = "" Then Exit Sub
        cmbMillName.Text = db.Mill.Data("MillName", "MillCode='" + txtMillCode.Text + "'")
        If cmbMillName.Text = "" Then
            cmbMillName.Text = txtMillCode.Text
        End If
    End Sub

    Private Sub cmbPartyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyName.TextChanged
        If cmbPartyName.Focused = True Then txtPartyCode.Text = db.Party.Data("PartyCode", "PartyName='" + cmbPartyName.Text + "'")
    End Sub

    Private Sub txtPartyCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPartyCode.TextChanged
        If txtPartyCode.Text = "" Then Exit Sub
        cmbPartyName.Text = db.Party.Data("PartyName", "PartyCode='" + txtPartyCode.Text + "'")
        If cmbPartyName.Text = "" Then
            cmbPartyName.Text = txtPartyCode.Text
        End If
    End Sub
End Class