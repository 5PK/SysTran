Public Class PaymentSel

#Region "VARIABLES"
    Dim InvID As Integer = 0
    Dim CusID As Integer
    Dim VehID As Integer
    Dim WoID As Integer
    Dim od As Integer
    Dim InvoiceTotal As Double

    Dim hasgotfocus As Boolean = False
    Dim tclear As Boolean = False

    Dim access As New DBControl

    Dim tbArray() As TextBox
    Dim btnArray() As Button


    Dim tx As Double
    Dim subtot As Double

    Dim invoiceList As ArrayList

#End Region

    Public Sub New(tax As Double, subtotal As Double, customerID As Integer, vehicleID As Integer, workID As Integer, odometer As Integer)

        InitializeComponent()

        CusID = customerID
        VehID = vehicleID
        WoID = workID
        od = odometer
        Dim tbArray2() As TextBox = {tbAR, tbCash, tbCredit, tbCheque, tbDebit}
        tbArray = tbArray2
        Dim btnArray2() As Button = {btnAR, btnCash, btnCredit, btnCheque, btnDebit}
        btnArray = btnArray2



        tx = tax
        subtot = subtotal

        tbInvTotal.Text = tax + subtotal
        tbChange.Text = tax + subtotal

    End Sub

    Public Sub New(tax As Double, subtotal As Double, customerID As Integer, vehicleID As Integer, workID As Integer, odometer As Integer, InvoiceID As Integer)

        InitializeComponent()

        CusID = customerID
        VehID = vehicleID
        WoID = workID
        od = odometer
        Dim tbArray2() As TextBox = {tbAR, tbCash, tbCredit, tbCheque, tbDebit}
        tbArray = tbArray2
        Dim btnArray2() As Button = {btnAR, btnCash, btnCredit, btnCheque, btnDebit}
        btnArray = btnArray2

        tx = tax
        subtot = subtotal

        tbInvTotal.Text = tax + subtotal
        tbChange.Text = tax + subtotal

        InvID = InvoiceID

    End Sub

    Private Sub PaymentSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

#Region "OTHER METHODS"

    Private Sub CreateInvoice()

        Dim frm As New Invoice(VehID, CusID, InvID, WoID)

        FillInvLabels(frm, VehID, CusID, InvID, WoID, System.DateTime.Today)


        'FILL INVOICE DGV
        Dim filepath As String = "WorkOrders\"
        Dim filename As String = WoID

        LoadTxtToDgv(frm.dgvInvoice, filepath, filename, False)
        frm.getRidofZero()
        frm.tbSubTot.Text = subtot
        frm.tbTotal.Text = "$" & tbInvTotal.Text
        frm.tbTax.Text = "$" & tx
        frm.save(Convert.ToString(InvID))
        frm.dgvInvoice.Rows(0).Cells(0).Selected = False
        frm.Show()

    End Sub

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
            tbAR.Text = tbInvTotal.Text - tbTotalPaid.Text
        End If


        tbChange.Text = tbInvTotal.Text - sumTextBox()



    End Sub

    Private Sub clearTextBoxes(ByVal index As Integer)

        For i As Integer = 0 To 4
            If i = index Then
                tbArray(i).Text = InvoiceTotal
            Else
                tbArray(i).Text = 0.00

            End If
        Next

    End Sub

    Private Sub disablebuttons()

        For index As Integer = 0 To 4

            btnArray(index).Enabled = False

        Next

    End Sub

    Private Sub UserEditCalc()

        Dim Sum As Integer

        For i As Integer = 1 To 4
            Sum = Sum + tbArray(i).Text
        Next

        tbTotalPaid.Text = Sum
        tbAR.Text = tbInvTotal.Text - Sum
        tbChange.Text = tbInvTotal.Text - tbTotalPaid.Text

    End Sub

    Private Sub TrueClear(ByRef cleared)

        If cleared = False Then
            cleared = True
            For i As Integer = 0 To 4
                tbArray(i).Text = 0.0
            Next
        End If

    End Sub
#End Region

#Region " PAYMENT BUTTON CLICKS "


    Private Sub btnAR_click() Handles btnAR.Click

        clearTextBoxes(0)
        tbAR.Text = tbInvTotal.Text
        outstandingAmount()

    End Sub

    Private Sub btnCash_click() Handles btnCash.Click

        clearTextBoxes(1)
        tbCash.Text = tbInvTotal.Text
        outstandingAmount()
    End Sub

    Private Sub btnCredit_click() Handles btnCredit.Click

        clearTextBoxes(2)
        tbCredit.Text = tbInvTotal.Text
        outstandingAmount()

    End Sub

    Private Sub btnCheque_click() Handles btnCheque.Click

        clearTextBoxes(3)
        tbCheque.Text = tbInvTotal.Text
        outstandingAmount()

    End Sub

    Private Sub btnDebit_click() Handles btnDebit.Click

        clearTextBoxes(4)
        tbDebit.Text = tbInvTotal.Text
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

