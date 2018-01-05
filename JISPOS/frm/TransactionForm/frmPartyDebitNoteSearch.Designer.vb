<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartyDebitNoteSearch
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
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.dgvDebitNoteMill = New System.Windows.Forms.DataGridView
        Me.cbxPeriod = New System.Windows.Forms.CheckBox
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.btnBill = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnInfixCompany = New System.Windows.Forms.RadioButton
        Me.rbnSuffixCompany = New System.Windows.Forms.RadioButton
        Me.rbnPrefixCompany = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMill = New System.Windows.Forms.RadioButton
        Me.lblHeading = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rbnPrefixMill = New System.Windows.Forms.RadioButton
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.lblQuarter = New System.Windows.Forms.Label
        Me.pnlOne = New System.Windows.Forms.Panel
        Me.rbnInfixMill = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cmbQuarter = New System.Windows.Forms.ComboBox
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgvDebitNoteSummery = New System.Windows.Forms.DataGridView
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.dgvDebitNoteMill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOne.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDebitNoteSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Items.AddRange(New Object() {"First", "Fourth", "Second", "Third"})
        Me.cmbMillName.Location = New System.Drawing.Point(31, 34)
        Me.cmbMillName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(408, 26)
        Me.cmbMillName.Sorted = True
        Me.cmbMillName.TabIndex = 141
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(107, 69)
        Me.dtpFDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(159, 27)
        Me.dtpFDate.TabIndex = 145
        '
        'dgvDebitNoteMill
        '
        Me.dgvDebitNoteMill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitNoteMill.Location = New System.Drawing.Point(23, 104)
        Me.dgvDebitNoteMill.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDebitNoteMill.Name = "dgvDebitNoteMill"
        Me.dgvDebitNoteMill.RowTemplate.Height = 24
        Me.dgvDebitNoteMill.Size = New System.Drawing.Size(1995, 740)
        Me.dgvDebitNoteMill.TabIndex = 0
        '
        'cbxPeriod
        '
        Me.cbxPeriod.AutoSize = True
        Me.cbxPeriod.Location = New System.Drawing.Point(32, 71)
        Me.cbxPeriod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxPeriod.Name = "cbxPeriod"
        Me.cbxPeriod.Size = New System.Drawing.Size(71, 21)
        Me.cbxPeriod.TabIndex = 147
        Me.cbxPeriod.Text = "Period"
        Me.cbxPeriod.UseVisualStyleBackColor = True
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(273, 69)
        Me.dtpTDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.Size = New System.Drawing.Size(164, 27)
        Me.dtpTDate.TabIndex = 146
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.Color.White
        Me.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBill.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnBill.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBill.Location = New System.Drawing.Point(1063, 5)
        Me.btnBill.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(88, 60)
        Me.btnBill.TabIndex = 143
        Me.btnBill.Text = " &Bill"
        Me.btnBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBill.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnInfixCompany)
        Me.Panel1.Controls.Add(Me.rbnSuffixCompany)
        Me.Panel1.Controls.Add(Me.rbnPrefixCompany)
        Me.Panel1.Location = New System.Drawing.Point(613, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 25)
        Me.Panel1.TabIndex = 139
        '
        'rbnInfixCompany
        '
        Me.rbnInfixCompany.AutoSize = True
        Me.rbnInfixCompany.Checked = True
        Me.rbnInfixCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixCompany.Location = New System.Drawing.Point(85, 0)
        Me.rbnInfixCompany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnInfixCompany.Name = "rbnInfixCompany"
        Me.rbnInfixCompany.Size = New System.Drawing.Size(62, 23)
        Me.rbnInfixCompany.TabIndex = 13
        Me.rbnInfixCompany.TabStop = True
        Me.rbnInfixCompany.Text = "Infix"
        Me.rbnInfixCompany.UseVisualStyleBackColor = True
        '
        'rbnSuffixCompany
        '
        Me.rbnSuffixCompany.AutoSize = True
        Me.rbnSuffixCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixCompany.Location = New System.Drawing.Point(157, 0)
        Me.rbnSuffixCompany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnSuffixCompany.Name = "rbnSuffixCompany"
        Me.rbnSuffixCompany.Size = New System.Drawing.Size(74, 23)
        Me.rbnSuffixCompany.TabIndex = 14
        Me.rbnSuffixCompany.Text = "Suffix"
        Me.rbnSuffixCompany.UseVisualStyleBackColor = True
        '
        'rbnPrefixCompany
        '
        Me.rbnPrefixCompany.AutoSize = True
        Me.rbnPrefixCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixCompany.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixCompany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnPrefixCompany.Name = "rbnPrefixCompany"
        Me.rbnPrefixCompany.Size = New System.Drawing.Size(75, 23)
        Me.rbnPrefixCompany.TabIndex = 12
        Me.rbnPrefixCompany.Text = "Prefix"
        Me.rbnPrefixCompany.UseVisualStyleBackColor = True
        '
        'rbnSuffixMill
        '
        Me.rbnSuffixMill.AutoSize = True
        Me.rbnSuffixMill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMill.Location = New System.Drawing.Point(157, 0)
        Me.rbnSuffixMill.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnSuffixMill.Name = "rbnSuffixMill"
        Me.rbnSuffixMill.Size = New System.Drawing.Size(74, 23)
        Me.rbnSuffixMill.TabIndex = 14
        Me.rbnSuffixMill.Text = "Suffix"
        Me.rbnSuffixMill.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1924, 52)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Party Debit Note Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'rbnPrefixMill
        '
        Me.rbnPrefixMill.AutoSize = True
        Me.rbnPrefixMill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMill.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMill.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnPrefixMill.Name = "rbnPrefixMill"
        Me.rbnPrefixMill.Size = New System.Drawing.Size(75, 23)
        Me.rbnPrefixMill.TabIndex = 12
        Me.rbnPrefixMill.Text = "Prefix"
        Me.rbnPrefixMill.UseVisualStyleBackColor = True
        '
        'cmbCompany
        '
        Me.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCompany.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Items.AddRange(New Object() {"First", "Fourth", "Second", "Third"})
        Me.cmbCompany.Location = New System.Drawing.Point(447, 35)
        Me.cmbCompany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(408, 26)
        Me.cmbCompany.Sorted = True
        Me.cmbCompany.TabIndex = 142
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(27, 13)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 19)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Party Name"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(447, 12)
        Me.lblCompanyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(132, 19)
        Me.lblCompanyName.TabIndex = 140
        Me.lblCompanyName.Text = "Company Name"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(967, 5)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(88, 60)
        Me.btnView.TabIndex = 137
        Me.btnView.Text = "&Export"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarter.Location = New System.Drawing.Point(1762, 31)
        Me.lblQuarter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(70, 19)
        Me.lblQuarter.TabIndex = 12
        Me.lblQuarter.Text = "Quarter"
        Me.lblQuarter.Visible = False
        '
        'pnlOne
        '
        Me.pnlOne.Controls.Add(Me.rbnInfixMill)
        Me.pnlOne.Controls.Add(Me.rbnSuffixMill)
        Me.pnlOne.Controls.Add(Me.rbnPrefixMill)
        Me.pnlOne.Location = New System.Drawing.Point(196, 6)
        Me.pnlOne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(243, 25)
        Me.pnlOne.TabIndex = 0
        '
        'rbnInfixMill
        '
        Me.rbnInfixMill.AutoSize = True
        Me.rbnInfixMill.Checked = True
        Me.rbnInfixMill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMill.Location = New System.Drawing.Point(85, 0)
        Me.rbnInfixMill.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnInfixMill.Name = "rbnInfixMill"
        Me.rbnInfixMill.Size = New System.Drawing.Size(62, 23)
        Me.rbnInfixMill.TabIndex = 13
        Me.rbnInfixMill.TabStop = True
        Me.rbnInfixMill.Text = "Infix"
        Me.rbnInfixMill.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1159, 5)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 60)
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
        Me.btnSearch.Location = New System.Drawing.Point(871, 5)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 60)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbQuarter
        '
        Me.cmbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbQuarter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQuarter.FormattingEnabled = True
        Me.cmbQuarter.Items.AddRange(New Object() {"First", "Fourth", "Second", "Third"})
        Me.cmbQuarter.Location = New System.Drawing.Point(1766, 55)
        Me.cmbQuarter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(99, 26)
        Me.cmbQuarter.Sorted = True
        Me.cmbQuarter.TabIndex = 11
        Me.cmbQuarter.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.Panel2)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 59)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1924, 891)
        Me.pnlContent.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.cmbCompany)
        Me.Panel2.Controls.Add(Me.cmbMillName)
        Me.Panel2.Controls.Add(Me.lblQuarter)
        Me.Panel2.Controls.Add(Me.cmbQuarter)
        Me.Panel2.Controls.Add(Me.btnBill)
        Me.Panel2.Controls.Add(Me.dgvDebitNoteSummery)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.dgvDebitNoteMill)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.pnlOne)
        Me.Panel2.Controls.Add(Me.lblCompanyName)
        Me.Panel2.Controls.Add(Me.dtpTDate)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.dtpFDate)
        Me.Panel2.Controls.Add(Me.cbxPeriod)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2073, 854)
        Me.Panel2.TabIndex = 2
        '
        'dgvDebitNoteSummery
        '
        Me.dgvDebitNoteSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitNoteSummery.Location = New System.Drawing.Point(32, 595)
        Me.dgvDebitNoteSummery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDebitNoteSummery.Name = "dgvDebitNoteSummery"
        Me.dgvDebitNoteSummery.RowTemplate.Height = 24
        Me.dgvDebitNoteSummery.Size = New System.Drawing.Size(1037, 219)
        Me.dgvDebitNoteSummery.TabIndex = 1
        Me.dgvDebitNoteSummery.Visible = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1924, 962)
        Me.pnlMain.TabIndex = 15
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 950)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1924, 12)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1924, 59)
        Me.pnlHeader.TabIndex = 0
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'frmPartyDebitNoteSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 962)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPartyDebitNoteSearch"
        Me.Text = "Party Debit Note Search"
        CType(Me.dgvDebitNoteMill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvDebitNoteSummery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDebitNoteMill As System.Windows.Forms.DataGridView
    Friend WithEvents cbxPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBill As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixCompany As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixCompany As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCompany As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMill As System.Windows.Forms.RadioButton
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvDebitNoteSummery As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblQuarter As System.Windows.Forms.Label
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMill As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMill As System.Windows.Forms.RadioButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbQuarter As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
