<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        PictureBox7 = New PictureBox()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        tbNumber = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnDelete = New Button()
        btnNew = New Button()
        btnAdd = New Button()
        btnModify = New Button()
        btnClose = New Button()
        GroupBox2 = New GroupBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        btnSearch = New Button()
        Label7 = New Label()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Label12 = New Label()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.loguito
        PictureBox7.Location = New Point(156, 43)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(164, 100)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 12
        PictureBox7.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Left
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbNumber)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(52, 274)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(360, 250)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(150, 220)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(154, 23)
        ComboBox1.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(10, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 19
        Label6.Text = "Activo"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox4.Location = New Point(150, 178)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(154, 23)
        TextBox4.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(10, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 17
        Label5.Text = "Direccion"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox1.Location = New Point(150, 136)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(154, 23)
        TextBox1.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(150, 58)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(154, 23)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(150, 20)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(154, 23)
        TextBox2.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(10, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 12
        Label4.Text = "Telefono"
        ' 
        ' tbNumber
        ' 
        tbNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tbNumber.Location = New Point(150, 97)
        tbNumber.Margin = New Padding(3, 2, 3, 2)
        tbNumber.Name = "tbNumber"
        tbNumber.Size = New Size(154, 23)
        tbNumber.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(10, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 10
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(10, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 15)
        Label2.TabIndex = 8
        Label2.Text = "Cuit"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(10, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nombre"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Left
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(186, 611)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(92, 32)
        btnDelete.TabIndex = 10
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
        btnNew.Location = New Point(186, 554)
        btnNew.Margin = New Padding(3, 2, 3, 2)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(92, 32)
        btnNew.TabIndex = 9
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
        btnAdd.Location = New Point(52, 554)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(92, 32)
        btnAdd.TabIndex = 8
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
        btnModify.Location = New Point(320, 554)
        btnModify.Margin = New Padding(3, 2, 3, 2)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(92, 32)
        btnModify.TabIndex = 13
        btnModify.Text = "Modificar"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1193, 0)
        btnClose.Margin = New Padding(3, 2, 3, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(35, 30)
        btnClose.TabIndex = 14
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(650, 32)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(420, 100)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Consultas"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(149, 61)
        TextBox6.Margin = New Padding(3, 2, 3, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(154, 23)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(149, 20)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(154, 23)
        TextBox5.TabIndex = 12
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(318, 34)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(92, 32)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Location = New Point(8, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 15)
        Label7.TabIndex = 10
        Label7.Text = "Cuit"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(8, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 15)
        Label8.TabIndex = 8
        Label8.Text = "Nombre"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(515, 145)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(673, 599)
        DataGridView1.TabIndex = 14
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.ForeColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        Label12.Location = New Point(1088, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(97, 21)
        Label12.TabIndex = 18
        Label12.Text = "Proveedores"
        ' 
        ' proveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(1229, 781)
        Controls.Add(Label12)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(btnClose)
        Controls.Add(btnModify)
        Controls.Add(PictureBox7)
        Controls.Add(GroupBox1)
        Controls.Add(btnDelete)
        Controls.Add(btnNew)
        Controls.Add(btnAdd)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "proveedores"
        Text = "proveedores"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnModify As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
End Class
