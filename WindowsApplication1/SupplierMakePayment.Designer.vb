<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierMakePayment
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
        Me.dgvSuppPay = New System.Windows.Forms.DataGridView()
        Me.btnAddPayment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbPayment = New System.Windows.Forms.TextBox()
        Me.btnApplyPay = New System.Windows.Forms.Button()
        CType(Me.dgvSuppPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSuppPay
        '
        Me.dgvSuppPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppPay.Location = New System.Drawing.Point(15, 91)
        Me.dgvSuppPay.Name = "dgvSuppPay"
        Me.dgvSuppPay.ReadOnly = True
        Me.dgvSuppPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppPay.Size = New System.Drawing.Size(736, 270)
        Me.dgvSuppPay.TabIndex = 1
        '
        'btnAddPayment
        '
        Me.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPayment.Location = New System.Drawing.Point(283, 383)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(94, 38)
        Me.btnAddPayment.TabIndex = 8
        Me.btnAddPayment.Text = "Supplier Transactions"
        Me.btnAddPayment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(402, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Payment History"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(678, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 38)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbPayment
        '
        Me.tbPayment.Location = New System.Drawing.Point(283, 37)
        Me.tbPayment.Name = "tbPayment"
        Me.tbPayment.Size = New System.Drawing.Size(100, 20)
        Me.tbPayment.TabIndex = 11
        Me.tbPayment.Text = "0.0"
        '
        'btnApplyPay
        '
        Me.btnApplyPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyPay.Location = New System.Drawing.Point(402, 27)
        Me.btnApplyPay.Name = "btnApplyPay"
        Me.btnApplyPay.Size = New System.Drawing.Size(94, 38)
        Me.btnApplyPay.TabIndex = 12
        Me.btnApplyPay.Text = "Make Payment"
        Me.btnApplyPay.UseVisualStyleBackColor = True
        '
        'SupplierMakePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 436)
        Me.Controls.Add(Me.btnApplyPay)
        Me.Controls.Add(Me.tbPayment)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddPayment)
        Me.Controls.Add(Me.dgvSuppPay)
        Me.Name = "SupplierMakePayment"
        Me.Text = "SupplierMakePayment"
        CType(Me.dgvSuppPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSuppPay As DataGridView
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbPayment As TextBox
    Friend WithEvents btnApplyPay As Button
End Class
