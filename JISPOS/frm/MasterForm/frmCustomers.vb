Public Class frmCustomers
    Dim tb As JISTable = db.Party

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtCustomerName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtCustomerName, "Please Enter the Customer Name")
            txtCustomerName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtCustomerName, "")
        End If

        Return RValue
    End Function

    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtTinNo.Enter, txtPhNo.Enter, txtMobileNo.Enter, txtEmailId.Enter, txtCST.Enter, txtBil.Enter, txtAddressLine.Enter, txtId.Enter, txtCustomerName.Enter, txtCode.Enter, txtAddressLine2.Enter, txtBillingName.Enter, txtOpBal.Enter, txtShortName.Enter, txtDesignation4.Enter, txtDesignation3.Enter, txtDesignation2.Enter, txtDesignation1.Enter, txtDepartment4.Enter, txtDepartment3.Enter, txtDepartment2.Enter, txtDepartment1.Enter, txtPerson4.Enter, txtPerson3.Enter, txtPerson2.Enter, txtPerson1.Enter, txtMobileNo4.Enter, txtMobileNo3.Enter, txtMobileNo2.Enter, txtMobileNo1.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtTinNo.Leave, txtPhNo.Leave, txtMobileNo.Leave, txtEmailId.Leave, txtCST.Leave, txtBil.Leave, txtAddressLine.Leave, txtId.Leave, txtCustomerName.Leave, txtCode.Leave, txtAddressLine2.Leave, txtBillingName.Leave, txtOpBal.Leave, txtShortName.Leave, txtDesignation4.Leave, txtDesignation3.Leave, txtDesignation2.Leave, txtDesignation1.Leave, txtDepartment4.Leave, txtDepartment3.Leave, txtDepartment2.Leave, txtDepartment1.Leave, txtPerson4.Leave, txtPerson3.Leave, txtPerson2.Leave, txtPerson1.Leave, txtMobileNo4.Leave, txtMobileNo3.Leave, txtMobileNo2.Leave, txtMobileNo1.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtBillingName, txtCustomerName, txtAddressLine, txtAddressLine2, txtMobileNo, txtPhNo, txtCST, txtTinNo, txtEmailId, txtOpBal, txtPerson1, txtPerson2, txtPerson3, txtPerson4, txtMobileNo1, txtMobileNo2, txtMobileNo3, txtMobileNo4, txtShortName, txtDepartment1, txtDepartment2, txtDepartment3, txtDepartment4, txtDesignation1, txtDesignation2, txtDesignation3, txtDesignation4)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmCustomersReport)
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
        FormShow(frmCustomerSearch)
    End Sub


    Sub NewForm()
        tb.NewRecord()
        txtCustomerName.Focus()
        txtMobileNo2.Text = ""
        txtOpBal.Text = "0"
        DataGridView1.Rows.Clear()
        txtNote.Text = ""
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True
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
                txtSearchBox.Text = ""
                Dim dv As New DataView
                Try
                    dv = db.PartyAddress.Grid("InvoiceAddress,DeliveryAddress,[Note]", String.Format("PartyCode='{0}'", txtCode.Text))
                    DataGridView1.Rows.Clear()
                    For i As Integer = 0 To dv.Count - 1
                        DataGridView1.Rows.Add()
                        DataGridView1.Item(0, i).Value = dv(i)(0).ToString()
                        DataGridView1.Item(1, i).Value = dv(i)(1).ToString()
                        txtNote.Text = dv(i)(2).ToString()
                    Next

                Catch ex As Exception

                End Try
                
            End If

            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                db.PartyAddress.DeleteRecordByUserCode(txtCode.Text)
                For i As Integer = 0 To DataGridView1.Rows.Count - 2
                    Dim Address1, Address2 As String
                    If DataGridView1.Item(0, i).Value Is Nothing Then
                        Address1 = ""
                    Else
                        Address1 = DataGridView1.Item(0, i).Value.ToString()
                    End If

                    If DataGridView1.Item(1, i).Value Is Nothing Then
                        Address2 = ""
                    Else
                        Address2 = DataGridView1.Item(1, i).Value.ToString()
                    End If

                    db.PartyAddress.SaveRecord(db.PartyAddress.NewId(), db.PartyAddress.NewCode(), txtCode.Text, Address1, Address2, txtNote.Text)
                Next
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
            NewForm()
        End If
    End Sub

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        ViewForm()
    End Sub

    'Private Sub txtCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerName.TextChanged
    '    txtBillingName.Text = String.Copy(txtCustomerName.Text)
    'End Sub
    Private Sub DataGridView1_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        DataGridView1.Rows(0).HeaderCell.Value = 123
    End Sub
End Class