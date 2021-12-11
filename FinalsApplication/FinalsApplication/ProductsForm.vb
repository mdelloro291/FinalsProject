Public Class ProductsForm
    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectFinalsDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.ProjectFinalsDataSet.tblProduct)

    End Sub

    Private Sub ChangeWindows_Click(sender As Object, e As EventArgs) Handles ChangeWindows.Click
        TransactionsForm.Show()
        Me.Hide()
    End Sub
End Class
