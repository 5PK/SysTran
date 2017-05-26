
Public Class WrWoInvoice

    Inherits Form

    Dim CustomerID As Integer
    Dim VehicleID As Integer

    Dim FirstCreate As Boolean


    Private Access As New DBControl


    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub WrWoInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub IsWOFirstCreation(ByVal IsWOFC As Boolean)

        FirstCreate = IsWOFC

    End Sub

    Private Sub dgvWorkOrder_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvWorkOrder.CellEndEdit

        For Each row As DataGridViewRow In dgvWorkOrder.Rows

            Dim qty As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colQty").Index).Value)
            Dim PartsEa As Double = Convert.ToDouble(row.Cells(dgvWorkOrder.Columns("colPartsEa").Index).Value)

            row.Cells(dgvWorkOrder.Columns("colTotPart").Index).Value = qty * PartsEa

        Next

    End Sub


    Private Sub PrintWorkRequest(sender As Object, e As EventArgs) Handles btnPrint.Click

        WRWOINVMethods.SaveWRtoDoc()
        WRWOINVMethods.PrintWR()


    End Sub

    Private Sub PreviewWorkRequest(sender As Object, e As EventArgs) Handles btnPreview.Click
        WRWOINVMethods.SaveWRtoDoc()


    End Sub



    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    '_________________________________________________________________________________________________________________
    'SAVE METHODS

    Private Sub SaveAndConvertToInvoice_Click(sender As Object, e As EventArgs) Handles btnSaveAndCnvrtToInvoice.Click

        Save()
        AddInvoicetoDB()


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
            AddWOtoDB2()
            WoID = GetInsertedRecord("WorkOrder")
            FirstCreate = False
        Else
            WoID = Convert.ToInt32(tbWOno)

        End If

        WRWOINVMethods.CreateWRTextFile(tbWorkRequests, WoID)
        WRWOINVMethods.CreateWOTextFile(dgvWorkOrder, WoID)

    End Sub



    '_________________________________________________________________________________________________________________
    'DATABASE METHODS

    Private Sub AddWOtoDB2()

        CustomerID = tbCuID.Text
        VehicleID = tbVehID.Text
        Dim WOStatus As Boolean = False

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
        Access.ExecQuery("INSERT INTO WorkOrder (vehID, CusID, WOStatus, fname, lname, make, model, plate) " &
                         "VALUES (@cusid,@vehid,@WOstatus, @fname, @lname, @make, @model, @plate); ")


    End Sub

    Private Sub AddInvoicetoDB()


        Dim WoID As Integer
        CustomerID = tbCuID.Text
        VehicleID = tbVehID.Text

        If FirstCreate = True Then
            AddWOtoDB2()
            WoID = GetInsertedRecord("WorkOrder")
        Else
            WoID = Convert.ToInt32(tbWOno)

        End If

        ToggleWOComplete(WoID)


        'Add Parameters 
        Access.AddParam("vehID", CustomerID)
        Access.AddParam("CusID", VehicleID)


        'Insert Record
        Access.ExecQuery("INSERT INTO InvoiceNo (vehID,cusID) " &
                        "VALUES (@vehID,@CusID); ")

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

End Class