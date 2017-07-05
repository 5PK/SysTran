<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppMakePaymentSelect
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
        Me.btnDebit = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnAR = New System.Windows.Forms.Button()
        Me.tbDebit = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbOutstanding = New System.Windows.Forms.TextBox()
        Me.tbInvTotal = New System.Windows.Forms.TextBox()
        Me.tbTotalPaid = New System.Windows.Forms.TextBox()
        Me.tbCheque = New System.Windows.Forms.TextBox()
        Me.tbCredit = New System.Windows.Forms.TextBox()
        Me.tbCash = New System.Windows.Forms.TextBox()
        Me.tbAR = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDebit
        '
        Me.btnDebit.BackColor = System.Drawing.Color.Silver
        Me.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebit.Location = New System.Drawing.Point(39, 151)
        Me.btnDebit.Name = "btnDebit"
        Me.btnDebit.Size = New System.Drawing.Size(75, 23)
        Me.btnDebit.TabIndex = 39
        Me.btnDebit.Text = "DEBIT"
        Me.btnDebit.UseVisualStyleBackColor = False
        '
        'btnCheque
        '
        Me.btnCheque.BackColor = System.Drawing.Color.Silver
        Me.btnCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheque.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheque.Location = New System.Drawing.Point(39, 117)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(75, 23)
        Me.btnCheque.TabIndex = 38
        Me.btnCheque.Text = "CHEQUE"
        Me.btnCheque.UseVisualStyleBackColor = False
        '
        'btnCredit
        '
        Me.btnCredit.BackColor = System.Drawing.Color.Silver
        Me.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredit.Location = New System.Drawing.Point(39, 84)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(75, 23)
        Me.btnCredit.TabIndex = 37
        Me.btnCredit.Text = "CREDIT"
        Me.btnCredit.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Silver
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(39, 53)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(75, 23)
        Me.btnCash.TabIndex = 36
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnAR
        '
        Me.btnAR.BackColor = System.Drawing.Color.Silver
        Me.btnAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAR.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAR.Location = New System.Drawing.Point(39, 23)
        Me.btnAR.Name = "btnAR"
        Me.btnAR.Size = New System.Drawing.Size(75, 23)
        Me.btnAR.TabIndex = 35
        Me.btnAR.Text = "A/R"
        Me.btnAR.UseVisualStyleBackColor = False
        '
        'tbDebit
        '
        Me.tbDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDebit.Location = New System.Drawing.Point(156, 151)
        Me.tbDebit.Name = "tbDebit"
        Me.tbDebit.Size = New System.Drawing.Size(100, 20)
        Me.tbDebit.TabIndex = 34
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(156, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "CANCEL"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.PaleGreen
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(54, 353)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 36)
        Me.btnOK.TabIndex = 32
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "OUTSTANDING"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "INVOICE TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "TOTAL PAID"
        '
        'tbOutstanding
        '
        Me.tbOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOutstanding.Location = New System.Drawing.Point(156, 300)
        Me.tbOutstanding.Name = "tbOutstanding"
        Me.tbOutstanding.Size = New System.Drawing.Size(100, 20)
        Me.tbOutstanding.TabIndex = 28
        '
        'tbInvTotal
        '
        Me.tbInvTotal.BackColor = System.Drawing.Color.Khaki
        Me.tbInvTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInvTotal.Location = New System.Drawing.Point(156, 265)
        Me.tbInvTotal.Name = "tbInvTotal"
        Me.tbInvTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbInvTotal.TabIndex = 27
        '
        'tbTotalPaid
        '
        Me.tbTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalPaid.Location = New System.Drawing.Point(156, 228)
        Me.tbTotalPaid.Name = "tbTotalPaid"
        Me.tbTotalPaid.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalPaid.TabIndex = 26
        '
        'tbCheque
        '
        Me.tbCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCheque.Location = New System.Drawing.Point(156, 117)
        Me.tbCheque.Name = "tbCheque"
        Me.tbCheque.Size = New System.Drawing.Size(100, 20)
        Me.tbCheque.TabIndex = 25
        '
        'tbCredit
        '
        Me.tbCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCredit.Location = New System.Drawing.Point(156, 84)
        Me.tbCredit.Name = "tbCredit"
        Me.tbCredit.Size = New System.Drawing.Size(100, 20)
        Me.tbCredit.TabIndex = 24
        '
        'tbCash
        '
        Me.tbCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCash.Location = New System.Drawing.Point(156, 53)
        Me.tbCash.Name = "tbCash"
        Me.tbCash.Size = New System.Drawing.Size(100, 20)
        Me.tbCash.TabIndex = 23
        '
        'tbAR
        '
        Me.tbAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAR.Location = New System.Drawing.Point(156, 23)
        Me.tbAR.Name = "tbAR"
        Me.tbAR.ReadOnly = True
        Me.tbAR.Size = New System.Drawing.Size(100, 20)
        Me.tbAR.TabIndex = 22
        '
        'SuppMakePaymentSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 416)
        Me.Controls.Add(Me.btnDebit)
        Me.Controls.Add(Me.btnCheque)
        Me.Controls.Add(Me.btnCredit)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.btnAR)
        Me.Controls.Add(Me.tbDebit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbOutstanding)
        Me.Controls.Add(Me.tbInvTotal)
        Me.Controls.Add(Me.tbTotalPaid)
        Me.Controls.Add(Me.tbCheque)
        Me.Controls.Add(Me.tbCredit)
        Me.Controls.Add(Me.tbCash)
        Me.Controls.Add(Me.tbAR)
        Me.Name = "SuppMakePaymentSelect"
        Me.Text = "SupplierMakePaymentSelect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDebit As Button
    Friend WithEvents btnCheque As Button
    Friend WithEvents btnCredit As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnAR As Button
    Friend WithEvents tbDebit As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbOutstanding As TextBox
    Friend WithEvents tbInvTotal As TextBox
    Friend WithEvents tbTotalPaid As TextBox
    Friend WithEvents tbCheque As TextBox
    Friend WithEvents tbCredit As TextBox
    Friend WithEvents tbCash As TextBox
    Friend WithEvents tbAR As TextBox
End Class
