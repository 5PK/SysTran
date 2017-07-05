
Imports System.Data.OleDb

Public Class WrWoInvoice

    Inherits Form

    Dim CustomerID As String
    Dim VehicleID As String
    Dim dtetoday As Date

    Dim FirstCreate As Boolean
    Dim InvoiceID As Integer = 0

    Dim TotalPrice As Double


    Private Access As New DBControl
    Dim con As New OleDbConnection

    Dim WorkOrderID As Integer

    Public Sub New()

        InitializeComponent()

    End Sub

    'FROM WORK ORDER CREATION
    Public Sub New(ByVal cusid As Integer, ByVal vehid As Integer, ByVal dte As Date)

        InitializeComponent()

        CustomerID = cusid
        VehicleID = vehid
        dtetoday = dte

    End Sub

    'FROM PENDING WO
    Public Sub New(ByVal WoID As Integer, ByVal cusid As Integer, ByVal vehid As Integer, ByVal dte As Date)

        InitializeComponent()

        WorkOrderID = WoID
        lblWoNo.Text = WoID
        lblWoNo2.Text = WoID

        CustomerID = cusid
        VehicleID = vehid
        dtetoday = dte

    End Sub

    'CONVERTED FROM INVOICE
    Public Sub New(ByVal invID As Integer, ByVal WoID As Integer, ByVal cusid As Integer, ByVal vehid As Integer, ByVal dte As Date)

        InitializeComponent()

        WorkOrderID = WoID
        InvoiceID = invID

        lblWoNo.Text = WoID
        lblWoNo2.Text = WoID

        lblInv.Text = invID
        lblInv2.Text = invID

        CustomerID = cusid
        VehicleID = vehid
        dtetoday = dte

    End Sub

    Private Sub WrWoInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvWorkOrder.DefaultCellStyle.Font = New Font("Courier New", 9)
        dgvWorkOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvWorkOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        lblDate.Text = dtetoday
        lblDate2.Text = dtetoday
        lblAdminFname.Text = GlobalAdmin.ADMINFNAME & " " & GlobalAdmin.ADMINLNAME
        lblAdminFname2.Text = GlobalAdmin.ADMINFNAME & " " & GlobalAdmin.ADMINLNAME

        lblReg.Text = GlobalAdmin.REGNO
        lblReg2.Text = GlobalAdmin.REGNO

    End Sub

    Public Sub IsWOFirstCreation(ByVal IsWOFC As Boolean)

        FirstCreate = IsWOFC

    End Sub

    Private Sub updateVehOdo()
        'ADD PARAMETERS - ORDER MATTERS


        Access.AddParam("@odo", lblOdometer.Text)
        Access.AddParam("@vehid", VehicleID)

        'RUN COMMAND

        Access.ExecQuery("UPDATE CuVehicles " &
                         "SET odometer=@odo " &
                         "WHERE ID=@vehid;")

    End Sub

