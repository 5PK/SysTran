<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierSel
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
        Me.tbSuppSel = New System.Windows.Forms.TextBox()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.lblAtel = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSuppSel
        '
        Me.tbSuppSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSuppSel.Location = New System.Drawing.Point(44, 52)
        Me.tbSuppSel.Name = "tbSuppSel"
        Me.tbSuppSel.Size = New System.Drawing.Size(167, 20)
        Me.tbSuppSel.TabIndex = 0
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AllowUserToResizeColumns = False
        Me.dgvSuppliers.AllowUserToResizeRows = False
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Location = New System.Drawing.Point(44, 102)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.Size = New System.Drawing.Size(218, 218)
        Me.dgvSuppliers.TabIndex = 0
        '
        'lblAtel
        '
        Me.lblAtel.AutoSize = True
        Me.lblAtel.Location = New System.Drawing.Point(341, 136)
        Me.lblAtel.Name = "lblAtel"
        Me.lblAtel.Size = New System.Drawing.Size(11, 13)
        Me.lblAtel.TabIndex = 2
        Me.lblAtel.Text = "*"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(377, 136)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(11, 13)
        Me.lblTel.TabIndex = 3
        Me.lblTel.Text = "*"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(341, 186)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(11, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "*"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ADD NEW SUPPLIER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PHONE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "EMAIL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter Supplier:"
        '
        'SupplierSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 346)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblAtel)
        Me.Controls.Add(Me.dgvSuppliers)
        Me.Controls.Add(Me.tbSuppSel)
        Me.Name = "SupplierSel"
        Me.Text = "SupplierSel"
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSuppSel As TextBox
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents lblAtel As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
