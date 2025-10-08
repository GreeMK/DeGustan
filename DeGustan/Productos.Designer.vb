<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnClose = New Button()
        pbImgProd = New PictureBox()
        GroupBox1 = New GroupBox()
        rtbDescription = New RichTextBox()
        btnChangeImg = New Button()
        cbSupplie = New ComboBox()
        Label9 = New Label()
        cbCategory = New ComboBox()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        tbMin = New TextBox()
        Label6 = New Label()
        tbCurrent = New TextBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        tbSell = New TextBox()
        Label5 = New Label()
        tbBuy = New TextBox()
        Label4 = New Label()
        tbName = New TextBox()
        tbCodigo = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        tbQueryCategory = New TextBox()
        tbQueryProduct = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        btnDelete = New Button()
        btnNew = New Button()
        btnAdd = New Button()
        btnModify = New Button()
        Label12 = New Label()
        lvProducts = New ListView()
        colID = New ColumnHeader()
        colCodigo = New ColumnHeader()
        colName = New ColumnHeader()
        colDescription = New ColumnHeader()
        colBuy = New ColumnHeader()
        colSell = New ColumnHeader()
        colCurrent = New ColumnHeader()
        colMin = New ColumnHeader()
        colCategory = New ColumnHeader()
        colSupplie = New ColumnHeader()
        colCreated_at = New ColumnHeader()
        colUpdate_at = New ColumnHeader()
        colActive = New ColumnHeader()
        CType(pbImgProd, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1193, 0)
        btnClose.Margin = New Padding(3, 2, 3, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(35, 30)
        btnClose.TabIndex = 1
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' pbImgProd
        ' 
        pbImgProd.Image = My.Resources.Resources.loguito
        pbImgProd.Location = New Point(10, 24)
        pbImgProd.Margin = New Padding(3, 2, 3, 2)
        pbImgProd.Name = "pbImgProd"
        pbImgProd.Size = New Size(144, 100)
        pbImgProd.SizeMode = PictureBoxSizeMode.Zoom
        pbImgProd.TabIndex = 8
        pbImgProd.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Left
        GroupBox1.Controls.Add(rtbDescription)
        GroupBox1.Controls.Add(btnChangeImg)
        GroupBox1.Controls.Add(cbSupplie)
        GroupBox1.Controls.Add(pbImgProd)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(cbCategory)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(tbName)
        GroupBox1.Controls.Add(tbCodigo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(56, 25)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(360, 569)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        ' 
        ' rtbDescription
        ' 
        rtbDescription.Location = New Point(149, 219)
        rtbDescription.Name = "rtbDescription"
        rtbDescription.Size = New Size(154, 77)
        rtbDescription.TabIndex = 22
        rtbDescription.Text = ""
        ' 
        ' btnChangeImg
        ' 
        btnChangeImg.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnChangeImg.FlatStyle = FlatStyle.Flat
        btnChangeImg.Location = New Point(186, 52)
        btnChangeImg.Margin = New Padding(3, 2, 3, 2)
        btnChangeImg.Name = "btnChangeImg"
        btnChangeImg.Size = New Size(82, 49)
        btnChangeImg.TabIndex = 21
        btnChangeImg.Text = "Cambiar imagen"
        btnChangeImg.UseVisualStyleBackColor = True
        ' 
        ' cbSupplie
        ' 
        cbSupplie.FormattingEnabled = True
        cbSupplie.Location = New Point(150, 347)
        cbSupplie.Margin = New Padding(3, 2, 3, 2)
        cbSupplie.Name = "cbSupplie"
        cbSupplie.Size = New Size(153, 23)
        cbSupplie.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Location = New Point(10, 349)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 15)
        Label9.TabIndex = 19
        Label9.Text = "Proveedor"
        ' 
        ' cbCategory
        ' 
        cbCategory.FormattingEnabled = True
        cbCategory.Location = New Point(150, 311)
        cbCategory.Margin = New Padding(3, 2, 3, 2)
        cbCategory.Name = "cbCategory"
        cbCategory.Size = New Size(153, 23)
        cbCategory.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(10, 313)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 17
        Label8.Text = "Categoría"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(tbMin)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(tbCurrent)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.ForeColor = SystemColors.Control
        GroupBox3.Location = New Point(8, 467)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(345, 94)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "Stock"
        ' 
        ' tbMin
        ' 
        tbMin.Location = New Point(141, 59)
        tbMin.Margin = New Padding(3, 2, 3, 2)
        tbMin.Name = "tbMin"
        tbMin.Size = New Size(154, 23)
        tbMin.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 2
        Label6.Text = "Mínimo"
        ' 
        ' tbCurrent
        ' 
        tbCurrent.Location = New Point(141, 19)
        tbCurrent.Margin = New Padding(3, 2, 3, 2)
        tbCurrent.Name = "tbCurrent"
        tbCurrent.Size = New Size(154, 23)
        tbCurrent.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(5, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 0
        Label7.Text = "Actual"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tbSell)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(tbBuy)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(8, 372)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(345, 94)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Precios"
        ' 
        ' tbSell
        ' 
        tbSell.Location = New Point(141, 59)
        tbSell.Margin = New Padding(3, 2, 3, 2)
        tbSell.Name = "tbSell"
        tbSell.Size = New Size(154, 23)
        tbSell.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 2
        Label5.Text = "Venta"
        ' 
        ' tbBuy
        ' 
        tbBuy.Location = New Point(141, 19)
        tbBuy.Margin = New Padding(3, 2, 3, 2)
        tbBuy.Name = "tbBuy"
        tbBuy.Size = New Size(154, 23)
        tbBuy.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 0
        Label4.Text = "Compra"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(150, 184)
        tbName.Margin = New Padding(3, 2, 3, 2)
        tbName.Name = "tbName"
        tbName.Size = New Size(154, 23)
        tbName.TabIndex = 14
        ' 
        ' tbCodigo
        ' 
        tbCodigo.Location = New Point(150, 150)
        tbCodigo.Margin = New Padding(3, 2, 3, 2)
        tbCodigo.Name = "tbCodigo"
        tbCodigo.Size = New Size(154, 23)
        tbCodigo.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(10, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 10
        Label3.Text = "Descripcion"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(10, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(10, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 6
        Label1.Text = "Codigo"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top
        GroupBox4.Controls.Add(tbQueryCategory)
        GroupBox4.Controls.Add(tbQueryProduct)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.ForeColor = SystemColors.Control
        GroupBox4.Location = New Point(633, 41)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(296, 100)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Busquedas"
        ' 
        ' tbQueryCategory
        ' 
        tbQueryCategory.Location = New Point(111, 60)
        tbQueryCategory.Name = "tbQueryCategory"
        tbQueryCategory.Size = New Size(161, 23)
        tbQueryCategory.TabIndex = 12
        ' 
        ' tbQueryProduct
        ' 
        tbQueryProduct.Location = New Point(111, 19)
        tbQueryProduct.Name = "tbQueryProduct"
        tbQueryProduct.Size = New Size(161, 23)
        tbQueryProduct.TabIndex = 11
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Location = New Point(8, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 15)
        Label10.TabIndex = 10
        Label10.Text = "Categoría"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Location = New Point(8, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 15)
        Label11.TabIndex = 8
        Label11.Text = "Producto"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Left
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(232, 623)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(92, 32)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Anchor = AnchorStyles.Left
        btnNew.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.ForeColor = SystemColors.Control
        btnNew.Location = New Point(127, 673)
        btnNew.Margin = New Padding(3, 2, 3, 2)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(92, 32)
        btnNew.TabIndex = 13
        btnNew.Text = "Nuevo"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = SystemColors.Control
        btnAdd.Location = New Point(127, 623)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(92, 32)
        btnAdd.TabIndex = 12
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.Anchor = AnchorStyles.Left
        btnModify.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnModify.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnModify.FlatStyle = FlatStyle.Flat
        btnModify.ForeColor = SystemColors.Control
        btnModify.Location = New Point(232, 673)
        btnModify.Margin = New Padding(3, 2, 3, 2)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(92, 32)
        btnModify.TabIndex = 15
        btnModify.Text = "Modificar"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.ForeColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        Label12.Location = New Point(1088, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 21)
        Label12.TabIndex = 16
        Label12.Text = "Productos"
        ' 
        ' lvProducts
        ' 
        lvProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lvProducts.Columns.AddRange(New ColumnHeader() {colID, colCodigo, colName, colDescription, colBuy, colSell, colCurrent, colMin, colCategory, colSupplie, colCreated_at, colUpdate_at, colActive})
        lvProducts.FullRowSelect = True
        lvProducts.Location = New Point(503, 165)
        lvProducts.Name = "lvProducts"
        lvProducts.Size = New Size(675, 540)
        lvProducts.TabIndex = 17
        lvProducts.UseCompatibleStateImageBehavior = False
        lvProducts.View = View.Details
        ' 
        ' colID
        ' 
        colID.Text = "ID"
        colID.Width = 0
        ' 
        ' colCodigo
        ' 
        colCodigo.Text = "Codigo"
        ' 
        ' colName
        ' 
        colName.Text = "Nombre"
        ' 
        ' colDescription
        ' 
        colDescription.Text = "Descripción"
        ' 
        ' colBuy
        ' 
        colBuy.Text = "Precio Compra"
        ' 
        ' colSell
        ' 
        colSell.Text = "Precio Venta"
        ' 
        ' colCurrent
        ' 
        colCurrent.Text = "Stock Actual"
        ' 
        ' colMin
        ' 
        colMin.Text = "Stock Minimo"
        ' 
        ' colCategory
        ' 
        colCategory.Text = "Categoria"
        ' 
        ' colSupplie
        ' 
        colSupplie.Text = "Proveedor"
        ' 
        ' colCreated_at
        ' 
        colCreated_at.Text = "Creado"
        ' 
        ' colUpdate_at
        ' 
        colUpdate_at.Text = "Actualizado"
        ' 
        ' colActive
        ' 
        colActive.Text = "Activo"
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(1229, 781)
        Controls.Add(lvProducts)
        Controls.Add(Label12)
        Controls.Add(btnModify)
        Controls.Add(btnDelete)
        Controls.Add(btnNew)
        Controls.Add(GroupBox4)
        Controls.Add(btnAdd)
        Controls.Add(GroupBox1)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Productos"
        Text = "Productos"
        CType(pbImgProd, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents pbImgProd As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbSell As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBuy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbMin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCurrent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbSupplie As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnChangeImg As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents lvProducts As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
    Friend WithEvents colCategory As ColumnHeader
    Friend WithEvents colSupplie As ColumnHeader
    Friend WithEvents colBuy As ColumnHeader
    Friend WithEvents colSell As ColumnHeader
    Friend WithEvents colCurrent As ColumnHeader
    Friend WithEvents colMin As ColumnHeader
    Friend WithEvents colCreated_at As ColumnHeader
    Friend WithEvents colUpdate_at As ColumnHeader
    Friend WithEvents colCodigo As ColumnHeader
    Friend WithEvents colActive As ColumnHeader
    Friend WithEvents tbQueryCategory As TextBox
    Friend WithEvents tbQueryProduct As TextBox
End Class
