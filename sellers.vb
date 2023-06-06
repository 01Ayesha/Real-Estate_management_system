Imports System.Data.SqlClient
Public Class sellers
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\REMS\REMS\REMS.mdf;Integrated Security=True")
    Private Sub Displaysellers()
        Try
            Con.Open()
            Dim query As String = "SELECT * FROM SellerTbl"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, Con)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "SellerTbl")
            SellersDGV.DataSource = ds.Tables("SellerTbl")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub BuyerPicture_Click(sender As Object, e As EventArgs) Handles BuyerPicture.Click
        Dim Obj = New buyers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Buyerlable_Click(sender As Object, e As EventArgs) Handles Buyerlable.Click
        Dim Obj = New buyers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PropertyPicture_Click(sender As Object, e As EventArgs) Handles PropertyPicture.Click
        Dim Obj = New Department()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Propertylabel_Click(sender As Object, e As EventArgs) Handles Propertylabel.Click
        Dim Obj = New Department()
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

    Private Sub sellerSaveBtn_Click(sender As Object, e As EventArgs) Handles sellerSaveBtn.Click
        If SellerNameTb.Text = "" Or SellerAddressTb.Text = "" Or SellermobileTb.Text = "" Or SellerTypeTb.Text = "" Or SellerDescripTb.Text = "" Or SellerSizeTb.Text = "" Then
            MsgBox("Missing Information....!")
        Else
            Try
                Con.Open()
                Dim query = "INSERT INTO SellerTbl VALUES('" & SellerNameTb.Text & "','" & SellerAddressTb.Text & "','" & SellermobileTb.Text & "','" & SellerTypeTb.Text & "','" & SellerDescripTb.Text & "','" & SellerSizeTb.Text & "')"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Seller added successfully")
                Displaysellers()
                Reset() 'Assuming this method is defined elsewhere and will clear the textboxes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
    Private Sub Reset()
        SellerNameTb.Text = ""
        SellerAddressTb.Text = ""
        SellermobileTb.Text = ""
        SellerTypeTb.Text = ""
        SellerDescripTb.Text = ""
        SellerSizeTb.Text = ""
    End Sub

    Private Sub sellers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displaysellers()
    End Sub

    Private Sub Cross3_Click(sender As Object, e As EventArgs) Handles Cross3.Click
        Application.Exit()
    End Sub

    Private Sub sellerUpdateBtn_Click(sender As Object, e As EventArgs) Handles sellerUpdateBtn.Click
        If SellerNameTb.Text = "" Or SellerAddressTb.Text = "" Or SellermobileTb.Text = "" Or SellerTypeTb.Text = "" Or SellerDescripTb.Text = "" Or SellerSizeTb.Text = "" Then
            MsgBox("Missing Information.....!")
        Else
            Try
                Con.Open()
                Dim query = "update SellerTbl set SellerName='" & SellerNameTb.Text & "',SellerAddress='" & SellerAddressTb.Text & "',SellerMobile='" & SellermobileTb.Text & "',SellerType='" & SellerTypeTb.Text & "',SellerDesc='" & SellerDescripTb.Text & "',SellerSize='" & SellerSizeTb.Text & "',where SellerId='" & Key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Seller updated successfully")
                Displaysellers()
                Reset()
                Con.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub sellerDeleteBtn_Click(sender As Object, e As EventArgs) Handles sellerDeleteBtn.Click
        If key = 0 Then
            MsgBox("Please select the seller to delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from SellerTbl where SellerId='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Seller deleted successfully")
                Con.Close()
                Displaysellers()
                Reset()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub sellerResetBtn_Click(sender As Object, e As EventArgs) Handles sellerResetBtn.Click
        Reset()
    End Sub
    Dim Key = 0
    Private Sub SellersDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SellersDGV.CellContentClick
        Dim row As DataGridViewRow = SellersDGV.Rows(e.RowIndex)
        SellerNameTb.Text = row.Cells(1).Value.ToString
        SellerAddressTb.Text = row.Cells(2).Value.ToString
        SellermobileTb.Text = row.Cells(3).Value.ToString
        SellerTypeTb.Text = row.Cells(4).Value.ToString
        SellerDescripTb.Text = row.Cells(5).Value.ToString
        SellerSizeTb.Text = row.Cells(6).Value.ToString
        If SellerNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class