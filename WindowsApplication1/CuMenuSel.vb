Public Class CuMenuSel
    Private Sub btnModifyCustomer_Click(sender As Object, e As EventArgs) Handles btnModifyCustomer.Click
        My.Forms.UpdateCustomerSelect.Show()
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        My.Forms.AddCustomer.Show()
        Me.Close()

    End Sub
End Class