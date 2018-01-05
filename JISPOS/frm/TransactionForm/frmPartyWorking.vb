Public Class frmPartyWorking
    Dim ItemState As String = "New"

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True

        If cmbMillName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbMillName, "Please Enter the Sales Type")
            cmbMillName.Focus()
            RValue = False
        Else
            If cmbMillName.FindStringExact(cmbMillName.Text) = -1 Then
                ErrorProvider1.SetError(cmbMillName, "Please Enter the Valid Sales Type")
                cmbMillName.Focus()
                RValue = False
            Else
                ErrorProvider1.SetError(cmbMillName, "")
            End If
        End If

        If RValue = True Then
            If dgvDetails.Rows.Count = 0 Then
                MsgDialog.ShowMsgDlg("Please Enter The Items", Me.Text, "I")
                RValue = False
            ElseIf dgvDetails.Item(0, 0).Value = Nothing Then
                MsgDialog.ShowMsgDlg("Please Enter The Items", Me.Text, "I")
                RValue = False
            End If
        End If
        Return RValue

    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtTotalDiscount.Enter, txtTotalAmount.Enter, txtTax.Enter, txtSNo.Enter, txtSearchBox.Enter, txtRoundOff.Enter, txtRate.Enter, txtNarration.Enter, txtItemsAmount.Enter, txtId.Enter, txtAmount.Enter, txtAddress3.Enter, dtpPWDate.Enter, cmbTaxType.Enter, cmbTax.Enter, cmbMillName.Enter, cmbPartyName.Enter, txttransporter.Enter, txtorderno.Enter, txtlrno.Enter, dtporderdate.Enter, txtTaxAmt.Enter, txtItemAmt.Enter, txtExtras.Enter, cmbTax.Enter, txtDiscount.Enter, cmbPartyName.Enter, cmbTaxPer.Enter, cmbEstimateCode.Enter, cmbUOM.Enter, txtNOOFBags.Enter, txtWeight.Enter, cmbBillType.Enter, cmbEFormNo.Enter, cmbCFormNo.Enter, txtInvoiceNo.Enter, txtCAmount.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, db.PartyWorking.Codes())
        If sender.name = cmbUOM.Name Then List_Datas(cmbUOM, db.UnitsOfMeasurement.UserCodes())
        If sender.name = cmbTaxPer.Name Then List_Datas(cmbTaxPer, db.TaxMaster.UserCodes())
        If sender.name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName"))
        End If
        If sender.name = cmbCFormNo.Name Then
            List_Datas(cmbCFormNo, db.CForm.Column("CFormNo"))
        End If
        If sender.Name = cmbEFormNo.Name Then
            List_Datas(cmbEFormNo, db.CForm.Column("EFormNo"))
        End If
        If sender.Name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtTotalDiscount.Leave, txtTotalAmount.Leave, txtTax.Leave, txtSNo.Leave, txtSearchBox.Leave, txtRoundOff.Leave, txtNarration.Leave, txtItemsAmount.Leave, txtId.Leave, txtAmount.Leave, txtAddress3.Leave, dtpPWDate.Leave, cmbTaxType.Leave, cmbTax.Leave, cmbMillName.Leave, cmbPartyName.Leave, txttransporter.Leave, txtorderno.Leave, txtlrno.Leave, dtporderdate.Leave, txtTaxAmt.Leave, txtItemAmt.Leave, txtRate.Leave, txtDiscount.Leave, cmbPartyName.Leave, cmbTaxPer.Leave, cmbEstimateCode.Leave, cmbUOM.Leave, txtNOOFBags.Leave, txtWeight.Leave, cmbBillType.Leave, cmbEFormNo.Leave, cmbCFormNo.Leave, txtInvoiceNo.Leave, txtCAmount.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor


        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frmSales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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


        db.PartyWorking.SetControls(txtId, txtCode, cmbMillName, dtpPWDate, cmbBillType, txtInvoiceNo, cmbCFormNo, txtCAmount, cmbEFormNo, dtpE1Date, txtItemAmt, cmbTaxPer, txtTaxAmt, txtDiscount, txtExtras, txtAdvance, txtTotalAmount)
        db.PartyWorkingDetails.SetControls(txtDetailsId, txtDetailsCode, txtMasterCode, txtSNo, cmbPartyName, txtNOOFBags, txtWeight, cmbUOM, txtRate, txtAmount)

        dgvDetails.Columns("SNo").Width = txtSNo.Width
        dgvDetails.Columns("PartyName").Width = cmbPartyName.Width
        dgvDetails.Columns("NoOfBags").Width = txtNOOFBags.Width
        dgvDetails.Columns("Weight").Width = txtWeight.Width
        dgvDetails.Columns("UOM").Width = cmbUOM.Width
        dgvDetails.Columns("Rate").Width = txtRate.Width
        dgvDetails.Columns("Amount").Width = txtAmount.Width


        dgvDetails.ColumnHeadersVisible = False
        dgvDetails.RowHeadersVisible = False
        dgvDetails.Rows.Add()
        lblvalue.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        NewForm()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmINV_PartyWorking)


    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then
                If ctl.Name = cmbPartyName.Name Then
                    FormShow(frmCustomers)
                ElseIf ctl.Name = cmbMillName.Name Then
                    FormShow(frmSuppliers)
                ElseIf ctl.Name = cmbUOM.Text Then
                    FormShow(frmUnits)
                End If
            ElseIf ctl.Text = "@" Then
                If ctl.Name = cmbPartyName.Name Then
                    FormShow(frmCustomers)
                ElseIf ctl.Name = cmbMillName.Name Then
                    FormShow(frmSuppliers)
                ElseIf ctl.Name = cmbUOM.Text Then
                    FormShow(frmUnits)
                End If
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
        'SaveAllRecord()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Type = "Admin" Then DeleteForm()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveItem()
            txtSNo.Focus()
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NewItem()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        ViewItem(dgvDetails.CurrentRow.Index)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgDialog.ShowMsgDlg("Do you Delete this Item?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then
            DeleteItem()
            MsgDialog.ShowMsgDlg("Deleted", Me.Text, "I")
        End If
    End Sub

    Private Sub dgvDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDetails.MouseDown
        dgvDetails.ContextMenuStrip = Nothing
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If dgvDetails.Item(0, dgvDetails.CurrentRow.Index).Value <> Nothing Then
                    dgvDetails.ContextMenuStrip = ContextMenuStrip1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetails_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvDetails.RowsAdded
        If dgvDetails.Rows.Count > 5 Then
            dgvDetails.Width = 788
        Else
            dgvDetails.Width = 770
        End If
    End Sub

    Private Sub dgvDetails_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvDetails.RowsRemoved
        If dgvDetails.Rows.Count > 5 Then
            dgvDetails.Width = 788
        Else
            dgvDetails.Width = 770
        End If
    End Sub

    Private Sub txtTotalAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmount.TextChanged
        If Val(txtTotalAmount.Text) <> 0 Then
            lblvalue.Text = "Rs." & Val(txtTotalAmount.Text)
            lblwords.Text = Number_to_Word.numtoword(txtTotalAmount.Text)
        Else
            lblvalue.Text = ""
            lblwords.Text = ""
        End If
    End Sub

    Private Sub txtExtras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalDiscount.TextChanged, txtTax.TextChanged
        FindTotalAmount()
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress, txtAmount.KeyPress
        e.KeyChar = NumericCheckwithsingledot(sender, e.KeyChar, False)
    End Sub

    Private Sub txtInvoiceNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txtInvoiceNo.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtInvoiceNo, "Please Enter the Invoice Number")
        Else
            ErrorProvider1.SetError(txtInvoiceNo, "")
        End If
    End Sub

    Private Sub txtFreightCharge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreightCharges.TextChanged
        FindTotalAmount()
    End Sub

    Private Sub txtFreightCharge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = NumericCheckwithsingledot(sender, e.KeyChar, False)
    End Sub

    Private Sub cmbTax_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTax.SelectedIndexChanged, txtItemsAmount.TextChanged, txtTotalDiscount.TextChanged
        Try
            txtTax.Text = Format((Val(txtItemsAmount.Text) * Val(txtTax.Text)) / 100, "0.00")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cmbSalesType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbMillName.Text = "Credit" Then
            txtNarration.Text = "CREDIT Party Working"
        Else
            txtNarration.Text = "CASH Party Working"
        End If

    End Sub

    Sub NewForm()

        ErrorProvider1.Clear()

        dgvDetails.Rows.Clear()
        db.PartyWorking.NewRecord()
        NewItem()
        cmbMillName.Focus()
        cmbTaxType.Text = "VAT"
        cmbTax.Text = "0"
        cmbTaxPer.Text = "0"

    End Sub
    Sub NewItem()
        ItemState = "New"
        db.PartyWorkingDetails.NewRecord()

        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("SNo", i).Value = Nothing Then
                txtSNo.Text = i + 1
                Exit For
            End If
        Next
        If Val(txtSNo.Text) = 0 Then txtSNo.Text = 1
        txtMasterCode.Text = txtCode.Text
        ErrorProvider1.Clear()
    End Sub


    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = db.PartyWorking.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                txtSearchBox.Text = ""
                Dim dv As New DataView
                dv = db.PartyWorkingDetails.Grid("*", "PartyCode='" + txtCode.Text + "'")
                dgvDetails.Rows.Clear()
                For i As Integer = 0 To dv.Count - 1
                    dgvDetails.Rows.Add()
                    dgvDetails.Item("SNo", i).Value = dv.Item(i)("sno").ToString()
                    dgvDetails.Item("PartyName", i).Value = dv.Item(i)("PartyName").ToString()
                    dgvDetails.Item("NoOfBags", i).Value = dv.Item(i)("NOOfBags").ToString()
                    dgvDetails.Item("Weight", i).Value = dv.Item(i)("Weight").ToString()
                    dgvDetails.Item("UOM", i).Value = dv.Item(i)("UOM").ToString()
                    dgvDetails.Item("Rate", i).Value = dv.Item(i)("Rate").ToString()
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
        cmbPartyName.Text = dgvDetails.Item("PartyName", i).Value
        txtNOOFBags.Text = dgvDetails.Item("NoOfBags", i).Value
        txtWeight.Text = dgvDetails.Item("Weight", i).Value
        cmbUOM.Text = dgvDetails.Item("UOM", i).Value
        txtRate.Text = dgvDetails.Item("Rate", i).Value
        txtAmount.Text = dgvDetails.Item("Amount", i).Value
        txtMasterCode.Text = txtCode.Text
    End Sub

    Sub FindTotalAmount()
        Dim IAmt As Double
        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
            IAmt = IAmt + Val(dgvDetails.Item("Amount", i).Value)
        Next

        txtItemAmt.Text = Format(IAmt, "0.00")
        txtTotalDiscount.Text = ""
        txtTaxAmt.Text = Format(IAmt * Val(cmbTaxPer.Text) / 100, "0.00")
        txtTotalAmount.Text = Val(txtItemAmt.Text) + Val(txtTaxAmt.Text) + Val(txtExtras.Text) - Val(txtDiscount.Text)
        txtRoundOff.Text = Format(Math.Round(Val(txtTotalAmount.Text)) - txtTotalAmount.Text, "0.00")
        txtTotalAmount.Text = Math.Round(Val(txtTotalAmount.Text))
    End Sub
    Sub SaveAllRecord()
        Dim arr As New ArrayList
        arr = db.PartyWorking.Codes()
        For i As Integer = 0 To arr.Count - 1
            txtSearchBox.Text = arr(i)
            ViewForm()
            SaveForm()
        Next
    End Sub
    Sub SaveForm()
        If FormValidate() Then
            ' If Type <> "Admin" And db.Sales.State <> "New" Then Exit Sub
            Dim str As String = ""
            Dim saveresult As String

            str = db.PartyWorking.SaveRecord()
            saveresult = str
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then

                Dim n As Integer
                Dim GroupName As String
                Dim id, code As String

                db.PartyWorkingDetails.DeleteRecordByUserCode(txtCode.Text)
                db.Stock.DeleteRecordByUserCode(txtCode.Text)
                db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)

                If cmbBillType.Text = "Credit" Then
                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode()
                    AddLedger(id, code, txtCode.Text, "CreditSales", dtpPWDate.Value, cmbPartyName.Text, "SalesA/C", txtNarration.Text, "Yes", txtTotalAmount.Text, 0, "", dtpPWDate.Value, "Credit", cmbPartyName.Text, txtCode.Text, "Credit", txtCode.Text)

                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode()
                    AddLedger(id, code, txtCode.Text, "CreditSales", dtpPWDate.Value, "SalesA/C", cmbPartyName.Text, txtNarration.Text, "Yes", 0, txtTotalAmount.Text, "", dtpPWDate.Value, "Credit", cmbPartyName.Text, txtCode.Text, "Credit", txtCode.Text)


                ElseIf cmbMillName.Text = "Cash" Then
                    GroupName = "Cash-in-hand"
                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode()
                    AddLedger(id, code, txtCode.Text, "CashSales", dtpPWDate.Value, "Cash", "SalesA/C", txtNarration.Text, "Yes", txtTotalAmount.Text, 0, GroupName, dtpPWDate.Value, cmbPartyName.Text, "Cash", txtCode.Text, " ", txtCode.Text)

                    id = db.LedgerReport.NewId()
                    code = db.LedgerReport.NewCode()
                    AddLedger(id, code, txtCode.Text, "CashSales", dtpPWDate.Value, "SalesA/C", "Cash", txtNarration.Text, "Yes", 0, txtTotalAmount.Text, GroupName, dtpPWDate.Value, cmbPartyName.Text, "Cash", txtCode.Text, "Cash", txtCode.Text)
                End If

                If Val(txtRoundOff.Text) > 0 Then
                    GroupName = "Indirect Expenses"
                    'id = db.LedgerReport.NewId()
                    'code = db.LedgerReport.NewCode()
                    'AddLedger(id, code, txtCode.Text, "Sales", dtpSalesDate.Value, "Round Off", "Sales Master", txtNarration.Text, "No", 0, txtRoundOff.Text, GroupName, dtpSalesDate.Value)
                Else
                    GroupName = "Indirect Expenses"
                    'id = db.LedgerReport.NewId()
                    'code = db.LedgerReport.NewCode()
                    'AddLedger(id, code, txtCode.Text, "Sales", dtpSalesDate.Value, "Round Off", "Sales Master", txtNarration.Text, "No", Math.Abs(Val(txtRoundOff.Text)), 0, GroupName, dtpSalesDate.Value)
                End If

                For i As Integer = 0 To dgvDetails.Rows.Count - 1
                    If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
                    db.PartyWorkingDetails.NewRecord()
                    ViewItem(i)

                    db.PartyWorkingDetails.SaveRecord()
                    n = i

                    id = db.Stock.NewId()
                    code = db.Stock.NewCode()
                    ' GroupName = db.GetGroupNameByProduct(dgvPDetails.Item("ItemName", i).Value.ToString())
                    'TaxAmt = Format((Val(dgvDetails.Item("Amount", i).Value.ToString()) * Val(cmbTax.Text)) / 100, "0.00")
                    'TotAmt = Format((Val(dgvDetails.Item("Amount", i).Value.ToString()) + TaxAmt), "0.00")
                    db.Stock.SaveRecord(id, code, txtCode.Text, "Sales", dtpPWDate.Value.ToString(), dgvDetails.Item("PartyName", i).Value.ToString(), dgvDetails.Item("NoOfBags", i).Value.ToString(), dgvDetails.Item("Rate", i).Value.ToString(), cmbUOM.Text, dgvDetails.Item("Amount", i).Value.ToString(), "", "", "", "Sales @ " + cmbTax.Text, DefultGodown, "Primary")

                Next


            End If
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If saveresult.ToLower = "inserted" And ckbisprint.Checked = True Then

                Dim f As New frmQuickPartyWorking
                f.viewprint(txtCode.Text)
                f.CrystalReportViewer1.RefreshReport()
                f.Show()
                f.CrystalReportViewer1.PrintReport()


            End If




            NewForm()
        End If

    End Sub

    Sub SaveItem()

        'If Not db.Products.ExistUserCode(cmbItemName.Text) Then
        '    MsgDialog.ShowMsgDlg("Product Name is not Available", Me.Text, "I")
        '    cmbItemName.Focus()
        '    Exit Sub
        'End If

        If cmbPartyName.Text = "" Then
            MsgDialog.ShowMsgDlg("Please Enter Product Name ", Me.Text, "I")
            cmbPartyName.Focus()
            Exit Sub
        End If

        If txtRate.Text.Trim() = "" Then
            MsgDialog.ShowMsgDlg("Please Enter The Item Rate", Me.Text, "I")
            txtRate.Focus()
            Exit Sub
        ElseIf Val(txtRate.Text) < 0 Then
            MsgDialog.ShowMsgDlg("Please Enter The Item Rate as Positive", Me.Text, "I")
            txtRate.Focus()
            Exit Sub
        End If


        'If txtQty.Text.Trim() = "" Then
        '    MsgDialog.ShowMsgDlg("Please Enter The Quantity", Me.Text, "I")
        '    txtQty.Focus()
        '    Exit Sub
        'ElseIf Val(txtQty.Text) < 0 Then
        '    MsgDialog.ShowMsgDlg("Please Enter The Quantity as Positive", Me.Text, "I")
        '    txtQty.Focus()
        '    Exit Sub
        'End If

        If txtAmount.Text.Trim() = "" Then
            MsgDialog.ShowMsgDlg("Please Enter The Amount", Me.Text, "I")
            txtAmount.Focus()
            Exit Sub
        ElseIf Val(txtAmount.Text) < 0 Then
            MsgDialog.ShowMsgDlg("Please Enter The Amount as Positive", Me.Text, "I")
            txtAmount.Focus()
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("PartyName", i).Value = Nothing Then Exit For
            If cmbPartyName.Text = dgvDetails.Item("PartyName", i).Value Then Exit For
        Next
        If i = dgvDetails.Rows.Count Then dgvDetails.Rows.Add()

        dgvDetails.Item("SNo", i).Value = i + 1
        dgvDetails.Item("PartyName", i).Value = cmbPartyName.Text
        dgvDetails.Item("NoOfBags", i).Value = txtNOOFBags.Text
        dgvDetails.Item("Weight", i).Value = txtWeight.Text
        dgvDetails.Item("UOM", i).Value = cmbUOM.Text
        dgvDetails.Item("Rate", i).Value = txtRate.Text
        dgvDetails.Item("Amount", i).Value = txtAmount.Text

        FindTotalAmount()
        NewItem()
        cmbPartyName.Focus()
    End Sub

    Sub DeleteForm()
        If db.PartyWorking.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        db.PartyWorkingDetails.DeleteRecordByUserCode(txtCode.Text)

        db.LedgerReport.DeleteRecordByUserCode(txtCode.Text)
        str = db.PartyWorking.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
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


    Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch1.Click
        FormShow(frmPartySearch)
    End Sub

    Private Sub txtTaxPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FindTotalAmount()
    End Sub

    Private Sub cmbTaxPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTaxPer.TextChanged
        FindTotalAmount()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtras.TextChanged, txtDiscount.TextChanged

        FindTotalAmount()
    End Sub

    Private Sub btnBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBill.Click
        If db.PartyWorking.State = "New" Then Exit Sub
        Dim f As New frmQuickPartyWorking
        f.viewprint(txtCode.Text)
        f.CrystalReportViewer1.RefreshReport()
        f.Show()
        f.CrystalReportViewer1.PrintReport()
    End Sub


    Private Sub cmbCFormNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCFormNo.TextChanged
        Try
            txtCAmount.Text = db.CForm.Data("CAmount", "CFormNo='" + cmbCFormNo.Text + "'")
        Catch ex As Exception

        End Try
    End Sub
End Class