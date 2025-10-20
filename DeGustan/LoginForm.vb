Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        If username = "" Or password = "" Then
            MsgBox("Por favor, complete usuario y contraseña.")
            Return
        End If
        Try
            conexion.Open()
            Dim query As String = "SELECT u.*, r.nombre AS rol_nombre FROM usuarios u JOIN roles r ON u.rol_id = r.id WHERE u.username = @username AND u.password = @password AND u.activo = 1"
            Dim cmd As New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            'MsgBox(query)
            If reader.Read() Then
                Dim idUser As Integer = Convert.ToInt32(reader("id"))
                Dim rol As String = reader("rol_nombre").ToString()
                ' Guardar usuario y rol en variables globales
                UsuarioActual.Id = idUser
                UsuarioActual.Nombre = reader("nombre").ToString().Trim()
                UsuarioActual.Rol = rol.Trim()
                UsuarioActual.IsLoggedIn = True
                Me.Hide()
                Dim principalForm As New Principal()
                principalForm.Show()
            Else
                MsgBox("Usuario o contraseña incorrectos, o usuario inactivo.")
            End If
            reader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar conexión si no lo está
        Try
            Conectar()
        Catch
        End Try

        ' Ajustar el tamaño del formulario para que el pnlContent quepa correctamente
        Try
            Dim marginLeft As Integer = Math.Max(20, pnlContent.Left)
            Dim marginTop As Integer = Math.Max(20, pnlContent.Top)
            Dim desiredWidth As Integer = marginLeft * 2 + pnlContent.Width
            Dim desiredHeight As Integer = marginTop + pnlContent.Height + 40 ' espacio inferior

            ' Aplicar tamaño mínimo
            If Me.MinimumSize.Width > 0 Then
                desiredWidth = Math.Max(desiredWidth, Me.MinimumSize.Width)
            End If
            If Me.MinimumSize.Height > 0 Then
                desiredHeight = Math.Max(desiredHeight, Me.MinimumSize.Height)
            End If

            Me.ClientSize = New Size(desiredWidth, desiredHeight)

            ' Centrar pnlContent horizontalmente
            pnlContent.Left = (Me.ClientSize.Width - pnlContent.Width) \ 2
            ' Mantener top como estaba (o centrar verticalmente si prefieres)
            ' pnlContent.Top = (Me.ClientSize.Height - pnlContent.Height) \ 2
        Catch
        End Try
    End Sub
End Class

' Clase para guardar datos del usuario logueado
Public Module UsuarioActual
    Public Id As Integer = 0
    Public Nombre As String = ""
    Public Rol As String = ""
    Public IsLoggedIn As Boolean = False
    ' Mantener estado del sidebar durante la sesión
    Public SidebarExpanded As Boolean = True

    Public Function HasRole(expected As String) As Boolean
        If String.IsNullOrEmpty(Rol) Then Return False
        Return String.Equals(Rol.Trim(), expected.Trim(), StringComparison.CurrentCultureIgnoreCase)
    End Function

    Public Function HasAnyRole(ParamArray expected() As String) As Boolean
        If String.IsNullOrEmpty(Rol) Then Return False
        For Each r In expected
            If HasRole(r) Then Return True
        Next
        Return False
    End Function
End Module
''''''''
