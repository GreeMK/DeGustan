Imports MySql.Data.MySqlClient

Public Class Principal
    Private minWitdh As Integer = 85
    Private maxWidth As Integer = 300
    Private expand As Boolean = False
    Private currentForm As Form = Nothing
    Private originalButtonTexts As New Dictionary(Of Button, String)()


    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs)
        expand = True
        Timer1.Start()
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs)
        If Not Panel1.ClientRectangle.Contains(Panel1.PointToClient(Cursor.Position)) Then
            expand = False
            Timer1.Start()
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(childForm)
        PanelContainer.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not UsuarioActual.IsLoggedIn Then
            MessageBox.Show("Sesión no iniciada. Volviendo al login.")
            Me.Close()
            Dim lf As New LoginForm()
            lf.Show()
            Return
        End If

        Try
            lblUser.Text = String.Format("{0} ({1})", UsuarioActual.Nombre, UsuarioActual.Rol)
        Catch
        End Try

        Panel1.Width = If(UsuarioActual.SidebarExpanded, maxWidth, minWitdh)
        expand = UsuarioActual.SidebarExpanded
        Timer1.Interval = 15

        originalButtonTexts.Clear()
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Button Then
                Dim b As Button = DirectCast(ctrl, Button)
                If b Is btnLogOut Then Continue For
                originalButtonTexts(b) = b.Text
            End If
        Next

        For Each ctrl As Control In Panel1.Controls
            AddHandler ctrl.MouseEnter, AddressOf Panel1_MouseEnter
            AddHandler ctrl.MouseLeave, AddressOf Panel1_MouseLeave
        Next

        btnUsers.Visible = UsuarioActual.HasRole("Root")
        btnUsers.Enabled = UsuarioActual.HasRole("Root")
        btnMovement.Visible = UsuarioActual.HasAnyRole("Root", "Ventas")
        btnMovement.Enabled = UsuarioActual.HasAnyRole("Root", "Ventas")
        btnProducts.Visible = UsuarioActual.HasAnyRole("Root", "Depósito", "Ventas")
        btnProducts.Enabled = UsuarioActual.HasAnyRole("Root", "Depósito")
        btnSuppliers.Visible = UsuarioActual.HasAnyRole("Root", "Depósito")
        btnSuppliers.Enabled = UsuarioActual.HasAnyRole("Root", "Depósito")
        btnCategorys.Visible = UsuarioActual.HasAnyRole("Root", "Depósito", "Ventas")
        btnCategorys.Enabled = UsuarioActual.HasAnyRole("Root", "Depósito")

        ArrangeSidebar(expand)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If expand AndAlso Panel1.Width < maxWidth Then
            Panel1.Width += 10
        ElseIf Not expand AndAlso Panel1.Width > minWitdh Then
            Panel1.Width -= 10
        Else
            Timer1.Stop()
            ArrangeSidebar(expand)
            UsuarioActual.SidebarExpanded = expand
        End If
    End Sub

    Private Sub ArrangeSidebar(expanded As Boolean)
        Try
            Dim menuButtons As New List(Of Button) From {btnMovement, btnProducts, btnCategorys, btnSuppliers, btnUsers}
            Dim topStart As Integer = 10
            If PictureBox7 IsNot Nothing Then topStart = PictureBox7.Bottom + 10
            If lblUser IsNot Nothing AndAlso lblUser.Visible Then
                topStart = Math.Max(topStart, lblUser.Bottom + 8)
            End If

            If btnLogOut IsNot Nothing Then
                btnLogOut.Top = Panel1.Height - btnLogOut.Height - 12
            End If
            Dim bottomLimit As Integer = If(btnLogOut IsNot Nothing, btnLogOut.Top - 10, Panel1.Height - 20)
            Dim availableHeight As Integer = Math.Max(0, bottomLimit - topStart)
            Dim btnHeight As Integer = 58
            Dim n As Integer = menuButtons.Count
            Dim spacing As Integer = 12

            If n > 0 Then
                Dim totalBtnsHeight As Integer = btnHeight * n
                Dim spaceRemaining As Integer = availableHeight - totalBtnsHeight
                spacing = If(spaceRemaining > 0, Math.Max(8, spaceRemaining \ (n + 1)), 6)
            End If

            For Each b In menuButtons
                If b Is Nothing Then Continue For
                If expanded Then
                    If originalButtonTexts.ContainsKey(b) Then b.Text = originalButtonTexts(b)
                    b.ImageAlign = ContentAlignment.MiddleLeft
                    b.TextAlign = ContentAlignment.MiddleLeft
                    b.Size = New Size(Math.Max(50, Panel1.Width - 20), btnHeight)
                Else
                    b.Text = ""
                    b.ImageAlign = ContentAlignment.MiddleCenter
                    b.TextAlign = ContentAlignment.MiddleCenter
                    b.Size = New Size(Math.Max(40, minWitdh - 10), btnHeight)
                End If
            Next

            Dim sidePanels As New List(Of Control) From {FlowLayoutPanel1, panelButton2, FlowLayoutPanel3, FlowLayoutPanel6, FlowLayoutPanel5}
            Dim yPos As Integer = topStart + spacing
            For idx As Integer = 0 To menuButtons.Count - 1
                Dim b = menuButtons(idx)
                If b Is Nothing Then Continue For
                Dim xPos As Integer = If(expanded, 10, 8)
                b.Location = New Point(xPos, yPos)
                yPos += btnHeight + spacing

                If idx < sidePanels.Count Then
                    Dim sp = sidePanels(idx)
                    If sp IsNot Nothing Then
                        sp.Top = b.Top
                        sp.Height = btnHeight
                        sp.Left = -2
                        sp.Width = 15
                        sp.Visible = True
                    End If
                End If
            Next

            If btnLogOut IsNot Nothing Then
                btnLogOut.Width = If(expanded, Panel1.Width - 20, minWitdh - 10)
                btnLogOut.Left = If(expanded, 13, 8)
                btnLogOut.BringToFront()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnProducts.MouseEnter
        panelButton2.Size = New Size(25, 58)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnProducts.MouseLeave
        panelButton2.Size = New Size(15, 58)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        If Not UsuarioActual.HasRole("Root") Then
            MsgBox("No tiene permiso para acceder a Usuarios. Consulte con el administrador.")
            Return
        End If
        OpenChildForm(New Usuarios())
    End Sub

    Private Sub btnMovement_Click(sender As Object, e As EventArgs) Handles btnMovement.Click
        If Not UsuarioActual.HasAnyRole("Root", "Ventas") Then
            MsgBox("No tiene permiso para acceder a Movimientos.")
            Return
        End If
        OpenChildForm(New Movimientos())
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        If UsuarioActual.HasAnyRole("Ventas", "Root", "Depósito") Then
            OpenChildForm(New Productos())
        Else
            MsgBox("No tiene permiso para acceder a Productos.")
        End If
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        If UsuarioActual.HasAnyRole("Root", "Depósito") Then
            OpenChildForm(New proveedores())
        Else
            MsgBox("No tiene permiso para acceder a Proveedores.")
        End If
    End Sub

    Private Sub btnCategorys_Click(sender As Object, e As EventArgs) Handles btnCategorys.Click
        If UsuarioActual.HasAnyRole("Root", "Depósito", "Ventas") Then
            OpenChildForm(New Categorias())
        Else
            MsgBox("No tiene permiso para acceder a Categorías.")
        End If
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        UsuarioActual.Id = 0
        UsuarioActual.Nombre = ""
        UsuarioActual.Rol = ""
        UsuarioActual.IsLoggedIn = False
        UsuarioActual.SidebarExpanded = True

        Dim lf As New LoginForm()
        lf.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class