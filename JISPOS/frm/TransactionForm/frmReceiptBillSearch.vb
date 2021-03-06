﻿Public Class frmReceiptBillSearch
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
        'ViewSearch()
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

        WQry = "ReceiptBillDate between  '" + SDate + "' And '" + EDate + "' and ReceiptBillAmount>='" + BillAmtFrom.ToString() + "' and ReceiptBillAmount<='" + BillAmtTo.ToString() + "'"

        If txtCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptBillFrom Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += txtCustomerName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If rbnCash.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptBillMode = 'cash' "

        End If
        If rbnCredit.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry += "ReceiptBillMode != 'cash' "

        End If
        Dim dv As DataView
        dv = db.ReceiptBill.Grid("ReceiptBillCode as 'Code', ReceiptBillDate as 'Date', ReceiptBillFrom, ReceiptBillMode as 'Mode',ReceiptBillAmount as 'Amount'", WQry, "ReceiptBillCode")
        dgvSearch.DataSource = dv

        dgvSearch.Columns("Code").Width = 100
        dgvSearch.Columns("Date").Width = 100
        dgvSearch.Columns("ReceiptBillFrom").Width = 200
        dgvSearch.Columns("Mode").Width = 150
        dgvSearch.Columns("Amount").Width = 200

        dgvSearch.Columns("Date").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim TotalAmt As Long
        TotalAmt = Val(db.ReceiptBill.Data("Sum(ReceiptBillAmount)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "Rs. " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If
       
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmReceiptBill.txtSearchBox.Text = txtCode.Text
            frmReceiptBill.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class