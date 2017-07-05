Imports System.Data.OleDb
Imports System.IO

Public Class InvoiceHistorySelChild

    Dim VehicleID As Integer
    Dim con As New OleDbConnection


    Dim ds As New DataSet
    Dim dt As New DataTable


    Public Sub New(ByVal VehID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        VehicleID = VehID

    End Sub

    Private Sub InvoiceHistorySelChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDgvInvoices()


    End Sub

    Private Sub loadDgvInvoices()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        ds.Tables.Add(dt)

        Dim str As String = "SELECT Dte AS [Date], ID AS [Invoice #], odometer AS [Odometer], InvTotal AS [Cost] FROM Invoice WHERE vehID = " & VehicleID & " AND isInvoiceConverted = False;"

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(str, con)

        da.Fill(dt)

        dgvInvoiceHistory.DataSource = dt.DefaultView

        con.Close()

    End Sub


    Private Sub dgvInvoiceHistory_click(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInvoiceHistory.CellMouseDoubleClick

        Dim InvID As Integer

        If dgvInvoiceHistory.SelectedCells.Count > 0 Then

            Dim SelectedRowIndex As Integer = dgvInvoiceHistory.SelectedCells(1).RowIndex
            Dim selectedRow As DataGridViewRow = dgvInvoiceHistory.Rows(SelectedRowIndex)

            'GETS Invoice ID
            InvID = Convert.ToInt32(selectedRow.Cells(1).Value)

        End If

        'FILL INVOICE HISTORY CHILD FORM DGV AND LABELS
        Dim frm As New InvoiceHistoryChild(InvID)

        Dim filepath As String = "Invoices/"
        Dim filename As String = Convert.ToString(InvID) & "INV"
        frm.Show()

        LoadTxtToDgv(frm.dgvInvoice, filepath, filename, False)

    End Sub

    Private Sub dgvInvoiceHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceHistory.CellContentClick

    End Sub
End Class