Public Class DetailOil

    Private Sub DetailOil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Pagament.Show()
        Enabled = True
        Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Gasolinera.Show()
        Close()
    End Sub
End Class