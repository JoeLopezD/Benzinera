Imports System.Security.Cryptography
Imports System.Text
Public Class Registre_admin
    Dim varBBDD As String
    Dim emailorpassword As String

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Login.Show()
        Login.Enabled = True
        Enabled = False
        Hide()
    End Sub

    Public Function TranslateVarFunction(ByVal translateVar As String) As String
        If translateVar = "yes" Then
            varBBDD = "login_admin"
            emailorpassword = "email"
        ElseIf translateVar = "no"
            varBBDD = "login_client"
            emailorpassword = "dni"
        End If

        Return varBBDD
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using hasher As MD5 = MD5.Create()

            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(TextBox2.Text))

            Dim sBuilder As New StringBuilder()

            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Dim zx As String = sBuilder.ToString()

            If varBBDD = "login_admin" Then
                Form2.Login_adminTableAdapter.Insert(TextBox1.Text, zx, "admin")
                Form2.Login_adminTableAdapter.Fill(Form2.CarburantDataSet.login_admin)
            ElseIf varBBDD = "login_client"
                Form2.Login_clientTableAdapter.Insert(TextBox1.Text, zx)
                Form2.Login_clientTableAdapter.Fill(Form2.CarburantDataSet.login_client)
            End If

        End Using
    End Sub

    Private Sub Registre_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class