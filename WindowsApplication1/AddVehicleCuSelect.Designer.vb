<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVehicleCuSelect
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToResizeColumns = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomers.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dgvCustomers.Location = New System.Drawing.Point(34, 236)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(442, 150)
        Me.dgvCustomers.TabIndex = 12
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(34, 434)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 54)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Click on the customer from the list, then click OK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(529, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter the first few characters of the customer's First Name, Last Name or Company" &
    ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SELECT CUSTOMER YOU WANT TO ADD VEHICLE TO"
        '
        'AddVehicleCuSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 592)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AddVehicleCuSelect"
        Me.Text = "AddVehicleCuSelect"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
