Public Class frmCNosearch
    Private Sub frmCustomerSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ViewSearch()
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
        Dim dv As New DataView
    End Sub
    Sub ViewSearch()

        Dim WQry As String

        WQry = ""
       
        If cmbMillName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MillName like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        If cmbPartyName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PartyName like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += cmbPartyName.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        If txtCFormNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "CFormNo = '" + txtCFormNo.Text + "'"
        End If
        If cmbPeriodFrom.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PeriodFrom = '" + cmbPeriodFrom.Text + "'"
        End If
        If cmbYear.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PeriodYear = '" + cmbYear.Text + "'"
        End If
        Dim dv As DataView
        dv = db.ViewEForm.Grid("EFormCode as Code,MillName as MillName,PartyName,BillingName,Amount,CFormNo,CAmount,CFormSentDate As SentDt,CourierName,CourierNo,E1FormNo", WQry, "EFormCode")
        dgvProductSearch.DataSource = dv

        dgvProductSearch.Columns("Code").Width = 80
        dgvProductSearch.Columns("MillName").Width = 120
        dgvProductSearch.Columns("PartyName").Width = 120
        dgvProductSearch.Columns("BillingName").Width = 100
        dgvProductSearch.Columns("Amount").Width = 50
        dgvProductSearch.Columns("CFormNo").Width = 50
        dgvProductSearch.Columns("CAmount").Width = 70
        dgvProductSearch.Columns("SentDt").Width = 80
        dgvProductSearch.Columns("CourierName").Width = 100
        dgvProductSearch.Columns("CourierNo").Width = 100
        dgvProductSearch.Columns("E1FormNo").Width = 100
        dgvProductSearch.Columns("SentDt").DefaultCellStyle.Format = "dd/MM/yyyy"
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.Enter, cmbPartyName.Enter, txtCFormNo.Enter, cmbYear.Enter, cmbPeriodFrom.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName"))
        End If
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMillName.Leave, cmbPartyName.Leave, txtCFormNo.Leave, cmbYear.Leave, cmbPeriodFrom.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProductSearch.DoubleClick
        Try
            frmCForm.txtSearchBox.Text = dgvProductSearch.SelectedRows(0).Cells(0).Value()

            frmCForm.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmProductsearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub

End Class