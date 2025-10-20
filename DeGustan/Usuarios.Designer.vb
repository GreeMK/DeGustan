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
        cbactivo = New CheckBox()
        Label9 = New Label()
        Label7 = New Label()
        tbEmail = New TextBox()
        Label5 = New Label()
        tbPassword = New TextBox()
        btnCargarImagen = New Button()
        cbrol = New ComboBox()
        Label6 = New Label()
        tbname = New TextBox()
        tbUsername = New TextBox()
        Label4 = New Label()
        tbapellido = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnDelete = New Button()
        btnAdd = New Button()
        GroupBox2 = New GroupBox()
        tbBuscar = New TextBox()
        btnSearch = New Button()
        Label8 = New Label()
        dtgridUsers = New DataGridView()
        Label12 = New Label()
        pictureUser = New PictureBox()
        PrintDocUser = New Printing.PrintDocument()
        btnCredencial = New Button()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dtgridUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1158, 0)
        btnClose.Margin = New Padding(3, 2, 3, 2)
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
        btnModify.Location = New Point(195, 603)
        btnModify.Margin = New Padding(3, 2, 3, 2)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(105, 42)
        btnModify.TabIndex = 22
        btnModify.Text = "Modificar"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.loguito
        PictureBox7.Location = New Point(55, 23)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(187, 134)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 21
        PictureBox7.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Left
        GroupBox1.Controls.Add(cbactivo)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(tbEmail)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(tbPassword)
        GroupBox1.Controls.Add(btnCargarImagen)
        GroupBox1.Controls.Add(cbrol)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(tbname)
        GroupBox1.Controls.Add(tbUsername)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbapellido)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(55, 162)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(374, 437)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        ' 
        ' cbactivo
        ' 
        cbactivo.AutoSize = True
        cbactivo.Location = New Point(252, 327)
        cbactivo.Margin = New Padding(2, 2, 2, 2)
        cbactivo.Name = "cbactivo"
        cbactivo.Size = New Size(18, 17)
        cbactivo.TabIndex = 28
        cbactivo.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Location = New Point(11, 232)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 20)
        Label9.TabIndex = 27
        Label9.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Location = New Point(22, 212)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 20)
        Label7.TabIndex = 26
        ' 
        ' tbEmail
        ' 
        tbEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tbEmail.Location = New Point(171, 222)
        tbEmail.Margin = New Padding(3, 2, 3, 2)
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(175, 27)
        tbEmail.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(11, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 24
        Label5.Text = "Password"
        ' 
        ' tbPassword
        ' 
        tbPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tbPassword.Location = New Point(171, 178)
        tbPassword.Margin = New Padding(3, 2, 3, 2)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(175, 27)
        tbPassword.TabIndex = 23
        ' 
        ' btnCargarImagen
        ' 
        btnCargarImagen.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCargarImagen.ForeColor = SystemColors.ActiveCaptionText
        btnCargarImagen.Location = New Point(230, 370)
        btnCargarImagen.Margin = New Padding(2, 2, 2, 2)
        btnCargarImagen.Name = "btnCargarImagen"
        btnCargarImagen.Size = New Size(115, 28)
        btnCargarImagen.TabIndex = 22
        btnCargarImagen.Text = "Cargar Imagen "
        btnCargarImagen.UseVisualStyleBackColor = True
        ' 
        ' cbrol
        ' 
        cbrol.FormattingEnabled = True
        cbrol.Location = New Point(171, 268)
        cbrol.Margin = New Padding(3, 2, 3, 2)
        cbrol.Name = "cbrol"
        cbrol.Size = New Size(175, 28)
        cbrol.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(11, 325)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 19
        Label6.Text = "Activo"
        ' 
        ' tbname
        ' 
        tbname.Location = New Point(171, 78)
        tbname.Margin = New Padding(3, 2, 3, 2)
        tbname.Name = "tbname"
        tbname.Size = New Size(175, 27)
        tbname.TabIndex = 15
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(171, 26)
        tbUsername.Margin = New Padding(3, 2, 3, 2)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(175, 27)
        tbUsername.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(11, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 20)
        Label4.TabIndex = 12
        Label4.Text = "Rol"
        ' 
        ' tbapellido
        ' 
        tbapellido.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tbapellido.Location = New Point(171, 130)
        tbapellido.Margin = New Padding(3, 2, 3, 2)
        tbapellido.Name = "tbapellido"
        tbapellido.Size = New Size(175, 27)
        tbapellido.TabIndex = 11
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
        Label1.Location = New Point(11, 30)
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
        btnDelete.Location = New Point(324, 603)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 42)
        btnDelete.TabIndex = 19
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = SystemColors.Control
        btnAdd.Location = New Point(71, 603)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 42)
        btnAdd.TabIndex = 17
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top
        GroupBox2.Controls.Add(tbBuscar)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(606, 66)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(480, 82)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Consultas"
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(150, 30)
        tbBuscar.Margin = New Padding(3, 2, 3, 2)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(175, 27)
        tbBuscar.TabIndex = 12
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(368, 22)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(105, 42)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(9, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 20)
        Label8.TabIndex = 8
        Label8.Text = "Nombre"
        ' 
        ' dtgridUsers
        ' 
        dtgridUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        dtgridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgridUsers.Location = New Point(465, 217)
        dtgridUsers.Margin = New Padding(3, 2, 3, 2)
        dtgridUsers.Name = "dtgridUsers"
        dtgridUsers.RowHeadersWidth = 51
        dtgridUsers.Size = New Size(725, 261)
        dtgridUsers.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12.0F)
        Label12.ForeColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        Label12.Location = New Point(1038, 4)
        Label12.Name = "Label12"
        Label12.Size = New Size(87, 28)
        Label12.TabIndex = 25
        Label12.Text = "Usuarios"
        ' 
        ' pictureUser
        ' 
        pictureUser.Location = New Point(255, 23)
        pictureUser.Margin = New Padding(2, 2, 2, 2)
        pictureUser.Name = "pictureUser"
        pictureUser.Size = New Size(155, 134)
        pictureUser.SizeMode = PictureBoxSizeMode.StretchImage
        pictureUser.TabIndex = 26
        pictureUser.TabStop = False
        ' 
        ' PrintDocUser
        ' 
        ' 
        ' btnCredencial
        ' 
        btnCredencial.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCredencial.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnCredencial.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnCredencial.FlatStyle = FlatStyle.Flat
        btnCredencial.ForeColor = SystemColors.Control
        btnCredencial.Location = New Point(455, 85)
        btnCredencial.Margin = New Padding(3, 2, 3, 2)
        btnCredencial.Name = "btnCredencial"
        btnCredencial.Size = New Size(105, 42)
        btnCredencial.TabIndex = 27
        btnCredencial.Text = "Credencial"
        btnCredencial.UseVisualStyleBackColor = True
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(1200, 676)
        Controls.Add(btnCredencial)
        Controls.Add(pictureUser)
        Controls.Add(Label12)
        Controls.Add(dtgridUsers)
        Controls.Add(GroupBox2)
        Controls.Add(btnModify)
        Controls.Add(PictureBox7)
        Controls.Add(GroupBox1)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Usuarios"
        Text = "Usuarios"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dtgridUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbname As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbapellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbrol As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtgridUsers As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents pictureUser As PictureBox
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbactivo As CheckBox
    Friend WithEvents PrintDocUser As Printing.PrintDocument
    Friend WithEvents btnCredencial As Button
End Class
