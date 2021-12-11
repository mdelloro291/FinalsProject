Imports FinalsApplication.TransactionsForm

Public Module TransactionModule
    Dim table As New DataTable
    Dim tblProductList As DataGridView
    Dim tblCart As DataGridView
    Function CreateCart() As DataTable
        ' Create new DataTable instance.


        ' Create 3 typed columns in the DataTable.
        table.Columns.Add("ProductID", GetType(Integer))
        table.Columns.Add("ProductName", GetType(String))
        table.Columns.Add("Quantity", GetType(Integer))
        table.Columns.Add("Price", GetType(Decimal))
        table.Columns.Add("Total", GetType(Decimal))
        Return table
    End Function
    Public Sub LoadDataGrids(tblProductsView As DataGridView, tblCartView As DataGridView)
        tblProductList = tblProductsView
        tblCart = tblCartView
    End Sub
    Function LoadCart() As DataTable
        Return table
    End Function
    Public Sub UpdateCart(cart As DataTable)
        tblCart.DataSource = cart
    End Sub
    Public Sub AddToCart(cart As DataTable)
        Dim row As DataRow = cart.NewRow
        Dim qty As Integer = TransactionsForm.getQty()
        Dim price As Decimal = tblProductList.SelectedRows(0).Cells(3).Value
        Dim id As Integer = tblProductList.SelectedRows(0).Cells(0).Value
        Dim name As String = tblProductList.SelectedRows(0).Cells(1).Value
        If (checkInCart(id) = False) Then
            row("ProductID") = id
            row("ProductName") = name
            row("Quantity") = qty
            row("Price") = price
            row("Total") = qty * price
            cart.Rows.Add(row)
        Else
            For Each existingRow As DataGridViewRow In tblCart.Rows
                If existingRow.Cells(0).Value = id Then
                    existingRow.Cells(2).Value += qty
                    existingRow.Cells(4).Value = existingRow.Cells(2).Value * existingRow.Cells(3).Value
                End If
            Next
        End If

        'Update Quantity and Decrease Button
        TransactionsForm.resetQuantity()

    End Sub
    Function checkInCart(newID As Integer) As Boolean
        For Each row As DataGridViewRow In tblCart.Rows
            If row.Cells(0).Value = newID Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function
End Module
