﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignarCargo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarCargo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBCargoEmpleado = New System.Windows.Forms.GroupBox()
        Me.DgvCargoEmp = New System.Windows.Forms.DataGridView()
        Me.IdCargoEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CargoEmpTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.cargoEmpTableAdapter()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoEmpBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoEmpBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.CargoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter()
        Me.GBCargoEmpleado.SuspendLayout()
        CType(Me.DgvCargoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoEmpBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoEmpBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asignar cargo a un empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado:"
        '
        'GBCargoEmpleado
        '
        Me.GBCargoEmpleado.Controls.Add(Me.DgvCargoEmp)
        Me.GBCargoEmpleado.Location = New System.Drawing.Point(24, 352)
        Me.GBCargoEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBCargoEmpleado.Name = "GBCargoEmpleado"
        Me.GBCargoEmpleado.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBCargoEmpleado.Size = New System.Drawing.Size(500, 319)
        Me.GBCargoEmpleado.TabIndex = 3
        Me.GBCargoEmpleado.TabStop = False
        Me.GBCargoEmpleado.Text = "Empleados con cargos"
        '
        'DgvCargoEmp
        '
        Me.DgvCargoEmp.AllowUserToAddRows = False
        Me.DgvCargoEmp.AllowUserToDeleteRows = False
        Me.DgvCargoEmp.AutoGenerateColumns = False
        Me.DgvCargoEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargoEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargoEmpDataGridViewTextBoxColumn, Me.IdEmpDataGridViewTextBoxColumn, Me.IdCargoDataGridViewTextBoxColumn})
        Me.DgvCargoEmp.DataSource = Me.CargoEmpBindingSource
        Me.DgvCargoEmp.Location = New System.Drawing.Point(22, 45)
        Me.DgvCargoEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvCargoEmp.Name = "DgvCargoEmp"
        Me.DgvCargoEmp.ReadOnly = True
        Me.DgvCargoEmp.RowHeadersWidth = 51
        Me.DgvCargoEmp.RowTemplate.Height = 24
        Me.DgvCargoEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCargoEmp.Size = New System.Drawing.Size(454, 252)
        Me.DgvCargoEmp.TabIndex = 0
        '
        'IdCargoEmpDataGridViewTextBoxColumn
        '
        Me.IdCargoEmpDataGridViewTextBoxColumn.DataPropertyName = "idCargoEmp"
        Me.IdCargoEmpDataGridViewTextBoxColumn.HeaderText = "idCargoEmp"
        Me.IdCargoEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCargoEmpDataGridViewTextBoxColumn.Name = "IdCargoEmpDataGridViewTextBoxColumn"
        Me.IdCargoEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCargoEmpDataGridViewTextBoxColumn.Visible = False
        Me.IdCargoEmpDataGridViewTextBoxColumn.Width = 50
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "ID Empleado"
        Me.IdEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpDataGridViewTextBoxColumn.Width = 125
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "ID Cargo"
        Me.IdCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCargoDataGridViewTextBoxColumn.Width = 125
        '
        'CargoEmpBindingSource
        '
        Me.CargoEmpBindingSource.DataMember = "cargoEmp"
        Me.CargoEmpBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cargo:"
        '
        'CmbEmpleado
        '
        Me.CmbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEmpleado.FormattingEnabled = True
        Me.CmbEmpleado.Location = New System.Drawing.Point(177, 118)
        Me.CmbEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbEmpleado.Name = "CmbEmpleado"
        Me.CmbEmpleado.Size = New System.Drawing.Size(345, 41)
        Me.CmbEmpleado.TabIndex = 1
        '
        'CmbCargo
        '
        Me.CmbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(177, 191)
        Me.CmbCargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(345, 41)
        Me.CmbCargo.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnGuardar.Location = New System.Drawing.Point(46, 274)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(184, 45)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnEliminar.Location = New System.Drawing.Point(320, 274)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(181, 45)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'CargoEmpTableAdapter
        '
        Me.CargoEmpTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CargoEmpBindingSource1
        '
        Me.CargoEmpBindingSource1.DataMember = "cargoEmp"
        Me.CargoEmpBindingSource1.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CargoEmpBindingSource2
        '
        Me.CargoEmpBindingSource2.DataMember = "cargoEmp"
        Me.CargoEmpBindingSource2.DataSource = Me.BDAsistenciasEySDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'FrmAsignarCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 688)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.CmbCargo)
        Me.Controls.Add(Me.CmbEmpleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GBCargoEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmAsignarCargo"
        Me.Text = "Asignar cargo"
        Me.GBCargoEmpleado.ResumeLayout(False)
        CType(Me.DgvCargoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoEmpBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoEmpBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GBCargoEmpleado As GroupBox
    Friend WithEvents DgvCargoEmp As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents CargoEmpBindingSource As BindingSource
    Friend WithEvents CargoEmpTableAdapter As BDAsistenciasEySDataSetTableAdapters.cargoEmpTableAdapter
    Friend WithEvents CmbEmpleado As ComboBox
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents CargoEmpBindingSource1 As BindingSource
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Friend WithEvents CargoEmpBindingSource2 As BindingSource
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents IdCargoEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
