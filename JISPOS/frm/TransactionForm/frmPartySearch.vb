Public Class frmPartySearch
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtTotalAmountTo.Enter, txtTotalAmountFrom.Enter, cmbCustomerName.Enter, cmbSalesCode.Enter, cmbOrderCode.Enter, cmbTax.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name = cmbCustomerName.Name Then
            List_Datas(cmbCustomerName, db.Party.Column("PartyName"))
        End If
        If sender.Name = cmbSalesCode.Name Then
            If cmbCustomerName.Text = "" Then
                List_Datas(cmbSalesCode, db.PartyWorking.Codes())
            Else
                List_Datas(cmbSalesCode, db.PartyWorking.Column("PartyCode", "MillName='" + cmbCustomerName.Text + "'"))
            End If

        End If


        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtTotalAmountTo.Leave, txtTotalAmountFrom.Leave, cmbCustomerName.Leave, cmbSalesCode.Leave, cmbOrderCode.Leave, cmbTax.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
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
        dtpOrderDateFrom.Value = New Date(dtpOrderDateFrom.Value.Year, dtpOrderDateFrom.Value.Month, dtpOrderDateFrom.Value.Day, 0, 0, 0)
        dtpOrderDateTo.Value = New Date(dtpOrderDateTo.Value.Year, dtpOrderDateTo.Value.Month, dtpOrderDateTo.Value.Day, 23, 59, 59)

        Dim SalesType As String = ""
        Dim SDate As String = dtpOrderDateFrom.Value.ToString()
        Dim EDate As String = dtpOrderDateTo.Value.ToString()

        Dim WQry As String

        Dim TotalAmtFrom, TotalAmtTo As Long
        TotalAmtFrom = 0
        TotalAmtTo = 99999999

        If txtTotalAmountFrom.Text.Trim <> "" Then TotalAmtFrom = Val(txtTotalAmountFrom.Text)
        If txtTotalAmountTo.Text.Trim <> "" Then TotalAmtTo = Val(txtTotalAmountTo.Text)

        WQry = "PWDate between  '" + SDate + "' And '" + EDate + "' and TotalAmount>='" + TotalAmtFrom.ToString() + "' and TotalAmount<='" + TotalAmtTo.ToString() + "'"

        If cmbCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += cmbCustomerName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        If rbnCash.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry += "Type = 'cash' "

        End If
        If rbnCredit.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry += "Type != 'cash' "

        End If

        If cmbSalesCode.Text.Trim <> "" Then
            WQry = "PartyCode='" + cmbSalesCode.Text + "'"
        End If

        If cmbOrderCode.Text.Trim <> "" Then
            WQry = "PartyCode in ( select PartyCode from PartyWorkingDetails where PartyCode='" + cmbOrderCode.Text + "')"
        End If


        Dim dv As DataView
        dv = db.PartyWorking.Grid("PartyCode as 'Code', PWDate as 'Date', MillName, Type, TotalAmount", WQry, "PartyCode")
        dgvSearch.DataSource = dv
        dgvSearch.Columns("Code").Width = 100
        dgvSearch.Columns("Date").Width = 100
        dgvSearch.Columns("MillName").Width = 200
        dgvSearch.Columns("Type").Width = 200
        dgvSearch.Columns("TotalAmount").Width = 200

        Dim TotalAmt As Long
        TotalAmt = Val(db.PartyWorking.Data("Sum(TotalAmount)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "Rs. " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If
        dgvSearch.Columns("Date").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("TotalAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmPartyWorking.txtSearchBox.Text = txtCode.Text
            frmPartyWorking.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbSalesCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSalesCode.TextChanged, cmbOrderCode.TextChanged, cmbTax.TextChanged, cmbCustomerName.TextChanged
        ViewSearch()
    End Sub
End Class