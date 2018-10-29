Imports System.Globalization
Imports System.Security.Cryptography

Module Funciones
    Public Function FormatearImporte(ByVal xImporte As Decimal) As String
        If xImporte < 10 Then
            Return String.Format(CultureInfo.InvariantCulture, "{0:0.00}", xImporte)
        Else
            Return String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", xImporte)
        End If
    End Function

    Public Function MD5EncryptPass(ByVal StrPass As String) As String

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strPassOutput As String
        Dim i As Integer
        strPassOutput = ""

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strPassOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return strPassOutput

    End Function
End Module
