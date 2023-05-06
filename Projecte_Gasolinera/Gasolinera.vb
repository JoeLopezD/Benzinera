Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Gasolinera

    Private conexion As String = "Data Source=DESKTOP-TPUG9J9\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim varBBDDTypeOilReturn As String
    Dim emailorpassword As String

    Dim adminTrue As String
    Dim buttonClicResult As Integer
    Dim typeOfOil As String

    'Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
    '    Registre_admin.Show()
    '    adminTrue = "no"
    '    Registre_admin.TranslateVarFunction(adminTrue)
    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim buttonClic As Button = DirectCast(sender, Button)
        buttonClicResult = buttonClic.Tag

        If Button1.Tag = buttonClicResult Then
            typeOfOil = "95"
            'DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            'DetailOil.Show()
        ElseIf Button2.Tag = buttonClicResult
            typeOfOil = "98"
            'DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            'DetailOil.Show()
        ElseIf Button3.Tag = buttonClicResult
            typeOfOil = "diesel"
            'DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            'DetailOil.Show()
        ElseIf Button4.Tag = buttonClicResult
            typeOfOil = "dieselPlus"
            'DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            'DetailOil.Show()
        ElseIf Button5.Tag = buttonClicResult
            typeOfOil = "Electric"
            'DetailOil.TranslateVarFunctionTypeOil(typeOfOil)
            'DetailOil.Show()
        End If


        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim ds As New DataSet
        Dim adaptador As New SqlDataAdapter("Select actual, nom_carburant from diposit", cn)
        adaptador.Fill(ds, "dades")
        For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
            If ds.Tables("Dades").Rows(i).Item(1).Equals(typeOfOil) Then
                DetailOil.Label1.Tag = ds.Tables("Dades").Rows(i).Item(1)
                DetailOil.Show()
                DetailOil.MyVerticalProgessBar1.Value = ds.Tables("Dades").Rows(i).Item(0)
            End If
        Next


    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

End Class