
Imports FinalsApplication.TransactionModule


Public Class TransactionsForm
    Dim quantity As Integer = 0
    Dim cart As DataTable = CreateCart()

    Private Sub TransactionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectFinalsDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.ProjectFinalsDataSet.tblProduct)
        'TODO: This line of code loads data into the 'ProjectFinalsDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.ProjectFinalsDataSet.tblProduct)

        resetQuantity()
        toggleBtns(False)
        LoadDataGrids(tblProductList, tblCart)
    End Sub
    ' Control Functions
    Private Sub TransactionWindowToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TblProductTableAdapter.TransactionWindow(Me.ProjectFinalsDataSet.tblProduct)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TransactionWindowToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.TblProductTableAdapter.TransactionWindow(Me.ProjectFinalsDataSet.tblProduct)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TransactionWindowToolStripButton1_Click_1(sender As Object, e As EventArgs)
        Try
            Me.TblProductTableAdapter.TransactionWindow(Me.ProjectFinalsDataSet.tblProduct)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cart = LoadCart()

        AddToCart(cart)
        UpdateCart(cart)
        tblCart.ClearSelection()
        tblProductList.ClearSelection()
        toggleBtns(False)
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        quantity = Convert.ToInt32(txtQuantity.Text)
        quantity += 1
        txtQuantity.Text = quantity
        isMinQty()

    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        quantity = Convert.ToInt32(txtQuantity.Text)
        quantity -= 1

        If (quantity > 0) Then
            txtQuantity.Text = quantity
        End If
        isMinQty()
    End Sub

    Private Sub tblProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProductList.CellClick
        tblCart.ClearSelection()
        tblCart.Update()
        toggleBtns(False)
    End Sub

    Private Sub tblCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblCart.CellClick
        tblProductList.ClearSelection()
        tblProductList.Update()
        toggleBtns(True)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tblCart.Rows.RemoveAt(tblCart.SelectedRows(0).Index())

        If tblCart.RowCount = 0 Then
            toggleBtns(False)
        Else
            toggleBtns(True)
        End If
        isMinQty()
    End Sub

    Private Sub btnUpdateQty_Click(sender As Object, e As EventArgs) Handles btnUpdateQty.Click
        tblCart.SelectedRows(0).Cells(2).Value = getQty()
        tblCart.SelectedRows(0).Cells(4).Value = tblCart.SelectedRows(0).Cells(2).Value * tblCart.SelectedRows(0).Cells(3).Value
        isMinQty()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click

    End Sub

    'End Control Functions

    ' Operation Functions
    Public Sub isMinQty()
        quantity = Convert.ToInt32(txtQuantity.Text)
        If (quantity > 1) Then
            btnDecrease.Enabled = True
        Else
            btnDecrease.Enabled = False
        End If
    End Sub
    Public Sub toggleBtns(toggle As Boolean)
        btnDelete.Enabled = toggle
        btnUpdateQty.Enabled = toggle
        If (tblProductList.SelectedRows.Count = 0 And tblCart.SelectedRows.Count = 0) Then
            btnAdd.Enabled = toggle
        Else
            btnAdd.Enabled = Not toggle
        End If
        If (tblCart.RowCount = 0) Then
            btnCheckOut.Enabled = False
        Else
            btnCheckOut.Enabled = True
        End If
    End Sub
    Public Sub resetQuantity()
        txtQuantity.Text = 1
        isMinQty()
    End Sub
    Public Function getQty() As Integer
        Dim qty As Integer = Convert.ToInt32(txtQuantity.Text)
        Return qty
    End Function










    'End Operations
End Class