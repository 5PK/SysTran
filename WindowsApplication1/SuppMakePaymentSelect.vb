Imports System.Data.OleDb

Public Class SuppMakePaymentSelect


    Dim InvoiceList As ArrayList
    Dim InvoiceBalances As ArrayList
    Dim PayAmount As Double
    Dim tbArray() As TextBox
    Dim SupplierID As Integer

    Dim dte As Date

    Dim con As New OleDbConnection


    Public Sub New(ByVal Invoices As ArrayList, ByVal InvoicesBalances As ArrayList, payment As Double, SuppID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        InvoiceList = Invoices
        InvoicesBalances = InvoicesBalances
        PayAmount = payment
        SupplierID = SuppID

        dte = Date.Today

        Dim tbArray2() As TextBox = {tbAR, tbCash, tbCredit, tbCheque, tbDebit}
        tbArray = tbArray2

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AccountsMakePaymentSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "ACCPAYABLE"

    Private Sub UpdateAccPayable(ByVal InvLists As ArrayList, ByVal BalanceList As ArrayList, ByVal payment As Double)

        Dim payments As Double

        For i As Integer = 0 To InvLists.Count

            If BalanceList(i) <= payments Then
                payments = payments - BalanceList(i)
                UpdateAccPayInvoice(InvLists(i), BalanceList(i), BalanceList(i))

            ElseIf BalanceList(i) > payments Then
                Dim newBalance As Double = BalanceList(i) - payments

                UpdateAccPayInvoice(InvLists(i), newBalance, payments)
            End If


        Next

    End Sub

    Private Sub UpdateAccPayInvoice(ByVal InvoiceID As String, ByVal newBalance As Double, ByVal newPayment As Double)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSAuto1.accdb"
        con.Open()

        Dim strCMD As String = "SELECT Payment FROM AccPayable WHERE InvoiceID = " & InvoiceID & " "

        Dim cmd As OleDbCommand = New OleDbCommand(strCMD, con)

        'READ DATA INTO NEXT FORM TEXTBOXES
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()
        Dim oldPayment As Double

        While rdr.Read
            oldPayment = rdr("Payment")
        End While

        Dim updatePayment As Double = oldPayment + newPayment

        Access.AddParam("@balance", newBalance)
        Access.AddParam("@payment", updatePayment)
        Access.AddParam("@InvoiceID", InvoiceID)


        Dim cmdstr As String = "UPDATE AccPayable " &
                               "SET Balance=@balance, Payment=@payment " &
                               "WHERE InvoiceID=@InvoiceID"

        Access.ExecQuery(cmdstr)

        con.Close()
    End Sub

    Private Sub AddAccPayablePaymentHistory()

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
                    Dim frm As New ChequePrint(chequeNo, dte, SupplierID, PayAmount)
                    frm.Show()

                    AddAccPayableHistoryDB(i, tbArray(i).Text, chequeNo)



                Else

                    AddAccPayableHistoryDB(i, tbArray(i).Text)

                End If
            End If
        Next

    End Sub
#End Region


#Region "Database Methods"
    Private Sub AddAccPayableHistoryDB(ByVal i As Integer, ByVal AmountPaid As Double)

        Access.AddParam("@SuppID", SupplierID)
        Access.AddParam("@AmountPaid", AmountPaid)



        Select Case i
            Case 1
                Access.AddParam("@PaymentType", "Cash")
                Access.ExecQuery("INSERT INTO AccPaymentHistory (SuppID,PaymentAmount,PaymentType) " &
                                 "VALUES (@SuppID,@AmountPaid,@PaymentType); ")
            Case 2
                Access.AddParam("@PaymentType", "Credit")
                Access.ExecQuery("INSERT INTO AccPaymentHistory (SuppID,PaymentAmount,PaymentType) " &
                                 "VALUES (@SuppID,@AmountPaid,@PaymentType); ")

            Case 4
                Access.AddParam("@PaymentType", "Debit")
                Access.ExecQuery("INSERT INTO AccPaymentHistory (SuppID,PaymentAmount,PaymentType) " &
                                 "VALUES (@SuppID,@AmountPaid,@PaymentType); ")

        End Select

    End Sub

    Private Sub AddAccPayableHistoryDB(ByVal i As Integer, ByVal AmountPaid As Double, ByVal ChequeNo As Integer)
        'Print CHEQUE
        Access.AddParam("@SuppID", SupplierID)
        Access.AddParam("@AmountPaid", AmountPaid)

        Access.AddParam("@PaymentType", "Cheque")
        Access.AddParam("@Cheque", ChequeNo)
        Access.ExecQuery("INSERT INTO PaymentHistory (SuppID,PaymentAmount,PaymentType,ChequeNo) " &
                                 "VALUES (@SuppID,@AmountPaid,@PaymentType,@Cheque); ")


    End Sub


#End Region

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        UpdateAccPayable(InvoiceList, InvoiceBalances, PayAmount)
        AddAccPayablePaymentHistory()

        Me.Close()


    End Sub
End Class