Imports System.Data.OleDb


Public Class UpdateCustomerInfo

    Private Access As New DBControl





    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        UpdateRecord()
        MessageBox.Show("CUSTOMER UPDATED")

        Me.Close()



    End Sub


    Private Sub UpdateRecord()

        'ADD PARAMETERS - ORDER MATTERS

        Access.AddParam("@company", tbCompany.Text)
        Access.AddParam("@fname", tbFname.Text)
        Access.AddParam("@lname", tbLname.Text)
        Access.AddParam("@cusid", tbtest.Text)

        'RUN COMMAND

        Access.ExecQuery("UPDATE Customers " &
                         "SET company=@company, fname=@fname, lname=@lname " &
                         "WHERE ID=@cusid;")


    End Sub

    Private Sub UpdateCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

End Class