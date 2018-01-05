<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnSearch1 = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.txtShortName = New System.Windows.Forms.TextBox
        Me.lblShortName = New System.Windows.Forms.Label
        Me.cmbCountGroup = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMobileNo4 = New System.Windows.Forms.TextBox
        Me.txtMobileNo3 = New System.Windows.Forms.TextBox
        Me.txtMobileNo2 = New System.Windows.Forms.TextBox
        Me.lblMobileNo1 = New System.Windows.Forms.Label
        Me.txtMobileNo1 = New System.Windows.Forms.TextBox
        Me.txtPerson4 = New System.Windows.Forms.TextBox
        Me.txtPerson3 = New System.Windows.Forms.TextBox
        Me.txtPerson2 = New System.Windows.Forms.TextBox
        Me.lblPerson1 = New System.Windows.Forms.Label
        Me.txtPerson1 = New System.Windows.Forms.TextBox
        Me.lblDueDays = New System.Windows.Forms.Label
        Me.txtDueDays = New System.Windows.Forms.TextBox
        Me.lblSupplierName = New System.Windows.Forms.Label
        Me.txtSupplierName = New System.Windows.Forms.TextBox
        Me.lblEmailId = New System.Windows.Forms.Label
        Me.txtEmailId = New System.Windows.Forms.TextBox
        Me.lblMillId = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtAddressLine = New System.Windows.Forms.TextBox
        Me.LinkParty = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBillingName = New System.Windows.Forms.TextBox
        Me.lblBillingName = New System.Windows.Forms.Label
        Me.lblCPNo1 = New System.Windows.Forms.Label
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.lblPhNo = New System.Windows.Forms.Label
        Me.txtPhNo = New System.Windows.Forms.TextBox
        Me.lblAddressLine2 = New System.Windows.Forms.Label
        Me.txtAddressline2 = New System.Windows.Forms.TextBox
        Me.txtTinNo = New System.Windows.Forms.TextBox
        Me.txtCST = New System.Windows.Forms.TextBox
        Me.lblCPName1 = New System.Windows.Forms.Label
        Me.lblOpBal = New System.Windows.Forms.Label
        Me.lblTin = New System.Windows.Forms.Label
        Me.txtOpBal = New System.Windows.Forms.TextBox
        Me.txtDepartment4 = New System.Windows.Forms.TextBox
        Me.txtDepartment3 = New System.Windows.Forms.TextBox
        Me.txtDepartment2 = New System.Windows.Forms.TextBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.txtDepartment1 = New System.Windows.Forms.TextBox
        Me.txtDesignation4 = New System.Windows.Forms.TextBox
        Me.txtDesignation3 = New System.Windows.Forms.TextBox
        Me.txtDesignation2 = New System.Windows.Forms.TextBox
        Me.lblDesignation = New System.Windows.Forms.Label
        Me.txtDesignation1 = New System.Windows.Forms.TextBox
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(751, 58)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(98, 22)
        Me.txtSearchBox.TabIndex = 3
        Me.txtSearchBox.Visible = False
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 730)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1263, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1263, 107)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnSearch1)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Location = New System.Drawing.Point(23, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(471, 56)
        Me.pnlToolBar.TabIndex = 0
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(380, 3)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch1.TabIndex = 5
        Me.btnSearch1.Text = "SEARC&H"
        Me.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.JISPOS.My.Resources.Resources.adds35
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(12, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 49)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.JISPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(86, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(306, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.JISPOS.My.Resources.Resources.delete35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(160, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(232, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = " &VIEW"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1263, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Mill"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(679, 45)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1263, 740)
        Me.pnlMain.TabIndex = 7
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Controls.Add(Me.txtBillingName)
        Me.pnlContent.Controls.Add(Me.lblBillingName)
        Me.pnlContent.Controls.Add(Me.lblCPNo1)
        Me.pnlContent.Controls.Add(Me.txtMobileNo)
        Me.pnlContent.Controls.Add(Me.lblPhNo)
        Me.pnlContent.Controls.Add(Me.txtPhNo)
        Me.pnlContent.Controls.Add(Me.lblAddressLine2)
        Me.pnlContent.Controls.Add(Me.txtAddressline2)
        Me.pnlContent.Controls.Add(Me.txtTinNo)
        Me.pnlContent.Controls.Add(Me.txtCST)
        Me.pnlContent.Controls.Add(Me.lblCPName1)
        Me.pnlContent.Controls.Add(Me.lblOpBal)
        Me.pnlContent.Controls.Add(Me.lblTin)
        Me.pnlContent.Controls.Add(Me.txtOpBal)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1263, 623)
        Me.pnlContent.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.cmbCountGroup)
        Me.pnlForm.Controls.Add(Me.txtDepartment4)
        Me.pnlForm.Controls.Add(Me.txtDepartment3)
        Me.pnlForm.Controls.Add(Me.txtDepartment2)
        Me.pnlForm.Controls.Add(Me.lblDepartment)
        Me.pnlForm.Controls.Add(Me.txtDepartment1)
        Me.pnlForm.Controls.Add(Me.txtShortName)
        Me.pnlForm.Controls.Add(Me.lblShortName)
        Me.pnlForm.Controls.Add(Me.Label2)
        Me.pnlForm.Controls.Add(Me.txtPerson4)
        Me.pnlForm.Controls.Add(Me.txtPerson3)
        Me.pnlForm.Controls.Add(Me.txtPerson2)
        Me.pnlForm.Controls.Add(Me.lblPerson1)
        Me.pnlForm.Controls.Add(Me.txtPerson1)
        Me.pnlForm.Controls.Add(Me.lblDueDays)
        Me.pnlForm.Controls.Add(Me.txtDueDays)
        Me.pnlForm.Controls.Add(Me.lblSupplierName)
        Me.pnlForm.Controls.Add(Me.txtSupplierName)
        Me.pnlForm.Controls.Add(Me.lblEmailId)
        Me.pnlForm.Controls.Add(Me.txtEmailId)
        Me.pnlForm.Controls.Add(Me.lblMillId)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Controls.Add(Me.lblAddress)
        Me.pnlForm.Controls.Add(Me.txtAddressLine)
        Me.pnlForm.Controls.Add(Me.LinkParty)
        Me.pnlForm.Controls.Add(Me.Label1)
        Me.pnlForm.Controls.Add(Me.lblDesignation)
        Me.pnlForm.Controls.Add(Me.txtDesignation1)
        Me.pnlForm.Controls.Add(Me.txtDesignation2)
        Me.pnlForm.Controls.Add(Me.txtDesignation3)
        Me.pnlForm.Controls.Add(Me.txtDesignation4)
        Me.pnlForm.Controls.Add(Me.lblMobileNo1)
        Me.pnlForm.Controls.Add(Me.txtMobileNo1)
        Me.pnlForm.Controls.Add(Me.txtMobileNo2)
        Me.pnlForm.Controls.Add(Me.txtMobileNo3)
        Me.pnlForm.Controls.Add(Me.txtMobileNo4)
        Me.pnlForm.Location = New System.Drawing.Point(67, 25)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1064, 435)
        Me.pnlForm.TabIndex = 0
        '
        'txtShortName
        '
        Me.txtShortName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortName.Location = New System.Drawing.Point(161, 57)
        Me.txtShortName.MaxLength = 100
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(231, 22)
        Me.txtShortName.TabIndex = 5
        '
        'lblShortName
        '
        Me.lblShortName.AutoSize = True
        Me.lblShortName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortName.Location = New System.Drawing.Point(42, 57)
        Me.lblShortName.Name = "lblShortName"
        Me.lblShortName.Size = New System.Drawing.Size(83, 16)
        Me.lblShortName.TabIndex = 4
        Me.lblShortName.Text = "Short Name"
        '
        'cmbCountGroup
        '
        Me.cmbCountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCountGroup.FormattingEnabled = True
        Me.cmbCountGroup.Items.AddRange(New Object() {"PSF-1", "PSF-2", "PC WARP-1", "PC WARP-2", "PC WARP-3", "PC WEFT-1", "PC WEFT-2", "PC WEFT-3", "COMBED-1", "COMBED-2", "KARDED-1", "KARDED-2", "KARDED-3", "OE-1", "OE-2", "PV-1", "PV-2", "SHEWING-1", "SHEWING-2", "GENERAL-1", "GENERAL-2"})
        Me.cmbCountGroup.Location = New System.Drawing.Point(686, 157)
        Me.cmbCountGroup.Name = "cmbCountGroup"
        Me.cmbCountGroup.Size = New System.Drawing.Size(231, 21)
        Me.cmbCountGroup.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "COUNT GROUP"
        '
        'txtMobileNo4
        '
        Me.txtMobileNo4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo4.Location = New System.Drawing.Point(741, 311)
        Me.txtMobileNo4.MaxLength = 100
        Me.txtMobileNo4.Name = "txtMobileNo4"
        Me.txtMobileNo4.Size = New System.Drawing.Size(218, 22)
        Me.txtMobileNo4.TabIndex = 30
        '
        'txtMobileNo3
        '
        Me.txtMobileNo3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo3.Location = New System.Drawing.Point(741, 289)
        Me.txtMobileNo3.MaxLength = 100
        Me.txtMobileNo3.Name = "txtMobileNo3"
        Me.txtMobileNo3.Size = New System.Drawing.Size(218, 22)
        Me.txtMobileNo3.TabIndex = 26
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.Location = New System.Drawing.Point(741, 267)
        Me.txtMobileNo2.MaxLength = 100
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(218, 22)
        Me.txtMobileNo2.TabIndex = 22
        '
        'lblMobileNo1
        '
        Me.lblMobileNo1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo1.Location = New System.Drawing.Point(741, 226)
        Me.lblMobileNo1.Name = "lblMobileNo1"
        Me.lblMobileNo1.Size = New System.Drawing.Size(218, 16)
        Me.lblMobileNo1.TabIndex = 33
        Me.lblMobileNo1.Tag = "Heading"
        Me.lblMobileNo1.Text = "Mobile No "
        Me.lblMobileNo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMobileNo1
        '
        Me.txtMobileNo1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo1.Location = New System.Drawing.Point(741, 245)
        Me.txtMobileNo1.MaxLength = 100
        Me.txtMobileNo1.Name = "txtMobileNo1"
        Me.txtMobileNo1.Size = New System.Drawing.Size(218, 22)
        Me.txtMobileNo1.TabIndex = 18
        '
        'txtPerson4
        '
        Me.txtPerson4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson4.Location = New System.Drawing.Point(39, 311)
        Me.txtPerson4.MaxLength = 100
        Me.txtPerson4.Name = "txtPerson4"
        Me.txtPerson4.Size = New System.Drawing.Size(218, 22)
        Me.txtPerson4.TabIndex = 27
        '
        'txtPerson3
        '
        Me.txtPerson3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson3.Location = New System.Drawing.Point(39, 289)
        Me.txtPerson3.MaxLength = 100
        Me.txtPerson3.Name = "txtPerson3"
        Me.txtPerson3.Size = New System.Drawing.Size(218, 22)
        Me.txtPerson3.TabIndex = 23
        '
        'txtPerson2
        '
        Me.txtPerson2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson2.Location = New System.Drawing.Point(39, 267)
        Me.txtPerson2.MaxLength = 100
        Me.txtPerson2.Name = "txtPerson2"
        Me.txtPerson2.Size = New System.Drawing.Size(218, 22)
        Me.txtPerson2.TabIndex = 19
        '
        'lblPerson1
        '
        Me.lblPerson1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson1.Location = New System.Drawing.Point(39, 226)
        Me.lblPerson1.Name = "lblPerson1"
        Me.lblPerson1.Size = New System.Drawing.Size(218, 16)
        Me.lblPerson1.TabIndex = 14
        Me.lblPerson1.Tag = "Heading"
        Me.lblPerson1.Text = "Person"
        Me.lblPerson1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPerson1
        '
        Me.txtPerson1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson1.Location = New System.Drawing.Point(39, 245)
        Me.txtPerson1.MaxLength = 100
        Me.txtPerson1.Name = "txtPerson1"
        Me.txtPerson1.Size = New System.Drawing.Size(218, 22)
        Me.txtPerson1.TabIndex = 15
        '
        'lblDueDays
        '
        Me.lblDueDays.AutoSize = True
        Me.lblDueDays.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDays.Location = New System.Drawing.Point(42, 156)
        Me.lblDueDays.Name = "lblDueDays"
        Me.lblDueDays.Size = New System.Drawing.Size(67, 16)
        Me.lblDueDays.TabIndex = 10
        Me.lblDueDays.Text = "Due Days"
        Me.lblDueDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDueDays
        '
        Me.txtDueDays.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDays.Location = New System.Drawing.Point(161, 153)
        Me.txtDueDays.MaxLength = 100
        Me.txtDueDays.Name = "txtDueDays"
        Me.txtDueDays.Size = New System.Drawing.Size(403, 22)
        Me.txtDueDays.TabIndex = 11
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierName.Location = New System.Drawing.Point(401, 25)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(72, 16)
        Me.lblSupplierName.TabIndex = 2
        Me.lblSupplierName.Text = "Mill Name"
        Me.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSupplierName
        '
        Me.txtSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSupplierName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName.Location = New System.Drawing.Point(517, 22)
        Me.txtSupplierName.MaxLength = 100
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(401, 22)
        Me.txtSupplierName.TabIndex = 3
        '
        'lblEmailId
        '
        Me.lblEmailId.AutoSize = True
        Me.lblEmailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailId.Location = New System.Drawing.Point(42, 126)
        Me.lblEmailId.Name = "lblEmailId"
        Me.lblEmailId.Size = New System.Drawing.Size(60, 16)
        Me.lblEmailId.TabIndex = 8
        Me.lblEmailId.Text = "Email Id"
        Me.lblEmailId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmailId
        '
        Me.txtEmailId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailId.Location = New System.Drawing.Point(161, 123)
        Me.txtEmailId.MaxLength = 0
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(757, 22)
        Me.txtEmailId.TabIndex = 9
        '
        'lblMillId
        '
        Me.lblMillId.AutoSize = True
        Me.lblMillId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillId.Location = New System.Drawing.Point(42, 25)
        Me.lblMillId.Name = "lblMillId"
        Me.lblMillId.Size = New System.Drawing.Size(51, 16)
        Me.lblMillId.TabIndex = 0
        Me.lblMillId.Text = "Mill  Id"
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(161, 22)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(231, 22)
        Me.txtCode.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(161, 22)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(231, 22)
        Me.txtId.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(401, 57)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddressLine
        '
        Me.txtAddressLine.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine.Location = New System.Drawing.Point(517, 55)
        Me.txtAddressLine.MaxLength = 300
        Me.txtAddressLine.Multiline = True
        Me.txtAddressLine.Name = "txtAddressLine"
        Me.txtAddressLine.Size = New System.Drawing.Size(401, 60)
        Me.txtAddressLine.TabIndex = 7
        '
        'LinkParty
        '
        Me.LinkParty.BackColor = System.Drawing.Color.White
        Me.LinkParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LinkParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LinkParty.Location = New System.Drawing.Point(708, -20)
        Me.LinkParty.Name = "LinkParty"
        Me.LinkParty.Size = New System.Drawing.Size(20, 20)
        Me.LinkParty.TabIndex = 23
        Me.LinkParty.TabStop = False
        Me.LinkParty.Text = "..."
        Me.LinkParty.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, -18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " C&ustomer Name"
        '
        'txtBillingName
        '
        Me.txtBillingName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBillingName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBillingName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingName.Location = New System.Drawing.Point(579, 509)
        Me.txtBillingName.MaxLength = 100
        Me.txtBillingName.Name = "txtBillingName"
        Me.txtBillingName.Size = New System.Drawing.Size(231, 22)
        Me.txtBillingName.TabIndex = 8
        Me.txtBillingName.Visible = False
        '
        'lblBillingName
        '
        Me.lblBillingName.AutoSize = True
        Me.lblBillingName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingName.Location = New System.Drawing.Point(471, 512)
        Me.lblBillingName.Name = "lblBillingName"
        Me.lblBillingName.Size = New System.Drawing.Size(94, 16)
        Me.lblBillingName.TabIndex = 7
        Me.lblBillingName.Text = "Ledger Name"
        Me.lblBillingName.Visible = False
        '
        'lblCPNo1
        '
        Me.lblCPNo1.AutoSize = True
        Me.lblCPNo1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPNo1.Location = New System.Drawing.Point(453, 469)
        Me.lblCPNo1.Name = "lblCPNo1"
        Me.lblCPNo1.Size = New System.Drawing.Size(112, 16)
        Me.lblCPNo1.TabIndex = 5
        Me.lblCPNo1.Text = "Mobile Number1"
        Me.lblCPNo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCPNo1.Visible = False
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(569, 466)
        Me.txtMobileNo.MaxLength = 30
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(231, 22)
        Me.txtMobileNo.TabIndex = 6
        Me.txtMobileNo.Visible = False
        '
        'lblPhNo
        '
        Me.lblPhNo.AutoSize = True
        Me.lblPhNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhNo.Location = New System.Drawing.Point(410, 563)
        Me.lblPhNo.Name = "lblPhNo"
        Me.lblPhNo.Size = New System.Drawing.Size(100, 16)
        Me.lblPhNo.TabIndex = 11
        Me.lblPhNo.Text = "Telephone No."
        Me.lblPhNo.Visible = False
        '
        'txtPhNo
        '
        Me.txtPhNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhNo.Location = New System.Drawing.Point(526, 560)
        Me.txtPhNo.MaxLength = 15
        Me.txtPhNo.Name = "txtPhNo"
        Me.txtPhNo.Size = New System.Drawing.Size(231, 22)
        Me.txtPhNo.TabIndex = 12
        Me.txtPhNo.Visible = False
        '
        'lblAddressLine2
        '
        Me.lblAddressLine2.AutoSize = True
        Me.lblAddressLine2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressLine2.Location = New System.Drawing.Point(90, 526)
        Me.lblAddressLine2.Name = "lblAddressLine2"
        Me.lblAddressLine2.Size = New System.Drawing.Size(101, 16)
        Me.lblAddressLine2.TabIndex = 3
        Me.lblAddressLine2.Text = "Address Line 2"
        Me.lblAddressLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddressLine2.Visible = False
        '
        'txtAddressline2
        '
        Me.txtAddressline2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressline2.Location = New System.Drawing.Point(209, 523)
        Me.txtAddressline2.MaxLength = 300
        Me.txtAddressline2.Name = "txtAddressline2"
        Me.txtAddressline2.Size = New System.Drawing.Size(231, 22)
        Me.txtAddressline2.TabIndex = 4
        Me.txtAddressline2.Visible = False
        '
        'txtTinNo
        '
        Me.txtTinNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinNo.Location = New System.Drawing.Point(320, 582)
        Me.txtTinNo.MaxLength = 75
        Me.txtTinNo.Name = "txtTinNo"
        Me.txtTinNo.Size = New System.Drawing.Size(231, 22)
        Me.txtTinNo.TabIndex = 10
        Me.txtTinNo.Visible = False
        '
        'txtCST
        '
        Me.txtCST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCST.Location = New System.Drawing.Point(676, 582)
        Me.txtCST.MaxLength = 100
        Me.txtCST.Name = "txtCST"
        Me.txtCST.Size = New System.Drawing.Size(231, 22)
        Me.txtCST.TabIndex = 14
        Me.txtCST.Visible = False
        '
        'lblCPName1
        '
        Me.lblCPName1.AutoSize = True
        Me.lblCPName1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPName1.Location = New System.Drawing.Point(560, 585)
        Me.lblCPName1.Name = "lblCPName1"
        Me.lblCPName1.Size = New System.Drawing.Size(34, 16)
        Me.lblCPName1.TabIndex = 13
        Me.lblCPName1.Text = "CST"
        Me.lblCPName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCPName1.Visible = False
        '
        'lblOpBal
        '
        Me.lblOpBal.AutoSize = True
        Me.lblOpBal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpBal.Location = New System.Drawing.Point(80, 488)
        Me.lblOpBal.Name = "lblOpBal"
        Me.lblOpBal.Size = New System.Drawing.Size(118, 16)
        Me.lblOpBal.TabIndex = 1
        Me.lblOpBal.Text = "Opening Balance"
        Me.lblOpBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOpBal.Visible = False
        '
        'lblTin
        '
        Me.lblTin.AutoSize = True
        Me.lblTin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTin.Location = New System.Drawing.Point(201, 585)
        Me.lblTin.Name = "lblTin"
        Me.lblTin.Size = New System.Drawing.Size(29, 16)
        Me.lblTin.TabIndex = 9
        Me.lblTin.Text = "TIN"
        Me.lblTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTin.Visible = False
        '
        'txtOpBal
        '
        Me.txtOpBal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpBal.Location = New System.Drawing.Point(199, 485)
        Me.txtOpBal.MaxLength = 100
        Me.txtOpBal.Name = "txtOpBal"
        Me.txtOpBal.Size = New System.Drawing.Size(231, 22)
        Me.txtOpBal.TabIndex = 2
        Me.txtOpBal.Visible = False
        '
        'txtDepartment4
        '
        Me.txtDepartment4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment4.Location = New System.Drawing.Point(273, 311)
        Me.txtDepartment4.MaxLength = 100
        Me.txtDepartment4.Name = "txtDepartment4"
        Me.txtDepartment4.Size = New System.Drawing.Size(218, 22)
        Me.txtDepartment4.TabIndex = 28
        '
        'txtDepartment3
        '
        Me.txtDepartment3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment3.Location = New System.Drawing.Point(273, 289)
        Me.txtDepartment3.MaxLength = 100
        Me.txtDepartment3.Name = "txtDepartment3"
        Me.txtDepartment3.Size = New System.Drawing.Size(218, 22)
        Me.txtDepartment3.TabIndex = 24
        '
        'txtDepartment2
        '
        Me.txtDepartment2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment2.Location = New System.Drawing.Point(273, 267)
        Me.txtDepartment2.MaxLength = 100
        Me.txtDepartment2.Name = "txtDepartment2"
        Me.txtDepartment2.Size = New System.Drawing.Size(218, 22)
        Me.txtDepartment2.TabIndex = 20
        '
        'lblDepartment
        '
        Me.lblDepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(273, 226)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(218, 16)
        Me.lblDepartment.TabIndex = 31
        Me.lblDepartment.Tag = "Heading"
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDepartment1
        '
        Me.txtDepartment1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment1.Location = New System.Drawing.Point(273, 245)
        Me.txtDepartment1.MaxLength = 100
        Me.txtDepartment1.Name = "txtDepartment1"
        Me.txtDepartment1.Size = New System.Drawing.Size(218, 22)
        Me.txtDepartment1.TabIndex = 16
        '
        'txtDesignation4
        '
        Me.txtDesignation4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation4.Location = New System.Drawing.Point(507, 311)
        Me.txtDesignation4.MaxLength = 100
        Me.txtDesignation4.Name = "txtDesignation4"
        Me.txtDesignation4.Size = New System.Drawing.Size(218, 22)
        Me.txtDesignation4.TabIndex = 29
        '
        'txtDesignation3
        '
        Me.txtDesignation3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation3.Location = New System.Drawing.Point(507, 289)
        Me.txtDesignation3.MaxLength = 100
        Me.txtDesignation3.Name = "txtDesignation3"
        Me.txtDesignation3.Size = New System.Drawing.Size(218, 22)
        Me.txtDesignation3.TabIndex = 25
        '
        'txtDesignation2
        '
        Me.txtDesignation2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation2.Location = New System.Drawing.Point(507, 267)
        Me.txtDesignation2.MaxLength = 100
        Me.txtDesignation2.Name = "txtDesignation2"
        Me.txtDesignation2.Size = New System.Drawing.Size(218, 22)
        Me.txtDesignation2.TabIndex = 21
        '
        'lblDesignation
        '
        Me.lblDesignation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignation.Location = New System.Drawing.Point(507, 226)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(218, 16)
        Me.lblDesignation.TabIndex = 32
        Me.lblDesignation.Tag = "Heading"
        Me.lblDesignation.Text = "Designation"
        Me.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDesignation1
        '
        Me.txtDesignation1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation1.Location = New System.Drawing.Point(507, 245)
        Me.txtDesignation1.MaxLength = 100
        Me.txtDesignation1.Name = "txtDesignation1"
        Me.txtDesignation1.Size = New System.Drawing.Size(218, 22)
        Me.txtDesignation1.TabIndex = 17
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 740)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmSuppliers"
        Me.Text = "MILL"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents LinkParty As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailId As System.Windows.Forms.Label
    Friend WithEvents txtEmailId As System.Windows.Forms.TextBox
    Friend WithEvents lblTin As System.Windows.Forms.Label
    Friend WithEvents txtTinNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBillingName As System.Windows.Forms.TextBox
    Friend WithEvents lblBillingName As System.Windows.Forms.Label
    Friend WithEvents lblMillId As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblPhNo As System.Windows.Forms.Label
    Friend WithEvents txtPhNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCPName1 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCPNo1 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine As System.Windows.Forms.TextBox
    Friend WithEvents txtCST As System.Windows.Forms.TextBox
    Friend WithEvents lblAddressLine2 As System.Windows.Forms.Label
    Friend WithEvents txtAddressline2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDueDays As System.Windows.Forms.Label
    Friend WithEvents txtDueDays As System.Windows.Forms.TextBox
    Friend WithEvents lblOpBal As System.Windows.Forms.Label
    Friend WithEvents txtOpBal As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo4 As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMobileNo1 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPerson4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPerson3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPerson2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPerson1 As System.Windows.Forms.Label
    Friend WithEvents txtPerson1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCountGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblShortName As System.Windows.Forms.Label
    Friend WithEvents txtShortName As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents txtDesignation1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtDepartment1 As System.Windows.Forms.TextBox
End Class
