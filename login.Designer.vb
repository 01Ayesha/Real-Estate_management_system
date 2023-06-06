<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Loginpicture = New System.Windows.Forms.PictureBox()
        Me.Loginpanel = New System.Windows.Forms.Panel()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.Forgetpassword = New System.Windows.Forms.LinkLabel()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Rememberpassword = New System.Windows.Forms.CheckBox()
        Me.Showpassword = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Cross2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Loginpanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1221, 718)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Loginpicture
        '
        Me.Loginpicture.Image = CType(resources.GetObject("Loginpicture.Image"), System.Drawing.Image)
        Me.Loginpicture.Location = New System.Drawing.Point(106, 15)
        Me.Loginpicture.Name = "Loginpicture"
        Me.Loginpicture.Size = New System.Drawing.Size(200, 178)
        Me.Loginpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loginpicture.TabIndex = 1
        Me.Loginpicture.TabStop = False
        '
        'Loginpanel
        '
        Me.Loginpanel.BackColor = System.Drawing.Color.Silver
        Me.Loginpanel.Controls.Add(Me.Resetbtn)
        Me.Loginpanel.Controls.Add(Me.Forgetpassword)
        Me.Loginpanel.Controls.Add(Me.Loginbtn)
        Me.Loginpanel.Controls.Add(Me.Rememberpassword)
        Me.Loginpanel.Controls.Add(Me.Showpassword)
        Me.Loginpanel.Controls.Add(Me.PictureBox4)
        Me.Loginpanel.Controls.Add(Me.PictureBox3)
        Me.Loginpanel.Controls.Add(Me.Txtpassword)
        Me.Loginpanel.Controls.Add(Me.Txtusername)
        Me.Loginpanel.Controls.Add(Me.Loginpicture)
        Me.Loginpanel.Location = New System.Drawing.Point(717, 110)
        Me.Loginpanel.Name = "Loginpanel"
        Me.Loginpanel.Size = New System.Drawing.Size(407, 571)
        Me.Loginpanel.TabIndex = 2
        '
        'Resetbtn
        '
        Me.Resetbtn.BackColor = System.Drawing.Color.Orange
        Me.Resetbtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Resetbtn.Location = New System.Drawing.Point(34, 424)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(120, 43)
        Me.Resetbtn.TabIndex = 7
        Me.Resetbtn.Text = "Reset"
        Me.Resetbtn.UseVisualStyleBackColor = False
        '
        'Forgetpassword
        '
        Me.Forgetpassword.AutoSize = True
        Me.Forgetpassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Forgetpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Forgetpassword.LinkColor = System.Drawing.Color.Black
        Me.Forgetpassword.Location = New System.Drawing.Point(232, 523)
        Me.Forgetpassword.Name = "Forgetpassword"
        Me.Forgetpassword.Size = New System.Drawing.Size(143, 23)
        Me.Forgetpassword.TabIndex = 3
        Me.Forgetpassword.TabStop = True
        Me.Forgetpassword.Text = "Forget password?"
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.Orange
        Me.Loginbtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Loginbtn.Location = New System.Drawing.Point(246, 424)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(120, 43)
        Me.Loginbtn.TabIndex = 6
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'Rememberpassword
        '
        Me.Rememberpassword.AutoSize = True
        Me.Rememberpassword.Location = New System.Drawing.Point(34, 371)
        Me.Rememberpassword.Name = "Rememberpassword"
        Me.Rememberpassword.Size = New System.Drawing.Size(171, 24)
        Me.Rememberpassword.TabIndex = 3
        Me.Rememberpassword.Text = "Remember password"
        Me.Rememberpassword.UseVisualStyleBackColor = True
        '
        'Showpassword
        '
        Me.Showpassword.AutoSize = True
        Me.Showpassword.Location = New System.Drawing.Point(232, 371)
        Me.Showpassword.Name = "Showpassword"
        Me.Showpassword.Size = New System.Drawing.Size(134, 24)
        Me.Showpassword.TabIndex = 4
        Me.Showpassword.Text = "Show password"
        Me.Showpassword.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(34, 309)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(34, 249)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(106, 309)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(260, 27)
        Me.Txtpassword.TabIndex = 3
        '
        'Txtusername
        '
        Me.Txtusername.Location = New System.Drawing.Point(106, 249)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(260, 27)
        Me.Txtusername.TabIndex = 2
        '
        'Cross2
        '
        Me.Cross2.AutoSize = True
        Me.Cross2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cross2.Location = New System.Drawing.Point(1191, 0)
        Me.Cross2.Name = "Cross2"
        Me.Cross2.Size = New System.Drawing.Size(28, 31)
        Me.Cross2.TabIndex = 8
        Me.Cross2.Text = "X"
        Me.Cross2.UseWaitCursor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 718)
        Me.Controls.Add(Me.Cross2)
        Me.Controls.Add(Me.Loginpanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Loginpanel.ResumeLayout(False)
        Me.Loginpanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Loginpicture As PictureBox
    Friend WithEvents Loginpanel As Panel
    Friend WithEvents Rememberpassword As CheckBox
    Friend WithEvents Showpassword As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Resetbtn As Button
    Friend WithEvents Forgetpassword As LinkLabel
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Cross2 As Label
End Class
