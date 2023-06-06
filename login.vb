Public Class Login
    Private Sub Cross2_Click(sender As Object, e As EventArgs) Handles Cross2.Click
        Application.Exit()
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        If Txtusername.Text = "" Or Txtpassword.Text = "" Then
            MsgBox("Please enter Username and Password")
        ElseIf Txtusername.Text = "Aisha" And Txtpassword.Text = "Password" Then
            Dim Obj = New Department
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("You have entered worong username and password")
            Txtusername.Text = ""
            Txtpassword.Text = ""
        End If
    End Sub

    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        Txtusername.Text = ""
        Txtpassword.Text = ""
    End Sub

    Private Sub Forgetpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Forgetpassword.LinkClicked
        MsgBox("Your username is Admin and password is Password", MsgBoxStyle.Information, "Forgot password? & Please write the login details")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class