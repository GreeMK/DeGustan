Imports DeGustan.ConnectorBD
Imports MySql.Data.MySqlClient

Public Class Movimientos
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar conexión y cargar datos base
        Try
            Conectar()
        Catch
        End Try

        ' Cargar tipos
        cbType.Items.Clear()
        cbType.Items.Add("entrada")
        cbType.Items.Add("salida")
        cbType.Items.Add("ajuste")

        ' Cargar productos en comboboxes
        LoadProductsIntoCombo(cbProductID)
        LoadProductsIntoCombo(ComboBox1)

        ' Cargar tipos para filtro
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("") ' vacío = todos
        ComboBox2.Items.Add("entrada")
        ComboBox2.Items.Add("salida")
        ComboBox2.Items.Add("ajuste")

        ' Cargar movimientos
        LoadMovements()
    End Sub

    Private Sub LoadProductsIntoCombo(cmb As ComboBox)
        Try
            conexion.Open()
            Dim query As String = "SELECT id, CONCAT(codigo,' - ',nombre) AS display FROM productos WHERE activo = 1 ORDER BY nombre;"
            Dim cmd As New MySqlCommand(query, conexion)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            conexion.Close()

            cmb.DisplayMember = "display"
            cmb.ValueMember = "id"
            cmb.DataSource = dt
        Catch ex As Exception
            MsgBox("Error cargando productos: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadMovements(Optional ByVal productId As Integer = -1, Optional ByVal tipo As String = "")
        Try
            conexion.Open()
            Dim query As String = "SELECT m.id, p.codigo, p.nombre AS producto, m.tipo, m.cantidad, m.cantidad_anterior, m.cantidad_nueva, m.motivo, u.nombre AS usuario, m.referencia, m.created_at " &
                                  "FROM movimientos_stock m " &
                                  "JOIN productos p ON m.producto_id = p.id " &
                                  "JOIN usuarios u ON m.usuario_id = u.id "

            Dim whereAdded As Boolean = False
            If productId > 0 Then
                query &= " WHERE m.producto_id = @pid"
                whereAdded = True
            End If
            If Not String.IsNullOrEmpty(tipo) Then
                If whereAdded Then
                    query &= " AND m.tipo = @tipo"
                Else
                    query &= " WHERE m.tipo = @tipo"
                    whereAdded = True
                End If
            End If

            query &= " ORDER BY m.created_at DESC;"

            Dim cmd As New MySqlCommand(query, conexion)
            If productId > 0 Then cmd.Parameters.AddWithValue("@pid", productId)
            If Not String.IsNullOrEmpty(tipo) Then cmd.Parameters.AddWithValue("@tipo", tipo)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ListView1.Items.Clear()
            While reader.Read()
                Dim it As New ListViewItem(reader("id").ToString())
                it.SubItems.Add(reader("codigo").ToString())
                it.SubItems.Add(reader("tipo").ToString())
                it.SubItems.Add(reader("cantidad").ToString())
                it.SubItems.Add(reader("cantidad_anterior").ToString())
                it.SubItems.Add(reader("cantidad_nueva").ToString())
                it.SubItems.Add(reader("motivo").ToString())
                it.SubItems.Add(reader("usuario").ToString())
                it.SubItems.Add(If(IsDBNull(reader("referencia")), "", reader("referencia").ToString()))
                it.SubItems.Add(reader("created_at").ToString())
                ListView1.Items.Add(it)
            End While
            reader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error cargando movimientos: " & ex.Message)
        End Try
    End Sub

    Private Function GetCurrentStock(productId As Integer) As Integer
        Try
            conexion.Open()
            Dim q As String = "SELECT stock_actual FROM productos WHERE id = @id LIMIT 1"
            Dim cmd As New MySqlCommand(q, conexion)
            cmd.Parameters.AddWithValue("@id", productId)
            Dim obj = cmd.ExecuteScalar()
            conexion.Close()
            If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
                Return Convert.ToInt32(obj)
            End If
        Catch ex As Exception
            MsgBox("Error obteniendo stock: " & ex.Message)
        End Try
        Return 0
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validaciones
        If cbProductID.SelectedValue Is Nothing Then
            MsgBox("Seleccione un producto.")
            Return
        End If
        If cbType.SelectedItem Is Nothing Then
            MsgBox("Seleccione tipo de movimiento.")
            Return
        End If
        Dim prodId As Integer = Convert.ToInt32(cbProductID.SelectedValue)
        Dim tipo As String = cbType.SelectedItem.ToString()
        Dim cantidadInput As Integer
        If Not Integer.TryParse(tbNumber.Text.Trim(), cantidadInput) Then
            MsgBox("Ingrese una cantidad válida.")
            Return
        End If
        If cantidadInput < 0 Then
            MsgBox("La cantidad debe ser positiva.")
            Return
        End If
        Dim motivo As String = TextBox1.Text.Trim()
        If motivo = "" Then
            MsgBox("Ingrese un motivo.")
            Return
        End If
        Dim referencia As String = ""
        If tbReference IsNot Nothing Then referencia = tbReference.Text.Trim()
        If referencia.Length > 100 Then
            MsgBox("La referencia no puede superar 100 caracteres.")
            Return
        End If

        Try
            ' Obtener stock actual
            Dim stockActual As Integer = GetCurrentStock(prodId)
            Dim cantidadAnterior As Integer = stockActual
            Dim cantidadNueva As Integer = stockActual

            If tipo = "entrada" Then
                cantidadNueva = stockActual + cantidadInput
            ElseIf tipo = "salida" Then
                cantidadNueva = stockActual - cantidadInput
                If cantidadNueva < 0 Then cantidadNueva = 0 ' evitar negativos
            ElseIf tipo = "ajuste" Then
                ' Para ajuste interpretamos el número ingresado como nuevo stock
                cantidadNueva = cantidadInput
            End If

            ' Insertar movimiento y actualizar stock en una transacción
            conexion.Open()
            Dim trans = conexion.BeginTransaction()
            Try
                Dim ins As String = "INSERT INTO movimientos_stock (producto_id, tipo, cantidad, cantidad_anterior, cantidad_nueva, motivo, usuario_id, referencia, created_at) " &
                                    "VALUES (@pid, @tipo, @cant, @cant_prev, @cant_new, @motivo, @uid, @ref, NOW())"
                Dim cmdIns As New MySqlCommand(ins, conexion, trans)
                cmdIns.Parameters.AddWithValue("@pid", prodId)
                cmdIns.Parameters.AddWithValue("@tipo", tipo)
                cmdIns.Parameters.AddWithValue("@cant", If(tipo = "ajuste", cantidadNueva, cantidadInput))
                cmdIns.Parameters.AddWithValue("@cant_prev", cantidadAnterior)
                cmdIns.Parameters.AddWithValue("@cant_new", cantidadNueva)
                cmdIns.Parameters.AddWithValue("@motivo", motivo)
                cmdIns.Parameters.AddWithValue("@uid", UsuarioActual.Id)
                ' referencia opcional
                If Not String.IsNullOrWhiteSpace(referencia) Then
                    cmdIns.Parameters.AddWithValue("@ref", referencia)
                Else
                    cmdIns.Parameters.AddWithValue("@ref", DBNull.Value)
                End If
                cmdIns.ExecuteNonQuery()

                Dim upd As String = "UPDATE productos SET stock_actual = @stock WHERE id = @id"
                Dim cmdUpd As New MySqlCommand(upd, conexion, trans)
                cmdUpd.Parameters.AddWithValue("@stock", cantidadNueva)
                cmdUpd.Parameters.AddWithValue("@id", prodId)
                cmdUpd.ExecuteNonQuery()

                trans.Commit()
                conexion.Close()

                MsgBox("Movimiento registrado correctamente.")
                ' Refrescar listados
                LoadMovements()
                clearForm()
            Catch ex As Exception
                trans.Rollback()
                conexion.Close()
                MsgBox("Error al registrar movimiento: " & ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub clearForm()
        cbProductID.SelectedIndex = -1
        cbType.SelectedIndex = -1
        tbNumber.Text = ""
        TextBox1.Text = ""
        If tbReference IsNot Nothing Then tbReference.Text = ""
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearForm()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim prodId As Integer = -1
        Dim tipo As String = ""
        Try
            If ComboBox1.SelectedValue IsNot Nothing Then
                prodId = Convert.ToInt32(ComboBox1.SelectedValue)
            End If
        Catch
        End Try
        Try
            If ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() <> "" Then
                tipo = ComboBox2.SelectedItem.ToString()
            End If
        Catch
        End Try
        LoadMovements(prodId, tipo)
    End Sub
End Class