Imports System.Net.Mail

Public Class JISEMail
    Dim DomainName As String
    Dim PortNo As Integer
    Dim UserId As String
    Dim Password As String
    Dim IsSSL As Boolean
    Dim SMTPServer As SmtpClient

    Sub New()
        DomainName = "mail.jisoft.in"
        PortNo = 25
        UserId = "hariom@jisoft.in"
        Password = "JISoft2014+"
        IsSSL = False
        SMTPServer = New SmtpClient(DomainName)
        SMTPServer.Port = PortNo
        SMTPServer.Credentials = New System.Net.NetworkCredential(UserId, Password)
        SMTPServer.EnableSsl = IsSSL
    End Sub
    Public Function ConvertToHTML(ByVal Box As RichTextBox) As String
        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer
        ' If nothing in the box, exit
        If Box.Text.Length = 0 Then
            Return ""
        End If
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Box.TextLength
        Box.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Set up initial parameters
        strColour = Box.SelectionColor.ToKnownColor.ToString
        blnBold = Box.SelectionFont.Bold
        blnItalic = Box.SelectionFont.Italic
        strFont = Box.SelectionFont.FontFamily.Name
        shtSize = Box.SelectionFont.Size
        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont & _
          "; font-size: " & shtSize & "pt; color: " _
              & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If
        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character
        strHTML += Box.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Box.Text.Length
            ' Select current character
            Box.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Box.Text.Substring(intCount - 1, 1) = _
                Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Box.SelectionColor.ToKnownColor.ToString <> _
               strColour Or Box.SelectionFont.FontFamily.Name _
               <> strFont Or Box.SelectionFont.Size <> shtSize _
               Then
                strHTML += "</span><span style=""font-family: " _
                  & Box.SelectionFont.FontFamily.Name & _
                  "; font-size: " & Box.SelectionFont.Size & _
                  "pt; color: " & _
                  Box.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Box.SelectionFont.Bold <> blnBold Then
                If Box.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for italic changes
            If Box.SelectionFont.Italic <> blnItalic Then
                If Box.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Box.Text, intCount, 1)
            ' Update variables with current style
            strColour = Box.SelectionColor.ToKnownColor.ToString
            blnBold = Box.SelectionFont.Bold
            blnItalic = Box.SelectionFont.Italic
            strFont = Box.SelectionFont.FontFamily.Name
            shtSize = Box.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += ""
        If blnItalic = True Then strHTML += ""
        ' Terminate outstanding HTML tags
        strHTML += "</span></html>"
        ' Restore original RichTextBox selection
        Box.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
    End Function
    Function SendMail(ByVal EMailTo As String, ByVal EMailSub As String, ByVal EMailBody As String, Optional ByVal AttachFiles As ArrayList = Nothing)
        Try
            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress(UserId)
            MyMailMessage.To.Add(EMailTo)
            MyMailMessage.Bcc.Add("tulsyandinesh@gmail.com")
            MyMailMessage.Subject = EMailSub
            '    MyMailMessage.Body = "<font size=5>This is</font> <font color=red><b>Hi THis is Dhana</b></font>"
            MyMailMessage.IsBodyHtml = True
            MyMailMessage.Body = EMailBody
            If Not AttachFiles Is Nothing Then
                For i As Integer = 0 To AttachFiles.Count - 1
                    Dim Attach As Net.Mail.Attachment = New Net.Mail.Attachment(AttachFiles(i))
                    MyMailMessage.Attachments.Add(Attach)
                Next
            End If

            SMTPServer.Send(MyMailMessage)
            Return "Sent"
        Catch ex As Exception
            Return "Not Sent"
        End Try
    End Function

End Class
