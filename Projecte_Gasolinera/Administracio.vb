Public Class Administracio
    Private Sub Administracio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.comanda' Puede moverla o quitarla según sea necesario.
        Me.ComandaTableAdapter.Fill(Me.CarburantDataSet.comanda)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.diposit' Puede moverla o quitarla según sea necesario.
        Me.DipositTableAdapter.Fill(Me.CarburantDataSet.diposit)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.venda' Puede moverla o quitarla según sea necesario.
        Me.VendaTableAdapter.Fill(Me.CarburantDataSet.venda)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.empresa_recarega' Puede moverla o quitarla según sea necesario.
        Me.Empresa_recaregaTableAdapter.Fill(Me.CarburantDataSet.empresa_recarega)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.login_client' Puede moverla o quitarla según sea necesario.
        Me.Login_clientTableAdapter.Fill(Me.CarburantDataSet.login_client)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.login_admin' Puede moverla o quitarla según sea necesario.
        Me.Login_adminTableAdapter.Fill(Me.CarburantDataSet.login_admin)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim empresaId = ComboBox1.SelectedValue.ToString
        Me.Empresa_recaregaTableAdapter.DeleteQuery(empresaId)
        Me.Empresa_recaregaTableAdapter.Fill(Me.CarburantDataSet.empresa_recarega)
        DataGridView4.DataSource = Me.CarburantDataSet.empresa_recarega
    End Sub
End Class