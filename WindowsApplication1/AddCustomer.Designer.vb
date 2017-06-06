<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCustomer
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
        Me.AddCstCompanyLabel = New System.Windows.Forms.Label()
        Me.AddCstFNameLabel = New System.Windows.Forms.Label()
        Me.AddCstLNameLabel = New System.Windows.Forms.Label()
        Me.AddCstStreetLabel = New System.Windows.Forms.Label()
        Me.AddCstCityLabel = New System.Windows.Forms.Label()
        Me.AddCstProvLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCompany = New System.Windows.Forms.TextBox()
        Me.tbFname = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.tbProvince = New System.Windows.Forms.TextBox()
        Me.tbStreet = New System.Windows.Forms.TextBox()
        Me.tbPostalCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddCstCompanyLabel
        '
        Me.AddCstCompanyLabel.AutoSize = True
        Me.AddCstCompanyLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCstCompanyLabel.Location = New System.Drawing.Point(53, 21)
        Me.AddCstCompanyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCstCompanyLabel.Name = "AddCstCompanyLabel"
        Me.AddCstCompanyLabel.Size = New System.Drawing.Size(72, 16)
        Me.AddCstCompanyLabel.TabIndex = 0
        Me.AddCstCompanyLabel.Text = "Company:"
        '
        'AddCstFNameLabel
        '
        Me.AddCstFNameLabel.AutoSize = True
        Me.AddCstFNameLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCstFNameLabel.Location = New System.Drawing.Point(29, 65)
        Me.AddCstFNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCstFNameLabel.Name = "AddCstFNameLabel"
        Me.AddCstFNameLabel.Size = New System.Drawing.Size(96, 16)
        Me.AddCstFNameLabel.TabIndex = 1
        Me.AddCstFNameLabel.Text = "First Name:"
        '
        'AddCstLNameLabel
        '
        Me.AddCstLNameLabel.AutoSize = True
        Me.AddCstLNameLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCstLNameLabel.Location = New System.Drawing.Point(37, 103)
        Me.AddCstLNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCstLNameLabel.Name = "AddCstLNameLabel"
        Me.AddCstLNameLabel.Size = New System.Drawing.Size(88, 16)
        Me.AddCstLNameLabel.TabIndex = 2
        Me.AddCstLNameLabel.Text = "Last Name:"
        '
        'AddCstStreetLabel
        '
        Me.AddCstStreetLabel.AutoSize = True
        Me.AddCstStreetLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCstStreetLabel.Location = New System.Drawing.Point(575, 99)
        Me.AddCstStreetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCstStreetLabel.Name = "AddCstStreetLabel"
        Me.AddCstStreetLabel.Size = New System.Drawing.Size(64, 16)
        Me.AddCstStreetLabel.TabIndex = 3
        Me.AddCstStreetLabel.Text = "Street:"
        '
        'AddCstCityLabel
        '
        Me.AddCstCityLabel.AutoSize = True
        Me.AddCstCityLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCstCityLabel.Location = New System.Drawing.Point(591, 18)
        Me.AddCstCityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCstCityLabel.Name = "AddCstCityLabel"
        Me.AddCstCityLabel.Size = New System.Drawing.Size(48, 16)
        Me.AddCstCityLabel.TabIndex = 4
        Me.AddCstCityLabel.Text = "City:"
        '
        'AddCstProvLabel
        '
        Me.AddCstProvLabel.AutoSize = True
        Me.AddCstProvLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCstProvLabel.Location = New System.Drawing.Point(559, 60)
        Me.AddCstProvLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCstProvLabel.Name = "AddCstProvLabel"
        Me.AddCstProvLabel.Size = New System.Drawing.Size(80, 16)
        Me.AddCstProvLabel.TabIndex = 5
        Me.AddCstProvLabel.Text = "Province:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(535, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Postal Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Home #:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Bus #:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cell #:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 257)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email:"
        '
        'tbCompany
        '
        Me.tbCompany.Location = New System.Drawing.Point(173, 18)
        Me.tbCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCompany.Name = "tbCompany"
        Me.tbCompany.Size = New System.Drawing.Size(229, 22)
        Me.tbCompany.TabIndex = 11
        '
        'tbFname
        '
        Me.tbFname.Location = New System.Drawing.Point(173, 62)
        Me.tbFname.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFname.Name = "tbFname"
        Me.tbFname.Size = New System.Drawing.Size(229, 22)
        Me.tbFname.TabIndex = 12
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(173, 100)
        Me.tbLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(229, 22)
        Me.tbLastName.TabIndex = 13
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(677, 15)
        Me.tbCity.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(229, 22)
        Me.tbCity.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(173, 150)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(173, 254)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(229, 22)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(173, 223)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 22)
        Me.TextBox7.TabIndex = 17
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(173, 191)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(132, 22)
        Me.TextBox8.TabIndex = 18
        '
        'tbProvince
        '
        Me.tbProvince.Location = New System.Drawing.Point(677, 57)
        Me.tbProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.tbProvince.Name = "tbProvince"
        Me.tbProvince.Size = New System.Drawing.Size(229, 22)
        Me.tbProvince.TabIndex = 19
        '
        'tbStreet
        '
        Me.tbStreet.Location = New System.Drawing.Point(677, 96)
        Me.tbStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.tbStreet.Name = "tbStreet"
        Me.tbStreet.Size = New System.Drawing.Size(229, 22)
        Me.tbStreet.TabIndex = 20
        '
        'tbPostalCode
        '
        Me.tbPostalCode.Location = New System.Drawing.Point(677, 133)
        Me.tbPostalCode.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPostalCode.Name = "tbPostalCode"
        Me.tbPostalCode.Size = New System.Drawing.Size(103, 22)
        Me.tbPostalCode.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(564, 220)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 59)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Save and Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(687, 220)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 59)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(940, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbPostalCode)
        Me.Controls.Add(Me.tbStreet)
        Me.Controls.Add(Me.tbProvince)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFname)
        Me.Controls.Add(Me.tbCompany)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddCstProvLabel)
        Me.Controls.Add(Me.AddCstCityLabel)
        Me.Controls.Add(Me.AddCstStreetLabel)
        Me.Controls.Add(Me.AddCstLNameLabel)
        Me.Controls.Add(Me.AddCstFNameLabel)
        Me.Controls.Add(Me.AddCstCompanyLabel)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddCustomer"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddCstCompanyLabel As Label
    Friend WithEvents AddCstFNameLabel As Label
    Friend WithEvents AddCstLNameLabel As Label
    Friend WithEvents AddCstStreetLabel As Label
    Friend WithEvents AddCstCityLabel As Label
    Friend WithEvents AddCstProvLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCompany As TextBox
    Friend WithEvents tbFname As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents tbProvince As TextBox
    Friend WithEvents tbStreet As TextBox
    Friend WithEvents tbPostalCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
