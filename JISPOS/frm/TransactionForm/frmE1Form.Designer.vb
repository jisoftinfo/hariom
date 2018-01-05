<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmE1Form
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
        Me.cmbBillingName = New System.Windows.Forms.ComboBox
        Me.lblBillingName = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbnPrefixMill = New System.Windows.Forms.RadioButton
        Me.rbnInfixMill = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMill = New System.Windows.Forms.RadioButton
        Me.lblYear = New System.Windows.Forms.Label
        Me.rbnPrefixBillingName = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rbnInfixBillingName = New System.Windows.Forms.RadioButton
        Me.rbnSuffixBillingName = New System.Windows.Forms.RadioButton
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnPrefixParty = New System.Windows.Forms.RadioButton
        Me.rbnInfixParty = New System.Windows.Forms.RadioButton
        Me.rbnSuffixParty = New System.Windows.Forms.RadioButton
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.cmbPartyName = New System.Windows.Forms.ComboBox
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.lblMillName = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgvCFormMon = New System.Windows.Forms.DataGridView
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblPartyName = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.gbxDisplay = New System.Windows.Forms.GroupBox
        Me.rbnSummary = New System.Windows.Forms.RadioButton
        Me.rbnDetails = New System.Windows.Forms.RadioButton
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.lblCFormRecvStatus = New System.Windows.Forms.Label
        Me.cmbCFormRecv = New System.Windows.Forms.ComboBox
        Me.lblHeading = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.dgvCFormQua = New System.Windows.Forms.DataGridView
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.cmbCountGroup = New System.Windows.Forms.ComboBox
        Me.lblCountGroup = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCFormMon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDisplay.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvCFormQua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbBillingName
        '
        Me.cmbBillingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbBillingName.FormattingEnabled = True
        Me.cmbBillingName.Location = New System.Drawing.Point(462, 26)
        Me.cmbBillingName.Name = "cmbBillingName"
        Me.cmbBillingName.Size = New System.Drawing.Size(263, 20)
        Me.cmbBillingName.TabIndex = 156
        '
        'lblBillingName
        '
        Me.lblBillingName.AutoSize = True
        Me.lblBillingName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingName.Location = New System.Drawing.Point(462, 7)
        Me.lblBillingName.Name = "lblBillingName"
        Me.lblBillingName.Size = New System.Drawing.Size(90, 16)
        Me.lblBillingName.TabIndex = 155
        Me.lblBillingName.Text = "Billing Name"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbnPrefixMill)
        Me.Panel2.Controls.Add(Me.rbnInfixMill)
        Me.Panel2.Controls.Add(Me.rbnSuffixMill)
        Me.Panel2.Location = New System.Drawing.Point(1051, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 24)
        Me.Panel2.TabIndex = 151
        '
        'rbnPrefixMill
        '
        Me.rbnPrefixMill.AutoSize = True
        Me.rbnPrefixMill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnPrefixMill.Location = New System.Drawing.Point(11, 4)
        Me.rbnPrefixMill.Name = "rbnPrefixMill"
        Me.rbnPrefixMill.Size = New System.Drawing.Size(59, 19)
        Me.rbnPrefixMill.TabIndex = 142
        Me.rbnPrefixMill.Text = "Prefix"
        Me.rbnPrefixMill.UseVisualStyleBackColor = True
        '
        'rbnInfixMill
        '
        Me.rbnInfixMill.AutoSize = True
        Me.rbnInfixMill.Checked = True
        Me.rbnInfixMill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMill.Location = New System.Drawing.Point(70, 4)
        Me.rbnInfixMill.Name = "rbnInfixMill"
        Me.rbnInfixMill.Size = New System.Drawing.Size(50, 19)
        Me.rbnInfixMill.TabIndex = 143
        Me.rbnInfixMill.TabStop = True
        Me.rbnInfixMill.Text = "Infix"
        Me.rbnInfixMill.UseVisualStyleBackColor = True
        '
        'rbnSuffixMill
        '
        Me.rbnSuffixMill.AutoSize = True
        Me.rbnSuffixMill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMill.Location = New System.Drawing.Point(120, 4)
        Me.rbnSuffixMill.Name = "rbnSuffixMill"
        Me.rbnSuffixMill.Size = New System.Drawing.Size(58, 19)
        Me.rbnSuffixMill.TabIndex = 144
        Me.rbnSuffixMill.Text = "Suffix"
        Me.rbnSuffixMill.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(1062, 88)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(36, 16)
        Me.lblYear.TabIndex = 131
        Me.lblYear.Text = "Year"
        Me.lblYear.Visible = False
        '
        'rbnPrefixBillingName
        '
        Me.rbnPrefixBillingName.AutoSize = True
        Me.rbnPrefixBillingName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnPrefixBillingName.Location = New System.Drawing.Point(1, 4)
        Me.rbnPrefixBillingName.Name = "rbnPrefixBillingName"
        Me.rbnPrefixBillingName.Size = New System.Drawing.Size(59, 19)
        Me.rbnPrefixBillingName.TabIndex = 142
        Me.rbnPrefixBillingName.Text = "Prefix"
        Me.rbnPrefixBillingName.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbnPrefixBillingName)
        Me.Panel3.Controls.Add(Me.rbnInfixBillingName)
        Me.Panel3.Controls.Add(Me.rbnSuffixBillingName)
        Me.Panel3.Location = New System.Drawing.Point(558, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(166, 24)
        Me.Panel3.TabIndex = 157
        '
        'rbnInfixBillingName
        '
        Me.rbnInfixBillingName.AutoSize = True
        Me.rbnInfixBillingName.Checked = True
        Me.rbnInfixBillingName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixBillingName.Location = New System.Drawing.Point(60, 4)
        Me.rbnInfixBillingName.Name = "rbnInfixBillingName"
        Me.rbnInfixBillingName.Size = New System.Drawing.Size(50, 19)
        Me.rbnInfixBillingName.TabIndex = 143
        Me.rbnInfixBillingName.TabStop = True
        Me.rbnInfixBillingName.Text = "Infix"
        Me.rbnInfixBillingName.UseVisualStyleBackColor = True
        '
        'rbnSuffixBillingName
        '
        Me.rbnSuffixBillingName.AutoSize = True
        Me.rbnSuffixBillingName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixBillingName.Location = New System.Drawing.Point(110, 4)
        Me.rbnSuffixBillingName.Name = "rbnSuffixBillingName"
        Me.rbnSuffixBillingName.Size = New System.Drawing.Size(58, 19)
        Me.rbnSuffixBillingName.TabIndex = 144
        Me.rbnSuffixBillingName.Text = "Suffix"
        Me.rbnSuffixBillingName.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1564, 253)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.lblCountGroup)
        Me.pnlToolBar.Controls.Add(Me.Label1)
        Me.pnlToolBar.Controls.Add(Me.Panel3)
        Me.pnlToolBar.Controls.Add(Me.cmbBillingName)
        Me.pnlToolBar.Controls.Add(Me.lblBillingName)
        Me.pnlToolBar.Controls.Add(Me.Panel2)
        Me.pnlToolBar.Controls.Add(Me.Panel1)
        Me.pnlToolBar.Controls.Add(Me.cmbMillName)
        Me.pnlToolBar.Controls.Add(Me.cmbStatus)
        Me.pnlToolBar.Controls.Add(Me.cmbPartyName)
        Me.pnlToolBar.Controls.Add(Me.cmbYear)
        Me.pnlToolBar.Controls.Add(Me.cmbMonth)
        Me.pnlToolBar.Controls.Add(Me.lblMillName)
        Me.pnlToolBar.Controls.Add(Me.lblStatus)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.lblYear)
        Me.pnlToolBar.Controls.Add(Me.dgvCFormMon)
        Me.pnlToolBar.Controls.Add(Me.lblMonth)
        Me.pnlToolBar.Controls.Add(Me.lblPartyName)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.dgvDetails)
        Me.pnlToolBar.Controls.Add(Me.cmbCountGroup)
        Me.pnlToolBar.Controls.Add(Me.lblCFormRecvStatus)
        Me.pnlToolBar.Controls.Add(Me.cmbCFormRecv)
        Me.pnlToolBar.Controls.Add(Me.gbxDisplay)
        Me.pnlToolBar.Location = New System.Drawing.Point(12, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1540, 205)
        Me.pnlToolBar.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1415, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 34)
        Me.Label1.TabIndex = 160
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnPrefixParty)
        Me.Panel1.Controls.Add(Me.rbnInfixParty)
        Me.Panel1.Controls.Add(Me.rbnSuffixParty)
        Me.Panel1.Location = New System.Drawing.Point(273, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 22)
        Me.Panel1.TabIndex = 150
        '
        'rbnPrefixParty
        '
        Me.rbnPrefixParty.AutoSize = True
        Me.rbnPrefixParty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnPrefixParty.Location = New System.Drawing.Point(11, 2)
        Me.rbnPrefixParty.Name = "rbnPrefixParty"
        Me.rbnPrefixParty.Size = New System.Drawing.Size(59, 19)
        Me.rbnPrefixParty.TabIndex = 43
        Me.rbnPrefixParty.Text = "Prefix"
        Me.rbnPrefixParty.UseVisualStyleBackColor = True
        '
        'rbnInfixParty
        '
        Me.rbnInfixParty.AutoSize = True
        Me.rbnInfixParty.Checked = True
        Me.rbnInfixParty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixParty.Location = New System.Drawing.Point(70, 2)
        Me.rbnInfixParty.Name = "rbnInfixParty"
        Me.rbnInfixParty.Size = New System.Drawing.Size(50, 19)
        Me.rbnInfixParty.TabIndex = 44
        Me.rbnInfixParty.TabStop = True
        Me.rbnInfixParty.Text = "Infix"
        Me.rbnInfixParty.UseVisualStyleBackColor = True
        '
        'rbnSuffixParty
        '
        Me.rbnSuffixParty.AutoSize = True
        Me.rbnSuffixParty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixParty.Location = New System.Drawing.Point(120, 2)
        Me.rbnSuffixParty.Name = "rbnSuffixParty"
        Me.rbnSuffixParty.Size = New System.Drawing.Size(58, 19)
        Me.rbnSuffixParty.TabIndex = 45
        Me.rbnSuffixParty.Text = "Suffix"
        Me.rbnSuffixParty.UseVisualStyleBackColor = True
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(980, 27)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(275, 20)
        Me.cmbMillName.TabIndex = 145
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"F", "P", "M"})
        Me.cmbStatus.Location = New System.Drawing.Point(527, 69)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(82, 20)
        Me.cmbStatus.TabIndex = 140
        '
        'cmbPartyName
        '
        Me.cmbPartyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(172, 27)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(286, 20)
        Me.cmbPartyName.TabIndex = 66
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {" 2014 -  2015", " 2015 -  2016", " 2016 -  2017", " 2017 -  2018", " 2018 -  2019", " 2019 -  2020", " 2020 -  2021", " 2021 -  2022", " 2022 -  2023", " 2023 -  2024", " 2024 -  2025", " 2025 -  2026"})
        Me.cmbYear.Location = New System.Drawing.Point(1062, 105)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(118, 20)
        Me.cmbYear.TabIndex = 132
        Me.cmbYear.Visible = False
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cmbMonth.Location = New System.Drawing.Point(465, 66)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(47, 20)
        Me.cmbMonth.TabIndex = 130
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(980, 8)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(72, 16)
        Me.lblMillName.TabIndex = 141
        Me.lblMillName.Text = "Mill Name"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(527, 52)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 16)
        Me.lblStatus.TabIndex = 139
        Me.lblStatus.Text = "Status"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(1344, 64)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 138
        Me.btnView.Text = "&Export"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.JISPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(1270, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 137
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvCFormMon
        '
        Me.dgvCFormMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCFormMon.Location = New System.Drawing.Point(172, 53)
        Me.dgvCFormMon.Name = "dgvCFormMon"
        Me.dgvCFormMon.Size = New System.Drawing.Size(286, 86)
        Me.dgvCFormMon.TabIndex = 1
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(465, 49)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(56, 16)
        Me.lblMonth.TabIndex = 129
        Me.lblMonth.Text = "Quarter"
        '
        'lblPartyName
        '
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.Location = New System.Drawing.Point(172, 8)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(82, 16)
        Me.lblPartyName.TabIndex = 41
        Me.lblPartyName.Text = "Party Name"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(1270, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1342, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'gbxDisplay
        '
        Me.gbxDisplay.Controls.Add(Me.rbnSummary)
        Me.gbxDisplay.Controls.Add(Me.rbnDetails)
        Me.gbxDisplay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gbxDisplay.Location = New System.Drawing.Point(470, 95)
        Me.gbxDisplay.Name = "gbxDisplay"
        Me.gbxDisplay.Size = New System.Drawing.Size(241, 55)
        Me.gbxDisplay.TabIndex = 149
        Me.gbxDisplay.TabStop = False
        Me.gbxDisplay.Text = "Display"
        Me.gbxDisplay.Visible = False
        '
        'rbnSummary
        '
        Me.rbnSummary.AutoSize = True
        Me.rbnSummary.Checked = True
        Me.rbnSummary.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSummary.Location = New System.Drawing.Point(25, 20)
        Me.rbnSummary.Name = "rbnSummary"
        Me.rbnSummary.Size = New System.Drawing.Size(78, 19)
        Me.rbnSummary.TabIndex = 147
        Me.rbnSummary.TabStop = True
        Me.rbnSummary.Text = "Summary"
        Me.rbnSummary.UseVisualStyleBackColor = True
        '
        'rbnDetails
        '
        Me.rbnDetails.AutoSize = True
        Me.rbnDetails.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnDetails.Location = New System.Drawing.Point(124, 20)
        Me.rbnDetails.Name = "rbnDetails"
        Me.rbnDetails.Size = New System.Drawing.Size(64, 19)
        Me.rbnDetails.TabIndex = 148
        Me.rbnDetails.Text = "Details"
        Me.rbnDetails.UseVisualStyleBackColor = True
        '
        'dgvDetails
        '
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Location = New System.Drawing.Point(1416, 3)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.Size = New System.Drawing.Size(120, 140)
        Me.dgvDetails.TabIndex = 146
        Me.dgvDetails.Visible = False
        '
        'lblCFormRecvStatus
        '
        Me.lblCFormRecvStatus.AutoSize = True
        Me.lblCFormRecvStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblCFormRecvStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFormRecvStatus.Location = New System.Drawing.Point(618, 52)
        Me.lblCFormRecvStatus.Name = "lblCFormRecvStatus"
        Me.lblCFormRecvStatus.Size = New System.Drawing.Size(156, 16)
        Me.lblCFormRecvStatus.TabIndex = 158
        Me.lblCFormRecvStatus.Text = "CForm Received Status"
        Me.lblCFormRecvStatus.Visible = False
        '
        'cmbCFormRecv
        '
        Me.cmbCFormRecv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCFormRecv.FormattingEnabled = True
        Me.cmbCFormRecv.Items.AddRange(New Object() {"Received", "Not Received"})
        Me.cmbCFormRecv.Location = New System.Drawing.Point(618, 69)
        Me.cmbCFormRecv.Name = "cmbCFormRecv"
        Me.cmbCFormRecv.Size = New System.Drawing.Size(156, 20)
        Me.cmbCFormRecv.TabIndex = 159
        Me.cmbCFormRecv.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1564, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "E1 Form Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1564, 23)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.ProgressBar1)
        Me.pnlContent.Controls.Add(Me.dgvCFormQua)
        Me.pnlContent.Location = New System.Drawing.Point(0, 256)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1564, 516)
        Me.pnlContent.TabIndex = 0
        '
        'dgvCFormQua
        '
        Me.dgvCFormQua.AllowUserToOrderColumns = True
        Me.dgvCFormQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCFormQua.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCFormQua.Location = New System.Drawing.Point(0, 0)
        Me.dgvCFormQua.Name = "dgvCFormQua"
        Me.dgvCFormQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCFormQua.Size = New System.Drawing.Size(1564, 516)
        Me.dgvCFormQua.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1564, 782)
        Me.pnlMain.TabIndex = 20
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 772)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1564, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'cmbCountGroup
        '
        Me.cmbCountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCountGroup.FormattingEnabled = True
        Me.cmbCountGroup.Location = New System.Drawing.Point(732, 26)
        Me.cmbCountGroup.Name = "cmbCountGroup"
        Me.cmbCountGroup.Size = New System.Drawing.Size(242, 20)
        Me.cmbCountGroup.TabIndex = 162
        '
        'lblCountGroup
        '
        Me.lblCountGroup.AutoSize = True
        Me.lblCountGroup.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountGroup.Location = New System.Drawing.Point(732, 8)
        Me.lblCountGroup.Name = "lblCountGroup"
        Me.lblCountGroup.Size = New System.Drawing.Size(88, 16)
        Me.lblCountGroup.TabIndex = 161
        Me.lblCountGroup.Text = "Count Group"
        '
        'frmE1Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1564, 782)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmE1Form"
        Me.Text = "E1 FORM"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCFormMon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDisplay.ResumeLayout(False)
        Me.gbxDisplay.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvCFormQua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbBillingName As System.Windows.Forms.ComboBox
    Friend WithEvents lblBillingName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbnPrefixMill As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixMill As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMill As System.Windows.Forms.RadioButton
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents rbnPrefixBillingName As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixBillingName As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixBillingName As System.Windows.Forms.RadioButton
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbnPrefixParty As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixParty As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixParty As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvCFormMon As System.Windows.Forms.DataGridView
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblPartyName As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gbxDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rbnDetails As System.Windows.Forms.RadioButton
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmbCFormRecv As System.Windows.Forms.ComboBox
    Friend WithEvents lblCFormRecvStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCFormQua As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCountGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblCountGroup As System.Windows.Forms.Label
End Class
