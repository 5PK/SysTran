﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccRecPaymentSel
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
        Me.tbDebit = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbChange = New System.Windows.Forms.TextBox()
        Me.tbTotalInvBalances = New System.Windows.Forms.TextBox()
        Me.tbTotalPaid = New System.Windows.Forms.TextBox()
        Me.tbCheque = New System.Windows.Forms.TextBox()
        Me.tbCredit = New System.Windows.Forms.TextBox()
        Me.tbCash = New System.Windows.Forms.TextBox()
        Me.tbAR = New System.Windows.Forms.TextBox()
        Me.btnAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDebit
        '
        Me.btnDebit.BackColor = System.Drawing.Color.Silver
        Me.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebit.Location = New System.Drawing.Point(34, 154)
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
        Me.btnCheque.Location = New System.Drawing.Point(34, 120)
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
        Me.btnCredit.Location = New System.Drawing.Point(34, 87)
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
        Me.btnCash.Location = New System.Drawing.Point(34, 56)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(75, 23)
        Me.btnCash.TabIndex = 36
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'tbDebit
        '
        Me.tbDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDebit.Location = New System.Drawing.Point(151, 154)
        Me.tbDebit.Name = "tbDebit"
        Me.tbDebit.Size = New System.Drawing.Size(100, 20)
        Me.tbDebit.TabIndex = 0
        Me.tbDebit.TabStop = False
        Me.tbDebit.Text = "0.0"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(151, 356)
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
        Me.btnOK.Location = New System.Drawing.Point(49, 356)
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
        Me.Label7.Location = New System.Drawing.Point(25, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "OUTSTANDING"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "INVOICE TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "TOTAL PAID"
        '
        'tbChange
        '
        Me.tbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbChange.Location = New System.Drawing.Point(151, 303)
        Me.tbChange.Name = "tbChange"
        Me.tbChange.Size = New System.Drawing.Size(100, 20)
        Me.tbChange.TabIndex = 28
        Me.tbChange.Text = "0.0"
        '
        'tbTotalInvBalances
        '
        Me.tbTotalInvBalances.BackColor = System.Drawing.Color.Khaki
        Me.tbTotalInvBalances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalInvBalances.Location = New System.Drawing.Point(151, 268)
        Me.tbTotalInvBalances.Name = "tbTotalInvBalances"
        Me.tbTotalInvBalances.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalInvBalances.TabIndex = 27
        Me.tbTotalInvBalances.Text = "0.0"
        '
        'tbTotalPaid
        '
        Me.tbTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalPaid.Location = New System.Drawing.Point(151, 231)
        Me.tbTotalPaid.Name = "tbTotalPaid"
        Me.tbTotalPaid.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalPaid.TabIndex = 26
        Me.tbTotalPaid.Text = "0.0"
        '
        'tbCheque
        '
        Me.tbCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCheque.Location = New System.Drawing.Point(151, 120)
        Me.tbCheque.Name = "tbCheque"
        Me.tbCheque.Size = New System.Drawing.Size(100, 20)
        Me.tbCheque.TabIndex = 0
        Me.tbCheque.TabStop = False
        Me.tbCheque.Text = "0.0"
        '
        'tbCredit
        '
        Me.tbCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCredit.Location = New System.Drawing.Point(151, 87)
        Me.tbCredit.Name = "tbCredit"
        Me.tbCredit.Size = New System.Drawing.Size(100, 20)
        Me.tbCredit.TabIndex = 0
        Me.tbCredit.TabStop = False
        Me.tbCredit.Text = "0.0"
        '
        'tbCash
        '
        Me.tbCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCash.Location = New System.Drawing.Point(151, 56)
        Me.tbCash.Name = "tbCash"
        Me.tbCash.Size = New System.Drawing.Size(100, 20)
        Me.tbCash.TabIndex = 0
        Me.tbCash.TabStop = False
        Me.tbCash.Text = "0.0"
        '
        'tbAR
        '
        Me.tbAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAR.Location = New System.Drawing.Point(151, 26)
        Me.tbAR.Name = "tbAR"
        Me.tbAR.ReadOnly = True
        Me.tbAR.Size = New System.Drawing.Size(100, 20)
        Me.tbAR.TabIndex = 0
        Me.tbAR.TabStop = False
        Me.tbAR.Text = "0.0"
        '
        'btnAR
        '
        Me.btnAR.BackColor = System.Drawing.Color.Silver
        Me.btnAR.Enabled = False
        Me.btnAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAR.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAR.Location = New System.Drawing.Point(34, 26)
        Me.btnAR.Name = "btnAR"
        Me.btnAR.Size = New System.Drawing.Size(75, 23)
        Me.btnAR.TabIndex = 35
        Me.btnAR.Text = "A/R"
        Me.btnAR.UseVisualStyleBackColor = False
        '
        'AccRecPaymentSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 420)
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
        Me.Controls.Add(Me.tbChange)
        Me.Controls.Add(Me.tbTotalInvBalances)
        Me.Controls.Add(Me.tbTotalPaid)
        Me.Controls.Add(Me.tbCheque)
        Me.Controls.Add(Me.tbCredit)
        Me.Controls.Add(Me.tbCash)
        Me.Controls.Add(Me.tbAR)
        Me.Name = "AccRecPaymentSel"
        Me.Text = "AccRecPaymentSel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDebit As Button
    Friend WithEvents btnCheque As Button
    Friend WithEvents btnCredit As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents tbDebit As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbChange As TextBox
    Friend WithEvents tbTotalInvBalances As TextBox
    Friend WithEvents tbTotalPaid As TextBox
    Friend WithEvents tbCheque As TextBox
    Friend WithEvents tbCredit As TextBox
    Friend WithEvents tbCash As TextBox
    Friend WithEvents tbAR As TextBox
    Friend WithEvents btnAR As Button
End Class
