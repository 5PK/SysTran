Imports System.Data.OleDb
Imports System.IO

Public Class PendingWO

    Dim con As New OleDbConnection

    Dim ds As New DataSet
    Dim dt As New DataTable

    Private Sub PendingWO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadWOPending()

    End Sub

    Private Sub loadWOPending()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter

        Dim cmdSTR2 As String = "SELECT WorkOrder.dte AS [Date], WorkOrder.ID AS [Work Order #], WorkOrder.VehID, WorkOrder.CusID, Customers.fname AS [First Name], Customers.lname AS [Last Name], " &
                                "CuVehicles.year AS [Year], CuVehicles.make AS [Make], CuVehicles.model AS [Model], CuVehicles.unitno AS [Unit #] " &
                                "FROM (Customers INNER JOIN CuVehicles ON Customers.ID = CuVehicles.cusid) INNER JOIN WorkOrder ON CuVehicles.ID = WorkOrder.VehID " &
                                "WHERE WorkOrder.WOStatus = False; "

        da = New OleDbDataAdapter(cmdSTR2, con)

        da.Fill(dt)

        dgvWOPending.DataSource = dt.DefaultView

        con.Close()
    End Sub


    Private Sub dgvWOPending_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvWOPending.CellMouseDoubleClick

        'SELECTION
        Dim WoID As Integer
        Dim CusID As Integer
        Dim VehID As Integer
        Dim Dte As System.DateTime

        If dgvWOPending.SelectedCells.Count > 0 Then

            Dim SelectedRowIndex As Integer = dgvWOPending.SelectedCells(1).RowIndex
            Dim selectedRow As DataGridViewRow = dgvWOPending.Rows(SelectedRowIndex)

            WoID = Convert.ToString(selectedRow.Cells(1).Value)
            VehID = Convert.ToString(selectedRow.Cells(2).Value)
            CusID = Convert.ToString(selectedRow.Cells(3).Value)
            Dte = Convert.ToDateTime(selectedRow.Cells(0).Value)

        End If

        'OPEN WRWOINVOICE FORM
        Dim frm As New WrWoInvoice(WoID, CusID, VehID, Dte)

        frm.IsWOFirstCreation(False)

        'Load WR and WO text
        Dim filepath As String = "WorkOrders\"
        Dim filename As String = WoID

        LoadTxtToDgv(frm.dgvWorkOrder, filepath, filename, True)
        frm.CalculateCells()
        FillWRWOLabels(frm, VehID, CusID)

        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class