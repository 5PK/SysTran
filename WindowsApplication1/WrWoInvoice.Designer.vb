<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WrWoInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WrWoInvoice))
        Me.tbVehID = New System.Windows.Forms.TextBox()
        Me.tcWorkFlow = New System.Windows.Forms.TabControl()
        Me.tpWorkRequest = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
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
        Me.tbWorkRequests = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tpWorkOrder = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveAndCnvrtToInvoice = New System.Windows.Forms.Button()
        Me.dgvWorkOrder = New System.Windows.Forms.DataGridView()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPartsEa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotPart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblWOCuFname = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnSaveWRWO = New System.Windows.Forms.Button()
        Me.tbCuID = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnSaveAndExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbWOno = New System.Windows.Forms.TextBox()
        Me.tcWorkFlow.SuspendLayout()
        Me.tpWorkRequest.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tpWorkOrder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbVehID
        '
        Me.tbVehID.Location = New System.Drawing.Point(252, 0)
        Me.tbVehID.Name = "tbVehID"
        Me.tbVehID.ReadOnly = True
        Me.tbVehID.Size = New System.Drawing.Size(100, 20)
        Me.tbVehID.TabIndex = 3
        '
        'tcWorkFlow
        '
        Me.tcWorkFlow.Controls.Add(Me.tpWorkRequest)
        Me.tcWorkFlow.Controls.Add(Me.tpWorkOrder)
        Me.tcWorkFlow.Location = New System.Drawing.Point(28, 26)
        Me.tcWorkFlow.Name = "tcWorkFlow"
        Me.tcWorkFlow.SelectedIndex = 0
        Me.tcWorkFlow.Size = New System.Drawing.Size(734, 488)
        Me.tcWorkFlow.TabIndex = 2
        '
        'tpWorkRequest
        '
        Me.tpWorkRequest.BackColor = System.Drawing.Color.Gainsboro
        Me.tpWorkRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpWorkRequest.Controls.Add(Me.GroupBox9)
        Me.tpWorkRequest.Location = New System.Drawing.Point(4, 22)
        Me.tpWorkRequest.Name = "tpWorkRequest"
        Me.tpWorkRequest.Size = New System.Drawing.Size(726, 462)
        Me.tpWorkRequest.TabIndex = 2
        Me.tpWorkRequest.Text = "Work Request"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Controls.Add(Me.tbWorkRequests)
        Me.GroupBox9.Controls.Add(Me.btnPreview)
        Me.GroupBox9.Controls.Add(Me.btnPrint)
        Me.GroupBox9.Controls.Add(Me.GroupBox8)
        Me.GroupBox9.Controls.Add(Me.GroupBox5)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(718, 454)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
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
        Me.lblUnitNo.Location = New System.Drawing.Point(88, 143)
        Me.lblUnitNo.Name = "lblUnitNo"
        Me.lblUnitNo.Size = New System.Drawing.Size(31, 13)
        Me.lblUnitNo.TabIndex = 15
        Me.lblUnitNo.Text = "Plate"
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Location = New System.Drawing.Point(44, 121)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(31, 13)
        Me.lblVin.TabIndex = 14
        Me.lblVin.Text = "Plate"
        '
        'lblOdometer
        '
        Me.lblOdometer.AutoSize = True
        Me.lblOdometer.Location = New System.Drawing.Point(88, 99)
        Me.lblOdometer.Name = "lblOdometer"
        Me.lblOdometer.Size = New System.Drawing.Size(31, 13)
        Me.lblOdometer.TabIndex = 13
        Me.lblOdometer.Text = "Plate"
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Location = New System.Drawing.Point(88, 77)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(31, 13)
        Me.lblPlate.TabIndex = 12
        Me.lblPlate.Text = "Plate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Unit #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "VIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Odometer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Plate"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(131, 50)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(35, 13)
        Me.lblModel.TabIndex = 7
        Me.lblModel.Text = "model"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(69, 50)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(33, 13)
        Me.lblMake.TabIndex = 6
        Me.lblMake.Text = "make"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(13, 50)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
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
        'tbWorkRequests
        '
        Me.tbWorkRequests.BackColor = System.Drawing.SystemColors.Control
        Me.tbWorkRequests.Location = New System.Drawing.Point(70, 211)
        Me.tbWorkRequests.Multiline = True
        Me.tbWorkRequests.Name = "tbWorkRequests"
        Me.tbWorkRequests.Size = New System.Drawing.Size(461, 182)
        Me.tbWorkRequests.TabIndex = 12
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(552, 318)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 32)
        Me.btnPreview.TabIndex = 13
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(552, 265)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 32)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.Control
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cell#"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "home#"
        '
        'lblBCellNum
        '
        Me.lblBCellNum.AutoSize = True
        Me.lblBCellNum.Location = New System.Drawing.Point(106, 112)
        Me.lblBCellNum.Name = "lblBCellNum"
        Me.lblBCellNum.Size = New System.Drawing.Size(43, 13)
        Me.lblBCellNum.TabIndex = 6
        Me.lblBCellNum.Text = "cellnum"
        '
        'lblACellNum
        '
        Me.lblACellNum.AutoSize = True
        Me.lblACellNum.Location = New System.Drawing.Point(61, 112)
        Me.lblACellNum.Name = "lblACellNum"
        Me.lblACellNum.Size = New System.Drawing.Size(43, 13)
        Me.lblACellNum.TabIndex = 5
        Me.lblACellNum.Text = "cellnum"
        '
        'lblCuBHomeNum
        '
        Me.lblCuBHomeNum.AutoSize = True
        Me.lblCuBHomeNum.Location = New System.Drawing.Point(106, 80)
        Me.lblCuBHomeNum.Name = "lblCuBHomeNum"
        Me.lblCuBHomeNum.Size = New System.Drawing.Size(53, 13)
        Me.lblCuBHomeNum.TabIndex = 4
        Me.lblCuBHomeNum.Text = "homenum"
        '
        'lblCuAHomeNum
        '
        Me.lblCuAHomeNum.AutoSize = True
        Me.lblCuAHomeNum.Location = New System.Drawing.Point(61, 80)
        Me.lblCuAHomeNum.Name = "lblCuAHomeNum"
        Me.lblCuAHomeNum.Size = New System.Drawing.Size(53, 13)
        Me.lblCuAHomeNum.TabIndex = 3
        Me.lblCuAHomeNum.Text = "homenum"
        '
        'lblCuLname
        '
        Me.lblCuLname.AutoSize = True
        Me.lblCuLname.Location = New System.Drawing.Point(97, 50)
        Me.lblCuLname.Name = "lblCuLname"
        Me.lblCuLname.Size = New System.Drawing.Size(62, 13)
        Me.lblCuLname.TabIndex = 2
        Me.lblCuLname.Text = "lblCuLname"
        '
        'lblCuFname
        '
        Me.lblCuFname.AutoSize = True
        Me.lblCuFname.Location = New System.Drawing.Point(16, 50)
        Me.lblCuFname.Name = "lblCuFname"
        Me.lblCuFname.Size = New System.Drawing.Size(62, 13)
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
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(496, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
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
        'tpWorkOrder
        '
        Me.tpWorkOrder.BackColor = System.Drawing.Color.Gainsboro
        Me.tpWorkOrder.Controls.Add(Me.GroupBox1)
        Me.tpWorkOrder.Location = New System.Drawing.Point(4, 22)
        Me.tpWorkOrder.Name = "tpWorkOrder"
        Me.tpWorkOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWorkOrder.Size = New System.Drawing.Size(726, 462)
        Me.tpWorkOrder.TabIndex = 0
        Me.tpWorkOrder.Text = "Work Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSaveAndCnvrtToInvoice)
        Me.GroupBox1.Controls.Add(Me.dgvWorkOrder)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox10)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 456)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btnSaveAndCnvrtToInvoice
        '
        Me.btnSaveAndCnvrtToInvoice.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSaveAndCnvrtToInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAndCnvrtToInvoice.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAndCnvrtToInvoice.Location = New System.Drawing.Point(602, 303)
        Me.btnSaveAndCnvrtToInvoice.Name = "btnSaveAndCnvrtToInvoice"
        Me.btnSaveAndCnvrtToInvoice.Size = New System.Drawing.Size(110, 46)
        Me.btnSaveAndCnvrtToInvoice.TabIndex = 17
        Me.btnSaveAndCnvrtToInvoice.Text = "CONVERT TO INVOICE"
        Me.btnSaveAndCnvrtToInvoice.UseVisualStyleBackColor = False
        '
        'dgvWorkOrder
        '
        Me.dgvWorkOrder.AllowUserToResizeColumns = False
        Me.dgvWorkOrder.AllowUserToResizeRows = False
        Me.dgvWorkOrder.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colQty, Me.colHrs, Me.colDesc, Me.colPartsEa, Me.colTotPart, Me.colLabour, Me.colTax, Me.colTotal})
        Me.dgvWorkOrder.Location = New System.Drawing.Point(6, 213)
        Me.dgvWorkOrder.MultiSelect = False
        Me.dgvWorkOrder.Name = "dgvWorkOrder"
        Me.dgvWorkOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvWorkOrder.Size = New System.Drawing.Size(590, 225)
        Me.dgvWorkOrder.TabIndex = 16
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 35
        '
        'colHrs
        '
        Me.colHrs.HeaderText = "Hrs"
        Me.colHrs.Name = "colHrs"
        Me.colHrs.Width = 35
        '
        'colDesc
        '
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.Width = 250
        '
        'colPartsEa
        '
        Me.colPartsEa.HeaderText = "Parts Ea"
        Me.colPartsEa.Name = "colPartsEa"
        Me.colPartsEa.Width = 50
        '
        'colTotPart
        '
        Me.colTotPart.HeaderText = "Tot Parts"
        Me.colTotPart.Name = "colTotPart"
        Me.colTotPart.Width = 50
        '
        'colLabour
        '
        Me.colLabour.HeaderText = "Labour"
        Me.colLabour.Name = "colLabour"
        Me.colLabour.Width = 50
        '
        'colTax
        '
        Me.colTax.HeaderText = "Tx"
        Me.colTax.Name = "colTax"
        Me.colTax.Width = 35
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Width = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(251, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Plate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Plate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Plate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Plate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Unit #"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "VIN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Odometer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Plate"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(131, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "model"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(69, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "make"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Year"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(217, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(16, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Vehicle"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.lblWOCuFname)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Cell#"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "home#"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(106, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "cellnum"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(61, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "cellnum"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(106, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "homenum"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(61, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "homenum"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(97, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Label24"
        '
        'lblWOCuFname
        '
        Me.lblWOCuFname.AutoSize = True
        Me.lblWOCuFname.Location = New System.Drawing.Point(16, 50)
        Me.lblWOCuFname.Name = "lblWOCuFname"
        Me.lblWOCuFname.Size = New System.Drawing.Size(45, 13)
        Me.lblWOCuFname.TabIndex = 1
        Me.lblWOCuFname.Text = "Label25"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCoral
        Me.Button4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(16, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Customer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Controls.Add(Me.Button9)
        Me.GroupBox10.Location = New System.Drawing.Point(496, 16)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightCoral
        Me.Button9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(16, 10)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(184, 23)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Work Order Admin."
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnSaveWRWO
        '
        Me.btnSaveWRWO.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveWRWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveWRWO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWRWO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveWRWO.Location = New System.Drawing.Point(221, 531)
        Me.btnSaveWRWO.Name = "btnSaveWRWO"
        Me.btnSaveWRWO.Size = New System.Drawing.Size(85, 55)
        Me.btnSaveWRWO.TabIndex = 10
        Me.btnSaveWRWO.Text = "SAVE"
        Me.btnSaveWRWO.UseVisualStyleBackColor = False
        '
        'tbCuID
        '
        Me.tbCuID.Location = New System.Drawing.Point(352, 0)
        Me.tbCuID.Name = "tbCuID"
        Me.tbCuID.ReadOnly = True
        Me.tbCuID.Size = New System.Drawing.Size(100, 20)
        Me.tbCuID.TabIndex = 5
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnSaveAndExit
        '
        Me.btnSaveAndExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnSaveAndExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAndExit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAndExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveAndExit.Location = New System.Drawing.Point(334, 531)
        Me.btnSaveAndExit.Name = "btnSaveAndExit"
        Me.btnSaveAndExit.Size = New System.Drawing.Size(85, 55)
        Me.btnSaveAndExit.TabIndex = 11
        Me.btnSaveAndExit.Text = "SAVE AND EXIT"
        Me.btnSaveAndExit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Crimson
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(448, 531)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 55)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tbWOno
        '
        Me.tbWOno.Location = New System.Drawing.Point(448, 0)
        Me.tbWOno.Name = "tbWOno"
        Me.tbWOno.ReadOnly = True
        Me.tbWOno.Size = New System.Drawing.Size(100, 20)
        Me.tbWOno.TabIndex = 13
        '
        'WrWoInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(790, 609)
        Me.Controls.Add(Me.tbWOno)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveAndExit)
        Me.Controls.Add(Me.tbCuID)
        Me.Controls.Add(Me.btnSaveWRWO)
        Me.Controls.Add(Me.tbVehID)
        Me.Controls.Add(Me.tcWorkFlow)
        Me.Name = "WrWoInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Flow"
        Me.tcWorkFlow.ResumeLayout(False)
        Me.tpWorkRequest.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.tpWorkOrder.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbVehID As TextBox
    Friend WithEvents tcWorkFlow As TabControl
    Friend WithEvents tpWorkRequest As TabPage
    Friend WithEvents tpWorkOrder As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblCuFname As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSaveWRWO As Button
    Friend WithEvents lblCuLname As Label
    Friend WithEvents lblCuAHomeNum As Label
    Friend WithEvents tbWorkRequests As TextBox
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBCellNum As Label
    Friend WithEvents lblACellNum As Label
    Friend WithEvents lblCuBHomeNum As Label
    Friend WithEvents tbCuID As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPreview As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvWorkOrder As DataGridView
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colHrs As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colPartsEa As DataGridViewTextBoxColumn
    Friend WithEvents colTotPart As DataGridViewTextBoxColumn
    Friend WithEvents colLabour As DataGridViewTextBoxColumn
    Friend WithEvents colTax As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblWOCuFname As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Button9 As Button
    Friend WithEvents btnSaveAndExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveAndCnvrtToInvoice As Button
    Friend WithEvents tbWOno As TextBox
End Class
