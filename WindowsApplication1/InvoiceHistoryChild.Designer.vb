<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceHistoryChild
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPartsEa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotPart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblWoNo = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.lblCuLname = New System.Windows.Forms.Label()
        Me.lblCuFname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbSubtot = New System.Windows.Forms.TextBox()
        Me.tbTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colQty, Me.colHrs, Me.colDesc, Me.colPartsEa, Me.colTotPart, Me.colLabour, Me.colTax, Me.colTotal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInvoice.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInvoice.Enabled = False
        Me.dgvInvoice.Location = New System.Drawing.Point(12, 154)
        Me.dgvInvoice.MultiSelect = False
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvoice.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInvoice.RowHeadersVisible = False
        Me.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoice.Size = New System.Drawing.Size(590, 250)
        Me.dgvInvoice.TabIndex = 18
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 38
        '
        'colHrs
        '
        Me.colHrs.HeaderText = "Hrs"
        Me.colHrs.Name = "colHrs"
        Me.colHrs.ReadOnly = True
        Me.colHrs.Width = 38
        '
        'colDesc
        '
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 275
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
        'lblUnitNo
        '
        Me.lblUnitNo.AutoSize = True
        Me.lblUnitNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitNo.Location = New System.Drawing.Point(81, 125)
        Me.lblUnitNo.Name = "lblUnitNo"
        Me.lblUnitNo.Size = New System.Drawing.Size(28, 14)
        Me.lblUnitNo.TabIndex = 29
        Me.lblUnitNo.Text = "***"
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVin.Location = New System.Drawing.Point(81, 103)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(28, 14)
        Me.lblVin.TabIndex = 28
        Me.lblVin.Text = "***"
        '
        'lblOdometer
        '
        Me.lblOdometer.AutoSize = True
        Me.lblOdometer.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdometer.Location = New System.Drawing.Point(81, 81)
        Me.lblOdometer.Name = "lblOdometer"
        Me.lblOdometer.Size = New System.Drawing.Size(28, 14)
        Me.lblOdometer.TabIndex = 27
        Me.lblOdometer.Text = "***"
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.Location = New System.Drawing.Point(81, 59)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(28, 14)
        Me.lblPlate.TabIndex = 26
        Me.lblPlate.Text = "***"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Unit #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "VIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Odometer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Plate"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(106, 32)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(42, 14)
        Me.lblModel.TabIndex = 21
        Me.lblModel.Text = "model"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(56, 32)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(35, 14)
        Me.lblMake.TabIndex = 20
        Me.lblMake.Text = "make"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(12, 32)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(35, 14)
        Me.lblYear.TabIndex = 19
        Me.lblYear.Text = "Year"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(283, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblWoNo
        '
        Me.lblWoNo.AutoSize = True
        Me.lblWoNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWoNo.Location = New System.Drawing.Point(233, 59)
        Me.lblWoNo.Name = "lblWoNo"
        Me.lblWoNo.Size = New System.Drawing.Size(28, 14)
        Me.lblWoNo.TabIndex = 32
        Me.lblWoNo.Text = "***"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(233, 32)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(28, 14)
        Me.lblInvoiceNo.TabIndex = 31
        Me.lblInvoiceNo.Text = "***"
        '
        'lblCuLname
        '
        Me.lblCuLname.AutoSize = True
        Me.lblCuLname.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuLname.Location = New System.Drawing.Point(485, 59)
        Me.lblCuLname.Name = "lblCuLname"
        Me.lblCuLname.Size = New System.Drawing.Size(77, 14)
        Me.lblCuLname.TabIndex = 34
        Me.lblCuLname.Text = "lblCuLname"
        '
        'lblCuFname
        '
        Me.lblCuFname.AutoSize = True
        Me.lblCuFname.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuFname.Location = New System.Drawing.Point(402, 59)
        Me.lblCuFname.Name = "lblCuFname"
        Me.lblCuFname.Size = New System.Drawing.Size(77, 14)
        Me.lblCuFname.TabIndex = 33
        Me.lblCuFname.Text = "lblCuFname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 14)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "WO#"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "INV#"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(402, 32)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(77, 14)
        Me.lblCompany.TabIndex = 37
        Me.lblCompany.Text = "lblCompany"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "DATE"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(233, 81)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(28, 14)
        Me.lblDate.TabIndex = 39
        Me.lblDate.Text = "***"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(449, 404)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 16)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "SubTotal"
        '
        'tbSubtot
        '
        Me.tbSubtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSubtot.Location = New System.Drawing.Point(527, 403)
        Me.tbSubtot.Name = "tbSubtot"
        Me.tbSubtot.ReadOnly = True
        Me.tbSubtot.Size = New System.Drawing.Size(75, 20)
        Me.tbSubtot.TabIndex = 44
        Me.tbSubtot.Text = "0.0"
        Me.tbSubtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTax
        '
        Me.tbTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTax.Location = New System.Drawing.Point(527, 422)
        Me.tbTax.Name = "tbTax"
        Me.tbTax.ReadOnly = True
        Me.tbTax.Size = New System.Drawing.Size(75, 20)
        Me.tbTax.TabIndex = 43
        Me.tbTax.Text = "0.0"
        Me.tbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(489, 423)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(32, 16)
        Me.lblTax.TabIndex = 42
        Me.lblTax.Text = "Tax"
        '
        'tbTotal
        '
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotal.Location = New System.Drawing.Point(527, 441)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(75, 20)
        Me.tbTotal.TabIndex = 41
        Me.tbTotal.Text = "0.0"
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(473, 442)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Total"
        '
        'InvoiceHistoryChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 483)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tbSubtot)
        Me.Controls.Add(Me.tbTax)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCuLname)
        Me.Controls.Add(Me.lblCuFname)
        Me.Controls.Add(Me.lblWoNo)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblUnitNo)
        Me.Controls.Add(Me.lblVin)
        Me.Controls.Add(Me.lblOdometer)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.dgvInvoice)
        Me.Name = "InvoiceHistoryChild"
        Me.Text = "InvoiceHistoryChild"
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInvoice As DataGridView
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
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWoNo As Label
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents lblCuLname As Label
    Friend WithEvents lblCuFname As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tbSubtot As TextBox
    Friend WithEvents tbTax As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colHrs As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colPartsEa As DataGridViewTextBoxColumn
    Friend WithEvents colTotPart As DataGridViewTextBoxColumn
    Friend WithEvents colLabour As DataGridViewTextBoxColumn
    Friend WithEvents colTax As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
End Class
