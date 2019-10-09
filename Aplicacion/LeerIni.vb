Module LeerIni

    'Funciones de la API de Windows
    Private Declare Function GetPrivateProfileStringKey Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileStringNullKey Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "Kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Object, ByVal lpString As Object, ByVal lpFileName As String) As Long

    Public Function LeerDato(ByVal xCabecera As String, ByVal xDato As String, ByVal sDefault As String, ByVal sRuta As String) As String
        Dim sTemp As String '* 256
        Dim nLength As Integer
        sTemp = Space$(256)
        nLength = GetPrivateProfileStringKey(xCabecera, xDato, sDefault, sTemp, 255, sRuta)
        Return OptimizarINI(Left$(sTemp, nLength))
    End Function

    Private Function OptimizarINI(ByVal Cadena As String) As String
        Cadena = Replace(Cadena, " ", "")
        If InStr(Cadena, ";", CompareMethod.Binary) <> 0 Then
            Cadena = Mid(Cadena, 1, InStr(Cadena, ";", CompareMethod.Binary) - 1)
        End If
        Cadena = Replace(Cadena, ".", ",")
        Return Cadena
    End Function


End Module
