Imports System.Data.SqlClient
Public Class buyers
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\REMS\REMS\REMS.mdf;Integrated Security=True")
    Private Sub Displaybuyers()
        Try
            Con.Open()
            Dim query As String = "SELECT * FROM BuyerTbl"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, Con)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "BuyerTbl")
            BuyersDGV.DataSource = ds.Tables("BuyerTbl")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
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

    Private Sub buyerSaveBtn_Click(sender As Object, e As EventArgs) Handles buyerSaveBtn.Click
        If BuyerNameTb.Text = "" Or BuyerAddressTb.Text = "" Or mobileTb.Text = "" Or buyerTypeTb.Text = "" Or BuyerDescripTb.Text = "" Or BuyerBudgetTb.Text = "" Then
            MsgBox("Missing Information....!")
        Else
            Try
                Con.Open()
                Dim query = "INSERT INTO BuyerTbl VALUES('" & BuyerNameTb.Text & "','" & BuyerAddressTb.Text & "','" & mobileTb.Text & "','" & buyerTypeTb.Text & "','" & BuyerDescripTb.Text & "','" & BuyerBudgetTb.Text & "')"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Buyer added successfully")
                Displaybuyers()
                Reset() 'Assuming this method is defined elsewhere and will clear the textboxes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
    Private Sub Reset()
        BuyerNameTb.Text = ""
        BuyerAddressTb.Text = ""
        mobileTb.Text = ""
        buyerTypeTb.Text = ""
        BuyerDescripTb.Text = ""
        BuyerBudgetTb.Text = ""
    End Sub

    Private Sub buyers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displaybuyers()
    End Sub

    Private Sub Cross3_Click(sender As Object, e As EventArgs) Handles Cross3.Click
        Application.Exit()
    End Sub

    Private Sub buyerUpdateBtn_Click(sender As Object, e As EventArgs) Handles buyerUpdateBtn.Click
        If BuyerNameTb.Text = "" Or BuyerAddressTb.Text = "" Or mobileTb.Text = "" Or buyerTypeTb.Text = "" Or BuyerDescripTb.Text = "" Or BuyerBudgetTb.Text = "" Then
            MsgBox("Missing Information.....!")
        Else
            Try
                Con.Open()
                Dim query = "update BuyerTbl set BuyerName='" & BuyerNameTb.Text & "',BuyerAddress='" & BuyerAddressTb.Text & "',BuyerMobile='" & mobileTb.Text & "',BuyerProType='" & buyerTypeTb.Text & "',BuyerProDesc='" & BuyerDescripTb.Text & "',BuyerBudget='" & BuyerBudgetTb.Text & "',where BuyerId='" & Key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Buyer updated successfully")
                Displaybuyers()
                Reset()
                Con.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub buyerDeleteBtn_Click(sender As Object, e As EventArgs) Handles buyerDeleteBtn.Click
        If key = 0 Then
            MsgBox("Please select the buyer to delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from BuyerTbl where BuyerId='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Buyer deleted successfully")
                Con.Close()
                Displaybuyers()
                Reset()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub buyerResetBtn_Click(sender As Object, e As EventArgs) Handles buyerResetBtn.Click
        Reset()
    End Sub
    Dim Key = 0
    Private Sub BuyersDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BuyersDGV.CellContentClick
        Dim row As DataGridViewRow = BuyersDGV.Rows(e.RowIndex)
        BuyerNameTb.Text = row.Cells(1).Value.ToString
        BuyerAddressTb.Text = row.Cells(2).Value.ToString
        mobileTb.Text = row.Cells(3).Value.ToString
        buyerTypeTb.Text = row.Cells(4).Value.ToString
        BuyerDescripTb.Text = row.Cells(5).Value.ToString
        BuyerBudgetTb.Text = row.Cells(6).Value.ToString
        If BuyerNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class