Imports System.Data.OleDb
Imports System.IO

Public Class AddVehicleCuSelect

    Dim con As New OleDbConnection

    Private Access As New DBControl
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim dt2 As New DataTable

    Dim customerID As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        FillTextBoxes()
    End Sub

    Private Sub FillTextBoxes()


        'IF A CUSTOMER IS SELECTED
        If dgvCustomers.SelectedCells.Count > 0 Then

            Dim SelectedRowIndex As Integer = dgvCustomers.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(SelectedRowIndex)


            'GETS CUSTOMER ID
            customerID = Convert.ToString(selectedRow.Cells(0).Value)




            'CREATES UPDATE CUSTOMER INFO FORM
            Dim frm As New AddVehicleInfo

            frm.Show()



            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"

            con.Open()

            ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
            Dim str As String

            str = "SELECT * FROM Customers WHERE ID = " & customerID & " "
            Dim cmd As OleDbCommand = New OleDbCommand(str, con)

            'READ DATA INTO NEXT FORM TEXTBOXES
            Dim rdr As OleDbDataReader = cmd.ExecuteReader()

            While rdr.Read
                'TODO - FILL RICH TEXT BOX

                'FILLS CUSTOMER ID
                frm.tbCustomerID.Text = customerID

            End While


        End If

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dt2.DefaultView.RowFilter = "fname Like '%" & TextBox1.Text & "%' OR lname LIKE '%" & TextBox1.Text & "%' OR company LIKE '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AddVehicleCuSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        datagridShow()
        dt2 = dt
        dgvCustomers.Columns(0).Visible = True
    End Sub

    Private Sub datagridShow()

        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select  ID, company, fname, lname From Customers", con)

        da.Fill(dt)

        dgvCustomers.DataSource = dt.DefaultView

        con.Close()
    End Sub

End Class