<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateVehicleSelect
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
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.tbCustomerSel = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSelectVehicle = New System.Windows.Forms.Button()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Location = New System.Drawing.Point(23, 116)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.Size = New System.Drawing.Size(485, 184)
        Me.dgvCustomers.TabIndex = 0
        '
        'dgvVehicles
        '
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.Location = New System.Drawing.Point(23, 319)
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.Size = New System.Drawing.Size(485, 179)
        Me.dgvVehicles.TabIndex = 1
        '
        'tbCustomerSel
        '
        Me.tbCustomerSel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerSel.Location = New System.Drawing.Point(23, 63)
        Me.tbCustomerSel.Name = "tbCustomerSel"
        Me.tbCustomerSel.Size = New System.Drawing.Size(169, 22)
        Me.tbCustomerSel.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(413, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 58)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSelectVehicle
        '
        Me.btnSelectVehicle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelectVehicle.Enabled = False
        Me.btnSelectVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectVehicle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectVehicle.Location = New System.Drawing.Point(23, 540)
        Me.btnSelectVehicle.Name = "btnSelectVehicle"
        Me.btnSelectVehicle.Size = New System.Drawing.Size(95, 58)
        Me.btnSelectVehicle.TabIndex = 5
        Me.btnSelectVehicle.Text = "SELECT VEHICLE"
        Me.btnSelectVehicle.UseVisualStyleBackColor = False
        '
        'UpdateVehicleSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(535, 639)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSelectVehicle)
        Me.Controls.Add(Me.tbCustomerSel)
        Me.Controls.Add(Me.dgvVehicles)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Name = "UpdateVehicleSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateVehicleSelect"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents dgvVehicles As DataGridView
    Friend WithEvents tbCustomerSel As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSelectVehicle As Button
End Class
