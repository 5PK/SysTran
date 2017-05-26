<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateWOSelect
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbCustomerSel = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCuSelect = New System.Windows.Forms.Button()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.btnCreateWO = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TSauto1DataSet = New WindowsApplication1.TSauto1DataSet()
        Me.TSauto1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSauto1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSauto1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbCustomerSel)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By"
        '
        'tbCustomerSel
        '
        Me.tbCustomerSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCustomerSel.Location = New System.Drawing.Point(21, 63)
        Me.tbCustomerSel.Name = "tbCustomerSel"
        Me.tbCustomerSel.Size = New System.Drawing.Size(238, 20)
        Me.tbCustomerSel.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCuSelect)
        Me.GroupBox2.Controls.Add(Me.dgvVehicles)
        Me.GroupBox2.Controls.Add(Me.dgvCustomers)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 409)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer List"
        '
        'btnCuSelect
        '
        Me.btnCuSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCuSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuSelect.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuSelect.Location = New System.Drawing.Point(157, 184)
        Me.btnCuSelect.Name = "btnCuSelect"
        Me.btnCuSelect.Size = New System.Drawing.Size(145, 32)
        Me.btnCuSelect.TabIndex = 2
        Me.btnCuSelect.Text = "Select Customer"
        Me.btnCuSelect.UseVisualStyleBackColor = False
        '
        'dgvVehicles
        '
        Me.dgvVehicles.AllowUserToAddRows = False
        Me.dgvVehicles.AllowUserToDeleteRows = False
        Me.dgvVehicles.AllowUserToResizeColumns = False
        Me.dgvVehicles.AllowUserToResizeRows = False
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVehicles.Location = New System.Drawing.Point(21, 233)
        Me.dgvVehicles.MultiSelect = False
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.ReadOnly = True
        Me.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehicles.Size = New System.Drawing.Size(432, 150)
        Me.dgvVehicles.TabIndex = 1
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToResizeColumns = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomers.Location = New System.Drawing.Point(21, 28)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(432, 150)
        Me.dgvCustomers.TabIndex = 0
        '
        'btnCreateWO
        '
        Me.btnCreateWO.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCreateWO.Enabled = False
        Me.btnCreateWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateWO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateWO.Location = New System.Drawing.Point(46, 591)
        Me.btnCreateWO.Name = "btnCreateWO"
        Me.btnCreateWO.Size = New System.Drawing.Size(95, 58)
        Me.btnCreateWO.TabIndex = 2
        Me.btnCreateWO.Text = "Create Work Order"
        Me.btnCreateWO.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(162, 591)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 58)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(299, 591)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 58)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Add New Customer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.PaleGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(429, 591)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 58)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Add New Vehicle"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TSauto1DataSet
        '
        Me.TSauto1DataSet.DataSetName = "TSauto1DataSet"
        Me.TSauto1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TSauto1DataSetBindingSource
        '
        Me.TSauto1DataSetBindingSource.DataSource = Me.TSauto1DataSet
        Me.TSauto1DataSetBindingSource.Position = 0
        '
        'CreateWOSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(575, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCreateWO)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CreateWOSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Work Order"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSauto1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSauto1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCreateWO As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tbCustomerSel As TextBox
    Friend WithEvents dgvVehicles As DataGridView
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnCuSelect As Button
    Friend WithEvents TSauto1DataSetBindingSource As BindingSource
    Friend WithEvents TSauto1DataSet As TSauto1DataSet
End Class
