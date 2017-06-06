Public Class PaymentSel

    Public InvID As Integer
    Public CusID As Integer
    Public VehID As Integer
    Public WoID As Integer
    Dim InvoiceTotal As Double
    Dim hasgotfocus As Boolean = False
    Dim access As New DBControl

    Dim tbArray() As TextBox
    Dim btnArray() As Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim tbArray2() As TextBox = {tbAR, tbCash, tbCredit, tbCheque, tbDebit}
        tbArray = tbArray2
        Dim btnArray2() As Button = {btnAR, btnCash, btnCredit, btnCheque, btnDebit}
        btnArray = btnArray2

    End Sub

    Private Sub PaymentSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For index As Integer = 1 To 4
            tbArray(index).Text = 0.00
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

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
        tbOutstanding.Text = tbInvTotal.Text - sum

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

    '_________________________________________________________________________________________
    'BUTTON CLICKS

    Private Sub btnAR_click() Handles btnAR.Click

        clearTextBoxes(0)
        tbAR.Text = tbInvTotal.Text

    End Sub

    Private Sub btnCash_click() Handles btnCash.Click

        clearTextBoxes(1)
        tbCash.Text = tbInvTotal.Text

    End Sub

    Private Sub btnCredit_click() Handles btnCredit.Click

        clearTextBoxes(2)
        tbCredit.Text = tbInvTotal.Text

    End Sub

    Private Sub btnCheque_click() Handles btnCheque.Click

        clearTextBoxes(3)
        tbCheque.Text = tbInvTotal.Text

    End Sub

    Private Sub btnDebit_click() Handles btnDebit.Click

        clearTextBoxes(4)
        tbDebit.Text = tbInvTotal.Text

    End Sub


    '______________________________________________________________________________________
    'FOCUS

    Private Sub tbCash_gotFocus() Handles tbCash.GotFocus
        disablebuttons()
        hasgotfocus = True

    End Sub

    Private Sub tbCredit_gotFocus() Handles tbCredit.GotFocus
        disablebuttons()
        hasgotfocus = True
    End Sub

    Private Sub tbCheque_gotFocus() Handles tbCheque.GotFocus
        disablebuttons()
        hasgotfocus = True
    End Sub

    Private Sub tbDebit_gotFocus() Handles tbDebit.GotFocus
        disablebuttons()
        hasgotfocus = True
    End Sub

    '______________________________________________________________________________________
    'TEXT CHANGES

    Private Sub tbCash_edit() Handles tbCash.TextChanged

        If hasgotfocus = True Then

            outstandingAmount()
        End If

    End Sub

    Private Sub tbCredit_edit() Handles tbCredit.TextChanged

        If hasgotfocus = True Then

            outstandingAmount()
        End If

    End Sub

    Private Sub tbCheque_edit() Handles tbCheque.TextChanged

        If hasgotfocus = True Then

            outstandingAmount()
        End If
    End Sub

    Private Sub tbDebit_edit() Handles tbDebit.TextChanged

        If hasgotfocus = True Then

            outstandingAmount()
        End If

    End Sub



    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        MessageBox.Show(InvID)
        MessageBox.Show(CusID)
        MessageBox.Show(VehID)

        If tbOutstanding.Text <> 0 Then
            MessageBox.Show("There is Outstanding owed, load into AR")
        ElseIf tbOutstanding.Text = 0 Then
            AddtoPaymentHistory()
        End If

        CreateInvoice()
        Me.Close()


    End Sub

    Private Sub addtoAR()

        access.AddParam("@InvID", InvID)
        access.AddParam("@CusID", CusID)
        access.AddParam("@VehID", VehID)
        access.AddParam("@Amount", tbOutstanding.Text)
        access.AddParam("@balance", tbOutstanding.Text)

    End Sub

    Private Sub CreateInvoice()

        Dim frm As New Invoice



        frm.lblInvoiceNo.Text = InvID
        frm.lblWoNo.Text = WoID

        frm.vehID = VehID
        frm.cusID = CusID

        FillInvLabels(frm, VehID, CusID)


        'FILL INVOICE DGV


        Dim filepath As String = "WorkOrders\"
        Dim filename As String = WoID

        LoadTxtToDgv(frm.dgvInvoice, filepath, filename, False)
        frm.getRidofZero()
        frm.tbTotal.Text = "$" & tbInvTotal.Text
        frm.save(Convert.ToString(InvID))
        frm.dgvInvoice.Rows(0).Cells(0).Selected = False
        frm.Show()

    End Sub

    Private Sub AddtoPaymentHistory()


        Dim Payment As Double = 0.0
        Dim Amount As Double = InvoiceTotal
        Dim Balance As Double = tbAR.Text


        For index As Integer = 1 To 4
            Payment = Payment + tbArray(index).Text
        Next

        If tbAR.Text > 0 Then
            AddAccReceivableDB(Amount, Balance, Payment)
        End If

        For i As Integer = 1 To 4
            If tbArray(i).Text > 0 Then

                AddToPaymentHistoryDB(i, tbArray(i).Text)
                Payment = Payment + tbArray(i).Text

            End If
        Next






    End Sub

    Private Sub AddAccReceivableDB(ByVal amount As Double, ByVal balance As Double, ByVal payment As Double)

        access.AddParam("@CustomerID", CusID)

        access.AddParam("@VehicleID", VehID)

        access.AddParam("@InvoiceID", InvID)

        access.AddParam("@Amount", amount)

        access.AddParam("@Payment", payment)

        access.AddParam("@Balance", balance)


        access.ExecQuery("INSERT INTO AccReceivable (CusID,VehID,InvID,Amount,Payment,Balance) " &
                         "VALUES (@CustomerID,@VehicleID,@InvoiceID,@Amount,@Payment,@Balance); ")


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

End Class