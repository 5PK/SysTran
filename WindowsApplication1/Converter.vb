Public Class Converter

#Region " Constructor "

    Public Sub New(ByVal amount As Long, ByVal style As ConvertStyle)
        m_amount = amount
        m_style = style
    End Sub

#End Region


#Region " Public Methods"

    Public Function Convert() As String

        Dim convertedString As String = String.Empty

        Select Case Me.Style

            Case ConvertStyle.English
                convertedString = Me.EnglishStyle

            Case ConvertStyle.Asian
                convertedString = Me.AsianStyle

        End Select

        Return convertedString
    End Function

#End Region


#Region " Private Methods"


#Region " English Style "


    Private Function EnglishStyle()
        If Amount = 0 Then Return "Zero" 'Unique and exceptional case
        'Overflow exception will occur when 18+ digits are passed as
        'Long can handle upto 18 digits but the routine below can convert upto 24 digits


        Dim amountString As String = Amount.ToString
        Dim result As String = String.Empty
        Dim tempResult As String = String.Empty
        Dim i As Integer = 3
        Dim newAmount As String = amountString
        Dim workedStringLength As Integer = 0

        Dim concatHigherDigitString As Boolean

        Do
            concatHigherDigitString = False
            If i > 3 Then concatHigherDigitString = True 'to suffix the Thousand/Million/Billion type of Word


            If newAmount.Length >= 4 Then   'work with 3 right most digits at a time
                newAmount = amountString.Substring(amountString.Length - i, 3)
            End If


            'do the conversion and affist the Thousand/Million/Billion type of word at the end when needed
            If concatHigherDigitString AndAlso CInt(newAmount) <> 0 Then
                result = ThreeDigitsConverter(CInt(newAmount)) & " " & HigherDigitEnglishStringArray(i / 3 + 1) & " " & result
            Else
                result = ThreeDigitsConverter(CInt(newAmount))
            End If


            workedStringLength += newAmount.Length
            newAmount = amountString.Substring(0, amountString.Length - workedStringLength)
            i += 3
        Loop Until amountString.Length <= workedStringLength

        Return RemoveSpaces(result)

    End Function


    Private Function ThreeDigitsConverter(ByVal amount As Integer) As String
        Dim amountString As String = amount.ToString

        'convert numbers to array of each digit
        Dim amountArray(amountString.Length - 1) As Integer
        For i As Integer = amountArray.Length To 1 Step -1
            amountArray(i - 1) = amountString.Substring(i - 1, 1)
        Next

        Dim j As Integer = 0
        Dim digit As Integer = 0
        Dim result As String = String.Empty
        Dim separator As String = String.Empty
        Dim higherDigitEnglishString As String = String.Empty
        Dim codeIndex As String = String.Empty


        For i As Integer = amountArray.Length To 1 Step -1
            j = amountArray.Length - i
            digit = amountArray(j)

            codeIndex = EnglishCodeArray(i - 1)
            higherDigitEnglishString = HigherDigitEnglishStringArray(CInt(codeIndex.Substring(0, 1)) - 1)


            If codeIndex = "1" Then 'Number [1 9]
                result = result & separator & SingleDigitStringArray(digit)

            ElseIf codeIndex.Length = 2 And digit <> 0 Then 'Number in tenth place and skip if digit is 0

                If digit = 1 Then   'Number [Eleven, Twelve,...., Nineteen]
                    Dim suffixDigit As Integer = amountArray(j + 1)
                    result = result & separator & TenthDigitStringArray(suffixDigit) & " " & higherDigitEnglishString
                    i -= 1  'Skip the next round as we already looked at it

                Else    'Number [tenth] and [20+]  
                    result = result & separator & DoubleDigitsStringArray(digit) & " " & higherDigitEnglishString
                End If

            ElseIf digit <> 0 Then  'Standard Number like 100, 1000, 1000000 and skip if digit is 0
                result = result & separator & SingleDigitStringArray(digit) & " " & higherDigitEnglishString
            End If

            separator = " "
        Next

        Return result
    End Function

#End Region

#Region " Asian Style "

    Private Function AsianStyle()
        Dim amountString As String = Amount.ToString

        If Amount = 0 Then Return "Zero" 'Unique and exceptional case
        If amountString.Length > 13 Then Return "That's too long..."

        Dim amountArray(amountString.Length - 1) As Integer
        For i As Integer = amountArray.Length To 1 Step -1
            amountArray(i - 1) = amountString.Substring(i - 1, 1)
        Next


        Dim j As Integer = 0
        Dim digit As Integer = 0
        Dim result As String = ""
        Dim separator As String = ""
        Dim higherDigitAsianString As String = ""
        Dim codeIndex As String = ""


        For i As Integer = amountArray.Length To 1 Step -1
            j = amountArray.Length - i
            digit = amountArray(j)

            codeIndex = AsianCodeArray(i - 1)
            higherDigitAsianString = HigherDigitAsianStringArray(CInt(codeIndex.Substring(0, 1)) - 1)


            If codeIndex = "1" Then 'Number [1, 9]
                result = result & separator & SingleDigitStringArray(digit)

            ElseIf codeIndex.Length = 2 And digit <> 0 Then 'Number in tenth place and skip if digit is 0
                Dim suffixDigit As Integer = amountArray(j + 1)

                If digit = 1 Then   'Number [Eleven, Twelve,...., Nineteen]
                    result = result & separator & TenthDigitStringArray(suffixDigit) & " " & higherDigitAsianString
                    i -= 1 'Skip the next round as we already looked at it

                Else    'Number [tenth] and [20+]  
                    If suffixDigit = 0 Then 'Numbers like [20 30 40...90]
                        result = result & separator & DoubleDigitsStringArray(digit) & " " & higherDigitAsianString
                    Else
                        result = result & separator & DoubleDigitsStringArray(digit)
                    End If

                End If

            ElseIf digit <> 0 Then  'Standard Number like 100, 1000, 1000000 and skip if digit is 0
                result = result & separator & SingleDigitStringArray(digit) & " " & higherDigitAsianString
            End If

            separator = " "
        Next



        Return RemoveSpaces(result)
    End Function

#End Region


    Private Function RemoveSpaces(ByVal word As String) As String
        Dim regEx As New System.Text.RegularExpressions.Regex("  ")
        Return regEx.Replace(word, " ").Trim
    End Function

#End Region


#Region " Property"

    Public ReadOnly Property Amount As Long
        Get
            Return m_amount
        End Get
    End Property

    Public ReadOnly Property Style As ConvertStyle
        Get
            Return m_style
        End Get
    End Property
#End Region


#Region " Fields"

    Private m_amount As Long
    Private m_style As ConvertStyle

    Private SingleDigitStringArray() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"}
    Private DoubleDigitsStringArray() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
    Private TenthDigitStringArray() As String = {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}

    Private HigherDigitEnglishStringArray() As String = {"", "", "Hundred", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}
    Private HigherDigitAsianStringArray() As String = {"", "", "Hundred", "Thousand", "Lakh", "Karod", "Arab", "Kharab"}

    Private EnglishCodeArray() As String = {"1", "22", "3"}
    Private AsianCodeArray() As String = {"1", "22", "3", "4", "42", "5", "52", "6", "62", "7", "72", "8", "82"}

#End Region


#Region " Enums"

    Public Enum ConvertStyle
        Asian
        English
    End Enum

#End Region

End Class