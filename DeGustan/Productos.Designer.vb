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
        PictureBox7 = New PictureBox()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        tbNumber = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        ComboBox3 = New ComboBox()
        btnSearch = New Button()
        Label10 = New Label()
        ComboBox4 = New ComboBox()
        Label11 = New Label()
        DataGridView1 = New DataGridView()
        btnDelete = New Button()
        btnNew = New Button()
        btnAdd = New Button()
        btnModify = New Button()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1326, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 40)
        btnClose.TabIndex = 1
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.loguito
        PictureBox7.Location = New Point(11, 32)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(164, 133)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 8
        PictureBox7.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(PictureBox7)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(tbNumber)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(64, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(411, 694)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(213, 70)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 65)
        Button1.TabIndex = 21
        Button1.Text = "Cambiar imagen"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(172, 388)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(174, 28)
        ComboBox2.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Location = New Point(11, 391)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 20)
        Label9.TabIndex = 19
        Label9.Text = "Proveedor"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(172, 340)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(174, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(11, 343)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 17
        Label8.Text = "Categoría"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox5)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(TextBox6)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.ForeColor = SystemColors.Control
        GroupBox3.Location = New Point(9, 558)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(394, 126)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "Stock"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(161, 79)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(176, 27)
        TextBox5.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 2
        Label6.Text = "Mínimo"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(161, 25)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(176, 27)
        TextBox6.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 20)
        Label7.TabIndex = 0
        Label7.Text = "Actual"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(9, 430)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(394, 126)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Precios"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(161, 79)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(176, 27)
        TextBox4.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 2
        Label5.Text = "Venta"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(161, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 0
        Label4.Text = "Compra"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(172, 246)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 27)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(172, 200)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 27)
        TextBox2.TabIndex = 10
        ' 
        ' tbNumber
        ' 
        tbNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tbNumber.Location = New Point(172, 293)
        tbNumber.Name = "tbNumber"
        tbNumber.Size = New Size(176, 27)
        tbNumber.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(11, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 10
        Label3.Text = "Descripcion"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(11, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(11, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 6
        Label1.Text = "Codigo"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top
        GroupBox4.Controls.Add(ComboBox3)
        GroupBox4.Controls.Add(btnSearch)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(ComboBox4)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.ForeColor = SystemColors.Control
        GroupBox4.Location = New Point(789, 55)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(480, 133)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Consultas"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(170, 81)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(176, 28)
        ComboBox3.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(364, 46)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(105, 43)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Location = New Point(9, 84)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 20)
        Label10.TabIndex = 10
        Label10.Text = "Categoría"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(170, 26)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(176, 28)
        ComboBox4.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Location = New Point(9, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 20)
        Label11.TabIndex = 8
        Label11.Text = "Producto"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(550, 231)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(785, 500)
        DataGridView1.TabIndex = 11
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(631, 79)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 43)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.ForeColor = SystemColors.Control
        btnNew.Location = New Point(511, 145)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(105, 43)
        btnNew.TabIndex = 13
        btnNew.Text = "Nuevo"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = SystemColors.Control
        btnAdd.Location = New Point(511, 79)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 43)
        btnAdd.TabIndex = 12
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnModify.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnModify.FlatStyle = FlatStyle.Flat
        btnModify.ForeColor = SystemColors.Control
        btnModify.Location = New Point(631, 145)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(105, 43)
        btnModify.TabIndex = 15
        btnModify.Text = "Modificar"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(1367, 773)
        Controls.Add(btnModify)
        Controls.Add(btnDelete)
        Controls.Add(DataGridView1)
        Controls.Add(btnNew)
        Controls.Add(GroupBox4)
        Controls.Add(btnAdd)
        Controls.Add(GroupBox1)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnModify As Button
End Class
