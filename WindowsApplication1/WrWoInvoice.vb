
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Public Class WrWoInvoice
    Inherits Form

    Public Sub New()


        InitializeComponent()



    End Sub

    Private Sub WrWoInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub

    Private Sub FileViewer(ByVal fileName As String)
        Try
            Process.Start(fileName)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub SaveWorkRequest(sender As Object, e As EventArgs) Handles btnSaveWR.Click

        'Load document
        Dim doc As New Document
        doc.LoadFromFile("C:\Users\ASUS\Desktop\swagcity\SysTran (2)\SysTran (2)\SysTran\WindowsApplication1\WindowsApplication1\Templates\WRFINAL.dotx")

        'Locate the bookmark
        Dim bookmarkNav As New BookmarksNavigator(doc)

        bookmarkNav.MoveToBookmark("bkCuName")
        'Replace content
        bookmarkNav.ReplaceBookmarkContent("FUCKKKK", False)


        'Save to disk
        doc.SaveToFile("fdfd", FileFormat.Docx)
        FileViewer("fdfd.docx")

        doc.Close()

    End Sub



    Private Sub PrintWorkRequest(sender As Object, e As EventArgs) Handles btnPrint.Click

        'Load Document
        Dim doc As New Document
        doc.LoadFromFile("C:\Users\ASUS\Documents\test.docx")

        'Print dialog
        Dim dialog As New PrintDialog
        dialog.AllowCurrentPage = True
        dialog.AllowSomePages = True
        dialog.UseEXDialog = True

        Try
            doc.PrintDialog = dialog
            dialog.Document = doc.PrintDocument
            dialog.Document.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error fam", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub

    Private Sub PreviewWorkRequest(sender As Object, e As EventArgs) Handles btnPreview.Click



    End Sub

    Private Sub dgvWorkOrder_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

        For Each row As DataGridViewRow In dgvWorkOrder.Rows

            Dim qty As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colQty").Index).Value)
            Dim PartsEa As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colPartsEa").Index).Value)

            row.Cells(dgvWorkOrder.Columns("colTotPart").Index).Value = qty * PartsEa

        Next
    End Sub


End Class