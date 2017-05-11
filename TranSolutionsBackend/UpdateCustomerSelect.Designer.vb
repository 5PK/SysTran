<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCustomerSelect
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.TSauto1DataSet = New WindowsApplication1.TSauto1DataSet()
        Me.TSauto1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WindowsApplication1.TSauto1DataSetTableAdapters.CustomersTableAdapter()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSauto1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSauto1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(579, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter the first few characters of the customer's First Name, Last Name or Company" &
    ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(54, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Click on the customer from the list, then click OK"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(54, 352)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 54)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToResizeColumns = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomers.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dgvCustomers.Location = New System.Drawing.Point(54, 154)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(442, 150)
        Me.dgvCustomers.TabIndex = 7
        '
        'TSauto1DataSet
        '
        Me.TSauto1DataSet.DataSetName = "TSauto1DataSet"
        Me.TSauto1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TSauto1DataSetBindingSource
        '
        Me.TSauto1DataSetBindingSource.DataSource = Me.TSauto1DataSet
        Me.TSauto1DataSetBindingSource.Position = 0
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.TSauto1DataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'UpdateCustomerSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 462)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UpdateCustomerSelect"
        Me.Text = "Update Customer"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSauto1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSauto1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents TSauto1DataSetBindingSource As BindingSource
    Friend WithEvents TSauto1DataSet As TSauto1DataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As TSauto1DataSetTableAdapters.CustomersTableAdapter
End Class
