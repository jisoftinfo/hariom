Option Strict Off
Option Explicit On
Module HTMLRTFConverter

    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:32:24 AM
    'Project Name      :   BeAware
    'Form/Class Name   :   HTML2RTF (Code)
    'Version           :   6.00
    'Description       :   This module encapsulates all the sub and functions needed for
    '                      HTML to RTF convertion
    '                      This deals with the basic formatting extra functionality can be easily added
    'Links             :   <Links With Any Other Form Modules>
    'Change History    :
    'Date      Author      Description Of Changes          Reason Of Change
    'Dec -20 - 2001
    'Vijay
    'Modified the code to include table formatting.
    '************************************************************************



    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:33:55 AM
    'Returns the RTF format of the HTML code supplied
    '************************************************************************
    Public Function HTMLtoRTF(ByRef sHTML As String) As String
        Dim ColorTable() As String
        Dim FontTable() As String
        Dim FontNumber, ColorCombNumber As Short
        Dim lTStart, lStart, lEnd, lTEnd As Integer
        Dim bFound, bFaceFound As Boolean
        Dim sFontTable, sColorTable As String
        Dim PreviousFontFace, DefaultFace As String
        Dim PreviousFontSize As Short
        Dim sRTF, sHead, sText As String
        Dim lLen, lCurrentToken As Integer
        Dim sToken, sTemp As String
        Dim I As Short
        Dim bUseDefaultFace As Boolean
        Dim sImage As String
        Dim FileContents As String

        On Error GoTo Error_Renamed
        Dim lHyperLink As Short

        lHyperLink = 0
        Dim gsHyperLink(0) As Object
        'Fix the HTML
        sHTML = Replace(sHTML, "<STRONG>", "<B>")
        sHTML = Replace(sHTML, "</STRONG>", "</B>")
        sHTML = Replace(sHTML, "<EM>", "<I>")
        sHTML = Replace(sHTML, "</EM>", "</I>")
        sHTML = Replace(sHTML, vbCrLf, "")
        sHTML = Replace(sHTML, "&nbsp;", "\~")


        'Initialize
        lLen = Len(sHTML)
        lStart = 1
        lEnd = 1

        'Add some default fonts
        ReDim FontTable(1)
        FontTable(0) = "Times New Roman"
        FontNumber = FontNumber + 1
        FontTable(1) = "MS Sans Serif"
        FontNumber = FontNumber + 1

        PreviousFontSize = 24 '12 'default font size

        'Add some default color
        ReDim ColorTable(3)
        ColorTable(0) = "000000" 'Black
        ColorCombNumber = ColorCombNumber + 1
        ColorTable(1) = "ff0000" 'Red
        ColorCombNumber = ColorCombNumber + 1
        ColorTable(2) = "00ff00" 'Green
        ColorCombNumber = ColorCombNumber + 1
        ColorTable(3) = "0000ff" 'Blue
        ColorCombNumber = ColorCombNumber + 1

        'Parse the HTML
        For lCurrentToken = 1 To lLen
            'get the tag
            lStart = InStr(lEnd, sHTML, "<")
            If lStart = 0 Then GoTo Completed
            lEnd = InStr(lStart, sHTML, ">")
            sToken = UCase(Mid(sHTML, lStart, lEnd - lStart + 1))
            '    Debug.Print sToken
            'Take action
            Select Case sToken
                Case "<B>"
                    sRTF = sRTF & "\b1"
                Case "</B>"
                    sRTF = sRTF & "\b0"
                Case "<I>"
                    sRTF = sRTF & "\I1"
                Case "</I>"
                    sRTF = sRTF & "\I0"
                Case "<U>"
                    sRTF = sRTF & "\ul1"
                Case "</U>"
                    sRTF = sRTF & "\ul0"
                Case "<TR>"
                    sRTF = sRTF & "\intbl"
                Case "</TR>"
                    sRTF = sRTF & "\row"
                Case "<TD>"
                Case "</TD>"
                    sRTF = sRTF & "\cell "
                Case "<BR>", "</P>"
                    sRTF = sRTF & vbCrLf & "\par "
                Case "</FONT>"
                    bUseDefaultFace = True
                    sRTF = sRTF & "\plain\cf1"
                Case Else
                    If UCase(Left(sToken, 6)) = "<TABLE" Then
                        sRTF = sRTF & "\plain"
                        sRTF = sRTF & GetTableStructure(sHTML, lStart)
                    End If
            End Select



            'Set font and color table
            'Check for fonts
            If InStr(1, UCase(sToken), "FONT") > 0 And Mid(sToken, 2, 1) <> "/" Then
                bUseDefaultFace = False
                lTStart = InStr(1, UCase(sToken), "FACE=")
                If lTStart > 0 Then
                    bFaceFound = True
                    lTEnd = InStr(lTStart + Len("FACE=") + 1, sToken, """")
                    If lTEnd = 0 Then
                        lTEnd = InStr(lTStart + Len("FACE="), sToken, " ")
                    End If
                    If lTEnd = 0 Then
                        lTEnd = InStr(lTStart + Len("FACE="), sToken, ">")
                    End If
                    sTemp = Replace(Mid(sToken, lTStart + Len("FACE="), lTEnd - (lTStart + Len("FACE="))), """", "")
                    If sTemp <> "" Then
                        bFaceFound = True
                        'Check if it is already in the table
                        If Not IsArrayEmpty(FontTable) Then
                            For I = 0 To UBound(FontTable)
                                If sTemp = FontTable(I) Then
                                    bFound = True
                                    Exit For
                                End If
                            Next I
                        Else
                            bFound = False
                        End If
                        'If not found add it
                        If bFound = False Then
                            ReDim Preserve FontTable(FontNumber)
                            FontTable(FontNumber) = sTemp
                            FontNumber = FontNumber + 1
                            PreviousFontFace = sTemp
                            If DefaultFace = "" Then DefaultFace = sTemp
                        End If
                        sRTF = sRTF & "\f" & GetIndex(FontTable, sTemp)
                        sTemp = ""
                        bFound = False
                    End If
                Else
                    bFaceFound = False
                End If

                lTStart = InStr(1, UCase(sToken), "SIZE=")
                If lTStart > 0 Then
                    lTEnd = InStr(lTStart + Len("SIZE="), sToken, " ")
                    If lTEnd = 0 Then
                        lTEnd = InStr(lTStart + Len("SIZE="), sToken, ">")
                    End If
                    sTemp = Replace(Mid(sToken, lTStart + Len("SIZE="), lTEnd - (lTStart + Len("SIZE="))), """", "")
                    If sTemp <> "" Then
                        sTemp = GetFontSize(sTemp)
                        PreviousFontSize = CShort(sTemp)
                        sTemp = ""
                    End If
                    bFound = False
                End If

                'Check for colors
                lTStart = InStr(1, UCase(sToken), "COLOR:")
                If lTStart > 0 Then
                    lTEnd = InStr(lTStart + Len("COLOR:"), sToken, " ")
                    If lTEnd = 0 Then
                        lTEnd = InStr(lTStart + Len("COLOR:"), sToken, ">")
                    End If
                    sTemp = Mid(sToken, lTStart + Len("COLOR:"), lTEnd - (lTStart + Len("COLOR:")))
                    sTemp = Replace(sTemp, """", "")
                    sTemp = Replace(sTemp, "#", "")
                    If sTemp <> "" Then
                        'Check if it is already in the table
                        If Not IsArrayEmpty(ColorTable) Then
                            For I = 0 To UBound(ColorTable)
                                If sTemp = ColorTable(I) Then
                                    bFound = True
                                    Exit For
                                End If
                            Next I
                        Else
                            bFound = False
                        End If
                        'If not found add it
                        If bFound = False Then
                            ReDim Preserve ColorTable(ColorCombNumber)
                            ColorTable(ColorCombNumber) = sTemp
                            ColorCombNumber = ColorCombNumber + 1
                        End If
                        sRTF = sRTF & "\cf" & GetIndex(ColorTable, sTemp) + 1
                        sTemp = ""
                        bFound = False
                    End If
                End If
            End If

            'Check for back ground colors
            '<FONT style="BACKGROUND-COLOR: #6495ed">
            lTStart = InStr(1, UCase(sToken), "STYLE=""BACKGROUND-COLOR:")
            If lTStart > 0 Then
                lTEnd = InStr(lTStart + Len("STYLE=""BACKGROUND-COLOR:"), sToken, " ")
                If lTEnd = 0 Then
                    lTEnd = InStr(lTStart + Len("STYLE=""BACKGROUND-COLOR:"), sToken, ">")
                End If
                sTemp = Mid(sToken, lTStart + Len("STYLE=""BACKGROUND-COLOR:"), lTEnd - (lTStart + Len("BACKGROUND-COLOR:")))
                sTemp = Replace(sTemp, """", "")
                sTemp = Replace(sTemp, " ", "")
                sTemp = Replace(sTemp, "#", "")
                If sTemp <> "" Then
                    'Check if it is already in the table
                    If Not IsArrayEmpty(ColorTable) Then
                        For I = 0 To UBound(ColorTable)
                            If sTemp = ColorTable(I) Then
                                bFound = True
                                Exit For
                            End If
                        Next I
                    Else
                        bFound = False
                    End If
                    'If not found add it
                    If bFound = False Then
                        ReDim Preserve ColorTable(ColorCombNumber)
                        ColorTable(ColorCombNumber) = sTemp
                        ColorCombNumber = ColorCombNumber + 1
                    End If
                    sRTF = sRTF & "\highlight" & GetIndex(ColorTable, sTemp) + 1
                    sTemp = ""
                    bFound = False
                End If
            End If

            'Check for back ground colors
            'AOL specific
            '<FONT COLOR="#0000ff" BACK="#80ff00">
            lTStart = InStr(1, UCase(sToken), "BACK=")
            If lTStart > 0 Then
                lTEnd = InStr(lTStart + Len("BACK="), sToken, " ")
                If lTEnd = 0 Then
                    lTEnd = InStr(lTStart + Len("BACK="), sToken, ">")
                End If
                sTemp = Mid(sToken, lTStart + Len("BACK="), lTEnd - (lTStart + Len("BACK=")))
                sTemp = Replace(sTemp, """", "")
                sTemp = Replace(sTemp, " ", "")
                sTemp = Replace(sTemp, "#", "")
                If sTemp <> "" Then
                    'Check if it is already in the table
                    If Not IsArrayEmpty(ColorTable) Then
                        For I = 0 To UBound(ColorTable)
                            If sTemp = ColorTable(I) Then
                                bFound = True
                                Exit For
                            End If
                        Next I
                    Else
                        bFound = False
                    End If
                    'If not found add it
                    If bFound = False Then
                        ReDim Preserve ColorTable(ColorCombNumber)
                        ColorTable(ColorCombNumber) = sTemp
                        ColorCombNumber = ColorCombNumber + 1
                    End If
                    sRTF = sRTF & "\highlight" & GetIndex(ColorTable, sTemp) + 1
                    sTemp = ""
                    bFound = False
                End If
            End If

            'Check for back ground colors
            '<BODY BGCOLOR="#ffffff">
            lTStart = InStr(1, UCase(sToken), "BGCOLOR=")
            If lTStart > 0 Then
                lTEnd = InStr(lTStart + Len("BGCOLOR="), sToken, " ")
                If lTEnd = 0 Then
                    lTEnd = InStr(lTStart + Len("BGCOLOR="), sToken, ">")
                End If
                sTemp = Mid(sToken, lTStart + Len("BGCOLOR="), lTEnd - (lTStart + Len("BGCOLOR=")))
                sTemp = Replace(sTemp, """", "")
                sTemp = Replace(sTemp, " ", "")
                sTemp = Replace(sTemp, "#", "")
                If sTemp <> "" Then
                    'Check if it is already in the table
                    If Not IsArrayEmpty(ColorTable) Then
                        For I = 0 To UBound(ColorTable)
                            If sTemp = ColorTable(I) Then
                                bFound = True
                                Exit For
                            End If
                        Next I
                    Else
                        bFound = False
                    End If
                    'If not found add it
                    If bFound = False Then
                        ReDim Preserve ColorTable(ColorCombNumber)
                        ColorTable(ColorCombNumber) = sTemp
                        ColorCombNumber = ColorCombNumber + 1
                    End If
                    sRTF = sRTF & "\highlight" & GetIndex(ColorTable, sTemp) + 1
                    sTemp = ""
                    bFound = False
                End If
            End If

            'check for hyperlink
            '<A href="http://www.microsoft.com">Friendly name</A>

            lTStart = InStr(1, UCase(sToken), "HREF=")
            If lTStart > 0 Then
                lTEnd = InStr(lTStart + Len("HREF=") + 1, sToken, """")
                If lTEnd > 0 Then
                    sTemp = Mid(sToken, lTStart + Len("HREF=") + 1, lTEnd - (lTStart + Len("HREF=") + 1))
                    If sTemp <> "" Then
                        ReDim Preserve gsHyperLink(lHyperLink)
                        'UPGRADE_WARNING: Couldn't resolve default property of object gsHyperLink(lHyperLink). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        gsHyperLink(lHyperLink) = LCase(sTemp)
                        sRTF = sRTF & "\ul1\cf" & GetIndex(ColorTable, "0000ff") + 1 & "<" & LCase(sTemp) & ">\ul0"
                        sTemp = ""
                        bFound = False
                        lHyperLink = lHyperLink + 1
                    End If
                End If
            End If



            '    'check for images
            '    '<IMG align=left alt="" src="file://C:\Documents and Settings\vijayp.CIPLNAGPUR\My Documents\My Pictures\clipart_anim.gif">
            '    lTStart = InStr(1, UCase(sToken), "IMG")
            '    'found a valid image tag
            '    If lTStart > 0 Then
            '        sImage = "\pict"
            '        'Get source
            '        lTStart = InStr(1, UCase(sToken), "SRC=")
            '        If lTStart > 0 Then
            '            lTEnd = InStr(lTStart + Len("SRC="""""), sToken, """")
            '            If lTEnd = 0 Then
            '                'no path specified Error
            '                GoTo ImageFileError
            '            End If
            '        End If
            '        sTemp = Mid(sToken, lTStart + Len("SRC="), lTEnd - (lTStart + Len("SRC=")))
            '        sTemp = Replace(sTemp, """", "")
            '        If sTemp <> "" Then
            '            'Get the file contents
            '            FileContents = GetFileContents(Replace(sTemp, "FILE://", ""))
            '            'Get the format from file extension
            '            sImage = sImage & GetFormatFromExtension(sTemp)
            '        End If
            '
            '        'Get Width
            '        lTStart = InStr(1, UCase(sToken), "WIDTH=")
            '        If lTStart > 0 Then
            '            lTEnd = InStr(lTStart + Len("WIDTH="), sToken, """")
            '            If lTEnd = 0 Then
            '                'no width specified
            '                GoTo CheckHeight
            '            End If
            '        Else
            '            GoTo CheckHeight
            '        End If
            '        sTemp = Mid(sToken, lTStart + Len("WIDTH="), lTEnd - (lTStart + Len("WIDTH=")))
            '        sTemp = Replace(sTemp, """", "")
            '        If sTemp <> "" Then
            '            'got the width
            '            sImage = sImage & "\picw" & sTemp
            '            sTemp = ""
            '        End If
            '        'Check Height
            'CheckHeight:
            '        lTStart = InStr(1, UCase(sToken), "HEIGHT=")
            '        If lTStart > 0 Then
            '            lTEnd = InStr(lTStart + Len("HEIGHT="), sToken, """")
            '            If lTEnd = 0 Then
            '                'no HEIGHT specified
            '                GoTo CheckHeight
            '            End If
            '
            '            sTemp = Mid(sToken, lTStart + Len("HEIGHT="), lTEnd - (lTStart + Len("HEIGHT=")))
            '            sTemp = Replace(sTemp, """", "")
            '            If sTemp <> "" Then
            '                'got the HEIGHT
            '                sImage = sImage & "\pich" & sTemp
            '                sTemp = ""
            '            End If
            '        End If
            '
            '        'Append to RTF
            '        sImage = sImage & vbCrLf & FileContents
            '        sRTF = sRTF & sImage & "}"
            '    End If
            '
            'ImageFileError:

            'Get the text
            lStart = InStr(lEnd, sHTML, ">")
            If lStart = 0 Then GoTo Completed
            lEnd = InStr(lStart, sHTML, "<")
            If lEnd = 0 Then GoTo Completed
            sText = Trim(Mid(sHTML, lStart, lEnd - lStart + 1))
            If Len(sText) > 2 Then
                sText = Mid(sText, 2, Len(sText) - 2)
                'check out for special characters
                sText = Replace(sText, "\", "\\")
                sText = Replace(sText, "{", "\{")
                sText = Replace(sText, "}", "\}")

                If bFaceFound = False And bUseDefaultFace Then
                    sTemp = CStr(GetIndex(FontTable, DefaultFace)) 'PreviousFontFace)
                    If CShort(sTemp) < 0 Then
                        sRTF = sRTF & "\f0"
                    Else
                        sRTF = sRTF & "\f" & sTemp
                    End If
                    sTemp = ""
                End If
                sRTF = sRTF & "\fs" & PreviousFontSize & " " & sText
                'Debug.Print sText
            End If

        Next lCurrentToken

Completed:

        'Generate Font Table
        sFontTable = "\deff0{\fonttbl"
        If Not IsArrayEmpty(FontTable) Then
            For I = 0 To UBound(FontTable)
                sFontTable = sFontTable & "{\f" & I & "\fnil\fcharset0 " & FontTable(I) & ";}"
            Next I
            sFontTable = sFontTable & "}"
        Else
            sFontTable = sFontTable & "{\f0\froman\fcharset0 Times New Roman;}}"
            ReDim FontTable(0)
            FontTable(0) = "Times New Roman"
            'FontTable(0).SIZE = "18"
        End If

        'Generate Color Table
        sColorTable = "{\colortbl ;"
        If Not IsArrayEmpty(ColorTable) Then
            For I = 0 To UBound(ColorTable)
                sColorTable = sColorTable & "\red" & GetRed(ColorTable(I)) & "\green" & GetGreen(ColorTable(I)) & "\blue" & GetBlue(ColorTable(I)) & ";"
            Next I
            sColorTable = sColorTable & "}"
        Else

        End If
        'Generate head
        sHead = "{\rtf1\ansi" & sFontTable & vbCrLf & sColorTable
        sHead = sHead & vbCrLf & "\pard\plain\tx0"

        HTMLtoRTF = sHead & sRTF & "}"
        Exit Function
Error_Renamed:
        HTMLtoRTF = ""
    End Function

    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:45:59 AM
    'OutPut : Red part of color code in decimal format
    'input  : color code in Hex format
    '************************************************************************
    Public Function GetRed(ByRef HexString As String) As Short
        On Error Resume Next
        Dim sTemp As String
        sTemp = Mid(HexString, 1, 2)
        GetRed = CDec("&H" & sTemp)
    End Function

    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:45:59 AM
    'OutPut : Green color code in decimal format
    'input  : color code in Hex format
    '************************************************************************
    Public Function GetGreen(ByRef HexString As String) As Short
        On Error Resume Next
        Dim sTemp As String
        sTemp = Mid(HexString, 3, 2)
        GetGreen = CDec("&H" & sTemp)
    End Function

    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:45:59 AM
    'OutPut : Blue part of color code in decimal format
    'input  : color code in Hex format
    '************************************************************************
    Public Function GetBlue(ByRef HexString As String) As Short
        On Error Resume Next
        Dim sTemp As String
        sTemp = Mid(HexString, 5, 2)
        GetBlue = CDec("&H" & sTemp)
    End Function

    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:45:59 AM
    'OutPut :the index at which the specified item is located in the table
    'Input : Table (array) and the item to find
    '************************************************************************
    Public Function GetIndex(ByRef Table() As String, ByRef Code As String) As Short
        On Error Resume Next
        Dim I As Short
        Dim bFound As Boolean
        'Get the index
        If Not IsArrayEmpty(Table) Then
            For I = 0 To UBound(Table)
                If Code = Table(I) Then
                    bFound = True
                    Exit For
                End If
            Next I
        Else
            bFound = False
        End If
        'return it
        If bFound = False Then
            GetIndex = 0
        Else
            GetIndex = I
        End If

    End Function


    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 7:45:59 AM
    'OutPut :the Actual font size for RTF format
    'input : font size as specified in HTML
    '************************************************************************
    Public Function GetFontSize(ByRef sSize As String) As String
        On Error Resume Next
        Select Case sSize
            Case "1"
                GetFontSize = "15" '"7.5"
            Case "2"
                GetFontSize = "20" '"10"
            Case "3"
                GetFontSize = "24" '"12"
            Case "4"
                GetFontSize = "27" '"13.5"
            Case "5"
                GetFontSize = "36" '"18"
            Case "6"
                GetFontSize = "48" '"24"
            Case "7"
                GetFontSize = "72" '"36"
            Case Else
                GetFontSize = CStr(System.Math.Round(Val(sSize), 1) * 2)
        End Select
    End Function

    ''************************************************************************
    ''Author            :   Vijay Phulwadhawa     Date    : 9/4/2001 12:23:53 PM
    ''Returns the RTF control word for a particular image file
    ''Input extension of the image file
    ''************************************************************************
    'Public Function GetFormatFromExtension(sFileName As String) As String
    'On Error Resume Next
    'Dim sTemp As String
    'Dim sExt As String
    '    sTemp = GetFile(sFileName)
    '    sExt = VBA.Right(sTemp, 3)
    '    Select Case LCase(sExt)
    '        Case "ext"
    '            GetFormatFromExtension = "\emfblip"
    '        Case "gif"
    '            GetFormatFromExtension = "\wmetafile8"
    '        Case "png"
    '            GetFormatFromExtension = "\pngblip"
    '        Case "jpg", "jpeg"
    '            GetFormatFromExtension = "\jpegblip"
    '        Case "wmf"
    '            GetFormatFromExtension = "\wmetafile1"
    '        Case "dib"
    '            GetFormatFromExtension = "\dibitmap0"
    '        Case "bmp"
    '            GetFormatFromExtension = "\wbitmap0"
    '    End Select
    'End Function


    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 8/25/2001 8:20:28 AM
    ' Determines whether an array contains any elements.
    ' Returns False if it does contain elements, True if it does not.
    '************************************************************************
    Public Function IsArrayEmpty(ByRef aArray As Object) As Boolean
        On Error Resume Next
        Dim lngUBound As Integer
        ' If the array is empty, an error occurs when you  check the array's bounds.
        lngUBound = UBound(aArray)
        If Err.Number <> 0 Then
            IsArrayEmpty = True
        Else
            IsArrayEmpty = False
        End If
    End Function

    '************************************************************************
    'Author            :   Vijay Phulwadhawa     Date    : 8/31/2001 8:15:06 AM
    'Returns the content of a file
    '************************************************************************
    Public Function GetFileContents(ByRef sFileName As String) As String
        On Error Resume Next
        Dim fp As Short
        Dim sBuf As String
        fp = FreeFile
        FileOpen(fp, sFileName, OpenMode.Binary, OpenAccess.Read)
        sBuf = Space(FileLen(sFileName))
        'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        FileGet(fp, sBuf, 1)
        GetFileContents = sBuf
        FileClose(fp)
    End Function


    '<TABLE cellSpacing=1 cellPadding=1 width="75%" border=1>
    '  <TR><TD>1,1</TD><TD>1,2</TD><TD>1,3</TD></TR>
    '  <TR><TD>2,1</TD><TD>2,2</TD><TD>2,3</TD></TR>
    '  <TR><TD>3,1</TD><TD>3,2</TD><TD>3,3</TD></TR>
    '</TABLE>
    Private Function GetTableStructure(ByVal sHTML As String, ByRef lPos As Integer) As String
        Dim sToken, sDummy As String
        Dim lStart, lEnd As Integer
        Dim iCellPadding, iBorder, iCellSpacing, iWidth As Short
        Dim iDummyStart, iDummyEnd As Short
        Dim iColCount, iRowCount As Short
        Dim sRTFTableStruct As String
        Dim iCellWidth As Short

        lStart = lPos
        lEnd = lPos
        lStart = InStr(lEnd, sHTML, "<")
        If lStart = 0 Then GoTo Completed
        lEnd = InStr(lStart, sHTML, ">")
        sToken = UCase(Mid(sHTML, lStart, lEnd - lStart + 1))
        'get the cell properties
        'CELLSPACING
        iDummyStart = InStr(6, sToken, "CELLSPACING")
        If iDummyStart <> 0 Then
            iDummyEnd = InStr(iDummyStart + Len("CELLSPACING") + 1, sToken, " ")
            If iDummyEnd = 0 Then iDummyEnd = InStr(iDummyStart + Len("CELLSPACING") + 1, sToken, ">")
            iCellSpacing = CShort(Mid(sToken, iDummyStart + Len("CELLSPACING") + 1, iDummyEnd - (iDummyStart + Len("CELLSPACING") + 1)))
        End If
        'CELLPADDING
        iDummyStart = InStr(6, sToken, "CELLPADDING")
        If iDummyStart <> 0 Then
            iDummyEnd = InStr(iDummyStart + Len("CELLPADDING") + 1, sToken, " ")
            If iDummyEnd = 0 Then iDummyEnd = InStr(iDummyStart + Len("CELLPADDING") + 1, sToken, ">")
            iCellPadding = CShort(Mid(sToken, iDummyStart + Len("CELLPADDING") + 1, iDummyEnd - (iDummyStart + Len("CELLPADDING") + 1)))
        End If
        'WIDTH
        iDummyStart = InStr(6, sToken, "WIDTH")
        If iDummyStart <> 0 Then
            iDummyEnd = InStr(iDummyStart + Len("WIDTH") + 1, sToken, " ")
            If iDummyEnd = 0 Then iDummyEnd = InStr(iDummyStart + Len("WIDTH") + 1, sToken, ">")
            iWidth = Val(Replace(Mid(sToken, iDummyStart + Len("WIDTH") + 1, iDummyEnd - (iDummyStart + Len("WIDTH") + 1)), """", ""))
        End If
        'BORDER
        iDummyStart = InStr(6, sToken, "BORDER")
        If iDummyStart <> 0 Then
            iDummyEnd = InStr(iDummyStart + Len("BORDER") + 1, sToken, " ")
            If iDummyEnd = 0 Then iDummyEnd = InStr(iDummyStart + Len("BORDER") + 1, sToken, ">")
            iBorder = CShort(Mid(sToken, iDummyStart + Len("BORDER") + 1, iDummyEnd - (iDummyStart + Len("BORDER") + 1)))
        End If

        iDummyEnd = InStr(lPos, sHTML, "</TABLE>")
        If iDummyEnd <> 0 Then iDummyEnd = iDummyEnd + Len("</TABLE>")
        sDummy = Mid(sHTML, lPos, iDummyEnd - lPos)
        'Get the row and col count for the table
        iRowCount = GetRowCount(sDummy)
        iColCount = GetColCount(sDummy) / iRowCount

        sRTFTableStruct = "\trowd\trgaph108\trleft-108"
        sRTFTableStruct = sRTFTableStruct & "\trbrdrt\brdrs\brdrw" & iBorder & " "
        sRTFTableStruct = sRTFTableStruct & "\trbrdrl\brdrs\brdrw" & iBorder & " "
        sRTFTableStruct = sRTFTableStruct & "\trbrdrb\brdrs\brdrw" & iBorder & " "
        sRTFTableStruct = sRTFTableStruct & "\trbrdrr\brdrs\brdrw" & iBorder & " "

        iCellWidth = 2952
        iDummyEnd = 0
        For iDummyStart = 1 To iColCount
            iDummyEnd = iDummyEnd + iCellWidth
            sRTFTableStruct = sRTFTableStruct & "\clbrdrt\brdrw15\brdrs\clbrdrl\brdrw15\brdrs\clbrdrb\brdrw15\brdrs\clbrdrr\brdrw15\brdrs"
            sRTFTableStruct = sRTFTableStruct & "\cellx" & CStr(iDummyEnd)

        Next

        sRTFTableStruct = sRTFTableStruct & "\pard"


        '    Do While sToken <> "</TABLE>"
        '
        '        lStart = InStr(lEnd, sHTML, "<")
        '        If lStart = 0 Then GoTo Completed
        '        lEnd = InStr(lStart, sHTML, ">")
        '        sToken = UCase(Mid(sHTML, lStart, lEnd - lStart + 1))
        '
        '        '\intbl\f0\fs24 1,1\cell 1,2\cell 1,3\cell\row
        '        '\intbl 2,1\cell 2,2\cell 2,3\cell\row
        '        '\intbl 3,1\cell 3,2\cell 3,3\cell\row
        '
        '    Loop

        iDummyEnd = InStr(lPos, sHTML, "</TABLE>")
        If iDummyEnd <> 0 Then iDummyEnd = iDummyEnd + Len("</TABLE>")

        lPos = iDummyEnd
        GetTableStructure = sRTFTableStruct

Completed:
    End Function

    Private Function GetColCount(ByVal sToken As String) As Short
        Dim sTemp As String
        Dim lStart As Integer
        Dim iPos, iCount As Short

        lStart = 1
        iPos = InStr(lStart, sToken, "<TD>")

        Do While iPos <> 0
            iCount = iCount + 1
            lStart = iPos + Len("<TD>")
            iPos = InStr(lStart, sToken, "<TD>")
        Loop

        GetColCount = iCount
    End Function

    Private Function GetRowCount(ByVal sToken As String) As Short
        Dim sTemp As String
        Dim lStart As Integer
        Dim iPos, iCount As Short

        lStart = 1

        iPos = InStr(lStart, sToken, "<TR>")

        Do While iPos <> 0
            iCount = iCount + 1
            lStart = iPos + Len("<TR>")
            iPos = InStr(lStart, sToken, "<TR>")
        Loop

        GetRowCount = iCount
    End Function
End Module