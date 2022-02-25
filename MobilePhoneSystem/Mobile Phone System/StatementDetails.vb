Imports System.IO

Public Class StatementDetails
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim trueval, trueval1 As Boolean

        strName = StrConv(txtCustomerName.Text, vbProperCase)

        strAddress = StrConv(txtAddress.Text, vbProperCase)
        strPostcode = StrConv(txtPostCode.Text, vbUpperCase)
        strmobileNo = txtMobileNo.Text
        strPlantype = cmbPlanType.Text


        If String.IsNullOrEmpty(txtCustomerName.Text) Or String.IsNullOrEmpty(txtAddress.Text) Or String.IsNullOrEmpty(txtPostCode.Text) Or String.IsNullOrEmpty(txtMobileNo.Text) Then

            trueval = False

            If String.IsNullOrEmpty(txtCustomerName.Text) Then
                txtCustomerName.BackColor = Color.Red
            End If

            If String.IsNullOrEmpty(txtAddress.Text) Then
                txtAddress.BackColor = Color.Red
            End If


            If String.IsNullOrEmpty(txtPostCode.Text) Then
                txtPostCode.BackColor = Color.Red
            End If

            If String.IsNullOrEmpty(txtMobileNo.Text) Then
                txtMobileNo.BackColor = Color.Red
            End If

        Else
            trueval = True
            txtCustomerName.BackColor = Color.White
            txtAddress.BackColor = Color.White
            txtPostCode.BackColor = Color.White
            txtMobileNo.BackColor = Color.White

        End If

        Try

        Catch ex As Exception

        End Try




        Try
            ushMinsused = CUShort(txtMinsUsed.Text)
            trueval1 = True
            txtMinsUsed.BackColor = Color.White
        Catch ex As Exception
            trueval1 = False
            txtMinsUsed.BackColor = Color.Pink
        End Try

        If String.IsNullOrEmpty(txtMinsUsed.Text) Or String.IsNullOrEmpty(txtTextsSent.Text) Or String.IsNullOrEmpty(txtDataUsed.Text) Then

            txtMinsUsed.Text = 0
            txtTextsSent.Text = 0
            txtDataUsed.Text = 0
            txtMinsUsed.BackColor = Color.White
            txtTextsSent.BackColor = Color.White
            txtDataUsed.BackColor = Color.White
            trueval1 = True

        End If

        If trueval = True And trueval1 = True Then
            Me.Hide()
            BillDetails.Show()
        End If

    End Sub

    Private Sub txtTextsSent_TextChanged(sender As Object, e As EventArgs) Handles txtTextsSent.TextChanged

    End Sub

    Private Sub txtTextsSent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTextsSent.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMinsUsed_TextChanged(sender As Object, e As EventArgs) Handles txtMinsUsed.TextChanged

    End Sub

    Private Sub txtMinsUsed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinsUsed.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDataUsed_TextChanged(sender As Object, e As EventArgs) Handles txtDataUsed.TextChanged

    End Sub

    Private Sub txtDataUsed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataUsed.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCustomerDetails_Click(sender As Object, e As EventArgs) Handles btnCustomerDetails.Click
        Me.Close()
        CustomerDetails.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim r As customer

        Dim myfile As FileIO.TextFieldParser

        Dim record() As String = {}
        '  If File.Exists("data.txt") Then
        myfile = My.Computer.FileSystem.OpenTextFieldParser("data.txt", ",")

            While Not myfile.EndOfData
                record = myfile.ReadFields
                r.customername = record(0)
                r.address = record(1)
                r.postcode = record(2)
                r.mobilenumber = record(3)
                mycustomerlist.Add(r)
            End While

            myfile.Close()

            For Each x As customer In mycustomerlist
                ComboBox1.Items.Add(x.customername & " " & x.mobilenumber)
            Next
        '  End If

        For i = 1 To 12
            ListView1.Items.Add(New ListViewItem({i, "4G", 0, 0, 0}))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim i As Integer

        i = ComboBox1.SelectedIndex

        txtCustomerName.Text = mycustomerlist(i).customername
        txtAddress.Text = mycustomerlist(i).address
        txtPostCode.Text = mycustomerlist(i).postcode
        txtMobileNo.Text = mycustomerlist(i).mobilenumber

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        myexit()
    End Sub

    Sub myexit()
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each x As ListViewItem In ListView1.CheckedItems
            x.SubItems(1).Text = cmbPlanType.Text
            x.SubItems(2).Text = txtMinsUsed.Text
            x.SubItems(3).Text = txtTextsSent.Text
            x.SubItems(4).Text = txtDataUsed.Text
        Next

        For Each x As ListViewItem In ListView1.CheckedItems
            x.Checked = False
        Next
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1Home.Show()
    End Sub
End Class
