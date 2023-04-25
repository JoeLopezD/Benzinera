Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.diposit' Puede moverla o quitarla según sea necesario.
        Me.DipositTableAdapter.Fill(Me.CarburantDataSet.diposit)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.venda' Puede moverla o quitarla según sea necesario.
        Me.VendaTableAdapter.Fill(Me.CarburantDataSet.venda)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.login_client' Puede moverla o quitarla según sea necesario.
        Me.Login_clientTableAdapter.Fill(Me.CarburantDataSet.login_client)
        'TODO: esta línea de código carga datos en la tabla 'CarburantDataSet.login_admin' Puede moverla o quitarla según sea necesario.
        Me.Login_adminTableAdapter.Fill(Me.CarburantDataSet.login_admin)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class