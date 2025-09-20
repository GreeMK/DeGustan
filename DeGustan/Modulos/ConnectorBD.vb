Imports MySql.Data.MySqlClient
Module ConnectorBD
    Friend conexion As MySqlConnection


    Sub Conectar()
        ' Uso el try para controlar errores

        Try
            ' Genero conexion nueva
            conexion = New MySqlConnection

            Dim cadena As String
            cadena = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "/dataConnect.txt")

            ' Configuro la propiedad de conexion
            conexion.ConnectionString = cadena


        Catch ex As Exception
            ' Obtengo el error generado
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
