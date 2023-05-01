<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracio
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LoginadminidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginadminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarburantDataSet = New Projecte_Gasolinera.carburantDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.LoginclientidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmpresarecaregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.EmpresaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdreçaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComunitatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VendaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DipositidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TargetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacitatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EurosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagatDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatavendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.DipositidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomcarburantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EurosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DipositBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.ComandaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DipositidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LitresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataenviatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComandaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_adminTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.login_adminTableAdapter()
        Me.Login_clientTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.login_clientTableAdapter()
        Me.Empresa_recaregaTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.empresa_recaregaTableAdapter()
        Me.VendaTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.vendaTableAdapter()
        Me.DipositBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DipositTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.dipositTableAdapter()
        Me.DipositBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComandaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComandaTableAdapter = New Projecte_Gasolinera.carburantDataSetTableAdapters.comandaTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginadminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarburantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.EmpresarecaregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DipositBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DipositBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DipositBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(999, 526)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(991, 500)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestió Client"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 497)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administració Gerent"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginadminidDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.LoginadminBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(51, 30)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(444, 437)
        Me.DataGridView2.TabIndex = 1
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DataGridView3)
        Me.GroupBox2.Location = New System.Drawing.Point(566, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 497)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Administració Client"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginclientidDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.LoginclientBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(52, 30)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(345, 437)
        Me.DataGridView3.TabIndex = 2
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.DataGridView4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(991, 500)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestió Espreses"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpresarecaregaBindingSource
        Me.ComboBox1.DisplayMember = "nom"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(161, 399)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "empresa_id"
        '
        'EmpresarecaregaBindingSource
        '
        Me.EmpresarecaregaBindingSource.DataMember = "empresa_recarega"
        Me.EmpresarecaregaBindingSource.DataSource = Me.CarburantDataSet
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(369, 399)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Eliminar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(288, 399)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Modificar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(470, 399)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Afegir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(631, 500)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(540, 500)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(450, 500)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpresaidDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn1, Me.TelefDataGridViewTextBoxColumn, Me.AdreçaDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.MunicipiDataGridViewTextBoxColumn, Me.ComarcaDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.ComunitatDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.EmpresarecaregaBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(988, 359)
        Me.DataGridView4.TabIndex = 3
        '
        'EmpresaidDataGridViewTextBoxColumn
        '
        Me.EmpresaidDataGridViewTextBoxColumn.DataPropertyName = "empresa_id"
        Me.EmpresaidDataGridViewTextBoxColumn.HeaderText = "empresa_id"
        Me.EmpresaidDataGridViewTextBoxColumn.Name = "EmpresaidDataGridViewTextBoxColumn"
        Me.EmpresaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn1
        '
        Me.EmailDataGridViewTextBoxColumn1.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn1.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn1.Name = "EmailDataGridViewTextBoxColumn1"
        '
        'TelefDataGridViewTextBoxColumn
        '
        Me.TelefDataGridViewTextBoxColumn.DataPropertyName = "telef"
        Me.TelefDataGridViewTextBoxColumn.HeaderText = "telef"
        Me.TelefDataGridViewTextBoxColumn.Name = "TelefDataGridViewTextBoxColumn"
        '
        'AdreçaDataGridViewTextBoxColumn
        '
        Me.AdreçaDataGridViewTextBoxColumn.DataPropertyName = "adreça"
        Me.AdreçaDataGridViewTextBoxColumn.HeaderText = "adreça"
        Me.AdreçaDataGridViewTextBoxColumn.Name = "AdreçaDataGridViewTextBoxColumn"
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "cp"
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        '
        'MunicipiDataGridViewTextBoxColumn
        '
        Me.MunicipiDataGridViewTextBoxColumn.DataPropertyName = "municipi"
        Me.MunicipiDataGridViewTextBoxColumn.HeaderText = "municipi"
        Me.MunicipiDataGridViewTextBoxColumn.Name = "MunicipiDataGridViewTextBoxColumn"
        '
        'ComarcaDataGridViewTextBoxColumn
        '
        Me.ComarcaDataGridViewTextBoxColumn.DataPropertyName = "comarca"
        Me.ComarcaDataGridViewTextBoxColumn.HeaderText = "comarca"
        Me.ComarcaDataGridViewTextBoxColumn.Name = "ComarcaDataGridViewTextBoxColumn"
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        '
        'ComunitatDataGridViewTextBoxColumn
        '
        Me.ComunitatDataGridViewTextBoxColumn.DataPropertyName = "comunitat"
        Me.ComunitatDataGridViewTextBoxColumn.HeaderText = "comunitat"
        Me.ComunitatDataGridViewTextBoxColumn.Name = "ComunitatDataGridViewTextBoxColumn"
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "pais"
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(991, 500)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gestió Ventes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendaidDataGridViewTextBoxColumn, Me.DipositidDataGridViewTextBoxColumn, Me.TargetaDataGridViewTextBoxColumn, Me.CapacitatDataGridViewTextBoxColumn, Me.EurosDataGridViewTextBoxColumn, Me.PagatDataGridViewCheckBoxColumn, Me.DatavendaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VendaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(745, 498)
        Me.DataGridView1.TabIndex = 1
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.TextBox1)
        Me.TabPage4.Controls.Add(Me.ComboBox2)
        Me.TabPage4.Controls.Add(Me.Button11)
        Me.TabPage4.Controls.Add(Me.DataGridView5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(991, 500)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Gestió Diposit"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(720, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "*Selecciona la ID "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(764, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Preu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(791, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(767, 302)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 13
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(720, 193)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(847, 191)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Modificar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DipositidDataGridViewTextBoxColumn1, Me.NomcarburantDataGridViewTextBoxColumn, Me.ActualDataGridViewTextBoxColumn, Me.MaximDataGridViewTextBoxColumn, Me.EurosDataGridViewTextBoxColumn1, Me.EmpresaidDataGridViewTextBoxColumn1})
        Me.DataGridView5.DataSource = Me.DipositBindingSource2
        Me.DataGridView5.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(644, 497)
        Me.DataGridView5.TabIndex = 3
        '
        'DipositidDataGridViewTextBoxColumn1
        '
        Me.DipositidDataGridViewTextBoxColumn1.DataPropertyName = "diposit_id"
        Me.DipositidDataGridViewTextBoxColumn1.HeaderText = "diposit_id"
        Me.DipositidDataGridViewTextBoxColumn1.Name = "DipositidDataGridViewTextBoxColumn1"
        Me.DipositidDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NomcarburantDataGridViewTextBoxColumn
        '
        Me.NomcarburantDataGridViewTextBoxColumn.DataPropertyName = "nom_carburant"
        Me.NomcarburantDataGridViewTextBoxColumn.HeaderText = "nom_carburant"
        Me.NomcarburantDataGridViewTextBoxColumn.Name = "NomcarburantDataGridViewTextBoxColumn"
        '
        'ActualDataGridViewTextBoxColumn
        '
        Me.ActualDataGridViewTextBoxColumn.DataPropertyName = "actual"
        Me.ActualDataGridViewTextBoxColumn.HeaderText = "actual"
        Me.ActualDataGridViewTextBoxColumn.Name = "ActualDataGridViewTextBoxColumn"
        '
        'MaximDataGridViewTextBoxColumn
        '
        Me.MaximDataGridViewTextBoxColumn.DataPropertyName = "maxim"
        Me.MaximDataGridViewTextBoxColumn.HeaderText = "maxim"
        Me.MaximDataGridViewTextBoxColumn.Name = "MaximDataGridViewTextBoxColumn"
        '
        'EurosDataGridViewTextBoxColumn1
        '
        Me.EurosDataGridViewTextBoxColumn1.DataPropertyName = "euros"
        Me.EurosDataGridViewTextBoxColumn1.HeaderText = "euros"
        Me.EurosDataGridViewTextBoxColumn1.Name = "EurosDataGridViewTextBoxColumn1"
        '
        'EmpresaidDataGridViewTextBoxColumn1
        '
        Me.EmpresaidDataGridViewTextBoxColumn1.DataPropertyName = "empresa_id"
        Me.EmpresaidDataGridViewTextBoxColumn1.HeaderText = "empresa_id"
        Me.EmpresaidDataGridViewTextBoxColumn1.Name = "EmpresaidDataGridViewTextBoxColumn1"
        '
        'DipositBindingSource2
        '
        Me.DipositBindingSource2.DataMember = "diposit"
        Me.DipositBindingSource2.DataSource = Me.CarburantDataSet
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGridView6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(991, 500)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Gestió Comandes"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComandaidDataGridViewTextBoxColumn, Me.EmpresaidDataGridViewTextBoxColumn2, Me.DipositidDataGridViewTextBoxColumn2, Me.LitresDataGridViewTextBoxColumn, Me.DataenviatDataGridViewTextBoxColumn})
        Me.DataGridView6.DataSource = Me.ComandaBindingSource1
        Me.DataGridView6.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(544, 497)
        Me.DataGridView6.TabIndex = 0
        '
        'ComandaidDataGridViewTextBoxColumn
        '
        Me.ComandaidDataGridViewTextBoxColumn.DataPropertyName = "comanda_id"
        Me.ComandaidDataGridViewTextBoxColumn.HeaderText = "comanda_id"
        Me.ComandaidDataGridViewTextBoxColumn.Name = "ComandaidDataGridViewTextBoxColumn"
        Me.ComandaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpresaidDataGridViewTextBoxColumn2
        '
        Me.EmpresaidDataGridViewTextBoxColumn2.DataPropertyName = "empresa_id"
        Me.EmpresaidDataGridViewTextBoxColumn2.HeaderText = "empresa_id"
        Me.EmpresaidDataGridViewTextBoxColumn2.Name = "EmpresaidDataGridViewTextBoxColumn2"
        '
        'DipositidDataGridViewTextBoxColumn2
        '
        Me.DipositidDataGridViewTextBoxColumn2.DataPropertyName = "diposit_id"
        Me.DipositidDataGridViewTextBoxColumn2.HeaderText = "diposit_id"
        Me.DipositidDataGridViewTextBoxColumn2.Name = "DipositidDataGridViewTextBoxColumn2"
        '
        'LitresDataGridViewTextBoxColumn
        '
        Me.LitresDataGridViewTextBoxColumn.DataPropertyName = "litres"
        Me.LitresDataGridViewTextBoxColumn.HeaderText = "litres"
        Me.LitresDataGridViewTextBoxColumn.Name = "LitresDataGridViewTextBoxColumn"
        '
        'DataenviatDataGridViewTextBoxColumn
        '
        Me.DataenviatDataGridViewTextBoxColumn.DataPropertyName = "data_enviat"
        Me.DataenviatDataGridViewTextBoxColumn.HeaderText = "data_enviat"
        Me.DataenviatDataGridViewTextBoxColumn.Name = "DataenviatDataGridViewTextBoxColumn"
        '
        'ComandaBindingSource1
        '
        Me.ComandaBindingSource1.DataMember = "comanda"
        Me.ComandaBindingSource1.DataSource = Me.CarburantDataSet
        '
        'Login_adminTableAdapter
        '
        Me.Login_adminTableAdapter.ClearBeforeFill = True
        '
        'Login_clientTableAdapter
        '
        Me.Login_clientTableAdapter.ClearBeforeFill = True
        '
        'Empresa_recaregaTableAdapter
        '
        Me.Empresa_recaregaTableAdapter.ClearBeforeFill = True
        '
        'VendaTableAdapter
        '
        Me.VendaTableAdapter.ClearBeforeFill = True
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
        'DipositBindingSource1
        '
        Me.DipositBindingSource1.DataMember = "diposit"
        Me.DipositBindingSource1.DataSource = Me.CarburantDataSet
        '
        'ComandaBindingSource
        '
        Me.ComandaBindingSource.DataMember = "comanda"
        Me.ComandaBindingSource.DataSource = Me.CarburantDataSet
        '
        'ComandaTableAdapter
        '
        Me.ComandaTableAdapter.ClearBeforeFill = True
        '
        'Administracio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 526)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Administracio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginadminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarburantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.EmpresarecaregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DipositBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DipositBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DipositBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CarburantDataSet As carburantDataSet
    Friend WithEvents LoginadminBindingSource As BindingSource
    Friend WithEvents Login_adminTableAdapter As carburantDataSetTableAdapters.login_adminTableAdapter
    Friend WithEvents LoginadminidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginclientBindingSource As BindingSource
    Friend WithEvents Login_clientTableAdapter As carburantDataSetTableAdapters.login_clientTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents LoginclientidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpresarecaregaBindingSource As BindingSource
    Friend WithEvents Empresa_recaregaTableAdapter As carburantDataSetTableAdapters.empresa_recaregaTableAdapter
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents EmpresaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TelefDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdreçaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MunicipiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComunitatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendaBindingSource As BindingSource
    Friend WithEvents VendaTableAdapter As carburantDataSetTableAdapters.vendaTableAdapter
    Friend WithEvents VendaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DipositidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TargetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacitatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EurosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagatDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DatavendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DipositBindingSource As BindingSource
    Friend WithEvents DipositTableAdapter As carburantDataSetTableAdapters.dipositTableAdapter
    Friend WithEvents DipositBindingSource1 As BindingSource
    Friend WithEvents ComandaBindingSource As BindingSource
    Friend WithEvents ComandaTableAdapter As carburantDataSetTableAdapters.comandaTableAdapter
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DipositidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NomcarburantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EurosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DipositBindingSource2 As BindingSource
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents ComandaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaidDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DipositidDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LitresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataenviatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComandaBindingSource1 As BindingSource
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
