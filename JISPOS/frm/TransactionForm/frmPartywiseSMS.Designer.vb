<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartywiseSMS
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
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.lblMsg = New System.Windows.Forms.Label
        Me.btnSend = New System.Windows.Forms.Button
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView
        Me.txtMsg = New System.Windows.Forms.TextBox
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbnPrefixAddress2 = New System.Windows.Forms.RadioButton
        Me.rbnInfixAddress2 = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress2 = New System.Windows.Forms.RadioButton
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtCustomerName = New System.Windows.Forms.TextBox
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
        Me.pnlOne = New System.Windows.Forms.Panel
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnPrefixAddress = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress = New System.Windows.Forms.RadioButton
        Me.rbnInfixAddress = New System.Windows.Forms.RadioButton
        Me.lblHeading = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress2 = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlthree.SuspendLayout()
        Me.pnlTwo.SuspendLayout()
        Me.pnlOne.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1184, 662)
        Me.pnlMain.TabIndex = 14
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblMsg)
        Me.pnlContent.Controls.Add(Me.btnSend)
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Controls.Add(Me.txtMsg)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 231)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 421)
        Me.pnlContent.TabIndex = 0
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(301, 308)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(50, 13)
        Me.lblMsg.TabIndex = 18
        Me.lblMsg.Text = "Message"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(673, 324)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(117, 40)
        Me.btnSend.TabIndex = 17
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(30, 7)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(1138, 284)
        Me.dgvCustomerSearch.TabIndex = 0
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(301, 324)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(366, 64)
        Me.txtMsg.TabIndex = 16
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.Panel2)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.Panel1)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.txtAddress2)
        Me.pnlHeader.Controls.Add(Me.txtAddress)
        Me.pnlHeader.Controls.Add(Me.lblAddress2)
        Me.pnlHeader.Controls.Add(Me.lblAddress)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 231)
        Me.pnlHeader.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbnPrefixAddress2)
        Me.Panel2.Controls.Add(Me.rbnInfixAddress2)
        Me.Panel2.Controls.Add(Me.rbnSuffixAddress2)
        Me.Panel2.Location = New System.Drawing.Point(728, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 19)
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
        Me.pnlToolBar.Controls.Add(Me.txtCustomerName)
        Me.pnlToolBar.Controls.Add(Me.pnlthree)
        Me.pnlToolBar.Controls.Add(Me.lblMailID)
        Me.pnlToolBar.Controls.Add(Me.txtMailId)
        Me.pnlToolBar.Controls.Add(Me.lblMobile)
        Me.pnlToolBar.Controls.Add(Me.txtMobile)
        Me.pnlToolBar.Controls.Add(Me.pnlTwo)
        Me.pnlToolBar.Controls.Add(Me.pnlOne)
        Me.pnlToolBar.Controls.Add(Me.lblCustomerName)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Location = New System.Drawing.Point(12, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(604, 165)
        Me.pnlToolBar.TabIndex = 0
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(7, 28)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(310, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'pnlthree
        '
        Me.pnlthree.Controls.Add(Me.rbnInfixMailId)
        Me.pnlthree.Controls.Add(Me.rbnSuffixMailId)
        Me.pnlthree.Controls.Add(Me.rbnPrefixMailId)
        Me.pnlthree.Location = New System.Drawing.Point(134, 104)
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
        Me.lblMailID.Location = New System.Drawing.Point(7, 108)
        Me.lblMailID.Name = "lblMailID"
        Me.lblMailID.Size = New System.Drawing.Size(51, 16)
        Me.lblMailID.TabIndex = 25
        Me.lblMailID.Text = "Mail Id"
        Me.lblMailID.Visible = False
        '
        'txtMailId
        '
        Me.txtMailId.Location = New System.Drawing.Point(7, 124)
        Me.txtMailId.Name = "txtMailId"
        Me.txtMailId.Size = New System.Drawing.Size(310, 20)
        Me.txtMailId.TabIndex = 0
        Me.txtMailId.Visible = False
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(7, 55)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(51, 16)
        Me.lblMobile.TabIndex = 20
        Me.lblMobile.Text = "Mobile"
        Me.lblMobile.Visible = False
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(7, 71)
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
        Me.pnlTwo.Location = New System.Drawing.Point(135, 53)
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
        'pnlOne
        '
        Me.pnlOne.Controls.Add(Me.rbnInfixCustomer)
        Me.pnlOne.Controls.Add(Me.rbnSuffixCustomer)
        Me.pnlOne.Controls.Add(Me.rbnPrefixCustomer)
        Me.pnlOne.Location = New System.Drawing.Point(135, 10)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(182, 20)
        Me.pnlOne.TabIndex = 0
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
        'rbnPrefixCustomer
        '
        Me.rbnPrefixCustomer.AutoSize = True
        Me.rbnPrefixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixCustomer.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixCustomer.Name = "rbnPrefixCustomer"
        Me.rbnPrefixCustomer.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixCustomer.TabIndex = 12
        Me.rbnPrefixCustomer.Text = "Prefix"
        Me.rbnPrefixCustomer.UseVisualStyleBackColor = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(7, 12)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(82, 16)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Party Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(424, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(352, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnPrefixAddress)
        Me.Panel1.Controls.Add(Me.rbnSuffixAddress)
        Me.Panel1.Controls.Add(Me.rbnInfixAddress)
        Me.Panel1.Location = New System.Drawing.Point(726, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 19)
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
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Partywise SMS  Sending"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(660, 118)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(272, 20)
        Me.txtAddress2.TabIndex = 26
        Me.txtAddress2.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(658, 73)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(272, 20)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Visible = False
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress2.Location = New System.Drawing.Point(662, 98)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(69, 16)
        Me.lblAddress2.TabIndex = 27
        Me.lblAddress2.Text = "Address 2"
        Me.lblAddress2.Visible = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(660, 53)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(69, 16)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address 1"
        Me.lblAddress.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM5"
        '
        'frmPartywiseSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPartywiseSMS"
        Me.Text = "Partywise SMS"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
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
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbnPrefixAddress2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixAddress2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress2 As System.Windows.Forms.RadioButton
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents pnlthree As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents lblMailID As System.Windows.Forms.Label
    Friend WithEvents txtMailId As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents pnlTwo As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbnPrefixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
End Class
