    Public Function readlines(path As String) As String()
        Dim yazi As String = System.IO.File.ReadAllText(path)
        Dim yazii As String = ""
        Dim tobereturned As String() = {"lines"}
        For i As Integer = 0 To yazi.Length - 1 Step +0
            If Not yazi(i) = Convert.ToChar(&HD) Then
                yazii += yazi(i)
            Else
                If Not yazii = "" Then
                    tobereturned = appendstringarray(tobereturned, yazii)
                    yazii = ""
                    i = i + 1
                End If
            End If
                i = i + 1
        Next
        If Not yazi(yazi.Length - 1) = Convert.ToChar(&HA) Then
            tobereturned = appendstringarray(tobereturned, yazii)
        End If
        Return tobereturned
    End Function
    Public Function appendstringarray(fbytes As String(), onebyte As String) As String()
        Dim nfbytes((fbytes.Length - 1) + 1) As String
        For huah As Integer = 0 To nfbytes.Length - 1
            If Not huah > fbytes.Length - 1 Then
                nfbytes(huah) = fbytes(huah)
            Else
                nfbytes(nfbytes.Length - 1) = onebyte
                Exit For
            End If
        Next
        Return nfbytes
    End Function
