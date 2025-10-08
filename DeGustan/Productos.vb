Imports MySql.Data.MySqlClient
Public Class Productos

    Private Sub AjustarColumnas()
        ' Verificamos que haya columnas
        If lvProducts.Columns.Count = 0 Then Exit Sub

        ' Defino la columna excluida
        Dim colExcluded As Integer = 0 ' Valor del indice de la columna a excluir
        lvProducts.Columns(colExcluded).Width = 0 ' Le doy un ancho de 0 para ocultarla

        ' Obtenemos el ancho total del ListView
        Dim anchoTotal As Integer = lvProducts.ClientSize.Width
        Dim anchoRest As Integer = anchoTotal - lvProducts.Columns(colExcluded).Width

        ' Calculo cuantas columnas quedan para ajustar
        Dim numColsAjustar As Integer = lvProducts.Columns.Count - 1

        If numColsAjustar <= 0 Then Exit Sub

        ' Calculamos el ancho de cada columna
        Dim anchoColumna As Integer = anchoTotal \ numColsAjustar

        ' Ajustamos cada columna
        For i As Integer = 0 To lvProducts.Columns.Count - 1
            If i <> colExcluded Then
                lvProducts.Columns(i).Width = anchoColumna
            End If
        Next
    End Sub

    Sub clearForm()
        tbCodigo.Text = ""
        tbName.Text = ""
        rtbDescription.Text = ""
        cbCategory.SelectedIndex = -1
        cbSupplie.SelectedIndex = -1
        tbSell.Text = ""
        tbBuy.Text = ""
        tbMin.Text = ""
        tbCurrent.Text = ""

        tbQueryProduct.Text = ""
        tbQueryCategory.Text = ""
    End Sub
    Sub cargarCategoria(order As String) ' sub rutina para cargar las categorias en el combobox
        Try
            conexion.Open()

            Dim query = "SELECT nombre, id FROM categorias order by @order"
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@order", order)
            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    cbCategory.Items.Add(reader("nombre").ToString())   ' Añado los nombres de las categorias al combobox
                End While
            End If

            reader.Close()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cargarProveedor(order As String) ' sub rutina para cargar los proveedores en el combobox
        Try
            conexion.Open()

            Dim query = "SELECT nombre FROM proveedores order by @order"
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@order", order)
            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    cbSupplie.Items.Add(reader("nombre").ToString())    ' Añado los nombres de los proveedores al combobox
                End While
            End If

            reader.Close()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cargaGrilla()
        Try
            conexion.Open()

            Dim query = "SELECT 
                            p.id,
                            p.codigo,
                            p.nombre AS producto,
                            p.descripcion,
                            p.precio_compra,
                            p.precio_venta,
                            p.stock_actual,
                            p.stock_minimo,
                            p.activo,
                            c.nombre AS categoria,
                            pr.nombre AS proveedor,
                            p.created_at,
                            p.update_at
                        FROM productos p
                        LEFT JOIN categorias c ON p.categoria_id = c.id
                        LEFT JOIN proveedores pr ON p.proveedor_id = pr.id
                        ORDER BY p.activo desc, p.id ASC;"


            Dim cmd = New MySqlCommand(query, conexion)

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                lvProducts.Items.Clear()
                While reader.Read()
                    Dim item As New ListViewItem(reader("id").ToString())
                    item.SubItems.Add(reader("codigo").ToString())
                    item.SubItems.Add(reader("producto").ToString())
                    item.SubItems.Add(reader("descripcion").ToString())
                    item.SubItems.Add(reader("precio_compra").ToString())
                    item.SubItems.Add(reader("precio_venta").ToString())
                    item.SubItems.Add(reader("stock_actual").ToString())
                    item.SubItems.Add(reader("stock_minimo").ToString())
                    item.SubItems.Add(reader("categoria").ToString())
                    item.SubItems.Add(reader("proveedor").ToString())
                    item.SubItems.Add(reader("created_at").ToString())
                    item.SubItems.Add(reader("update_at").ToString())
                    item.SubItems.Add(If(reader("activo") = True, "Sí", "No"))
                    lvProducts.Items.Add(item)
                End While
            End If

            reader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub busquedaAsistida(ByVal buscar As String)
        If buscar = "" Then
            lvProducts.Items.Clear()
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim query As String = "SELECT 
                                        p.id,
                                        p.codigo,
                                        p.nombre AS producto,
                                        p.descripcion,
                                        p.precio_compra,
                                        p.precio_venta,
                                        p.stock_actual,
                                        p.stock_minimo,
                                        p.activo,
                                        c.nombre AS categoria,
                                        pr.nombre AS proveedor,
                                        p.created_at,
                                        p.update_at
                                    FROM productos p
                                    LEFT JOIN categorias c ON p.categoria_id = c.id
                                    LEFT JOIN proveedores pr ON p.proveedor_id = pr.id
                                    WHERE 
                                        (@nombre IS NULL OR p.nombre LIKE @nombre)
                                        AND (@categoria IS NULL OR c.nombre LIKE @categoria)
                                    ORDER BY p.nombre;"

            Dim cmd As New MySqlCommand(query, conexion)

            If String.IsNullOrWhiteSpace(tbQueryProduct.Text) Then
                cmd.Parameters.AddWithValue("@nombre", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@nombre", "%" & buscar & "%")
            End If

            If String.IsNullOrWhiteSpace(tbQueryCategory.Text) Then
                cmd.Parameters.AddWithValue("@categoria", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@categoria", "%" & buscar & "%")
            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            lvProducts.Items.Clear()

            While reader.Read()
                Dim item As New ListViewItem(reader("id").ToString())
                item.SubItems.Add(reader("codigo").ToString())
                item.SubItems.Add(reader("producto").ToString())
                item.SubItems.Add(reader("descripcion").ToString())
                item.SubItems.Add(reader("precio_compra").ToString())
                item.SubItems.Add(reader("precio_venta").ToString())
                item.SubItems.Add(reader("stock_actual").ToString())
                item.SubItems.Add(reader("stock_minimo").ToString())
                item.SubItems.Add(reader("categoria").ToString())
                item.SubItems.Add(reader("proveedor").ToString())
                item.SubItems.Add(reader("created_at").ToString())
                item.SubItems.Add(reader("update_at").ToString())
                item.SubItems.Add(If(reader("activo") = True, "Sí", "No"))
                lvProducts.Items.Add(item)
            End While

            reader.Close()
            conexion.Close()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        cargarCategoria("id")
        cargarProveedor("id")

        cargaGrilla()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbCodigo.Text.Trim() = "" Or tbName.Text.Trim() = "" Or tbSell.Text.Trim() = "" Or tbBuy.Text.Trim() = "" Or tbMin.Text.Trim() = "" Or tbCurrent.Text.Trim() = "" Or cbCategory.SelectedIndex = -1 Or cbSupplie.SelectedIndex = -1 Then
            MsgBox("Por favor, complete todos los campos.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            conexion.Open()
            Dim query As String = "INSERT INTO productos 
                                    (codigo, nombre, descripcion, precio_compra, precio_venta, stock_actual, stock_minimo, categoria_id, proveedor_id, created_at, update_at)
                                    VALUES
                                    (@codigo, @nombre, @descripcion, @precio_compra, @precio_venta, @stock_actual, @stock_minimo,
                                     (SELECT id FROM categorias WHERE nombre = @categoria LIMIT 1),
                                     (SELECT id FROM proveedores WHERE nombre = @proveedor LIMIT 1),
                                     NOW(), NOW())"
            Dim cmd As New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@codigo", tbCodigo.Text.Trim())
            cmd.Parameters.AddWithValue("@nombre", tbName.Text.Trim())
            cmd.Parameters.AddWithValue("@descripcion", rtbDescription.Text.Trim())
            cmd.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(tbSell.Text.Trim()))
            cmd.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(tbBuy.Text.Trim()))
            cmd.Parameters.AddWithValue("@stock_minimo", Convert.ToInt32(tbMin.Text.Trim()))
            cmd.Parameters.AddWithValue("@stock_actual", Convert.ToInt32(tbCurrent.Text.Trim()))
            cmd.Parameters.AddWithValue("@categoria", cbCategory.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@proveedor", cbSupplie.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            clearForm()
            conexion.Close()
            cargaGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProducts.SelectedIndexChanged
        If lvProducts.SelectedItems.Count = 0 Then
            clearForm()
            Exit Sub
        End If

        Dim item As ListViewItem = lvProducts.SelectedItems(0)

        tbCodigo.Text = item.SubItems(1).Text
        tbName.Text = item.SubItems(2).Text
        rtbDescription.Text = item.SubItems(3).Text
        tbBuy.Text = item.SubItems(4).Text
        tbSell.Text = item.SubItems(5).Text
        tbCurrent.Text = item.SubItems(6).Text
        tbMin.Text = item.SubItems(7).Text

        ' Selecciona la categoría en el combobox
        Dim categoria As String = item.SubItems(8).Text
        Dim idxCategoria As Integer = cbCategory.FindStringExact(categoria)
        cbCategory.SelectedIndex = idxCategoria

        ' Selecciona el proveedor en el combobox
        Dim proveedor As String = item.SubItems(9).Text
        Dim idxProveedor As Integer = cbSupplie.FindStringExact(proveedor)
        cbSupplie.SelectedIndex = idxProveedor
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If lvProducts.SelectedItems.Count = 0 Then ' verifico que haya una fila seleccionada
            MsgBox("Por favor, seleccione un producto para eliminar.", MsgBoxStyle.Exclamation, "Selección requerida")
            Exit Sub
        End If

        Dim selectedId As Integer = Convert.ToInt32(lvProducts.SelectedItems(0).Text) ' convierto el ID seleccionado a Integer

        If tbCodigo.Text.Trim() = "" Or tbName.Text.Trim() = "" Or tbSell.Text.Trim() = "" Or tbBuy.Text.Trim() = "" Or tbMin.Text.Trim() = "" Or tbCurrent.Text.Trim() = "" Or cbCategory.SelectedIndex = -1 Or cbSupplie.SelectedIndex = -1 Then
            MsgBox("Por favor, complete todos los campos.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim query As String = "UPDATE productos SET 
                                codigo = @codigo,
                                nombre = @nombre,
                                descripcion = @descripcion,
                                precio_compra = @precio_compra,
                                precio_venta = @precio_venta,
                                stock_actual = @stock_actual,
                                stock_minimo = @stock_minimo,
                                categoria_id = (SELECT id FROM categorias WHERE nombre = @categoria LIMIT 1),
                                proveedor_id = (SELECT id FROM proveedores WHERE nombre = @proveedor LIMIT 1),
                                update_at = NOW()
                            WHERE id = @id"

            Dim cmd As New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@codigo", tbCodigo.Text.Trim())
            cmd.Parameters.AddWithValue("@nombre", tbName.Text.Trim())
            cmd.Parameters.AddWithValue("@descripcion", rtbDescription.Text.Trim())
            cmd.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(tbBuy.Text.Trim()))
            cmd.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(tbSell.Text.Trim()))
            cmd.Parameters.AddWithValue("@stock_actual", Convert.ToInt32(tbCurrent.Text.Trim()))
            cmd.Parameters.AddWithValue("@stock_minimo", Convert.ToInt32(tbMin.Text.Trim()))
            cmd.Parameters.AddWithValue("@categoria", cbCategory.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@proveedor", cbSupplie.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@id", selectedId)
            cmd.ExecuteNonQuery()

            conexion.Close()
            cargaGrilla()
            clearForm()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearForm()
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvProducts.SelectedItems.Count = 0 Then ' verifico que haya una fila seleccionada
            MsgBox("Por favor, seleccione un producto para eliminar.", MsgBoxStyle.Exclamation, "Selección requerida")
            Exit Sub
        End If
        Dim selectedId As Integer = Convert.ToInt32(lvProducts.SelectedItems(0).Text)
        Try

            conexion.Open()

            Dim query As String = "UPDATE productos SET activo = 0, update_at = NOW() WHERE id = @id"

            Dim cmd As New MySqlCommand(query, conexion)

            cmd.Parameters.AddWithValue("@id", selectedId)

            cmd.ExecuteNonQuery()

            conexion.Close()
            cargaGrilla()
            clearForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Productos_shown(sender As Object, e As EventArgs) Handles Me.Shown
        AjustarColumnas()
    End Sub

    Private Sub tbQueryProduct_TextChanged(sender As Object, e As EventArgs) Handles tbQueryProduct.TextChanged
        If tbQueryProduct.Text = "" Then
            cargaGrilla()

        Else
            busquedaAsistida(tbQueryProduct.Text)
        End If

    End Sub

    Private Sub tbQueryCategory_TextChanged(sender As Object, e As EventArgs) Handles tbQueryCategory.TextChanged
        If tbQueryCategory.Text = "" Then
            cargaGrilla()

        Else
            busquedaAsistida(tbQueryCategory.Text)
        End If
    End Sub
End Class