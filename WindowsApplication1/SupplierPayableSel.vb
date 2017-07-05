Imports System.Data.OleDb

Public Class SupplierPayableSel

    'Supplier DGV
    Dim ds As New DataSet
    Dim dt1 As New DataTable
    Dim con As New OleDbConnection
    Dim SupplierId As Integer

    Private Sub SupplierPayableSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        loaddgv()
    End Sub

    Private Sub loaddgv()

        ds.Tables.Add(dt1)
        Dim da As New OleDbDataAdapter
        Dim str As String = "SELECT Suppliers.ID, Suppliers.company AS [Company], SUM(m.Balance) AS [Balance] " &
                              "FROM (SELECT DISTINCT SuppID, Balance FROM Invoice) As m " &
                              "INNER JOIN Suppliers on m.SuppID = Suppliers.ID " &
                              "GROUP BY Suppliers.ID, Suppliers.company"

        da = New OleDbDataAdapter(str, con)

        da.Fill(dt1)

        DataGridView1.DataSource = dt1.DefaultView

        con.Close()


    End Sub

    Private Sub cell_doubleclick() Handles DataGridView1.CellDoubleClick

        Dim selectedRowIndex As Integer = DataGridView1.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(selectedRowIndex)

        SupplierId = selectedRow.Cells(0).Value

        Dim frm As New SupplierPayable(SupplierId)

        frm.Show()
        Me.Close()

    End Sub


End Class