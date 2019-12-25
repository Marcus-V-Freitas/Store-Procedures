Imports System.IO
Module DataDAO

    Public server As String
    Public user As String
    Public password As String
    Public database As String

    Public Sub PreencherDados()
        If Not File.Exists("connectionString") Then
            Dim write = File.CreateText("connectionString")
            'Dados para possivel backup de em arquivos
        End If

        'Recuperação e preenchimento dos dados da conexao
        Dim read = File.OpenText("connectionString")

        Dim lista As New List(Of String)

        While (read.Peek <> -1)
            lista.Add(read.ReadLine)
        End While

        server = lista(0)
        user = lista(1)
        password = lista(2)
        database = lista(3)

    End Sub
End Module
