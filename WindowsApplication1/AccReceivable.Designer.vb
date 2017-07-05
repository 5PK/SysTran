<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccReceivable
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
        Me.dgvAccR = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnTakePay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TakePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbCustomerSel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvAccR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAccR
        '
        Me.dgvAccR.AllowUserToAddRows = False
        Me.dgvAccR.AllowUserToDeleteRows = False
        Me.dgvAccR.AllowUserToResizeColumns = False
        Me.dgvAccR.AllowUserToResizeRows = False
        Me.dgvAccR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccR.Location = New System.Drawing.Point(12, 82)
        Me.dgvAccR.MultiSelect = False
        Me.dgvAccR.Name = "dgvAccR"
        Me.dgvAccR.ReadOnly = True
        Me.dgvAccR.RowHeadersVisible = False
        Me.dgvAccR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccR.Size = New System.Drawing.Size(743, 379)
        Me.dgvAccR.TabIndex = 0
        Me.dgvAccR.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(680, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Bisque
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(12, 482)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 31)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "REFRESH A/R"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnTakePay
        '
        Me.btnTakePay.BackColor = System.Drawing.Color.PaleGreen
        Me.btnTakePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTakePay.Location = New System.Drawing.Point(433, 482)
        Me.btnTakePay.Name = "btnTakePay"
        Me.btnTakePay.Size = New System.Drawing.Size(104, 31)
        Me.btnTakePay.TabIndex = 3
        Me.btnTakePay.Text = "TAKE PAYMENT"
        Me.btnTakePay.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TAKE PAYMENT FOR INVOICE #"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(314, 489)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakePaymentToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 26)
        '
        'TakePaymentToolStripMenuItem
        '
        Me.TakePaymentToolStripMenuItem.Name = "TakePaymentToolStripMenuItem"
        Me.TakePaymentToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.TakePaymentToolStripMenuItem.Text = "Take Payment"
        '
        'tbCustomerSel
        '
        Me.tbCustomerSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCustomerSel.Location = New System.Drawing.Point(12, 47)
        Me.tbCustomerSel.Name = "tbCustomerSel"
        Me.tbCustomerSel.Size = New System.Drawing.Size(163, 20)
        Me.tbCustomerSel.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter part of either the Customer's Company, First Name, or Last Name"
        '
        'AccReceivable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(774, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCustomerSel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTakePay)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvAccR)
        Me.Name = "AccReceivable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccReceivable"
        CType(Me.dgvAccR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAccR As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnTakePay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TakePaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbCustomerSel As TextBox
    Friend WithEvents Label2 As Label
End Class
