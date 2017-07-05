<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChequePrint
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCityProv = New System.Windows.Forms.Label()
        Me.lblPostal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblToCompany = New System.Windows.Forms.Label()
        Me.lblToStreet = New System.Windows.Forms.Label()
        Me.lbltoCity = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblChequeNo = New System.Windows.Forms.Label()
        Me.lblDte = New System.Windows.Forms.Label()
        Me.lblCents = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblToProv = New System.Windows.Forms.Label()
        Me.lblToPostal = New System.Windows.Forms.Label()
        Me.lblNumWords = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 46)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(525, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Don't Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(104, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Print Preview"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(14, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(4, 7)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(258, 13)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "TOMSON AUTOMOTIVE LTD. (SINCE 1995)"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(4, 21)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(109, 13)
        Me.lblStreet.TabIndex = 2
        Me.lblStreet.Text = "62 Six Point Road"
        '
        'lblCityProv
        '
        Me.lblCityProv.AutoSize = True
        Me.lblCityProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityProv.Location = New System.Drawing.Point(4, 35)
        Me.lblCityProv.Name = "lblCityProv"
        Me.lblCityProv.Size = New System.Drawing.Size(100, 13)
        Me.lblCityProv.TabIndex = 3
        Me.lblCityProv.Text = "Toronto, Ontario"
        '
        'lblPostal
        '
        Me.lblPostal.AutoSize = True
        Me.lblPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostal.Location = New System.Drawing.Point(4, 49)
        Me.lblPostal.Name = "lblPostal"
        Me.lblPostal.Size = New System.Drawing.Size(58, 13)
        Me.lblPostal.TabIndex = 4
        Me.lblPostal.Text = "M8Z 2X2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PAY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TO THE ORDER OF"
        '
        'lblToCompany
        '
        Me.lblToCompany.AutoSize = True
        Me.lblToCompany.Location = New System.Drawing.Point(124, 124)
        Me.lblToCompany.Name = "lblToCompany"
        Me.lblToCompany.Size = New System.Drawing.Size(77, 13)
        Me.lblToCompany.TabIndex = 8
        Me.lblToCompany.Text = "1-800 Radiator"
        '
        'lblToStreet
        '
        Me.lblToStreet.AutoSize = True
        Me.lblToStreet.Location = New System.Drawing.Point(124, 137)
        Me.lblToStreet.Name = "lblToStreet"
        Me.lblToStreet.Size = New System.Drawing.Size(121, 13)
        Me.lblToStreet.TabIndex = 9
        Me.lblToStreet.Text = "70 Belfield Road Suite 7"
        '
        'lbltoCity
        '
        Me.lbltoCity.AutoSize = True
        Me.lbltoCity.Location = New System.Drawing.Point(124, 150)
        Me.lbltoCity.Name = "lbltoCity"
        Me.lbltoCity.Size = New System.Drawing.Size(44, 13)
        Me.lbltoCity.TabIndex = 10
        Me.lbltoCity.Text = "Toronto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "MEMO"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(52, 205)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 20)
        Me.TextBox1.TabIndex = 12
        '
        'lblChequeNo
        '
        Me.lblChequeNo.AutoSize = True
        Me.lblChequeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNo.Location = New System.Drawing.Point(566, 7)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(35, 13)
        Me.lblChequeNo.TabIndex = 13
        Me.lblChequeNo.Text = "7994"
        '
        'lblDte
        '
        Me.lblDte.AutoSize = True
        Me.lblDte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDte.Location = New System.Drawing.Point(526, 49)
        Me.lblDte.Name = "lblDte"
        Me.lblDte.Size = New System.Drawing.Size(75, 13)
        Me.lblDte.TabIndex = 14
        Me.lblDte.Text = "06/19/2017"
        '
        'lblCents
        '
        Me.lblCents.AutoSize = True
        Me.lblCents.Location = New System.Drawing.Point(422, 83)
        Me.lblCents.Name = "lblCents"
        Me.lblCents.Size = New System.Drawing.Size(28, 13)
        Me.lblCents.TabIndex = 15
        Me.lblCents.Text = "PAY"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(484, 83)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 16
        Me.lblCost.Text = "PAY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowText
        Me.Panel2.Location = New System.Drawing.Point(363, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 3)
        Me.Panel2.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(423, 209)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Authorized Signature"
        '
        'lblToProv
        '
        Me.lblToProv.AutoSize = True
        Me.lblToProv.Location = New System.Drawing.Point(179, 150)
        Me.lblToProv.Name = "lblToProv"
        Me.lblToProv.Size = New System.Drawing.Size(39, 13)
        Me.lblToProv.TabIndex = 19
        Me.lblToProv.Text = "Label1"
        '
        'lblToPostal
        '
        Me.lblToPostal.AutoSize = True
        Me.lblToPostal.Location = New System.Drawing.Point(230, 150)
        Me.lblToPostal.Name = "lblToPostal"
        Me.lblToPostal.Size = New System.Drawing.Size(39, 13)
        Me.lblToPostal.TabIndex = 20
        Me.lblToPostal.Text = "Label1"
        '
        'lblNumWords
        '
        Me.lblNumWords.AutoSize = True
        Me.lblNumWords.Location = New System.Drawing.Point(124, 83)
        Me.lblNumWords.Name = "lblNumWords"
        Me.lblNumWords.Size = New System.Drawing.Size(28, 13)
        Me.lblNumWords.TabIndex = 6
        Me.lblNumWords.Text = "PAY"
        '
        'ChequePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(609, 286)
        Me.Controls.Add(Me.lblToPostal)
        Me.Controls.Add(Me.lblToProv)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblCents)
        Me.Controls.Add(Me.lblDte)
        Me.Controls.Add(Me.lblChequeNo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbltoCity)
        Me.Controls.Add(Me.lblToStreet)
        Me.Controls.Add(Me.lblToCompany)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNumWords)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPostal)
        Me.Controls.Add(Me.lblCityProv)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ChequePrint"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblCityProv As Label
    Friend WithEvents lblPostal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblToCompany As Label
    Friend WithEvents lblToStreet As Label
    Friend WithEvents lbltoCity As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblChequeNo As Label
    Friend WithEvents lblDte As Label
    Friend WithEvents lblCents As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblToProv As Label
    Friend WithEvents lblToPostal As Label
    Friend WithEvents lblNumWords As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
