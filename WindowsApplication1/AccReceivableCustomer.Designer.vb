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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCusAcc = New System.Windows.Forms.DataGridView()
        Me.tbPayment = New System.Windows.Forms.TextBox()
        Me.btnApplyPay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPayHistory = New System.Windows.Forms.Button()
        Me.btnARTrans = New System.Windows.Forms.Button()
        Me.TSauto1DataSet1 = New WindowsApplication1.TSauto1DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvCusAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSauto1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCusAcc
        '
        Me.dgvCusAcc.AllowUserToAddRows = False
        Me.dgvCusAcc.AllowUserToDeleteRows = False
        Me.dgvCusAcc.AllowUserToResizeColumns = False
        Me.dgvCusAcc.AllowUserToResizeRows = False
        Me.dgvCusAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCusAcc.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCusAcc.Location = New System.Drawing.Point(12, 69)
        Me.dgvCusAcc.Name = "dgvCusAcc"
        Me.dgvCusAcc.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusAcc.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCusAcc.RowHeadersVisible = False
        Me.dgvCusAcc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCusAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCusAcc.Size = New System.Drawing.Size(611, 281)
        Me.dgvCusAcc.TabIndex = 0
        '
        'tbPayment
        '
        Me.tbPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPayment.Location = New System.Drawing.Point(224, 23)
        Me.tbPayment.Name = "tbPayment"
        Me.tbPayment.ReadOnly = True
        Me.tbPayment.Size = New System.Drawing.Size(100, 20)
        Me.tbPayment.TabIndex = 1
        Me.tbPayment.Text = "0.0"
        '
        'btnApplyPay
        '
        Me.btnApplyPay.BackColor = System.Drawing.Color.LightBlue
        Me.btnApplyPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApplyPay.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyPay.Location = New System.Drawing.Point(346, 12)
        Me.btnApplyPay.Name = "btnApplyPay"
        Me.btnApplyPay.Size = New System.Drawing.Size(66, 40)
        Me.btnApplyPay.TabIndex = 2
        Me.btnApplyPay.Text = "APPLY PAYMENT"
        Me.btnApplyPay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(556, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 45)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPayHistory
        '
        Me.btnPayHistory.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPayHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayHistory.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayHistory.Location = New System.Drawing.Point(12, 381)
        Me.btnPayHistory.Name = "btnPayHistory"
        Me.btnPayHistory.Size = New System.Drawing.Size(79, 45)
        Me.btnPayHistory.TabIndex = 4
        Me.btnPayHistory.Text = "PAYMENT HISTORY"
        Me.btnPayHistory.UseVisualStyleBackColor = False
        '
        'btnARTrans
        '
        Me.btnARTrans.BackColor = System.Drawing.Color.LightBlue
        Me.btnARTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnARTrans.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnARTrans.Location = New System.Drawing.Point(97, 381)
        Me.btnARTrans.Name = "btnARTrans"
        Me.btnARTrans.Size = New System.Drawing.Size(110, 45)
        Me.btnARTrans.TabIndex = 5
        Me.btnARTrans.Text = "A/R TRANSACTIONS"
        Me.btnARTrans.UseVisualStyleBackColor = False
        '
        'TSauto1DataSet1
        '
        Me.TSauto1DataSet1.DataSetName = "TSauto1DataSet"
        Me.TSauto1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "fdf"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AccReceivableCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 438)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnARTrans)
        Me.Controls.Add(Me.btnPayHistory)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnApplyPay)
        Me.Controls.Add(Me.tbPayment)
        Me.Controls.Add(Me.dgvCusAcc)
        Me.Name = "AccReceivableCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccReceivableCustomer"
        CType(Me.dgvCusAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSauto1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCusAcc As DataGridView
    Friend WithEvents tbPayment As TextBox
    Friend WithEvents btnApplyPay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPayHistory As Button
    Friend WithEvents btnARTrans As Button
    Friend WithEvents TSauto1DataSet1 As TSauto1DataSet
    Friend WithEvents Button1 As Button
End Class
