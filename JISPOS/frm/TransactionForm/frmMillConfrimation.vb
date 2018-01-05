Public Class frmMillConfrimation


    Dim tb As JISTable = db.MillConfrimation

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtConfrimationNo.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtConfrimationNo, "Please Enter the Confrimation No")
            txtConfrimationNo.Focus()
            RValue = False
        ElseIf tb.State = "New" And tb.ExistUserCode(txtConfrimationNo.Text) Then
            ErrorProvider1.SetError(txtConfrimationNo, txtConfrimationNo.Text + " is Already Exist. Please Enter the Confrimation No")
            txtConfrimationNo.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtConfrimationNo, "")
        End If

        If txtMillCode.Text = "" Then
            ErrorProvider1.SetError(cmbMillName, "Please Enter the Valid Mill Name")
            cmbMillName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbMillName, "")
        End If

        If txtPartyCode.Text = "" Then
            ErrorProvider1.SetError(cmbPartyName, "Please Enter the Valid Party Name or Billing Name")
            ErrorProvider1.SetError(cmbBillingName, "Please Enter the Valid Party Name or Billing Name")
            cmbPartyName.Focus()

            RValue = False
        Else
            ErrorProvider1.SetError(cmbPartyName, "")
            ErrorProvider1.SetError(cmbBillingName, "")
        End If

        If cmbBillingName.Text = "" Then
            ErrorProvider1.SetError(cmbBillingName, "Please Enter the Valid Billing Name")
            cmbBillingName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbBillingName, "")
        End If

        If txtCount.Text = "" Then
            ErrorProvider1.SetError(txtCount, "Please Enter the Count")
            txtCount.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtCount, "")
        End If

        If txtNoOfBags.Text = "" Then
            ErrorProvider1.SetError(txtNoOfBags, "Please Enter the No Of Bags")
            txtNoOfBags.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtNoOfBags, "")
        End If

        If txtRate.Text = "" Then
            ErrorProvider1.SetError(txtRate, "Please Enter the Rate")
            txtRate.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtRate, "")
        End If

        If txtDeliverySedule.Text = "" Then
            ErrorProvider1.SetError(txtDeliverySedule, "Please Enter the Delivery Schedule")
            txtDeliverySedule.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtDeliverySedule, "")
        End If

        If txtLRBreakUp.Text = "" Then
            ErrorProvider1.SetError(txtLRBreakUp, "Please Enter the LR BreakUp")
            txtLRBreakUp.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtLRBreakUp, "")
        End If
        If cmbPayMode.Text = "" Then
            ErrorProvider1.SetError(cmbPayMode, "Please Select The Pay Mode")
            cmbPayMode.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPayMode, "")
        End If

        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtRate.Enter, txtNoOfBags.Enter, txtNarration.Enter, txtLRBreakUp.Enter, txtLotNo.Enter, txtDeliverySedule.Enter, txtCount.Enter, txtConfrimationNo.Enter, cmbSalesMode.Enter, cmbPayMode.Enter, cmbPartyName.Enter, cmbMillName.Enter, cmbBillingName.Enter, cmbCountGroup.Enter, cmbStaus.Enter, txtDiscount.Enter, txtNameInChange.Enter, txtParticulars.Enter
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

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtRate.Leave, txtNoOfBags.Leave, txtNarration.Leave, txtLRBreakUp.Leave, txtLotNo.Leave, txtDeliverySedule.Leave, txtCount.Leave, txtConfrimationNo.Leave, cmbSalesMode.Leave, cmbPayMode.Leave, cmbPartyName.Leave, cmbMillName.Leave, cmbBillingName.Leave, cmbCountGroup.Leave, cmbStaus.Leave, txtDiscount.Leave, txtNameInChange.Leave, txtParticulars.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
        txtLRBreakUp.Text = txtLRBreakUp.Text.ToUpper
        txtLotNo.Text = txtLotNo.Text.ToUpper
        txtDeliverySedule.Text = txtDeliverySedule.Text.ToUpper
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtConfrimationNo, dtpDate, txtMillCode, txtPartyCode, txtCount, txtRate, txtNoOfBags, txtLotNo, cmbSalesMode, txtDiscount, txtDeliverySedule, txtLRBreakUp, cmbPayMode, txtNarration, txtInvoiceAddress, txtDeliveryAddress, txtInvoice, cmbStaus, txtNameInChange, txtParticulars)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmMillConfrimationReport)
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
        cmbMillName.Text = ""
        cmbPartyName.Text = ""
        cmbBillingName.Text = ""
        cmbStaus.Text = "P"
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                cmbMillName.Text = db.Mill.Data("MillName", String.Format("MillCode='{0}'", txtMillCode.Text))
                Dim ArrPartyInfo As New ArrayList
                ArrPartyInfo = db.Party.Row("LedgerName,PartyName", String.Format("PartyCode='{0}'", txtPartyCode.Text))
                If Not ArrPartyInfo Is Nothing Then
                    If ArrPartyInfo.Count > 1 Then
                        cmbBillingName.Text = ArrPartyInfo.Item(0)
                        cmbPartyName.Text = ArrPartyInfo.Item(1)
                    End If
                End If

                txtSearchBox.Text = ""
            End If
            ErrorProvider1.Clear()
        End If

    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
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
        FormShow(frmMillConfrimationSearch)
    End Sub


    'Private Sub cmbSalesMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSalesMode.SelectedIndexChanged
    '    If cmbSalesMode.Text.ToUpper() = "DISCOUNT" Then
    '        txtDiscount.Enabled = True
    '    Else
    '        txtDiscount.Enabled = False
    '    End If
    'End Sub

    Private Sub FindMillCode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.TextChanged
        txtMillCode.Text = db.Mill.Data("MillCode", String.Format("MillName='{0}'", cmbMillName.Text))
    End Sub

    Private Sub FindCountGroup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.TextChanged
        cmbCountGroup.Text = db.Mill.Data("CountGroup", String.Format("MillName='{0}'", cmbMillName.Text))
    End Sub

    Private Sub FindPartyCode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyName.TextChanged, cmbBillingName.TextChanged
        txtPartyCode.Text = db.Party.Data("PartyCode", String.Format("LedgerName='{0}' and PartyName='{1}'", cmbBillingName.Text, cmbPartyName.Text))
        Dim dv As New DataView
        dv = db.PartyAddress.Grid("InvoiceAddress,DeliveryAddress", String.Format("PartyCode='{0}'", txtPartyCode.Text))
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To dv.Count - 1
            DataGridView1.Rows.Add()
            DataGridView1.Item("INVOICEADDRESS", i).Value = dv(i)("INVOICEADDRESS").ToString()
            DataGridView1.Item("DELIVERYADDRESS", i).Value = dv(i)("DELIVERYADDRESS").ToString()
            If dv(i)("INVOICEADDRESS").ToString = txtInvoiceAddress.Text And dv(i)("DELIVERYADDRESS") = txtDeliveryAddress.Text Then
                DataGridView1.Item(0, i).Value = 1
            Else
                DataGridView1.Item(0, i).Value = 0
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Then
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If e.RowIndex = i Then
                    DataGridView1.Item(0, i).Value = 1
                Else
                    DataGridView1.Item(0, i).Value = 0
                End If
            Next
            txtInvoiceAddress.Text = ""
            txtDeliveryAddress.Text = ""
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(0, i).Value = 1 Then
                    txtInvoiceAddress.Text = DataGridView1.Item("INVOICEADDRESS", i).Value.ToString()
                    txtDeliveryAddress.Text = DataGridView1.Item("DELIVERYADDRESS", i).Value.ToString()
                End If
            Next
        End If
    End Sub

    Private Sub cmbMillName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPartyName.KeyUp, cmbMillName.KeyUp
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


    Private Sub txtOpBalance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoOfBags.KeyPress
        If (Asc(e.KeyChar) = 124 Or Asc(e.KeyChar) = 36 Or Asc(e.KeyChar) = 94 Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsLetter(e.KeyChar) = True) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub
  
End Class