Public Class Form1
    Private minWitdh As Integer = 85
    Private maxWidth As Integer = 300
    Private expand As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Width = minWitdh
        Timer1.Interval = 15

        For Each ctrl As Control In Panel1.Controls
            AddHandler ctrl.MouseEnter, AddressOf Panel1_MouseEnter
            AddHandler ctrl.MouseLeave, AddressOf Panel1_MouseLeave
        Next
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        expand = True
        Timer1.Start()
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        If Not Panel1.ClientRectangle.Contains(Panel1.PointToClient(Cursor.Position)) Then
            expand = False
            Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
End Class


