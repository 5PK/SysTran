Imports System.Data.OleDb


Public Class SupplierMakePayment

    Dim SuppID As Integer
    Dim selectedRowIndexes As New List(Of String)

    Dim invoices As ArrayList = New ArrayList
    Dim invoicesBalance As ArrayList = New ArrayList


    'Supplier DGV
    Dim ds As New DataSet
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable

    Dim DefaultPayment As Double
    Dim con As New OleDbConnection


    Public Sub New(ByVal supplierID As Integer)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        SuppID = supplierID

    End Sub

    Private Sub dgvUDF_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSuppPay.CellMouseClick


        If (Me.selectedRowIndexes.IndexOf(e.RowIndex) > -1) Then
            dgvSuppPay.Text = dgvSuppPay.Text - dgvSuppPay.Rows(e.RowIndex).Cells(3).Value

            invoices.Remove(dgvSuppPay.Rows(e.RowIndex).Cells(1).Value)
            invoicesBalance.Remove(dgvSuppPay.Rows(e.RowIndex).Cells(5).Value)

            Me.selectedRowIndexes.Remove(e.RowIndex)



        Else
            tbPayment.Text = tbPayment.Text + dgvSuppPay.Rows(e.RowIndex).Cells(3).Value

            invoices.Add(dgvSuppPay.Rows(e.RowIndex).Cells(1).Value)
            invoicesBalance.Add(dgvSuppPay.Rows(e.RowIndex).Cells(5).Value)

            Me.selectedRowIndexes.Add(e.RowIndex)
            Me.dgvSuppPay.CurrentCell = Nothing

        End If
    End Sub

    Private Sub dgvUDF_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvSuppPay.RowPrePaint
        If (Me.selectedRowIndexes.IndexOf(e.RowIndex) > -1) Then
            dgvSuppPay.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Crimson

        Else
            dgvSuppPay.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke

        End If
    End Sub

    Private Sub btnApplyPay_Click(sender As Object, e As EventArgs) Handles btnApplyPay.Click



    End Sub

    Private Sub SupplierMakePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        'dgvSuppPay.Rows(0).Cells(0).Selected = False
        loaddgvSuppPay()
        dgvSuppPay.Columns(0).Visible = False

    End Sub

    Private Sub loaddgvSuppPay()
        ds.Tables.Add(dt1)
        Dim da As New OleDbDataAdapter


        da = New OleDbDataAdapter("SELECT dte AS [Date], InvoiceID AS [Invoice #],Description,  Purchase,Tax, Balance FROM Invoice WHERE SuppID = " & SuppID & "; ", con)

        da.Fill(dt1)

        dgvSuppPay.DataSource = dt1.DefaultView

        con.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class