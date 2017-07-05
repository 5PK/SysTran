Imports System.Data.OleDb

Public Class AdminSettings

    Dim con As New OleDbConnection
    Dim access As DBControl

    Private Sub AdminSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTextBoxes()
    End Sub

    Private Sub loadTextBoxes()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim cmdStr = "SELECT Username, Password, LabourRate, TaxRate, Fname, Lname FROM Administrator WHERE ID = 1"

        Dim cmd As OleDbCommand = New OleDbCommand(cmdStr, con)

        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read
            tbUsername.Text = rdr("Username").ToString
            tbPassword.Text = rdr("Password").ToString
            tbLabour.Text = rdr("LabourRate").ToString
            tbHST.Text = rdr("TaxRate").ToString
            tbFname.Text = rdr("Fname").ToString
            tbLname.Text = rdr("Lname").ToString


        End While

        rdr.Close()
        con.Close()

    End Sub


    Private Sub tbFname_TextChanged(sender As Object, e As EventArgs) Handles tbFname.GotFocus
        btnSave.Enabled = True
    End Sub

    Private Sub tbLname_TextChanged(sender As Object, e As EventArgs) Handles tbLname.GotFocus
        btnSave.Enabled = True
    End Sub

    Private Sub tbLabour_TextChanged(sender As Object, e As EventArgs) Handles tbLabour.GotFocus
        btnSave.Enabled = True
    End Sub

    Private Sub tbHST_TextChanged(sender As Object, e As EventArgs) Handles tbHST.GotFocus
        btnSave.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If btnSave.Enabled = True Then
            Dim result As Integer = MessageBox.Show("You have not save changes, would you like to save before exiting", "caption", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then
                Me.Close()
            ElseIf result = DialogResult.Yes Then
                save()
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()



    End Sub

    Private Sub save()
        access.AddParam("@Username", tbUsername.Text)
        access.AddParam("@Password", tbPassword.Text)
        access.AddParam("@fname", tbFname.Text)
        access.AddParam("@lname", tbLname.Text)
        access.AddParam("@Labour", tbLabour.Text)
        access.AddParam("@tax", tbHST.Text)

        access.ExecQuery("UPDATE Administrator " &
                         "SET Username=@Username, Password=@Password, Fname=@fname, Lname=@lname, LabourRate=@Labour, TaxRate=@tax " &
                         "WHERE ID = 1);")
    End Sub

End Class