#Region "WO GRID METHODS"

    Private Sub dgvWordOrder_CellDelete(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvWorkOrder.KeyDown
        If e.KeyCode = Keys.Delete Then

            Dim cell As DataGridView = dgvWorkOrder

            cell.CurrentCell.Value = 0
            cell.BeginEdit(True)
            CalculateCells()



        End If

    End Sub

    Private Sub dgvWorkOrder_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvWorkOrder.CellEndEdit
        CalculateCells()

    End Sub

    Public Sub CalculateCells()
        Dim SubTotal As Double = 0.0
        Dim FinalTotal As Double = 0.0

        For Each row As DataGridViewRow In dgvWorkOrder.Rows
            For i As Integer = 0 To 7

                If row.Cells(i).Value Is Nothing Then
                    Select Case i
                        Case 0
                            row.Cells(i).Value = 0
                        Case 1
                            row.Cells(i).Value = 0
                        Case 2
                            row.Cells(i).Value = ""
                        Case 3
                            row.Cells(i).Value = 0
                        Case 4
                            row.Cells(i).Value = 0
                        Case 5
                            row.Cells(i).Value = 0
                        Case 6
                            row.Cells(i).Value = 0
                        Case 7
                            row.Cells(i).Value = 0
                    End Select

                ElseIf i <> 2 Then
                    Dim parseto As Double = 0.0
                    'If row.Cells(i).Value.GetType = GetType(String) Then
                    If Double.TryParse(row.Cells(i).Value, parseto) = False Then
                        MessageBox.Show("Please Enter a Numeric Value")
                        row.Cells(i).Value = 0
                    End If
                End If
            Next

            Dim qty As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colQty").Index).Value)
            Dim PartsEa As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colPartsEa").Index).Value)

            row.Cells(dgvWorkOrder.Columns("colTotPart").Index).Value = qty * PartsEa

            Dim Hrs As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colHrs").Index).Value)
            Dim labour As Double = row.Cells(dgvWorkOrder.Columns("colLabour").Index).Value

            If Hrs > 0 Then
                labour = Hrs * GlobalAdmin.LABOURRATE
                row.Cells(dgvWorkOrder.Columns("colLabour").Index).Value = labour
            End If

            row.Cells(dgvWorkOrder.Columns("colTotal").Index).Value = row.Cells(dgvWorkOrder.Columns("colTotPart").Index).Value + row.Cells(dgvWorkOrder.Columns("colLabour").Index).Value

            SubTotal = SubTotal + row.Cells(7).Value

        Next

        tbSubtot.Text = SubTotal
        tbTax.Text = SubTotal * GlobalAdmin.TAX


        FinalTotal = tbTax.Text + SubTotal

        tbTotal.Text = "$" & FinalTotal
        TotalPrice = FinalTotal

    End Sub

#End Region

#Region "WORK REQUEST METHODS"

    Private Sub PrintWorkRequest(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim SplitArray() As String = Split(lblVeh.Text)

        Dim bookmarkreplace() As String = {
            lblCompany.Text,
            lblCuFname.Text,
            lblABusNum.Text & " " & lblBBusNum.Text,
            lblAHomeNum.Text & " " & lblBHomeNum.Text,
            lblACellNum.Text & " " & lblBCellNum.Text,
            SplitArray(0) & " " & SplitArray(1),
            SplitArray(2),
            lblPlate.Text,
            lblVin.Text,
            lblOdometer.Text,
            lblUnitNo.Text,
            lblDate.Text,
            tbWorkRequests.Text}


        Dim docFile As String = SaveWRtoDoc(bookmarkreplace)
        Dim imgFile As String = ConvertDoctoJPG(docFile)



    End Sub

    Private Sub PreviewWorkRequest(sender As Object, e As EventArgs) Handles btnPreview.Click

        Dim SplitArray() As String = Split(lblVeh.Text)


        Dim bookmarkreplace() As String = {
            lblCompany.Text,
            lblCuFname.Text,
            lblABusNum.Text & " " & lblBBusNum.Text,
            lblAHomeNum.Text & " " & lblBHomeNum.Text,
            lblACellNum.Text & " " & lblBCellNum.Text,
            SplitArray(0) & " " & SplitArray(1),
            SplitArray(2),
            lblPlate.Text,
            lblVin.Text,
            lblOdometer.Text,
            lblUnitNo.Text,
            lblDate.Text}


        Dim docFile As String = SaveWRtoDoc(bookmarkreplace)
        Dim imgFile As String = ConvertDoctoJPG(docFile)

        Dim frm As New PreviewDoc(imgFile)
        frm.Show()


    End Sub

#End Region

#Region "SAVE METHODS"

    Private Sub btnSaveWRWO_Click(sender As Object, e As EventArgs) Handles btnSaveWRWO.Click

        Save()

    End Sub

    Private Sub SaveAndExit_Click(sender As Object, e As EventArgs) Handles btnSaveAndExit.Click

        Save()

        Me.Close()

    End Sub

    Private Sub Save()

        updateVehOdo()
        Dim WoID As Integer

        If FirstCreate = True Then
            AddWOtoDB()
            WoID = GetInsertedRecord("WorkOrder")
            FirstCreate = False
            lblWoNo.Text = WoID
            lblWoNo2.Text = WoID
            WorkOrderID = WoID
        Else
            'WoID = Convert.ToInt32(lblWoNo.Text)
            WoID = WorkOrderID

        End If

        CreateWRTextFile(tbWorkRequests, WoID)
        CreateWOTextFile(dgvWorkOrder, WoID)

    End Sub

#End Region

#Region "DATABSE METHODS"
    Private Sub AddWOtoDB()

        Dim flnm As String = lblCuFname.Text
        Dim flnmSplit As String() = flnm.Split(New Char() {" "c})

        Dim WOStatus As Boolean = False

        Access.AddParam("@cusid", CustomerID)
        Access.AddParam("@vehid", VehicleID)
        Access.AddParam("@WOstatus", WOStatus)
        Access.AddParam("@Dte", dtetoday)


        'RUN COMMAND
        Access.ExecQuery("INSERT INTO WorkOrder (CusID, vehID, WOStatus, Dte) " &
                         "VALUES (@cusid,@vehid,@WOstatus,@Dte); ")

    End Sub

    Public Sub ToggleWOComplete(ByVal WoID As Integer)

        'Toggle Work Order as Complete in DB
        Dim WOStatus As Boolean = True

        ''Add Parameters
        Access.AddParam("@WOStatus", WOStatus)
        Access.AddParam("@WOID", WoID)

        ''Insert Record
        Access.ExecQuery("UPDATE WorkOrder " &
                         "SET WOStatus=@WOStatus " &
                         "WHERE ID=@WOID;")

    End Sub

#End Region

#Region "CLICK METHODS"

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

        Dim frm As New InvoiceHistorySelChild(VehicleID)
        frm.Show()

    End Sub

    Private Sub tpWorkOrder_Click(sender As Object, e As EventArgs) Handles tpWorkOrder.Click

    End Sub

    Private Sub btnCustomer1_Click(sender As Object, e As EventArgs) Handles btnCustomer1.Click
        Dim frm As New UpdateCustomerInfo

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
        Dim strCu As String

        strCu = "SELECT * FROM Customers WHERE ID = " & CustomerID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCu, con)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()

        'TODO - Fill Customer/Vehicle/Admin
        While rdr.Read
            frm.tbFname.Text = rdr("fname").ToString
            frm.tbLname.Text = rdr("lname").ToString
            frm.tbAHomeNum.Text = rdr("AHTEL").ToString
            frm.tbBHomeNum.Text = rdr("htel").ToString
            frm.tbACellNum.Text = rdr("acell").ToString
            frm.tbBCellNum.Text = rdr("cell").ToString
            frm.tbCompany.Text = rdr("company").ToString
            frm.tbABusNum.Text = rdr("abtel").ToString
            frm.tbBBusNum.Text = rdr("btel").ToString
        End While

        con.Close()

        frm.Show()


    End Sub

    Private Sub btnCustomer2_Click(sender As Object, e As EventArgs) Handles btnCustomer2.Click

        Dim frm As New UpdateCustomerInfo

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()



        ''QUERIES RECORDS PERTAINING TO CUSTOMER ID
        Dim strCu As String

        strCu = "SELECT * FROM Customers WHERE ID = " & CustomerID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCu, con)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()


        'TODO - Fill Customer/Vehicle/Admin

        While rdr.Read
            frm.tbFname.Text = rdr("fname").ToString
            frm.tbLname.Text = rdr("lname").ToString
            frm.tbAHomeNum.Text = rdr("AHTEL").ToString
            frm.tbBHomeNum.Text = rdr("htel").ToString
            frm.tbACellNum.Text = rdr("acell").ToString
            frm.tbBCellNum.Text = rdr("cell").ToString
            frm.tbCompany.Text = rdr("company").ToString
            frm.tbABusNum.Text = rdr("abtel").ToString
            frm.tbBBusNum.Text = rdr("btel").ToString
        End While

        con.Close()

        frm.Show()

    End Sub

    Private Sub lblOdometer_Click(sender As Object, e As EventArgs) Handles lblOdometer.Click

        Dim Message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        Message = "Enter a new Mileage"
        ' Set title.
        title = "InputBox Demo"
        defaultValue = "0"   ' Set default value.

        ' Display message, title, and default value.
        myValue = InputBox(Message, title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue 
        lblOdometer = myValue
        lblOdometer2 = myValue

    End Sub

    Private Sub lblOdometer2_Click(sender As Object, e As EventArgs) Handles lblOdometer2.Click

        Dim Message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        Message = "Enter a new Mileage"
        ' Set title.
        title = "InputBox Demo"
        defaultValue = "0"   ' Set default value.

        ' Display message, title, and default value.
        myValue = InputBox(Message, title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue 
        lblOdometer = myValue
        lblOdometer2 = myValue

    End Sub

    Private Sub SaveAndConvertToInvoice_Click(sender As Object, e As EventArgs) Handles btnSaveAndCnvrtToInvoice.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to convert to Invoice?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Save()
            ToggleWOComplete(WorkOrderID)

            'Dim WoID As String = lblWoNo.Text
            Dim WoID As Integer = WorkOrderID
            ToggleWOComplete(Convert.ToInt32(WoID))

            If InvoiceID = 0 Then
                Dim frm As New PaymentSel(tbTax.Text, tbSubtot.Text, CustomerID, VehicleID, WoID, lblOdometer.Text)
                frm.Show()

                Me.Close()
            ElseIf InvoiceID > 0 Then
                Dim frm As New PaymentSel(tbTax.Text, tbSubtot.Text, CustomerID, VehicleID, WoID, lblOdometer.Text, InvoiceID)
                frm.Show()

                Me.Close()

            End If
        End If
    End Sub



#End Region


End Class