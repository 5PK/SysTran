Imports System.Data.OleDb

Public Class InvoiceHistoryChild

    Dim con As New OleDbConnection

    Dim InvoiceID As Integer
    Dim CustomerID As Integer
    Dim VehicleID As Integer
    Dim Odo As Integer
    Dim Dte As String
    Dim WorkOrderID As Integer

    Public Sub New(ByVal InvID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InvoiceID = InvID
        getCusVehID(InvID)
        fillLabels()
        dgvInvoice.ClearSelection()

    End Sub

    Private Sub getCusVehID(ByVal InvID)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim strCMD As String = "Select * From Invoice WHERE ID = " & InvoiceID

        Dim cmd As OleDbCommand = New OleDbCommand(strCMD, con)

        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read()
            CustomerID = rdr("cusID")
            VehicleID = rdr("vehID")
            Odo = rdr("odometer")
            Dte = rdr("Dte").ToString
            WorkOrderID = rdr("WoID")
        End While

        rdr.Close()
        con.Close()

    End Sub

    Private Sub fillLabels()
        lblOdometer.Text = Odo
        lblDate.Text = Dte
        lblInvoiceNo.Text = InvoiceID
        lblWoNo.Text = WorkOrderID

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
        Dim strCu As String
        Dim strVe As String

        strCu = "SELECT * FROM Customers WHERE ID = " & CustomerID & " "
        strVe = "SELECT * FROM CuVehicles WHERE ID = " & VehicleID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCu, con)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()


        While rdr.Read
            lblCuFname.Text = rdr("fname").ToString
            lblCuLname.Text = rdr("lname").ToString
            lblCompany.Text = rdr("company").ToString
        End While

        rdr.Close()


        cmd = New OleDbCommand(strVe, con)
        Dim rdr2 As OleDbDataReader = cmd.ExecuteReader()


        While rdr2.Read

            lblYear.Text = rdr2("year").ToString
            lblMake.Text = rdr2("make").ToString
            lblModel.Text = rdr2("model").ToString
            lblPlate.Text = rdr2("plate").ToString
            lblVin.Text = rdr2("vin").ToString
            lblUnitNo.Text = rdr2("unitno").ToString


        End While

        rdr2.Close()
        con.Close()

    End Sub

    Private Sub lblYear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub InvoiceHistoryChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class