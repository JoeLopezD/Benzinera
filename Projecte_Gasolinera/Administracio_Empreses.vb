Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Administracio_Empreses
    Private conexion As String = "Data Source=DESKTOP-4GK2TOH\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim clientCVV, clientCardCNumber, clientName, clientExpDate, typeOfOil As String
    Dim inputValor1, inputValor2, inputValor3, inputValor4, inputValor5, inputValor6, inputValor7, inputValor8, inputValor9, inputValor10 As String
    Dim ValorModificar As String
    Dim translateVarModificarorAfegir As String
    Dim LabelValue As String
    Dim inputValor11 As Integer
    Private Sub Administracio_Empreses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LabelValue = "Modificar" Then
            Label11.Text = "Modificar Empresa"
            Button1.Text = "Modificar"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim ds As New DataSet
            Dim adaptador As New SqlDataAdapter("select nom,email,telef,adreça,cp,municipi,comarca,provincia,comunitat,pais, empresa_id from empresa_recarega", cn)
            adaptador.Fill(ds, "dades")

            For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
                If ds.Tables("Dades").Rows(i).Item(0).Equals(Administracio.ComboBox1.Text) Then
                    inputValor1 = ds.Tables("Dades").Rows(i).Item(0)
                    inputValor2 = ds.Tables("Dades").Rows(i).Item(1)
                    inputValor3 = ds.Tables("Dades").Rows(i).Item(2)
                    inputValor4 = ds.Tables("Dades").Rows(i).Item(3)
                    inputValor5 = ds.Tables("Dades").Rows(i).Item(4)
                    inputValor6 = ds.Tables("Dades").Rows(i).Item(5)
                    inputValor7 = ds.Tables("Dades").Rows(i).Item(6)
                    inputValor8 = ds.Tables("Dades").Rows(i).Item(7)
                    inputValor9 = ds.Tables("Dades").Rows(i).Item(8)
                    inputValor10 = ds.Tables("Dades").Rows(i).Item(9)
                    inputValor11 = ds.Tables("Dades").Rows(i).Item(10)
                    TextBox1.Text = inputValor1
                    TextBox2.Text = inputValor2
                    TextBox3.Text = inputValor3
                    TextBox4.Text = inputValor4
                    TextBox5.Text = inputValor5
                    TextBox6.Text = inputValor6
                    TextBox7.Text = inputValor7
                    TextBox8.Text = inputValor8
                    TextBox9.Text = inputValor9
                    TextBox10.Text = inputValor10

                End If
            Next
        End If


    End Sub

    Public Function TranslateVarFunction(ByVal translateVar As String) As String
        If translateVar = "Modificar" Then
            LabelValue = "Modificar"
            Button1.Visible = True
            Button2.Visible = False
            Show()
        ElseIf translateVar = "Afegir"
            LabelValue = "Afegir"
            Button1.Visible = False
            Button2.Visible = True
            Show()
        End If

        Return LabelValue
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '_________________________________________________________
        Administracio.Empresa_recaregaTableAdapter.UpdateTest(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, inputValor11)
        Administracio.Empresa_recaregaTableAdapter.Fill(Administracio.CarburantDataSet.empresa_recarega)
        Administracio.DataGridView4.DataSource = Administracio.CarburantDataSet.empresa_recarega
        Me.Close()
        '_________________________________________________________
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '_________________________________________________________
        Administracio.Empresa_recaregaTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text)
        Administracio.Empresa_recaregaTableAdapter.Fill(Administracio.CarburantDataSet.empresa_recarega)
        '_________________________________________________________
    End Sub

End Class