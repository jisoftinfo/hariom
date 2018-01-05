Imports System.Data.SqlClient
Imports System.IO

Public Class frmCompanyDetails
    Dim tb As JISTable = db.CompanyDetails

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtCompanyName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtCompanyName, "Please Enter the Company Name")
            txtCompanyName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtCompanyName, "")
        End If
        If txtAddress.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAddress, "Please Enter the Address Line1")
            txtAddress.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtAddress, "")
        End If
        Return RValue
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtCompanyName.Enter, txtTINNo.Enter, txtPhoneNo.Enter, txtMobileNo.Enter, txtMailId.Enter, txtCSTNo.Enter, txtAddress.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTINNo.Leave, txtPhoneNo.Leave, txtMobileNo.Leave, txtMailId.Leave, txtCSTNo.Leave, txtCompanyName.Leave, txtCode.Leave, txtAddress.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtCompanyName, txtAddress, txtPhoneNo, txtMobileNo, txtMailId, txtTINNo, txtCSTNo)
        SetFormStyle(Me)
        NewForm()
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

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveForm()
    End Sub


    Sub NewForm()
        tb.NewRecord()
        txtCompanyName.ReadOnly = False
        ErrorProvider1.Clear()
        txtFile.Text = ""
        picFrame.BackgroundImage = Nothing
    End Sub

    Public Sub ViewForm(ByVal ComName As String)
        If ComName.Trim() = "" Then
            Me.Close()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByUserCode(ComName)
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                If File.Exists(Application.StartupPath + "\Images\CompanyBG\" + txtCode.Text + ".jpg") Then
                    Dim buffer As Byte() = File.ReadAllBytes(Application.StartupPath + "\Images\CompanyBG\" + txtCode.Text + ".jpg")
                    Dim stream As MemoryStream = New MemoryStream(buffer)

                    Dim bm As Bitmap = CType(Bitmap.FromStream(stream), Bitmap)

                    picFrame.BackgroundImage = bm.Clone
                    stream.Dispose()
                    bm.Dispose()
                    picFrame.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    picFrame.BackgroundImage = Nothing
                End If
                txtFile.Text = ""
            End If
            txtCompanyName.ReadOnly = True
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Then
                Dim objConn As New SqlConnection("Data Source=" + DBServerName + ";Initial Catalog=Master;User ID=" + DBUserName + ";Password=" + DBPassword)
                objConn.Open()
                Try
                    File.Delete(DBBackupPath + "JISPOS_Private_New.bak")
                Catch ex As Exception

                End Try

                Dim objCmd As New SqlCommand("BACKUP DATABASE " + DBName + " TO DISK = '" + DBRestorePath + "JISPOS_Private_New.bak'", objConn)
                objCmd.ExecuteNonQuery()

                Dim objCmdRes As New SqlCommand("RESTORE DATABASE " + DBName + "_" + txtCompanyName.Text.Replace(" ", "") + " FROM DISK='" + DBRestorePath + "JISPOS_Private_New.bak' WITH MOVE '" + DBName + "_data' TO '" + DBRestorePath + DBName + "_" + txtCompanyName.Text.Replace(" ", "") + ".mdf', MOVE '" + DBName + "_log' TO '" + DBRestorePath + DBName + "_" + txtCompanyName.Text.Replace(" ", "") + "_log.ldf'", objConn)
                objCmdRes.ExecuteNonQuery()
                objConn.Close()

                db.UserAccount.SaveRecord(db.UserAccount.NewId(), db.UserAccount.NewCode(), txtCompanyName.Text, "Admin", "Admin", "Admin")
            End If
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                If File.Exists(txtFile.Text) Then
                    File.Copy(txtFile.Text, Application.StartupPath + "\Images\CompanyBG\" + txtCode.Text + ".jpg", True)

                    Dim buffer As Byte() = File.ReadAllBytes(Application.StartupPath + "\Images\CompanyBG\" + txtCode.Text + ".jpg")
                    Dim stream As MemoryStream = New MemoryStream(buffer)

                    Dim bm As Bitmap = CType(Bitmap.FromStream(stream), Bitmap)

                    frmMaster.BackgroundImage = bm.Clone
                    frmMaster.BackgroundImageLayout = ImageLayout.Stretch
                    stream.Dispose()
                    bm.Dispose()
                End If
                Me.Close()
            End If

        End If
    End Sub


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim od As New OpenFileDialog
        If od.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile.Text = od.FileName
            picFrame.BackgroundImage = New Bitmap(od.FileName)
        End If
    End Sub
 
End Class