#Region "OK BUTTON"

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If tbTotalPaid.Text = 0 Then

            MessageBox.Show("Click a Payment type, or enter a custom Payment")


        ElseIf tbChange.Text >= 0 Then

            AddtoPaymentHistory()

            If InvID = 0 Then
                AddInvoicetoDB(tbInvTotal.Text, tbAR.Text)
                InvID = GetInsertedRecord("Invoice")
                CreateInvoice()
                Me.Close()
            ElseIf InvID > 0 Then
                UpdateInvoiceDB(tbInvTotal.Text, tbAR.Text, InvID)
                CreateInvoice()
                Me.Close()

            End If
        End If

    End Sub

#End Region

#Region "DATABASE METHODS"

    Private Sub UpdateInvoiceDB(ByVal outstanding As Double, ByVal totalowed As Double, ByVal invoiceID As Integer)

        Dim invoiceConverted As Boolean = False

        'ADD PARAMETERS - ORDER MATTERS

        access.AddParam("@IsInvoiceConverted", invoiceConverted)
        access.AddParam("@date", System.DateTime.Today)
        access.AddParam("@balance", outstanding)

        access.AddParam("@total", totalowed)
        access.AddParam("@od", od)
        access.AddParam("@ID", invoiceID)

        'RUN COMMAND

        access.ExecQuery("UPDATE Invoice " &
                         "SET company=@IsInvoiceConverted, Dte=@date, Balance=@balance, InvTotal=@total, odometer=@od " &
                         "WHERE ID=@cusid;")

    End Sub

    Private Sub AddInvoicetoDB(ByVal outstanding As Double, ByVal totalowed As Double)

        Dim invoiceConverted As Boolean = False
        Dim WorkOrderID As Integer = WoID

        'Add Parameters 
        access.AddParam("@vehID", VehID)
        access.AddParam("@CusID", CusID)
        access.AddParam("@IsInvoiceConverted", invoiceConverted)
        access.AddParam("@WoID", WoID)
        access.AddParam("@date", System.DateTime.Today)
        access.AddParam("@balance", outstanding)

        access.AddParam("@total", totalowed)
        access.AddParam("@od", od)

        'Insert Record
        access.ExecQuery("INSERT INTO Invoice (vehID,cusID,isInvoiceConverted,WoID,Dte,Balance,InvTotal,odometer) " &
                        "VALUES (@vehID,@CusID,@IsInvoiceConverted,@WoID,@date,@balance,@total,@od); ")

    End Sub

    Private Sub AddtoPaymentHistory()

        Dim Payment As Double = 0.0
        Dim Amount As Double = InvoiceTotal
        Dim Balance As Double = tbAR.Text

        For index As Integer = 1 To 4
            Payment = Payment + tbArray(index).Text
        Next

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
                    AddToPaymentHistoryDB(i, tbArray(i).Text, chequeNo)

                Else

                    AddToPaymentHistoryDB(i, tbArray(i).Text)

                End If
            End If
        Next
    End Sub

    Private Sub AddToPaymentHistoryDB(ByRef i As Integer, ByRef AmountPaid As Double)

        access.AddParam("@CustomerID", CusID)
        access.AddParam("@AmountPaid", AmountPaid)
        access.AddParam("@VehicleID", VehID)
        access.AddParam("@InvoiceID", InvID)

        Select Case i
            Case 1
                access.AddParam("@PaymentType", "Cash")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 2
                access.AddParam("@PaymentType", "Credit")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 3
                access.AddParam("@PaymentType", "Cheque")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 4
                access.AddParam("@PaymentType", "Debit")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")



        End Select

    End Sub

    Private Sub AddToPaymentHistoryDB(ByRef i As Integer, ByRef AmountPaid As Double, ByVal chequeNo As Integer)

        access.AddParam("@CustomerID", CusID)
        access.AddParam("@AmountPaid", AmountPaid)
        access.AddParam("@VehicleID", VehID)
        access.AddParam("@InvoiceID", InvID)





        Select Case i
            Case 1
                access.AddParam("@PaymentType", "Cash")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 2
                access.AddParam("@PaymentType", "Credit")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")
            Case 3


                access.AddParam("@PaymentType", "Cheque")
                access.AddParam("@Cheque", chequeNo)
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType,ChequeNo) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType,@chequNo); ")
            Case 4
                access.AddParam("@PaymentType", "Debit")
                access.ExecQuery("INSERT INTO PaymentHistory (CustomerID,AmountPaid,VehicleID,InvNo,PaymentType) " &
                                 "VALUES (@CustomerID,@AmountPaid,@VehicleID,@InvoiceID,@PaymentType); ")



        End Select

    End Sub

    #End Region

End Class