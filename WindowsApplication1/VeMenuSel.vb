Public Class VeMenuSel
    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        My.Forms.AddVehicleCuSelect.Show()
        Me.Close()

    End Sub

    Private Sub btnModifyVehicle_Click(sender As Object, e As EventArgs) Handles btnModifyVehicle.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class