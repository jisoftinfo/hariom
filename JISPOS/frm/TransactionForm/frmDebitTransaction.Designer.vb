<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitTransaction
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
        Me.lblBillingName = New System.Windows.Forms.Label
        Me.lblMillName = New System.Windows.Forms.Label
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnBill = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnSearch1 = New System.Windows.Forms.Button
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.txtAddressLine = New System.Windows.Forms.TextBox
        Me.txtTotalKg = New System.Windows.Forms.TextBox
        Me.txtExMillAmt = New System.Windows.Forms.TextBox
        Me.txtComAmt = New System.Windows.Forms.TextBox
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.cmbTDSYr = New System.Windows.Forms.ComboBox
        Me.txtChequeAmount = New System.Windows.Forms.TextBox
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker
        Me.txtNoOfBags = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.lblRate = New System.Windows.Forms.Label
        Me.txtComPer = New System.Windows.Forms.TextBox
        Me.lblTaxAmt = New System.Windows.Forms.Label
        Me.cmbTaxPer = New System.Windows.Forms.ComboBox
        Me.txtTaxAmt = New System.Windows.Forms.TextBox
        Me.txtTDSAmount = New System.Windows.Forms.TextBox
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.txtChequeNo = New System.Windows.Forms.TextBox
        Me.lblChqueDate = New System.Windows.Forms.Label
        Me.lblChequeNo = New System.Windows.Forms.Label
        Me.lblChequeAmt = New System.Windows.Forms.Label
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.lblTDSYear = New System.Windows.Forms.Label
        Me.lblTDSAmount = New System.Windows.Forms.Label
        Me.lblCommissionType = New System.Windows.Forms.Label
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.txtBillingName = New System.Windows.Forms.TextBox
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.lblPeriodFrom = New System.Windows.Forms.Label
        Me.lblCommissionPer = New System.Windows.Forms.Label
        Me.lblExMillAmt = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalKg = New System.Windows.Forms.Label
        Me.lblNoOfBags = New System.Windows.Forms.Label
        Me.lblBillDate = New System.Windows.Forms.Label
        Me.lblDNd = New System.Windows.Forms.Label
        Me.LinkParty = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.dgvDebitDetails = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.txtStatusColor = New System.Windows.Forms.TextBox
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.dtpRDate3 = New System.Windows.Forms.DateTimePicker
        Me.txtRAmt3 = New System.Windows.Forms.TextBox
        Me.txtRCNo3 = New System.Windows.Forms.TextBox
        Me.dtpRDate2 = New System.Windows.Forms.DateTimePicker
        Me.txtRAmt2 = New System.Windows.Forms.TextBox
        Me.txtRCNo2 = New System.Windows.Forms.TextBox
        Me.dtpRDate1 = New System.Windows.Forms.DateTimePicker
        Me.txtRCNo1 = New System.Windows.Forms.TextBox
        Me.txtRAmt1 = New System.Windows.Forms.TextBox
        Me.txtOpBal = New System.Windows.Forms.TextBox
        Me.txtMillCode = New System.Windows.Forms.TextBox
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        CType(Me.dgvDebitDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBillingName
        '
        Me.lblBillingName.AutoSize = True
        Me.lblBillingName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingName.Location = New System.Drawing.Point(774, 486)
        Me.lblBillingName.Name = "lblBillingName"
        Me.lblBillingName.Size = New System.Drawing.Size(90, 16)
        Me.lblBillingName.TabIndex = 4
        Me.lblBillingName.Text = "Billing Name"
        Me.lblBillingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBillingName.Visible = False
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(15, 44)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(72, 16)
        Me.lblMillName.TabIndex = 5
        Me.lblMillName.Text = "Mill Name"
        Me.lblMillName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(841, 58)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 2
        Me.txtSearchBox.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.btnSearch1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 107)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnBill)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Location = New System.Drawing.Point(222, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(509, 56)
        Me.pnlToolBar.TabIndex = 0
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.Color.White
        Me.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBill.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnBill.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBill.Location = New System.Drawing.Point(382, 3)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(66, 49)
        Me.btnBill.TabIndex = 5
        Me.btnBill.Text = " &Bill"
        Me.btnBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBill.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(308, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
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
        Me.btnExit.Location = New System.Drawing.Point(234, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 3
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
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "MILL DEBIT NOTE"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(769, 45)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch1.TabIndex = 1
        Me.btnSearch1.Text = "SEARC&H"
        Me.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch1.UseVisualStyleBackColor = False
        Me.btnSearch1.Visible = False
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.txtAddressLine)
        Me.pnlForm.Controls.Add(Me.txtTotalKg)
        Me.pnlForm.Controls.Add(Me.txtExMillAmt)
        Me.pnlForm.Controls.Add(Me.txtComAmt)
        Me.pnlForm.Controls.Add(Me.txtTotalAmount)
        Me.pnlForm.Controls.Add(Me.cmbTDSYr)
        Me.pnlForm.Controls.Add(Me.txtChequeAmount)
        Me.pnlForm.Controls.Add(Me.dtpChequeDate)
        Me.pnlForm.Controls.Add(Me.cmbMillName)
        Me.pnlForm.Controls.Add(Me.dtpBillDate)
        Me.pnlForm.Controls.Add(Me.txtNoOfBags)
        Me.pnlForm.Controls.Add(Me.txtAmount)
        Me.pnlForm.Controls.Add(Me.cmbType)
        Me.pnlForm.Controls.Add(Me.lblRate)
        Me.pnlForm.Controls.Add(Me.txtComPer)
        Me.pnlForm.Controls.Add(Me.lblTaxAmt)
        Me.pnlForm.Controls.Add(Me.cmbTaxPer)
        Me.pnlForm.Controls.Add(Me.txtTaxAmt)
        Me.pnlForm.Controls.Add(Me.txtTDSAmount)
        Me.pnlForm.Controls.Add(Me.cmbCompany)
        Me.pnlForm.Controls.Add(Me.txtChequeNo)
        Me.pnlForm.Controls.Add(Me.lblChqueDate)
        Me.pnlForm.Controls.Add(Me.lblChequeNo)
        Me.pnlForm.Controls.Add(Me.lblChequeAmt)
        Me.pnlForm.Controls.Add(Me.lblCompanyName)
        Me.pnlForm.Controls.Add(Me.lblTDSYear)
        Me.pnlForm.Controls.Add(Me.lblTDSAmount)
        Me.pnlForm.Controls.Add(Me.lblCommissionType)
        Me.pnlForm.Controls.Add(Me.dtpTDate)
        Me.pnlForm.Controls.Add(Me.dtpFDate)
        Me.pnlForm.Controls.Add(Me.txtBillingName)
        Me.pnlForm.Controls.Add(Me.lblTotalAmount)
        Me.pnlForm.Controls.Add(Me.lblTax)
        Me.pnlForm.Controls.Add(Me.lblPeriodFrom)
        Me.pnlForm.Controls.Add(Me.lblCommissionPer)
        Me.pnlForm.Controls.Add(Me.lblExMillAmt)
        Me.pnlForm.Controls.Add(Me.Label2)
        Me.pnlForm.Controls.Add(Me.lblTotalKg)
        Me.pnlForm.Controls.Add(Me.lblNoOfBags)
        Me.pnlForm.Controls.Add(Me.lblBillDate)
        Me.pnlForm.Controls.Add(Me.lblBillingName)
        Me.pnlForm.Controls.Add(Me.lblMillName)
        Me.pnlForm.Controls.Add(Me.lblDNd)
        Me.pnlForm.Controls.Add(Me.LinkParty)
        Me.pnlForm.Controls.Add(Me.Label1)
        Me.pnlForm.Controls.Add(Me.lblAddress)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Controls.Add(Me.dgvDebitDetails)
        Me.pnlForm.Location = New System.Drawing.Point(222, 17)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(847, 511)
        Me.pnlForm.TabIndex = 0
        '
        'txtAddressLine
        '
        Me.txtAddressLine.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine.Location = New System.Drawing.Point(499, 42)
        Me.txtAddressLine.MaxLength = 300
        Me.txtAddressLine.Multiline = True
        Me.txtAddressLine.Name = "txtAddressLine"
        Me.txtAddressLine.Size = New System.Drawing.Size(259, 50)
        Me.txtAddressLine.TabIndex = 8
        '
        'txtTotalKg
        '
        Me.txtTotalKg.Location = New System.Drawing.Point(499, 106)
        Me.txtTotalKg.Name = "txtTotalKg"
        Me.txtTotalKg.Size = New System.Drawing.Size(259, 20)
        Me.txtTotalKg.TabIndex = 15
        '
        'txtExMillAmt
        '
        Me.txtExMillAmt.Location = New System.Drawing.Point(499, 138)
        Me.txtExMillAmt.Name = "txtExMillAmt"
        Me.txtExMillAmt.Size = New System.Drawing.Size(259, 20)
        Me.txtExMillAmt.TabIndex = 18
        Me.txtExMillAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtComAmt
        '
        Me.txtComAmt.Location = New System.Drawing.Point(499, 169)
        Me.txtComAmt.Name = "txtComAmt"
        Me.txtComAmt.Size = New System.Drawing.Size(255, 20)
        Me.txtComAmt.TabIndex = 24
        Me.txtComAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(499, 202)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(259, 20)
        Me.txtTotalAmount.TabIndex = 30
        '
        'cmbTDSYr
        '
        Me.cmbTDSYr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTDSYr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTDSYr.FormattingEnabled = True
        Me.cmbTDSYr.Items.AddRange(New Object() {"2014 - 2015", "2015 - 2016", "2016 - 2017", "2017 - 2018", "2018 - 2019", "2019 - 2020", "2020 - 2021", "2021 - 2022", "2022 - 2023", "2023 - 2024", "2024 - 2025", "2025 - 2026"})
        Me.cmbTDSYr.Location = New System.Drawing.Point(493, 359)
        Me.cmbTDSYr.Name = "cmbTDSYr"
        Me.cmbTDSYr.Size = New System.Drawing.Size(259, 22)
        Me.cmbTDSYr.Sorted = True
        Me.cmbTDSYr.TabIndex = 34
        Me.cmbTDSYr.Visible = False
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.Location = New System.Drawing.Point(499, 405)
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.Size = New System.Drawing.Size(259, 20)
        Me.txtChequeAmount.TabIndex = 38
        Me.txtChequeAmount.Visible = False
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(499, 433)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.ShowUpDown = True
        Me.dtpChequeDate.Size = New System.Drawing.Size(259, 23)
        Me.dtpChequeDate.TabIndex = 42
        Me.dtpChequeDate.Visible = False
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(106, 43)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(252, 22)
        Me.cmbMillName.Sorted = True
        Me.cmbMillName.TabIndex = 6
        '
        'dtpBillDate
        '
        Me.dtpBillDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDate.Location = New System.Drawing.Point(106, 75)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.ShowUpDown = True
        Me.dtpBillDate.Size = New System.Drawing.Size(252, 23)
        Me.dtpBillDate.TabIndex = 10
        '
        'txtNoOfBags
        '
        Me.txtNoOfBags.Location = New System.Drawing.Point(106, 108)
        Me.txtNoOfBags.Name = "txtNoOfBags"
        Me.txtNoOfBags.Size = New System.Drawing.Size(252, 20)
        Me.txtNoOfBags.TabIndex = 13
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(106, 140)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(252, 20)
        Me.txtAmount.TabIndex = 16
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Amount", "Bags", "ExMillAmount", "Kg"})
        Me.cmbType.Location = New System.Drawing.Point(106, 168)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(133, 22)
        Me.cmbType.Sorted = True
        Me.cmbType.TabIndex = 20
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(245, 171)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(70, 16)
        Me.lblRate.TabIndex = 43
        Me.lblRate.Text = "Com Rate"
        '
        'txtComPer
        '
        Me.txtComPer.Location = New System.Drawing.Point(319, 169)
        Me.txtComPer.Name = "txtComPer"
        Me.txtComPer.Size = New System.Drawing.Size(39, 20)
        Me.txtComPer.TabIndex = 21
        Me.txtComPer.Text = "1"
        Me.txtComPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTaxAmt
        '
        Me.lblTaxAmt.AutoSize = True
        Me.lblTaxAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmt.Location = New System.Drawing.Point(173, 204)
        Me.lblTaxAmt.Name = "lblTaxAmt"
        Me.lblTaxAmt.Size = New System.Drawing.Size(84, 16)
        Me.lblTaxAmt.TabIndex = 27
        Me.lblTaxAmt.Text = "Tax Amount"
        '
        'cmbTaxPer
        '
        Me.cmbTaxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTaxPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTaxPer.FormattingEnabled = True
        Me.cmbTaxPer.Items.AddRange(New Object() {"12.36"})
        Me.cmbTaxPer.Location = New System.Drawing.Point(106, 201)
        Me.cmbTaxPer.Name = "cmbTaxPer"
        Me.cmbTaxPer.Size = New System.Drawing.Size(61, 22)
        Me.cmbTaxPer.Sorted = True
        Me.cmbTaxPer.TabIndex = 26
        '
        'txtTaxAmt
        '
        Me.txtTaxAmt.Location = New System.Drawing.Point(257, 202)
        Me.txtTaxAmt.Name = "txtTaxAmt"
        Me.txtTaxAmt.Size = New System.Drawing.Size(101, 20)
        Me.txtTaxAmt.TabIndex = 28
        Me.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDSAmount
        '
        Me.txtTDSAmount.Location = New System.Drawing.Point(141, 360)
        Me.txtTDSAmount.Name = "txtTDSAmount"
        Me.txtTDSAmount.Size = New System.Drawing.Size(252, 20)
        Me.txtTDSAmount.TabIndex = 32
        Me.txtTDSAmount.Visible = False
        '
        'cmbCompany
        '
        Me.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCompany.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(106, 230)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(252, 22)
        Me.cmbCompany.Sorted = True
        Me.cmbCompany.TabIndex = 36
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(106, 434)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(252, 20)
        Me.txtChequeNo.TabIndex = 40
        Me.txtChequeNo.Visible = False
        '
        'lblChqueDate
        '
        Me.lblChqueDate.AutoSize = True
        Me.lblChqueDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChqueDate.Location = New System.Drawing.Point(386, 436)
        Me.lblChqueDate.Name = "lblChqueDate"
        Me.lblChqueDate.Size = New System.Drawing.Size(90, 16)
        Me.lblChqueDate.TabIndex = 41
        Me.lblChqueDate.Text = "Cheque Date"
        Me.lblChqueDate.Visible = False
        '
        'lblChequeNo
        '
        Me.lblChequeNo.AutoSize = True
        Me.lblChequeNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNo.Location = New System.Drawing.Point(15, 436)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(70, 16)
        Me.lblChequeNo.TabIndex = 39
        Me.lblChequeNo.Text = "Chque No"
        Me.lblChequeNo.Visible = False
        '
        'lblChequeAmt
        '
        Me.lblChequeAmt.AutoSize = True
        Me.lblChequeAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeAmt.Location = New System.Drawing.Point(386, 407)
        Me.lblChequeAmt.Name = "lblChequeAmt"
        Me.lblChequeAmt.Size = New System.Drawing.Size(110, 16)
        Me.lblChequeAmt.TabIndex = 37
        Me.lblChequeAmt.Text = "Cheque Amount"
        Me.lblChequeAmt.Visible = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(15, 233)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(68, 16)
        Me.lblCompanyName.TabIndex = 35
        Me.lblCompanyName.Text = "Company"
        '
        'lblTDSYear
        '
        Me.lblTDSYear.AutoSize = True
        Me.lblTDSYear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDSYear.Location = New System.Drawing.Point(421, 362)
        Me.lblTDSYear.Name = "lblTDSYear"
        Me.lblTDSYear.Size = New System.Drawing.Size(66, 16)
        Me.lblTDSYear.TabIndex = 33
        Me.lblTDSYear.Text = "TDS Year"
        Me.lblTDSYear.Visible = False
        '
        'lblTDSAmount
        '
        Me.lblTDSAmount.AutoSize = True
        Me.lblTDSAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDSAmount.Location = New System.Drawing.Point(50, 362)
        Me.lblTDSAmount.Name = "lblTDSAmount"
        Me.lblTDSAmount.Size = New System.Drawing.Size(87, 16)
        Me.lblTDSAmount.TabIndex = 31
        Me.lblTDSAmount.Text = "TDS Amount"
        Me.lblTDSAmount.Visible = False
        '
        'lblCommissionType
        '
        Me.lblCommissionType.AutoSize = True
        Me.lblCommissionType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommissionType.Location = New System.Drawing.Point(15, 171)
        Me.lblCommissionType.Name = "lblCommissionType"
        Me.lblCommissionType.Size = New System.Drawing.Size(71, 16)
        Me.lblCommissionType.TabIndex = 19
        Me.lblCommissionType.Text = "Com Type"
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(634, 9)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.ShowUpDown = True
        Me.dtpTDate.Size = New System.Drawing.Size(124, 23)
        Me.dtpTDate.TabIndex = 4
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(499, 9)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.ShowUpDown = True
        Me.dtpFDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpFDate.TabIndex = 3
        '
        'txtBillingName
        '
        Me.txtBillingName.Location = New System.Drawing.Point(865, 484)
        Me.txtBillingName.Name = "txtBillingName"
        Me.txtBillingName.Size = New System.Drawing.Size(252, 20)
        Me.txtBillingName.TabIndex = 5
        Me.txtBillingName.Visible = False
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(386, 204)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(92, 16)
        Me.lblTotalAmount.TabIndex = 29
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(15, 204)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(83, 16)
        Me.lblTax.TabIndex = 25
        Me.lblTax.Text = "Service Tax"
        '
        'lblPeriodFrom
        '
        Me.lblPeriodFrom.AutoSize = True
        Me.lblPeriodFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriodFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodFrom.Location = New System.Drawing.Point(386, 12)
        Me.lblPeriodFrom.Name = "lblPeriodFrom"
        Me.lblPeriodFrom.Size = New System.Drawing.Size(50, 16)
        Me.lblPeriodFrom.TabIndex = 2
        Me.lblPeriodFrom.Text = "Period"
        '
        'lblCommissionPer
        '
        Me.lblCommissionPer.AutoSize = True
        Me.lblCommissionPer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommissionPer.Location = New System.Drawing.Point(386, 171)
        Me.lblCommissionPer.Name = "lblCommissionPer"
        Me.lblCommissionPer.Size = New System.Drawing.Size(85, 16)
        Me.lblCommissionPer.TabIndex = 22
        Me.lblCommissionPer.Text = "Commission"
        '
        'lblExMillAmt
        '
        Me.lblExMillAmt.AutoSize = True
        Me.lblExMillAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExMillAmt.Location = New System.Drawing.Point(386, 140)
        Me.lblExMillAmt.Name = "lblExMillAmt"
        Me.lblExMillAmt.Size = New System.Drawing.Size(104, 16)
        Me.lblExMillAmt.TabIndex = 17
        Me.lblExMillAmt.Text = "Ex-Mill Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Amount"
        '
        'lblTotalKg
        '
        Me.lblTotalKg.AutoSize = True
        Me.lblTotalKg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalKg.Location = New System.Drawing.Point(386, 108)
        Me.lblTotalKg.Name = "lblTotalKg"
        Me.lblTotalKg.Size = New System.Drawing.Size(60, 16)
        Me.lblTotalKg.TabIndex = 14
        Me.lblTotalKg.Text = "Total Kg"
        '
        'lblNoOfBags
        '
        Me.lblNoOfBags.AutoSize = True
        Me.lblNoOfBags.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfBags.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBags.Location = New System.Drawing.Point(15, 110)
        Me.lblNoOfBags.Name = "lblNoOfBags"
        Me.lblNoOfBags.Size = New System.Drawing.Size(78, 16)
        Me.lblNoOfBags.TabIndex = 11
        Me.lblNoOfBags.Text = "No Of Bags"
        '
        'lblBillDate
        '
        Me.lblBillDate.AutoSize = True
        Me.lblBillDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDate.Location = New System.Drawing.Point(15, 78)
        Me.lblBillDate.Name = "lblBillDate"
        Me.lblBillDate.Size = New System.Drawing.Size(62, 16)
        Me.lblBillDate.TabIndex = 9
        Me.lblBillDate.Text = "Bill Date"
        Me.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDNd
        '
        Me.lblDNd.AutoSize = True
        Me.lblDNd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNd.Location = New System.Drawing.Point(15, 12)
        Me.lblDNd.Name = "lblDNd"
        Me.lblDNd.Size = New System.Drawing.Size(57, 16)
        Me.lblDNd.TabIndex = 0
        Me.lblDNd.Text = "Debit Id"
        '
        'LinkParty
        '
        Me.LinkParty.BackColor = System.Drawing.Color.White
        Me.LinkParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LinkParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LinkParty.Location = New System.Drawing.Point(708, -20)
        Me.LinkParty.Name = "LinkParty"
        Me.LinkParty.Size = New System.Drawing.Size(20, 20)
        Me.LinkParty.TabIndex = 41
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
        Me.Label1.TabIndex = 42
        Me.Label1.Text = " C&ustomer Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(386, 44)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(106, 12)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(252, 22)
        Me.txtCode.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(106, 12)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(252, 22)
        Me.txtId.TabIndex = 1
        '
        'dgvDebitDetails
        '
        Me.dgvDebitDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitDetails.Location = New System.Drawing.Point(18, 258)
        Me.dgvDebitDetails.Name = "dgvDebitDetails"
        Me.dgvDebitDetails.Size = New System.Drawing.Size(740, 244)
        Me.dgvDebitDetails.TabIndex = 31
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.txtNarration)
        Me.pnlContent.Controls.Add(Me.txtStatusColor)
        Me.pnlContent.Controls.Add(Me.txtStatus)
        Me.pnlContent.Controls.Add(Me.dtpRDate3)
        Me.pnlContent.Controls.Add(Me.txtRAmt3)
        Me.pnlContent.Controls.Add(Me.txtRCNo3)
        Me.pnlContent.Controls.Add(Me.dtpRDate2)
        Me.pnlContent.Controls.Add(Me.txtRAmt2)
        Me.pnlContent.Controls.Add(Me.txtRCNo2)
        Me.pnlContent.Controls.Add(Me.dtpRDate1)
        Me.pnlContent.Controls.Add(Me.txtRCNo1)
        Me.pnlContent.Controls.Add(Me.txtRAmt1)
        Me.pnlContent.Controls.Add(Me.txtOpBal)
        Me.pnlContent.Controls.Add(Me.txtMillCode)
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 545)
        Me.pnlContent.TabIndex = 2
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(70, 499)
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(127, 20)
        Me.txtNarration.TabIndex = 64
        Me.txtNarration.Visible = False
        '
        'txtStatusColor
        '
        Me.txtStatusColor.Location = New System.Drawing.Point(70, 462)
        Me.txtStatusColor.Name = "txtStatusColor"
        Me.txtStatusColor.Size = New System.Drawing.Size(127, 20)
        Me.txtStatusColor.TabIndex = 63
        Me.txtStatusColor.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(70, 436)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(127, 20)
        Me.txtStatus.TabIndex = 62
        Me.txtStatus.Visible = False
        '
        'dtpRDate3
        '
        Me.dtpRDate3.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDate3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate3.Location = New System.Drawing.Point(70, 398)
        Me.dtpRDate3.Name = "dtpRDate3"
        Me.dtpRDate3.ShowUpDown = True
        Me.dtpRDate3.Size = New System.Drawing.Size(127, 23)
        Me.dtpRDate3.TabIndex = 59
        Me.dtpRDate3.Visible = False
        '
        'txtRAmt3
        '
        Me.txtRAmt3.Location = New System.Drawing.Point(70, 363)
        Me.txtRAmt3.Name = "txtRAmt3"
        Me.txtRAmt3.Size = New System.Drawing.Size(127, 20)
        Me.txtRAmt3.TabIndex = 61
        Me.txtRAmt3.Visible = False
        '
        'txtRCNo3
        '
        Me.txtRCNo3.Location = New System.Drawing.Point(70, 337)
        Me.txtRCNo3.Name = "txtRCNo3"
        Me.txtRCNo3.Size = New System.Drawing.Size(127, 20)
        Me.txtRCNo3.TabIndex = 60
        Me.txtRCNo3.Visible = False
        '
        'dtpRDate2
        '
        Me.dtpRDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate2.Location = New System.Drawing.Point(70, 308)
        Me.dtpRDate2.Name = "dtpRDate2"
        Me.dtpRDate2.ShowUpDown = True
        Me.dtpRDate2.Size = New System.Drawing.Size(127, 23)
        Me.dtpRDate2.TabIndex = 56
        Me.dtpRDate2.Visible = False
        '
        'txtRAmt2
        '
        Me.txtRAmt2.Location = New System.Drawing.Point(70, 273)
        Me.txtRAmt2.Name = "txtRAmt2"
        Me.txtRAmt2.Size = New System.Drawing.Size(127, 20)
        Me.txtRAmt2.TabIndex = 58
        Me.txtRAmt2.Visible = False
        '
        'txtRCNo2
        '
        Me.txtRCNo2.Location = New System.Drawing.Point(70, 247)
        Me.txtRCNo2.Name = "txtRCNo2"
        Me.txtRCNo2.Size = New System.Drawing.Size(127, 20)
        Me.txtRCNo2.TabIndex = 57
        Me.txtRCNo2.Visible = False
        '
        'dtpRDate1
        '
        Me.dtpRDate1.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate1.Location = New System.Drawing.Point(70, 218)
        Me.dtpRDate1.Name = "dtpRDate1"
        Me.dtpRDate1.ShowUpDown = True
        Me.dtpRDate1.Size = New System.Drawing.Size(127, 23)
        Me.dtpRDate1.TabIndex = 44
        Me.dtpRDate1.Visible = False
        '
        'txtRCNo1
        '
        Me.txtRCNo1.Location = New System.Drawing.Point(70, 183)
        Me.txtRCNo1.Name = "txtRCNo1"
        Me.txtRCNo1.Size = New System.Drawing.Size(127, 20)
        Me.txtRCNo1.TabIndex = 55
        Me.txtRCNo1.Visible = False
        '
        'txtRAmt1
        '
        Me.txtRAmt1.Location = New System.Drawing.Point(70, 157)
        Me.txtRAmt1.Name = "txtRAmt1"
        Me.txtRAmt1.Size = New System.Drawing.Size(127, 20)
        Me.txtRAmt1.TabIndex = 54
        Me.txtRAmt1.Visible = False
        '
        'txtOpBal
        '
        Me.txtOpBal.Location = New System.Drawing.Point(70, 127)
        Me.txtOpBal.Name = "txtOpBal"
        Me.txtOpBal.Size = New System.Drawing.Size(127, 20)
        Me.txtOpBal.TabIndex = 53
        Me.txtOpBal.Visible = False
        '
        'txtMillCode
        '
        Me.txtMillCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMillCode.Location = New System.Drawing.Point(113, 61)
        Me.txtMillCode.MaxLength = 100
        Me.txtMillCode.Name = "txtMillCode"
        Me.txtMillCode.Size = New System.Drawing.Size(84, 22)
        Me.txtMillCode.TabIndex = 52
        Me.txtMillCode.Visible = False
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
        Me.pnlMain.TabIndex = 7
        '
        'frmDebitTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmDebitTransaction"
        Me.Text = "MILL DEBIT NOTE"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.dgvDebitDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBillingName As System.Windows.Forms.Label
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblDNd As System.Windows.Forms.Label
    Friend WithEvents LinkParty As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddressLine As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents lblBillDate As System.Windows.Forms.Label
    Friend WithEvents dtpBillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoOfBags As System.Windows.Forms.TextBox
    Friend WithEvents lblNoOfBags As System.Windows.Forms.Label
    Friend WithEvents txtTotalKg As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalKg As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtExMillAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblExMillAmt As System.Windows.Forms.Label
    Friend WithEvents lblPeriodFrom As System.Windows.Forms.Label
    Friend WithEvents txtComAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtComPer As System.Windows.Forms.TextBox
    Friend WithEvents lblCommissionPer As System.Windows.Forms.Label
    Friend WithEvents txtTaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents btnBill As System.Windows.Forms.Button
    Friend WithEvents dgvDebitDetails As System.Windows.Forms.DataGridView
    Friend WithEvents txtBillingName As System.Windows.Forms.TextBox
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCommissionType As System.Windows.Forms.Label
    Friend WithEvents txtTDSAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTDSAmount As System.Windows.Forms.Label
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblTDSYear As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTDSYr As System.Windows.Forms.ComboBox
    Friend WithEvents lblChqueDate As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents lblChequeNo As System.Windows.Forms.Label
    Friend WithEvents txtChequeAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblChequeAmt As System.Windows.Forms.Label
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTaxPer As System.Windows.Forms.ComboBox
    Friend WithEvents lblTaxAmt As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents txtMillCode As System.Windows.Forms.TextBox
    Friend WithEvents dtpRDate3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRAmt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRCNo3 As System.Windows.Forms.TextBox
    Friend WithEvents dtpRDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRAmt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRCNo2 As System.Windows.Forms.TextBox
    Friend WithEvents dtpRDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRCNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRAmt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOpBal As System.Windows.Forms.TextBox
    Friend WithEvents txtStatusColor As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
End Class
