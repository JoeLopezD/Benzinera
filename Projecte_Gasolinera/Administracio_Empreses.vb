Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Administracio_Empreses
    Private conexion As String = "Data Source=DESKTOP-TPUG9J9\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim clientCVV, clientCardCNumber, clientName, clientExpDate, typeOfOil As String
    Dim inputValor As String
    Dim ValorModificar As String
    Dim translateVarModificarorAfegir As String
    Dim LabelValue As String
    Private Sub Administracio_Empreses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LabelValue = "Modificar" Then
            Label11.Text = "Modificar Empresa"
            Button1.Text = "Modificar"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim ds As New DataSet
            Dim adaptador As New SqlDataAdapter("select nom from empresa_recarega", cn)
            adaptador.Fill(ds, "dades")

            For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
                If ds.Tables("Dades").Rows(i).Item(0).Equals(Administracio.ComboBox1.Text) Then
                    inputValor = ds.Tables("Dades").Rows(i).Item(0)
                    TextBox1.Text = inputValor
                    '_________________________________________________________
                    'Dim varDipositId As Integer
                    'varDipositId = ds.Tables("Dades").Rows(i).Item(0)
                    'Form2.VendaTableAdapter.Insert(varDipositId, TextBox2.Text, Label12.Text, Label10.Text, True, Today)
                    'Form2.VendaTableAdapter.Fill(Form2.CarburantDataSet.venda)
                    '_________________________________________________________
                End If
            Next
        End If


    End Sub

    Public Function TranslateVarFunction(ByVal translateVar As String) As String
        If translateVar = "Modificar" Then
            LabelValue = "Modificar"
            Show()
        ElseIf translateVar = "Afegir"
            LabelValue = "Afegir"
            Show()
        End If

        Return LabelValue
    End Function

End Class