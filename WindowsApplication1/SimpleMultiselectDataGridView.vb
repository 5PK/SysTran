Public Class SimpleMultiselectDataGridView
    Inherits DataGridView

    Protected Overrides Sub OnCellMouseDown(e As DataGridViewCellMouseEventArgs)
        Me.Rows(e.RowIndex).Selected = Not Me.Rows(e.RowIndex).Selected
    End Sub

    Protected Overrides Sub OnCellMouseUp(e As DataGridViewCellMouseEventArgs)
    End Sub
End Class

