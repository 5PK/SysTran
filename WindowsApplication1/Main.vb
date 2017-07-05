Imports System.Data.OleDb

Public Class SysTran

    Dim con As New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.PendingWO.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Forms.InvoiceSelect.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        My.Forms.AddCustomer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.CreateWOSelect.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Customers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        My.Forms.CuMenuSel.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ExitForm.SaveAndExit(Me)
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        AddVehicleCuSelect.Show()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        CreateWOSelect.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub SysTran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim cmdStr = "SELECT LabourRate, TaxRate, Fname, Lname, Regno FROM Administrator WHERE ID = 1"

        Dim cmd As OleDbCommand = New OleDbCommand(cmdStr, con)

        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read
            GlobalAdmin.LABOURRATE = rdr("LabourRate").ToString
            GlobalAdmin.TAX = rdr("TaxRate").ToString
            GlobalAdmin.ADMINFNAME = rdr("Fname").ToString
            GlobalAdmin.ADMINLNAME = rdr("Lname").ToString
            GlobalAdmin.REGNO = rdr("Regno").ToString
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.VeMenuSel.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        My.Forms.Invoice.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        'TODO ADD SETTINGS
        My.Forms.AdminSettings.Show()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Forms.AccReceivable.Show()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Forms.SupplierSel.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click

        Dim frm As New ChequePrint(1122, Date.Now, 3, 122.44)
        frm.Show()


    End Sub
End Class
