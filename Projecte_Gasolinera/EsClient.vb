﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class EsClient
    Private conexion As String = "Data Source=DESKTOP-TPUG9J9\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim varBBDDTypeOilReturn As String
    Dim emailorpassword As String
    Dim roundedEuros As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim ds As New DataSet
        Dim adaptador As New SqlDataAdapter("Select dni from login_client", cn)
        adaptador.Fill(ds, "dades")
        For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
            If ds.Tables("Dades").Rows(i).Item(0).Equals(TextBox1.Text) Then
                Pagament.Label10.Text = Pagament.Label10.Text - (0.05 * Pagament.Label12.Text)
                roundedEuros = Pagament.Label10.Text
                Dim dosDigitsPreu = roundedEuros
                Dim roundedNumPreu As Double = Math.Round(dosDigitsPreu, 2, MidpointRounding.ToEven)
                Pagament.Label10.Text = roundedNumPreu
                Close()
            End If
        Next
    End Sub
End Class