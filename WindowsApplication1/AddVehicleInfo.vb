Public Class AddVehicleInfo

    Private Access As New DBControl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AddVehicleInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddVehicle()

        'ADD PARAMETERS - ORDER MATTERS
        Access.AddParam("@plate", tbPlate.Text)
        Access.AddParam("@odometer", tbOdometer.Text)
        Access.AddParam("@vin", tbVin.Text)
        Access.AddParam("@year", tbYear.Text)
        Access.AddParam("@make", tbMake.Text)
        Access.AddParam("@model", tbModel.Text)
        Access.AddParam("@bodytype", tbBodyType.Text)
        Access.AddParam("@engine", tbEngine.Text)
        Access.AddParam("@trans", tbTrans.Text)
        Access.AddParam("@ac", tbAC.Text)
        Access.AddParam("@unitnum", tbUnitNum.Text)
        Access.AddParam("@cusid", tbCustomerID.Text)

        'RUN COMMAND
        Access.ExecQuery("INSERT INTO CuVehicles (plate, odometer, vin, year, [make], model, doors, engsize, transmission, ac, unitno, cusid) " &
                         "VALUES (@plate,@odometer,@vin,@year,@make,@model,@bodytype,@engine,@trans,@ac,@unitnum,@cusid); ")



    End Sub

    Private Sub AddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        AddVehicle()
        MessageBox.Show("Vehicle Added! :D")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class