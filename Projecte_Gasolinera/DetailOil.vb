Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class DetailOil
    Private conexion As String = "Data Source=DESKTOP-TPUG9J9\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim varBBDDTypeOil As String
    Dim varBBDDTypeOilReturn As String
    Dim emailorpassword As String


    Private Sub DetailOil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim ds As New DataSet
        Dim adaptador As New SqlDataAdapter("Select actual from diposit where  nom_carburant =" + varBBDDTypeOilReturn, cn)
        adaptador.Fill(ds, "dades")
        For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
            MyVerticalProgessBar1.Value = ds.Tables("Dades").Rows(i).Item(0)
        Next

    End Sub

    Public Function TranslateVarFunctionTypeOil(ByVal translateVarTypeOil As String) As String
        If translateVarTypeOil = "95" Then
            varBBDDTypeOilReturn = "95"
        ElseIf translateVarTypeOil = "98"
            varBBDDTypeOilReturn = "98"
        ElseIf translateVarTypeOil = "Diesel"
            varBBDDTypeOilReturn = "Diesel"
        ElseIf translateVarTypeOil = "DieselPlus"
            varBBDDTypeOilReturn = "DieselPlus"
        End If

        Return varBBDDTypeOil
    End Function

End Class