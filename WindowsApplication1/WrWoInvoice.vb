
Imports System.Data.OleDb

Public Class WrWoInvoice

    Inherits Form

    Public CustomerID As String
    Public VehicleID As String

    Dim FirstCreate As Boolean
    Dim TotalPrice As Double


    Private Access As New DBControl
    Dim con As New OleDbConnection


    Public Sub New()

        InitializeComponent()





    End Sub

    Private Sub WrWoInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvWorkOrder.DefaultCellStyle.Font = New Font("Courier New", 9)
        dgvWorkOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvWorkOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True



    End Sub

    Public Sub IsWOFirstCreation(ByVal IsWOFC As Boolean)

        FirstCreate = IsWOFC

    End Sub


    Private Sub dgvWordOrder_CellDelete(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvWorkOrder.KeyDown
        If e.KeyCode = Keys.Delete Then

            Dim cell As DataGridView = dgvWorkOrder
            cell.CurrentCell.Value = 0
            cell.BeginEdit(True)


        End If

    End Sub

    Private Sub dgvWorkOrder_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvWorkOrder.CellEndEdit

        Dim AllTotal As Double = 0.0

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
                labour = Hrs * 99.95
                row.Cells(dgvWorkOrder.Columns("colLabour").Index).Value = labour
            End If


            row.Cells(dgvWorkOrder.Columns("colTotal").Index).Value = row.Cells(dgvWorkOrder.Columns("colTotPart").Index).Value + row.Cells(dgvWorkOrder.Columns("colLabour").Index).Value

            AllTotal = AllTotal + row.Cells(7).Value

        Next

        tbTax.Text = AllTotal * 0.13
        AllTotal = AllTotal + tbTax.Text

        tbTotal.Text = "$" & AllTotal
        TotalPrice = AllTotal

    End Sub



    Private Sub PrintWorkRequest(sender As Object, e As EventArgs) Handles btnPrint.Click

        SaveWRtoDoc()
        PrintWR()


    End Sub

    Private Sub PreviewWorkRequest(sender As Object, e As EventArgs) Handles btnPreview.Click
        SaveWRtoDoc()


    End Sub



    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    '_________________________________________________________________________________________________________________
    'SAVE METHODS

    Private Sub SaveAndConvertToInvoice_Click(sender As Object, e As EventArgs) Handles btnSaveAndCnvrtToInvoice.Click


        Save()

        AddInvoicetoDB()

        Dim InvoiceNo As Integer = GetInsertedRecord("Invoice")
        Dim WoID As String = lblWoNo.Text
        ToggleWOComplete(Convert.ToInt32(WoID))

        Dim frm As New PaymentSel

        frm.InvID = InvoiceNo
        frm.CusID = CustomerID
        frm.VehID = VehicleID
        frm.WoID = WoID

        frm.tbAR.Text = TotalPrice
        frm.tbTotalPaid.Text = TotalPrice
        frm.tbInvTotal.Text = TotalPrice
        frm.tbOutstanding.Text = 0.0

        frm.Show()

        Me.Close()





        'Dim frm As New Invoice



        'frm.lblInvoiceNo.Text = InvoiceNo
        'frm.lblWoNo.Text = WoID

        'frm.vehID = VehicleID
        'frm.cusID = CustomerID

        'FillInvLabels(frm, VehicleID, CustomerID)


        ''FILL INVOICE DGV


        'Dim filepath As String = "WorkOrders\"
        'Dim filename As String = WoID

        'LoadTxtToDgv(frm.dgvInvoice, filepath, filename)
        'frm.getRidofZero()
        'frm.tbTotal.Text = tbTotal.Text
        'frm.save(Convert.ToString(InvoiceNo))
        'frm.dgvInvoice.CurrentCell = Nothing
        'frm.Show()
        'Me.Close()



    End Sub




    Private Sub btnSaveWRWO_Click(sender As Object, e As EventArgs) Handles btnSaveWRWO.Click

        Save()

    End Sub

    Private Sub SaveAndExit_Click(sender As Object, e As EventArgs) Handles btnSaveAndExit.Click

        Save()

        Me.Close()

    End Sub

    Private Sub Save()

        Dim WoID As Integer

        If FirstCreate = True Then
            AddWOtoDB()
            WoID = GetInsertedRecord("WorkOrder")
            FirstCreate = False
            lblWoNo.Text = WoID
        Else
            WoID = Convert.ToInt32(lblWoNo.Text)

        End If

        CreateWRTextFile(tbWorkRequests, WoID)
        CreateWOTextFile(dgvWorkOrder, WoID)

    End Sub



    '_________________________________________________________________________________________________________________
    'DATABASE METHODS

    Private Sub AddWOtoDB()

        'CustomerID = tbCuID.Text
        'VehicleID = tbVehID.Text
        Dim WOStatus As Boolean = True

        Access.AddParam("@cusid", CustomerID)
        Access.AddParam("@vehid", VehicleID)
        Access.AddParam("@WOstatus", WOStatus)
        Access.AddParam("@fname", lblCuFname.Text)
        Access.AddParam("@lname", lblCuLname.Text)
        'Access.AddParam("@company", lbl)
        Access.AddParam("@make", lblMake.Text)
        Access.AddParam("@model", lblModel.Text)
        Access.AddParam("@plate", lblPlate.Text)

        'RUN COMMAND
        Access.ExecQuery("INSERT INTO WorkOrder (CusID, vehID, WOStatus, fname, lname, make, model, plate) " &
                         "VALUES (@cusid,@vehid,@WOstatus, @fname, @lname, @make, @model, @plate); ")


    End Sub

    Private Sub AddInvoicetoDB()

        Dim invoiceConverted As Boolean = False
        Dim WoID As Integer

        ' CustomerID = tbCuID.Text
        'VehicleID = tbVehID.Text

        If FirstCreate = True Then
            AddWOtoDB()
            WoID = GetInsertedRecord("WorkOrder")
        Else
            WoID = Convert.ToInt32(lblWoNo.Text)

        End If

        ToggleWOComplete(WoID)


        'Add Parameters 
        Access.AddParam("@vehID", VehicleID)
        Access.AddParam("@CusID", CustomerID)
        Access.AddParam("@IsInvoiceConverted", invoiceConverted)
        Access.AddParam("@WoID", WoID)


        'Insert Record
        Access.ExecQuery("INSERT INTO Invoice (vehID,cusID,IsInvoiceConverted,WoID) " &
                        "VALUES (@vehID,@CusID,@IsInvoiceConverted,@WoID); ")



    End Sub

    Public Sub ToggleWOComplete(ByVal WoID As Integer)

        'Toggle Work Order as Complete in DB

        Dim WOStatus As Boolean = True

        ''Add Parameters


        Access.AddParam("WOStatus", WOStatus)
        Access.AddParam("WOID", WoID)

        ''Insert Record

        Access.ExecQuery("UPDATE WorkOrder (WOStatus) " &
                         "SET (WOStatus=@WOStatus) " &
                         "WHERE ID=@WOID);")


    End Sub


    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

        MessageBox.Show(VehicleID)

        Dim frm As New InvoiceHistorySelChild

        frm.VehID = VehicleID
        frm.Show()







    End Sub

    Private Sub dgvWorkOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorkOrder.CellContentClick

    End Sub

    Private Sub tpWorkOrder_Click(sender As Object, e As EventArgs) Handles tpWorkOrder.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click



    End Sub
End Class