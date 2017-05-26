Imports System.Data.OleDb
Imports System.IO

Public Class PendingWO

    Dim con As New OleDbConnection

    Dim ds As New DataSet
    Dim dt As New DataTable

    Dim ds2 As New DataSet
    Dim dt2 As New DataTable


    Private Sub PendingWO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadWOPending()
    End Sub

    Private Sub loadWOPending()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM WorkOrder WHERE WOStatus = True;", con)


        da.Fill(dt)


        dgvWOPending.DataSource = dt.DefaultView

        con.Close()

    End Sub

    Private Sub loadWOPending2()



    End Sub




    Private Sub dgvWOPending_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvWOPending.CellMouseDoubleClick

        'OPEN WRWOINVOICE FORM
        Dim frm As New WrWoInvoice
        frm.Show()
        frm.IsWOFirstCreation(False)

        'Load Customer Request to TextBox from txt file
        'Load DGV from Text File


        Me.Close()






    End Sub



End Class