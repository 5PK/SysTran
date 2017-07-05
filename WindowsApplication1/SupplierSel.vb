Imports System.Data.OleDb

Public Class SupplierSel


    Dim con As New OleDbConnection

    'Customer DGV
    Dim ds As New DataSet
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim test As String

    Private Sub SupplierSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()

        loaddgvSuppliers()

        dt2 = dt1



    End Sub

    Private Sub loaddgvSuppliers()

        ds.Tables.Add(dt1)

        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT ID, company As [Company] FROM Suppliers;", con)

        da.Fill(dt1)

        dgvSuppliers.DataSource = dt1.DefaultView
        dgvSuppliers.Columns(0).Visible = False
        dgvSuppliers.Columns(1).Width = 240
        con.Close()


    End Sub

    Private Sub tbSuppSel_TextChanged(sender As Object, e As EventArgs) Handles tbSuppSel.TextChanged


        dt2.DefaultView.RowFilter = "[Company] Like '%" & tbSuppSel.Text & "%'"

    End Sub

    Private Sub dgvSupp_CellClick() Handles dgvSuppliers.CellClick

        Dim selectedRowIndex As Integer = dgvSuppliers.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvSuppliers.Rows(selectedRowIndex)

        Dim suppID As Integer = Convert.ToString(selectedRow.Cells(0).Value)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()

        Dim cmdstr As String = "SELECT * FROM Suppliers WHERE ID = " & suppID & ";"

        Dim cmd As OleDbCommand = New OleDbCommand(cmdstr, con)

        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read
            lblAtel.Text = rdr("atel").ToString
            lblTel.Text = rdr("tel").ToString
            lblEmail.Text = rdr("email").ToString

        End While

        rdr.Close()
        con.Close()



    End Sub


    'CREATE TINGS
    Private Sub dgv_doubleclick() Handles dgvSuppliers.CellDoubleClick
        Dim selectedRowIndex As Integer = dgvSuppliers.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvSuppliers.Rows(selectedRowIndex)

        Dim suppID As Integer = Convert.ToString(selectedRow.Cells(0).Value)

        Dim frm As New SupplierPayable(suppID)

        frm.Show()
        Me.Close()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTel.Click

    End Sub
End Class