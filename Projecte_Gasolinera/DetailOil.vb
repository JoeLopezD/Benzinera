Public Class DetailOil
    Dim buttonClicResult As Integer
    Dim precio As String

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Pagament.Show()
        Enabled = True
        Hide()
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
            TextBox3.Text = precio + "€"
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
End Class