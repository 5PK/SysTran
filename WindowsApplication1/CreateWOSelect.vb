Imports System.Data.OleDb


Public Class CreateWOSelect

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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call ExitForm.Cancel(Me)

    End Sub

    Private Sub CreateWO_Click(sender As Object, e As EventArgs) Handles btnCreateWO.Click

        'CREATES WORK REQUEST WORK ORDER INVOICE FORM
        Dim frm As New WrWoInvoice
        frm.Show()
        FillLabels(frm)
        frm.IsWOFirstCreation(True)
        Me.Close()

    End Sub





    Private Sub FillLabels(ByRef frm As WrWoInvoice)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim SelectedRowIndex As Integer = dgvVehicles.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvVehicles.Rows(SelectedRowIndex)

        vehicleID = Convert.ToString(selectedRow.Cells(0).Value)

        frm.tbVehID.Text = vehicleID
        frm.tbCuID.Text = customerID

        ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
        Dim strCu As String
        Dim strVe As String

        strCu = "SELECT * FROM Customers WHERE ID = " & customerID & " "
        strVe = "SELECT * FROM CuVehicles WHERE ID = " & vehicleID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCu, con)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()


        'TODO - Fill Customer/Vehicle/Admin

        While rdr.Read
            frm.lblCuFname.Text = rdr("fname").ToString
            frm.lblCuLname.Text = rdr("lname").ToString
            frm.lblCuAHomeNum.Text = rdr("AHTEL").ToString
            frm.lblCuBHomeNum.Text = rdr("htel").ToString
            frm.lblACellNum.Text = rdr("acell").ToString
            frm.lblBCellNum.Text = rdr("cell").ToString
        End While
        rdr.Close()

        cmd = New OleDbCommand(strVe, con)
        Dim rdr2 As OleDbDataReader = cmd.ExecuteReader()


        While rdr2.Read
            frm.lblYear.Text = rdr2("year").ToString
            frm.lblMake.Text = rdr2("make").ToString
            frm.lblModel.Text = rdr2("model").ToString
            frm.lblPlate.Text = rdr2("plate").ToString
            frm.lblOdometer.Text = rdr2("odometer").ToString
            frm.lblVin.Text = rdr2("vin").ToString
            frm.lblUnitNo.Text = rdr2("unitno").ToString
        End While

        rdr2.Close()
        con.Close()
    End Sub



    Private Sub CreateWOSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        dgvCustomersShow()
        dt1b = dt1a
        dgvCustomers.Columns(0).Visible = True

        ds2.Tables.Add(dt2a)

    End Sub

    Private Sub tbCustomerSel_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerSel.TextChanged

        dt1b.DefaultView.RowFilter = "fname Like '%" & tbCustomerSel.Text & "%' OR lname LIKE '%" & tbCustomerSel.Text & "%' OR company LIKE '%" & tbCustomerSel.Text & "%'"


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

    Private Sub btnCuSelect_Click(sender As Object, e As EventArgs) Handles btnCuSelect.Click

        con.Open()


        Dim SelectedRowIndex As Integer = dgvCustomers.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(SelectedRowIndex)

        customerID = Convert.ToString(selectedRow.Cells(0).Value)

        dgvVehiclesShow()

        btnCreateWO.Enabled = True


    End Sub
End Class