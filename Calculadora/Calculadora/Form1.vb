Public Class Calculadora
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        txtTotal.Text = Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text)
    End Sub

    Private Sub btnDiminui_Click(sender As Object, e As EventArgs) Handles btnDiminui.Click
        txtTotal.Text = Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text)
    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles btnMultiplica.Click
        txtTotal.Text = Convert.ToInt32(txtNumero1.Text) * Convert.ToInt32(txtNumero2.Text)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtTotal.Text = Convert.ToInt32(txtNumero1.Text) / Convert.ToInt32(txtNumero2.Text)
    End Sub
End Class
