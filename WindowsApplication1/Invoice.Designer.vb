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
        Me.btnSaveWR = New System.Windows.Forms.Button()
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
        Me.dgvWorkOrder = New System.Windows.Forms.DataGridView()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPartsEa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotPart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox9.Controls.Add(Me.dgvWorkOrder)
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Controls.Add(Me.btnPreview)
        Me.GroupBox9.Controls.Add(Me.btnPrint)
        Me.GroupBox9.Controls.Add(Me.btnSaveWR)
        Me.GroupBox9.Controls.Add(Me.GroupBox8)
        Me.GroupBox9.Controls.Add(Me.GroupBox5)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(718, 556)
        Me.GroupBox9.TabIndex = 15
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
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(342, 482)
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
        Me.btnPrint.Location = New System.Drawing.Point(512, 482)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 32)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSaveWR
        '
        Me.btnSaveWR.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveWR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveWR.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveWR.Location = New System.Drawing.Point(173, 482)
        Me.btnSaveWR.Name = "btnSaveWR"
        Me.btnSaveWR.Size = New System.Drawing.Size(75, 32)
        Me.btnSaveWR.TabIndex = 10
        Me.btnSaveWR.Text = "Save"
        Me.btnSaveWR.UseVisualStyleBackColor = False
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
        'dgvWorkOrder
        '
        Me.dgvWorkOrder.AllowUserToResizeColumns = False
        Me.dgvWorkOrder.AllowUserToResizeRows = False
        Me.dgvWorkOrder.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colQty, Me.colHrs, Me.colDesc, Me.colPartsEa, Me.colTotPart, Me.colLabour, Me.colTax, Me.colTotal})
        Me.dgvWorkOrder.Location = New System.Drawing.Point(54, 198)
        Me.dgvWorkOrder.MultiSelect = False
        Me.dgvWorkOrder.Name = "dgvWorkOrder"
        Me.dgvWorkOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvWorkOrder.Size = New System.Drawing.Size(590, 225)
        Me.dgvWorkOrder.TabIndex = 17
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
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(746, 580)
        Me.Controls.Add(Me.GroupBox9)
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSaveWR As Button
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
    Friend WithEvents dgvWorkOrder As DataGridView
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colHrs As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colPartsEa As DataGridViewTextBoxColumn
    Friend WithEvents colTotPart As DataGridViewTextBoxColumn
    Friend WithEvents colLabour As DataGridViewTextBoxColumn
    Friend WithEvents colTax As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
End Class
