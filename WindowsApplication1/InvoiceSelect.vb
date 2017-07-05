Imports System.Data.OleDb

Public Class InvoiceSelect


    Dim con As New OleDbConnection

    'Customer DGV
    Dim ds1 As New DataSet
    Dim dt1a As New DataTable
    Dim dt1b As New DataTable

    'Vehicle DGV
    Dim ds2 As New DataSet
    Dim dt2a As New DataTable
    Dim dt2b As New DataTable

    'Invoice DGV

    Dim ds3 As New DataSet
    Dim dt3a As New DataTable
    Dim dt3b As New DataTable

    Dim customerID As Integer
    Dim vehicleID As Integer
    Dim InvoiceID As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        '  Dim frm As New InvoiceHistoryChild

        ' frm.Show()
    End Sub

    Private Sub InvoiceSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        dgvCustomersShow()
        dgvCustomers.Columns(0).Visible = False
        dgvCustomers.Rows(0).Cells(0).Selected = False
        dt1b = dt1a


        ds2.Tables.Add(dt2a)
        ds3.Tables.Add(dt3a)

    End Sub

    Private Sub tbCustomerSel_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerSel.TextChanged

        dt1b.DefaultView.RowFilter = "[Company] LIKE '%" & tbCustomerSel.Text & "%' OR [First Name] LIKE '%" & tbCustomerSel.Text & "%' OR [Last Name] LIKE '%" & tbCustomerSel.Text & "%'"


    End Sub

    Private Sub dgvCustomersShow()

        ds1.Tables.Add(dt1a)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT ID, company AS [Company], fname AS [First Name], lname AS [Last Name] FROM Customers", con)

        da.Fill(dt1a)

        dgvCustomers.DataSource = dt1a.DefaultView

        con.Close()

    End Sub

    Private Sub dgvVehiclesShow()


        'Clears the dataset
        dt2a.Clear()
        'Adds empty dataset to the dgv
        dgvVehicles.DataSource = dt2a

        'Regular Expression to fill dgv

        Dim dataAdapt As New OleDbDataAdapter

        dataAdapt = New OleDbDataAdapter("SELECT ID, cusid, year AS [Year], make AS [Make], model AS [Model], plate AS [Plate] FROM CuVehicles WHERE cusid = " & customerID & " ", con)

        dataAdapt.Fill(dt2a)

        dgvVehicles.DataSource = dt2a.DefaultView


        con.Close()



    End Sub

    Private Sub dgvInvoicesShow()

        dt3a.Clear()

        dgvInvoices.DataSource = dt3a

        Dim dataAdapt As New OleDbDataAdapter

        dataAdapt = New OleDbDataAdapter("SELECT Dte AS [Date], ID AS [Invoice ID], WoID, odometer AS [Odometer], InvTotal AS [Total] FROM Invoice WHERE vehID = " & vehicleID & " ", con)

        dataAdapt.Fill(dt3a)




        dgvInvoices.DataSource = dt3a.DefaultView

        con.Close()





    End Sub


    Private Sub dgvCustomers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        con.Open()


        Dim SelectedRowIndex As Integer = dgvCustomers.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(SelectedRowIndex)

        customerID = Convert.ToString(selectedRow.Cells(0).Value)

        dgvVehiclesShow()

        dgvVehicles.Columns(0).Visible = False
        dgvVehicles.Columns(1).Visible = False
        dgvVehicles.Rows(0).Cells(0).Selected = False

        dgvInvoices.Rows.Clear()
        dgvInvoices.Refresh()


    End Sub

    Private Sub dgvVehicles_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvVehicles.CellClick



        con.Open()


        Dim SelectedRowIndex As Integer = dgvVehicles.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvVehicles.Rows(SelectedRowIndex)

        vehicleID = Convert.ToString(selectedRow.Cells(0).Value)

        dgvInvoicesShow()

        dgvInvoices.Columns(2).Visible = False



    End Sub

    Private Sub dgvInvoices_doubleclieck(sender As Object, e As EventArgs) Handles dgvInvoices.CellMouseDoubleClick


        Dim SelectedRowIndex As Integer = dgvInvoices.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvInvoices.Rows(SelectedRowIndex)

        InvoiceID = Convert.ToString(selectedRow.Cells(1).Value)
        Dim WorkOrderID As String = Convert.ToString(selectedRow.Cells(2).Value)
        Dim dte As String = Convert.ToString(selectedRow.Cells(0).Value)


        Dim frm As New Invoice(customerID, vehicleID, InvoiceID, WorkOrderID, dte)

        Dim filepath As String = "Invoices/"
        Dim filename As String = InvoiceID & "INV"

        LoadTxtToDgv(frm.dgvInvoice, filepath, filename, False)
        FillInvLabels(frm, vehicleID, customerID, InvoiceID, WorkOrderID, dte)

        frm.Show()
        Me.Close()



    End Sub




End Class