Public Class frmLogin

    Function formvalidation() As Boolean
        If txtuserid.Text = "" Then
            MsgBox("Enter the userid")
            txtuserid.Focus()
            Return False
        ElseIf cmbCompanyName.Text = "" Then
            MsgBox("Enter the Company Name")
            cmbCompanyName.Focus()
            Return False

        ElseIf txtPassword.Text = "" Then
            MsgBox("Enter the password")
            txtPassword.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuserid.Enter, txtPassword.Enter, cmbCompanyName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.name = "cmbCompanyName" Then List_Datas(cmbCompanyName, db.CompanyDetails.UserCodes)
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuserid.Leave, txtPassword.Leave, cmbCompanyName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.Escape) Then
            txtPassword.Text = ""
            MsgDialog.ShowMsgDlg(txtPassword, "Do you want to QUIT", "LOGIN", "Q")
            If MsgDialog.DialogResult = Windows.Forms.DialogResult.Yes Then
                End
            End If
        ElseIf e.KeyCode = Keys.F1 And e.Control And e.Shift And e.Alt Then
            pnlCompany.Visible = Not pnlCompany.Visible
        ElseIf e.KeyCode = Keys.Scroll And e.Control And e.Shift And e.Alt Then
            Try
                If cmbCompanyName.Text.Trim() = "" Then cmbCompanyName.Text = db.CompanyDetails.Data("CompanyName", "CompanyId=" + GetCompanyId())
                Dim arr As New ArrayList()
                arr = db.UserAccount.Row("UserName,Password", "CompanyName='" + cmbCompanyName.Text + "' and UserType='Admin'")
                txtuserid.Text = arr(0)
                txtPassword.Text = arr(1)
                UserLogin()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
        txtuserid.Text = ""
        txtPassword.Text = ""
        cmbCompanyName.Text = db.CompanyDetails.Data("CompanyName", "CompanyId=" + GetCompanyId())
        txtuserid.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Try
        '    txtuserid.Text = ""
        '    cmbCompanyName.Text = ""
        '    cmbYear.Text = ""
        '    txtPassword.Text = ""
        'Catch ex As Exception

        'End Try
        End
    End Sub
    Sub UserLogin()
        Try
            If formvalidation() Then

                Type = db.UserAccount.Data("UserType", "CompanyName='" + cmbCompanyName.Text + "' and UserName='" + txtuserid.Text + "' and password='" + txtPassword.Text + "'")
                If Type <> "" Then
                    CompName = cmbCompanyName.Text
                    UserName = txtuserid.Text
                    UserType = Type

                    'Dim CompanyType As String
                    'CompanyType = db.CompanyDetails.Data("CompanyType", "CompanyName='" + CompName + "'")
                    'If CompanyType = "Motors" Then
                    '    FormMaster = frmMasterMoter
                    'ElseIf CompanyType = "Batteries" Then
                    '    FormMaster = frmMasterBattery
                    'End If
                    'JISDbTransaction = New JISDatabase("Data Source=" + DBServerName + ";Initial Catalog=" + DBName + "_" + CompName.Replace(" ", "").Trim() + ";User ID=" + DBUserName + ";Password=" + DBPassword, "SQL")
                    db = New DBLib()
                    frmMaster.Show()
                    Me.Close()


                Else
                    MsgBox("Invalid User")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        UserLogin()
    End Sub

    Private Sub btnCompanyRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompanyRegister.Click
        frmCompanyDetails.ShowDialog()
    End Sub

End Class