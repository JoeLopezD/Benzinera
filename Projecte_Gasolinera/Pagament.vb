Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Pagament
    Private conexion As String = "Data Source=DESKTOP-TPUG9J9\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim clientCVV, clientCardCNumber, clientName, clientExpDate, typeOfOil As String
    Dim inputValor As String

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        EsClient.Show()
    End Sub

    Dim totalLitres As Double
    Dim preuCombustible As Double
    Dim totalActual As Double
    Private Sub Pagament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DetailOil.Enabled = True
        Label7.Text = Label7.Tag
        Label8.Text = Label8.Tag
        inputValor = Label11.Tag
        If Label9.Tag = "litres" Then
            RadioButton4.Checked = True
            totalLitres = inputValor
            preuCombustible = totalLitres * Label8.Tag


        Else
            RadioButton2.Checked = True
            preuCombustible = inputValor
            totalLitres = preuCombustible / Label8.Tag
        End If

        Dim dosDigitsPreu = preuCombustible
        Dim roundedNumPreu As Double = Math.Round(dosDigitsPreu, 2, MidpointRounding.ToEven)
        Label10.Text = roundedNumPreu

        Dim num As Double = totalLitres
        Dim roundedNum As Double = Math.Round(num, 2, MidpointRounding.ToEven)
        Label12.Text = roundedNum

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clientName = TextBox1.Text
        clientCardCNumber = TextBox2.Text
        clientExpDate = TextBox4.Text
        clientCVV = TextBox3.Text

        If TextBox2.TextLength < 16 Then
            Label14.Text = ""
            Label14.Text = "El Nº de la tarjeta no es correcte"
        End If
        If TextBox3.TextLength < 3 Then
            Label14.Text = ""
            Label14.Text = "El Nº del Codi CVV no es correcte"
        End If
        If TextBox1.Text = "" Then
            Label14.Text = ""
            Label14.Text = "El Nom no es correcte"
        End If
        If TextBox4.Text = "" Then
            Label14.Text = ""
            Label14.Text = "La Data no es correcta"
        End If
        If TextBox2.TextLength = 16 And TextBox3.TextLength = 3 Then
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim ds As New DataSet
            Dim adaptador As New SqlDataAdapter("select diposit_id, actual, nom_carburant from diposit", cn)
            adaptador.Fill(ds, "dades")
            For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
                If ds.Tables("Dades").Rows(i).Item(2).Equals(Label7.Text) Then
                    totalActual = ds.Tables("Dades").Rows(i).Item(1)
                    totalActual = totalActual - Label12.Text
                    Form2.DipositTableAdapter.UpdateQuery(totalActual, Label7.Text)
                    '_________________________________________________________
                    Dim varDipositId As Integer
                    varDipositId = ds.Tables("Dades").Rows(i).Item(0)
                    Form2.VendaTableAdapter.Insert(varDipositId, TextBox2.Text, Label12.Text, Label10.Text, True, Today)
                    Form2.VendaTableAdapter.Fill(Form2.CarburantDataSet.venda)

                    '_________________________________________________________
                    Close()
                End If
            Next
        End If

    End Sub
End Class