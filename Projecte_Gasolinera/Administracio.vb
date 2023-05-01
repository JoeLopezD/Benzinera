Public Class Administracio
    Dim translateVarModificarorAfegir As String
    Dim LabelValue As String

    Private Sub Administracio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComandaTableAdapter.Fill(Me.CarburantDataSet.comanda)
        Me.DipositTableAdapter.Fill(Me.CarburantDataSet.diposit)
        Me.VendaTableAdapter.Fill(Me.CarburantDataSet.venda)
        Me.Empresa_recaregaTableAdapter.Fill(Me.CarburantDataSet.empresa_recarega)
        Me.Login_clientTableAdapter.Fill(Me.CarburantDataSet.login_client)
        Me.Login_adminTableAdapter.Fill(Me.CarburantDataSet.login_admin)

        Label1.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim empresaId = ComboBox1.SelectedValue.ToString
        Me.Empresa_recaregaTableAdapter.DeleteQuery(empresaId)
        Me.Empresa_recaregaTableAdapter.Fill(Me.CarburantDataSet.empresa_recarega)
        DataGridView4.DataSource = Me.CarburantDataSet.empresa_recarega
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        translateVarModificarorAfegir = "no"
        'Administracio_Empreses.TranslateVarFunction(translateVarModificarorAfegir)
        TranslateVarFunction(translateVarModificarorAfegir)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        translateVarModificarorAfegir = "yes"
        'Administracio_Empreses.TranslateVarFunction(translateVarModificarorAfegir)
        TranslateVarFunction(translateVarModificarorAfegir)
    End Sub



    Public Function TranslateVarFunction(ByVal translateVar As String) As String
        If translateVarModificarorAfegir = "yes" Then
            LabelValue = "Modificar"
            Administracio_Empreses.TranslateVarFunction(LabelValue)
            'Administracio_Empreses.Show()
        ElseIf translateVarModificarorAfegir = "no"
            LabelValue = "Afegir"
            Administracio_Empreses.TranslateVarFunction(LabelValue)
            'Administracio_Empreses.Show()
        End If

        Return LabelValue
    End Function

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label1.Visible = True
        TextBox1.Visible = True
        Button1.Visible = True
        Dim empresaId = ComboBox2.SelectedValue.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim depositId = ComboBox2.SelectedValue
        Me.DipositTableAdapter.UpdateDiposit(TextBox1.Text, depositId)
        Me.DipositTableAdapter.Fill(Me.CarburantDataSet.diposit)
        Me.DataGridView5.DataSource = Me.CarburantDataSet.diposit

    End Sub

End Class