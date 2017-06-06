<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.tbCuID = New System.Windows.Forms.TextBox()
        Me.tbVehID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConverttoWO = New System.Windows.Forms.Button()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPartsEa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotPart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblUnitNo = New System.Windows.Forms.Label()
        Me.lblVin = New System.Windows.Forms.Label()
        Me.lblOdometer = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBCellNum = New System.Windows.Forms.Label()
        Me.lblACellNum = New System.Windows.Forms.Label()
        Me.lblCuBHomeNum = New System.Windows.Forms.Label()
        Me.lblCuAHomeNum = New System.Windows.Forms.Label()
        Me.lblCuLname = New System.Windows.Forms.Label()
        Me.lblCuFname = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWoNo = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox9.Controls.Add(Me.tbTotal)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.btnHistory)
        Me.GroupBox9.Controls.Add(Me.tbCuID)
        Me.GroupBox9.Controls.Add(Me.tbVehID)
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.btnConverttoWO)
        Me.GroupBox9.Controls.Add(Me.dgvInvoice)
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Controls.Add(Me.btnPreview)
        Me.GroupBox9.Controls.Add(Me.btnPrint)
        Me.GroupBox9.Controls.Add(Me.btnSave)
        Me.GroupBox9.Controls.Add(Me.GroupBox8)
        Me.GroupBox9.Controls.Add(Me.GroupBox5)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(718, 590)
        Me.GroupBox9.TabIndex = 15
        Me.GroupBox9.TabStop = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(54, 544)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(75, 31)
        Me.btnHistory.TabIndex = 22
        Me.btnHistory.Text = "HISTORY"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'tbCuID
        '
        Me.tbCuID.Location = New System.Drawing.Point(335, 555)
        Me.tbCuID.Name = "tbCuID"
        Me.tbCuID.Size = New System.Drawing.Size(100, 20)
        Me.tbCuID.TabIndex = 21
        '
        'tbVehID
        '
        Me.tbVehID.Location = New System.Drawing.Point(335, 529)
        Me.tbVehID.Name = "tbVehID"
        Me.tbVehID.Size = New System.Drawing.Size(100, 20)
        Me.tbVehID.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(565, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
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
        Me.btnConverttoWO.Location = New System.Drawing.Point(135, 507)
        Me.btnConverttoWO.Name = "btnConverttoWO"
        Me.btnConverttoWO.Size = New System.Drawing.Size(102, 68)
        Me.btnConverttoWO.TabIndex = 18
        Me.btnConverttoWO.Text = "CONVERT BACK TO WORK ORDER"
        Me.btnConverttoWO.UseVisualStyleBackColor = False
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToAddRows = False
        Me.dgvInvoice.AllowUserToDeleteRows = False
        Me.dgvInvoice.AllowUserToResizeColumns = False
        Me.dgvInvoice.AllowUserToResizeRows = False
        Me.dgvInvoice.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colQty, Me.colHrs, Me.colDesc, Me.colPartsEa, Me.colTotPart, Me.colLabour, Me.colTax, Me.colTotal})
        Me.dgvInvoice.Enabled = False
        Me.dgvInvoice.Location = New System.Drawing.Point(54, 191)
        Me.dgvInvoice.MultiSelect = False
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.ReadOnly = True
        Me.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvInvoice.Size = New System.Drawing.Size(590, 250)
        Me.dgvInvoice.TabIndex = 17
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 35
        '
        'colHrs
        '
        Me.colHrs.HeaderText = "Hrs"
        Me.colHrs.Name = "colHrs"
        Me.colHrs.ReadOnly = True
        Me.colHrs.Width = 35
        '
        'colDesc
        '
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 250
        '
        'colPartsEa
        '
        Me.colPartsEa.HeaderText = "Parts Ea"
        Me.colPartsEa.Name = "colPartsEa"
        Me.colPartsEa.ReadOnly = True
        Me.colPartsEa.Width = 50
        '
        'colTotPart
        '
        Me.colTotPart.HeaderText = "Tot Parts"
        Me.colTotPart.Name = "colTotPart"
        Me.colTotPart.ReadOnly = True
        Me.colTotPart.Width = 50
        '
        'colLabour
        '
        Me.colLabour.HeaderText = "Labour"
        Me.colLabour.Name = "colLabour"
        Me.colLabour.ReadOnly = True
        Me.colLabour.Width = 50
        '
        'colTax
        '
        Me.colTax.HeaderText = "Tx"
        Me.colTax.Name = "colTax"
        Me.colTax.ReadOnly = True
        Me.colTax.Width = 35
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Width = 50
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.lblUnitNo)
        Me.GroupBox6.Controls.Add(Me.lblVin)
        Me.GroupBox6.Controls.Add(Me.lblOdometer)
        Me.GroupBox6.Controls.Add(Me.lblPlate)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.lblModel)
        Me.GroupBox6.Controls.Add(Me.lblMake)
        Me.GroupBox6.Controls.Add(Me.lblYear)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.Button7)
        Me.GroupBox6.Location = New System.Drawing.Point(251, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        '
        'lblUnitNo
        '
        Me.lblUnitNo.AutoSize = True
        Me.lblUnitNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitNo.Location = New System.Drawing.Point(81, 143)
        Me.lblUnitNo.Name = "lblUnitNo"
        Me.lblUnitNo.Size = New System.Drawing.Size(35, 14)
        Me.lblUnitNo.TabIndex = 15
        Me.lblUnitNo.Text = "****"
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVin.Location = New System.Drawing.Point(44, 121)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(35, 14)
        Me.lblVin.TabIndex = 14
        Me.lblVin.Text = "****"
        '
        'lblOdometer
        '
        Me.lblOdometer.AutoSize = True
        Me.lblOdometer.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdometer.Location = New System.Drawing.Point(81, 99)
        Me.lblOdometer.Name = "lblOdometer"
        Me.lblOdometer.Size = New System.Drawing.Size(35, 14)
        Me.lblOdometer.TabIndex = 13
        Me.lblOdometer.Text = "****"
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.Location = New System.Drawing.Point(81, 77)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(35, 14)
        Me.lblPlate.TabIndex = 12
        Me.lblPlate.Text = "****"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Unit #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "VIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Odometer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Plate"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(131, 50)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(42, 14)
        Me.lblModel.TabIndex = 7
        Me.lblModel.Text = "model"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(69, 50)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(35, 14)
        Me.lblMake.TabIndex = 6
        Me.lblMake.Text = "make"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(13, 50)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(35, 14)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button6)
        Me.GroupBox7.Location = New System.Drawing.Point(217, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(184, 23)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(16, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(184, 23)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Vehicle"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(565, 507)
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
        Me.btnPrint.Location = New System.Drawing.Point(484, 507)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 31)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(54, 507)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox8.Controls.Add(Me.lblCompany)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.lblBCellNum)
        Me.GroupBox8.Controls.Add(Me.lblACellNum)
        Me.GroupBox8.Controls.Add(Me.lblCuBHomeNum)
        Me.GroupBox8.Controls.Add(Me.lblCuAHomeNum)
        Me.GroupBox8.Controls.Add(Me.lblCuLname)
        Me.GroupBox8.Controls.Add(Me.lblCuFname)
        Me.GroupBox8.Controls.Add(Me.Button8)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(16, 49)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(56, 14)
        Me.lblCompany.TabIndex = 9
        Me.lblCompany.Text = "Company"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cell#"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Home#"
        '
        'lblBCellNum
        '
        Me.lblBCellNum.AutoSize = True
        Me.lblBCellNum.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCellNum.Location = New System.Drawing.Point(100, 132)
        Me.lblBCellNum.Name = "lblBCellNum"
        Me.lblBCellNum.Size = New System.Drawing.Size(35, 14)
        Me.lblBCellNum.TabIndex = 6
        Me.lblBCellNum.Text = "****"
        '
        'lblACellNum
        '
        Me.lblACellNum.AutoSize = True
        Me.lblACellNum.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACellNum.Location = New System.Drawing.Point(74, 133)
        Me.lblACellNum.Name = "lblACellNum"
        Me.lblACellNum.Size = New System.Drawing.Size(28, 14)
        Me.lblACellNum.TabIndex = 5
        Me.lblACellNum.Text = "***"
        '
        'lblCuBHomeNum
        '
        Me.lblCuBHomeNum.AutoSize = True
        Me.lblCuBHomeNum.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuBHomeNum.Location = New System.Drawing.Point(100, 99)
        Me.lblCuBHomeNum.Name = "lblCuBHomeNum"
        Me.lblCuBHomeNum.Size = New System.Drawing.Size(35, 14)
        Me.lblCuBHomeNum.TabIndex = 4
        Me.lblCuBHomeNum.Text = "****"
        '
        'lblCuAHomeNum
        '
        Me.lblCuAHomeNum.AutoSize = True
        Me.lblCuAHomeNum.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuAHomeNum.Location = New System.Drawing.Point(74, 99)
        Me.lblCuAHomeNum.Name = "lblCuAHomeNum"
        Me.lblCuAHomeNum.Size = New System.Drawing.Size(28, 14)
        Me.lblCuAHomeNum.TabIndex = 3
        Me.lblCuAHomeNum.Text = "***"
        '
        'lblCuLname
        '
        Me.lblCuLname.AutoSize = True
        Me.lblCuLname.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuLname.Location = New System.Drawing.Point(91, 67)
        Me.lblCuLname.Name = "lblCuLname"
        Me.lblCuLname.Size = New System.Drawing.Size(77, 14)
        Me.lblCuLname.TabIndex = 2
        Me.lblCuLname.Text = "lblCuLname"
        '
        'lblCuFname
        '
        Me.lblCuFname.AutoSize = True
        Me.lblCuFname.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuFname.Location = New System.Drawing.Point(16, 67)
        Me.lblCuFname.Name = "lblCuFname"
        Me.lblCuFname.Size = New System.Drawing.Size(77, 14)
        Me.lblCuFname.TabIndex = 1
        Me.lblCuFname.Text = "lblCuFname"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button8.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(16, 10)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(184, 23)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Customer"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.lblWoNo)
        Me.GroupBox5.Controls.Add(Me.lblInvoiceNo)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(496, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(54, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "***"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 14)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Manager"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "WO#"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INV#"
        '
        'lblWoNo
        '
        Me.lblWoNo.AutoSize = True
        Me.lblWoNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWoNo.Location = New System.Drawing.Point(149, 50)
        Me.lblWoNo.Name = "lblWoNo"
        Me.lblWoNo.Size = New System.Drawing.Size(28, 14)
        Me.lblWoNo.TabIndex = 2
        Me.lblWoNo.Text = "***"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(54, 50)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(28, 14)
        Me.lblInvoiceNo.TabIndex = 1
        Me.lblInvoiceNo.Text = "***"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(16, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(184, 23)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Work Order Admin."
        Me.Button5.UseVisualStyleBackColor = False
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(569, 440)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(75, 20)
        Me.tbTotal.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(515, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Total"
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(746, 614)
        Me.Controls.Add(Me.GroupBox9)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblUnitNo As Label
    Friend WithEvents lblVin As Label
    Friend WithEvents lblOdometer As Label
    Friend WithEvents lblPlate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBCellNum As Label
    Friend WithEvents lblACellNum As Label
    Friend WithEvents lblCuBHomeNum As Label
    Friend WithEvents lblCuAHomeNum As Label
    Friend WithEvents lblCuLname As Label
    Friend WithEvents lblCuFname As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colHrs As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colPartsEa As DataGridViewTextBoxColumn
    Friend WithEvents colTotPart As DataGridViewTextBoxColumn
    Friend WithEvents colLabour As DataGridViewTextBoxColumn
    Friend WithEvents colTax As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents btnConverttoWO As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents tbCuID As TextBox
    Friend WithEvents tbVehID As TextBox
    Friend WithEvents lblWoNo As Label
    Friend WithEvents btnHistory As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label12 As Label
End Class
