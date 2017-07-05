Imports System.Data.OleDb

Public Class SupplierPayable
    Dim suppID As Integer

    Dim con As New OleDbConnection

    'Customer DGV
    Dim ds1 As New DataSet
    Dim dt1a As New DataTable
    Dim dt1b As New DataTable

    Dim Access As New DBControl

    Public Sub New(ByVal supplierID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        suppID = supplierID

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbDate.TextChanged

    End Sub

    Private Sub loadSuppPaydgv()
        ds1.Tables.Add(dt1a)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT ID, Dte AS [Date], Description AS [Description], Purchase AS [Purchase], Tax as [Tax], Payment as [Payment], Balance as [Balance] FROM AccPayable WHERE SuppID = " & suppID & ";", con)

        da.Fill(dt1a)

        dgvSuppPay.DataSource = dt1a.DefaultView

        con.Close()



    End Sub

    Private Sub SupplierPayable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        loadSuppPaydgv()

        dt1b = dt1a

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMakePay.Click

        Dim frm As New SupplierMakePayment(suppID)

        frm.Show()
        Me.Close()
    End Sub

    Private Sub tbPurchase_TextChanged(sender As Object, e As EventArgs) Handles tbPurchase.TextChanged
        Dim Tax As Double = tbPurchase.Text * GlobalAdmin.TAX

        tbTax.Text = tbPurchase.Text + Tax
    End Sub

    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click

        Access.AddParam("@InvoiceID", tbInvoiceID.Text)
        Access.AddParam("@Date", tbDate.Text)
        Access.AddParam("@Desc", tbDesc.Text)
        Access.AddParam("@Purchase", tbPurchase.Text)
        Access.AddParam("@Tax", tbTax.Text)
        Access.AddParam("@Balance", tbBalance.Text)
        Access.AddParam("@SuppID", suppID)

        Access.ExecQuery("INSERT INTO AccPayable (InvoiceID, Dte, Description, Purchase, Balance, SuppID) " &
                         "VALUES (@InvoiceID, @Date, @Desc, @Purchase, @Tax, @Balance, @SuppID);")

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSauto1.accdb"
        con.Open()
        loadSuppPaydgv()

        dt1b = dt1a

    End Sub

    Private Sub btnDeletePurchase_Click(sender As Object, e As EventArgs) Handles btnDeletePurchase.Click

        Dim SelectedRowIndex As Integer = dgvSuppPay.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dgvSuppPay.Rows(SelectedRowIndex)

        Dim purchaseID As Integer = selectedRow.Cells(0).Value

        Access.ExecQuery("DELETE FROM AccPayable WHERE ID = " & purchaseID & ";")

        dgvSuppPay.Rows.RemoveAt(SelectedRowIndex)

    End Sub
End Class