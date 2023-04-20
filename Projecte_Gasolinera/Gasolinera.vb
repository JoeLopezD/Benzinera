Public Class Gasolinera
    Dim adminTrue As String
    Dim buttonClicResult As Integer
    Dim typeOfOil As String

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Registre_admin.Show()
        adminTrue = "no"
        Registre_admin.TranslateVarFunction(adminTrue)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim buttonClic As Button = DirectCast(sender, Button)
        buttonClicResult = buttonClic.Tag

        If Button1.Tag = buttonClicResult Then
            typeOfOil = "95"
            DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            DetailOil.Show()
        ElseIf Button2.Tag = buttonClicResult
            typeOfOil = "98"
            DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            DetailOil.Show()
        ElseIf Button3.Tag = buttonClicResult
            typeOfOil = "Diesel"
            DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            DetailOil.Show()
        ElseIf Button4.Tag = buttonClicResult
            typeOfOil = "DieselPlus"
            DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            DetailOil.Show()
        ElseIf Button5.Tag = buttonClicResult
            typeOfOil = "Electric"
            DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            DetailOil.Show()
        End If
    End Sub

End Class