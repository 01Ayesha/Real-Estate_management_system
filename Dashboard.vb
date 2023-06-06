Imports System.Data.SqlClient
Public Class Dashboard
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\REMS\REMS\REMS.mdf;Integrated Security=True")
    Private Sub CountBuyers()
        Dim Bnum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from BuyerTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Bnum = cmd.ExecuteScalar
        NOB.Text = Bnum
        Con.Close()
    End Sub
    Private Sub CountSellers()
        Dim Snum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from SellerTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Snum = cmd.ExecuteScalar
        NOS.Text = Snum
        Con.Close()
    End Sub
    Private Sub CountProperty()
        Dim Pnum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from PropertyTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Pnum = cmd.ExecuteScalar
        NOP.Text = Pnum
        Con.Close()
    End Sub
    Private Sub CountRegistrations()
        Dim Rnum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from RegistrationTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Rnum = cmd.ExecuteScalar
        NOR.Text = Rnum
        Con.Close()
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountBuyers()
        CountSellers()
        CountProperty()
        CountRegistrations()
    End Sub

    Private Sub Cross3_Click(sender As Object, e As EventArgs) Handles Cross3.Click
        Application.Exit()
    End Sub
End Class