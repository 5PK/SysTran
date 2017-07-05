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
        dgvAccR.Rows(0).Cells(0).Selected = False

        dgvAccR.Columns(0).Visible = False
        dt2 = dt1



    End Sub

    Private Sub tbCustomerSel_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerSel.TextChanged

        dt2.DefaultView.RowFilter = "[First Name] Like '%" & tbCustomerSel.Text & "%' OR [Last Name] LIKE '%" & tbCustomerSel.Text & "%' OR [Company] LIKE '%" & tbCustomerSel.Text & "%'"


    End Sub

    Private Sub loadCustomers()

        ds.Tables.Add(dt1)
        Dim da As New OleDbDataAdapter
        Dim daCMD As String = "SELECT Customers.ID, Customers.company AS [Company], Customers.fname AS [First Name], Customers.lname AS [Last Name], SUM(m.Balance) AS [Balance] " &
                              "FROM (SELECT DISTINCT cusID, Balance FROM Invoice) As m " &
                              "INNER JOIN Customers on  m.cusID = Customers.ID " &
                              "WHERE Invoice.Balance > 0 " &
                              "GROUP BY Customers.ID, Customers.company, Customers.fname, Customers.lname"


        da = New OleDbDataAdapter(daCMD, con)

        da.Fill(dt1)

        dgvAccR.DataSource = dt1.DefaultView

        con.Close()

    End Sub



    Private Sub dgvAccR_DoubleClick(sender As Object, e As EventArgs) Handles dgvAccR.CellMouseDoubleClick

        Dim selectedRowIndex As Integer = dgvAccR.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvAccR.Rows(selectedRowIndex)

        customerID = selectedRow.Cells(0).Value

        Dim frm As New AccReceivableCustomer(customerID)

        frm.Show()

        Me.Close()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvAccR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccR.CellContentClick

    End Sub
End Class