<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMillPaymenyDebitNote
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblHeading = New System.Windows.Forms.Label
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.btnView = New System.Windows.Forms.Button
        Me.lblMillName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.chkMillPayment = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.dgvDebitNoteSummery = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.cbxPeriod = New System.Windows.Forms.CheckBox
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.lblStatus = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView
        Me.DNCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MillName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommissionRate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Commission = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OpBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSYr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STATUS = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ClrDt1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chq1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClrDt2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chq2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClrDt3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chq3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusColor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDebitNoteSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1284, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Mill Payment"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Location = New System.Drawing.Point(12, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(977, 10)
        Me.pnlToolBar.TabIndex = 0
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCompanyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(288, 25)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(252, 22)
        Me.cmbCompanyName.Sorted = True
        Me.cmbCompanyName.TabIndex = 140
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(288, 9)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(109, 16)
        Me.lblCompanyName.TabIndex = 139
        Me.lblCompanyName.Text = "Company Name"
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(30, 25)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(252, 22)
        Me.cmbMillName.Sorted = True
        Me.cmbMillName.TabIndex = 138
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(1089, 6)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 137
        Me.btnView.Text = "&Export"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(30, 9)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(72, 16)
        Me.lblMillName.TabIndex = 10
        Me.lblMillName.Text = "Mill Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1163, 6)
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
        Me.btnSearch.Location = New System.Drawing.Point(1015, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1284, 58)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1284, 803)
        Me.pnlMain.TabIndex = 15
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.chkMillPayment)
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.DataGridView1)
        Me.pnlContent.Controls.Add(Me.dgvDebitNoteSummery)
        Me.pnlContent.Controls.Add(Me.btnSave)
        Me.pnlContent.Controls.Add(Me.btnSearch)
        Me.pnlContent.Controls.Add(Me.btnView)
        Me.pnlContent.Controls.Add(Me.btnExit)
        Me.pnlContent.Controls.Add(Me.lblMillName)
        Me.pnlContent.Controls.Add(Me.cmbMillName)
        Me.pnlContent.Controls.Add(Me.lblCompanyName)
        Me.pnlContent.Controls.Add(Me.cmbCompanyName)
        Me.pnlContent.Controls.Add(Me.cbxPeriod)
        Me.pnlContent.Controls.Add(Me.dtpFDate)
        Me.pnlContent.Controls.Add(Me.dtpTDate)
        Me.pnlContent.Controls.Add(Me.lblStatus)
        Me.pnlContent.Controls.Add(Me.cmbStatus)
        Me.pnlContent.Controls.Add(Me.ProgressBar1)
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 58)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1284, 735)
        Me.pnlContent.TabIndex = 0
        '
        'chkMillPayment
        '
        Me.chkMillPayment.AutoSize = True
        Me.chkMillPayment.Location = New System.Drawing.Point(1253, 43)
        Me.chkMillPayment.Name = "chkMillPayment"
        Me.chkMillPayment.Size = New System.Drawing.Size(94, 17)
        Me.chkMillPayment.TabIndex = 16
        Me.chkMillPayment.Text = "For Copy Data"
        Me.chkMillPayment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 34)
        Me.Label1.TabIndex = 157
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(790, 735)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(747, 178)
        Me.DataGridView1.TabIndex = 155
        '
        'dgvDebitNoteSummery
        '
        Me.dgvDebitNoteSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitNoteSummery.Location = New System.Drawing.Point(6, 735)
        Me.dgvDebitNoteSummery.Name = "dgvDebitNoteSummery"
        Me.dgvDebitNoteSummery.Size = New System.Drawing.Size(778, 178)
        Me.dgvDebitNoteSummery.TabIndex = 152
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.JISPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(941, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbxPeriod
        '
        Me.cbxPeriod.AutoSize = True
        Me.cbxPeriod.Location = New System.Drawing.Point(549, 6)
        Me.cbxPeriod.Name = "cbxPeriod"
        Me.cbxPeriod.Size = New System.Drawing.Size(56, 17)
        Me.cbxPeriod.TabIndex = 150
        Me.cbxPeriod.Text = "Period"
        Me.cbxPeriod.UseVisualStyleBackColor = True
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(546, 24)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(106, 23)
        Me.dtpFDate.TabIndex = 148
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(660, 24)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.Size = New System.Drawing.Size(124, 23)
        Me.dtpTDate.TabIndex = 149
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(790, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 16)
        Me.lblStatus.TabIndex = 153
        Me.lblStatus.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"F", "P", "T"})
        Me.cmbStatus.Location = New System.Drawing.Point(790, 24)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(145, 22)
        Me.cmbStatus.Sorted = True
        Me.cmbStatus.TabIndex = 154
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 66)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1531, 23)
        Me.ProgressBar1.TabIndex = 151
        Me.ProgressBar1.Visible = False
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNCode, Me.BillDate, Me.MillName, Me.CompanyName, Me.Year, Me.Period, Me.CommissionRate, Me.Commission, Me.Tax, Me.Total, Me.TDS, Me.Balance, Me.OpBal, Me.TotalBal, Me.BalAmt, Me.TDSYr, Me.STATUS, Me.ClrDt1, Me.Amt1, Me.Chq1, Me.ClrDt2, Me.Amt2, Me.Chq2, Me.ClrDt3, Me.Amt3, Me.Chq3, Me.StatusColor, Me.Narration})
        Me.dgvCustomerSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(6, 89)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(1531, 640)
        Me.dgvCustomerSearch.TabIndex = 0
        '
        'DNCode
        '
        Me.DNCode.HeaderText = "DNCode"
        Me.DNCode.Name = "DNCode"
        Me.DNCode.Visible = False
        '
        'BillDate
        '
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.BillDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.BillDate.HeaderText = "BILL DATE"
        Me.BillDate.Name = "BillDate"
        '
        'MillName
        '
        Me.MillName.HeaderText = "MILL NAME"
        Me.MillName.Name = "MillName"
        Me.MillName.Width = 150
        '
        'CompanyName
        '
        Me.CompanyName.HeaderText = "COMPANY NAME"
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Width = 150
        '
        'Year
        '
        Me.Year.HeaderText = "YEAR"
        Me.Year.Name = "Year"
        '
        'Period
        '
        Me.Period.HeaderText = "PERIOD"
        Me.Period.Name = "Period"
        '
        'CommissionRate
        '
        Me.CommissionRate.HeaderText = "COMM RATE"
        Me.CommissionRate.Name = "CommissionRate"
        '
        'Commission
        '
        Me.Commission.HeaderText = "COMMISSION"
        Me.Commission.Name = "Commission"
        '
        'Tax
        '
        Me.Tax.HeaderText = "TAX"
        Me.Tax.Name = "Tax"
        '
        'Total
        '
        Me.Total.HeaderText = "TOTAL"
        Me.Total.Name = "Total"
        '
        'TDS
        '
        Me.TDS.HeaderText = "TDS"
        Me.TDS.Name = "TDS"
        '
        'Balance
        '
        Me.Balance.HeaderText = "BALANCE"
        Me.Balance.Name = "Balance"
        '
        'OpBal
        '
        Me.OpBal.HeaderText = "OP BAL"
        Me.OpBal.Name = "OpBal"
        '
        'TotalBal
        '
        Me.TotalBal.HeaderText = "TOTAL BAL"
        Me.TotalBal.Name = "TotalBal"
        '
        'BalAmt
        '
        Me.BalAmt.HeaderText = "BAL AMT"
        Me.BalAmt.Name = "BalAmt"
        '
        'TDSYr
        '
        Me.TDSYr.HeaderText = "TDS YEAR"
        Me.TDSYr.Name = "TDSYr"
        '
        'STATUS
        '
        Me.STATUS.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.STATUS.DisplayStyleForCurrentCellOnly = True
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Items.AddRange(New Object() {"P", "F", "T"})
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ClrDt1
        '
        Me.ClrDt1.HeaderText = "CLR DATE"
        Me.ClrDt1.Name = "ClrDt1"
        '
        'Amt1
        '
        Me.Amt1.HeaderText = "AMT"
        Me.Amt1.Name = "Amt1"
        '
        'Chq1
        '
        Me.Chq1.HeaderText = "CHQ"
        Me.Chq1.Name = "Chq1"
        '
        'ClrDt2
        '
        Me.ClrDt2.HeaderText = "CLR DATE"
        Me.ClrDt2.Name = "ClrDt2"
        '
        'Amt2
        '
        Me.Amt2.HeaderText = "AMT"
        Me.Amt2.Name = "Amt2"
        '
        'Chq2
        '
        Me.Chq2.HeaderText = "CHQ"
        Me.Chq2.Name = "Chq2"
        '
        'ClrDt3
        '
        Me.ClrDt3.HeaderText = "CLR DATE"
        Me.ClrDt3.Name = "ClrDt3"
        '
        'Amt3
        '
        Me.Amt3.HeaderText = "AMT"
        Me.Amt3.Name = "Amt3"
        '
        'Chq3
        '
        Me.Chq3.HeaderText = "CHQ"
        Me.Chq3.Name = "Chq3"
        '
        'StatusColor
        '
        Me.StatusColor.HeaderText = "StatusColor"
        Me.StatusColor.Name = "StatusColor"
        Me.StatusColor.Visible = False
        '
        'Narration
        '
        Me.Narration.HeaderText = "NARRATION"
        Me.Narration.Name = "Narration"
        Me.Narration.Width = 150
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 793)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1284, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'frmMillPaymenyDebitNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 803)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmMillPaymenyDebitNote"
        Me.Text = "MILL PAYMENT"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDebitNoteSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dgvDebitNoteSummery As System.Windows.Forms.DataGridView
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMillPayment As System.Windows.Forms.CheckBox
    Friend WithEvents DNCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MillName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Period As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommissionRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Commission As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSYr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ClrDt1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chq1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClrDt2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chq2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClrDt3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chq3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
