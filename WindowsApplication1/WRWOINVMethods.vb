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



Imports Microsoft.Office.Interop

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
            Dim fn As String = rdr("fname").ToString
            Dim ln As String = rdr("lname").ToString

            frm.lblCuFname.Text = fn & " " & ln

            frm.lblAHomeNum.Text = rdr("AHTEL").ToString
            frm.lblBHomeNum.Text = rdr("htel").ToString
            frm.lblACellNum.Text = rdr("acell").ToString
            frm.lblBCellNum.Text = rdr("cell").ToString
            frm.lblCompany.Text = rdr("company").ToString
            frm.lblABusNum.Text = rdr("abtel").ToString
            frm.lblBBusNum.Text = rdr("btel").ToString

            frm.lblCuFname2.Text = fn & " " & ln

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

        Dim year As String
        Dim make As String
        Dim model As String

        While rdr2.Read

            year = rdr2("year").ToString
            make = rdr2("make").ToString
            model = rdr2("model").ToString

            frm.lblVeh.Text = year & " " & make & " " & model
            frm.lblPlate.Text = rdr2("plate").ToString
            frm.lblOdometer.Text = rdr2("odometer").ToString
            frm.lblVin.Text = rdr2("vin").ToString
            frm.lblUnitNo.Text = rdr2("unitno").ToString

            frm.lblVeh2.Text = year & " " & make & " " & model
            frm.lblPlate2.Text = rdr2("plate").ToString
            frm.lblOdometer2.Text = rdr2("odometer").ToString
            frm.lblVin2.Text = rdr2("vin").ToString
            frm.lblUnitNo2.Text = rdr2("unitno").ToString

        End While

        rdr2.Close()
        con1.Close()
    End Sub


    Public Sub FillInvLabels(ByRef frm As Invoice, ByVal vehicleID As String, ByVal customerID As String, ByVal InvoiceID As Integer, ByVal WorkOrderID As Integer, ByVal dte As Date)

        frm.lblInv.Text = InvoiceID
        frm.lblWoNo.Text = WorkOrderID
        frm.lblDate.Text = dte

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
            Dim fn As String = rdr("fname").ToString
            Dim ln As String = rdr("lname").ToString

            frm.lblCuFname.Text = fn & " " & ln
            frm.lblAHomeNum.Text = rdr("AHTEL").ToString
            frm.lblBHomeNum.Text = rdr("htel").ToString
            frm.lblACellNum.Text = rdr("acell").ToString
            frm.lblBCellNum.Text = rdr("cell").ToString
            frm.lblABusNum.Text = rdr("abtel").ToString
            frm.lblBBusNum.Text = rdr("btel").ToString
        End While
        rdr.Close()



        cmd = New OleDbCommand(strVe, con1)
        Dim rdr2 As OleDbDataReader = cmd.ExecuteReader()


        While rdr2.Read

            Dim year As String = rdr2("year").ToString
            Dim make As String = rdr2("make").ToString
            Dim model As String = rdr2("model").ToString

            frm.lblVeh.Text = year & " " & make & " " & model

            frm.lblPlate.Text = rdr2("plate").ToString
            frm.lblOdometer.Text = rdr2("odometer").ToString
            frm.lblVin.Text = rdr2("vin").ToString
            frm.lblUnitNo.Text = rdr2("unitno").ToString
            frm.lblEngSize.Text = rdr2("engsize").ToString
        End While

        rdr2.Close()
        con1.Close()
    End Sub

    Public Sub FillInvHistoryLabels(ByRef frm As InvoiceHistoryChild, ByVal InvID As Integer)

        Dim strcmd As String = "SELECT C"



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

    Public Function SaveWRtoDoc(ByVal boomarkreplace() As String) As String

        Dim filename As String

        'Load document
        Dim doc As New Spire.Doc.Document
        doc.LoadFromFile("C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\Templates\WRFINAL.dotx")

        Dim bookmarks() As String = {
             "bkCompany",
             "bkCuName",
             "bkCuBusPhone",
             "bkCuHomePhone",
             "bkCuCellPhone",
             "bkVeMake",
             "bkVeModel",
             "bkPlate",
             "bkVeVIN",
             "bkVeOdometer",
             "bkVeUnitNo",
             "bkDate",
             "bkCuRequests"}

        'Locate the bookmark
        Dim bookmarkNav As New BookmarksNavigator(doc)


        For i As Integer = 0 To 11
            bookmarkNav.MoveToBookmark(bookmarks(i))
            bookmarkNav.ReplaceBookmarkContent(boomarkreplace(i), False)

        Next


        'Save to disk
        doc.SaveToFile("C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\WRdoc.docx", Spire.Doc.FileFormat.Docx)
        'FileViewer("fdfd.docx")

        doc.Close()

        filename = "C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\WRdoc.docx"

        Return filename

    End Function

    Public Function ConvertDoctoJPG(fileToConvert As String) As String
        Dim filename As String

        Dim wrdDoc As New Document
        wrdDoc.LoadFromFile(fileToConvert)

        Dim img As Image = wrdDoc.SaveToImages(0, Documents.ImageType.Metafile)

        img.Save("C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\finaltestIMG.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


        filename = "C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\finaltestIMG.jpg"
        Return filename

    End Function



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

#Region "EXCEL METHODS"

    Public Function InvoiceToExcel(ByVal frm As Invoice, dgvInvoice As DataGridView) As String
        con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con1.Open()

        Dim CustomerID As Integer = frm.cusID
        Dim VehicleId As Integer = frm.vehID

        Dim cmdStr = "SELECT street, city, province, postal, abtel, btel FROM Customers WHERE ID = " & CustomerID & "; "
        Dim cmdstr2 = "SELECT engsize FROM CuVehicles WHERE ID = " & VehicleId & "; "

        Dim Street As String = ""
        Dim City As String = ""
        Dim Province As String = ""
        Dim PostalCode As String = ""
        Dim abtel As String = ""
        Dim btel As String = ""
        Dim engsize As String = ""

        Dim cmd As OleDbCommand = New OleDbCommand(cmdStr, con1)
        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdstr2, con1)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()
        Dim rdr2 As OleDbDataReader = cmd2.ExecuteReader()

        'TODO - Fill Customer/Vehicle/Admin
        While rdr.Read
            Street = rdr("street").ToString
            City = rdr("city").ToString
            Province = rdr("province").ToString
            PostalCode = rdr("postal").ToString
            abtel = rdr("abtel").ToString
            btel = rdr("btel").ToString
        End While

        While rdr2.Read
            engsize = rdr2("engsize").ToString
        End While


        rdr.Close()
        con1.Close()

        Dim InvoiceXLSFile As String

        Dim workbook As New Workbook
        workbook.LoadFromFile("C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\Templates\NEW TEMPLATE.xlsx")

        Dim sheet As Worksheet = workbook.Worksheets(0)

        sheet.Range("A6").Value = frm.lblCompany.Text
        sheet.Range("A7").Value = frm.lblCuFname.Text
        sheet.Range("A8").Value = Street
        sheet.Range("A9").Value = City & ", " & Province & ", " & PostalCode
        sheet.Range("B11").Value = abtel & " " & btel
        sheet.Range("B12").Value = frm.lblAHomeNum.Text & " " & frm.lblBHomeNum.Text
        sheet.Range("B11").Value = frm.lblACellNum.Text & " " & frm.lblBCellNum.Text
        sheet.Range("E6").Value = frm.lblVeh.Text
        sheet.Range("F7").Value = frm.lblPlate.Text
        sheet.Range("F8").Value = frm.lblOdometer.Text
        sheet.Range("F9").Value = frm.lblVin.Text
        sheet.Range("F10").Value = frm.lblUnitNo.Text
        sheet.Range("F11").Value = frm.lblEngSize.Text

        sheet.Range("J6").Value = frm.lblInv.Text
        sheet.Range("J7").Value = frm.lblDate.Text
        sheet.Range("J8").Value = GlobalAdmin.REGNO
        sheet.Range("J9").Value = GlobalAdmin.ADMINFNAME & " " & GlobalAdmin.ADMINLNAME

        sheet.Range("K38").Value = frm.tbSubTot.Text
        sheet.Range("K39").Value = frm.tbTax.Text
        sheet.Range("K41").Value = frm.tbTotal.Text

        For i As Integer = 0 To dgvInvoice.Rows.Count - 1
            For j As Integer = 0 To dgvInvoice.Columns.Count - 1

                Dim cellRowIndex As Integer = i + 14
                Dim cellColIndexInt As Integer = j + 1
                Dim cellColIndexStr As String = ""

                Select Case cellColIndexInt
                    Case 1
                        cellColIndexStr = "A"
                    Case 2
                        cellColIndexStr = "B"
                    Case 3
                        cellColIndexStr = "C"
                    Case 4
                        cellColIndexStr = "H"
                    Case 5
                        cellColIndexStr = "I"
                    Case 6
                        cellColIndexStr = "J"
                    Case 7
                        cellColIndexStr = "K"
                    Case 8
                        cellColIndexStr = "L"
                End Select

                Dim xlCell As String = cellColIndexStr & cellRowIndex.ToString
                Dim xlCellVal As String = dgvInvoice.Rows(i).Cells(j).Value.ToString

                If String.IsNullOrEmpty(xlCellVal) Then
                    xlCellVal = ""
                End If

                sheet.Range(xlCell).Value = dgvInvoice.Rows(i).Cells(j).Value.ToString

            Next
        Next

        workbook.SaveToFile("C:\Users\ASUS\Desktop\swagcity\SysTran (2) (2)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\EditSheet.xlsx", ExcelVersion.Version2010)

        'System.Diagnostics.Process.Start("EditSheet.xlsx")

        InvoiceXLSFile = "C:\Users\ASUS\Desktop\swagcity\SysTran (2) (2)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\EditSheet.xlsx"
        Return InvoiceXLSFile

    End Function


    Public Function XLStoJPeg(filename As String) As String
        Dim img As String
        Dim workbook As New Workbook
        workbook.LoadFromFile(filename)

        Dim sheet As Worksheet = workbook.Worksheets(0)
        sheet.SaveToImage("C:\Users\ASUS\Desktop\swagcity\SysTran (2) (2)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\EditSheetimg.tiff")


        img = "C:\Users\ASUS\Desktop\swagcity\SysTran (2) (2)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\EditSheetimg.tiff"
        Return img
    End Function


    Public Function XLStoDOCX(filename As String) As String
        Dim newDocFile

        Dim workbook As New Workbook
        workbook.LoadFromFile(filename)
        Dim sheet As Worksheet = workbook.Worksheets(0)

        Dim doc As New Document
        Dim table As Table = doc.AddSection.AddTable(True)
        table.ResetCells(sheet.LastRow, sheet.LastColumn)

        For r As Integer = 1 To sheet.LastRow - 1
            For c As Integer = 1 To sheet.LastColumn - 1
                Dim xCell As CellRange = sheet.Range(r, c)
                Dim wCell As TableCell = table.Rows(r - 1).Cells(c - 1)

                'fill data to word table
                Dim textRange As TextRange = wCell.AddParagraph.AppendText(xCell.NumberText)

                'Copy font and cell style from excel to word
                CopyStyle(textRange, xCell, wCell)


            Next

        Next

        For i As Integer = 0 To table.Rows.Count - 2
            For j As Integer = 0 To table.Rows(i).Cells.Count - 2
                table.Rows(i).Cells(j).Width = 60.0F
            Next
        Next

        doc.SaveToFile("C:\Users\ASUS\Desktop\swagcity\SysTran (2) (2)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\EditSheetDoc.docx", Spire.Doc.FileFormat.Docx)

        newDocFile = "C:\Users\ASUS\Desktop\swagcity\SysTran (2) (2)\SysTran\WindowsApplication1\WindowsApplication1\bin\Debug\EditSheetDoc.docx"


        Return newDocFile
    End Function

    Private Sub CopyStyle(ByVal wTextRange As TextRange, ByVal xCell As CellRange, ByVal wCell As TableCell)

        wTextRange.CharacterFormat.TextColor = xCell.Style.Font.Color
        wTextRange.CharacterFormat.FontSize = xCell.Style.Font.Size
        wTextRange.CharacterFormat.FontName = xCell.Style.Font.IsBold
        wTextRange.CharacterFormat.Italic = xCell.Style.Font.IsItalic

        wCell.CellFormat.BackColor = xCell.Style.Color

        Select Case xCell.HorizontalAlignment
            Case HorizontalAlignType.Left
                wTextRange.OwnerParagraph.Format.HorizontalAlignment = HorizontalAlignment.Left
            Case HorizontalAlignType.Center
                wTextRange.OwnerParagraph.Format.HorizontalAlignment = HorizontalAlignment.Center
            Case HorizontalAlignType.Right
                wTextRange.OwnerParagraph.Format.HorizontalAlignment = HorizontalAlignment.Right
        End Select




    End Sub

#End Region

End Module
