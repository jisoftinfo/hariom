
Public Module Number_to_Word

    Dim Words As String
    Dim getw As String
    Dim num As Integer
    Function numtoword(ByVal num As String) As String
        If Val(num) <> 0 Then
            numtoword = ConvertNumerToWords(num) & " ONLY"

        Else
            numtoword = "ZERO"
        End If
    End Function

    Private Function GetDivideby(ByVal len1 As Byte) As Long
        Select Case len1
            Case 1, 2 : GetDivideby = 1
            Case 3, 3 : GetDivideby = 100 : getw = " HUNDRED"
            Case 4, 5 : GetDivideby = 1000 : getw = " THOUSAND"
            Case 6, 7 : GetDivideby = 100000 : getw = " LAKH"
            Case 8, 9 : GetDivideby = 10000000 : getw = " CRORE"
        End Select
    End Function

    Private Function ConvertNumerToWords(ByVal NumberToConvert As String) As String
        On Error Resume Next
        Dim divideby As Long, Remainder As Long, Quotient As Long, dividend As Long
        Dim Quotient1 As String, Remainder1 As String, textcontent() As String

        textcontent = Split(NumberToConvert, ".")
        Remainder = Val(textcontent(0))
        Remainder1 = Remainder
        Do While Val(Remainder1) > 0
            dividend = Remainder
            divideby = GetDivideby(Len(Remainder1))

            Quotient = dividend \ divideby
            Quotient1 = Quotient

            wordings(Quotient1)

            Words = Words & getw
            getw = ""
            Remainder = dividend Mod divideby
            Remainder1 = Remainder
        Loop

        If UBound(textcontent) = 1 Then
            If Len(textcontent(1)) = 1 Then
                Words = Words & " RUPEES AND" & Getsinglenumber(Val(textcontent(1))) & " PAISE"
            ElseIf Len(textcontent(1)) = 2 Then
                Words = Words & " RUPEES AND" & Getty(Left(textcontent(1), 1))
                Words = Words & Getsinglenumber(Right(textcontent(1), 1)) & " PAISE"
            End If
        End If

        ConvertNumerToWords = Words
        Words = ""
    End Function

    Private Function wordings(ByVal common As String) As String
        If Val(common) < 20 Then
            Words = Words & Getsinglenumber(Val(common))
        Else
            Words = Words & Getty(Left(common, 1))
            Words = Words & Getsinglenumber(Right(common, 1))
        End If
        Return Words
    End Function

    Private Function Getsinglenumber(ByVal number As Long) As String
        Dim Str As String = ""
        Select Case number
            Case 1 : Str = " ONE"
            Case 2 : Str = " TWO"
            Case 3 : Str = " THREE"
            Case 4 : Str = " FOUR"
            Case 5 : Str = " FIVE"
            Case 6 : Str = " SIX"
            Case 7 : Str = " SEVEN"
            Case 8 : Str = " EIGHT"
            Case 9 : Str = " NINE"
            Case 10 : Str = " TEN"
            Case 11 : Str = " ELEVEN"
            Case 12 : Str = " TWELVE"
            Case 13 : Str = " THIRTEEN"
            Case 14 : Str = " FOURTEEN"
            Case 15 : Str = " FIFTEEN"
            Case 16 : Str = " SIXTEEN"
            Case 17 : Str = " SEVENTEEN"
            Case 18 : Str = " EIGHTEEN"
            Case 19 : Str = " NINETEEN"
        End Select
        Return Str
    End Function

    Private Function Getty(ByVal number As Long) As String
        Dim Str As String = ""
        Select Case number
            Case 2 : Str = " TWENTY"
            Case 3 : Str = " THIRTY"
            Case 4 : Str = " FORTY"
            Case 5 : Str = " FIFTY"
            Case 6 : Str = " SIXTY"
            Case 7 : Str = " SEVENTY"
            Case 8 : Str = " EIGHTY"
            Case 9 : Str = " NINTY"
        End Select
        Return Str
    End Function


End Module
