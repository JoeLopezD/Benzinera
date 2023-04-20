Public Class Gasolinera
    Dim adminTrue As String
    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Registre_admin.Show()
        adminTrue = "no"
        Registre_admin.TranslateVarFunction(adminTrue)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class