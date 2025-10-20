Imports MySql.Data.MySqlClient
Public Class proveedores

    Private Sub ClearForm()
        tbName.Text = ""
        tbPhone.Text = ""
        tbAddress.Text = ""
        tbEmail.Text = ""
        tbCuit.Text = ""
        cmbActive.SelectedIndex = 0
        tbNameQuery.Text = ""
        tbCuitQuery.Text = ""
        tbName.Focus()
    End Sub

    Private Sub cargarProveedor(order As String)
        Try
            conexion.Open()
            Dim query = "SELECT * FROM proveedores order by @order"
            Dim cmd As New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@order", order)

            Dim reader = cmd.ExecuteReader

            If reader.HasRows Then
                lvDataGridSup.Items.Clear()

                Dim lvItem As New ListViewItem

                Do While reader.Read()
                    lvItem = lvDataGridSup.Items.Add(reader("id"))
                    lvItem.SubItems.Add(reader("nombre"))
                    lvItem.SubItems.Add(reader("cuit"))
                    lvItem.SubItems.Add(reader("email"))
                    lvItem.SubItems.Add(reader("telefono"))
                    lvItem.SubItems.Add(reader("direccion"))
                    lvItem.SubItems.Add(If(reader("activo") = True, "Si", "No"))
                    lvItem.SubItems.Add(reader("created_at"))
                    lvItem.SubItems.Add(reader("update_at"))
                Loop

            End If

            reader.Close()
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AjustarColumnas()
        ' Verificamos que haya columnas
        If lvDataGridSup.Columns.Count = 0 Then Exit Sub

        ' Defino la columna excluida
        Dim colExcluded As Integer = 0 ' Valor del indice de la columna a excluir
        lvDataGridSup.Columns(colExcluded).Width = 0 ' Le doy un ancho de 0 para ocultarla

        ' Obtenemos el ancho total del ListView
        Dim anchoTotal As Integer = lvDataGridSup.ClientSize.Width
        Dim anchoRest As Integer = anchoTotal - lvDataGridSup.Columns(colExcluded).Width

        ' Calculo cuantas columnas quedan para ajustar
        Dim numColsAjustar As Integer = lvDataGridSup.Columns.Count - 1

        If numColsAjustar <= 0 Then Exit Sub

        ' Calculamos el ancho de cada columna
        Dim anchoColumna As Integer = anchoTotal \ numColsAjustar

        ' Ajustamos cada columna
        For i As Integer = 0 To lvDataGridSup.Columns.Count - 1
            If i <> colExcluded Then
                lvDataGridSup.Columns(i).Width = anchoColumna
            End If
        Next
    End Sub

    Private Sub CargarSugerencias(ByVal buscar As String)
        ' sub rutina para cargar las sugerencias en los textbox de búsqueda
        If buscar = "" Then
            lvDataGridSup.Items.Clear()
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim query As String = "SELECT * FROM proveedores WHERE (@nombre IS NULL OR nombre LIKE @nombre) AND (@cuit IS NULL OR cuit LIKE @cuit)"
            Dim cmd As New MySqlCommand(query, conexion)

            ' Validar por cuál valor se buscará
            If String.IsNullOrEmpty(tbNameQuery.Text) Then     ' Si el nombre está vacío devuelvo NULL, buscar solo por CUIT
                cmd.Parameters.AddWithValue("@nombre", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@nombre", "%" & buscar & "%")
            End If

            If String.IsNullOrEmpty(tbCuitQuery.Text) Then     ' Si el CUIT está vacío devuelvo NULL, buscar solo por nombre
                cmd.Parameters.AddWithValue("@cuit", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@cuit", "%" & buscar & "%")
            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                lvDataGridSup.Items.Clear()
                Dim lvItem As New ListViewItem
                Do While reader.Read()
                    lvItem = lvDataGridSup.Items.Add(reader("id"))
                    lvItem.SubItems.Add(reader("nombre"))
                    lvItem.SubItems.Add(reader("cuit"))
                    lvItem.SubItems.Add(reader("email"))
                    lvItem.SubItems.Add(reader("telefono"))
                    lvItem.SubItems.Add(reader("direccion"))
                    lvItem.SubItems.Add(If(reader("activo") = True, "Si", "No"))
                    lvItem.SubItems.Add(reader("created_at"))
                    lvItem.SubItems.Add(reader("update_at"))
                Loop
            Else
                MsgBox("No se encontraron proveedores que coincidan con los criterios de búsqueda.", vbInformation, "Búsqueda")
                cargarProveedor("id")
            End If

            reader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al buscar proveedores: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()

        ' Configurar el ComboBox de estado
        cmbActive.Items.Add("Activo")
        cmbActive.Items.Add("Inactivo")
        cmbActive.SelectedIndex = 0


        cargarProveedor("id")

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearForm()
        cargarProveedor("id")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Validar campos obligatorios: nombre y teléfono
        If tbName.Text = "" Or tbPhone.Text = "" Then
            MsgBox("Debe completar los campos obligatorios: Nombre y Teléfono", vbExclamation, "Atención")
            Exit Sub
        End If

        Try
            conexion.Open()
            Dim activo As Boolean
            If cmbActive.SelectedIndex = 0 Then
                activo = True
            Else
                activo = False
            End If

            Dim cmd As New MySqlCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO proveedores (nombre, cuit, email, telefono, direccion, activo, created_at, update_at) VALUES (@nombre, @cuit, @email, @telefono, @direccion, @activo, NOW(), NOW())"
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@cuit", tbCuit.Text)
            cmd.Parameters.AddWithValue("@email", tbEmail.Text)
            cmd.Parameters.AddWithValue("@telefono", tbPhone.Text)
            cmd.Parameters.AddWithValue("@direccion", tbAddress.Text)
            cmd.Parameters.AddWithValue("@activo", activo)

            cmd.ExecuteNonQuery()

            ClearForm()
            conexion.Close()
            cargarProveedor("id")


        Catch ex As Exception
            MsgBox("Error al agregar el proveedor: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Validar que se haya seleccionado un proveedor
        If lvDataGridSup.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un proveedor para eliminar", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim selectedId As Integer = Convert.ToInt32(lvDataGridSup.SelectedItems(0).Text) ' Obtener el ID del proveedor seleccionado
        ' Confirmar la eliminación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el proveedor seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                conexion.Open()
                Dim cmd As New MySqlCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM proveedores WHERE id = @id"
                cmd.Parameters.AddWithValue("@id", selectedId)
                cmd.ExecuteNonQuery()
                conexion.Close()
                cargarProveedor("id")
            Catch ex As Exception
                MsgBox("Error al eliminar el proveedor: " & ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub lvDataGridSup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDataGridSup.SelectedIndexChanged
        ' Rellenar los campos del formulario con los datos del proveedor seleccionado

        tbName.Text = lvDataGridSup.Items(lvDataGridSup.FocusedItem.Index).SubItems(1).Text
        tbCuit.Text = lvDataGridSup.Items(lvDataGridSup.FocusedItem.Index).SubItems(2).Text
        tbEmail.Text = lvDataGridSup.Items(lvDataGridSup.FocusedItem.Index).SubItems(3).Text
        tbPhone.Text = lvDataGridSup.Items(lvDataGridSup.FocusedItem.Index).SubItems(4).Text
        tbAddress.Text = lvDataGridSup.Items(lvDataGridSup.FocusedItem.Index).SubItems(5).Text
        If lvDataGridSup.Items(lvDataGridSup.FocusedItem.Index).SubItems(6).Text = "Si" Then
            cmbActive.SelectedIndex = 0
        Else
            cmbActive.SelectedIndex = 1
        End If

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If lvDataGridSup.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un proveedor para modificar", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim selectedId As Integer = Convert.ToInt32(lvDataGridSup.SelectedItems(0).Text) ' Obtener el ID del proveedor seleccionado

        Try
            conexion.Open()

            Dim activo As Boolean
            If cmbActive.SelectedIndex = 0 Then
                activo = True
            Else
                activo = False
            End If

            Dim cmd As New MySqlCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE proveedores SET nombre = @nombre, cuit = @cuit, email = @email, telefono = @telefono, direccion = @direccion, activo = @activo, update_at = NOW() WHERE id = @id"
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@cuit", tbCuit.Text)
            cmd.Parameters.AddWithValue("@email", tbEmail.Text)
            cmd.Parameters.AddWithValue("@telefono", tbPhone.Text)
            cmd.Parameters.AddWithValue("@direccion", tbAddress.Text)
            cmd.Parameters.AddWithValue("@activo", activo)
            cmd.Parameters.AddWithValue("@id", selectedId)
            cmd.ExecuteNonQuery()
            conexion.Close()
            ClearForm()
            cargarProveedor("id")
        Catch ex As Exception
            MsgBox("Error al modificar el proveedor: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub


    Private Sub tbNameQuery_TextChanged(sender As Object, e As EventArgs) Handles tbNameQuery.TextChanged
        tbCuitQuery.Text = ""
        tbCuitQuery.Enabled = False
        If tbNameQuery.Text = "" Then
            cargarProveedor("id")
            tbCuitQuery.Enabled = True
        Else
            CargarSugerencias(tbNameQuery.Text)
        End If

    End Sub

    Private Sub proveedores_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AjustarColumnas()
    End Sub

    Private Sub tbCuitQuery_TextChanged(sender As Object, e As EventArgs) Handles tbCuitQuery.TextChanged
        tbNameQuery.Text = ""
        tbNameQuery.Enabled = False

        If tbCuitQuery.Text = "" Then
            cargarProveedor("id")
            tbNameQuery.Enabled = True
        Else
            CargarSugerencias(tbCuitQuery.Text)
        End If


    End Sub
End Class