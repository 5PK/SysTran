Imports System.Data.OleDb
Imports System.IO

Public Class UpdateCustomerSelect

    Dim con As New OleDbConnection

    Private Access As DBControl
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim dt2 As New DataTable

    Dim customerID As String

   Public Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        FillTextBoxes()
    End Sub

    Private Sub FillTextBoxes()


        'IF A CUSTOMER IS SELECTED
        If dgvCustomers.SelectedCells.Count > 0 Then

            Dim SelectedRowIndex As Integer = dgvCustomers.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(SelectedRowIndex)


            'GETS CUSTOMER ID
            customerID = Convert.ToString(selectedRow.Cells(3).Value)


            ''CREATE PARAMETER
            Access.AddParam("@customerID", customerID)


            ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
            Access.ExecQuery("SELECT * FROM Customers " &
                             "WHERE ID=@customerID;")


            'CREATES UPDATE CUSTOMER INFO FORM
            Dim frm As New UpdateCustomerInfo

            frm.Show()


            'READ DATA INTO TEXTBOXES
            Dim rdr As DataRow = Access.DBDT.Rows(customerID)

            frm.tbCompany.Text = rdr("company").ToString
            frm.tbFname.Text = rdr("fname").ToString
            frm.tbLname.Text = rdr("lname").ToString
            frm.tbABusNum.Text = rdr("abtel").ToString
            frm.tbBBusNum.Text = rdr("btel").ToString
            frm.tbAHomeNum.Text = rdr("AHTEL").ToString
            frm.tbBHomeNum.Text = rdr("htel").ToString
            frm.tbACellNum.Text = rdr("acell").ToString
            frm.tbBCellNum.Text = rdr("cell").ToString
            frm.tbEmail.Text = rdr("email").ToString
            frm.tbStreet.Text = rdr("street").ToString
            frm.tbCity.Text = rdr("city").ToString
            frm.tbProvince.Text = rdr("province").ToString
            frm.tbPostalCode.Text = rdr("postal").ToString

            frm.tbtest.Text = customerID

        End If

    End Sub



    Private Sub UpdateCustomerSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; data source = TSauto1.accdb"
        con.Open()
        datagridShow()
        dt2 = dt
        dgvCustomers.Columns(3).Visible = False




    End Sub

    Private Sub datagridShow()

        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select company, fname, lname, ID From Customers", con)      

        da.Fill(dt)

        dgvCustomers.DataSource = dt.DefaultView

        con.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dt2.DefaultView.RowFilter = "fname Like '%" & TextBox1.Text & "%' OR lname LIKE '%" & TextBox1.Text & "%' OR company LIKE '%" & TextBox1.Text & "%'"



    End Sub


End Class