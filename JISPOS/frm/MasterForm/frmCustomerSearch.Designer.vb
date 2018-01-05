<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSearch
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView
        Me.PartyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PartyName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillingName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShortName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Person = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Designation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.btnView = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbnPrefixAddress2 = New System.Windows.Forms.RadioButton
        Me.rbnInfixAddress2 = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress2 = New System.Windows.Forms.RadioButton
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.pnlthree = New System.Windows.Forms.Panel
        Me.rbnInfixMailId = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMailId = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMailId = New System.Windows.Forms.RadioButton
        Me.lblMailID = New System.Windows.Forms.Label
        Me.txtMailId = New System.Windows.Forms.TextBox
        Me.lblMobile = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.pnlTwo = New System.Windows.Forms.Panel
        Me.rbnInfixMobile = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMobile = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMobile = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnPrefixAddress = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress = New System.Windows.Forms.RadioButton
        Me.rbnInfixAddress = New System.Windows.Forms.RadioButton
        Me.lblHeading = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblAddress2 = New System.Windows.Forms.Label
        Me.pnlOne = New System.Windows.Forms.Panel
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlthree.SuspendLayout()
        Me.pnlTwo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlOne.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1866, 1054)
        Me.pnlMain.TabIndex = 13
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 231)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1866, 813)
        Me.pnlContent.TabIndex = 0
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomerSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartyCode, Me.PartyName, Me.BillingName, Me.Address, Me.ShortName, Me.EmailId, Me.Person, Me.Department, Me.Designation, Me.ContactNo})
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(12, 6)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomerSearch.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(1758, 768)
        Me.dgvCustomerSearch.TabIndex = 0
        '
        'PartyCode
        '
        Me.PartyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PartyCode.HeaderText = "CODE"
        Me.PartyCode.Name = "PartyCode"
        Me.PartyCode.Width = 62
        '
        'PartyName
        '
        Me.PartyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PartyName.HeaderText = "PARTY NAME"
        Me.PartyName.Name = "PartyName"
        Me.PartyName.Width = 94
        '
        'BillingName
        '
        Me.BillingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BillingName.HeaderText = "BILLING NAME"
        Me.BillingName.Name = "BillingName"
        Me.BillingName.Width = 98
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Address.HeaderText = "ADDRESS"
        Me.Address.Name = "Address"
        Me.Address.Width = 84
        '
        'ShortName
        '
        Me.ShortName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ShortName.HeaderText = "SHORT NAME"
        Me.ShortName.Name = "ShortName"
        Me.ShortName.Width = 96
        '
        'EmailId
        '
        Me.EmailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EmailId.HeaderText = "EMailId"
        Me.EmailId.Name = "EmailId"
        Me.EmailId.Width = 67
        '
        'Person
        '
        Me.Person.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Person.DefaultCellStyle = DataGridViewCellStyle1
        Me.Person.HeaderText = "PERSON"
        Me.Person.Name = "Person"
        Me.Person.Width = 77
        '
        'Department
        '
        Me.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department.DefaultCellStyle = DataGridViewCellStyle2
        Me.Department.HeaderText = "DEPARTMENT"
        Me.Department.Name = "Department"
        Me.Department.Width = 107
        '
        'Designation
        '
        Me.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Designation.DefaultCellStyle = DataGridViewCellStyle3
        Me.Designation.HeaderText = "DESIGNATION"
        Me.Designation.Name = "Designation"
        Me.Designation.Width = 106
        '
        'ContactNo
        '
        Me.ContactNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContactNo.DefaultCellStyle = DataGridViewCellStyle4
        Me.ContactNo.HeaderText = "CONTACT NO"
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Width = 94
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 1044)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1866, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.btnView)
        Me.pnlHeader.Controls.Add(Me.ProgressBar1)
        Me.pnlHeader.Controls.Add(Me.rbnPrefixCustomer)
        Me.pnlHeader.Controls.Add(Me.Panel2)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.Panel1)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.txtAddress2)
        Me.pnlHeader.Controls.Add(Me.btnExit)
        Me.pnlHeader.Controls.Add(Me.txtAddress)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Controls.Add(Me.lblAddress2)
        Me.pnlHeader.Controls.Add(Me.pnlOne)
        Me.pnlHeader.Controls.Add(Me.lblAddress)
        Me.pnlHeader.Controls.Add(Me.lblCustomerName)
        Me.pnlHeader.Controls.Add(Me.CmbCustomerName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1866, 231)
        Me.pnlHeader.TabIndex = 0
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(963, 53)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 140
        Me.btnView.Text = "&Export"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 202)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1758, 23)
        Me.ProgressBar1.TabIndex = 153
        Me.ProgressBar1.Visible = False
        '
        'rbnPrefixCustomer
        '
        Me.rbnPrefixCustomer.AutoSize = True
        Me.rbnPrefixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixCustomer.Location = New System.Drawing.Point(1051, 155)
        Me.rbnPrefixCustomer.Name = "rbnPrefixCustomer"
        Me.rbnPrefixCustomer.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixCustomer.TabIndex = 12
        Me.rbnPrefixCustomer.Text = "Prefix"
        Me.rbnPrefixCustomer.UseVisualStyleBackColor = True
        Me.rbnPrefixCustomer.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbnPrefixAddress2)
        Me.Panel2.Controls.Add(Me.rbnInfixAddress2)
        Me.Panel2.Controls.Add(Me.rbnSuffixAddress2)
        Me.Panel2.Location = New System.Drawing.Point(1248, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(41, 19)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'rbnPrefixAddress2
        '
        Me.rbnPrefixAddress2.AutoSize = True
        Me.rbnPrefixAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixAddress2.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixAddress2.Name = "rbnPrefixAddress2"
        Me.rbnPrefixAddress2.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixAddress2.TabIndex = 28
        Me.rbnPrefixAddress2.Text = "Prefix"
        Me.rbnPrefixAddress2.UseVisualStyleBackColor = True
        '
        'rbnInfixAddress2
        '
        Me.rbnInfixAddress2.AutoSize = True
        Me.rbnInfixAddress2.Checked = True
        Me.rbnInfixAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixAddress2.Location = New System.Drawing.Point(72, 0)
        Me.rbnInfixAddress2.Name = "rbnInfixAddress2"
        Me.rbnInfixAddress2.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixAddress2.TabIndex = 29
        Me.rbnInfixAddress2.TabStop = True
        Me.rbnInfixAddress2.Text = "Infix"
        Me.rbnInfixAddress2.UseVisualStyleBackColor = True
        '
        'rbnSuffixAddress2
        '
        Me.rbnSuffixAddress2.AutoSize = True
        Me.rbnSuffixAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixAddress2.Location = New System.Drawing.Point(134, 0)
        Me.rbnSuffixAddress2.Name = "rbnSuffixAddress2"
        Me.rbnSuffixAddress2.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixAddress2.TabIndex = 30
        Me.rbnSuffixAddress2.Text = "Suffix"
        Me.rbnSuffixAddress2.UseVisualStyleBackColor = True
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.pnlthree)
        Me.pnlToolBar.Controls.Add(Me.lblMailID)
        Me.pnlToolBar.Controls.Add(Me.txtMailId)
        Me.pnlToolBar.Controls.Add(Me.lblMobile)
        Me.pnlToolBar.Controls.Add(Me.txtMobile)
        Me.pnlToolBar.Controls.Add(Me.pnlTwo)
        Me.pnlToolBar.Location = New System.Drawing.Point(12, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(327, 106)
        Me.pnlToolBar.TabIndex = 0
        Me.pnlToolBar.Visible = False
        '
        'pnlthree
        '
        Me.pnlthree.Controls.Add(Me.rbnInfixMailId)
        Me.pnlthree.Controls.Add(Me.rbnSuffixMailId)
        Me.pnlthree.Controls.Add(Me.rbnPrefixMailId)
        Me.pnlthree.Location = New System.Drawing.Point(130, 59)
        Me.pnlthree.Name = "pnlthree"
        Me.pnlthree.Size = New System.Drawing.Size(182, 20)
        Me.pnlthree.TabIndex = 2
        Me.pnlthree.Visible = False
        '
        'rbnInfixMailId
        '
        Me.rbnInfixMailId.AutoSize = True
        Me.rbnInfixMailId.Checked = True
        Me.rbnInfixMailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMailId.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixMailId.Name = "rbnInfixMailId"
        Me.rbnInfixMailId.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixMailId.TabIndex = 28
        Me.rbnInfixMailId.TabStop = True
        Me.rbnInfixMailId.Text = "Infix"
        Me.rbnInfixMailId.UseVisualStyleBackColor = True
        '
        'rbnSuffixMailId
        '
        Me.rbnSuffixMailId.AutoSize = True
        Me.rbnSuffixMailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMailId.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixMailId.Name = "rbnSuffixMailId"
        Me.rbnSuffixMailId.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixMailId.TabIndex = 29
        Me.rbnSuffixMailId.Text = "Suffix"
        Me.rbnSuffixMailId.UseVisualStyleBackColor = True
        '
        'rbnPrefixMailId
        '
        Me.rbnPrefixMailId.AutoSize = True
        Me.rbnPrefixMailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMailId.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMailId.Name = "rbnPrefixMailId"
        Me.rbnPrefixMailId.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixMailId.TabIndex = 27
        Me.rbnPrefixMailId.Text = "Prefix"
        Me.rbnPrefixMailId.UseVisualStyleBackColor = True
        '
        'lblMailID
        '
        Me.lblMailID.AutoSize = True
        Me.lblMailID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailID.Location = New System.Drawing.Point(3, 63)
        Me.lblMailID.Name = "lblMailID"
        Me.lblMailID.Size = New System.Drawing.Size(51, 16)
        Me.lblMailID.TabIndex = 25
        Me.lblMailID.Text = "Mail Id"
        Me.lblMailID.Visible = False
        '
        'txtMailId
        '
        Me.txtMailId.Location = New System.Drawing.Point(3, 79)
        Me.txtMailId.Name = "txtMailId"
        Me.txtMailId.Size = New System.Drawing.Size(310, 20)
        Me.txtMailId.TabIndex = 0
        Me.txtMailId.Visible = False
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(3, 10)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(51, 16)
        Me.lblMobile.TabIndex = 20
        Me.lblMobile.Text = "Mobile"
        Me.lblMobile.Visible = False
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(3, 26)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(310, 20)
        Me.txtMobile.TabIndex = 0
        Me.txtMobile.Visible = False
        '
        'pnlTwo
        '
        Me.pnlTwo.Controls.Add(Me.rbnInfixMobile)
        Me.pnlTwo.Controls.Add(Me.rbnSuffixMobile)
        Me.pnlTwo.Controls.Add(Me.rbnPrefixMobile)
        Me.pnlTwo.Location = New System.Drawing.Point(131, 8)
        Me.pnlTwo.Name = "pnlTwo"
        Me.pnlTwo.Size = New System.Drawing.Size(182, 20)
        Me.pnlTwo.TabIndex = 1
        Me.pnlTwo.Visible = False
        '
        'rbnInfixMobile
        '
        Me.rbnInfixMobile.AutoSize = True
        Me.rbnInfixMobile.Checked = True
        Me.rbnInfixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMobile.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixMobile.Name = "rbnInfixMobile"
        Me.rbnInfixMobile.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixMobile.TabIndex = 23
        Me.rbnInfixMobile.TabStop = True
        Me.rbnInfixMobile.Text = "Infix"
        Me.rbnInfixMobile.UseVisualStyleBackColor = True
        '
        'rbnSuffixMobile
        '
        Me.rbnSuffixMobile.AutoSize = True
        Me.rbnSuffixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMobile.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixMobile.Name = "rbnSuffixMobile"
        Me.rbnSuffixMobile.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixMobile.TabIndex = 24
        Me.rbnSuffixMobile.Text = "Suffix"
        Me.rbnSuffixMobile.UseVisualStyleBackColor = True
        '
        'rbnPrefixMobile
        '
        Me.rbnPrefixMobile.AutoSize = True
        Me.rbnPrefixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMobile.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMobile.Name = "rbnPrefixMobile"
        Me.rbnPrefixMobile.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixMobile.TabIndex = 22
        Me.rbnPrefixMobile.Text = "Prefix"
        Me.rbnPrefixMobile.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnPrefixAddress)
        Me.Panel1.Controls.Add(Me.rbnSuffixAddress)
        Me.Panel1.Controls.Add(Me.rbnInfixAddress)
        Me.Panel1.Location = New System.Drawing.Point(1246, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(43, 19)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'rbnPrefixAddress
        '
        Me.rbnPrefixAddress.AutoSize = True
        Me.rbnPrefixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixAddress.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixAddress.Name = "rbnPrefixAddress"
        Me.rbnPrefixAddress.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixAddress.TabIndex = 7
        Me.rbnPrefixAddress.Text = "Prefix"
        Me.rbnPrefixAddress.UseVisualStyleBackColor = True
        '
        'rbnSuffixAddress
        '
        Me.rbnSuffixAddress.AutoSize = True
        Me.rbnSuffixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixAddress.Location = New System.Drawing.Point(134, 0)
        Me.rbnSuffixAddress.Name = "rbnSuffixAddress"
        Me.rbnSuffixAddress.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixAddress.TabIndex = 9
        Me.rbnSuffixAddress.Text = "Suffix"
        Me.rbnSuffixAddress.UseVisualStyleBackColor = True
        '
        'rbnInfixAddress
        '
        Me.rbnInfixAddress.AutoSize = True
        Me.rbnInfixAddress.Checked = True
        Me.rbnInfixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixAddress.Location = New System.Drawing.Point(72, 0)
        Me.rbnInfixAddress.Name = "rbnInfixAddress"
        Me.rbnInfixAddress.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixAddress.TabIndex = 8
        Me.rbnInfixAddress.TabStop = True
        Me.rbnInfixAddress.Text = "Infix"
        Me.rbnInfixAddress.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1866, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Party  Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(1180, 200)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(109, 20)
        Me.txtAddress2.TabIndex = 26
        Me.txtAddress2.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1037, 53)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(1178, 155)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(109, 20)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(889, 53)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress2.Location = New System.Drawing.Point(1182, 180)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(69, 16)
        Me.lblAddress2.TabIndex = 27
        Me.lblAddress2.Text = "Address 2"
        Me.lblAddress2.Visible = False
        '
        'pnlOne
        '
        Me.pnlOne.Controls.Add(Me.rbnInfixCustomer)
        Me.pnlOne.Controls.Add(Me.rbnSuffixCustomer)
        Me.pnlOne.Location = New System.Drawing.Point(765, 68)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(47, 20)
        Me.pnlOne.TabIndex = 0
        Me.pnlOne.Visible = False
        '
        'rbnInfixCustomer
        '
        Me.rbnInfixCustomer.AutoSize = True
        Me.rbnInfixCustomer.Checked = True
        Me.rbnInfixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixCustomer.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixCustomer.Name = "rbnInfixCustomer"
        Me.rbnInfixCustomer.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixCustomer.TabIndex = 13
        Me.rbnInfixCustomer.TabStop = True
        Me.rbnInfixCustomer.Text = "Infix"
        Me.rbnInfixCustomer.UseVisualStyleBackColor = True
        '
        'rbnSuffixCustomer
        '
        Me.rbnSuffixCustomer.AutoSize = True
        Me.rbnSuffixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixCustomer.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixCustomer.Name = "rbnSuffixCustomer"
        Me.rbnSuffixCustomer.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixCustomer.TabIndex = 14
        Me.rbnSuffixCustomer.Text = "Suffix"
        Me.rbnSuffixCustomer.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(1180, 135)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(69, 16)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address 1"
        Me.lblAddress.Visible = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(549, 55)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(82, 16)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Party Name"
        '
        'CmbCustomerName
        '
        Me.CmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbCustomerName.FormattingEnabled = True
        Me.CmbCustomerName.Location = New System.Drawing.Point(552, 74)
        Me.CmbCustomerName.Name = "CmbCustomerName"
        Me.CmbCustomerName.Size = New System.Drawing.Size(310, 21)
        Me.CmbCustomerName.TabIndex = 28
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'frmCustomerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1866, 1054)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmCustomerSearch"
        Me.Text = "Party Search"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlthree.ResumeLayout(False)
        Me.pnlthree.PerformLayout()
        Me.pnlTwo.ResumeLayout(False)
        Me.pnlTwo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents rbnInfixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents pnlthree As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents txtMailId As System.Windows.Forms.TextBox
    Friend WithEvents lblMailID As System.Windows.Forms.Label
    Friend WithEvents pnlTwo As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents rbnInfixAddress2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixAddress2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents PartyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillingName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShortName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Designation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
