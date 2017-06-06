Imports System.Data.OleDb
Imports System.IO

Public Class PendingWO

    Dim con As New OleDbConnection

    Dim ds As New DataSet
    Dim dt As New DataTable

    'Dim ds2 As New DataSet
    'Dim dt2 As New DataTable


    Private Sub PendingWO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadWOPending()
    End Sub

    Private Sub loadWOPending()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT ID, fname, lname, make, model, plate FROM WorkOrder WHERE WOStatus = True;", con)


        da.Fill(dt)


        dgvWOPending.DataSource = dt.DefaultView

        con.Close()

    End Sub


    Private Sub dgvWOPending_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvWOPending.CellMouseDoubleClick


        'SELECTION
        Dim WoID As Integer

        If dgvWOPending.SelectedCells.Count > 0 Then

            Dim SelectedRowIndex As Integer = dgvWOPending.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = dgvWOPending.Rows(SelectedRowIndex)


            'GETS WOID ID
            WoID = Convert.ToString(selectedRow.Cells(0).Value)

        End If

        'OPEN WRWOINVOICE FORM
        Dim frm As New WrWoInvoice
        frm.Show()
        frm.IsWOFirstCreation(False)
        frm.lblWoNo.Text = WoID

        'Load WR and WO text
        Dim filepath As String = "WorkOrders\"
        Dim filename As String = WoID

        LoadTxtToDgv(frm.dgvWorkOrder, filepath, filename, True)


        Me.Close()






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class