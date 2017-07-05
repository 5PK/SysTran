Imports System.Data.OleDb

Public Class AccRecPaymentSel

    Dim con As New OleDbConnection

    Dim invoiceIDs As ArrayList
    Dim payments As ArrayList

    Dim totalInvoiceBalances As Double = 0.0
    Dim totalPaid As Double = 0.0

    Dim tbArray() As TextBox
    Dim btnArray() As Button

    Dim hasgotfocus As Boolean = False
    Dim tclear As Boolean = False
    Private Access As New DBControl

    Public Sub New(invIDs As ArrayList, pays As ArrayList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tbArray = {tbAR, tbCash, tbCredit, tbCheque, tbDebit}
        btnArray = {btnAR, btnCash, btnCredit, btnCheque, btnDebit}

        Dim num As Double
        For Each num In pays
            totalInvoiceBalances = totalInvoiceBalances + num
        Next
        tbTotalInvBalances.Text = totalInvoiceBalances

        MessageBox.Show(totalInvoiceBalances)

        Dim ID As Integer
        For Each ID In invIDs
            MessageBox.Show(ID)
        Next

        invoiceIDs = invIDs
        payments = pays


    End Sub

    Private Sub AccRecPaymentSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub getCusVehID(ByRef CusID As Integer, ByRef VehID As Integer, ByRef InvoiceID As Integer)



        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim strCMD As String = "SELECT * FROM Invoice WHERE ID = " & InvoiceID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCMD, con)
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read
            CusID = rdr("cusID").ToString
            VehID = rdr("vehID").ToString
        End While

        rdr.Close()
        con.Close()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        totalPaid = tbTotalPaid.Text

        If tbTotalPaid.Text = 0 Then

            MessageBox.Show("Click a Payment type, or enter a custom Payment")
        ElseIf tbChange.Text >= 0 Then

            For i As Integer = 0 To invoiceIDs.Count - 1
                Dim InvoiceID = invoiceIDs(i)
                Dim CusID As Integer = 0
                Dim VehID As Integer = 0
                Dim balance As Double = 0

                If totalPaid - payments(i) >= 0 Then

                    getCusVehID(CusID, VehID, InvoiceID)

                    UpdateInvoiceDB(payments(i), balance, InvoiceID)

                    'add hist
                    AddToPaymentHistory(payments(i), InvoiceID, CusID, VehID)

                    totalPaid = totalPaid - payments(i)
                ElseIf totalPaid - payments(i) < 0 Then
                    balance = payments(i) - totalPaid

                    getCusVehID(CusID, VehID, InvoiceID)
                    UpdateInvoiceDB(totalPaid, balance, InvoiceID)

                    'add hist
                    AddToPaymentHistory(totalPaid, InvoiceID, CusID, VehID)

                End If
            Next
        End If


        Dim frm As New AccReceivable
        frm.Show()
        Me.Close()

    End Sub

#Region "DB METHODS"

    Private Sub UpdateInvoiceDB(ByVal payment As Double, ByVal balance As Double, ByVal invoiceID As Integer)

        'ADD PARAMETERS - ORDER MATTERS

        Access.AddParam("@payment", payment)
        Access.AddParam("@balance", balance)
        Access.AddParam("@ID", invoiceID)

        'RUN COMMAND

        Access.ExecQuery("UPDATE Invoice " &
                         "SET Payment=@payment, Balance=@balance " &
                         "WHERE ID=@ID;")

    End Sub


    Private Sub AddToPaymentHistory(ByVal payAmount As Double, ByVal invoiceID As Integer, ByVal CusID As Integer, ByVal VehID As Integer)

        For i As Integer = 1 To 4
            If tbArray(i).Text > 0 Then
                If i = 3 Then
                    Dim chequeNo As Integer
                    Dim msg, title, defaultValue As String
                    Dim chequeMsg As Object

                    msg = "Cheque Number"
                    title = "Cheque Number Input"
                    defaultValue = "0"

                    chequeMsg = InputBox(msg, title, defaultValue)

                    chequeNo = chequeMsg
                    AddToPaymentHistoryDB(i, tbArray(i).Text, chequeNo, invoiceID, CusID, VehID)

                Else

                    AddToPaymentHistoryDB(i, tbArray(i).Text, invoiceID, CusID, VehID)

                End If
            End If
        Next

    End Sub


    Private Sub AddToPaymentHistoryDB(ByRef i As Integer, ByRef AmountPaid As Double, ByVal invoiceID As Integer, ByVal CusID As Integer, ByVal VehID As Integer)

        Access.AddParam("@CustomerID", CusID)
        Access.AddParam("@AmountPaid", AmountPaid)
        Access.AddParam("@VehicleID", VehID)
        Access.AddParam("@InvoiceID", invoiceID)

        Select Case i
            Case 1
                Access.AddParam("@PaymentType", "Cash")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 2
                Access.AddParam("@PaymentType", "Credit")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 3
                Access.AddParam("@PaymentType", "Cheque")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 4
                Access.AddParam("@PaymentType", "Debit")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")



        End Select

    End Sub

    Private Sub AddToPaymentHistoryDB(ByRef i As Integer, ByRef AmountPaid As Double, ByVal chequeNo As Integer, ByVal invoiceID As Integer, ByVal CusID As Integer, ByVal VehID As Integer)

        Access.AddParam("@CustomerID", CusID)
        Access.AddParam("@AmountPaid", AmountPaid)
        Access.AddParam("@VehicleID", VehID)
        Access.AddParam("@InvoiceID", invoiceID)


        Select Case i
            Case 1
                Access.AddParam("@PaymentType", "Cash")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 2
                Access.AddParam("@PaymentType", "Credit")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 3


                Access.AddParam("@PaymentType", "Cheque")
                Access.AddParam("@Cheque", chequeNo)
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType,ChequeNo) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType,@chequNo); ")
            Case 4
                Access.AddParam("@PaymentType", "Debit")
                Access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")



        End Select

    End Sub
