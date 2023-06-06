<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Loginpicture = New System.Windows.Forms.PictureBox()
        Me.Headline = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cross = New System.Windows.Forms.Label()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Loginpicture
        '
        Me.Loginpicture.BackColor = System.Drawing.Color.White
        Me.Loginpicture.Image = CType(resources.GetObject("Loginpicture.Image"), System.Drawing.Image)
        Me.Loginpicture.Location = New System.Drawing.Point(1, 0)
        Me.Loginpicture.Name = "Loginpicture"
        Me.Loginpicture.Size = New System.Drawing.Size(1221, 718)
        Me.Loginpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Loginpicture.TabIndex = 0
        Me.Loginpicture.TabStop = False
        '
        'Headline
        '
        Me.Headline.AutoSize = True
        Me.Headline.BackColor = System.Drawing.Color.Transparent
        Me.Headline.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Headline.ForeColor = System.Drawing.Color.Black
        Me.Headline.Location = New System.Drawing.Point(451, 70)
        Me.Headline.Name = "Headline"
        Me.Headline.Size = New System.Drawing.Size(658, 37)
        Me.Headline.TabIndex = 1
        Me.Headline.Text = "REAL - ESTATE MANAGEMENT SYSTEM"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Lime
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(216, 646)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(792, 27)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Cross
        '
        Me.Cross.AutoSize = True
        Me.Cross.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cross.Location = New System.Drawing.Point(1194, 0)
        Me.Cross.Name = "Cross"
        Me.Cross.Size = New System.Drawing.Size(28, 31)
        Me.Cross.TabIndex = 3
        Me.Cross.Text = "X"
        Me.Cross.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 718)
        Me.Controls.Add(Me.Cross)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Headline)
        Me.Controls.Add(Me.Loginpicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "proglogin"
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Loginpicture As PictureBox
    Friend WithEvents Headline As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cross As Label
End Class
