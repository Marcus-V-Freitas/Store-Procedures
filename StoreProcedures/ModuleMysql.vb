Imports MySql.Data.MySqlClient
Module ModuleMysql
    ReadOnly connection As New MySqlConnection($"server={server};user id={user}; Password={password};database={database};allowuservariables=True")


    Sub AbrirConexao()
        connection.Open()
    End Sub

    Function Conexao() As MySqlConnection
        Return connection
    End Function

    Function RetDataTable(ByVal command As MySqlCommand) As DataTable
        Dim data As New DataTable()

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(data)

        Return data

    End Function

    Sub ExecutarComando(ByVal command As MySqlCommand)
        command.ExecuteNonQuery()
    End Sub


    Sub FecharConexao()
        connection.Close()
    End Sub


End Module
