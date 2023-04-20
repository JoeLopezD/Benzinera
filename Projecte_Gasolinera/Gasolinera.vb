Public Class Gasolinera
    Dim adminTrue As String
    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Registre_admin.Show()
        adminTrue = "no"
        Registre_admin.TranslateVarFunction(adminTrue)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click

    End Sub
End Class