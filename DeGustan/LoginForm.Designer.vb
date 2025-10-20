<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblUsuario = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        pnlContent = New Panel()
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 11F)
        lblUsuario.ForeColor = Color.White
        lblUsuario.Location = New Point(24, 20)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(91, 30)
        lblUsuario.TabIndex = 1
        lblUsuario.Text = "Usuario:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 11F)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(24, 70)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(127, 30)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Contraseña:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.Location = New Point(160, 17)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(280, 37)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.Location = New Point(160, 67)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(280, 37)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(202, 123)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(169, 64)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Ingresar"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(38), CByte(22), CByte(61))
        pnlContent.Controls.Add(lblUsuario)
        pnlContent.Controls.Add(txtUsername)
        pnlContent.Controls.Add(lblPassword)
        pnlContent.Controls.Add(txtPassword)
        pnlContent.Controls.Add(btnLogin)
        pnlContent.Location = New Point(42, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(480, 209)
        pnlContent.TabIndex = 0
        ' 
        ' LoginForm
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(11.0F, 28.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(589, 344)
        Controls.Add(pnlContent)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar sesión - DeGustan"
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlContent As Panel
End Class
