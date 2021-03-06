﻿Imports System.Data.OleDb

Public Class UpdateVehicleSelect


    Dim con As New OleDbConnection
    Private Access As New DBControl

    'Customer DGV
    Dim ds1 As New DataSet
    Dim dt1a As New DataTable
    Dim dt1b As New DataTable

    'Vehicle DGV
    Dim ds2 As New DataSet
    Dim dt2a As New DataTable
    Dim dt2b As New DataTable

    Dim customerID As String
    Dim vehicleID As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub tbCustomerSel_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerSel.TextChanged

        dt1b.DefaultView.RowFilter = "fname Like '%" & tbCustomerSel.Text & "%' OR lname LIKE '%" & tbCustomerSel.Text & "%' OR company LIKE '%" & tbCustomerSel.Text & "%'"


    End Sub

    Private Sub UpdateVehicleSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        dgvCustomersShow()
        dt1b = dt1a
        dgvCustomers.Columns(0).Visible = True

        ds2.Tables.Add(dt2a)

    End Sub


    Private Sub dgvCustomersShow()

        ds1.Tables.Add(dt1a)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT ID, company, fname, lname FROM Customers", con)

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

        dataAdapt = New OleDbDataAdapter("SELECT ID, cusid, plate, make, model FROM CuVehicles WHERE cusid = " & customerID & " ", con)

        dataAdapt.Fill(dt2a)

        dgvVehicles.DataSource = dt2a.DefaultView

        con.Close()




    End Sub


    Private Sub dgvCustomers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        con.Open()


        Dim SelectedRowIndex As Integer = dgvCustomers.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(SelectedRowIndex)

        customerID = Convert.ToString(selectedRow.Cells(0).Value)

        dgvVehiclesShow()

        btnSelectVehicle.Enabled = True

    End Sub


End Class