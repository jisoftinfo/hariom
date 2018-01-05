Option Strict On

Class ImageWatermark
    Private bmp As Bitmap

    Public Sub NewImage(ByVal Image As Bitmap)
        bmp = Image
    End Sub
    Public Sub AddWatermark(ByVal TextValue As String, ByVal TextColor As Color, _
         ByVal Font As Font, ByVal FontStyle As FontStyle, _
         ByVal alpha As Integer, ByVal TextPosX As Integer, ByVal TextPosY As Integer, _
         ByVal BackgroundColour As Color, _
         Optional ByVal Background As Boolean = False, _
         Optional ByVal BackgroundAlpha As Integer = 255, _
         Optional ByVal BackgroundPosX As Integer = 0, _
         Optional ByVal BackgroundPosY As Integer = 0)

        Dim watermark As String = TextValue
        Dim canvas As Graphics
        Try
            canvas = Graphics.FromImage(bmp)
        Catch e As Exception
            Dim bmpNew As Bitmap = New Bitmap(bmp.Width, bmp.Height)
            Dim rec As New Rectangle(0, 0, bmpNew.Width, bmpNew.Height)
            canvas = Graphics.FromImage(bmpNew)
            canvas.DrawImage(bmp, rec, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel)
            bmp = bmpNew
        End Try

        'Set-up the background for the text

        'Dim font As New Font(TextFont, FontSize, FontStyle)
        Dim myBrush As New SolidBrush(Color.FromArgb(alpha, TextColor))

        If Background = True Then
            Dim Backgroundcanvas As Graphics
            Dim w As Integer
            w = bmp.Width
            Backgroundcanvas = Graphics.FromImage(bmp)
            Dim rec As RectangleF
            Dim BackgroundBrush As New SolidBrush(Color.FromArgb(BackgroundAlpha, BackgroundColour))
            rec = New RectangleF(BackgroundPosX, BackgroundPosY, bmp.Width, Font.Size + 6)
            'Fill the background rectangle
            Backgroundcanvas.FillRectangle(BackgroundBrush, rec)
        End If
        'Draw the text
        canvas.DrawString(watermark, Font, myBrush, TextPosX, TextPosY)
        canvas.Dispose()
    End Sub

    Public Sub DateTimeStamp(ByVal TextValue As String, ByVal TextColor As Color, _
        ByVal Font As Font, ByVal FontStyle As FontStyle, _
        ByVal alpha As Integer, ByVal TextPosX As Integer, ByVal TextPosY As Integer, _
        ByVal BackgroundColour As Color, _
        Optional ByVal Background As Boolean = False, _
        Optional ByVal BackgroundAlpha As Integer = 255, _
        Optional ByVal BackgroundPosX As Integer = 0, _
        Optional ByVal BackgroundPosY As Integer = 0)

        Dim canvas As Graphics
        Dim watermark As String
        Dim strFormat As New StringFormat
        Dim _Time As String
        Dim _Date As String

        _Time = Format(Now, "hh:mm:ss tt")
        _Date = Format(Now, "dd:MM:yyy")

        watermark = TextValue & " " & _Date & " " & _Time
        'Get the image
        Try
            canvas = Graphics.FromImage(bmp)
        Catch e As Exception
            Dim bmpNew As Bitmap = New Bitmap(bmp.Width, bmp.Height)
            Dim rec As New Rectangle(0, 0, bmpNew.Width, bmpNew.Height)
            canvas = Graphics.FromImage(bmpNew)
            canvas.DrawImage(bmp, rec, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel)
            bmp = bmpNew
        End Try

        'Set-up the background for the text

        'Dim font As New Font(TextFont, FontSize, FontStyle)
        Dim myBrush As New SolidBrush(Color.FromArgb(alpha, TextColor))

        If Background = True Then
            Dim Backgroundcanvas As Graphics
            Dim w As Integer
            w = bmp.Width
            Backgroundcanvas = Graphics.FromImage(bmp)
            Dim rec As RectangleF
            Dim BackgroundBrush As New SolidBrush(Color.FromArgb(BackgroundAlpha, BackgroundColour))
            rec = New RectangleF(BackgroundPosX, BackgroundPosY, bmp.Width, Font.Size + 6)
            'Fill the background rectangle
            Backgroundcanvas.FillRectangle(BackgroundBrush, rec)
        End If
        'Draw the text
        canvas.DrawString(watermark, Font, myBrush, TextPosX, TextPosY)
        canvas.Dispose()
    End Sub
    Public Sub SaveImage(ByVal image As Bitmap, ByVal ImagePath As String)
        Try
            image.Save(ImagePath)
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub
    Public Sub SaveImageSnapShot(ByVal image As Bitmap, ByVal ImagePath As String, ByVal FileName As String, ByVal ImageFormat As Imaging.ImageFormat)
        Try
            Dim pathfilename As String
            pathfilename = ImagePath & "\" & FileName

            image.Save(pathfilename, ImageFormat)
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub
    Public ReadOnly Property Image() As Bitmap
        Get
            Return bmp
        End Get
    End Property

End Class