#End Region

    Private Function sumTextBox() As Double

        Dim sum As Double = 0

        For index As Integer = 0 To 4
            sum = sum + tbArray(index).Text
        Next

        Return sum

    End Function

    Private Sub outstandingAmount()

        Dim sum As Double = sumTextBox()

        tbTotalPaid.Text = sum

        If tbAR.Text = 0 Then
            tbAR.Text = tbTotalInvBalances.Text - tbTotalPaid.Text
        End If


        tbChange.Text = tbTotalInvBalances.Text - sumTextBox()



    End Sub

    Private Sub disablebuttons()

        For index As Integer = 0 To 4

            btnArray(index).Enabled = False

        Next

    End Sub

    Private Sub TrueClear(ByRef cleared)

        If cleared = False Then
            cleared = True
            For i As Integer = 0 To 4
                tbArray(i).Text = 0.0
            Next
        End If

    End Sub

    Private Sub UserEditCalc()

        Dim Sum As Integer

        For i As Integer = 1 To 4
            Sum = Sum + tbArray(i).Text
        Next

        tbTotalPaid.Text = Sum
        tbAR.Text = tbTotalInvBalances.Text - Sum
        tbChange.Text = tbTotalInvBalances.Text - tbTotalPaid.Text

    End Sub

#Region " PAYMENT BUTTON CLICKS "

    Private Sub paymentTypeSel(ByVal index As Integer)

        For i As Integer = 0 To 4
            If i = index Then
                tbArray(i).Text = totalInvoiceBalances
            Else
                tbArray(i).Text = 0.00

            End If
        Next

    End Sub

    Private Sub btnAR_click() Handles btnAR.Click

        paymentTypeSel(0)
        tbAR.Text = tbTotalInvBalances.Text
        outstandingAmount()

    End Sub

    Private Sub btnCash_click() Handles btnCash.Click

        paymentTypeSel(1)
        tbCash.Text = tbTotalInvBalances.Text
        outstandingAmount()
    End Sub

    Private Sub btnCredit_click() Handles btnCredit.Click

        paymentTypeSel(2)
        tbCredit.Text = tbTotalInvBalances.Text
        outstandingAmount()

    End Sub

    Private Sub btnCheque_click() Handles btnCheque.Click

        paymentTypeSel(3)
        tbCheque.Text = tbTotalInvBalances.Text
        outstandingAmount()

    End Sub

    Private Sub btnDebit_click() Handles btnDebit.Click

        paymentTypeSel(4)
        tbDebit.Text = tbTotalInvBalances.Text
        outstandingAmount()

    End Sub

#End Region


#Region " GOT FOCUS "

    Private Sub tbAR_gotFocus() Handles tbAR.GotFocus
        disablebuttons()
        TrueClear(tclear)
        hasgotfocus = True

    End Sub

    Private Sub tbCash_gotFocus() Handles tbCash.GotFocus
        disablebuttons()
        TrueClear(tclear)
        hasgotfocus = True

    End Sub

    Private Sub tbCredit_gotFocus() Handles tbCredit.GotFocus
        disablebuttons()
        TrueClear(tclear)
        hasgotfocus = True
    End Sub

    Private Sub tbCheque_gotFocus() Handles tbCheque.GotFocus
        disablebuttons()
        TrueClear(tclear)
        hasgotfocus = True
    End Sub

    Private Sub tbDebit_gotFocus() Handles tbDebit.GotFocus
        disablebuttons()
        TrueClear(tclear)
        hasgotfocus = True
    End Sub

#End Region

#Region " TEXT CHANGES "

    Private Sub tbAR_edit() Handles tbAR.TextChanged
        If hasgotfocus = True Then

            UserEditCalc()
        End If
    End Sub

    Private Sub tbCash_edit() Handles tbCash.TextChanged

        If hasgotfocus = True Then
            'tbCash.Clear()
            UserEditCalc()
        End If

    End Sub

    Private Sub tbCredit_edit() Handles tbCredit.TextChanged

        If hasgotfocus = True Then
            ' tbCredit.Clear()
            UserEditCalc()
        End If

    End Sub

    Private Sub tbCheque_edit() Handles tbCheque.TextChanged

        If hasgotfocus = True Then
            '   tbCheque.Clear()
            UserEditCalc()
        End If
    End Sub

    Private Sub tbDebit_edit() Handles tbDebit.TextChanged

        If hasgotfocus = True Then
            '     tbDebit.Clear()
            UserEditCalc()
        End If

    End Sub

#End Region
End Class