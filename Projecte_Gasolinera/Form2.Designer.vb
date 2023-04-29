<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LoginadminidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginadminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarburantDataSet = New Projecte_Gasolinera.carburantDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LoginclientidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.VendaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DipositidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TargetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacitatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EurosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagatDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatavendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_adminTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.login_adminTableAdapter()
        Me.Login_clientTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.login_clientTableAdapter()
        Me.VendaTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.vendaTableAdapter()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DipositBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DipositTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.dipositTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginadminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarburantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DipositBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginadminidDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginadminBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(103, 70)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(332, 122)
        Me.DataGridView1.TabIndex = 0
        '
        'LoginadminidDataGridViewTextBoxColumn
        '
        Me.LoginadminidDataGridViewTextBoxColumn.DataPropertyName = "login_admin_id"
        Me.LoginadminidDataGridViewTextBoxColumn.HeaderText = "login_admin_id"
        Me.LoginadminidDataGridViewTextBoxColumn.Name = "LoginadminidDataGridViewTextBoxColumn"
        Me.LoginadminidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        '
        'RolDataGridViewTextBoxColumn
        '
        Me.RolDataGridViewTextBoxColumn.DataPropertyName = "rol"
        Me.RolDataGridViewTextBoxColumn.HeaderText = "rol"
        Me.RolDataGridViewTextBoxColumn.Name = "RolDataGridViewTextBoxColumn"
        '
        'LoginadminBindingSource
        '
        Me.LoginadminBindingSource.DataMember = "login_admin"
        Me.LoginadminBindingSource.DataSource = Me.CarburantDataSet
        '
        'CarburantDataSet
        '
        Me.CarburantDataSet.DataSetName = "carburantDataSet"
        Me.CarburantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginclientidDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.LoginclientBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(103, 209)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(332, 129)
        Me.DataGridView2.TabIndex = 2
        '
        'LoginclientidDataGridViewTextBoxColumn
        '
        Me.LoginclientidDataGridViewTextBoxColumn.DataPropertyName = "login_client_id"
        Me.LoginclientidDataGridViewTextBoxColumn.HeaderText = "login_client_id"
        Me.LoginclientidDataGridViewTextBoxColumn.Name = "LoginclientidDataGridViewTextBoxColumn"
        Me.LoginclientidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        '
        'ContraseñaDataGridViewTextBoxColumn1
        '
        Me.ContraseñaDataGridViewTextBoxColumn1.DataPropertyName = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn1.HeaderText = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn1.Name = "ContraseñaDataGridViewTextBoxColumn1"
        '
        'LoginclientBindingSource
        '
        Me.LoginclientBindingSource.DataMember = "login_client"
        Me.LoginclientBindingSource.DataSource = Me.CarburantDataSet
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendaidDataGridViewTextBoxColumn, Me.DipositidDataGridViewTextBoxColumn, Me.TargetaDataGridViewTextBoxColumn, Me.CapacitatDataGridViewTextBoxColumn, Me.EurosDataGridViewTextBoxColumn, Me.PagatDataGridViewCheckBoxColumn, Me.DatavendaDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.VendaBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(473, 70)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(332, 122)
        Me.DataGridView3.TabIndex = 3
        '
        'VendaidDataGridViewTextBoxColumn
        '
        Me.VendaidDataGridViewTextBoxColumn.DataPropertyName = "venda_id"
        Me.VendaidDataGridViewTextBoxColumn.HeaderText = "venda_id"
        Me.VendaidDataGridViewTextBoxColumn.Name = "VendaidDataGridViewTextBoxColumn"
        Me.VendaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DipositidDataGridViewTextBoxColumn
        '
        Me.DipositidDataGridViewTextBoxColumn.DataPropertyName = "diposit_id"
        Me.DipositidDataGridViewTextBoxColumn.HeaderText = "diposit_id"
        Me.DipositidDataGridViewTextBoxColumn.Name = "DipositidDataGridViewTextBoxColumn"
        '
        'TargetaDataGridViewTextBoxColumn
        '
        Me.TargetaDataGridViewTextBoxColumn.DataPropertyName = "targeta"
        Me.TargetaDataGridViewTextBoxColumn.HeaderText = "targeta"
        Me.TargetaDataGridViewTextBoxColumn.Name = "TargetaDataGridViewTextBoxColumn"
        '
        'CapacitatDataGridViewTextBoxColumn
        '
        Me.CapacitatDataGridViewTextBoxColumn.DataPropertyName = "capacitat"
        Me.CapacitatDataGridViewTextBoxColumn.HeaderText = "capacitat"
        Me.CapacitatDataGridViewTextBoxColumn.Name = "CapacitatDataGridViewTextBoxColumn"
        '
        'EurosDataGridViewTextBoxColumn
        '
        Me.EurosDataGridViewTextBoxColumn.DataPropertyName = "euros"
        Me.EurosDataGridViewTextBoxColumn.HeaderText = "euros"
        Me.EurosDataGridViewTextBoxColumn.Name = "EurosDataGridViewTextBoxColumn"
        '
        'PagatDataGridViewCheckBoxColumn
        '
        Me.PagatDataGridViewCheckBoxColumn.DataPropertyName = "pagat"
        Me.PagatDataGridViewCheckBoxColumn.HeaderText = "pagat"
        Me.PagatDataGridViewCheckBoxColumn.Name = "PagatDataGridViewCheckBoxColumn"
        '
        'DatavendaDataGridViewTextBoxColumn
        '
        Me.DatavendaDataGridViewTextBoxColumn.DataPropertyName = "data_venda"
        Me.DatavendaDataGridViewTextBoxColumn.HeaderText = "data_venda"
        Me.DatavendaDataGridViewTextBoxColumn.Name = "DatavendaDataGridViewTextBoxColumn"
        '
        'VendaBindingSource
        '
        Me.VendaBindingSource.DataMember = "venda"
        Me.VendaBindingSource.DataSource = Me.CarburantDataSet
        '
        'Login_adminTableAdapter
        '
        Me.Login_adminTableAdapter.ClearBeforeFill = True
        '
        'Login_clientTableAdapter
        '
        Me.Login_clientTableAdapter.ClearBeforeFill = True
        '
        'VendaTableAdapter
        '
        Me.VendaTableAdapter.ClearBeforeFill = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView4.DataSource = Me.DipositBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(473, 216)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(332, 122)
        Me.DataGridView4.TabIndex = 4
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "diposit_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "diposit_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "euros"
        Me.DataGridViewTextBoxColumn5.HeaderText = "euros"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DipositBindingSource
        '
        Me.DipositBindingSource.DataMember = "diposit"
        Me.DipositBindingSource.DataSource = Me.CarburantDataSet
        '
        'DipositTableAdapter
        '
        Me.DipositTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 509)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginadminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarburantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DipositBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CarburantDataSet As carburantDataSet
    Friend WithEvents LoginadminBindingSource As BindingSource
    Friend WithEvents Login_adminTableAdapter As carburantDataSetTableAdapters.login_adminTableAdapter
    Friend WithEvents LoginadminidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LoginclientBindingSource As BindingSource
    Friend WithEvents Login_clientTableAdapter As carburantDataSetTableAdapters.login_clientTableAdapter
    Friend WithEvents LoginclientidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents VendaBindingSource As BindingSource
    Friend WithEvents VendaTableAdapter As carburantDataSetTableAdapters.vendaTableAdapter
    Friend WithEvents VendaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DipositidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TargetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacitatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EurosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagatDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DatavendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DipositBindingSource As BindingSource
    Friend WithEvents DipositTableAdapter As carburantDataSetTableAdapters.dipositTableAdapter
End Class
