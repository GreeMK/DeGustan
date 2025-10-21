Imports MySql.Data.MySqlClient

Public Class Principal
    Private minWitdh As Integer = 85    ' Ancho minimo del panel lateral
    Private maxWidth As Integer = 300   ' Ancho maximo del panel lateral
    Private expand As Boolean = False
    Private currentForm As Form = Nothing
    Private Sub OpenChildForm(childForm As Form)    ' Sub para abrir formularios hijos dentro del panel

        If currentForm IsNot Nothing Then currentForm.Close()   ' Compruebo que no haya otro formulario abierto y si lo hay lo cierro
        currentForm = childForm ' Asigno el formulario actual al formulario hijo que se va a abrir
        childForm.TopLevel = False      ' Indico que el formulario hijo no es un formulario de nivel superior
        childForm.FormBorderStyle = FormBorderStyle.None ' Indico que el formulario hijo no tiene bordes
        childForm.Dock = DockStyle.Fill ' Indico que el formulario hijo se ajuste al tamaño del panel
        PanelContainer.Controls.Add(childForm)  ' Añado el formulario hijo al panel
        PanelContainer.Tag = childForm  ' Asigno el formulario hijo al tag del panel
        childForm.BringToFront()    ' Llevo el formulario hijo al frente
        childForm.Show()    ' Muestro el formulario hijo

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Width = minWitdh         ' Indico que el ancho inicial del panel es el minimo
        Timer1.Interval = 15

        For Each ctrl As Control In Panel1.Controls             ' Recorro todos los controles del panel lateral y los agrego dentro de los eventos MouseEnter y MouseLeave
            AddHandler ctrl.MouseEnter, AddressOf Panel1_MouseEnter
            AddHandler ctrl.MouseLeave, AddressOf Panel1_MouseLeave
        Next
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter   ' Cuando el mouse entra el panel empieza a expandirse
        expand = True
        Timer1.Start()
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave   ' Cuando el mouse sale del panel empieza a contraerse
        If Not Panel1.ClientRectangle.Contains(Panel1.PointToClient(Cursor.Position)) Then
            expand = False
            Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick   ' Cada vez que el timer hace tick se expande o contrae el panel
        If expand AndAlso Panel1.Width < maxWidth Then
            Panel1.Width += 10
        ElseIf Not expand AndAlso Panel1.Width > minWitdh Then
            Panel1.Width -= 10
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnProducts.MouseEnter
        panelButton2.Size = New Size(25, 58)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnProducts.MouseLeave
        panelButton2.Size = New Size(15, 58)
    End Sub

    Private Sub btnMovement_Click(sender As Object, e As EventArgs) Handles btnMovement.Click
        OpenChildForm(New Movimientos())
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        OpenChildForm(New Productos())
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        OpenChildForm(New proveedores())
    End Sub

    Private Sub btnCategorys_Click(sender As Object, e As EventArgs) Handles btnCategorys.Click
        OpenChildForm(New Categorias())
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        OpenChildForm(New Usuarios())
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmlogin.Show()
    End Sub
End Class


