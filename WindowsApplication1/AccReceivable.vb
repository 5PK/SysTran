Imports System.Data.OleDb

Public Class AccReceivable

    Dim customerID As Integer


    Dim con As New OleDbConnection

    'Customer DGV
    Dim ds As New DataSet
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable


    Private Sub AccReceivable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        loadCustomers()
        dt1 = dt2
        dgvAccR.Rows(0).Cells(0).Selected = False


    End Sub

    Private Sub tbCustomerSel_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerSel.TextChanged

        dt2.DefaultView.RowFilter = "fname Like '%" & tbCustomerSel.Text & "%' OR lname LIKE '%" & tbCustomerSel.Text & "%' OR company LIKE '%" & tbCustomerSel.Text & "%'"


    End Sub

    Private Sub loadCustomers()

        ds.Tables.Add(dt1)
        Dim da As New OleDbDataAdapter

        'da = New OleDbDataAdapter("SELECT Customers.company, Customers.fname, Customers.lname, SUM(m.Balance) FROM (SELECT DISTINCT CusID, Balance FROM AccReceivable) AS m INNER JOIN Customers ON m.CusID = Customers.ID;", con)
        da = New OleDbDataAdapter("SELECT Customers.fname, Customers.lname, SUM(m.Balance) FROM (SELECT DISTINCT CusID, Balance FROM AccReceivable) AS m INNER JOIN Customers ON m.CusID = Customers.ID GROUP BY Customers.fname, Customers.lname", con)

        da.Fill(dt1)

        dgvAccR.DataSource = dt1.DefaultView

        con.Close()

    End Sub



    Private Sub dgvAccR_DoubleClick(sender As Object, e As EventArgs) Handles dgvAccR.CellMouseDoubleClick

        Dim selectedRowIndex As Integer = dgvAccR.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvAccR.Rows(selectedRowIndex)

        customerID = selectedRow.Cells(0).Value



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class