Imports MySql.Data.MySqlClient
Module ModuleCustomer

    Public Sub Adicionar()
        Dim command As New MySqlCommand("Inserir", Conexao)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("@_nome", MySqlDbType.VarChar).Value = "Marcus"
        command.Parameters.Add("@_endereco", MySqlDbType.VarChar).Value = "Rua Tuim"
        command.Parameters.Add("@_cidade", MySqlDbType.VarChar).Value = "São Paulo"
        command.Parameters.Add("@_estado", MySqlDbType.VarChar).Value = "SP"
        command.Parameters.Add("@_telefone", MySqlDbType.VarChar).Value = "11959121570"

        ExecutarComando(command)

    End Sub

    Public Sub Atualizar()
        Dim command As New MySqlCommand("Atualizar", Conexao)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("@_id", MySqlDbType.Int32).Value = 9
        command.Parameters.Add("@_nome", MySqlDbType.VarChar).Value = "Marcus"
        command.Parameters.Add("@_endereco", MySqlDbType.VarChar).Value = "Rua Tuim 762"
        command.Parameters.Add("@_cidade", MySqlDbType.VarChar).Value = "São Paulo"
        command.Parameters.Add("@_estado", MySqlDbType.VarChar).Value = "SP"
        command.Parameters.Add("@_telefone", MySqlDbType.VarChar).Value = "11959121570"

        ExecutarComando(command)
    End Sub

    Public Sub Procurar()
        Dim command As New MySqlCommand("Procurar", Conexao)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("@_id", MySqlDbType.Int32).Value = 9

        Dim data = RetDataTable(command)

        Console.WriteLine(data.Rows(0)("id").ToString())
        Console.WriteLine(data.Rows(0)("nome").ToString())
        Console.WriteLine(data.Rows(0)("endereco").ToString())
        Console.WriteLine(data.Rows(0)("cidade").ToString())
        Console.WriteLine(data.Rows(0)("estado").ToString())
        Console.WriteLine(data.Rows(0)("telefone").ToString())

    End Sub

    Public Sub Listar()
        Dim command As New MySqlCommand("Listar", Conexao)
        command.CommandType = CommandType.StoredProcedure

        Dim data = RetDataTable(command)

        For i = 0 To data.Rows.Count - 1 Step 1


            Console.WriteLine(data.Rows(i)("id").ToString())
            Console.WriteLine(data.Rows(i)("nome").ToString())
            Console.WriteLine(data.Rows(i)("endereco").ToString())
            Console.WriteLine(data.Rows(i)("cidade").ToString())
            Console.WriteLine(data.Rows(i)("estado").ToString())
            Console.WriteLine(data.Rows(i)("telefone").ToString())

        Next
    End Sub

End Module
