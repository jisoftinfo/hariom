Imports System.Net.Mail

Public Class frmEMail

    Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser.Click
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                lstAttachedFiles.Items.Add(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lstAttachedFiles.Items.Remove(lstAttachedFiles.SelectedItem)
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Me.Enabled = False
        Try
            Dim ObjEM As New JISEMail()
            Dim AttFiles As New ArrayList

            Dim counter As New Integer
            For counter = 0 To lstAttachedFiles.Items.Count - 1
                AttFiles.Add(lstAttachedFiles.Items(counter))
            Next
            Dim arr() As String
            arr = txtSendMail.Text.Split(",")
            For j As Integer = 0 To arr.Count - 1
                MsgBox(ObjEM.SendMail(arr(j), txtSubject.Text, ObjEM.ConvertToHTML(rtxtMessage), AttFiles))
                ' MsgBox(ObjEM.SendMail(arr(j), txtSubject.Text, Message, AttFiles))
            Next
        Catch ex As Exception

        End Try
        Me.Enabled = True
    End Sub

    Private Sub frmEMail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                Me.SelectNextControl(ctl, True, True, True, True)
            End If
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmEMail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
End Class