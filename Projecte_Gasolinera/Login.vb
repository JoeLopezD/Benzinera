Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    Private conexion As String = "Data Source=DESKTOP-TPUG9J9\SQLEXPRESS;Initial Catalog=carburant;Integrated Security=True"
    Dim varBBDD As String
    Dim emailorpassword As String
    Dim adminTrue As String

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

    Public Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        '____________________________________________________________________________________________


        Using hasher As MD5 = MD5.Create()

            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(TextBox2.Text))

            Dim sBuilder As New StringBuilder()

            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Dim zx As String = sBuilder.ToString()

            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                Dim ds As New DataSet
                Dim adaptador As New SqlDataAdapter("Select " + emailorpassword + " , contraseña from " + varBBDD, cn)
                adaptador.Fill(ds, "dades")

                For i As Integer = 0 To ds.Tables("dades").Rows.Count - 1
                    If ds.Tables("Dades").Rows(i).Item(0).Equals(TextBox1.Text) Then
                        If ds.Tables("Dades").Rows(i).Item(1).Equals(zx) Then
                            Administracio.Show()
                            Hide()
                            Dim loged As Boolean = True
                        Else
                            Label3.Visible = True
                            Label3.Text = "La Contraseña no es correcta"
                        End If
                    Else
                        Label3.Visible = True
                        Label3.Text = "El Usuari no es correcte"
                    End If
                Next
            Else
                Label3.Visible = True
                Label3.Text = "Els camps de Email i contraseña no poden estar buits"
            End If
        End Using

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Registre_admin.Show()
        adminTrue = "yes"
        Registre_admin.TranslateVarFunction(adminTrue)
        Enabled = False
        Hide()
    End Sub

End Class