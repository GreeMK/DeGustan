Imports DeGustan.ConnectorBD
Public Class Categorias
    ' Subrutina para limpiar los campos del formulario
    Private Sub clearForm()
        tbName.Text = ""
        tbDesc.Text = ""
        cmbActive.SelectedValue = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        clearForm()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbName.Text.Trim() = "" Or tbDesc.Text.Trim() = "" Then
            MsgBox("Por favor, complete todos los campos.", MsgBoxStyle.Exclamation, "Campos incompletos")
            Exit Sub
        End If


    End Sub
End Class