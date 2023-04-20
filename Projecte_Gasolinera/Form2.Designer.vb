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
        Me.Login_adminTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.login_adminTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LoginclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_clientTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.login_clientTableAdapter()
        Me.LoginclientidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginadminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarburantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginadminidDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginadminBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(79, 70)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'Login_adminTableAdapter
        '
        Me.Login_adminTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(445, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginclientidDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.LoginclientBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(79, 219)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(332, 129)
        Me.DataGridView2.TabIndex = 2
        '
        'LoginclientBindingSource
        '
        Me.LoginclientBindingSource.DataMember = "login_client"
        Me.LoginclientBindingSource.DataSource = Me.CarburantDataSet
        '
        'Login_clientTableAdapter
        '
        Me.Login_clientTableAdapter.ClearBeforeFill = True
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 509)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginadminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarburantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LoginclientBindingSource As BindingSource
    Friend WithEvents Login_clientTableAdapter As carburantDataSetTableAdapters.login_clientTableAdapter
    Friend WithEvents LoginclientidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
