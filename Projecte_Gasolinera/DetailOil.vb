Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class DetailOil
    Private conexion As String = "Data Source=DESKTOP-4GK2TOH\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim buttonClicResult, inputValor As String
    Dim finalCharacter = "€", precio, lastCharacter, typeOfOil As String

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim texto As String
        texto = TextBox3.Text.Trim()

        If texto.EndsWith(",") Or Val(texto) = 0 Then
            MsgBox("Sius plau, introdueix un valor valid o que no acabi amb ','")
        Else
            If texto.EndsWith("L") Then
                texto = texto.Substring(0, texto.Length - 1)
            End If
            If texto <= 20000 Then
                Dim valorNumerico As Double = Val(texto)
                If Not (texto Like "0*") Then

                    Dim cn As New SqlConnection
                    cn.ConnectionString = conexion

                    Dim ds As New DataSet
                    Dim adaptador As New SqlDataAdapter("Select euros, nom_carburant from diposit", cn)
                    adaptador.Fill(ds, "dades")
                    For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
                        If ds.Tables("Dades").Rows(i).Item(1).Equals(typeOfOil) Then
                            Pagament.Label7.Tag = ds.Tables("Dades").Rows(i).Item(1)
                            Pagament.Label8.Tag = ds.Tables("Dades").Rows(i).Item(0)
                            If RadioButton1.Checked = True Then
                                Pagament.Label9.Tag = "euros"
                            Else
                                Pagament.Label9.Tag = "litres"
                            End If
                            inputValor = TextBox3.Text
                            Pagament.Label11.Tag = Mid(inputValor, 1, Len(inputValor) - 1)
                            Pagament.Show()
                            Close()
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Gasolinera.Show()
        'Close()
        TextBox3.Text = "0" + finalCharacter
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox3.Text = "0L"
            finalCharacter = "L"
        Else
            TextBox3.Text = "0€"
            finalCharacter = "€"
        End If
    End Sub

    Private Sub DetailOil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typeOfOil = Label1.Tag
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

        If typeOfOil = "95" Then
            PictureBox2.Visible = True
        ElseIf typeOfOil = "98"
            PictureBox3.Visible = True
        ElseIf typeOfOil = "diesel"
            PictureBox4.Visible = True
        ElseIf typeOfOil = "dieselPlus"
            PictureBox5.Visible = True
        ElseIf typeOfOil = "Electric"
            RadioButton2.Visible = False
            PictureBox6.Visible = True
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button12.Click, Button14.Click
        Dim buttonClic As Button = DirectCast(sender, Button)
        buttonClicResult = buttonClic.Tag
        Dim inputText As String = TextBox3.Text
        precio = inputText.Substring(0, inputText.Length - 1)
        If precio = "0" Then
            precio = buttonClicResult
            If precio = "," Then
                TextBox3.Text = "0," + finalCharacter
            Else
                If precio <> 0 Then
                    TextBox3.Text = precio + finalCharacter
                End If
            End If

        Else
            Select Case buttonClicResult
                Case 1
                    precio = precio & "1"
                    TextBox3.Text = precio + finalCharacter
                Case 2
                    precio = precio & "2"
                    TextBox3.Text = precio + finalCharacter
                Case 3
                    precio = precio & "3"
                    TextBox3.Text = precio + finalCharacter
                Case 4
                    precio = precio & "4"
                    TextBox3.Text = precio + finalCharacter
                Case 5
                    precio = precio & "5"
                    TextBox3.Text = precio + finalCharacter
                Case 6
                    precio = precio & "6"
                    TextBox3.Text = precio + finalCharacter
                Case 7
                    precio = precio & "7"
                    TextBox3.Text = precio + finalCharacter
                Case 8
                    precio = precio & "8"
                    TextBox3.Text = precio + finalCharacter
                Case 9
                    precio = precio & "9"
                    TextBox3.Text = precio + finalCharacter
                Case 0
                    TextBox3.Text = precio + "0" + finalCharacter
                Case ","
                    TextBox3.Text = precio + "," + finalCharacter
            End Select
        End If

    End Sub
End Class