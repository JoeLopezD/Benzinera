Public Class Form1
    Dim adminTrue As String
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Visible = False
        adminTrue = "yes"
        Login.TranslateVarFunction(adminTrue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gasolinera.Show()
        Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
