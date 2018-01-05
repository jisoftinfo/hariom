Imports System.Data

Public Class frmDebitNote
    Dim db As New DBLib
    Dim tb As JISTable = db.debitNote
    Private Sub frmDebitNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetFormStyle(Me)
    End Sub
    Private Sub frmINV_SalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmINV_SalesReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Enter, dtpTDate.Enter, cmbCustomerName.Enter, txtTotalAmount.Enter, txtTaxPer.Enter, txtTaxAmt.Enter, txtExMillAmt.Enter, txtComPer.Enter, txtComAmt.Enter, txtAmount.Enter, txtAddress.Enter, txtNoOfBags.Enter, txtTotalKg.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbCustomerName.Name Then List_Datas(cmbCustomerName, db.Mill.Column("MillName"))

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Leave, dtpTDate.Leave, cmbCustomerName.Leave, txtTotalAmount.Leave, txtTaxPer.Leave, txtTaxAmt.Leave, txtExMillAmt.Leave, txtComPer.Leave, txtComAmt.Leave, txtAmount.Leave, txtAddress.Leave, txtNoOfBags.Leave, txtTotalKg.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub cmbCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.TextChanged
        Dim Adr1, Adr2 As String
        Adr1 = db.Mill.Data("AddressLine1", "MillName='" + cmbCustomerName.Text + "'")
        Adr2 = db.Mill.Data("AddressLine2", "MillName='" + cmbCustomerName.Text + "'")
        txtAddress.Text = Adr1 & vbCrLf & Adr2
        txtAmount.Text = db.MillWorking.Data("sum(Amount)", "MillName='" + cmbCustomerName.Text + "'")

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim ds As New DataSet
        Dim t As DataTable = ds.Tables.Add("DebitNote")
        t.Columns.Add("MillName", System.Type.GetType("System.String"))
        t.Columns.Add("Address", System.Type.GetType("System.String"))
        t.Columns.Add("FromDate", System.Type.GetType("System.DateTime"))
        t.Columns.Add("ToDate", System.Type.GetType("System.DateTime"))
        t.Columns.Add("Amount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("ExMillAmount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("CommissionPer", System.Type.GetType("System.Decimal"))
        t.Columns.Add("CommissionAmount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TaxPer", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TaxAmount", System.Type.GetType("System.Decimal"))
        t.Columns.Add("TotalAmount", System.Type.GetType("System.Decimal"))

        Dim r As DataRow
        r = t.NewRow()
        r("MillName") = cmbCustomerName.Text
        r("Address") = txtAddress.Text
        r("FromDate") = dtpFDate.Value
        r("ToDate") = dtpTDate.Value
        r("Amount") = Val(txtAmount.Text)
        r("ExMillAmount") = Val(txtExMillAmt.Text)
        r("CommissionPer") = Val(txtComPer.Text)
        r("CommissionAmount") = Val(txtComAmt.Text)
        r("TaxPer") = Val(txtTaxPer.Text)
        r("TaxAmount") = Val(txtTaxAmt.Text)
        r("TotalAmount") = Val(txtTotalAmount.Text)

        t.Rows.Add(r)
        ReportView(CrystalReportViewer1, "InventoryReport\cryDebitNote.rpt", ds)
    End Sub

    Private Sub txtExMillAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaxAmt.TextChanged, txtExMillAmt.TextChanged, txtComAmt.TextChanged
        Try
            If txtExMillAmt.Text <> "" And txtTaxPer.Text <> "" Then
                txtComAmt.Text = Math.Round(Val(txtExMillAmt.Text) * Val(txtComPer.Text) / 100)
                txtTaxAmt.Text = Math.Round(Val(txtComAmt.Text) * Val(txtTaxPer.Text) / 100)
                txtTotalAmount.Text = Math.Round(Val(txtComAmt.Text) + Val(txtTaxAmt.Text))
            End If

        Catch ex As Exception

        End Try

    End Sub

   
    Private Sub txtTaxPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaxPer.TextChanged
        Try
            If txtComAmt.Text <> "" Then
                txtTaxAmt.Text = Math.Round(Val(txtComAmt.Text) * Val(txtTaxPer.Text) / 100)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtComPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComPer.TextChanged
        Try
            If txtExMillAmt.Text <> "" Then
                txtComAmt.Text = Math.Round(Val(txtExMillAmt.Text) * Val(txtComPer.Text) / 100)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub NewForm()
        tb.NewRecord()
        
        ErrorProvider1.Clear()
    End Sub
   
End Class