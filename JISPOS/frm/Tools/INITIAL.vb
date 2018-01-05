
Public NotInheritable Class INITIAL

    Private Sub INITIAL_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim db As New DBLib
        Timer1.Enabled = True
    End Sub

    Private Sub INITIAL_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ApplicationTitle.Text = "JISoft"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
        Timer1.Enabled = False
        frmLogin.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
