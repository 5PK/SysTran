Imports System.Data.OleDb


Public Class CreateWOSelect

    Dim con As New OleDbConnection

    'Customer DGV
    Dim ds1 As New DataSet
    Dim dt1a As New DataTable
    Dim dt1b As New DataTable

    'Vehicle DGV
    Dim ds2 As New DataSet
    Dim dt2a As New DataTable
    Dim dt2b As New DataTable

    Dim customerID As Integer
    Dim vehicleID As Integer


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call ExitForm.Cancel(Me)

    End Sub

    Private Sub CreateWO_Click(sender As Object, e As EventArgs) Handles btnCreateWO.Click
        Dim dte As Date = System.DateTime.Today


        Dim SelectedRowIndex As Integer = dgvVehicles.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvVehicles.Rows(SelectedRowIndex)

        vehicleID = selectedRow.Cells(0).Value


        'CREATES WORK REQUEST WORK ORDER INVOICE FORM
        Dim frm As New WrWoInvoice(customerID, vehicleID, dte)
        frm.Show()
        FillWRWOLabels(frm, vehicleID, customerID)

        frm.IsWOFirstCreation(True)
        Me.Close()

    End Sub

    Private Sub CreateWOSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        dgvCustomersShow()
        dgvCustomers.Rows(0).Cells(0).Selected = False
        dgvCustomers.Columns(0).Visible = False
        dgvCustomers.Columns(1).Width = 200
        dgvCustomers.Columns(3).Width = 110


        dt1b = dt1a


        ds2.Tables.Add(dt2a)

    End Sub

    Private Sub tbCustomerSel_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerSel.TextChanged

        dt1b.DefaultView.RowFilter = "[Company] Like '%" & tbCustomerSel.Text & "%' OR [First Name] LIKE '%" & tbCustomerSel.Text & "%' OR [Last Name]LIKE '%" & tbCustomerSel.Text & "%'"


    End Sub

#Region "DGV METHODS"

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

        dataAdapt = New OleDbDataAdapter("SELECT ID, cusid, year AS [Year], make AS [Make], model AS [Model], plate AS [Plate], odometer as [Odometer] FROM CuVehicles WHERE cusid = " & customerID & " ", con)

        dataAdapt.Fill(dt2a)

        dgvVehicles.DataSource = dt2a.DefaultView


        con.Close()




    End Sub


    Private Sub dgvCustomers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        con.Open()


        Dim SelectedRowIndex As Integer = dgvCustomers.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(SelectedRowIndex)

        customerID = selectedRow.Cells(0).Value

        dgvVehiclesShow()

        dgvVehicles.Columns(0).Visible = False
        dgvVehicles.Columns(1).Visible = False
        dgvVehicles.Columns(2).Width = 45
        dgvVehicles.Columns(3).Width = 90
        dgvVehicles.Columns(4).Width = 160
        dgvVehicles.Columns(6).Width = 90

        btnCreateWO.Enabled = True

    End Sub

#End Region
End Class