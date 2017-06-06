<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentSel
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
        Me.tbAR = New System.Windows.Forms.TextBox()
        Me.tbCash = New System.Windows.Forms.TextBox()
        Me.tbCredit = New System.Windows.Forms.TextBox()
        Me.tbCheque = New System.Windows.Forms.TextBox()
        Me.tbTotalPaid = New System.Windows.Forms.TextBox()
        Me.tbInvTotal = New System.Windows.Forms.TextBox()
        Me.tbOutstanding = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbDebit = New System.Windows.Forms.TextBox()
        Me.btnAR = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.btnDebit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbAR
        '
        Me.tbAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAR.Location = New System.Drawing.Point(151, 40)
        Me.tbAR.Name = "tbAR"
        Me.tbAR.ReadOnly = True
        Me.tbAR.Size = New System.Drawing.Size(100, 20)
        Me.tbAR.TabIndex = 0
        '
        'tbCash
        '
        Me.tbCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCash.Location = New System.Drawing.Point(151, 70)
        Me.tbCash.Name = "tbCash"
        Me.tbCash.Size = New System.Drawing.Size(100, 20)
        Me.tbCash.TabIndex = 1
        '
        'tbCredit
        '
        Me.tbCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCredit.Location = New System.Drawing.Point(151, 101)
        Me.tbCredit.Name = "tbCredit"
        Me.tbCredit.Size = New System.Drawing.Size(100, 20)
        Me.tbCredit.TabIndex = 2
        '
        'tbCheque
        '
        Me.tbCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCheque.Location = New System.Drawing.Point(151, 134)
        Me.tbCheque.Name = "tbCheque"
        Me.tbCheque.Size = New System.Drawing.Size(100, 20)
        Me.tbCheque.TabIndex = 3
        '
        'tbTotalPaid
        '
        Me.tbTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalPaid.Location = New System.Drawing.Point(151, 245)
        Me.tbTotalPaid.Name = "tbTotalPaid"
        Me.tbTotalPaid.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalPaid.TabIndex = 4
        '
        'tbInvTotal
        '
        Me.tbInvTotal.BackColor = System.Drawing.Color.Khaki
        Me.tbInvTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInvTotal.Location = New System.Drawing.Point(151, 282)
        Me.tbInvTotal.Name = "tbInvTotal"
        Me.tbInvTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbInvTotal.TabIndex = 5
        '
        'tbOutstanding
        '
        Me.tbOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOutstanding.Location = New System.Drawing.Point(151, 317)
        Me.tbOutstanding.Name = "tbOutstanding"
        Me.tbOutstanding.Size = New System.Drawing.Size(100, 20)
        Me.tbOutstanding.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TOTAL PAID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "INVOICE TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "OUTSTANDING"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.PaleGreen
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(49, 370)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 36)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(151, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "CANCEL"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tbDebit
        '
        Me.tbDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDebit.Location = New System.Drawing.Point(151, 168)
        Me.tbDebit.Name = "tbDebit"
        Me.tbDebit.Size = New System.Drawing.Size(100, 20)
        Me.tbDebit.TabIndex = 16
        '
        'btnAR
        '
        Me.btnAR.BackColor = System.Drawing.Color.Silver
        Me.btnAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAR.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAR.Location = New System.Drawing.Point(34, 40)
        Me.btnAR.Name = "btnAR"
        Me.btnAR.Size = New System.Drawing.Size(75, 23)
        Me.btnAR.TabIndex = 17
        Me.btnAR.Text = "A/R"
        Me.btnAR.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Silver
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(34, 70)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(75, 23)
        Me.btnCash.TabIndex = 18
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnCredit
        '
        Me.btnCredit.BackColor = System.Drawing.Color.Silver
        Me.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredit.Location = New System.Drawing.Point(34, 101)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(75, 23)
        Me.btnCredit.TabIndex = 19
        Me.btnCredit.Text = "CREDIT"
        Me.btnCredit.UseVisualStyleBackColor = False
        '
        'btnCheque
        '
        Me.btnCheque.BackColor = System.Drawing.Color.Silver
        Me.btnCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheque.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheque.Location = New System.Drawing.Point(34, 134)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(75, 23)
        Me.btnCheque.TabIndex = 20
        Me.btnCheque.Text = "CHEQUE"
        Me.btnCheque.UseVisualStyleBackColor = False
        '
        'btnDebit
        '
        Me.btnDebit.BackColor = System.Drawing.Color.Silver
        Me.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebit.Location = New System.Drawing.Point(34, 168)
        Me.btnDebit.Name = "btnDebit"
        Me.btnDebit.Size = New System.Drawing.Size(75, 23)
        Me.btnDebit.TabIndex = 21
        Me.btnDebit.Text = "DEBIT"
        Me.btnDebit.UseVisualStyleBackColor = False
        '
        'PaymentSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(287, 426)
        Me.ControlBox = False
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
        Me.Name = "PaymentSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbAR As TextBox
    Friend WithEvents tbCash As TextBox
    Friend WithEvents tbCredit As TextBox
    Friend WithEvents tbCheque As TextBox
    Friend WithEvents tbTotalPaid As TextBox
    Friend WithEvents tbInvTotal As TextBox
    Friend WithEvents tbOutstanding As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbDebit As TextBox
    Friend WithEvents btnAR As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnCredit As Button
    Friend WithEvents btnCheque As Button
    Friend WithEvents btnDebit As Button
End Class
