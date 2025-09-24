<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        tbUser = New TextBox()
        Label1 = New Label()
        btnCancel = New Button()
        btnAcept = New Button()
        Label2 = New Label()
        tbPasswd = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' tbUser
        ' 
        tbUser.Location = New Point(167, 100)
        tbUser.Name = "tbUser"
        tbUser.Size = New Size(180, 23)
        tbUser.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(59, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 1
        Label1.Text = "Usuario"
        ' 
        ' btnCancel
        ' 
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12F)
        btnCancel.Location = New Point(253, 238)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(104, 34)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancelar"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnAcept
        ' 
        btnAcept.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(149), CByte(72))
        btnAcept.FlatStyle = FlatStyle.Flat
        btnAcept.Font = New Font("Segoe UI", 12F)
        btnAcept.Location = New Point(54, 238)
        btnAcept.Name = "btnAcept"
        btnAcept.Size = New Size(104, 34)
        btnAcept.TabIndex = 3
        btnAcept.Text = "Aceptar"
        btnAcept.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 5
        Label2.Text = "Contraseña"
        ' 
        ' tbPasswd
        ' 
        tbPasswd.Location = New Point(167, 163)
        tbPasswd.Name = "tbPasswd"
        tbPasswd.PasswordChar = "*"c
        tbPasswd.Size = New Size(180, 23)
        tbPasswd.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(162, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 21)
        Label3.TabIndex = 6
        Label3.Text = "Iniciar sesión"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(423, 304)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbPasswd)
        Controls.Add(btnAcept)
        Controls.Add(btnCancel)
        Controls.Add(Label1)
        Controls.Add(tbUser)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAcept As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPasswd As TextBox
    Friend WithEvents Label3 As Label
End Class
