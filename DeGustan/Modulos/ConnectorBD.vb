Imports MySql.Data.MySqlClient
Module ConnectorBD
    Friend conexion As MySqlConnection


    Sub Conectar()
        ' Uso el try para controlar errores

        Try
            ' Genero conexion nueva
            conexion = New MySqlConnection
            Dim cadena As String

            Dim ruta As String = My.Application.Info.DirectoryPath & "\coneccionbd.txt"

            If System.IO.File.Exists(ruta) Then
                cadena = My.Computer.FileSystem.ReadAllText(ruta)
            Else
                MsgBox("El archivo coneccionbd.txt no se encuentra en la carpeta de la aplicación.")
                Exit Sub
            End If

            'cadena = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\dataConnect.txt")

            ' Configuro la propiedad de conexion
            conexion.ConnectionString = cadena


        Catch ex As Exception
            ' Obtengo el error generado
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
