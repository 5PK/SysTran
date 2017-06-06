Imports System.IO

Public Class Invoice

    Dim Access As New DBControl

    Public vehID As Integer
    Public cusID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Public Sub getRidofZero()

        For Each row As DataGridViewRow In dgvInvoice.Rows
            For i As Integer = 0 To 7
                If row.Cells(i).Value = "0" Then
                    row.Cells(i).Value = " "
                End If
            Next
        Next

    End Sub

    Private Sub btnConverttoWO_Click(sender As Object, e As EventArgs) Handles btnConverttoWO.Click
        Dim CustomerID As String = tbCuID.Text
        Dim VehicleID As String = tbVehID.Text

        Me.Close()

        Dim IsInvoiceConverted As Boolean = True
        Dim InvoiceID As Integer = Convert.ToInt32(lblInvoiceNo.Text)



        Access.AddParam("@IsInvoiceConverted", IsInvoiceConverted)
        Access.AddParam("@ID", InvoiceID)

        Access.ExecQuery("UPDATE Invoice " &
                         "SET IsInvoiceConverted=@IsInvoiceConverted " &
                         "WHERE ID=@ID;")




        Dim frm As New WrWoInvoice
        frm.IsWOFirstCreation(False)

        FillWRWOLabels(frm, VehicleID, CustomerID)
        frm.Show()


    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        InvoiceToExcel(dgvInvoice)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim filepath As String = "Invoices\"
        Dim filename As String = lblInvoiceNo.Text & "INV"

        loadDGVtoTxt(dgvInvoice, filepath, filename)


    End Sub

    Public Sub save(ByVal invoiceID As String)

        Dim filepath As String = "Invoices\"
        Dim filename As String = invoiceID & "INV"

        Dim file As String = filepath & filename & ".txt"

        Dim writer As TextWriter = New StreamWriter(file)

        For i As Integer = 0 To dgvInvoice.Rows.Count - 1 Step +1
            For j As Integer = 0 To dgvInvoice.Columns.Count - 1 Step +1
                writer.Write(dgvInvoice.Rows(i).Cells(j).Value.ToString() & ",")

            Next
            writer.Write(Environment.NewLine)
        Next

        writer.Close()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

        Dim vehicleIDTemp As Integer = vehID

        Dim frm As New InvoiceHistorySelChild

        frm.VehID = vehicleIDTemp





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class