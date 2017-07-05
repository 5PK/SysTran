<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierPayable
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
        Me.dgvSuppPay = New System.Windows.Forms.DataGridView()
        Me.tbInvoiceID = New System.Windows.Forms.TextBox()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.tbPurchase = New System.Windows.Forms.TextBox()
        Me.tbTax = New System.Windows.Forms.TextBox()
        Me.btnAddPayment = New System.Windows.Forms.Button()
        Me.btnMakePay = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbBalance = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDeletePurchase = New System.Windows.Forms.Button()
        CType(Me.dgvSuppPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSuppPay
        '
        Me.dgvSuppPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppPay.Location = New System.Drawing.Point(12, 12)
        Me.dgvSuppPay.MultiSelect = False
        Me.dgvSuppPay.Name = "dgvSuppPay"
        Me.dgvSuppPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppPay.Size = New System.Drawing.Size(736, 270)
        Me.dgvSuppPay.TabIndex = 0
        '
        'tbInvoiceID
        '
        Me.tbInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInvoiceID.Location = New System.Drawing.Point(12, 288)
        Me.tbInvoiceID.Name = "tbInvoiceID"
        Me.tbInvoiceID.Size = New System.Drawing.Size(86, 20)
        Me.tbInvoiceID.TabIndex = 1
        '
        'tbDate
        '
        Me.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDate.Location = New System.Drawing.Point(97, 288)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(86, 20)
        Me.tbDate.TabIndex = 2
        '
        'tbDesc
        '
        Me.tbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDesc.Location = New System.Drawing.Point(182, 288)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(226, 20)
        Me.tbDesc.TabIndex = 3
        '
        'tbPurchase
        '
        Me.tbPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPurchase.Location = New System.Drawing.Point(407, 288)
        Me.tbPurchase.Name = "tbPurchase"
        Me.tbPurchase.Size = New System.Drawing.Size(86, 20)
        Me.tbPurchase.TabIndex = 4
        Me.tbPurchase.Text = "0.0"
        '
        'tbTax
        '
        Me.tbTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTax.Location = New System.Drawing.Point(492, 288)
        Me.tbTax.Name = "tbTax"
        Me.tbTax.ReadOnly = True
        Me.tbTax.Size = New System.Drawing.Size(86, 20)
        Me.tbTax.TabIndex = 5
        Me.tbTax.Text = "0.0"
        '
        'btnAddPayment
        '
        Me.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPayment.Location = New System.Drawing.Point(12, 345)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(94, 39)
        Me.btnAddPayment.TabIndex = 7
        Me.btnAddPayment.Text = "Add Purchase"
        Me.btnAddPayment.UseVisualStyleBackColor = True
        '
        'btnMakePay
        '
        Me.btnMakePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakePay.Location = New System.Drawing.Point(339, 345)
        Me.btnMakePay.Name = "btnMakePay"
        Me.btnMakePay.Size = New System.Drawing.Size(94, 39)
        Me.btnMakePay.TabIndex = 8
        Me.btnMakePay.Text = "Make Payment"
        Me.btnMakePay.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(439, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 39)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Payment History"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbBalance
        '
        Me.tbBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBalance.Location = New System.Drawing.Point(662, 288)
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.ReadOnly = True
        Me.tbBalance.Size = New System.Drawing.Size(86, 20)
        Me.tbBalance.TabIndex = 10
        Me.tbBalance.Text = "0.0"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(677, 345)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 39)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDeletePurchase
        '
        Me.btnDeletePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePurchase.Location = New System.Drawing.Point(112, 345)
        Me.btnDeletePurchase.Name = "btnDeletePurchase"
        Me.btnDeletePurchase.Size = New System.Drawing.Size(94, 39)
        Me.btnDeletePurchase.TabIndex = 12
        Me.btnDeletePurchase.Text = "Delete Purchase"
        Me.btnDeletePurchase.UseVisualStyleBackColor = True
        '
        'SupplierPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 396)
        Me.Controls.Add(Me.btnDeletePurchase)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tbBalance)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnMakePay)
        Me.Controls.Add(Me.btnAddPayment)
        Me.Controls.Add(Me.tbTax)
        Me.Controls.Add(Me.tbPurchase)
        Me.Controls.Add(Me.tbDesc)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.tbInvoiceID)
        Me.Controls.Add(Me.dgvSuppPay)
        Me.Name = "SupplierPayable"
        Me.Text = "SupplierPayable"
        CType(Me.dgvSuppPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSuppPay As DataGridView
    Friend WithEvents tbInvoiceID As TextBox
    Friend WithEvents tbDate As TextBox
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents tbPurchase As TextBox
    Friend WithEvents tbTax As TextBox
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents btnMakePay As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbBalance As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDeletePurchase As Button
End Class
