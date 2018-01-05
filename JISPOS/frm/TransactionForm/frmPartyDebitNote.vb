Public Class frmPartyDebitNote

    Dim tb As JISTable = db.DebitNoteParty

    Public Arr_SearchCodes As New ArrayList
    Public SearchCodeIndex As Integer

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbPartyName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPartyName, "Please Enter the Party Name")
            cmbPartyName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPartyName, "")
        End If

        If cmbCompany.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbCompany, "Please Enter the Company Name")
            cmbCompany.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbCompany, "")
        End If

        Return RValue
    End Function

    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtTotalKg.Enter, txtTotalAmount.Enter, txtTaxAmt.Enter, txtNoOfBags.Enter, txtExMillAmt.Enter, txtComPer.Enter, txtComAmt.Enter, txtAmount.Enter, txtAddressLine.Enter, cmbPartyName.Enter, txtBillingName.Enter, cmbType.Enter, cmbTDSYr.Enter, txtTDSAmount.Enter, txtChequeNo.Enter, txtChequeAmount.Enter, cmbCompany.Enter, cmbTaxPer.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("Partyname"))
        End If
        If sender.Name = cmbCompany.Name Then
            List_Datas(cmbCompany, db.CompanyInfo.UserCodes())
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtTotalKg.Leave, txtTotalAmount.Leave, txtTaxAmt.Leave, txtNoOfBags.Leave, txtExMillAmt.Leave, txtComPer.Leave, txtComAmt.Leave, txtAmount.Leave, txtAddressLine.Leave, cmbPartyName.Leave, txtBillingName.Leave, cmbType.Leave, cmbTDSYr.Leave, txtTDSAmount.Leave, txtChequeNo.Leave, txtChequeAmount.Leave, cmbCompany.Leave, cmbTaxPer.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtMillCode, txtBillingName, txtAddressLine, dtpBillDate, txtNoOfBags, txtTotalKg, txtAmount, txtExMillAmt, dtpFDate, dtpTDate, txtComPer, txtComAmt, cmbTaxPer, txtTaxAmt, txtTotalAmount, cmbType, txtTDSAmount, cmbTDSYr, cmbCompany, txtOpBal, dtpRDate1, txtRAmt1, txtRCNo1, dtpRDate2, txtRAmt2, txtRCNo2, dtpRDate3, txtRAmt3, txtRCNo3, txtNarration, txtStatus, txtStatusColor)
        SetFormStyle(Me)
        dgvDebitDetails.AllowUserToAddRows = True
        dgvDebitDetails.AllowUserToDeleteRows = True
        dgvDebitDetails.RowHeadersVisible = True
        dgvDebitDetails.EditMode = DataGridViewEditMode.EditOnKeystroke
        dgvDebitDetails.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Dim dv As New DataView
        dv = db.DebitNoteDetailsParty.Grid("MWDate, Invoice,(select MillName from Mill where MillCode=DebitNoteDetailsParty.PartyName) as MillName,Partyname,NoOfBags,Weight,TotalKg,Rate,Amount,[Count],MWCode")

        dgvDebitDetails.DataSource = dv
        dgvDebitDetails.Columns("MWDate").DefaultCellStyle.Format = "dd/MM/yyyy"

        NewForm()

        Arr_SearchCodes = tb.Codes()
        SearchCodeIndex = Arr_SearchCodes.Count
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormShow(frmDebitNoteReport)
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
        ElseIf e.KeyValue = Keys.Left And e.Control = True Then
            SearchCodeIndex -= 1
            If SearchCodeIndex < 0 Then
                MsgDialog.ShowMsgDlg("Record is Reached Begin", Me.Text, "I")
                SearchCodeIndex = 0
            Else
                txtSearchBox.Text = Arr_SearchCodes(SearchCodeIndex)
                ViewForm()
            End If
        ElseIf e.KeyValue = Keys.Right And e.Control = True Then
            SearchCodeIndex += 1
            If SearchCodeIndex >= Arr_SearchCodes.Count Then
                MsgDialog.ShowMsgDlg("Record is Reached Last", Me.Text, "I")
                SearchCodeIndex = Arr_SearchCodes.Count
            Else
                txtSearchBox.Text = Arr_SearchCodes(SearchCodeIndex)
                ViewForm()
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
        FormShow(frmPartyDebitNoteSearch)
    End Sub


    Sub NewForm()
        tb.NewRecord()
        'cmbMillName.Focus()
        txtCode.Focus()
        txtExMillAmt.Text = 0
        txtTotalAmount.Text = 0
        txtTaxAmt.Text = 0
        cmbTaxPer.Text = 0

        dtpRDate1.Value = New Date(1900, 1, 1)
        dtpRDate2.Value = New Date(1900, 1, 1)
        dtpRDate3.Value = New Date(1900, 1, 1)
        Dim arr As New ArrayList
        arr = db.DebitNoteParty.Row("PeridFrom, PeriodTo", " 1 ORDER BY DNCode DESC")
        If arr.Count > 0 Then
            dtpFDate.Value = arr(0)
            dtpTDate.Value = arr(1)
        End If
        txtStatus.Text = "P"
        ErrorProvider1.Clear()
        dgvDebitDetails.DataSource = Nothing

    End Sub

    Public Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            dgvDebitDetails.DataSource = db.DebitNoteDetailsParty.Grid("MWDate  ,Invoice,(select MillName from Mill where MillCode=DebitNoteDetailsParty.PartyName) as MillName,(select BillingName from MillWorking where MWCode=DebitNoteDetailsParty.MWCode) as BillingName,NoOfBags,TotalKg,Amount,[Count],MWCode", "DNCode='" + txtCode.Text + "'")
            ErrorProvider1.Clear()
            If Not dgvDebitDetails.DataSource Is Nothing Then dgvDebitDetails.Columns("MWDate").DefaultCellStyle.Format = "dd/MM/yyyy"
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
            Dim str As String = ""
            Dim saveresult As String

            str = db.DebitNoteParty.SaveRecord()
            saveresult = str
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then


                If saveresult.ToLower = "inserted" Then

                    'Dim f As New frmDebitNoteReport
                    'f.viewprint(txtCode.Text)
                    'f.CrystalReportViewer1.RefreshReport()
                    'f.Show()
                    'f.CrystalReportViewer1.PrintReport()

                End If
                If saveresult.ToLower = "inserted" Or saveresult.ToLower = "updated" Then
                    db.DebitNoteDetailsParty.DeleteRecordByUserCode(txtCode.Text)

                    For i As Integer = 0 To dgvDebitDetails.RowCount - 2
                        db.DebitNoteDetailsParty.SaveRecord(db.DebitNoteDetailsParty.NewId(), db.DebitNoteDetailsParty.NewCode(), txtCode.Text, (i + 1).ToString(), dgvDebitDetails.Item("mwdate", i).Value.ToString(), dgvDebitDetails.Item("Invoice", i).Value.ToString(), db.Mill.Data("MillCode", "LEDGERNAME='" + dgvDebitDetails.Item("MillName", i).Value.ToString() + "'"), dgvDebitDetails.Item("NoOfBags", i).Value.ToString(), "", dgvDebitDetails.Item("TotalKg", i).Value.ToString(), "", dgvDebitDetails.Item("Amount", i).Value.ToString(), dgvDebitDetails.Item("Count", i).Value.ToString(), dgvDebitDetails.Item("MWCode", i).Value.ToString())
                    Next
                End If
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
            db.DebitNoteDetailsParty.DeleteRecordByUserCode(txtCode.Text)
            NewForm()
        End If
    End Sub

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        ViewForm()
    End Sub

    Private Sub cmbCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyName.TextChanged
        If cmbPartyName.Focused And db.Party.ExistData("PartyName", cmbPartyName.Text) Then
            Dim Adr1, Adr2 As String
            Adr1 = db.Party.Data("AddressLine1", "PartyName='" + cmbPartyName.Text + "'")
            Adr2 = db.Party.Data("AddressLine2", "PartyName='" + cmbPartyName.Text + "'")
            txtAddressLine.Text = Adr1 & vbCrLf & Adr2

            dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
            dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
            Dim SDate As String = dtpFDate.Value.ToString()
            Dim EDate As String = dtpTDate.Value.ToString()


            Dim WQry As String
            WQry = "MWDate>=#" + SDate + "# and MWDate<=#" + EDate + "# and PartyName in (select PartyName from party where partyname= '" + cmbPartyName.Text + "') and MWCode not in (select MWCode from DebitNoteDetailsParty where not DNCode='" + txtCode.Text + "')"

            'Dim arr As New ArrayList
            'arr = db.MillWorking.Row("sum(Amount),sum(NoOfBags),sum(TotalKg)", WQry)
            'If arr.Count > 0 Then
            '    txtAmount.Text = arr(0).ToString()
            '    txtNoOfBags.Text = arr(1).ToString()
            '    txtTotalKg.Text = arr(2).ToString()
            'Else
            '    txtAmount.Text = 0
            '    txtNoOfBags.Text = 0
            '    txtTotalKg.Text = 0
            'End If

            Dim dv As New DataView
            'dv = db.ViewMillWorking.Grid("MWDate,Invoice,MillName,BillingName,NoOfBags,Weight,TotalKg,Rate,Amount,[Count],MWCode", WQry)
            dv = db.ViewMillWorking.Grid("MWDate,Invoice,MillName,BillingName,NoOfBags,TotalKg,Amount,[Count],MWCode", WQry)
            dgvDebitDetails.DataSource = dv
            dgvDebitDetails.Columns("MWDate").DefaultCellStyle.Format = "dd/MM/yyyy"
            FindTotal()
        End If

    End Sub

    Private Sub txtComPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComPer.TextChanged, cmbType.TextChanged, txtAmount.TextAlignChanged, txtNoOfBags.TextChanged, txtTotalKg.TextChanged, txtAmount.TextChanged
        If txtComPer.Focused Or cmbType.Focused Or txtAmount.Focused Or txtNoOfBags.Focused Or txtTotalKg.Focused Or txtAmount.Focused Then
            FindCommission()
        End If

    End Sub

    Private Sub btnBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBill.Click
        If db.DebitNote.State = "New" Then Exit Sub
        Dim f As New frmDebitNoteReportParty
        f.viewprint(txtCode.Text)
        ' f.CrystalReportViewer1.RefreshReport()
        f.Show()
        ' f.CrystalReportViewer1.PrintReport()
    End Sub

    Sub FindCommission()
        If cmbType.Text = "Amount" Then
            txtComAmt.Text = Math.Round(Val(txtAmount.Text) * Val(txtComPer.Text) / 100)
        ElseIf cmbType.Text = "Bags" Then
            txtComAmt.Text = Math.Round(Val(txtNoOfBags.Text) * Val(txtComPer.Text))
        ElseIf cmbType.Text = "Kg" Then
            txtComAmt.Text = Math.Round(Val(txtTotalKg.Text) * Val(txtComPer.Text))
        ElseIf cmbType.Text = "ExMillAmount" Then
            txtComAmt.Text = Math.Round(Val(txtExMillAmt.Text) * Val(txtComPer.Text) / 100)
        End If
    End Sub

    Private Sub txtComAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaxAmt.TextChanged, txtComAmt.TextChanged
        Try
            txtTotalAmount.Text = Val(txtComAmt.Text) + Val(txtTaxAmt.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbTaxPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTaxPer.TextChanged
        Try
            If txtComAmt.Text <> 0 And cmbTaxPer.Text <> "" Then
                txtTaxAmt.Text = Val(txtComAmt.Text) * Val(cmbTaxPer.Text) / 100
                txtTaxAmt.Text = Format(Val(txtTaxAmt.Text), "0.00")
                txtTaxAmt.Text = Math.Round(Val(txtTaxAmt.Text))
            Else
                txtTaxAmt.Text = Val(txtAmount.Text) * Val(cmbTaxPer.Text) / 100
                txtTaxAmt.Text = Format(Val(txtTaxAmt.Text), "0.00")
                txtTaxAmt.Text = Math.Round(Val(txtTaxAmt.Text))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbMillName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyName.TextChanged
        txtMillCode.Text = db.Party.Data("PartyCode", "PartyName='" + cmbPartyName.Text + "'")
    End Sub

    Private Sub txtMillName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMillCode.TextChanged
        cmbPartyName.Text = db.Party.Data("PartyName", "PartyCode='" + txtMillCode.Text + "'")
    End Sub

    Private Sub dtpTDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTDate.ValueChanged
        dtpBillDate.Value = dtpTDate.Value
    End Sub

    Private Sub dgvDebitDetails_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDebitDetails.RowEnter
        If dgvDebitDetails.Focused Then
            FindTotal()
        End If
    End Sub

    Sub FindTotal()
        txtAmount.Text = 0
        txtNoOfBags.Text = 0
        txtTotalKg.Text = 0
        Try
            For i As Integer = 0 To dgvDebitDetails.RowCount - 1
                txtAmount.Text = Val(txtAmount.Text) + dgvDebitDetails.Item("Amount", i).Value
                txtNoOfBags.Text = Val(txtNoOfBags.Text) + dgvDebitDetails.Item("NoOfBags", i).Value
                txtTotalKg.Text = Val(txtTotalKg.Text) + dgvDebitDetails.Item("TotalKg", i).Value
            Next
            Catch ex As Exception

        End Try

    End Sub
End Class