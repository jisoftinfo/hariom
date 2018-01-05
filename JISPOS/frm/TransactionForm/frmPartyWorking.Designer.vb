<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartyWorking
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.cmbPartyName = New System.Windows.Forms.ComboBox
        Me.lblRate = New System.Windows.Forms.Label
        Me.txtSNo = New System.Windows.Forms.TextBox
        Me.lblPartyName = New System.Windows.Forms.Label
        Me.txtMasterCode = New System.Windows.Forms.TextBox
        Me.lblSNo = New System.Windows.Forms.Label
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PartyName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoOfBags = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Weight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtDetailsCode = New System.Windows.Forms.TextBox
        Me.lblAmount = New System.Windows.Forms.Label
        Me.txtDetailsId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFreightCharges = New System.Windows.Forms.Label
        Me.txtFreightCharges = New System.Windows.Forms.TextBox
        Me.txtlrno = New System.Windows.Forms.TextBox
        Me.dtpFreightDate = New System.Windows.Forms.DateTimePicker
        Me.lbllrno = New System.Windows.Forms.Label
        Me.lblRefId = New System.Windows.Forms.Label
        Me.txttransporter = New System.Windows.Forms.TextBox
        Me.lblFreightDate = New System.Windows.Forms.Label
        Me.lbltransporter = New System.Windows.Forms.Label
        Me.txtRefId = New System.Windows.Forms.TextBox
        Me.btnBill = New System.Windows.Forms.Button
        Me.ckbisprint = New System.Windows.Forms.CheckBox
        Me.btnsearch1 = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.cmbCFormNo = New System.Windows.Forms.ComboBox
        Me.cmbEFormNo = New System.Windows.Forms.ComboBox
        Me.cmbBillType = New System.Windows.Forms.ComboBox
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.dtpE1Date = New System.Windows.Forms.DateTimePicker
        Me.lblEFormNo = New System.Windows.Forms.Label
        Me.txtCAmount = New System.Windows.Forms.TextBox
        Me.lblCAmount = New System.Windows.Forms.Label
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.pnlTotalAmt = New System.Windows.Forms.Panel
        Me.txtAdvance = New System.Windows.Forms.TextBox
        Me.lblAdvance = New System.Windows.Forms.Label
        Me.cmbTaxPer = New System.Windows.Forms.ComboBox
        Me.txtExtras = New System.Windows.Forms.TextBox
        Me.lblVehicle = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblTotTax = New System.Windows.Forms.Label
        Me.txtTaxAmt = New System.Windows.Forms.TextBox
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.txtItemAmt = New System.Windows.Forms.TextBox
        Me.lblType = New System.Windows.Forms.Label
        Me.lblTotItemAmt = New System.Windows.Forms.Label
        Me.lblE1Date = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.dtpPWDate = New System.Windows.Forms.DateTimePicker
        Me.lblCFormNo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbEstimateCode = New System.Windows.Forms.ComboBox
        Me.lblEstimateCode = New System.Windows.Forms.Label
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.lblWeight = New System.Windows.Forms.Label
        Me.txtNOOFBags = New System.Windows.Forms.TextBox
        Me.lblNoOfPiece = New System.Windows.Forms.Label
        Me.cmbUOM = New System.Windows.Forms.ComboBox
        Me.lblUOM = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtAddress4 = New System.Windows.Forms.TextBox
        Me.txtorderno = New System.Windows.Forms.TextBox
        Me.txtItemsAmount = New System.Windows.Forms.TextBox
        Me.lblorderno = New System.Windows.Forms.Label
        Me.lblItemAmount = New System.Windows.Forms.Label
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.lblorderdate = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.txtTotalDiscount = New System.Windows.Forms.TextBox
        Me.txtAddress3 = New System.Windows.Forms.TextBox
        Me.txtRoundOff = New System.Windows.Forms.TextBox
        Me.lblRoundOff = New System.Windows.Forms.Label
        Me.cmbTaxType = New System.Windows.Forms.ComboBox
        Me.cmbTax = New System.Windows.Forms.ComboBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblMillName = New System.Windows.Forms.Label
        Me.lblwords = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblvalue = New System.Windows.Forms.Label
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnView = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlTotalAmt.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(540, 27)
        Me.txtRate.MaxLength = 300
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(89, 22)
        Me.txtRate.TabIndex = 11
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbPartyName
        '
        Me.cmbPartyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPartyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbPartyName.Location = New System.Drawing.Point(41, 27)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(253, 22)
        Me.cmbPartyName.TabIndex = 3
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Maroon
        Me.lblRate.Location = New System.Drawing.Point(540, 5)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(89, 22)
        Me.lblRate.TabIndex = 10
        Me.lblRate.Tag = "Heading"
        Me.lblRate.Text = "Rate"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSNo
        '
        Me.txtSNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNo.Location = New System.Drawing.Point(10, 27)
        Me.txtSNo.MaxLength = 300
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.ReadOnly = True
        Me.txtSNo.Size = New System.Drawing.Size(31, 22)
        Me.txtSNo.TabIndex = 1
        '
        'lblPartyName
        '
        Me.lblPartyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPartyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.ForeColor = System.Drawing.Color.Maroon
        Me.lblPartyName.Location = New System.Drawing.Point(41, 5)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(253, 22)
        Me.lblPartyName.TabIndex = 2
        Me.lblPartyName.Tag = "Heading"
        Me.lblPartyName.Text = "Party Name"
        Me.lblPartyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasterCode
        '
        Me.txtMasterCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMasterCode.Location = New System.Drawing.Point(172, 57)
        Me.txtMasterCode.MaxLength = 300
        Me.txtMasterCode.Name = "txtMasterCode"
        Me.txtMasterCode.Size = New System.Drawing.Size(76, 22)
        Me.txtMasterCode.TabIndex = 10
        Me.txtMasterCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMasterCode.Visible = False
        '
        'lblSNo
        '
        Me.lblSNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblSNo.Location = New System.Drawing.Point(10, 5)
        Me.lblSNo.Name = "lblSNo"
        Me.lblSNo.Size = New System.Drawing.Size(31, 22)
        Me.lblSNo.TabIndex = 0
        Me.lblSNo.Tag = "Heading"
        Me.lblSNo.Text = "No"
        Me.lblSNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDetails
        '
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.ColumnHeadersVisible = False
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.PartyName, Me.NoOfBags, Me.Weight, Me.UOM, Me.Rate, Me.Amount})
        Me.dgvDetails.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvDetails.Location = New System.Drawing.Point(10, 49)
        Me.dgvDetails.Name = "dgvDetails"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDetails.Size = New System.Drawing.Size(770, 159)
        Me.dgvDetails.TabIndex = 0
        '
        'SNo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.SNo.HeaderText = "SNo"
        Me.SNo.Name = "SNo"
        Me.SNo.ReadOnly = True
        Me.SNo.Width = 25
        '
        'PartyName
        '
        Me.PartyName.HeaderText = "Party Name"
        Me.PartyName.Name = "PartyName"
        '
        'NoOfBags
        '
        Me.NoOfBags.HeaderText = "NoOfBags"
        Me.NoOfBags.Name = "NoOfBags"
        '
        'Weight
        '
        Me.Weight.HeaderText = "weight"
        Me.Weight.Name = "Weight"
        '
        'UOM
        '
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 70)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'txtDetailsCode
        '
        Me.txtDetailsCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailsCode.Location = New System.Drawing.Point(96, 57)
        Me.txtDetailsCode.MaxLength = 300
        Me.txtDetailsCode.Name = "txtDetailsCode"
        Me.txtDetailsCode.Size = New System.Drawing.Size(76, 22)
        Me.txtDetailsCode.TabIndex = 8
        Me.txtDetailsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDetailsCode.Visible = False
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Maroon
        Me.lblAmount.Location = New System.Drawing.Point(629, 5)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(151, 22)
        Me.lblAmount.TabIndex = 12
        Me.lblAmount.Tag = "Heading"
        Me.lblAmount.Text = "Amount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDetailsId
        '
        Me.txtDetailsId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailsId.Location = New System.Drawing.Point(20, 57)
        Me.txtDetailsId.MaxLength = 300
        Me.txtDetailsId.Name = "txtDetailsId"
        Me.txtDetailsId.Size = New System.Drawing.Size(76, 22)
        Me.txtDetailsId.TabIndex = 7
        Me.txtDetailsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDetailsId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(516, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CST"
        Me.Label1.Visible = False
        '
        'lblFreightCharges
        '
        Me.lblFreightCharges.AutoSize = True
        Me.lblFreightCharges.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreightCharges.Location = New System.Drawing.Point(0, 5)
        Me.lblFreightCharges.Name = "lblFreightCharges"
        Me.lblFreightCharges.Size = New System.Drawing.Size(105, 16)
        Me.lblFreightCharges.TabIndex = 2
        Me.lblFreightCharges.Text = "FreightCharges"
        Me.lblFreightCharges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFreightCharges
        '
        Me.txtFreightCharges.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFreightCharges.Location = New System.Drawing.Point(109, 3)
        Me.txtFreightCharges.MaxLength = 300
        Me.txtFreightCharges.Name = "txtFreightCharges"
        Me.txtFreightCharges.Size = New System.Drawing.Size(188, 22)
        Me.txtFreightCharges.TabIndex = 3
        Me.txtFreightCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtlrno
        '
        Me.txtlrno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtlrno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtlrno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlrno.ForeColor = System.Drawing.Color.DarkGray
        Me.txtlrno.Location = New System.Drawing.Point(96, 69)
        Me.txtlrno.MaxLength = 500
        Me.txtlrno.Name = "txtlrno"
        Me.txtlrno.Size = New System.Drawing.Size(68, 22)
        Me.txtlrno.TabIndex = 9
        Me.txtlrno.Visible = False
        '
        'dtpFreightDate
        '
        Me.dtpFreightDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFreightDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFreightDate.Location = New System.Drawing.Point(109, 31)
        Me.dtpFreightDate.Name = "dtpFreightDate"
        Me.dtpFreightDate.Size = New System.Drawing.Size(130, 20)
        Me.dtpFreightDate.TabIndex = 5
        Me.dtpFreightDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lbllrno
        '
        Me.lbllrno.AutoSize = True
        Me.lbllrno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllrno.Location = New System.Drawing.Point(-99, 74)
        Me.lbllrno.Name = "lbllrno"
        Me.lbllrno.Size = New System.Drawing.Size(50, 16)
        Me.lbllrno.TabIndex = 1
        Me.lbllrno.Text = "L.R No"
        Me.lbllrno.Visible = False
        '
        'lblRefId
        '
        Me.lblRefId.AutoSize = True
        Me.lblRefId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefId.Location = New System.Drawing.Point(305, 7)
        Me.lblRefId.Name = "lblRefId"
        Me.lblRefId.Size = New System.Drawing.Size(41, 16)
        Me.lblRefId.TabIndex = 14
        Me.lblRefId.Text = "RefId"
        Me.lblRefId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRefId.Visible = False
        '
        'txttransporter
        '
        Me.txttransporter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txttransporter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txttransporter.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransporter.ForeColor = System.Drawing.Color.DarkGray
        Me.txttransporter.Location = New System.Drawing.Point(96, 41)
        Me.txttransporter.MaxLength = 500
        Me.txttransporter.Name = "txttransporter"
        Me.txttransporter.Size = New System.Drawing.Size(68, 22)
        Me.txttransporter.TabIndex = 6
        Me.txttransporter.Visible = False
        '
        'lblFreightDate
        '
        Me.lblFreightDate.AutoSize = True
        Me.lblFreightDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFreightDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreightDate.Location = New System.Drawing.Point(3, 31)
        Me.lblFreightDate.Name = "lblFreightDate"
        Me.lblFreightDate.Size = New System.Drawing.Size(82, 16)
        Me.lblFreightDate.TabIndex = 4
        Me.lblFreightDate.Text = "FreightDate"
        '
        'lbltransporter
        '
        Me.lbltransporter.AutoSize = True
        Me.lbltransporter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransporter.Location = New System.Drawing.Point(-99, 46)
        Me.lbltransporter.Name = "lbltransporter"
        Me.lbltransporter.Size = New System.Drawing.Size(80, 16)
        Me.lbltransporter.TabIndex = 0
        Me.lbltransporter.Text = "Transporter"
        Me.lbltransporter.Visible = False
        '
        'txtRefId
        '
        Me.txtRefId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefId.Location = New System.Drawing.Point(352, 5)
        Me.txtRefId.MaxLength = 300
        Me.txtRefId.Name = "txtRefId"
        Me.txtRefId.Size = New System.Drawing.Size(188, 22)
        Me.txtRefId.TabIndex = 15
        Me.txtRefId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRefId.Visible = False
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.Color.White
        Me.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBill.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnBill.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBill.Location = New System.Drawing.Point(467, 1)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(66, 49)
        Me.btnBill.TabIndex = 7
        Me.btnBill.Text = " &Bill"
        Me.btnBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBill.UseVisualStyleBackColor = False
        '
        'ckbisprint
        '
        Me.ckbisprint.AutoSize = True
        Me.ckbisprint.Checked = True
        Me.ckbisprint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbisprint.Location = New System.Drawing.Point(538, 16)
        Me.ckbisprint.Name = "ckbisprint"
        Me.ckbisprint.Size = New System.Drawing.Size(54, 17)
        Me.ckbisprint.TabIndex = 6
        Me.ckbisprint.Text = "Isprint"
        Me.ckbisprint.UseVisualStyleBackColor = True
        '
        'btnsearch1
        '
        Me.btnsearch1.BackColor = System.Drawing.Color.White
        Me.btnsearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch1.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnsearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsearch1.Location = New System.Drawing.Point(382, 2)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnsearch1.TabIndex = 5
        Me.btnsearch1.Text = "SEARC&H"
        Me.btnsearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsearch1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.JISPOS.My.Resources.Resources.adds35
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(14, 2)
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
        Me.btnSave.Location = New System.Drawing.Point(86, 2)
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
        Me.btnExit.Location = New System.Drawing.Point(306, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = " EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.JISPOS.My.Resources.Resources.delete35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(160, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
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
        Me.pnlMain.TabIndex = 10
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 95)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 557)
        Me.pnlContent.TabIndex = 1
        '
        'pnlForm
        '
        Me.pnlForm.AutoScroll = True
        Me.pnlForm.Controls.Add(Me.cmbMillName)
        Me.pnlForm.Controls.Add(Me.cmbCFormNo)
        Me.pnlForm.Controls.Add(Me.cmbEFormNo)
        Me.pnlForm.Controls.Add(Me.cmbBillType)
        Me.pnlForm.Controls.Add(Me.txtInvoiceNo)
        Me.pnlForm.Controls.Add(Me.dtpE1Date)
        Me.pnlForm.Controls.Add(Me.lblEFormNo)
        Me.pnlForm.Controls.Add(Me.txtCAmount)
        Me.pnlForm.Controls.Add(Me.lblCAmount)
        Me.pnlForm.Controls.Add(Me.lblInvoiceNo)
        Me.pnlForm.Controls.Add(Me.pnlTotalAmt)
        Me.pnlForm.Controls.Add(Me.txtItemAmt)
        Me.pnlForm.Controls.Add(Me.lblType)
        Me.pnlForm.Controls.Add(Me.lblTotItemAmt)
        Me.pnlForm.Controls.Add(Me.lblE1Date)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.dtpPWDate)
        Me.pnlForm.Controls.Add(Me.lblCFormNo)
        Me.pnlForm.Controls.Add(Me.Panel1)
        Me.pnlForm.Controls.Add(Me.lblMillName)
        Me.pnlForm.Controls.Add(Me.lblwords)
        Me.pnlForm.Controls.Add(Me.txtNarration)
        Me.pnlForm.Controls.Add(Me.lblNarration)
        Me.pnlForm.Controls.Add(Me.lblDate)
        Me.pnlForm.Controls.Add(Me.lblId)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Controls.Add(Me.lblvalue)
        Me.pnlForm.Location = New System.Drawing.Point(13, 6)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1100, 545)
        Me.pnlForm.TabIndex = 0
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(461, 11)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(208, 22)
        Me.cmbMillName.TabIndex = 3
        '
        'cmbCFormNo
        '
        Me.cmbCFormNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCFormNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCFormNo.FormattingEnabled = True
        Me.cmbCFormNo.Location = New System.Drawing.Point(461, 45)
        Me.cmbCFormNo.Name = "cmbCFormNo"
        Me.cmbCFormNo.Size = New System.Drawing.Size(208, 22)
        Me.cmbCFormNo.TabIndex = 9
        '
        'cmbEFormNo
        '
        Me.cmbEFormNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbEFormNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEFormNo.FormattingEnabled = True
        Me.cmbEFormNo.Location = New System.Drawing.Point(461, 84)
        Me.cmbEFormNo.Name = "cmbEFormNo"
        Me.cmbEFormNo.Size = New System.Drawing.Size(208, 22)
        Me.cmbEFormNo.TabIndex = 15
        '
        'cmbBillType
        '
        Me.cmbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbBillType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBillType.FormattingEnabled = True
        Me.cmbBillType.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbBillType.Location = New System.Drawing.Point(172, 49)
        Me.cmbBillType.Name = "cmbBillType"
        Me.cmbBillType.Size = New System.Drawing.Size(181, 22)
        Me.cmbBillType.Sorted = True
        Me.cmbBillType.TabIndex = 7
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(172, 88)
        Me.txtInvoiceNo.MaxLength = 300
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(181, 22)
        Me.txtInvoiceNo.TabIndex = 13
        '
        'dtpE1Date
        '
        Me.dtpE1Date.CustomFormat = "dd/MM/yyyy"
        Me.dtpE1Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpE1Date.Location = New System.Drawing.Point(766, 83)
        Me.dtpE1Date.Name = "dtpE1Date"
        Me.dtpE1Date.ShowUpDown = True
        Me.dtpE1Date.Size = New System.Drawing.Size(181, 20)
        Me.dtpE1Date.TabIndex = 17
        Me.dtpE1Date.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lblEFormNo
        '
        Me.lblEFormNo.AutoSize = True
        Me.lblEFormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFormNo.Location = New System.Drawing.Point(371, 87)
        Me.lblEFormNo.Name = "lblEFormNo"
        Me.lblEFormNo.Size = New System.Drawing.Size(74, 16)
        Me.lblEFormNo.TabIndex = 14
        Me.lblEFormNo.Text = "E Form No"
        '
        'txtCAmount
        '
        Me.txtCAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAmount.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCAmount.Location = New System.Drawing.Point(766, 48)
        Me.txtCAmount.MaxLength = 500
        Me.txtCAmount.Name = "txtCAmount"
        Me.txtCAmount.Size = New System.Drawing.Size(181, 22)
        Me.txtCAmount.TabIndex = 11
        '
        'lblCAmount
        '
        Me.lblCAmount.AutoSize = True
        Me.lblCAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAmount.Location = New System.Drawing.Point(678, 48)
        Me.lblCAmount.Name = "lblCAmount"
        Me.lblCAmount.Size = New System.Drawing.Size(70, 16)
        Me.lblCAmount.TabIndex = 10
        Me.lblCAmount.Text = "C Amount"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(89, 91)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(75, 16)
        Me.lblInvoiceNo.TabIndex = 12
        Me.lblInvoiceNo.Text = "Invoice No"
        '
        'pnlTotalAmt
        '
        Me.pnlTotalAmt.Controls.Add(Me.txtAdvance)
        Me.pnlTotalAmt.Controls.Add(Me.lblAdvance)
        Me.pnlTotalAmt.Controls.Add(Me.cmbTaxPer)
        Me.pnlTotalAmt.Controls.Add(Me.txtExtras)
        Me.pnlTotalAmt.Controls.Add(Me.lblVehicle)
        Me.pnlTotalAmt.Controls.Add(Me.txtDiscount)
        Me.pnlTotalAmt.Controls.Add(Me.lblDiscount)
        Me.pnlTotalAmt.Controls.Add(Me.lblTotTax)
        Me.pnlTotalAmt.Controls.Add(Me.txtTaxAmt)
        Me.pnlTotalAmt.Controls.Add(Me.lblTotalAmount)
        Me.pnlTotalAmt.Controls.Add(Me.txtTotalAmount)
        Me.pnlTotalAmt.Location = New System.Drawing.Point(461, 378)
        Me.pnlTotalAmt.Name = "pnlTotalAmt"
        Me.pnlTotalAmt.Size = New System.Drawing.Size(419, 164)
        Me.pnlTotalAmt.TabIndex = 21
        '
        'txtAdvance
        '
        Me.txtAdvance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAdvance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAdvance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvance.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAdvance.Location = New System.Drawing.Point(220, 107)
        Me.txtAdvance.MaxLength = 500
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(188, 22)
        Me.txtAdvance.TabIndex = 8
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvance.Location = New System.Drawing.Point(120, 110)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(63, 16)
        Me.lblAdvance.TabIndex = 7
        Me.lblAdvance.Text = "Advance"
        '
        'cmbTaxPer
        '
        Me.cmbTaxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTaxPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTaxPer.FormattingEnabled = True
        Me.cmbTaxPer.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbTaxPer.Location = New System.Drawing.Point(220, 11)
        Me.cmbTaxPer.Name = "cmbTaxPer"
        Me.cmbTaxPer.Size = New System.Drawing.Size(51, 22)
        Me.cmbTaxPer.TabIndex = 1
        '
        'txtExtras
        '
        Me.txtExtras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtExtras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtExtras.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtras.ForeColor = System.Drawing.Color.DarkGray
        Me.txtExtras.Location = New System.Drawing.Point(220, 77)
        Me.txtExtras.MaxLength = 500
        Me.txtExtras.Name = "txtExtras"
        Me.txtExtras.Size = New System.Drawing.Size(188, 22)
        Me.txtExtras.TabIndex = 6
        Me.txtExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVehicle
        '
        Me.lblVehicle.AutoSize = True
        Me.lblVehicle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicle.Location = New System.Drawing.Point(120, 80)
        Me.lblVehicle.Name = "lblVehicle"
        Me.lblVehicle.Size = New System.Drawing.Size(47, 16)
        Me.lblVehicle.TabIndex = 5
        Me.lblVehicle.Text = "Extras"
        '
        'txtDiscount
        '
        Me.txtDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDiscount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.DarkGray
        Me.txtDiscount.Location = New System.Drawing.Point(220, 43)
        Me.txtDiscount.MaxLength = 500
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(188, 22)
        Me.txtDiscount.TabIndex = 4
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(120, 46)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(62, 16)
        Me.lblDiscount.TabIndex = 3
        Me.lblDiscount.Text = "Discount"
        '
        'lblTotTax
        '
        Me.lblTotTax.AutoSize = True
        Me.lblTotTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTax.Location = New System.Drawing.Point(120, 14)
        Me.lblTotTax.Name = "lblTotTax"
        Me.lblTotTax.Size = New System.Drawing.Size(31, 16)
        Me.lblTotTax.TabIndex = 0
        Me.lblTotTax.Text = "Ta&x"
        Me.lblTotTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTaxAmt
        '
        Me.txtTaxAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxAmt.Location = New System.Drawing.Point(277, 11)
        Me.txtTaxAmt.MaxLength = 300
        Me.txtTaxAmt.Name = "txtTaxAmt"
        Me.txtTaxAmt.ReadOnly = True
        Me.txtTaxAmt.Size = New System.Drawing.Size(132, 22)
        Me.txtTaxAmt.TabIndex = 2
        Me.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(120, 138)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(92, 16)
        Me.lblTotalAmount.TabIndex = 9
        Me.lblTotalAmount.Text = "Total Amount"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(221, 135)
        Me.txtTotalAmount.MaxLength = 300
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(188, 22)
        Me.txtTotalAmount.TabIndex = 10
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemAmt
        '
        Me.txtItemAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemAmt.Location = New System.Drawing.Point(690, 355)
        Me.txtItemAmt.MaxLength = 300
        Me.txtItemAmt.Name = "txtItemAmt"
        Me.txtItemAmt.ReadOnly = True
        Me.txtItemAmt.Size = New System.Drawing.Size(188, 22)
        Me.txtItemAmt.TabIndex = 20
        Me.txtItemAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(89, 54)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(47, 13)
        Me.lblType.TabIndex = 6
        Me.lblType.Text = "Bill Type"
        '
        'lblTotItemAmt
        '
        Me.lblTotItemAmt.AutoSize = True
        Me.lblTotItemAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotItemAmt.Location = New System.Drawing.Point(586, 355)
        Me.lblTotItemAmt.Name = "lblTotItemAmt"
        Me.lblTotItemAmt.Size = New System.Drawing.Size(89, 16)
        Me.lblTotItemAmt.TabIndex = 19
        Me.lblTotItemAmt.Text = "Item Amount"
        Me.lblTotItemAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblE1Date
        '
        Me.lblE1Date.AutoSize = True
        Me.lblE1Date.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE1Date.Location = New System.Drawing.Point(678, 87)
        Me.lblE1Date.Name = "lblE1Date"
        Me.lblE1Date.Size = New System.Drawing.Size(56, 16)
        Me.lblE1Date.TabIndex = 16
        Me.lblE1Date.Text = "E1 Date"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(172, 11)
        Me.txtCode.MaxLength = 150
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(181, 22)
        Me.txtCode.TabIndex = 1
        '
        'dtpPWDate
        '
        Me.dtpPWDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPWDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPWDate.Location = New System.Drawing.Point(766, 12)
        Me.dtpPWDate.Name = "dtpPWDate"
        Me.dtpPWDate.ShowUpDown = True
        Me.dtpPWDate.Size = New System.Drawing.Size(181, 20)
        Me.dtpPWDate.TabIndex = 5
        Me.dtpPWDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lblCFormNo
        '
        Me.lblCFormNo.AutoSize = True
        Me.lblCFormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFormNo.Location = New System.Drawing.Point(371, 48)
        Me.lblCFormNo.Name = "lblCFormNo"
        Me.lblCFormNo.Size = New System.Drawing.Size(75, 16)
        Me.lblCFormNo.TabIndex = 8
        Me.lblCFormNo.Text = "C Form No"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cmbEstimateCode)
        Me.Panel1.Controls.Add(Me.lblEstimateCode)
        Me.Panel1.Controls.Add(Me.txtWeight)
        Me.Panel1.Controls.Add(Me.lblWeight)
        Me.Panel1.Controls.Add(Me.txtNOOFBags)
        Me.Panel1.Controls.Add(Me.lblNoOfPiece)
        Me.Panel1.Controls.Add(Me.cmbUOM)
        Me.Panel1.Controls.Add(Me.lblUOM)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.lblAmount)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.cmbPartyName)
        Me.Panel1.Controls.Add(Me.txtSNo)
        Me.Panel1.Controls.Add(Me.lblRate)
        Me.Panel1.Controls.Add(Me.lblPartyName)
        Me.Panel1.Controls.Add(Me.lblSNo)
        Me.Panel1.Controls.Add(Me.dgvDetails)
        Me.Panel1.Location = New System.Drawing.Point(83, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 222)
        Me.Panel1.TabIndex = 18
        '
        'cmbEstimateCode
        '
        Me.cmbEstimateCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbEstimateCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstimateCode.FormattingEnabled = True
        Me.cmbEstimateCode.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbEstimateCode.Location = New System.Drawing.Point(294, 122)
        Me.cmbEstimateCode.Name = "cmbEstimateCode"
        Me.cmbEstimateCode.Size = New System.Drawing.Size(152, 22)
        Me.cmbEstimateCode.TabIndex = 23
        Me.cmbEstimateCode.Visible = False
        '
        'lblEstimateCode
        '
        Me.lblEstimateCode.AutoSize = True
        Me.lblEstimateCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimateCode.Location = New System.Drawing.Point(674, 92)
        Me.lblEstimateCode.Name = "lblEstimateCode"
        Me.lblEstimateCode.Size = New System.Drawing.Size(95, 16)
        Me.lblEstimateCode.TabIndex = 22
        Me.lblEstimateCode.Text = "EstimateCode"
        Me.lblEstimateCode.Visible = False
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(383, 27)
        Me.txtWeight.MaxLength = 300
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(89, 22)
        Me.txtWeight.TabIndex = 7
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWeight
        '
        Me.lblWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.Maroon
        Me.lblWeight.Location = New System.Drawing.Point(383, 5)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(89, 22)
        Me.lblWeight.TabIndex = 6
        Me.lblWeight.Tag = "Heading"
        Me.lblWeight.Text = "Weight"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNOOFBags
        '
        Me.txtNOOFBags.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOOFBags.Location = New System.Drawing.Point(294, 27)
        Me.txtNOOFBags.MaxLength = 300
        Me.txtNOOFBags.Name = "txtNOOFBags"
        Me.txtNOOFBags.Size = New System.Drawing.Size(89, 22)
        Me.txtNOOFBags.TabIndex = 5
        Me.txtNOOFBags.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNoOfPiece
        '
        Me.lblNoOfPiece.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNoOfPiece.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfPiece.ForeColor = System.Drawing.Color.Maroon
        Me.lblNoOfPiece.Location = New System.Drawing.Point(294, 5)
        Me.lblNoOfPiece.Name = "lblNoOfPiece"
        Me.lblNoOfPiece.Size = New System.Drawing.Size(89, 22)
        Me.lblNoOfPiece.TabIndex = 4
        Me.lblNoOfPiece.Tag = "Heading"
        Me.lblNoOfPiece.Text = "No Of Bags"
        Me.lblNoOfPiece.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbUOM
        '
        Me.cmbUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbUOM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUOM.FormattingEnabled = True
        Me.cmbUOM.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbUOM.Location = New System.Drawing.Point(472, 27)
        Me.cmbUOM.Name = "cmbUOM"
        Me.cmbUOM.Size = New System.Drawing.Size(68, 22)
        Me.cmbUOM.TabIndex = 9
        '
        'lblUOM
        '
        Me.lblUOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUOM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUOM.ForeColor = System.Drawing.Color.Maroon
        Me.lblUOM.Location = New System.Drawing.Point(472, 5)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(68, 22)
        Me.lblUOM.TabIndex = 8
        Me.lblUOM.Tag = "Heading"
        Me.lblUOM.Text = "UOM"
        Me.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtMasterCode)
        Me.Panel2.Controls.Add(Me.txtDetailsCode)
        Me.Panel2.Controls.Add(Me.txtDetailsId)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblFreightCharges)
        Me.Panel2.Controls.Add(Me.txtFreightCharges)
        Me.Panel2.Controls.Add(Me.txtlrno)
        Me.Panel2.Controls.Add(Me.dtpFreightDate)
        Me.Panel2.Controls.Add(Me.lbllrno)
        Me.Panel2.Controls.Add(Me.lblRefId)
        Me.Panel2.Controls.Add(Me.txttransporter)
        Me.Panel2.Controls.Add(Me.lblFreightDate)
        Me.Panel2.Controls.Add(Me.lbltransporter)
        Me.Panel2.Controls.Add(Me.txtRefId)
        Me.Panel2.Controls.Add(Me.txtAddress4)
        Me.Panel2.Controls.Add(Me.txtorderno)
        Me.Panel2.Controls.Add(Me.txtItemsAmount)
        Me.Panel2.Controls.Add(Me.lblorderno)
        Me.Panel2.Controls.Add(Me.lblItemAmount)
        Me.Panel2.Controls.Add(Me.dtporderdate)
        Me.Panel2.Controls.Add(Me.txtTax)
        Me.Panel2.Controls.Add(Me.lblorderdate)
        Me.Panel2.Controls.Add(Me.lblTax)
        Me.Panel2.Controls.Add(Me.txtTotalDiscount)
        Me.Panel2.Controls.Add(Me.txtAddress3)
        Me.Panel2.Controls.Add(Me.txtRoundOff)
        Me.Panel2.Controls.Add(Me.lblRoundOff)
        Me.Panel2.Controls.Add(Me.cmbTaxType)
        Me.Panel2.Controls.Add(Me.cmbTax)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(524, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 29)
        Me.Panel2.TabIndex = 17
        Me.Panel2.Visible = False
        '
        'txtAddress4
        '
        Me.txtAddress4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress4.Location = New System.Drawing.Point(659, 65)
        Me.txtAddress4.MaxLength = 300
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.Size = New System.Drawing.Size(10, 22)
        Me.txtAddress4.TabIndex = 24
        Me.txtAddress4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAddress4.Visible = False
        '
        'txtorderno
        '
        Me.txtorderno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtorderno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtorderno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorderno.ForeColor = System.Drawing.Color.DarkGray
        Me.txtorderno.Location = New System.Drawing.Point(430, 37)
        Me.txtorderno.MaxLength = 500
        Me.txtorderno.Name = "txtorderno"
        Me.txtorderno.Size = New System.Drawing.Size(12, 22)
        Me.txtorderno.TabIndex = 0
        Me.txtorderno.Visible = False
        '
        'txtItemsAmount
        '
        Me.txtItemsAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemsAmount.Location = New System.Drawing.Point(894, 78)
        Me.txtItemsAmount.MaxLength = 300
        Me.txtItemsAmount.Name = "txtItemsAmount"
        Me.txtItemsAmount.ReadOnly = True
        Me.txtItemsAmount.Size = New System.Drawing.Size(188, 22)
        Me.txtItemsAmount.TabIndex = 12
        Me.txtItemsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtItemsAmount.Visible = False
        '
        'lblorderno
        '
        Me.lblorderno.AutoSize = True
        Me.lblorderno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorderno.Location = New System.Drawing.Point(246, 40)
        Me.lblorderno.Name = "lblorderno"
        Me.lblorderno.Size = New System.Drawing.Size(98, 16)
        Me.lblorderno.TabIndex = 12
        Me.lblorderno.Text = "Order Number"
        Me.lblorderno.Visible = False
        '
        'lblItemAmount
        '
        Me.lblItemAmount.AutoSize = True
        Me.lblItemAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemAmount.Location = New System.Drawing.Point(792, 82)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(91, 16)
        Me.lblItemAmount.TabIndex = 15
        Me.lblItemAmount.Text = "ItemsAmount"
        Me.lblItemAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblItemAmount.Visible = False
        '
        'dtporderdate
        '
        Me.dtporderdate.CustomFormat = "dd/MM/yyyy"
        Me.dtporderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtporderdate.Location = New System.Drawing.Point(659, 37)
        Me.dtporderdate.Name = "dtporderdate"
        Me.dtporderdate.Size = New System.Drawing.Size(10, 20)
        Me.dtporderdate.TabIndex = 22
        Me.dtporderdate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        Me.dtporderdate.Visible = False
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(602, 36)
        Me.txtTax.MaxLength = 300
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(135, 22)
        Me.txtTax.TabIndex = 28
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTax.Visible = False
        '
        'lblorderdate
        '
        Me.lblorderdate.AutoSize = True
        Me.lblorderdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorderdate.Location = New System.Drawing.Point(511, 40)
        Me.lblorderdate.Name = "lblorderdate"
        Me.lblorderdate.Size = New System.Drawing.Size(77, 16)
        Me.lblorderdate.TabIndex = 26
        Me.lblorderdate.Text = "Order Date"
        Me.lblorderdate.Visible = False
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(447, 36)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(31, 16)
        Me.lblTax.TabIndex = 27
        Me.lblTax.Text = "Tax"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTax.Visible = False
        '
        'txtTotalDiscount
        '
        Me.txtTotalDiscount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount.Location = New System.Drawing.Point(549, 8)
        Me.txtTotalDiscount.MaxLength = 300
        Me.txtTotalDiscount.Name = "txtTotalDiscount"
        Me.txtTotalDiscount.Size = New System.Drawing.Size(188, 22)
        Me.txtTotalDiscount.TabIndex = 23
        Me.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalDiscount.Visible = False
        '
        'txtAddress3
        '
        Me.txtAddress3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAddress3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAddress3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress3.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAddress3.Location = New System.Drawing.Point(430, 11)
        Me.txtAddress3.MaxLength = 500
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(239, 22)
        Me.txtAddress3.TabIndex = 16
        Me.txtAddress3.Visible = False
        '
        'txtRoundOff
        '
        Me.txtRoundOff.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundOff.Location = New System.Drawing.Point(549, 94)
        Me.txtRoundOff.MaxLength = 300
        Me.txtRoundOff.Name = "txtRoundOff"
        Me.txtRoundOff.ReadOnly = True
        Me.txtRoundOff.Size = New System.Drawing.Size(188, 22)
        Me.txtRoundOff.TabIndex = 25
        Me.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRoundOff.Visible = False
        '
        'lblRoundOff
        '
        Me.lblRoundOff.AutoSize = True
        Me.lblRoundOff.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundOff.Location = New System.Drawing.Point(447, 94)
        Me.lblRoundOff.Name = "lblRoundOff"
        Me.lblRoundOff.Size = New System.Drawing.Size(71, 16)
        Me.lblRoundOff.TabIndex = 18
        Me.lblRoundOff.Text = "Round Off"
        Me.lblRoundOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRoundOff.Visible = False
        '
        'cmbTaxType
        '
        Me.cmbTaxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTaxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTaxType.FormattingEnabled = True
        Me.cmbTaxType.Items.AddRange(New Object() {"CST", "VAT"})
        Me.cmbTaxType.Location = New System.Drawing.Point(479, 36)
        Me.cmbTaxType.MaxLength = 10
        Me.cmbTaxType.Name = "cmbTaxType"
        Me.cmbTaxType.Size = New System.Drawing.Size(59, 21)
        Me.cmbTaxType.TabIndex = 22
        Me.cmbTaxType.Visible = False
        '
        'cmbTax
        '
        Me.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTax.FormattingEnabled = True
        Me.cmbTax.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbTax.Location = New System.Drawing.Point(549, 35)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(45, 24)
        Me.cmbTax.TabIndex = 30
        Me.cmbTax.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(629, 27)
        Me.txtAmount.MaxLength = 300
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(151, 22)
        Me.txtAmount.TabIndex = 13
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(371, 14)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(72, 16)
        Me.lblMillName.TabIndex = 2
        Me.lblMillName.Text = "Mill Name"
        '
        'lblwords
        '
        Me.lblwords.AutoSize = True
        Me.lblwords.BackColor = System.Drawing.Color.Transparent
        Me.lblwords.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwords.Location = New System.Drawing.Point(32, 472)
        Me.lblwords.Name = "lblwords"
        Me.lblwords.Size = New System.Drawing.Size(0, 16)
        Me.lblwords.TabIndex = 19
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(31, 389)
        Me.txtNarration.MaxLength = 75
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(346, 22)
        Me.txtNarration.TabIndex = 23
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNarration.Location = New System.Drawing.Point(36, 372)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(67, 16)
        Me.lblNarration.TabIndex = 22
        Me.lblNarration.Text = "Narration"
        Me.lblNarration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(678, 14)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 16)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(89, 14)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(46, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "PW Id"
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(172, 11)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(181, 22)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'lblvalue
        '
        Me.lblvalue.BackColor = System.Drawing.Color.Transparent
        Me.lblvalue.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalue.ForeColor = System.Drawing.Color.Red
        Me.lblvalue.Location = New System.Drawing.Point(32, 424)
        Me.lblvalue.Name = "lblvalue"
        Me.lblvalue.Size = New System.Drawing.Size(461, 53)
        Me.lblvalue.TabIndex = 18
        Me.lblvalue.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 95)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnBill)
        Me.pnlToolBar.Controls.Add(Me.ckbisprint)
        Me.pnlToolBar.Controls.Add(Me.btnsearch1)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Location = New System.Drawing.Point(294, 40)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(596, 53)
        Me.pnlToolBar.TabIndex = 1
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(232, 2)
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
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 30)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Tag = "Heading"
        Me.lblHeading.Text = "Party Working"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(899, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(971, 51)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 3
        Me.txtSearchBox.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmPartyWorking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPartyWorking"
        Me.Text = "Party Working"
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlTotalAmt.ResumeLayout(False)
        Me.pnlTotalAmt.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents cmbPartyName As System.Windows.Forms.ComboBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents txtSNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPartyName As System.Windows.Forms.Label
    Friend WithEvents txtMasterCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSNo As System.Windows.Forms.Label
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDetailsCode As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtDetailsId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFreightCharges As System.Windows.Forms.Label
    Friend WithEvents txtFreightCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtlrno As System.Windows.Forms.TextBox
    Friend WithEvents dtpFreightDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbllrno As System.Windows.Forms.Label
    Friend WithEvents lblRefId As System.Windows.Forms.Label
    Friend WithEvents txttransporter As System.Windows.Forms.TextBox
    Friend WithEvents lblFreightDate As System.Windows.Forms.Label
    Friend WithEvents lbltransporter As System.Windows.Forms.Label
    Friend WithEvents txtRefId As System.Windows.Forms.TextBox
    Friend WithEvents btnBill As System.Windows.Forms.Button
    Friend WithEvents ckbisprint As System.Windows.Forms.CheckBox
    Friend WithEvents btnsearch1 As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents pnlTotalAmt As System.Windows.Forms.Panel
    Friend WithEvents cmbTaxPer As System.Windows.Forms.ComboBox
    Friend WithEvents txtExtras As System.Windows.Forms.TextBox
    Friend WithEvents lblVehicle As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTotTax As System.Windows.Forms.Label
    Friend WithEvents txtTaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbBillType As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblTotItemAmt As System.Windows.Forms.Label
    Friend WithEvents lblE1Date As System.Windows.Forms.Label
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents dtpPWDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCFormNo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbEstimateCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstimateCode As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtNOOFBags As System.Windows.Forms.TextBox
    Friend WithEvents lblNoOfPiece As System.Windows.Forms.Label
    Friend WithEvents cmbUOM As System.Windows.Forms.ComboBox
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtAddress4 As System.Windows.Forms.TextBox
    Friend WithEvents txtorderno As System.Windows.Forms.TextBox
    Friend WithEvents txtItemsAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblorderno As System.Windows.Forms.Label
    Friend WithEvents lblItemAmount As System.Windows.Forms.Label
    Friend WithEvents dtporderdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents lblorderdate As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRoundOff As System.Windows.Forms.TextBox
    Friend WithEvents lblRoundOff As System.Windows.Forms.Label
    Private WithEvents cmbTaxType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTax As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents lblwords As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblvalue As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents txtCAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblCAmount As System.Windows.Forms.Label
    Friend WithEvents lblEFormNo As System.Windows.Forms.Label
    Friend WithEvents dtpE1Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfBags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Weight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents lblAdvance As System.Windows.Forms.Label
    Friend WithEvents cmbCFormNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEFormNo As System.Windows.Forms.ComboBox
End Class
