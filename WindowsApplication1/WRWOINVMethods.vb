Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

'References for Excel
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO.Directory


Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel

Imports Spire.Xls




Module WRWOINVMethods

    Public Access As DBControl
    Dim con1 As New OleDbConnection

    Public Sub FileViewer(ByVal fileName As String)
        Try
            Process.Start(fileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WordDocViewer(ByVal fileName As String)
        Try
            Process.Start(fileName)
        Catch
        End Try
    End Sub



    Public Function GetInsertedRecord(ByVal table As String) As Integer


        Dim ID As Integer

        con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con1.Open()

        Dim strcmd As String = "Select top 1 ID from" & table & "order by ID desc"
        Dim cmd As OleDbCommand = New OleDbCommand(strcmd, con1)

        ID = Int32.Parse(cmd.ExecuteScalar)

        con1.Close()

        Return ID

    End Function

    Public Sub CreateWRTextFile(ByVal tbWorkRequests As System.Windows.Forms.TextBox, WoID As Integer)

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(WoID & "WR.txt", True)
        file.WriteLine(tbWorkRequests.Text)
        file.Close()

    End Sub

    Public Sub CreateWOTextFile(ByVal dgvWorkOrder As System.Windows.Forms.DataGridView, WoID As Integer)


        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(WoID & ".txt", True)

        For i As Integer = 0 To dgvWorkOrder.Rows.Count - 2
            For j As Integer = 0 To dgvWorkOrder.Columns.Count - 1

                file.WriteLine(dgvWorkOrder.Rows(i).Cells(j).Value.ToString)

            Next
        Next

        file.Close()

    End Sub

    Public Sub SaveWRtoDoc()

        'Load document
        Dim doc As New Document
        doc.LoadFromFile("C:\Users\ASUS\Desktop\swagcity\SysTran (2)\SysTran (2)\SysTran\WindowsApplication1\WindowsApplication1\Templates\WRFINAL.dotx")

        'Locate the bookmark
        Dim bookmarkNav As New BookmarksNavigator(doc)
        bookmarkNav.MoveToBookmark("bkCuName")

        'Replace content
        bookmarkNav.ReplaceBookmarkContent("FUCKKKK", False)


        'Save to disk
        doc.SaveToFile("fdfd", Spire.Doc.FileFormat.Docx)
        FileViewer("fdfd.docx")

        doc.Close()

    End Sub

    Public Sub PreviewWR()
        Dim doc As New Document
        doc.LoadFromFile("fdfd.docx")

        '
        Dim img As Image = doc.SaveToImages(0, Documents.ImageType.Metafile)
        img.Save("sample.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

        WordDocViewer("sample.bmp")


    End Sub


    'TODO - CONVERT DOC TO IMAGE TO PRINT
    Public Sub PrintWR()

        'Load Document
        Dim doc As New Document
        doc.LoadFromFile("C:\Users\ASUS\Documents\test.docx")

        'Print dialog
        Dim dialog As New PrintDialog
        dialog.AllowCurrentPage = True
        dialog.AllowSomePages = True
        dialog.UseEXDialog = True

        Try
            'doc.PrintDialog = dialog
            'dialog.Document = doc.PrintDocument
            dialog.Document.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error fam", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        doc.Close()
    End Sub





    Public Sub loadDGVtoTxt(ByVal dgvWorkOrder As DataGridView, filepath As String, filename As String)


        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filepath & filename & ".txt", True)

        For i As Integer = 0 To dgvWorkOrder.Rows.Count - 2
            For j As Integer = 0 To dgvWorkOrder.Columns.Count - 1

                file.WriteLine(dgvWorkOrder.Rows(i).Cells(j).Value.ToString)

            Next
        Next

        file.Close()


    End Sub


    Public Sub LoadTxtToDgv(ByRef datagridview As DataGridView, ByVal filename As String)

        Dim reader As System.IO.StreamReader
        reader = My.Computer.FileSystem.OpenTextFileReader(filename)


        Dim str As String
        Dim col As Integer = 0
        Dim row As Integer = 0


        Do
            str = reader.ReadLine
            datagridview.Rows(row).Cells(col).Value = str

            col = col + 1

            If col = 8 Then
                row = row + 1
                col = 0
            End If

        Loop Until str Is Nothing

    End Sub




    Public Sub InvoiceToExcel(ByVal dgvInvoice As DataGridView)

        Dim workbook As New Workbook
        workbook.LoadFromFile("C:\Users\ASUS\Desktop\swagcity\SysTran (3) (1)\SysTran (3)\SysTran\WindowsApplication1\WindowsApplication1\Templates\TSAutoInvoice.xlsx")

        Dim sheet As Worksheet = workbook.Worksheets(0)

        For i As Integer = 0 To dgvInvoice.Rows.Count - 2
            For j As Integer = 0 To dgvInvoice.Columns.Count - 1

                Dim cellRowIndex As Integer = i + 15
                Dim cellColIndexInt As Integer = j + 1
                Dim cellColIndexStr As String

                Select Case cellColIndexInt
                    Case 1
                        cellColIndexStr = "A"
                    Case 2
                        cellColIndexStr = "B"
                    Case 3
                        cellColIndexStr = "C"
                    Case 4
                        cellColIndexStr = "D"
                    Case 5
                        cellColIndexStr = "E"
                    Case 6
                        cellColIndexStr = "F"
                    Case 7
                        cellColIndexStr = "G"
                    Case 8
                        cellColIndexStr = "H"
                End Select

                Dim xlCell As String = cellColIndexStr & cellRowIndex.ToString
                Dim xlCellVal As String = dgvInvoice.Rows(i).Cells(j).Value.ToString

                If String.IsNullOrEmpty(xlCellVal) Then
                    xlCellVal = ""
                End If

                sheet.Range(xlCell).Value = dgvInvoice.Rows(i).Cells(j).Value.ToString

            Next
        Next

        workbook.SaveToFile("EditSheet.xlsx", ExcelVersion.Version2010)

        System.Diagnostics.Process.Start("EditSheet.xlsx")


    End Sub

    'TODO 
    Public Sub PrintInvoice()

    End Sub


End Module
