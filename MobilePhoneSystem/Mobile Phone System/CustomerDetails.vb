Imports System.IO
Public Class CustomerDetails


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1Home.Show()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

        Dim r As customer

        r.customername = StrConv(txtName.Text, vbProperCase)
        r.address = StrConv(txtAddress.Text, vbProperCase)
        r.postcode = StrConv(txtPostCode.Text, vbUpperCase)
        r.mobilenumber = txtMobileNo.Text

        mycustomerlist.Add(r)

        For Each x As ListViewItem In ListView1.Items
            x.Remove()
        Next


        For Each x As customer In mycustomerlist
            ListView1.Items.Add(New ListViewItem({x.customername, x.address, x.postcode, x.mobilenumber}))
        Next


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim i As Integer

        For Each x As ListViewItem In ListView1.CheckedItems
            i = x.Index
            mycustomerlist.RemoveAt(i)
            x.Remove()
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim text As String
        text = ""
        'overwrite file with empty data
        'If Not File.Exists("data.txt") Then File.CreateText("data.txt")
        My.Computer.FileSystem.WriteAllText("data.txt", "", False)


        '  Using sw As New StreamWriter("data.txt")
        For Each x As customer In mycustomerlist
                text = x.customername & "," & x.address & "," & x.postcode & "," & x.mobilenumber & vbCrLf
                My.Computer.FileSystem.WriteAllText("data.txt", text, True)
            Next
        '   End Using


        MsgBox("Employe Data Saved")

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each x As customer In mycustomerlist
            ListView1.Items.Add(New ListViewItem({x.customername, x.address, x.postcode, x.mobilenumber}))
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnCustomerDetails_Click(sender As Object, e As EventArgs) Handles btnCustomerDetails.Click
        Me.Close()
        StatementDetails.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class