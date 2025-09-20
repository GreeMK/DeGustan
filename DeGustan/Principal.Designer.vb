<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Panel1 = New Panel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        btnLogOut = New Button()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        btnUsers = New Button()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        btnSuppliers = New Button()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        btnCategorys = New Button()
        panelButton2 = New FlowLayoutPanel()
        btnProducts = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnMovement = New Button()
        PictureBox7 = New PictureBox()
        Timer1 = New Timer(components)
        PanelContainer = New Panel()
        pcbBackground = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        PanelContainer.SuspendLayout()
        CType(pcbBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(38), CByte(22), CByte(61))
        Panel1.Controls.Add(FlowLayoutPanel4)
        Panel1.Controls.Add(btnLogOut)
        Panel1.Controls.Add(FlowLayoutPanel5)
        Panel1.Controls.Add(btnUsers)
        Panel1.Controls.Add(FlowLayoutPanel6)
        Panel1.Controls.Add(btnSuppliers)
        Panel1.Controls.Add(FlowLayoutPanel3)
        Panel1.Controls.Add(btnCategorys)
        Panel1.Controls.Add(panelButton2)
        Panel1.Controls.Add(btnProducts)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Controls.Add(btnMovement)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.MaximumSize = New Size(225, 0)
        Panel1.MinimumSize = New Size(85, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(225, 781)
        Panel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        FlowLayoutPanel4.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        FlowLayoutPanel4.Location = New Point(-2, 717)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(15, 58)
        FlowLayoutPanel4.TabIndex = 15
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI", 12F)
        btnLogOut.ForeColor = SystemColors.ButtonFace
        btnLogOut.Image = My.Resources.Resources.cerrar_sesion1
        btnLogOut.ImageAlign = ContentAlignment.MiddleLeft
        btnLogOut.Location = New Point(13, 717)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(260, 58)
        btnLogOut.TabIndex = 16
        btnLogOut.Text = "Cerrar sesión"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Anchor = AnchorStyles.Left
        FlowLayoutPanel5.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        FlowLayoutPanel5.Location = New Point(-2, 468)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(15, 58)
        FlowLayoutPanel5.TabIndex = 13
        ' 
        ' btnUsers
        ' 
        btnUsers.Anchor = AnchorStyles.Left
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 12F)
        btnUsers.ForeColor = SystemColors.ButtonFace
        btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), Image)
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(13, 468)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(252, 58)
        btnUsers.TabIndex = 14
        btnUsers.Text = "Usuarios"
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Anchor = AnchorStyles.Left
        FlowLayoutPanel6.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        FlowLayoutPanel6.Location = New Point(-2, 404)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(15, 58)
        FlowLayoutPanel6.TabIndex = 11
        ' 
        ' btnSuppliers
        ' 
        btnSuppliers.Anchor = AnchorStyles.Left
        btnSuppliers.FlatAppearance.BorderSize = 0
        btnSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnSuppliers.FlatStyle = FlatStyle.Flat
        btnSuppliers.Font = New Font("Segoe UI", 12F)
        btnSuppliers.ForeColor = SystemColors.ButtonFace
        btnSuppliers.Image = CType(resources.GetObject("btnSuppliers.Image"), Image)
        btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft
        btnSuppliers.Location = New Point(13, 404)
        btnSuppliers.Name = "btnSuppliers"
        btnSuppliers.Size = New Size(280, 58)
        btnSuppliers.TabIndex = 12
        btnSuppliers.Text = "Proveedores"
        btnSuppliers.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Left
        FlowLayoutPanel3.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        FlowLayoutPanel3.Location = New Point(-2, 340)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(15, 58)
        FlowLayoutPanel3.TabIndex = 9
        ' 
        ' btnCategorys
        ' 
        btnCategorys.Anchor = AnchorStyles.Left
        btnCategorys.FlatAppearance.BorderSize = 0
        btnCategorys.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnCategorys.FlatStyle = FlatStyle.Flat
        btnCategorys.Font = New Font("Segoe UI", 12F)
        btnCategorys.ForeColor = SystemColors.ButtonFace
        btnCategorys.Image = CType(resources.GetObject("btnCategorys.Image"), Image)
        btnCategorys.ImageAlign = ContentAlignment.MiddleLeft
        btnCategorys.Location = New Point(13, 340)
        btnCategorys.Name = "btnCategorys"
        btnCategorys.Size = New Size(260, 58)
        btnCategorys.TabIndex = 10
        btnCategorys.Text = "Categorías"
        btnCategorys.UseVisualStyleBackColor = True
        ' 
        ' panelButton2
        ' 
        panelButton2.Anchor = AnchorStyles.Left
        panelButton2.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        panelButton2.Location = New Point(-2, 276)
        panelButton2.Name = "panelButton2"
        panelButton2.Size = New Size(15, 58)
        panelButton2.TabIndex = 7
        ' 
        ' btnProducts
        ' 
        btnProducts.Anchor = AnchorStyles.Left
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.Font = New Font("Segoe UI", 12F)
        btnProducts.ForeColor = SystemColors.ButtonFace
        btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), Image)
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft
        btnProducts.Location = New Point(19, 276)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(246, 58)
        btnProducts.TabIndex = 8
        btnProducts.Text = "Productos"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Left
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        FlowLayoutPanel1.Location = New Point(-2, 212)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(15, 58)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' btnMovement
        ' 
        btnMovement.Anchor = AnchorStyles.Left
        btnMovement.FlatAppearance.BorderSize = 0
        btnMovement.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(51), CByte(85))
        btnMovement.FlatStyle = FlatStyle.Flat
        btnMovement.Font = New Font("Segoe UI", 12F)
        btnMovement.ForeColor = SystemColors.ButtonFace
        btnMovement.Image = CType(resources.GetObject("btnMovement.Image"), Image)
        btnMovement.ImageAlign = ContentAlignment.MiddleLeft
        btnMovement.Location = New Point(16, 212)
        btnMovement.Name = "btnMovement"
        btnMovement.Size = New Size(275, 58)
        btnMovement.TabIndex = 2
        btnMovement.Text = "Movimientos"
        btnMovement.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.loguito
        PictureBox7.Location = New Point(-2, 1)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 72)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' PanelContainer
        ' 
        PanelContainer.Controls.Add(pcbBackground)
        PanelContainer.Dock = DockStyle.Fill
        PanelContainer.Location = New Point(225, 0)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(1229, 781)
        PanelContainer.TabIndex = 2
        ' 
        ' pcbBackground
        ' 
        pcbBackground.Anchor = AnchorStyles.None
        pcbBackground.Image = My.Resources.Resources.logo
        pcbBackground.Location = New Point(277, 184)
        pcbBackground.Name = "pcbBackground"
        pcbBackground.Size = New Size(675, 412)
        pcbBackground.SizeMode = PictureBoxSizeMode.Zoom
        pcbBackground.TabIndex = 2
        pcbBackground.TabStop = False
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(33), CByte(70))
        ClientSize = New Size(1454, 781)
        Controls.Add(PanelContainer)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1470, 820)
        Name = "Principal"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        PanelContainer.ResumeLayout(False)
        CType(pcbBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents btnMovement As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents btnUsers As Button
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents btnCategorys As Button
    Friend WithEvents panelButton2 As FlowLayoutPanel
    Friend WithEvents btnProducts As Button
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents pcbBackground As PictureBox
End Class
