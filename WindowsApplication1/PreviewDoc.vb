Public Class PreviewDoc

    Dim pic As String

    Public Sub New(filename As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'ConverttoJPG(filename)

        pic = filename

        loadJPG(filename)


    End Sub

    Private Sub loadJPG(ByVal filename As String)

        PictureBox1.Image = Image.FromFile(filename)

    End Sub

    Private Sub PreviewWR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim grphcs As Graphics = e.Graphics

        grphcs.DrawImage(Image.FromFile(pic), 5, 5)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim pages As Integer = NumericUpDown1.Value

        PrintDoc.PrinterSettings.Copies = pages
        PrintDoc.Print()

    End Sub


End Class