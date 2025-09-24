Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Principal.Visible = False


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAcept_Click(sender As Object, e As EventArgs) Handles btnAcept.Click
        If tbUser.Text = "" Or tbPasswd.Text = "" Then
            MessageBox.Show("Debe ingresar un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUser.Focus()
            Exit Sub
        End If

        ' controlo usuario "root"
        If tbUser.Text = "root" And tbPasswd.Text = "toor" Then
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUser.Focus()
            Exit Sub
        End If
    End Sub
End Class