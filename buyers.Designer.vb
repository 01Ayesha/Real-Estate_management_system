<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class buyers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buyers))
        Me.Buyerslist = New System.Windows.Forms.Label()
        Me.BuyersDGV = New System.Windows.Forms.DataGridView()
        Me.buyerResetBtn = New System.Windows.Forms.Button()
        Me.buyerDeleteBtn = New System.Windows.Forms.Button()
        Me.buyerUpdateBtn = New System.Windows.Forms.Button()
        Me.buyerSaveBtn = New System.Windows.Forms.Button()
        Me.BuyerBudgetTb = New System.Windows.Forms.TextBox()
        Me.BuyerDescripTb = New System.Windows.Forms.TextBox()
        Me.buyerTypeTb = New System.Windows.Forms.TextBox()
        Me.mobileTb = New System.Windows.Forms.TextBox()
        Me.BuyerAddressTb = New System.Windows.Forms.TextBox()
        Me.BuyerNameTb = New System.Windows.Forms.TextBox()
        Me.Budget = New System.Windows.Forms.Label()
        Me.buyerdesc = New System.Windows.Forms.Label()
        Me.buyerType = New System.Windows.Forms.Label()
        Me.mobile = New System.Windows.Forms.Label()
        Me.buyeraddress = New System.Windows.Forms.Label()
        Me.Cross3 = New System.Windows.Forms.Label()
        Me.byrlabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Remslabel = New System.Windows.Forms.Label()
        Me.Dashboardlabel = New System.Windows.Forms.Label()
        Me.Registrationlabel = New System.Windows.Forms.Label()
        Me.Propertylabel = New System.Windows.Forms.Label()
        Me.Sellerlable = New System.Windows.Forms.Label()
        Me.DashboardPicture = New System.Windows.Forms.PictureBox()
        Me.LogoutPicture = New System.Windows.Forms.PictureBox()
        Me.RegistrationPicture = New System.Windows.Forms.PictureBox()
        Me.PropertyPicture = New System.Windows.Forms.PictureBox()
        Me.SellerPicture = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BuyerName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.BuyersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DashboardPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoutPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buyerslist
        '
        Me.Buyerslist.AutoSize = True
        Me.Buyerslist.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Buyerslist.ForeColor = System.Drawing.Color.Black
        Me.Buyerslist.Location = New System.Drawing.Point(737, 329)
        Me.Buyerslist.Name = "Buyerslist"
        Me.Buyerslist.Size = New System.Drawing.Size(141, 28)
        Me.Buyerslist.TabIndex = 39
        Me.Buyerslist.Text = "Buyers List"
        '
        'BuyersDGV
        '
        Me.BuyersDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BuyersDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BuyersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuyersDGV.GridColor = System.Drawing.Color.Aquamarine
        Me.BuyersDGV.Location = New System.Drawing.Point(358, 361)
        Me.BuyersDGV.Name = "BuyersDGV"
        Me.BuyersDGV.RowHeadersWidth = 51
        Me.BuyersDGV.RowTemplate.Height = 29
        Me.BuyersDGV.Size = New System.Drawing.Size(945, 397)
        Me.BuyersDGV.TabIndex = 38
        '
        'buyerResetBtn
        '
        Me.buyerResetBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.buyerResetBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerResetBtn.ForeColor = System.Drawing.Color.White
        Me.buyerResetBtn.Location = New System.Drawing.Point(1066, 262)
        Me.buyerResetBtn.Name = "buyerResetBtn"
        Me.buyerResetBtn.Size = New System.Drawing.Size(141, 50)
        Me.buyerResetBtn.TabIndex = 37
        Me.buyerResetBtn.Text = "Reset"
        Me.buyerResetBtn.UseVisualStyleBackColor = False
        '
        'buyerDeleteBtn
        '
        Me.buyerDeleteBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.buyerDeleteBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.buyerDeleteBtn.Location = New System.Drawing.Point(858, 262)
        Me.buyerDeleteBtn.Name = "buyerDeleteBtn"
        Me.buyerDeleteBtn.Size = New System.Drawing.Size(141, 50)
        Me.buyerDeleteBtn.TabIndex = 36
        Me.buyerDeleteBtn.Text = "Delete"
        Me.buyerDeleteBtn.UseVisualStyleBackColor = False
        '
        'buyerUpdateBtn
        '
        Me.buyerUpdateBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.buyerUpdateBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.buyerUpdateBtn.Location = New System.Drawing.Point(643, 262)
        Me.buyerUpdateBtn.Name = "buyerUpdateBtn"
        Me.buyerUpdateBtn.Size = New System.Drawing.Size(141, 50)
        Me.buyerUpdateBtn.TabIndex = 35
        Me.buyerUpdateBtn.Text = "Update"
        Me.buyerUpdateBtn.UseVisualStyleBackColor = False
        '
        'buyerSaveBtn
        '
        Me.buyerSaveBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.buyerSaveBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerSaveBtn.ForeColor = System.Drawing.Color.White
        Me.buyerSaveBtn.Location = New System.Drawing.Point(436, 262)
        Me.buyerSaveBtn.Name = "buyerSaveBtn"
        Me.buyerSaveBtn.Size = New System.Drawing.Size(141, 50)
        Me.buyerSaveBtn.TabIndex = 34
        Me.buyerSaveBtn.Text = "Save"
        Me.buyerSaveBtn.UseVisualStyleBackColor = False
        '
        'BuyerBudgetTb
        '
        Me.BuyerBudgetTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BuyerBudgetTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BuyerBudgetTb.Location = New System.Drawing.Point(1054, 217)
        Me.BuyerBudgetTb.Name = "BuyerBudgetTb"
        Me.BuyerBudgetTb.Size = New System.Drawing.Size(241, 28)
        Me.BuyerBudgetTb.TabIndex = 33
        '
        'BuyerDescripTb
        '
        Me.BuyerDescripTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BuyerDescripTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BuyerDescripTb.Location = New System.Drawing.Point(703, 217)
        Me.BuyerDescripTb.Name = "BuyerDescripTb"
        Me.BuyerDescripTb.Size = New System.Drawing.Size(242, 28)
        Me.BuyerDescripTb.TabIndex = 32
        '
        'buyerTypeTb
        '
        Me.buyerTypeTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.buyerTypeTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerTypeTb.Location = New System.Drawing.Point(382, 217)
        Me.buyerTypeTb.Name = "buyerTypeTb"
        Me.buyerTypeTb.Size = New System.Drawing.Size(242, 28)
        Me.buyerTypeTb.TabIndex = 31
        '
        'mobileTb
        '
        Me.mobileTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mobileTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mobileTb.Location = New System.Drawing.Point(1054, 139)
        Me.mobileTb.Name = "mobileTb"
        Me.mobileTb.Size = New System.Drawing.Size(241, 28)
        Me.mobileTb.TabIndex = 30
        '
        'BuyerAddressTb
        '
        Me.BuyerAddressTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BuyerAddressTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BuyerAddressTb.Location = New System.Drawing.Point(703, 139)
        Me.BuyerAddressTb.Name = "BuyerAddressTb"
        Me.BuyerAddressTb.Size = New System.Drawing.Size(307, 28)
        Me.BuyerAddressTb.TabIndex = 29
        '
        'BuyerNameTb
        '
        Me.BuyerNameTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BuyerNameTb.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BuyerNameTb.Location = New System.Drawing.Point(382, 139)
        Me.BuyerNameTb.Name = "BuyerNameTb"
        Me.BuyerNameTb.Size = New System.Drawing.Size(242, 28)
        Me.BuyerNameTb.TabIndex = 28
        '
        'Budget
        '
        Me.Budget.AutoSize = True
        Me.Budget.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Budget.ForeColor = System.Drawing.Color.Black
        Me.Budget.Location = New System.Drawing.Point(1054, 190)
        Me.Budget.Name = "Budget"
        Me.Budget.Size = New System.Drawing.Size(83, 24)
        Me.Budget.TabIndex = 27
        Me.Budget.Text = "Budget"
        '
        'buyerdesc
        '
        Me.buyerdesc.AutoSize = True
        Me.buyerdesc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerdesc.ForeColor = System.Drawing.Color.Black
        Me.buyerdesc.Location = New System.Drawing.Point(703, 190)
        Me.buyerdesc.Name = "buyerdesc"
        Me.buyerdesc.Size = New System.Drawing.Size(219, 24)
        Me.buyerdesc.TabIndex = 26
        Me.buyerdesc.Text = "Property Description"
        '
        'buyerType
        '
        Me.buyerType.AutoSize = True
        Me.buyerType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyerType.ForeColor = System.Drawing.Color.Black
        Me.buyerType.Location = New System.Drawing.Point(382, 190)
        Me.buyerType.Name = "buyerType"
        Me.buyerType.Size = New System.Drawing.Size(153, 24)
        Me.buyerType.TabIndex = 25
        Me.buyerType.Text = "Property Type"
        '
        'mobile
        '
        Me.mobile.AutoSize = True
        Me.mobile.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mobile.ForeColor = System.Drawing.Color.Black
        Me.mobile.Location = New System.Drawing.Point(1054, 112)
        Me.mobile.Name = "mobile"
        Me.mobile.Size = New System.Drawing.Size(164, 24)
        Me.mobile.TabIndex = 24
        Me.mobile.Text = "Mobile Number"
        '
        'buyeraddress
        '
        Me.buyeraddress.AutoSize = True
        Me.buyeraddress.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyeraddress.ForeColor = System.Drawing.Color.Black
        Me.buyeraddress.Location = New System.Drawing.Point(703, 112)
        Me.buyeraddress.Name = "buyeraddress"
        Me.buyeraddress.Size = New System.Drawing.Size(91, 24)
        Me.buyeraddress.TabIndex = 23
        Me.buyeraddress.Text = "Address"
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
        'byrlabel
        '
        Me.byrlabel.AutoSize = True
        Me.byrlabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.byrlabel.ForeColor = System.Drawing.Color.White
        Me.byrlabel.Location = New System.Drawing.Point(16, 27)
        Me.byrlabel.Name = "byrlabel"
        Me.byrlabel.Size = New System.Drawing.Size(112, 28)
        Me.byrlabel.TabIndex = 2
        Me.byrlabel.Text = "Buyer(s)"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Cross3)
        Me.Panel3.Controls.Add(Me.byrlabel)
        Me.Panel3.Location = New System.Drawing.Point(344, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 81)
        Me.Panel3.TabIndex = 21
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
        'Dashboardlabel
        '
        Me.Dashboardlabel.AutoSize = True
        Me.Dashboardlabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Dashboardlabel.ForeColor = System.Drawing.Color.Black
        Me.Dashboardlabel.Location = New System.Drawing.Point(95, 449)
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
        Me.Registrationlabel.Location = New System.Drawing.Point(95, 342)
        Me.Registrationlabel.Name = "Registrationlabel"
        Me.Registrationlabel.Size = New System.Drawing.Size(188, 28)
        Me.Registrationlabel.TabIndex = 12
        Me.Registrationlabel.Text = "Registration(s)"
        '
        'Propertylabel
        '
        Me.Propertylabel.AutoSize = True
        Me.Propertylabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Propertylabel.ForeColor = System.Drawing.Color.Black
        Me.Propertylabel.Location = New System.Drawing.Point(95, 243)
        Me.Propertylabel.Name = "Propertylabel"
        Me.Propertylabel.Size = New System.Drawing.Size(165, 28)
        Me.Propertylabel.TabIndex = 11
        Me.Propertylabel.Text = "Property(ies)"
        '
        'Sellerlable
        '
        Me.Sellerlable.AutoSize = True
        Me.Sellerlable.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sellerlable.ForeColor = System.Drawing.Color.Black
        Me.Sellerlable.Location = New System.Drawing.Point(95, 139)
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
        'PropertyPicture
        '
        Me.PropertyPicture.Image = CType(resources.GetObject("PropertyPicture.Image"), System.Drawing.Image)
        Me.PropertyPicture.Location = New System.Drawing.Point(0, 215)
        Me.PropertyPicture.Name = "PropertyPicture"
        Me.PropertyPicture.Size = New System.Drawing.Size(86, 81)
        Me.PropertyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PropertyPicture.TabIndex = 5
        Me.PropertyPicture.TabStop = False
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
        'BuyerName
        '
        Me.BuyerName.AutoSize = True
        Me.BuyerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BuyerName.ForeColor = System.Drawing.Color.Black
        Me.BuyerName.Location = New System.Drawing.Point(382, 112)
        Me.BuyerName.Name = "BuyerName"
        Me.BuyerName.Size = New System.Drawing.Size(68, 24)
        Me.BuyerName.TabIndex = 22
        Me.BuyerName.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Dashboardlabel)
        Me.Panel1.Controls.Add(Me.Registrationlabel)
        Me.Panel1.Controls.Add(Me.Propertylabel)
        Me.Panel1.Controls.Add(Me.Sellerlable)
        Me.Panel1.Controls.Add(Me.DashboardPicture)
        Me.Panel1.Controls.Add(Me.LogoutPicture)
        Me.Panel1.Controls.Add(Me.RegistrationPicture)
        Me.Panel1.Controls.Add(Me.PropertyPicture)
        Me.Panel1.Controls.Add(Me.SellerPicture)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 766)
        Me.Panel1.TabIndex = 20
        '
        'buyers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1317, 766)
        Me.Controls.Add(Me.Buyerslist)
        Me.Controls.Add(Me.BuyersDGV)
        Me.Controls.Add(Me.buyerResetBtn)
        Me.Controls.Add(Me.buyerDeleteBtn)
        Me.Controls.Add(Me.buyerUpdateBtn)
        Me.Controls.Add(Me.buyerSaveBtn)
        Me.Controls.Add(Me.BuyerBudgetTb)
        Me.Controls.Add(Me.BuyerDescripTb)
        Me.Controls.Add(Me.buyerTypeTb)
        Me.Controls.Add(Me.mobileTb)
        Me.Controls.Add(Me.BuyerAddressTb)
        Me.Controls.Add(Me.BuyerNameTb)
        Me.Controls.Add(Me.Budget)
        Me.Controls.Add(Me.buyerdesc)
        Me.Controls.Add(Me.buyerType)
        Me.Controls.Add(Me.mobile)
        Me.Controls.Add(Me.buyeraddress)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BuyerName)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "buyers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "buyer(s)"
        CType(Me.BuyersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DashboardPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoutPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buyerslist As Label
    Friend WithEvents BuyersDGV As DataGridView
    Friend WithEvents buyerResetBtn As Button
    Friend WithEvents buyerDeleteBtn As Button
    Friend WithEvents buyerUpdateBtn As Button
    Friend WithEvents buyerSaveBtn As Button
    Friend WithEvents BuyerBudgetTb As TextBox
    Friend WithEvents BuyerDescripTb As TextBox
    Friend WithEvents buyerTypeTb As TextBox
    Friend WithEvents mobileTb As TextBox
    Friend WithEvents BuyerAddressTb As TextBox
    Friend WithEvents BuyerNameTb As TextBox
    Friend WithEvents Budget As Label
    Friend WithEvents buyerdesc As Label
    Friend WithEvents buyerType As Label
    Friend WithEvents mobile As Label
    Friend WithEvents buyeraddress As Label
    Friend WithEvents Cross3 As Label
    Friend WithEvents byrlabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Remslabel As Label
    Friend WithEvents Dashboardlabel As Label
    Friend WithEvents Registrationlabel As Label
    Friend WithEvents Propertylabel As Label
    Friend WithEvents Sellerlable As Label
    Friend WithEvents DashboardPicture As PictureBox
    Friend WithEvents LogoutPicture As PictureBox
    Friend WithEvents RegistrationPicture As PictureBox
    Friend WithEvents PropertyPicture As PictureBox
    Friend WithEvents SellerPicture As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BuyerName As Label
    Friend WithEvents Panel1 As Panel
End Class
