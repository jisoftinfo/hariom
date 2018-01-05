Public Class frmColorSchema
    Dim db As New DBLib

    Sub NewForm()
        db.ColorSchema.NewRecord()
        btnFColor.Focus()

    End Sub
    Sub ViewForm(ByVal Code As String)
        Dim str As String = ""
        str = db.ColorSchema.ViewRecordByUserCode(Code)
      End Sub
    Private Sub btnFColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFColor.Click
        If ColorDialog1.ShowDialog Then
            txtFColor.Text = ColorDialog1.Color.ToArgb
            Label1.ForeColor = Color.FromArgb(txtFColor.Text)
            lblheader.ForeColor = Color.FromArgb(txtFColor.Text)
        End If
    End Sub

    Private Sub btnBColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBColor.Click
        If ColorDialog1.ShowDialog Then
            txtBColor.Text = ColorDialog1.Color.ToArgb
            pnlcontent.BackColor = Color.FromArgb(txtBColor.Text)
        End If
    End Sub

    Private Sub btnGrid1stFColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrid1stFColor.Click
        If ColorDialog1.ShowDialog Then
            txtGrid1stFColor.Text = ColorDialog1.Color.ToArgb

        End If
    End Sub

    Private Sub btnGrid2stFColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrid2stFColor.Click
        If ColorDialog1.ShowDialog Then
            txtGrid2stFColor.Text = ColorDialog1.Color.ToArgb
        End If
    End Sub

    Private Sub btnGrid1stBColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrid1stBColor.Click
        If ColorDialog1.ShowDialog Then
            txtGrid1stBColor.Text = ColorDialog1.Color.ToArgb
        End If
    End Sub

    Private Sub btnGrid2stBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrid2stBackColor.Click
        If ColorDialog1.ShowDialog Then
            txtGrid2stBColor.Text = ColorDialog1.Color.ToArgb
        End If
    End Sub

    Private Sub btnbtnBordercolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbtnBordercolor.Click
        If ColorDialog1.ShowDialog Then
            txtbtnBordercolor.Text = ColorDialog1.Color.ToArgb
        End If
    End Sub

    Private Sub btnMouseDownBackcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMouseDownBackcolor1.Click
        If ColorDialog1.ShowDialog Then
            txtbtnMouseDownBackcolor.Text = ColorDialog1.Color.ToArgb

        End If
    End Sub

    Private Sub btnMouseOverBackcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMouseOverBackcolor1.Click
        If ColorDialog1.ShowDialog Then
            txtbtnMouseOverBackcolor.Text = ColorDialog1.Color.ToArgb

        End If
    End Sub

    Private Sub btnGridHeading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridHeading.Click
        If ColorDialog1.ShowDialog Then
            txtGridHeading.Text = ColorDialog1.Color.ToArgb

        End If
    End Sub

    Private Sub btntitlecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntitlecolor.Click
        If ColorDialog1.ShowDialog Then
            txtlbltitle.Text = ColorDialog1.Color.ToArgb
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim str As String = ""
        str = db.ColorSchema.SaveRecord()
        'If Str.ToLower.Trim() = "inserted" Then txtSearchBox.AutoCompleteCustomSource.Add(txtACNo.Text)
        If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
        'FrmLogin.SetColor()
    End Sub

    Private Sub frmColorSchema_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmColorSchema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        db.ColorSchema.SetControls(txtcolorid, txtcolorcode, txtstaffname, txtFColor, txtBColor, txtGrid1stFColor, txtGrid2stFColor, txtGrid1stBColor, txtGrid2stBColor, txtbtnBordercolor, txtbtnMouseDownBackcolor, txtbtnMouseOverBackcolor, txtGridHeading, txtlbltitle)
        ViewForm(Login_Id)
        SetFormStyle(Me)

    End Sub

    Private Sub BtnDef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDef.Click
        Dim str As String = ""
        str = (db.ColorSchema.SaveRecord(txtcolorid.Text, txtcolorcode.Text, txtstaffname.Text, "-16767964", "-327681", "-16767964", "-16767964", "-327681", "-327681", "-16765650", "-5832705", "-3342337", "-64", "-4839231"))
        If str.Trim() <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I")
        If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
        End If
        'FrmLogin.SetColor()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
End Class