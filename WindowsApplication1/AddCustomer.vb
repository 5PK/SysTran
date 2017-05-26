Public Class AddCustomer

    Private Access As DBControl

    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AddCustomer()

        'ADD PARAMETERS - ORDER MATTERS
        Access.AddParam("@company", tbCompany.Text)
        Access.AddParam("@fname", tbFname.Text)
        Access.AddParam("@lname", tbLastName.Text)
        Access.AddParam("@city", tbCity.Text)
        Access.AddParam("@province", tbProvince.Text)
        Access.AddParam("@street", tbStreet.Text)
        Access.AddParam("@postal", tbPostalCode.Text)

        'TODO - Add rest of params


        'RUN COMMAND
        Access.ExecQuery("INSERT INTO Customers (company, fname, lname, city, province, street, postal) " &
                         "VALUES (@company, @fname, @lname, @city, @province, @street, @postal); ")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddCustomer()
        Call ExitForm.SaveAndExit(Me)
        MessageBox.Show("Customer Added!")



    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class