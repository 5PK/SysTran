Imports System.Data.OleDb

Public Class AccReceivableCustomer

    Dim Access As New DBControl

    Public CustomerID As Integer
    Dim selectedRowIndexes As New List(Of String)

    Dim con As New OleDbConnection

    'Customer DGV
    Dim ds As New DataSet
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable

    Dim DefaultPayment As Double
    Dim arID As Integer

    Dim invoices As ArrayList = New ArrayList
    Dim balances As ArrayList = New ArrayList

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal CusID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomerID = CusID

    End Sub


    Private Sub dgvUDF_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCusAcc.CellMouseClick


        If (Me.selectedRowIndexes.IndexOf(e.RowIndex) > -1) Then
            tbPayment.Text = tbPayment.Text - dgvCusAcc.Rows(e.RowIndex).Cells(3).Value

            invoices.Remove(dgvCusAcc.Rows(e.RowIndex).Cells(1).Value)
            balances.Remove(dgvCusAcc.Rows(e.RowIndex).Cells(3).Value)

            Me.selectedRowIndexes.Remove(e.RowIndex)


        Else
            tbPayment.Text = tbPayment.Text + dgvCusAcc.Rows(e.RowIndex).Cells(3).Value

            invoices.Add(dgvCusAcc.Rows(e.RowIndex).Cells(1).Value)
            balances.Add(dgvCusAcc.Rows(e.RowIndex).Cells(3).Value)

            Me.selectedRowIndexes.Add(e.RowIndex)
            Me.dgvCusAcc.CurrentCell = Nothing

        End If
    End Sub

    Private Sub dgvUDF_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvCusAcc.RowPrePaint
        If (Me.selectedRowIndexes.IndexOf(e.RowIndex) > -1) Then
            dgvCusAcc.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Crimson

        Else
            dgvCusAcc.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke

        End If
    End Sub

    Private Sub btnApplyPay_Click(sender As Object, e As EventArgs) Handles btnApplyPay.Click

        Dim frm As New AccRecPaymentSel(invoices, balances)

        frm.Show()
        Me.Close()
    End Sub

    Private Sub AccReceivableCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        'dgvCusAcc.Rows(0).Cells(0).Selected = False
        loaddgvCusAcc()
        dgvCusAcc.Columns(0).Visible = False

    End Sub

    Private Sub loaddgvCusAcc()


        ds.Tables.Add(dt1)
        Dim da As New OleDbDataAdapter


        da = New OleDbDataAdapter("SELECT dte AS [Date], ID AS [Invoice #], InvTotal, Balance FROM Invoice WHERE cusID = " & CustomerID & " AND Balance > 0; ", con)

        da.Fill(dt1)

        dgvCusAcc.DataSource = dt1.DefaultView

        con.Close()

    End Sub

    Private Sub dgvCusAcc_CellClick() Handles dgvCusAcc.CellClick

        'Dim selectedRowIndex As Integer = dgvCusAcc.SelectedCells(0).RowIndex
        'Dim selectedRow As DataGridViewRow = dgvCusAcc.Rows(selectedRowIndex)

        'arID = selectedRow.Cells(0).Value
        'DefaultPayment = selectedRow.Cells(3).Value
        '
        'tbPayment.Text = DefaultPayment


    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each element In invoices
            MessageBox.Show(element)
        Next


    End Sub
End Class