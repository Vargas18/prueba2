Public Class colores
    Private Sub Btnrojo_Click(sender As Object, e As EventArgs) Handles Btnrojo.Click
        txtcolores.BackColor = Color.Red
    End Sub

    Private Sub btnverde_Click(sender As Object, e As EventArgs) Handles btnverde.Click
        txtcolores.BackColor = Color.Green
    End Sub

    Private Sub btnazul_Click(sender As Object, e As EventArgs) Handles btnazul.Click
        txtcolores.BackColor = Color.Blue
    End Sub

    Private Sub btnmorado_Click(sender As Object, e As EventArgs) Handles btnmorado.Click
        txtcolores.BackColor = Color.Purple
    End Sub

    Private Sub btbamarillo_Click(sender As Object, e As EventArgs) Handles btbamarillo.Click
        txtcolores.BackColor = Color.Yellow
    End Sub
End Class
