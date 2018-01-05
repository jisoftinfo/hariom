Imports System.Data.OleDb

Public Class Form1
    'Passwsord = tulsyan50
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String
        str = "<html><head></head><body><font style='color:#00ffcc'>DINESH TULSYAN</font><br><font style='color:#00ffcc'>HARIOM YARN AGENCY</font><br><font style='color:#00ffcc'>2/569,VAGAI ST.,GOMATHIPURAM 6TH</font><br><font style='color:#00ffcc'>MAIN(ROAD.MADURAI - 625020)</font><br><font style='color:#00ffcc'>TAMILNADU</font><br><font style='color:#00ffcc'>tulsyandinesh@(gmail.com)</font><br><font style='color:#00ffcc'>Cell(+9345213033, 8220010234)</font><br><font style='color:#00ffcc'>Ph :  0452-4516303, 4383033, 82206-60044</font><br><hr style='color:#00ffcc'><br><table cellpadding=0 cellspacing=0><tr><td>Test</td></tr></table></body></html>"
        RichTextBox1.Rtf = HTMLtoRTF(str)
        RichTextBox1.SaveFile("d:\mstech\dhana.doc")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = GetAPIData(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim webClient As New System.Net.WebClient
        Dim SMSURL As String = String.Format("http://enterprise.liveair.in/httpapi/httpapi?token=a511a63dbdbf7402f979368e55dad627&sender={0}&number={1}&route={2}&type={3}&sms={4}", "hariom", "8428492911", "2", "1", "Testing SMS")

        Dim result As String = webClient.DownloadString(SMSURL)

        'textBox1.Text = String.Format("http://bulksmsservice.co.in/api/sentsms.php?username=hariomyarnagency&api_password=73edcef479&to={0}&priority=2&sender=HARIOM&message={1}", TextBox3.Text, TextBox4.Text)
        TextBox1.Text = result
    End Sub
End Class
