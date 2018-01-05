Imports System.IO
Public Class frmProducts
    Dim tb As JISTable = db.Products

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtProductName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtProductName, "Please Enter the Product Name")
            txtProductName.Focus()
            RValue = False
        ElseIf tb.State = "New" And tb.ExistUserCode(txtProductName.Text) Then
            ErrorProvider1.SetError(txtProductName, txtProductName.Text + " is Already Exist. Please Enter the New Product Name")
            txtProductName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtProductName, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtProductName.Enter, txtCode.Enter, txtId.Enter, txtItemCode.Enter, txtSellingRate.Enter, lblSellingRate.Enter, cmbUOMSymbol.Enter, txtPurchaseRate.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.name = "cmbUOMSymbol" Then List_Datas(cmbUOMSymbol, db.UnitsOfMeasurement.UserCodes())
        If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, tb.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, TextBox5.Leave, txtSellingRate.Leave, lblSellingRate.Leave, cmbUOMSymbol.Leave, txtItemCode.Leave, txtId.Leave, txtCode.Leave, txtProductName.Leave, txtPurchaseRate.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtProductName, txtItemCode, txtPurchaseRate, txtSellingRate, cmbUOMSymbol)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmProductsReport)
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

                If ctl.Name = cmbUOMSymbol.Name Then
                    FormShow(frmUnits)
                End If
            ElseIf ctl.Text = "@" Then
                If ctl.Name = cmbUOMSymbol.Text Then
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
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

        'l = (pnlContent.Width - pnlForm.Width) / 2
        'If l < 0 Then l = 0

        't = (pnlContent.Height - pnlForm.Height) / 2
        'If t < 0 Then t = 0

        'pnlForm.Left = l
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

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        ViewForm()
    End Sub


    Sub NewForm()
        tb.NewRecord()
        'picFrame.BackgroundImage = Nothing
        ErrorProvider1.Clear()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            txtSearchBox.Text = txtSearchBox.Text.Replace("'", "''")
            str = tb.ViewRecordByUserCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            If File.Exists(Application.StartupPath + "\Images\ItemMaster\" + txtCode.Text + ".jpg") Then

                Dim buffer As Byte() = File.ReadAllBytes(Application.StartupPath + "\Images\ItemMaster\" + txtCode.Text + ".jpg")
                Dim stream As MemoryStream = New MemoryStream(buffer)

                Dim bm As Bitmap = CType(Bitmap.FromStream(stream), Bitmap)

                ' picFrame.BackgroundImage = bm.Clone
                stream.Dispose()
                bm.Dispose()
                'picFrame.BackgroundImageLayout = ImageLayout.Stretch
            Else
                'picFrame.BackgroundImage = Nothing
            End If
            ' txtFile.Text = ""

            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            txtProductName.Text = txtProductName.Text.Replace("'", "''")
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then

                'If File.Exists(txtFile.Text) Then
                '    File.Copy(txtFile.Text, Application.StartupPath + "\Images\ItemMaster\" + txtCode.Text + ".jpg", True)
                'End If
                NewForm()
            End If

            
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

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FormShow(frmProductsearch)
    End Sub

    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim od As New OpenFileDialog
    '    If od.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        txtFile.Text = od.FileName
    '        picFrame.BackgroundImage = New Bitmap(od.FileName)
    '    End If
    'End Sub

   
End Class