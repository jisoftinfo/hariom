Public Class frmProductsReport
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

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim WQry As String

        Dim SaleRateFrom, SaleRateTo As Long
        SaleRateFrom = 0
        SaleRateTo = 99999999

        If txtStartingSRate.Text.Trim <> "" Then SaleRateFrom = Val(txtStartingSRate.Text)
        If txtEndingSRate.Text.Trim <> "" Then SaleRateTo = Val(txtEndingSRate.Text)

        WQry = ""
        WQry = "SellingRate>='" + SaleRateFrom.ToString() + "' and SellingRate<='" + SaleRateTo.ToString() + "'"

        If txtProductName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ProductName Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += txtProductName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTProducts As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName=N'" + CompName + "'").ToTable("CompanyDetails")

        Dim OrderBy As String
        OrderBy = ""
        If cmbOrderBy.Text = "Product Name" Then
            OrderBy = "ProductName"
        ElseIf cmbOrderBy.Text = "Units" Then
            OrderBy = "UOMSymbol"
        ElseIf cmbOrderBy.Text = "Sale Rate" Then
            OrderBy = "SellingRate"
        End If

        If OrderBy <> "" And rbnDescending.Checked = True Then
            OrderBy += " desc"
        End If

        DTProducts = db.Products.Grid("*", WQry, OrderBy).ToTable("Products")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTProducts)
        ReportView(CrystalReportViewer1, "Master\cryProducts.rpt", ds)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartingSRate.Enter, txtProductName.Enter, txtEndingSRate.Enter, cmbOrderBy.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartingSRate.Leave, txtProductName.Leave, txtEndingSRate.Leave, cmbOrderBy.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub
End Class