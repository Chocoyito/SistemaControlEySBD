﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPin = New System.Windows.Forms.TextBox()
        Me.GBAdmin = New System.Windows.Forms.GroupBox()
        Me.DgvAdmin = New System.Windows.Forms.DataGridView()
        Me.IdAdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.AdminTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.adminTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GBAdmin.SuspendLayout()
        CType(Me.DgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manejo de opciones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Administrador)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(42, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNombre.Location = New System.Drawing.Point(150, 139)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(196, 35)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtApellidos.Location = New System.Drawing.Point(152, 194)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(194, 35)
        Me.TxtApellidos.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(399, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(439, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PIN"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtUsuario.Location = New System.Drawing.Point(510, 131)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(194, 35)
        Me.TxtUsuario.TabIndex = 3
        '
        'TxtPin
        '
        Me.TxtPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtPin.Location = New System.Drawing.Point(510, 199)
        Me.TxtPin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPin.Name = "TxtPin"
        Me.TxtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPin.Size = New System.Drawing.Size(194, 35)
        Me.TxtPin.TabIndex = 4
        '
        'GBAdmin
        '
        Me.GBAdmin.Controls.Add(Me.DgvAdmin)
        Me.GBAdmin.Location = New System.Drawing.Point(47, 416)
        Me.GBAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBAdmin.Name = "GBAdmin"
        Me.GBAdmin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBAdmin.Size = New System.Drawing.Size(704, 226)
        Me.GBAdmin.TabIndex = 11
        Me.GBAdmin.TabStop = False
        Me.GBAdmin.Text = "Usuarios"
        '
        'DgvAdmin
        '
        Me.DgvAdmin.AllowUserToAddRows = False
        Me.DgvAdmin.AllowUserToDeleteRows = False
        Me.DgvAdmin.AutoGenerateColumns = False
        Me.DgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAdminDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PwDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DgvAdmin.DataSource = Me.AdminBindingSource
        Me.DgvAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvAdmin.Location = New System.Drawing.Point(3, 21)
        Me.DgvAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvAdmin.Name = "DgvAdmin"
        Me.DgvAdmin.ReadOnly = True
        Me.DgvAdmin.RowHeadersWidth = 51
        Me.DgvAdmin.RowTemplate.Height = 24
        Me.DgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAdmin.Size = New System.Drawing.Size(698, 203)
        Me.DgvAdmin.TabIndex = 0
        '
        'IdAdminDataGridViewTextBoxColumn
        '
        Me.IdAdminDataGridViewTextBoxColumn.DataPropertyName = "idAdmin"
        Me.IdAdminDataGridViewTextBoxColumn.HeaderText = "idAdmin"
        Me.IdAdminDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdAdminDataGridViewTextBoxColumn.Name = "IdAdminDataGridViewTextBoxColumn"
        Me.IdAdminDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAdminDataGridViewTextBoxColumn.Visible = False
        Me.IdAdminDataGridViewTextBoxColumn.Width = 125
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PwDataGridViewTextBoxColumn
        '
        Me.PwDataGridViewTextBoxColumn.DataPropertyName = "pw"
        Me.PwDataGridViewTextBoxColumn.HeaderText = "PIN"
        Me.PwDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PwDataGridViewTextBoxColumn.Name = "PwDataGridViewTextBoxColumn"
        Me.PwDataGridViewTextBoxColumn.ReadOnly = True
        Me.PwDataGridViewTextBoxColumn.Visible = False
        Me.PwDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        Me.AdminBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.BtnAgregar.Location = New System.Drawing.Point(332, 346)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(132, 42)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.BtnEditar.Location = New System.Drawing.Point(470, 345)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(132, 44)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.BtnEliminar.Location = New System.Drawing.Point(609, 345)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(132, 44)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnRegresar.Location = New System.Drawing.Point(606, 31)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(134, 45)
        Me.BtnRegresar.TabIndex = 9
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(45, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(51, 349)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(245, 35)
        Me.txtBuscar.TabIndex = 13
        '
        'FrmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 672)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GBAdmin)
        Me.Controls.Add(Me.TxtPin)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmOpciones"
        Me.Text = "Manejo de opciones"
        Me.GBAdmin.ResumeLayout(False)
        CType(Me.DgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPin As TextBox
    Friend WithEvents GBAdmin As GroupBox
    Friend WithEvents DgvAdmin As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As BDAsistenciasEySDataSetTableAdapters.adminTableAdapter
    Friend WithEvents IdDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents IdAdminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PwDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
