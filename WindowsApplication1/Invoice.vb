Imports System.IO

Public Class Invoice

    Dim Access As New DBControl

    Public vehID As Integer
    Public cusID As Integer
    Dim invoiceID As Integer
    Dim workID As Integer
    Dim pic As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal customerid As Integer, ByVal vehicleid As Integer, ByVal InvID As Integer, ByVal WoID As Integer)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        vehID = vehicleid
        cusID = customerid
        invoiceID = InvID
        workID = WoID



    End Sub

    Public Sub New(ByVal customerid As Integer, ByVal vehicleid As Integer, ByVal InvID As Integer, ByVal WoID As Integer, ByVal dte As Date)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vehID = vehicleid
        cusID = customerid
        invoiceID = InvID
        workID = WoID
        lblDate.Text = dte
        lblInv.Text = InvID
        lblWoNo.Text = WoID
        lblReg.Text = GlobalAdmin.REGNO
        lblAdminName.Text = GlobalAdmin.ADMINFNAME & " " & GlobalAdmin.ADMINLNAME


    End Sub

#Region "LOAD METHODS"


    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvInvoice.Rows(0).Cells(0).Selected = False


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

#End Region

#Region "Button Clicks"

    Private Sub btnConverttoWO_Click(sender As Object, e As EventArgs) Handles btnConverttoWO.Click


        Dim result As Integer = MessageBox.Show("Are you sure you want to convert back to Work Order?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Dim IsInvoiceConverted As Boolean = True
            Dim InvoiceID As Integer = Convert.ToInt32(lblInv.Text)

            Access.AddParam("@convert", IsInvoiceConverted)
            Access.AddParam("@ID", InvoiceID)

            Access.ExecQuery("UPDATE Invoice " &
                             "SET VALUES isInvoiceConverted=@ID " &
                             "WHERE ID=@ID")

            Access.AddParam("@Status", False)
            Access.AddParam("@WOID", workID)

            Access.ExecQuery("UPDATE WorkOrder " &
                             "SET WOStatus=Status " &
                             "WHERE ID=@WOID;")

            Dim frm As New WrWoInvoice(workID, InvoiceID, cusID, vehID, lblDate.Text)
            'Load WR and WO text
            Dim filepath As String = "WorkOrders\"

            LoadTxtToDgv(frm.dgvWorkOrder, filepath, workID, True)
            frm.IsWOFirstCreation(False)

            FillWRWOLabels(frm, vehID, cusID)
            frm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click


        Dim InvoiceXLS As String = InvoiceToExcel(Me, dgvInvoice)
        Dim InvoiceIMG As String = XLStoJPeg(InvoiceXLS)
        pic = InvoiceIMG

        Dim frm As New PreviewDoc(pic)
        frm.Show()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim InvoiceXLS As String = InvoiceToExcel(Me, dgvInvoice)
        Dim InvoiceIMG As String = XLStoJPeg(InvoiceXLS)
        pic = InvoiceIMG

        Dim pages As Integer = NumericUpDown1.Value

        'PrintDoc.PrinterSettings.Copies = pages
        'PrintDoc.Print()


        Dim counter As Integer = 0

        While counter <> pages
            Dim oProcess As New System.Diagnostics.Process
            With oProcess.StartInfo

                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Hidden
                .Verb = "print"
                .UseShellExecute = True
                .FileName = InvoiceXLS

            End With
            oProcess.Start()

            counter = counter + 1
        End While


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

#End Region

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




#Region "PRINT METHODS"

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim grphcs As Graphics = e.Graphics

        grphcs.DrawImage(Image.FromFile(pic), 5, 5)

    End Sub

#End Region


End Class