'TO Create a Word file, import word libary then create 3 objects


Public Class WrWoInvoice

    Dim oWord As Microsoft.Office.Interop.Word.Application
    Dim wd As Microsoft.Office.Interop.Word.Document


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub WrWoInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO - Fill Customer/Vehicle/Admin



    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnPrintWR.Click
        oWord.Documents.Add()

    End Sub
End Class