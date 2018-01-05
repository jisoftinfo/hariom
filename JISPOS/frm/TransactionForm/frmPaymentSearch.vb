Public Class frmPaymentSearch

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

        WQry = "PaymentDate between  '" + SDate + "' And '" + EDate + "' and PayAmount>='" + BillAmtFrom.ToString() + "' and PayAmount<='" + BillAmtTo.ToString() + "'"

        If cmbPayName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PayName ='" + cmbPayName.Text + "'"
        End If

        If cmbPayMode.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "paymentfrom='" + cmbPayMode.Text + "'"
        End If

        If cmbPayCode.Text.Trim() <> "" Then
            WQry = "Paymentcode='" + cmbPayCode.Text + "'"
        End If

        Dim dv As DataView
        dv = db.Payment.Grid("PaymentCode as 'Code', PaymentDate as 'Date', PaymentTo, PayName, PayMode,PayAmount", WQry, "PaymentCode")
        dgvSearch.DataSource = dv
        dgvSearch.Columns("Code").Width = 100
        dgvSearch.Columns("Date").Width = 80
        dgvSearch.Columns("PaymentTo").Width = 150
        dgvSearch.Columns("PayName").Width = 200
        dgvSearch.Columns("PayMode").Width = 100
        dgvSearch.Columns("PayAmount").Width = 100

        Dim TotalAmt As Long
        TotalAmt = Val(db.Payment.Data("Sum(PayAmount)", WQry))

        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "Rs. " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If

        dgvSearch.Columns("Date").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("PayAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmPayment.txtSearchBox.Text = txtCode.Text
            frmPayment.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbPayCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillAmountTo.Enter, txtBillAmountFrom.Enter, cmbPaymentTo.Enter, cmbPayCode.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbPayCode.Name Then List_Datas(cmbPayCode, db.Payment.UserCodes())
        If sender.Name = cmbPayName.Name Then
            If cmbPaymentTo.Text = "Suppliers" Then
                List_Datas(cmbPayName, db.Mill.UserCodes())
            ElseIf cmbPaymentTo.Text = "Banks" Then
                List_Datas(cmbPayName, db.Banks.UserCodes())
            ElseIf cmbPaymentTo.Text = "Account Heads" Then
                List_Datas(cmbPayName, db.Ledger.Column("LedgerName", "not ledgername in (SELECT LedgerName FROM Customer UNION SELECT LedgerName FROM Supplier UNION SELECT LedgerName FROM Banks)"))
            ElseIf cmbPaymentTo.Text = "Customers" Then
                List_Datas(cmbPayName, db.Party.Column("PartyName"))
            End If
        End If
        If sender.Name = cmbPayMode.Name Then
            cmbPayMode.Items.Clear()
            cmbPayMode.Items.Add("CASH")
            List_Datas(cmbPayMode, db.Banks.UserCodes(), True)
        End If
    End Sub

    Private Sub cmbPayCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayCode.TextChanged
        ViewSearch()
    End Sub
End Class