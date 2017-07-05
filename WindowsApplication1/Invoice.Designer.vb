<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEngSize = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUnitNo = New System.Windows.Forms.Label()
        Me.lblVin = New System.Windows.Forms.Label()
        Me.lblOdometer = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblVeh = New System.Windows.Forms.Label()
        Me.btnVehicle2 = New System.Windows.Forms.Button()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblBBusNum = New System.Windows.Forms.Label()
        Me.lblABusNum = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblBCellNum = New System.Windows.Forms.Label()
        Me.lblACellNum = New System.Windows.Forms.Label()
        Me.lblBHomeNum = New System.Windows.Forms.Label()
        Me.lblAHomeNum = New System.Windows.Forms.Label()
        Me.lblCuFname = New System.Windows.Forms.Label()
        Me.btnCustomer2 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblInv = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblAdminName = New System.Windows.Forms.Label()
        Me.lblWoNo = New System.Windows.Forms.Label()
        Me.btnAdmin2 = New System.Windows.Forms.Button()
        Me.tbSubTot = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.tbTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConverttoWO = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox9.Controls.Add(Me.GroupBox2)
        Me.GroupBox9.Controls.Add(Me.dgvInvoice)
        Me.GroupBox9.Controls.Add(Me.Label23)
        Me.GroupBox9.Controls.Add(Me.GroupBox4)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.tbSubTot)
        Me.GroupBox9.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox9.Controls.Add(Me.tbTax)
        Me.GroupBox9.Controls.Add(Me.lblTax)
        Me.GroupBox9.Controls.Add(Me.tbTotal)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.btnConverttoWO)
        Me.GroupBox9.Controls.Add(Me.btnPreview)
        Me.GroupBox9.Controls.Add(Me.btnPrint)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(832, 590)
        Me.GroupBox9.TabIndex = 15
        Me.GroupBox9.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.lblEngSize)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblUnitNo)
        Me.GroupBox2.Controls.Add(Me.lblVin)
        Me.GroupBox2.Controls.Add(Me.lblOdometer)
        Me.GroupBox2.Controls.Add(Me.lblPlate)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblVeh)
        Me.GroupBox2.Controls.Add(Me.btnVehicle2)
        Me.GroupBox2.Location = New System.Drawing.Point(251, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 171)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'lblEngSize
        '
        Me.lblEngSize.AutoSize = True
        Me.lblEngSize.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEngSize.Location = New System.Drawing.Point(199, 143)
        Me.lblEngSize.Name = "lblEngSize"
        Me.lblEngSize.Size = New System.Drawing.Size(17, 17)
        Me.lblEngSize.TabIndex = 19
        Me.lblEngSize.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label22.Location = New System.Drawing.Point(158, 143)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 17)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Eng"
        '
        'lblUnitNo
        '
        Me.lblUnitNo.AutoSize = True
        Me.lblUnitNo.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitNo.Location = New System.Drawing.Point(93, 142)
        Me.lblUnitNo.Name = "lblUnitNo"
        Me.lblUnitNo.Size = New System.Drawing.Size(17, 17)
        Me.lblUnitNo.TabIndex = 15
        Me.lblUnitNo.Text = "*"
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVin.Location = New System.Drawing.Point(93, 122)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(17, 17)
        Me.lblVin.TabIndex = 14
        Me.lblVin.Text = "*"
        '
        'lblOdometer
        '
        Me.lblOdometer.AutoSize = True
        Me.lblOdometer.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdometer.Location = New System.Drawing.Point(93, 98)
        Me.lblOdometer.Name = "lblOdometer"
        Me.lblOdometer.Size = New System.Drawing.Size(17, 17)
        Me.lblOdometer.TabIndex = 13
        Me.lblOdometer.Text = "*"
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.Location = New System.Drawing.Point(93, 76)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(17, 17)
        Me.lblPlate.TabIndex = 12
        Me.lblPlate.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(13, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Unit #"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(13, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "VIN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(13, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 17)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Odometer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label17.Location = New System.Drawing.Point(13, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Plate"
        '
        'lblVeh
        '
        Me.lblVeh.AutoSize = True
        Me.lblVeh.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeh.Location = New System.Drawing.Point(13, 49)
        Me.lblVeh.Name = "lblVeh"
        Me.lblVeh.Size = New System.Drawing.Size(17, 17)
        Me.lblVeh.TabIndex = 5
        Me.lblVeh.Text = "*"
        '
        'btnVehicle2
        '
        Me.btnVehicle2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnVehicle2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicle2.Location = New System.Drawing.Point(71, 10)
        Me.btnVehicle2.Name = "btnVehicle2"
        Me.btnVehicle2.Size = New System.Drawing.Size(184, 23)
        Me.btnVehicle2.TabIndex = 0
        Me.btnVehicle2.Text = "Vehicle"
        Me.btnVehicle2.UseVisualStyleBackColor = False
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToAddRows = False
        Me.dgvInvoice.AllowUserToDeleteRows = False
        Me.dgvInvoice.AllowUserToResizeColumns = False
        Me.dgvInvoice.AllowUserToResizeRows = False
        Me.dgvInvoice.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInvoice.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvInvoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvInvoice.Enabled = False
        Me.dgvInvoice.Location = New System.Drawing.Point(78, 209)
        Me.dgvInvoice.MultiSelect = False
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvoice.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvInvoice.RowHeadersVisible = False
        Me.dgvInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvInvoice.Size = New System.Drawing.Size(614, 225)
        Me.dgvInvoice.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 38
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hrs"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 38
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 280
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Parts Ea"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 53
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tot Parts"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 53
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Labour"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 57
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tx"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 35
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 56
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(539, 434)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 16)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "SubTotal"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.lblBBusNum)
        Me.GroupBox4.Controls.Add(Me.lblABusNum)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.lblCompany)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.lblBCellNum)
        Me.GroupBox4.Controls.Add(Me.lblACellNum)
        Me.GroupBox4.Controls.Add(Me.lblBHomeNum)
        Me.GroupBox4.Controls.Add(Me.lblAHomeNum)
        Me.GroupBox4.Controls.Add(Me.lblCuFname)
        Me.GroupBox4.Controls.Add(Me.btnCustomer2)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 171)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'lblBBusNum
        '
        Me.lblBBusNum.AutoSize = True
        Me.lblBBusNum.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBBusNum.Location = New System.Drawing.Point(109, 85)
        Me.lblBBusNum.Name = "lblBBusNum"
        Me.lblBBusNum.Size = New System.Drawing.Size(17, 17)
        Me.lblBBusNum.TabIndex = 12
        Me.lblBBusNum.Text = "*"
        '
        'lblABusNum
        '
        Me.lblABusNum.AutoSize = True
        Me.lblABusNum.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblABusNum.Location = New System.Drawing.Point(69, 85)
        Me.lblABusNum.Name = "lblABusNum"
        Me.lblABusNum.Size = New System.Drawing.Size(17, 17)
        Me.lblABusNum.TabIndex = 11
        Me.lblABusNum.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Location = New System.Drawing.Point(19, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 17)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Bus#"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(19, 36)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(17, 17)
        Me.lblCompany.TabIndex = 9
        Me.lblCompany.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Location = New System.Drawing.Point(12, 131)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 17)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Cell#"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label21.Location = New System.Drawing.Point(12, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 17)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Home#"
        '
        'lblBCellNum
        '
        Me.lblBCellNum.AutoSize = True
        Me.lblBCellNum.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCellNum.Location = New System.Drawing.Point(109, 130)
        Me.lblBCellNum.Name = "lblBCellNum"
        Me.lblBCellNum.Size = New System.Drawing.Size(17, 17)
        Me.lblBCellNum.TabIndex = 6
        Me.lblBCellNum.Text = "*"
        '
        'lblACellNum
        '
        Me.lblACellNum.AutoSize = True
        Me.lblACellNum.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACellNum.Location = New System.Drawing.Point(69, 130)
        Me.lblACellNum.Name = "lblACellNum"
        Me.lblACellNum.Size = New System.Drawing.Size(17, 17)
        Me.lblACellNum.TabIndex = 5
        Me.lblACellNum.Text = "*"
        '
        'lblBHomeNum
        '
        Me.lblBHomeNum.AutoSize = True
        Me.lblBHomeNum.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBHomeNum.Location = New System.Drawing.Point(109, 107)
        Me.lblBHomeNum.Name = "lblBHomeNum"
        Me.lblBHomeNum.Size = New System.Drawing.Size(17, 17)
        Me.lblBHomeNum.TabIndex = 4
        Me.lblBHomeNum.Text = "*"
        '
        'lblAHomeNum
        '
        Me.lblAHomeNum.AutoSize = True
        Me.lblAHomeNum.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAHomeNum.Location = New System.Drawing.Point(69, 107)
        Me.lblAHomeNum.Name = "lblAHomeNum"
        Me.lblAHomeNum.Size = New System.Drawing.Size(17, 17)
        Me.lblAHomeNum.TabIndex = 3
        Me.lblAHomeNum.Text = "*"
        '
        'lblCuFname
        '
        Me.lblCuFname.AutoSize = True
        Me.lblCuFname.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuFname.Location = New System.Drawing.Point(19, 61)
        Me.lblCuFname.Name = "lblCuFname"
        Me.lblCuFname.Size = New System.Drawing.Size(17, 17)
        Me.lblCuFname.TabIndex = 1
        Me.lblCuFname.Text = "*"
        '
        'btnCustomer2
        '
        Me.btnCustomer2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCustomer2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer2.Location = New System.Drawing.Point(16, 10)
        Me.btnCustomer2.Name = "btnCustomer2"
        Me.btnCustomer2.Size = New System.Drawing.Size(184, 23)
        Me.btnCustomer2.TabIndex = 0
        Me.btnCustomer2.Text = "Customer"
        Me.btnCustomer2.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Controls.Add(Me.lblInv)
        Me.GroupBox10.Controls.Add(Me.lblReg)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Controls.Add(Me.Label25)
        Me.GroupBox10.Controls.Add(Me.Label26)
        Me.GroupBox10.Controls.Add(Me.lblDate)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.lblAdminName)
        Me.GroupBox10.Controls.Add(Me.lblWoNo)
        Me.GroupBox10.Controls.Add(Me.btnAdmin2)
        Me.GroupBox10.Location = New System.Drawing.Point(609, 14)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(216, 171)
        Me.GroupBox10.TabIndex = 13
        Me.GroupBox10.TabStop = False
        '
        'lblInv
        '
        Me.lblInv.AutoSize = True
        Me.lblInv.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInv.Location = New System.Drawing.Point(145, 49)
        Me.lblInv.Name = "lblInv"
        Me.lblInv.Size = New System.Drawing.Size(17, 17)
        Me.lblInv.TabIndex = 23
        Me.lblInv.Text = "*"
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.Location = New System.Drawing.Point(63, 76)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(17, 17)
        Me.lblReg.TabIndex = 22
        Me.lblReg.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label24.Location = New System.Drawing.Point(13, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 17)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "REG#"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label25.Location = New System.Drawing.Point(13, 139)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 17)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Tech."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label26.Location = New System.Drawing.Point(95, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 17)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "INV#"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(63, 107)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(17, 17)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label33.Location = New System.Drawing.Point(13, 108)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 17)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Date"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label34.Location = New System.Drawing.Point(13, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(35, 17)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "WO#"
        '
        'lblAdminName
        '
        Me.lblAdminName.AutoSize = True
        Me.lblAdminName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminName.Location = New System.Drawing.Point(63, 138)
        Me.lblAdminName.Name = "lblAdminName"
        Me.lblAdminName.Size = New System.Drawing.Size(17, 17)
        Me.lblAdminName.TabIndex = 3
        Me.lblAdminName.Text = "*"
        '
        'lblWoNo
        '
        Me.lblWoNo.AutoSize = True
        Me.lblWoNo.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWoNo.Location = New System.Drawing.Point(63, 49)
        Me.lblWoNo.Name = "lblWoNo"
        Me.lblWoNo.Size = New System.Drawing.Size(17, 17)
        Me.lblWoNo.TabIndex = 1
        Me.lblWoNo.Text = "*"
        '
        'btnAdmin2
        '
        Me.btnAdmin2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdmin2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin2.Location = New System.Drawing.Point(16, 10)
        Me.btnAdmin2.Name = "btnAdmin2"
        Me.btnAdmin2.Size = New System.Drawing.Size(184, 23)
        Me.btnAdmin2.TabIndex = 0
        Me.btnAdmin2.Text = "Work Order Admin."
        Me.btnAdmin2.UseVisualStyleBackColor = False
        '
        'tbSubTot
        '
        Me.tbSubTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSubTot.Location = New System.Drawing.Point(617, 433)
        Me.tbSubTot.Name = "tbSubTot"
        Me.tbSubTot.ReadOnly = True
        Me.tbSubTot.Size = New System.Drawing.Size(75, 20)
        Me.tbSubTot.TabIndex = 29
        Me.tbSubTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(219, 511)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(39, 20)
        Me.NumericUpDown1.TabIndex = 28
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbTax
        '
        Me.tbTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTax.Location = New System.Drawing.Point(617, 452)
        Me.tbTax.Name = "tbTax"
        Me.tbTax.ReadOnly = True
        Me.tbTax.Size = New System.Drawing.Size(75, 20)
        Me.tbTax.TabIndex = 27
        Me.tbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(579, 453)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(32, 16)
        Me.lblTax.TabIndex = 26
        Me.lblTax.Text = "Tax"
        '
        'tbTotal
        '
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotal.Location = New System.Drawing.Point(617, 471)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(75, 20)
        Me.tbTotal.TabIndex = 24
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(563, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Total"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(750, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnConverttoWO
        '
        Me.btnConverttoWO.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnConverttoWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConverttoWO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConverttoWO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConverttoWO.Location = New System.Drawing.Point(30, 505)
        Me.btnConverttoWO.Name = "btnConverttoWO"
        Me.btnConverttoWO.Size = New System.Drawing.Size(102, 68)
        Me.btnConverttoWO.TabIndex = 18
        Me.btnConverttoWO.Text = "CONVERT BACK TO WORK ORDER"
        Me.btnConverttoWO.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(138, 542)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 31)
        Me.btnPreview.TabIndex = 13
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(138, 505)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 31)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintDoc
        '
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(864, 615)
        Me.Controls.Add(Me.GroupBox9)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnConverttoWO As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents tbTax As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents tbSubTot As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEngSize As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblUnitNo As Label
    Friend WithEvents lblVin As Label
    Friend WithEvents lblOdometer As Label
    Friend WithEvents lblPlate As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblVeh As Label
    Friend WithEvents btnVehicle2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblBBusNum As Label
    Friend WithEvents lblABusNum As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblBCellNum As Label
    Friend WithEvents lblACellNum As Label
    Friend WithEvents lblBHomeNum As Label
    Friend WithEvents lblAHomeNum As Label
    Friend WithEvents lblCuFname As Label
    Friend WithEvents btnCustomer2 As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lblInv As Label
    Friend WithEvents lblReg As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblAdminName As Label
    Friend WithEvents lblWoNo As Label
    Friend WithEvents btnAdmin2 As Button
End Class
