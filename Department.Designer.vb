<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Department))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dashboardlabel = New System.Windows.Forms.Label()
        Me.Registrationlabel = New System.Windows.Forms.Label()
        Me.Buyerlabel = New System.Windows.Forms.Label()
        Me.Sellerlable = New System.Windows.Forms.Label()
        Me.DashboardPicture = New System.Windows.Forms.PictureBox()
        Me.LogoutPicture = New System.Windows.Forms.PictureBox()
        Me.RegistrationPicture = New System.Windows.Forms.PictureBox()
        Me.BuyerPicture = New System.Windows.Forms.PictureBox()
        Me.SellerPicture = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Remslabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cross3 = New System.Windows.Forms.Label()
        Me.Propertylabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.proaddress = New System.Windows.Forms.Label()
        Me.protype = New System.Windows.Forms.Label()
        Me.prodes = New System.Windows.Forms.Label()
        Me.prosize = New System.Windows.Forms.Label()
        Me.proprice = New System.Windows.Forms.Label()
        Me.NameTb = New System.Windows.Forms.TextBox()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.DescriptionTb = New System.Windows.Forms.TextBox()
        Me.SizeTb = New System.Windows.Forms.TextBox()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.propertyDGV = New System.Windows.Forms.DataGridView()
        Me.propertylist = New System.Windows.Forms.Label()
        Me.TypeTb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DashboardPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoutPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.propertyDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Dashboardlabel)
        Me.Panel1.Controls.Add(Me.Registrationlabel)
        Me.Panel1.Controls.Add(Me.Buyerlabel)
        Me.Panel1.Controls.Add(Me.Sellerlable)
        Me.Panel1.Controls.Add(Me.DashboardPicture)
        Me.Panel1.Controls.Add(Me.LogoutPicture)
        Me.Panel1.Controls.Add(Me.RegistrationPicture)
        Me.Panel1.Controls.Add(Me.BuyerPicture)
        Me.Panel1.Controls.Add(Me.SellerPicture)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 766)
        Me.Panel1.TabIndex = 0
        '
        'Dashboardlabel
        '
        Me.Dashboardlabel.AutoSize = True
        Me.Dashboardlabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Dashboardlabel.ForeColor = System.Drawing.Color.Black
        Me.Dashboardlabel.Location = New System.Drawing.Point(92, 450)
        Me.Dashboardlabel.Name = "Dashboardlabel"
        Me.Dashboardlabel.Size = New System.Drawing.Size(137, 28)
        Me.Dashboardlabel.TabIndex = 13
        Me.Dashboardlabel.Text = "Dashboard"
        '
        'Registrationlabel
        '
        Me.Registrationlabel.AutoSize = True
        Me.Registrationlabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Registrationlabel.ForeColor = System.Drawing.Color.Black
        Me.Registrationlabel.Location = New System.Drawing.Point(92, 346)
        Me.Registrationlabel.Name = "Registrationlabel"
        Me.Registrationlabel.Size = New System.Drawing.Size(188, 28)
        Me.Registrationlabel.TabIndex = 12
        Me.Registrationlabel.Text = "Registration(s)"
        '
        'Buyerlabel
        '
        Me.Buyerlabel.AutoSize = True
        Me.Buyerlabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Buyerlabel.ForeColor = System.Drawing.Color.Black
        Me.Buyerlabel.Location = New System.Drawing.Point(92, 240)
        Me.Buyerlabel.Name = "Buyerlabel"
        Me.Buyerlabel.Size = New System.Drawing.Size(112, 28)
        Me.Buyerlabel.TabIndex = 11
        Me.Buyerlabel.Text = "Buyer(s)"
        '
        'Sellerlable
        '
        Me.Sellerlable.AutoSize = True
        Me.Sellerlable.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sellerlable.ForeColor = System.Drawing.Color.Black
        Me.Sellerlable.Location = New System.Drawing.Point(95, 135)
        Me.Sellerlable.Name = "Sellerlable"
        Me.Sellerlable.Size = New System.Drawing.Size(111, 28)
        Me.Sellerlable.TabIndex = 10
        Me.Sellerlable.Text = "Seller(s)"
        '
        'DashboardPicture
        '
        Me.DashboardPicture.Image = CType(resources.GetObject("DashboardPicture.Image"), System.Drawing.Image)
        Me.DashboardPicture.Location = New System.Drawing.Point(0, 424)
        Me.DashboardPicture.Name = "DashboardPicture"
        Me.DashboardPicture.Size = New System.Drawing.Size(86, 81)
        Me.DashboardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DashboardPicture.TabIndex = 8
        Me.DashboardPicture.TabStop = False
        '
        'LogoutPicture
        '
        Me.LogoutPicture.Image = CType(resources.GetObject("LogoutPicture.Image"), System.Drawing.Image)
        Me.LogoutPicture.Location = New System.Drawing.Point(0, 713)
        Me.LogoutPicture.Name = "LogoutPicture"
        Me.LogoutPicture.Size = New System.Drawing.Size(48, 50)
        Me.LogoutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoutPicture.TabIndex = 7
        Me.LogoutPicture.TabStop = False
        '
        'RegistrationPicture
        '
        Me.RegistrationPicture.Image = CType(resources.GetObject("RegistrationPicture.Image"), System.Drawing.Image)
        Me.RegistrationPicture.Location = New System.Drawing.Point(0, 320)
        Me.RegistrationPicture.Name = "RegistrationPicture"
        Me.RegistrationPicture.Size = New System.Drawing.Size(86, 81)
        Me.RegistrationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RegistrationPicture.TabIndex = 6
        Me.RegistrationPicture.TabStop = False
        '
        'BuyerPicture
        '
        Me.BuyerPicture.Image = CType(resources.GetObject("BuyerPicture.Image"), System.Drawing.Image)
        Me.BuyerPicture.Location = New System.Drawing.Point(0, 215)
        Me.BuyerPicture.Name = "BuyerPicture"
        Me.BuyerPicture.Size = New System.Drawing.Size(86, 81)
        Me.BuyerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuyerPicture.TabIndex = 5
        Me.BuyerPicture.TabStop = False
        '
        'SellerPicture
        '
        Me.SellerPicture.Image = CType(resources.GetObject("SellerPicture.Image"), System.Drawing.Image)
        Me.SellerPicture.Location = New System.Drawing.Point(3, 112)
        Me.SellerPicture.Name = "SellerPicture"
        Me.SellerPicture.Size = New System.Drawing.Size(86, 81)
        Me.SellerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SellerPicture.TabIndex = 4
        Me.SellerPicture.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Remslabel)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 81)
        Me.Panel2.TabIndex = 0
        '
        'Remslabel
        '
        Me.Remslabel.AutoSize = True
        Me.Remslabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Remslabel.ForeColor = System.Drawing.Color.White
        Me.Remslabel.Location = New System.Drawing.Point(92, 27)
        Me.Remslabel.Name = "Remslabel"
        Me.Remslabel.Size = New System.Drawing.Size(79, 28)
        Me.Remslabel.TabIndex = 3
        Me.Remslabel.Text = "REMS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Cross3)
        Me.Panel3.Controls.Add(Me.Propertylabel)
        Me.Panel3.Location = New System.Drawing.Point(344, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 81)
        Me.Panel3.TabIndex = 1
        '
        'Cross3
        '
        Me.Cross3.AutoSize = True
        Me.Cross3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cross3.ForeColor = System.Drawing.Color.White
        Me.Cross3.Location = New System.Drawing.Point(945, 0)
        Me.Cross3.Name = "Cross3"
        Me.Cross3.Size = New System.Drawing.Size(28, 31)
        Me.Cross3.TabIndex = 9
        Me.Cross3.Text = "X"
        Me.Cross3.UseWaitCursor = True
        '
        'Propertylabel
        '
        Me.Propertylabel.AutoSize = True
        Me.Propertylabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Propertylabel.ForeColor = System.Drawing.Color.White
        Me.Propertylabel.Location = New System.Drawing.Point(16, 27)
        Me.Propertylabel.Name = "Propertylabel"
        Me.Propertylabel.Size = New System.Drawing.Size(165, 28)
        Me.Propertylabel.TabIndex = 2
        Me.Propertylabel.Text = "Property(ies)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(382, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Owner Name"
        '
        'proaddress
        '
        Me.proaddress.AutoSize = True
        Me.proaddress.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proaddress.ForeColor = System.Drawing.Color.Black
        Me.proaddress.Location = New System.Drawing.Point(703, 112)
        Me.proaddress.Name = "proaddress"
        Me.proaddress.Size = New System.Drawing.Size(189, 24)
        Me.proaddress.TabIndex = 3
        Me.proaddress.Text = "Property Location"
        '
        'protype
        '
        Me.protype.AutoSize = True
        Me.protype.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.protype.ForeColor = System.Drawing.Color.Black
        Me.protype.Location = New System.Drawing.Point(1054, 112)
        Me.protype.Name = "protype"
        Me.protype.Size = New System.Drawing.Size(153, 24)
        Me.protype.TabIndex = 4
        Me.protype.Text = "Property Type"
        '
        'prodes
        '
        Me.prodes.AutoSize = True
        Me.prodes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prodes.ForeColor = System.Drawing.Color.Black
        Me.prodes.Location = New System.Drawing.Point(382, 190)
        Me.prodes.Name = "prodes"
        Me.prodes.Size = New System.Drawing.Size(219, 24)
        Me.prodes.TabIndex = 5
        Me.prodes.Text = "Property Description"
        '
        'prosize
        '
        Me.prosize.AutoSize = True
        Me.prosize.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prosize.ForeColor = System.Drawing.Color.Black
        Me.prosize.Location = New System.Drawing.Point(703, 190)
        Me.prosize.Name = "prosize"
        Me.prosize.Size = New System.Drawing.Size(118, 24)
        Me.prosize.TabIndex = 6
        Me.prosize.Text = "Size (Sqft)"
        '
        'proprice
        '
        Me.proprice.AutoSize = True
        Me.proprice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proprice.ForeColor = System.Drawing.Color.Black
        Me.proprice.Location = New System.Drawing.Point(1054, 190)
        Me.proprice.Name = "proprice"
        Me.proprice.Size = New System.Drawing.Size(110, 24)
        Me.proprice.TabIndex = 7
        Me.proprice.Text = "Price (Rs)"
        '
        'NameTb
        '
        Me.NameTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameTb.Location = New System.Drawing.Point(382, 139)
        Me.NameTb.Name = "NameTb"
        Me.NameTb.Size = New System.Drawing.Size(242, 28)
        Me.NameTb.TabIndex = 8
        '
        'AddressTb
        '
        Me.AddressTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AddressTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddressTb.Location = New System.Drawing.Point(703, 139)
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(307, 28)
        Me.AddressTb.TabIndex = 9
        '
        'DescriptionTb
        '
        Me.DescriptionTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DescriptionTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionTb.Location = New System.Drawing.Point(382, 217)
        Me.DescriptionTb.Name = "DescriptionTb"
        Me.DescriptionTb.Size = New System.Drawing.Size(242, 28)
        Me.DescriptionTb.TabIndex = 11
        '
        'SizeTb
        '
        Me.SizeTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SizeTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SizeTb.Location = New System.Drawing.Point(703, 217)
        Me.SizeTb.Name = "SizeTb"
        Me.SizeTb.Size = New System.Drawing.Size(242, 28)
        Me.SizeTb.TabIndex = 12
        '
        'PriceTb
        '
        Me.PriceTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PriceTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PriceTb.Location = New System.Drawing.Point(1054, 217)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(241, 28)
        Me.PriceTb.TabIndex = 13
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.savebtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.Location = New System.Drawing.Point(436, 262)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(141, 50)
        Me.savebtn.TabIndex = 14
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.updatebtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.updatebtn.ForeColor = System.Drawing.Color.White
        Me.updatebtn.Location = New System.Drawing.Point(643, 262)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(141, 50)
        Me.updatebtn.TabIndex = 15
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.deletebtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(858, 262)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(141, 50)
        Me.deletebtn.TabIndex = 16
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.resetbtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.resetbtn.ForeColor = System.Drawing.Color.White
        Me.resetbtn.Location = New System.Drawing.Point(1066, 262)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(141, 50)
        Me.resetbtn.TabIndex = 17
        Me.resetbtn.Text = "Reset"
        Me.resetbtn.UseVisualStyleBackColor = False
        '
        'propertyDGV
        '
        Me.propertyDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.propertyDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.propertyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.propertyDGV.GridColor = System.Drawing.Color.Aquamarine
        Me.propertyDGV.Location = New System.Drawing.Point(358, 362)
        Me.propertyDGV.Name = "propertyDGV"
        Me.propertyDGV.RowHeadersWidth = 51
        Me.propertyDGV.RowTemplate.Height = 29
        Me.propertyDGV.Size = New System.Drawing.Size(945, 397)
        Me.propertyDGV.TabIndex = 18
        '
        'propertylist
        '
        Me.propertylist.AutoSize = True
        Me.propertylist.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.propertylist.ForeColor = System.Drawing.Color.Black
        Me.propertylist.Location = New System.Drawing.Point(732, 329)
        Me.propertylist.Name = "propertylist"
        Me.propertylist.Size = New System.Drawing.Size(181, 28)
        Me.propertylist.TabIndex = 19
        Me.propertylist.Text = "Properties List"
        '
        'TypeTb
        '
        Me.TypeTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TypeTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TypeTb.Location = New System.Drawing.Point(1054, 139)
        Me.TypeTb.Name = "TypeTb"
        Me.TypeTb.Size = New System.Drawing.Size(241, 28)
        Me.TypeTb.TabIndex = 10
        '
        'Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1317, 766)
        Me.Controls.Add(Me.propertylist)
        Me.Controls.Add(Me.propertyDGV)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.PriceTb)
        Me.Controls.Add(Me.SizeTb)
        Me.Controls.Add(Me.DescriptionTb)
        Me.Controls.Add(Me.TypeTb)
        Me.Controls.Add(Me.AddressTb)
        Me.Controls.Add(Me.NameTb)
        Me.Controls.Add(Me.proprice)
        Me.Controls.Add(Me.prosize)
        Me.Controls.Add(Me.prodes)
        Me.Controls.Add(Me.protype)
        Me.Controls.Add(Me.proaddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DashboardPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoutPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.propertyDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Propertylabel As Label
    Friend WithEvents DashboardPicture As PictureBox
    Friend WithEvents LogoutPicture As PictureBox
    Friend WithEvents RegistrationPicture As PictureBox
    Friend WithEvents BuyerPicture As PictureBox
    Friend WithEvents SellerPicture As PictureBox
    Friend WithEvents Dashboardlabel As Label
    Friend WithEvents Registrationlabel As Label
    Friend WithEvents Buyerlabel As Label
    Friend WithEvents Sellerlable As Label
    Friend WithEvents Remslabel As Label
    Friend WithEvents Cross3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents proaddress As Label
    Friend WithEvents protype As Label
    Friend WithEvents prodes As Label
    Friend WithEvents prosize As Label
    Friend WithEvents proprice As Label
    Friend WithEvents NameTb As TextBox
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents DescriptionTb As TextBox
    Friend WithEvents SizeTb As TextBox
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents propertyDGV As DataGridView
    Friend WithEvents propertylist As Label
    Friend WithEvents TypeTb As TextBox
End Class
