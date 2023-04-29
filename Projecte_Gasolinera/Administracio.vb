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
            'Administracio_Empreses.Show()
        End If

        Return LabelValue
    End Function

End Class