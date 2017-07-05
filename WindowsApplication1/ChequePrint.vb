Imports System.Data.OleDb
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields




Public Class ChequePrint
    Dim con As New OleDbConnection

    Dim fileprint As String
    Private stringToPrint As String


    Dim bookmarkFill As String()

    Dim PriceInWords As String
    Dim Cents As Integer
    Dim Price As Double


    Public Sub New(chequeNo As Integer, dte As System.DateTime, supplierID As Integer, payment As Double)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Price = payment

        lblChequeNo.Text = chequeNo
        loadsuppInfo(supplierID)
        loadadmininfo()
        PriceConvert()

        loadBookmarkArray()

        bookmarkFill = {
            lblCents.Text,
            lblDte.Text,
            lblDte.Text,
            lblDte.Text,
            lblDte.Text,
            lblDte.Text,
            Price,
            Price,
            Price,
            lblToCompany.Text,
            lblToCompany.Text,
            lblToCompany.Text,
            PriceInWords,
            lblToStreet.Text,
            lblToStreet.Text,
            lblToStreet.Text,
            lbltoCity.Text & ", " & lblToProv.Text & ", " & lblPostal.Text,
            lbltoCity.Text & ", " & lblToProv.Text & ", " & lblPostal.Text,
            lbltoCity.Text & ", " & lblToProv.Text & ", " & lblPostal.Text
        }

        CreateChequeRTF()


    End Sub

    Private Sub loadBookmarkArray()

        bookmarkFill = {lblDte.Text,
                        lblNumWords.Text,
                        lblCents.Text,
                        lblCost.Text,
                        lblToCompany.Text,
                        lblToStreet.Text,
                        lbltoCity.Text,
                        lblToProv.Text,
                        lblToPostal.Text}

    End Sub

    Private Sub PriceConvert()
        Dim PriceAsInt As Integer = Math.Truncate(Price)
        Cents = (Price - PriceAsInt) * 100

        Dim cnvrt As New Converter(PriceAsInt, Converter.ConvertStyle.English)

        Dim Str As String = cnvrt.Convert

        Dim PriceInWords As String = "***" & Str & "***"

        lblNumWords.Text = PriceInWords
        lblCents.Text = Cents
        lblCost.Text = Price


    End Sub

    Private Sub CreateChequeRTF()


        Dim doc As New Spire.Doc.Document
        doc.LoadFromFile("C:\Users\ASUS\Desktop\swagcity\SysTran (5)\SysTran\WindowsApplication1\WindowsApplication1\Templates\Cheque.dotx")

        Dim bookmarks() As String = {"bkCents",
                                     "bkDate1",
                                     "bkDate2",
                                     "bkDate3",
                                     "bkDateRec1",
                                     "bkDateRec2",
                                     "bkPayDouble1",
                                     "bkPayDouble2",
                                     "bkPayDouble3",
                                     "bkPayee1",
                                     "bkPayee2",
                                     "bkPayee3",
                                     "bkPaymentWords",
                                     "bkStreet1",
                                     "bkStreet2",
                                     "bkStreet3",
                                     "bkCityProvPostal1",
                                     "bkCityProvPostal2",
                                     "bkCityProvPostal3"}

        Dim bookmarkNav As New BookmarksNavigator(doc)

        For i As Integer = 0 To 18
            bookmarkNav.MoveToBookmark(bookmarks(i))
            bookmarkNav.ReplaceBookmarkContent(bookmarkFill(i), False)
        Next

        doc.SaveToFile("chequesave.docx")
        doc.Close()

        Dim rtfDOC As New Document
        rtfDOC.LoadFromFile("chequesave.docx")
        rtfDOC.SaveToFile("chequesave.rtf", FileFormat.Rtf)

        fileprint = "chequesave.rtf"

    End Sub

    Private Sub loadadmininfo()
        lblCompany.Text = GlobalAdmin.COMPANY
        lblStreet.Text = GlobalAdmin.STREET
        lblCityProv.Text = GlobalAdmin.CITY & ", " & GlobalAdmin.PROVINCE
        lblPostal.Text = GlobalAdmin.POSTAL

    End Sub

    Private Sub loadsuppInfo(ByVal supplierID As Integer)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim cmdStr As String = "SELECT * FROM Suppliers WHERE ID = " & supplierID & ";"

        Dim cmd As OleDbCommand = New OleDbCommand(cmdStr, con)
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read
            lblToCompany.Text = rdr("company").ToString
            lblToStreet.Text = rdr("street").ToString
            lbltoCity.Text = rdr("city").ToString
            lblToProv.Text = rdr("province").ToString
            lblToPostal.Text = rdr("postal").ToString

        End While

    End Sub

    Private Sub ChequePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim oProcess As New System.Diagnostics.Process
        'With oProcess.StartInfo

        '    .CreateNoWindow = True
        '    .WindowStyle = ProcessWindowStyle.Hidden
        '    .Verb = "print"
        '    .UseShellExecute = True
        '    .FileName = fileprint

        'End With
        'oProcess.Start()


        ReadFile()
        PrintDocument1.Print()

    End Sub

    Private Sub ReadFile()

        PrintDocument1.DocumentName = fileprint
        Dim stream As New FileStream(fileprint, FileMode.Open)
        Try
            Dim reader As New StreamReader(stream)
            Try
                stringToPrint = reader.ReadToEnd()
            Finally
                reader.Dispose()
            End Try
        Finally
            stream.Dispose()
        End Try
    End Sub

End Class