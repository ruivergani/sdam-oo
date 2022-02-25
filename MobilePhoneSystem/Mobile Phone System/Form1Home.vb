Public Class Form1Home
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCustomerDetails_Click(sender As Object, e As EventArgs) Handles btnCustomerDetails.Click
        Me.Hide()
        CustomerDetails.Show()
    End Sub

    Private Sub btnStatementDetails_Click(sender As Object, e As EventArgs) Handles btnStatementDetails.Click
        Me.Hide()
        StatementDetails.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class