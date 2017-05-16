Public Class SysTran
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.PendingWO.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.UpdateCustomerSelect.Show()
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
End Class
