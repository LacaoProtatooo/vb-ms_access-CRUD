Imports System.Data.OleDb

Module Module1
    ' Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\dbppl.accdb
    ' G:\TOHOOOO\APP DRAFTS\Visual Basic\vbmsaccess\bin\Debug

    Public connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= G:\TOHOOOO\APP DRAFTS\Visual Basic\vbmsaccess\bin\Debug\dbppl.accdb"

    Public conn As New OleDbConnection(connStr)

    Public aid As String
    Public aname As String
    Public aage As String
    Public aadress As String

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Return True
    End Function

End Module
