Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

'References for Excel
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO.Directory
Imports System.Text


Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel

Imports Spire.Xls
Imports System.IO

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

    Public Sub FillWRWOLabels(ByRef frm As WrWoInvoice, vehicleID As String, customerID As String)

        con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con1.Open()

        'frm.tbVehID.Text = vehicleID
        'frm.tbCuID.Text = customerID

        ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
        Dim strCu As String
        Dim strVe As String

        strCu = "SELECT * FROM Customers WHERE ID = " & customerID & " "
        strVe = "SELECT * FROM CuVehicles WHERE ID = " & vehicleID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCu, con1)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()


        'TODO - Fill Customer/Vehicle/Admin

        While rdr.Read
            frm.lblCuFname.Text = rdr("fname").ToString
            frm.lblCuLname.Text = rdr("lname").ToString
            frm.lblAHomeNum.Text = rdr("AHTEL").ToString
            frm.lblBHomeNum.Text = rdr("htel").ToString
            frm.lblACellNum.Text = rdr("acell").ToString
            frm.lblBCellNum.Text = rdr("cell").ToString
            frm.lblCompany.Text = rdr("company").ToString
            frm.lblABusNum.Text = rdr("abtel").ToString
            frm.lblBBusNum.Text = rdr("btel").ToString

            frm.lblCuFname2.Text = rdr("fname").ToString
            frm.lblCuLname2.Text = rdr("lname").ToString
            frm.lblAHomeNum2.Text = rdr("AHTEL").ToString
            frm.lblBHomeNum2.Text = rdr("htel").ToString
            frm.lblACellNum2.Text = rdr("acell").ToString
            frm.lblBCellNum2.Text = rdr("cell").ToString
            frm.lblCompany2.Text = rdr("company").ToString
            frm.lblABusNum2.Text = rdr("abtel").ToString
            frm.lblBBusNum2.Text = rdr("btel").ToString

        End While



        rdr.Close()

        cmd = New OleDbCommand(strVe, con1)
        Dim rdr2 As OleDbDataReader = cmd.ExecuteReader()


        While rdr2.Read

            frm.lblYear.Text = rdr2("year").ToString
            frm.lblMake.Text = rdr2("make").ToString
            frm.lblModel.Text = rdr2("model").ToString
            frm.lblPlate.Text = rdr2("plate").ToString
            frm.lblOdometer.Text = rdr2("odometer").ToString
            frm.lblVin.Text = rdr2("vin").ToString
            frm.lblUnitNo.Text = rdr2("unitno").ToString

            frm.lblYear2.Text = rdr2("year").ToString
            frm.lblMake2.Text = rdr2("make").ToString
            frm.lblModel2.Text = rdr2("model").ToString
            frm.lblPlate2.Text = rdr2("plate").ToString
            frm.lblOdometer2.Text = rdr2("odometer").ToString
            frm.lblVin2.Text = rdr2("vin").ToString
            frm.lblUnitNo2.Text = rdr2("unitno").ToString

        End While

        rdr2.Close()
        con1.Close()
    End Sub


    Public Sub FillInvLabels(ByRef frm As Invoice, vehicleID As String, customerID As String)

        con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con1.Open()

        ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
        Dim strCu As String
        Dim strVe As String

        strCu = "SELECT * FROM Customers WHERE ID = " & customerID & " "
        strVe = "SELECT * FROM CuVehicles WHERE ID = " & vehicleID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCu, con1)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()


        'TODO - Fill Customer/Vehicle/Admin

        While rdr.Read
            frm.lblCuFname.Text = rdr("fname").ToString
            frm.lblCuLname.Text = rdr("lname").ToString
            frm.lblCuAHomeNum.Text = rdr("AHTEL").ToString
            frm.lblCuBHomeNum.Text = rdr("htel").ToString
            frm.lblACellNum.Text = rdr("acell").ToString
            frm.lblBCellNum.Text = rdr("cell").ToString
        End While
        rdr.Close()



        cmd = New OleDbCommand(strVe, con1)
        Dim rdr2 As OleDbDataReader = cmd.ExecuteReader()


        While rdr2.Read
            frm.lblYear.Text = rdr2("year").ToString
            frm.lblMake.Text = rdr2("make").ToString
            frm.lblModel.Text = rdr2("model").ToString
            frm.lblPlate.Text = rdr2("plate").ToString
            frm.lblOdometer.Text = rdr2("odometer").ToString
            frm.lblVin.Text = rdr2("vin").ToString
            frm.lblUnitNo.Text = rdr2("unitno").ToString
        End While

        rdr2.Close()
        con1.Close()
    End Sub


    Public Function GetInsertedRecord(ByVal table As String) As Integer


        Dim ID As Integer

        con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con1.Open()

        Dim strcmd As String = "Select top 1 ID from " & table & " order by ID desc"
        Dim cmd As OleDbCommand = New OleDbCommand(strcmd, con1)

        ID = Int32.Parse(cmd.ExecuteScalar)

        con1.Close()

        Return ID

    End Function

    Public Sub CreateWRTextFile(ByVal tbWorkRequests As System.Windows.Forms.TextBox, WoID As Integer)

        Dim file As System.IO.StreamWriter
        Dim filepath As String = "WorkRequests\"

        file = My.Computer.FileSystem.OpenTextFileWriter(WoID & "WR.txt", True)
        file.WriteLine(tbWorkRequests.Text)
        file.Close()

    End Sub

    Public Sub CreateWOTextFile(ByVal dgvWorkOrder As System.Windows.Forms.DataGridView, WoID As Integer)

        Dim filepath As String = "WorkOrders\"
        Dim filename As String = WoID.ToString

        loadDGVtoTxt(dgvWorkOrder, filepath, filename)

    End Sub

    Public Sub SaveWRtoDoc()

        'Load document
        Dim doc As New Document
        doc.LoadFromFile("SysTran\WindowsApplication1\WindowsApplication1\Templates\WRFINAL.dotx")

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

        Dim file As String = filepath & filename & ".txt"

        Dim writer As TextWriter = New StreamWriter(file)

        For i As Integer = 0 To dgvWorkOrder.Rows.Count - 2 Step +1
            For j As Integer = 0 To dgvWorkOrder.Columns.Count - 1 Step +1
                writer.Write(dgvWorkOrder.Rows(i).Cells(j).Value.ToString() & ",")

            Next
            writer.Write(Environment.NewLine)
        Next

        writer.Close()


    End Sub




    Public Sub LoadTxtToDgv(ByRef datagridview As DataGridView, ByVal filepath As String, ByVal filename As String, ByRef isWorkOrder As Boolean)
        Dim rowLimit As Integer = 0


        Dim file As String = filepath & filename & ".txt"

        Dim reader As New StreamReader(file, Encoding.Default)

        Dim sline As String = ""

        If isWorkOrder = True Then
            rowLimit = 2
        Else
            rowLimit = 1
        End If

        Do
            sline = reader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            datagridview.Rows.Add("")
            For ix As Integer = 0 To 7
                datagridview.Rows(datagridview.Rows.Count - rowLimit).Cells(ix).Value = words(ix)
            Next
        Loop


    End Sub




    Public Sub InvoiceToExcel(ByVal dgvInvoice As DataGridView)

        Dim workbook As New Workbook
        workbook.LoadFromFile("SysTran\WindowsApplication1\WindowsApplication1\Templates\TSAutoInvoice.xlsx")

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
