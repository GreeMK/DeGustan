<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        btnModify = New Button()
        PictureBox7 = New PictureBox()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
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
        ComboBox2 = New ComboBox()
        GroupBox2 = New GroupBox()
        TextBox5 = New TextBox()
        btnSearch = New Button()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1325, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 40)
        btnClose.TabIndex = 16
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.Anchor = AnchorStyles.Left
        btnModify.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnModify.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnModify.FlatStyle = FlatStyle.Flat
        btnModify.ForeColor = SystemColors.Control
        btnModify.Location = New Point(368, 582)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(105, 43)
        btnModify.TabIndex = 22
        btnModify.Text = "Modificar"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.loguito
        PictureBox7.Location = New Point(180, 48)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(188, 133)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 21
        PictureBox7.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Left
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbNumber)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(62, 223)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(411, 295)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(172, 236)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(176, 28)
        ComboBox1.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(11, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 19
        Label6.Text = "Activo"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(172, 77)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 27)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(172, 26)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 27)
        TextBox2.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(11, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 20)
        Label4.TabIndex = 12
        Label4.Text = "Rol"
        ' 
        ' tbNumber
        ' 
        tbNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tbNumber.Location = New Point(172, 129)
        tbNumber.Name = "tbNumber"
        tbNumber.Size = New Size(176, 27)
        tbNumber.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(11, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 10
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(11, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(11, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 6
        Label1.Text = "Username"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Left
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(215, 658)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 43)
        btnDelete.TabIndex = 19
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
        btnNew.Location = New Point(215, 582)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(105, 43)
        btnNew.TabIndex = 18
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
        btnAdd.Location = New Point(62, 582)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 43)
        btnAdd.TabIndex = 17
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(172, 182)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 28)
        ComboBox2.TabIndex = 21
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(690, 67)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(480, 82)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Consultas"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(170, 26)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(176, 27)
        TextBox5.TabIndex = 12
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(368, 21)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(105, 43)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(9, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 20)
        Label8.TabIndex = 8
        Label8.Text = "Nombre"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(533, 170)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(769, 531)
        DataGridView1.TabIndex = 24
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(1367, 773)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(btnModify)
        Controls.Add(PictureBox7)
        Controls.Add(GroupBox1)
        Controls.Add(btnDelete)
        Controls.Add(btnNew)
        Controls.Add(btnAdd)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "Usuarios"
        Text = "Usuarios"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
