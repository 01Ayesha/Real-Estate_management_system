Imports System.Data.SqlClient
Public Class Registrations
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\REMS\REMS\REMS.mdf;Integrated Security=True")
    Private Sub DisplayRegistrations()
        Try
            Con.Open()
            Dim query As String = "SELECT * FROM RegistrationTbl"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, Con)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "RegistrationTbl")
            RegistrationsDGV.DataSource = ds.Tables("RegistrationTbl")
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

    Private Sub SellerPicture_Click(sender As Object, e As EventArgs) Handles SellerPicture.Click
        Dim Obj = New sellers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Sellerlabel_Click(sender As Object, e As EventArgs) Handles Sellerlabel.Click
        Dim Obj = New sellers()
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

    Private Sub RegSaveBtn_Click(sender As Object, e As EventArgs) Handles RegSaveBtn.Click
        If RegSellerNameTb.Text = "" Or RegBuyerNameTb.Text = "" Or RegIdTb.Text = "" Or RegTypeTb.Text = "" Or RegDescTb.Text = "" Or RegSizeTb.Text = "" Or RegPriceTb.Text = "" Then
            MsgBox("Missing Information....!")
        Else
            Try
                Con.Open()
                Dim query = "INSERT INTO RegistrationTbl VALUES(@SellerName, @BuyerName, @Id, @Type, @Description, @Size, @Date, @Price)"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@SellerName", RegSellerNameTb.Text)
                cmd.Parameters.AddWithValue("@BuyerName", RegBuyerNameTb.Text)
                cmd.Parameters.AddWithValue("@Id", RegIdTb.Text)
                cmd.Parameters.AddWithValue("@Type", RegTypeTb.Text)
                cmd.Parameters.AddWithValue("@Description", RegDescTb.Text)
                cmd.Parameters.AddWithValue("@Size", RegSizeTb.Text)
                cmd.Parameters.AddWithValue("@Date", RegDate.Value)
                cmd.Parameters.AddWithValue("@Price", RegPriceTb.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Registration added successfully")
                DisplayRegistrations()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub

    Private Sub Registrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRegistrations()
    End Sub

    Private Sub Cross3_Click(sender As Object, e As EventArgs) Handles Cross3.Click
        Application.Exit()
    End Sub

    Dim Key As Integer = 0

    Private Sub RegistrationsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegistrationsDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = RegistrationsDGV.Rows(e.RowIndex)
            RegSellerNameTb.Text = row.Cells(1).Value.ToString
            RegBuyerNameTb.Text = row.Cells(2).Value.ToString
            RegIdTb.Text = row.Cells(3).Value.ToString
            RegTypeTb.Text = row.Cells(4).Value.ToString
            RegDescTb.Text = row.Cells(5).Value.ToString
            RegSizeTb.Text = row.Cells(6).Value.ToString
            If IsDate(row.Cells(7).Value) Then
                RegDate.Value = CDate(row.Cells(7).Value)
            End If
            RegPriceTb.Text = row.Cells(8).Value.ToString
            If RegSellerNameTb.Text = "" Or RegBuyerNameTb.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row.Cells(0).Value)
            End If
        End If
    End Sub
End Class