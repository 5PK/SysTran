<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccReceivableCustomer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnApplyPay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPayHistory = New System.Windows.Forms.Button()
        Me.btnARTrans = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(611, 281)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnApplyPay
        '
        Me.btnApplyPay.Location = New System.Drawing.Point(346, 12)
        Me.btnApplyPay.Name = "btnApplyPay"
        Me.btnApplyPay.Size = New System.Drawing.Size(66, 40)
        Me.btnApplyPay.TabIndex = 2
        Me.btnApplyPay.Text = "Apply Payment"
        Me.btnApplyPay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(556, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 45)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPayHistory
        '
        Me.btnPayHistory.Location = New System.Drawing.Point(12, 381)
        Me.btnPayHistory.Name = "btnPayHistory"
        Me.btnPayHistory.Size = New System.Drawing.Size(110, 45)
        Me.btnPayHistory.TabIndex = 4
        Me.btnPayHistory.Text = "PAYMENT HISTORY"
        Me.btnPayHistory.UseVisualStyleBackColor = True
        '
        'btnARTrans
        '
        Me.btnARTrans.Location = New System.Drawing.Point(128, 381)
        Me.btnARTrans.Name = "btnARTrans"
        Me.btnARTrans.Size = New System.Drawing.Size(110, 45)
        Me.btnARTrans.TabIndex = 5
        Me.btnARTrans.Text = "A/R TRANSACTIONS"
        Me.btnARTrans.UseVisualStyleBackColor = True
        '
        'AccReceivableCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 438)
        Me.Controls.Add(Me.btnARTrans)
        Me.Controls.Add(Me.btnPayHistory)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnApplyPay)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AccReceivableCustomer"
        Me.Text = "AccReceivableCustomer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnApplyPay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPayHistory As Button
    Friend WithEvents btnARTrans As Button
End Class
