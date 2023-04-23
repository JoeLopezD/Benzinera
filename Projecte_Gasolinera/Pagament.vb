Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Pagament
    'El precio total está en la variable "preuCombustible" 
    'el total de litros está en la variable "totalLitres"
    'el tipo de gasolina en "typeOfOil"
    '
    '
    '
    Private conexion As String = "Data Source=DESKTOP-4GK2TOH\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim clientCVV, clientCardCNumber, clientName, clientExpDate, typeOfOil As String
    Dim totalLitres, preuCombustible, inputValor As String
    Private Sub Pagament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        preuCombustible = preuCombustible + "€"
        totalLitres = totalLitres + "L"

        Label10.Text = preuCombustible
        Label12.Text = totalLitres

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

        'Guardar datos en DB

        '

    End Sub
End Class