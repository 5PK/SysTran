<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VeMenuSel
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDeleteVehicle = New System.Windows.Forms.Button()
        Me.btnModifyVehicle = New System.Windows.Forms.Button()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(155, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(44, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDeleteVehicle
        '
        Me.btnDeleteVehicle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteVehicle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteVehicle.Location = New System.Drawing.Point(12, 155)
        Me.btnDeleteVehicle.Name = "btnDeleteVehicle"
        Me.btnDeleteVehicle.Size = New System.Drawing.Size(116, 46)
        Me.btnDeleteVehicle.TabIndex = 6
        Me.btnDeleteVehicle.Text = "DELETE VEHICLE"
        Me.btnDeleteVehicle.UseVisualStyleBackColor = False
        '
        'btnModifyVehicle
        '
        Me.btnModifyVehicle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnModifyVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyVehicle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyVehicle.Location = New System.Drawing.Point(12, 81)
        Me.btnModifyVehicle.Name = "btnModifyVehicle"
        Me.btnModifyVehicle.Size = New System.Drawing.Size(116, 46)
        Me.btnModifyVehicle.TabIndex = 5
        Me.btnModifyVehicle.Text = "MODIFY VEHICLE"
        Me.btnModifyVehicle.UseVisualStyleBackColor = False
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVehicle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVehicle.Location = New System.Drawing.Point(12, 12)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(116, 46)
        Me.btnAddVehicle.TabIndex = 4
        Me.btnAddVehicle.Text = "ADD VEHICLE"
        Me.btnAddVehicle.UseVisualStyleBackColor = False
        '
        'VeMenuSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(216, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeleteVehicle)
        Me.Controls.Add(Me.btnModifyVehicle)
        Me.Controls.Add(Me.btnAddVehicle)
        Me.Name = "VeMenuSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VeMenuSel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDeleteVehicle As Button
    Friend WithEvents btnModifyVehicle As Button
    Friend WithEvents btnAddVehicle As Button
End Class
