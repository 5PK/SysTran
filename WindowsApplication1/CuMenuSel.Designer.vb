<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuMenuSel
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
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnModifyCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomer.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(12, 12)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(116, 46)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "ADD CUSTOMER"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'btnModifyCustomer
        '
        Me.btnModifyCustomer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnModifyCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyCustomer.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyCustomer.Location = New System.Drawing.Point(12, 81)
        Me.btnModifyCustomer.Name = "btnModifyCustomer"
        Me.btnModifyCustomer.Size = New System.Drawing.Size(116, 46)
        Me.btnModifyCustomer.TabIndex = 1
        Me.btnModifyCustomer.Text = "MODIFY CUSTOMER"
        Me.btnModifyCustomer.UseVisualStyleBackColor = False
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCustomer.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(12, 155)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(116, 46)
        Me.btnDeleteCustomer.TabIndex = 2
        Me.btnDeleteCustomer.Text = "Delete Customer"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(155, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(44, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'CuMenuSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(216, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.btnModifyCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Name = "CuMenuSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnModifyCustomer As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnExit As Button
End Class
