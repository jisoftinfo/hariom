<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartyPaymentDebitNote
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
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.chkPartyPayment = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvTotal = New System.Windows.Forms.DataGridView
        Me.dgvDebitNoteSummery = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblMillName = New System.Windows.Forms.Label
        Me.cmbPartylName = New System.Windows.Forms.ComboBox
        Me.cbxPeriod = New System.Windows.Forms.CheckBox
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox
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
        Me.Bal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OpBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSYr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.lblHeading = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDebitNoteSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.chkPartyPayment)
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.dgvTotal)
        Me.pnlContent.Controls.Add(Me.dgvDebitNoteSummery)
        Me.pnlContent.Controls.Add(Me.btnSave)
        Me.pnlContent.Controls.Add(Me.btnSearch)
        Me.pnlContent.Controls.Add(Me.btnView)
        Me.pnlContent.Controls.Add(Me.btnExit)
        Me.pnlContent.Controls.Add(Me.lblMillName)
        Me.pnlContent.Controls.Add(Me.cmbPartylName)
        Me.pnlContent.Controls.Add(Me.cbxPeriod)
        Me.pnlContent.Controls.Add(Me.dtpFDate)
        Me.pnlContent.Controls.Add(Me.dtpTDate)
        Me.pnlContent.Controls.Add(Me.lblCompanyName)
        Me.pnlContent.Controls.Add(Me.cmbCompanyName)
        Me.pnlContent.Controls.Add(Me.lblStatus)
        Me.pnlContent.Controls.Add(Me.cmbStatus)
        Me.pnlContent.Controls.Add(Me.ProgressBar1)
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 71)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1924, 905)
        Me.pnlContent.TabIndex = 0
        '
        'chkPartyPayment
        '
        Me.chkPartyPayment.AutoSize = True
        Me.chkPartyPayment.Location = New System.Drawing.Point(365, 86)
        Me.chkPartyPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPartyPayment.Name = "chkPartyPayment"
        Me.chkPartyPayment.Size = New System.Drawing.Size(121, 21)
        Me.chkPartyPayment.TabIndex = 17
        Me.chkPartyPayment.Text = "For Copy Data"
        Me.chkPartyPayment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1899, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 44)
        Me.Label1.TabIndex = 156
        '
        'dgvTotal
        '
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Location = New System.Drawing.Point(1401, 7)
        Me.dgvTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.RowTemplate.Height = 24
        Me.dgvTotal.Size = New System.Drawing.Size(460, 66)
        Me.dgvTotal.TabIndex = 155
        '
        'dgvDebitNoteSummery
        '
        Me.dgvDebitNoteSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitNoteSummery.Location = New System.Drawing.Point(8, 905)
        Me.dgvDebitNoteSummery.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDebitNoteSummery.Name = "dgvDebitNoteSummery"
        Me.dgvDebitNoteSummery.RowTemplate.Height = 24
        Me.dgvDebitNoteSummery.Size = New System.Drawing.Size(1037, 219)
        Me.dgvDebitNoteSummery.TabIndex = 152
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.JISPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(996, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 60)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(1095, 7)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 60)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(1193, 7)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(88, 60)
        Me.btnView.TabIndex = 137
        Me.btnView.Text = "&Export"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1292, 7)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 60)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(16, 4)
        Me.lblMillName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(100, 19)
        Me.lblMillName.TabIndex = 10
        Me.lblMillName.Text = "Party Name"
        '
        'cmbPartylName
        '
        Me.cmbPartylName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPartylName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartylName.FormattingEnabled = True
        Me.cmbPartylName.Location = New System.Drawing.Point(16, 23)
        Me.cmbPartylName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPartylName.Name = "cmbPartylName"
        Me.cmbPartylName.Size = New System.Drawing.Size(407, 26)
        Me.cmbPartylName.Sorted = True
        Me.cmbPartylName.TabIndex = 138
        '
        'cbxPeriod
        '
        Me.cbxPeriod.AutoSize = True
        Me.cbxPeriod.Location = New System.Drawing.Point(20, 64)
        Me.cbxPeriod.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPeriod.Name = "cbxPeriod"
        Me.cbxPeriod.Size = New System.Drawing.Size(71, 21)
        Me.cbxPeriod.TabIndex = 150
        Me.cbxPeriod.Text = "Period"
        Me.cbxPeriod.UseVisualStyleBackColor = True
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(16, 86)
        Me.dtpFDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(140, 27)
        Me.dtpFDate.TabIndex = 148
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(168, 86)
        Me.dtpTDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.Size = New System.Drawing.Size(164, 27)
        Me.dtpTDate.TabIndex = 149
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(432, 4)
        Me.lblCompanyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(132, 19)
        Me.lblCompanyName.TabIndex = 139
        Me.lblCompanyName.Text = "Company Name"
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCompanyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(432, 23)
        Me.cmbCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(335, 26)
        Me.cmbCompanyName.Sorted = True
        Me.cmbCompanyName.TabIndex = 140
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(795, 4)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 19)
        Me.lblStatus.TabIndex = 153
        Me.lblStatus.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"F", "P", "T"})
        Me.cmbStatus.Location = New System.Drawing.Point(795, 23)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(192, 26)
        Me.cmbStatus.Sorted = True
        Me.cmbStatus.TabIndex = 154
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 124)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(2041, 28)
        Me.ProgressBar1.TabIndex = 151
        Me.ProgressBar1.Visible = False
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNCode, Me.BillDate, Me.MillName, Me.CompanyName, Me.Year, Me.Period, Me.CommissionRate, Me.Commission, Me.Tax, Me.Total, Me.TDS, Me.Bal, Me.OpBal, Me.TotalBal, Me.BalAmt, Me.TDSYr, Me.Status, Me.ClrDt1, Me.Amt1, Me.Chq1, Me.ClrDt2, Me.Amt2, Me.Chq2, Me.ClrDt3, Me.Amt3, Me.Chq3, Me.StatusColor, Me.Narration})
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(8, 153)
        Me.dgvCustomerSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.RowTemplate.Height = 24
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(2041, 735)
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
        Me.BillDate.HeaderText = "BILL DATE"
        Me.BillDate.Name = "BillDate"
        '
        'MillName
        '
        Me.MillName.FillWeight = 150.0!
        Me.MillName.HeaderText = "PARTY NAME"
        Me.MillName.Name = "MillName"
        Me.MillName.Width = 150
        '
        'CompanyName
        '
        Me.CompanyName.FillWeight = 150.0!
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
        Me.Period.FillWeight = 150.0!
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
        'Bal
        '
        Me.Bal.HeaderText = "BALANCE"
        Me.Bal.Name = "Bal"
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
        Me.TDSYr.HeaderText = "TDS YR"
        Me.TDSYr.Name = "TDSYr"
        '
        'Status
        '
        Me.Status.HeaderText = "STATUS"
        Me.Status.Name = "Status"
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
        Me.StatusColor.HeaderText = "STATUS COLOR"
        Me.StatusColor.Name = "StatusColor"
        Me.StatusColor.Visible = False
        '
        'Narration
        '
        Me.Narration.HeaderText = "NARRATION"
        Me.Narration.Name = "Narration"
        Me.Narration.Width = 150
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1924, 988)
        Me.pnlMain.TabIndex = 16
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 976)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1924, 12)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1924, 71)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Location = New System.Drawing.Point(16, 55)
        Me.pnlToolBar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1303, 12)
        Me.pnlToolBar.TabIndex = 0
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
        Me.lblHeading.Text = "Party Payment"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'frmPartyPaymentDebitNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1924, 988)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPartyPaymentDebitNote"
        Me.Text = "PARTY PAYMENT"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDebitNoteSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents dgvTotal As System.Windows.Forms.DataGridView
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents dgvDebitNoteSummery As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartylName As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgvCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkPartyPayment As System.Windows.Forms.CheckBox
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
    Friend WithEvents Bal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSYr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
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
