Public Class DetailOil
    Dim buttonClicResult As Integer
    Dim precio, lastCharacter As String

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim texto As String
        texto = TextBox3.Text.Trim() 'eliminar espacios en blanco al principio y al final del texto

        If texto.EndsWith(",") Or Val(texto) = 0 Then 'verificar si el texto termina en "," o su valor total es 0
            MsgBox("Sius plau, introdueix un valor valid o que no acabi amb ','")
        Else
            'el texto no termina en "," y su valor total no es 0, ahora se verifica que no tenga como valor total solo ceros.
            Dim valorNumerico As Double = Val(texto)
            If Not (texto Like "0*") Then
                Pagament.Show()
                Enabled = True
                Hide()
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Gasolinera.Show()
        Close()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button12.Click, Button14.Click
        Dim buttonClic As Button = DirectCast(sender, Button)
        buttonClicResult = buttonClic.Tag
        Dim inputText As String = TextBox3.Text
        precio = inputText.Substring(0, inputText.Length - 1)
        If precio = "0" Then
            precio = buttonClicResult
            If precio <> 0 Then
                TextBox3.Text = precio + "€"
            End If
        Else
            Select Case buttonClicResult
                Case 1
                    precio = precio & "1"
                    TextBox3.Text = precio + "€"
                Case 2
                    precio = precio & "2"
                    TextBox3.Text = precio + "€"
                Case 3
                    precio = precio & "3"
                    TextBox3.Text = precio + "€"
                Case 4
                    precio = precio & "4"
                    TextBox3.Text = precio + "€"
                Case 5
                    precio = precio & "5"
                    TextBox3.Text = precio + "€"
                Case 6
                    precio = precio & "6"
                    TextBox3.Text = precio + "€"
                Case 7
                    precio = precio & "7"
                    TextBox3.Text = precio + "€"
                Case 8
                    precio = precio & "8"
                    TextBox3.Text = precio + "€"
                Case 9
                    precio = precio & "9"
                    TextBox3.Text = precio + "€"
                Case 0
                    TextBox3.Text = precio + "0€"
                Case 99
                    TextBox3.Text = precio + ",€"
            End Select
        End If

    End Sub

    Private Sub DetailOil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
    End Sub
End Class