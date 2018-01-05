Public Class frmCreditSearch
    
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        lblValue.Font = New System.Drawing.Font("Arial", 25.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWords.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ViewSearch()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()
        dtpBillDateFrom.Value = New Date(dtpBillDateFrom.Value.Year, dtpBillDateFrom.Value.Month, dtpBillDateFrom.Value.Day, 0, 0, 0)
        dtpBillDateTo.Value = New Date(dtpBillDateTo.Value.Year, dtpBillDateTo.Value.Month, dtpBillDateTo.Value.Day, 23, 59, 59)

        Dim PType As String = ""
        Dim SDate As String = dtpBillDateFrom.Value.ToString()
        Dim EDate As String = dtpBillDateTo.Value.ToString()

        Dim WQry As String

        Dim BillAmtFrom, BillAmtTo As Long
        BillAmtFrom = 0
        BillAmtTo = 99999999

        If txtBillAmountFrom.Text.Trim <> "" Then BillAmtFrom = Val(txtBillAmountFrom.Text)
        If txtBillAmountTo.Text.Trim <> "" Then BillAmtTo = Val(txtBillAmountTo.Text)

        WQry = "ReceiptDate between  '" + SDate + "' And '" + EDate + "' and ReceiptAmount>='" + BillAmtFrom.ToString() + "' and ReceiptAmount<='" + BillAmtTo.ToString() + "'"


        If cmbReceiptFrom.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptFrom='" + cmbReceiptFrom.Text + "'"
        End If


        If cmbReceiptName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "Fromm ='" + cmbReceiptName.Text + "'"
        End If

        If cmbReceiptMode.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptTo='" + cmbReceiptMode.Text + "'"
        End If

        If cmbReceiptCode.Text.Trim() <> "" Then
            WQry = "Receiptcode='" + cmbReceiptCode.Text + "'"
        End If


        Dim dv As DataView
        dv = db.Receipt.Grid("ReceiptCode as 'Code', ReceiptDate as 'Date', ReceiptFrom, Fromm as 'Receipt Name', ReceiptTo as 'Receipt Mode',ReceiptAmount", WQry, "ReceiptCode")
        dgvSearch.DataSource = dv

        dgvSearch.Columns("Code").Width = 100
        dgvSearch.Columns("Date").Width = 150
        dgvSearch.Columns("ReceiptFrom").Width = 170
        dgvSearch.Columns("Receipt Name").Width = 150
        dgvSearch.Columns("Receipt Mode").Width = 150
        dgvSearch.Columns("ReceiptAmount").Width = 120

        Dim TotalAmt As Long
        TotalAmt = Val(db.Receipt.Data("Sum(ReceiptAmount)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "Rs. " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If

        dgvSearch.Columns("Date").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("ReceiptAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmReceipt.txtSearchBox.Text = txtCode.Text
            frmReceipt.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBillAmountFrom_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Enter, txtBillAmountFrom.Enter, cmbReceiptName.Enter, cmbReceiptMode.Enter, cmbReceiptFrom.Enter, cmbReceiptCode.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbReceiptCode.Name Then List_Datas(cmbReceiptCode, db.Receipt.Codes())
        If sender.Name = cmbReceiptName.Name Then
            If cmbReceiptFrom.Text = "Suppliers" Then
                List_Datas(cmbReceiptName, db.Mill.Column("MillName"))
            ElseIf cmbReceiptFrom.Text = "Banks" Then
                List_Datas(cmbReceiptName, db.Banks.UserCodes())
            ElseIf cmbReceiptFrom.Text = "Account Heads" Then
                List_Datas(cmbReceiptName, db.Ledger.Column("LedgerName", "not ledgername in (SELECT LedgerName FROM Customer UNION SELECT LedgerName FROM Supplier UNION SELECT LedgerName FROM Banks)"))
            ElseIf cmbReceiptFrom.Text = "Customers" Then
                List_Datas(cmbReceiptName, db.Party.Column("PartyName"))
            End If
        End If
        If sender.Name = cmbReceiptMode.Name Then
            cmbReceiptMode.Items.Clear()
            cmbReceiptMode.Items.Add("CASH")
            List_Datas(cmbReceiptMode, db.Banks.UserCodes(), True)
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtBillAmountFrom_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Leave, txtBillAmountFrom.Leave, cmbReceiptName.Leave, cmbReceiptMode.Leave, cmbReceiptFrom.Leave, cmbReceiptCode.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub cmbPayCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReceiptCode.TextChanged
        ViewSearch()
    End Sub
End Class