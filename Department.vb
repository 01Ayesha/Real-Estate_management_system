Imports System.Data.SqlClient

Public Class Department
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\REMS\REMS\REMS.mdf;Integrated Security=True")

    Private Sub DisplayDepartment()
        Try
            Con.Open()
            Dim query As String = "SELECT * FROM PropertyTbl"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, Con)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "PropertyTbl")
            propertyDGV.DataSource = ds.Tables("PropertyTbl")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do not call Application.Exit(), this will immediately close the application
        'This method is used to perform any initialization code for the form when it is loaded
        'For example, you might want to call DisplayDepartment() to show the data in the grid view
        DisplayDepartment()
    End Sub

    Private Sub Cross3_Click(sender As Object, e As EventArgs) Handles Cross3.Click
        'Do not call Application.Exit() here, this will immediately close the application
        'Instead, you can close the form by calling Me.Close()
        Me.Close()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If NameTb.Text = "" Or AddressTb.Text = "" Or TypeTb.Text = "" Or DescriptionTb.Text = "" Or SizeTb.Text = "" Or PriceTb.Text = "" Then
            MsgBox("Missing Information....!")
        Else
            Try
                Con.Open()
                Dim query = "INSERT INTO PropertyTbl VALUES('" & NameTb.Text & "','" & AddressTb.Text & "','" & TypeTb.Text & "','" & DescriptionTb.Text & "','" & SizeTb.Text & "','" & PriceTb.Text & "')"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Property added successfully")
                DisplayDepartment()
                Reset() 'Assuming this method is defined elsewhere and will clear the textboxes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
    Private Sub Reset()
        NameTb.Text = ""
        AddressTb.Text = ""
        TypeTb.Text = ""
        DescriptionTb.Text = ""
        SizeTb.Text = ""
        PriceTb.Text = ""
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        If NameTb.Text = "" Or AddressTb.Text = "" Or TypeTb.Text = "" Or DescriptionTb.Text = "" Or SizeTb.Text = "" Or PriceTb.Text = "" Then
            MsgBox("Missing Information....!")
        Else
            Try
                Con.Open()
                Dim query = "update PropertyTbl set Slr_Name='" & NameTb.Text & "',Pro_Add='" & AddressTb.Text & "',Pro_Type='" & TypeTb.Text & "',Pro_Des='" & DescriptionTb.Text & "',Pro_Size='" & SizeTb.Text & "',Pro_Price='" & PriceTb.Text & "',where Pro_Id='" & Key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Property updated successfully")
                DisplayDepartment()
                Reset()
                Con.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If key = 0 Then
            MsgBox("Please select the property to delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from PropertyTbl where Pro_Id='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Property deleted successfully")
                Con.Close()
                DisplayDepartment()
                Reset()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub propertyDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles propertyDGV.CellContentClick
        Dim row As DataGridViewRow = propertyDGV.Rows(e.RowIndex)
        NameTb.Text = row.Cells(1).Value.ToString
        AddressTb.Text = row.Cells(2).Value.ToString
        TypeTb.Text = row.Cells(3).Value.ToString
        DescriptionTb.Text = row.Cells(4).Value.ToString
        SizeTb.Text = row.Cells(5).Value.ToString
        PriceTb.Text = row.Cells(6).Value.ToString
        If NameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub SellerPicture_Click(sender As Object, e As EventArgs) Handles SellerPicture.Click
        Dim Obj = New sellers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Sellerlable_Click(sender As Object, e As EventArgs) Handles Sellerlable.Click
        Dim Obj = New sellers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BuyerPicture_Click(sender As Object, e As EventArgs) Handles BuyerPicture.Click
        Dim Obj = New buyers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Buyerlabel_Click(sender As Object, e As EventArgs) Handles Buyerlabel.Click
        Dim Obj = New buyers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrationPicture_Click(sender As Object, e As EventArgs) Handles RegistrationPicture.Click
        Dim Obj = New Registrations()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Registrationlabel_Click(sender As Object, e As EventArgs) Handles Registrationlabel.Click
        Dim Obj = New Registrations()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardPicture_Click(sender As Object, e As EventArgs) Handles DashboardPicture.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboardlabel_Click(sender As Object, e As EventArgs) Handles Dashboardlabel.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub DateLabel_Click(sender As Object, e As EventArgs) Handles DateLabel.Click
        Dim Obj = New Date_Registration()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub DatePic_Click(sender As Object, e As EventArgs) Handles DatePic.Click
        Dim Obj = New Date_Registration()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutPicture_Click(sender As Object, e As EventArgs) Handles LogoutPicture.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class
