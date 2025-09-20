Imports MySql.Data.MySqlClient
Public Class proveedores

    Private Sub ClearForm()
        tbName.Text = ""
        tbPhone.Text = ""
        tbAddress.Text = ""
        tbEmail.Text = ""
        tbCuit.Text = ""
        cmbActive.SelectedIndex = 0
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        cmbActive.Items.Add("Activo")
        cmbActive.Items.Add("Inactivo")

        AjustarColumnas()

        cargarProveedor("id")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearForm()
    End Sub
End Class