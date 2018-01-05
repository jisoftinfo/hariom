<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMillConfrimation
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSearch1 = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.lblLotNo = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.lblBillingName = New System.Windows.Forms.Label
        Me.lblPartyName = New System.Windows.Forms.Label
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.lblHeading = New System.Windows.Forms.Label
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblNoOfBags = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblMWDate = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblMillName = New System.Windows.Forms.Label
        Me.lblEFId = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.cmbPartyName = New System.Windows.Forms.ComboBox
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.lblParticulars = New System.Windows.Forms.Label
        Me.lblNameInChange = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.txtDeliveryAddress = New System.Windows.Forms.TextBox
        Me.txtInvoiceAddress = New System.Windows.Forms.TextBox
        Me.txtPartyCode = New System.Windows.Forms.TextBox
        Me.txtMillCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSalesMode = New System.Windows.Forms.Label
        Me.lblDelSed = New System.Windows.Forms.Label
        Me.lblConfrimationNO = New System.Windows.Forms.Label
        Me.picColor = New System.Windows.Forms.PictureBox
        Me.lblPayMode = New System.Windows.Forms.Label
        Me.lblLr = New System.Windows.Forms.Label
        Me.cmbColor = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SelectAddress = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.INVOICEADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DELIVERYADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtConfrimationNo = New System.Windows.Forms.TextBox
        Me.txtCount = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.cmbSalesMode = New System.Windows.Forms.ComboBox
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.cmbPayMode = New System.Windows.Forms.ComboBox
        Me.cmbStaus = New System.Windows.Forms.ComboBox
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.cmbBillingName = New System.Windows.Forms.ComboBox
        Me.txtNoOfBags = New System.Windows.Forms.TextBox
        Me.txtLotNo = New System.Windows.Forms.TextBox
        Me.txtDeliverySedule = New System.Windows.Forms.TextBox
        Me.txtLRBreakUp = New System.Windows.Forms.TextBox
        Me.cmbCountGroup = New System.Windows.Forms.ComboBox
        Me.txtNameInChange = New System.Windows.Forms.TextBox
        Me.txtParticulars = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlToolBar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.btnSearch1)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Location = New System.Drawing.Point(168, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(455, 56)
        Me.pnlToolBar.TabIndex = 0
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
        Me.btnDelete.Location = New System.Drawing.Point(160, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(378, 2)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch1.TabIndex = 5
        Me.btnSearch1.Text = "SEARC&H"
        Me.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch1.UseVisualStyleBackColor = False
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
        'lblLotNo
        '
        Me.lblLotNo.AutoSize = True
        Me.lblLotNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotNo.Location = New System.Drawing.Point(446, 140)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(57, 16)
        Me.lblLotNo.TabIndex = 16
        Me.lblLotNo.Text = "LOT NO"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(12, 112)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(53, 16)
        Me.lblCount.TabIndex = 10
        Me.lblCount.Text = "COUNT"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(12, 140)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(41, 16)
        Me.lblRate.TabIndex = 14
        Me.lblRate.Text = "RATE"
        '
        'lblBillingName
        '
        Me.lblBillingName.AutoSize = True
        Me.lblBillingName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingName.Location = New System.Drawing.Point(446, 82)
        Me.lblBillingName.Name = "lblBillingName"
        Me.lblBillingName.Size = New System.Drawing.Size(101, 16)
        Me.lblBillingName.TabIndex = 8
        Me.lblBillingName.Text = "BILLING NAME"
        '
        'lblPartyName
        '
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.Location = New System.Drawing.Point(12, 82)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(91, 16)
        Me.lblPartyName.TabIndex = 6
        Me.lblPartyName.Text = "PARTY NAME"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 783)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1328, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1328, 107)
        Me.pnlHeader.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(972, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
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
        Me.txtSearchBox.Location = New System.Drawing.Point(761, 58)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 3
        Me.txtSearchBox.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1328, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "MILL CONFIRMATION"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblNoOfBags
        '
        Me.lblNoOfBags.AutoSize = True
        Me.lblNoOfBags.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBags.Location = New System.Drawing.Point(446, 112)
        Me.lblNoOfBags.Name = "lblNoOfBags"
        Me.lblNoOfBags.Size = New System.Drawing.Size(90, 16)
        Me.lblNoOfBags.TabIndex = 12
        Me.lblNoOfBags.Text = "NO OF BAGS"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 70)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'lblMWDate
        '
        Me.lblMWDate.AutoSize = True
        Me.lblMWDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMWDate.Location = New System.Drawing.Point(288, 23)
        Me.lblMWDate.Name = "lblMWDate"
        Me.lblMWDate.Size = New System.Drawing.Size(41, 16)
        Me.lblMWDate.TabIndex = 2
        Me.lblMWDate.Text = "DATE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(933, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(148, 20)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(134, 22)
        Me.txtCode.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(148, 20)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(134, 22)
        Me.txtId.TabIndex = 6
        Me.txtId.Visible = False
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(446, 52)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(80, 16)
        Me.lblMillName.TabIndex = 4
        Me.lblMillName.Text = "MILL NAME"
        '
        'lblEFId
        '
        Me.lblEFId.AutoSize = True
        Me.lblEFId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFId.Location = New System.Drawing.Point(12, 23)
        Me.lblEFId.Name = "lblEFId"
        Me.lblEFId.Size = New System.Drawing.Size(21, 16)
        Me.lblEFId.TabIndex = 0
        Me.lblEFId.Text = "ID"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(335, 20)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpDate.TabIndex = 3
        '
        'cmbPartyName
        '
        Me.cmbPartyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(148, 80)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(291, 21)
        Me.cmbPartyName.TabIndex = 7
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.lblParticulars)
        Me.pnlForm.Controls.Add(Me.lblNameInChange)
        Me.pnlForm.Controls.Add(Me.lblStatus)
        Me.pnlForm.Controls.Add(Me.txtDeliveryAddress)
        Me.pnlForm.Controls.Add(Me.lblRate)
        Me.pnlForm.Controls.Add(Me.txtInvoiceAddress)
        Me.pnlForm.Controls.Add(Me.txtPartyCode)
        Me.pnlForm.Controls.Add(Me.txtMillCode)
        Me.pnlForm.Controls.Add(Me.dtpDate)
        Me.pnlForm.Controls.Add(Me.Label1)
        Me.pnlForm.Controls.Add(Me.lblSalesMode)
        Me.pnlForm.Controls.Add(Me.lblDelSed)
        Me.pnlForm.Controls.Add(Me.lblConfrimationNO)
        Me.pnlForm.Controls.Add(Me.picColor)
        Me.pnlForm.Controls.Add(Me.lblPayMode)
        Me.pnlForm.Controls.Add(Me.lblLr)
        Me.pnlForm.Controls.Add(Me.cmbColor)
        Me.pnlForm.Controls.Add(Me.lblBillingName)
        Me.pnlForm.Controls.Add(Me.lblLotNo)
        Me.pnlForm.Controls.Add(Me.lblCount)
        Me.pnlForm.Controls.Add(Me.lblPartyName)
        Me.pnlForm.Controls.Add(Me.lblNoOfBags)
        Me.pnlForm.Controls.Add(Me.lblMWDate)
        Me.pnlForm.Controls.Add(Me.Button1)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Controls.Add(Me.lblMillName)
        Me.pnlForm.Controls.Add(Me.lblEFId)
        Me.pnlForm.Controls.Add(Me.DataGridView1)
        Me.pnlForm.Controls.Add(Me.txtConfrimationNo)
        Me.pnlForm.Controls.Add(Me.cmbPartyName)
        Me.pnlForm.Controls.Add(Me.txtCount)
        Me.pnlForm.Controls.Add(Me.txtRate)
        Me.pnlForm.Controls.Add(Me.cmbSalesMode)
        Me.pnlForm.Controls.Add(Me.lblDiscount)
        Me.pnlForm.Controls.Add(Me.txtDiscount)
        Me.pnlForm.Controls.Add(Me.cmbPayMode)
        Me.pnlForm.Controls.Add(Me.cmbStaus)
        Me.pnlForm.Controls.Add(Me.cmbMillName)
        Me.pnlForm.Controls.Add(Me.cmbBillingName)
        Me.pnlForm.Controls.Add(Me.txtNoOfBags)
        Me.pnlForm.Controls.Add(Me.txtLotNo)
        Me.pnlForm.Controls.Add(Me.txtDeliverySedule)
        Me.pnlForm.Controls.Add(Me.txtLRBreakUp)
        Me.pnlForm.Controls.Add(Me.cmbCountGroup)
        Me.pnlForm.Controls.Add(Me.txtNameInChange)
        Me.pnlForm.Controls.Add(Me.txtParticulars)
        Me.pnlForm.Location = New System.Drawing.Point(12, 19)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(910, 651)
        Me.pnlForm.TabIndex = 0
        '
        'lblParticulars
        '
        Me.lblParticulars.AutoSize = True
        Me.lblParticulars.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticulars.Location = New System.Drawing.Point(14, 295)
        Me.lblParticulars.Name = "lblParticulars"
        Me.lblParticulars.Size = New System.Drawing.Size(99, 16)
        Me.lblParticulars.TabIndex = 34
        Me.lblParticulars.Text = "PARTICULARS"
        '
        'lblNameInChange
        '
        Me.lblNameInChange.AutoSize = True
        Me.lblNameInChange.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameInChange.Location = New System.Drawing.Point(446, 260)
        Me.lblNameInChange.Name = "lblNameInChange"
        Me.lblNameInChange.Size = New System.Drawing.Size(120, 16)
        Me.lblNameInChange.TabIndex = 32
        Me.lblNameInChange.Text = "NAME IN CHANGE"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(14, 260)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 16)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "STATUS"
        '
        'txtDeliveryAddress
        '
        Me.txtDeliveryAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryAddress.Location = New System.Drawing.Point(628, 18)
        Me.txtDeliveryAddress.MaxLength = 100
        Me.txtDeliveryAddress.Multiline = True
        Me.txtDeliveryAddress.Name = "txtDeliveryAddress"
        Me.txtDeliveryAddress.Size = New System.Drawing.Size(35, 20)
        Me.txtDeliveryAddress.TabIndex = 7
        Me.txtDeliveryAddress.Visible = False
        '
        'txtInvoiceAddress
        '
        Me.txtInvoiceAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceAddress.Location = New System.Drawing.Point(593, 18)
        Me.txtInvoiceAddress.MaxLength = 100
        Me.txtInvoiceAddress.Multiline = True
        Me.txtInvoiceAddress.Name = "txtInvoiceAddress"
        Me.txtInvoiceAddress.Size = New System.Drawing.Size(35, 20)
        Me.txtInvoiceAddress.TabIndex = 6
        Me.txtInvoiceAddress.Visible = False
        '
        'txtPartyCode
        '
        Me.txtPartyCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartyCode.Location = New System.Drawing.Point(558, 17)
        Me.txtPartyCode.MaxLength = 100
        Me.txtPartyCode.Name = "txtPartyCode"
        Me.txtPartyCode.Size = New System.Drawing.Size(35, 22)
        Me.txtPartyCode.TabIndex = 5
        '
        'txtMillCode
        '
        Me.txtMillCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMillCode.Location = New System.Drawing.Point(523, 17)
        Me.txtMillCode.MaxLength = 100
        Me.txtMillCode.Name = "txtMillCode"
        Me.txtMillCode.Size = New System.Drawing.Size(35, 22)
        Me.txtMillCode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(451, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "COUNT GROUP"
        '
        'lblSalesMode
        '
        Me.lblSalesMode.AutoSize = True
        Me.lblSalesMode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesMode.Location = New System.Drawing.Point(12, 170)
        Me.lblSalesMode.Name = "lblSalesMode"
        Me.lblSalesMode.Size = New System.Drawing.Size(93, 16)
        Me.lblSalesMode.TabIndex = 18
        Me.lblSalesMode.Text = "SALES MODE"
        '
        'lblDelSed
        '
        Me.lblDelSed.AutoSize = True
        Me.lblDelSed.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelSed.Location = New System.Drawing.Point(446, 171)
        Me.lblDelSed.Name = "lblDelSed"
        Me.lblDelSed.Size = New System.Drawing.Size(126, 16)
        Me.lblDelSed.TabIndex = 22
        Me.lblDelSed.Text = "DELIVERY SEDULE"
        '
        'lblConfrimationNO
        '
        Me.lblConfrimationNO.AutoSize = True
        Me.lblConfrimationNO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfrimationNO.Location = New System.Drawing.Point(12, 53)
        Me.lblConfrimationNO.Name = "lblConfrimationNO"
        Me.lblConfrimationNO.Size = New System.Drawing.Size(130, 16)
        Me.lblConfrimationNO.TabIndex = 2
        Me.lblConfrimationNO.Text = "CONFRIMATION NO"
        '
        'picColor
        '
        Me.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor.Location = New System.Drawing.Point(920, 243)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(680, 22)
        Me.picColor.TabIndex = 50
        Me.picColor.TabStop = False
        Me.picColor.Visible = False
        '
        'lblPayMode
        '
        Me.lblPayMode.AutoSize = True
        Me.lblPayMode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayMode.Location = New System.Drawing.Point(14, 227)
        Me.lblPayMode.Name = "lblPayMode"
        Me.lblPayMode.Size = New System.Drawing.Size(74, 16)
        Me.lblPayMode.TabIndex = 26
        Me.lblPayMode.Text = "PAY MODE"
        '
        'lblLr
        '
        Me.lblLr.AutoSize = True
        Me.lblLr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLr.Location = New System.Drawing.Point(12, 200)
        Me.lblLr.Name = "lblLr"
        Me.lblLr.Size = New System.Drawing.Size(95, 16)
        Me.lblLr.TabIndex = 24
        Me.lblLr.Text = "LR BREAK-UP"
        '
        'cmbColor
        '
        Me.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"P", "F"})
        Me.cmbColor.Location = New System.Drawing.Point(920, 243)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(200, 21)
        Me.cmbColor.TabIndex = 36
        Me.cmbColor.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectAddress, Me.INVOICEADDRESS, Me.DELIVERYADDRESS})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 377)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(860, 222)
        Me.DataGridView1.TabIndex = 38
        '
        'SelectAddress
        '
        Me.SelectAddress.HeaderText = ""
        Me.SelectAddress.Name = "SelectAddress"
        Me.SelectAddress.Width = 40
        '
        'INVOICEADDRESS
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.INVOICEADDRESS.DefaultCellStyle = DataGridViewCellStyle3
        Me.INVOICEADDRESS.HeaderText = "INVOICE ADDRESS"
        Me.INVOICEADDRESS.Name = "INVOICEADDRESS"
        Me.INVOICEADDRESS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.INVOICEADDRESS.Width = 370
        '
        'DELIVERYADDRESS
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DELIVERYADDRESS.DefaultCellStyle = DataGridViewCellStyle4
        Me.DELIVERYADDRESS.HeaderText = "DELIVERY ADDRESS"
        Me.DELIVERYADDRESS.Name = "DELIVERYADDRESS"
        Me.DELIVERYADDRESS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DELIVERYADDRESS.Width = 370
        '
        'txtConfrimationNo
        '
        Me.txtConfrimationNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfrimationNo.Location = New System.Drawing.Point(148, 50)
        Me.txtConfrimationNo.MaxLength = 100
        Me.txtConfrimationNo.Name = "txtConfrimationNo"
        Me.txtConfrimationNo.Size = New System.Drawing.Size(291, 22)
        Me.txtConfrimationNo.TabIndex = 3
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.Location = New System.Drawing.Point(148, 109)
        Me.txtCount.MaxLength = 100
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(291, 22)
        Me.txtCount.TabIndex = 11
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(148, 137)
        Me.txtRate.MaxLength = 100
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(291, 22)
        Me.txtRate.TabIndex = 15
        '
        'cmbSalesMode
        '
        Me.cmbSalesMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbSalesMode.FormattingEnabled = True
        Me.cmbSalesMode.Items.AddRange(New Object() {"EX-MILL", "NET DELIVERY RATE", "WO LORYY FREIGHT"})
        Me.cmbSalesMode.Location = New System.Drawing.Point(148, 168)
        Me.cmbSalesMode.Name = "cmbSalesMode"
        Me.cmbSalesMode.Size = New System.Drawing.Size(152, 21)
        Me.cmbSalesMode.TabIndex = 19
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(309, 170)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(62, 16)
        Me.lblDiscount.TabIndex = 20
        Me.lblDiscount.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(377, 167)
        Me.txtDiscount.MaxLength = 100
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(63, 22)
        Me.txtDiscount.TabIndex = 21
        '
        'cmbPayMode
        '
        Me.cmbPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPayMode.FormattingEnabled = True
        Me.cmbPayMode.Items.AddRange(New Object() {"Regular", "Advance"})
        Me.cmbPayMode.Location = New System.Drawing.Point(148, 225)
        Me.cmbPayMode.Name = "cmbPayMode"
        Me.cmbPayMode.Size = New System.Drawing.Size(291, 21)
        Me.cmbPayMode.TabIndex = 27
        '
        'cmbStaus
        '
        Me.cmbStaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStaus.FormattingEnabled = True
        Me.cmbStaus.Items.AddRange(New Object() {"P", "F"})
        Me.cmbStaus.Location = New System.Drawing.Point(148, 258)
        Me.cmbStaus.Name = "cmbStaus"
        Me.cmbStaus.Size = New System.Drawing.Size(291, 21)
        Me.cmbStaus.TabIndex = 31
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(585, 50)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(291, 21)
        Me.cmbMillName.TabIndex = 5
        '
        'cmbBillingName
        '
        Me.cmbBillingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbBillingName.FormattingEnabled = True
        Me.cmbBillingName.Location = New System.Drawing.Point(585, 80)
        Me.cmbBillingName.Name = "cmbBillingName"
        Me.cmbBillingName.Size = New System.Drawing.Size(291, 21)
        Me.cmbBillingName.TabIndex = 9
        '
        'txtNoOfBags
        '
        Me.txtNoOfBags.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfBags.Location = New System.Drawing.Point(582, 109)
        Me.txtNoOfBags.MaxLength = 100
        Me.txtNoOfBags.Name = "txtNoOfBags"
        Me.txtNoOfBags.Size = New System.Drawing.Size(291, 22)
        Me.txtNoOfBags.TabIndex = 13
        '
        'txtLotNo
        '
        Me.txtLotNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.Location = New System.Drawing.Point(585, 137)
        Me.txtLotNo.MaxLength = 100
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(291, 22)
        Me.txtLotNo.TabIndex = 17
        '
        'txtDeliverySedule
        '
        Me.txtDeliverySedule.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliverySedule.Location = New System.Drawing.Point(585, 168)
        Me.txtDeliverySedule.MaxLength = 100
        Me.txtDeliverySedule.Name = "txtDeliverySedule"
        Me.txtDeliverySedule.Size = New System.Drawing.Size(291, 22)
        Me.txtDeliverySedule.TabIndex = 23
        '
        'txtLRBreakUp
        '
        Me.txtLRBreakUp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRBreakUp.Location = New System.Drawing.Point(148, 197)
        Me.txtLRBreakUp.MaxLength = 100
        Me.txtLRBreakUp.Name = "txtLRBreakUp"
        Me.txtLRBreakUp.Size = New System.Drawing.Size(727, 22)
        Me.txtLRBreakUp.TabIndex = 25
        '
        'cmbCountGroup
        '
        Me.cmbCountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCountGroup.FormattingEnabled = True
        Me.cmbCountGroup.Location = New System.Drawing.Point(585, 225)
        Me.cmbCountGroup.Name = "cmbCountGroup"
        Me.cmbCountGroup.Size = New System.Drawing.Size(291, 21)
        Me.cmbCountGroup.TabIndex = 29
        '
        'txtNameInChange
        '
        Me.txtNameInChange.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameInChange.Location = New System.Drawing.Point(585, 257)
        Me.txtNameInChange.MaxLength = 100
        Me.txtNameInChange.Name = "txtNameInChange"
        Me.txtNameInChange.Size = New System.Drawing.Size(291, 22)
        Me.txtNameInChange.TabIndex = 33
        '
        'txtParticulars
        '
        Me.txtParticulars.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParticulars.Location = New System.Drawing.Point(148, 292)
        Me.txtParticulars.MaxLength = 100
        Me.txtParticulars.Multiline = True
        Me.txtParticulars.Name = "txtParticulars"
        Me.txtParticulars.Size = New System.Drawing.Size(725, 52)
        Me.txtParticulars.TabIndex = 35
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNarration.Location = New System.Drawing.Point(921, 203)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(83, 16)
        Me.lblNarration.TabIndex = 31
        Me.lblNarration.Text = "NARRATION"
        Me.lblNarration.Visible = False
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(932, 228)
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(306, 37)
        Me.txtNarration.TabIndex = 32
        Me.txtNarration.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.txtInvoice)
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Controls.Add(Me.txtNarration)
        Me.pnlContent.Controls.Add(Me.lblNarration)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1328, 676)
        Me.pnlContent.TabIndex = 0
        '
        'txtInvoice
        '
        Me.txtInvoice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.Location = New System.Drawing.Point(945, 326)
        Me.txtInvoice.MaxLength = 100
        Me.txtInvoice.Multiline = True
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(306, 37)
        Me.txtInvoice.TabIndex = 33
        Me.txtInvoice.Visible = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1328, 793)
        Me.pnlMain.TabIndex = 10
        '
        'frmMillConfrimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 793)
        Me.Controls.Add(Me.pnlMain)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmMillConfrimation"
        Me.Text = "MILL CONFIRMATION"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblLotNo As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblBillingName As System.Windows.Forms.Label
    Friend WithEvents lblPartyName As System.Windows.Forms.Label
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents cmbPartyName As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoOfBags As System.Windows.Forms.TextBox
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBillingName As System.Windows.Forms.ComboBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtLRBreakUp As System.Windows.Forms.TextBox
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents picColor As System.Windows.Forms.PictureBox
    Friend WithEvents lblPayMode As System.Windows.Forms.Label
    Friend WithEvents lblLr As System.Windows.Forms.Label
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents lblNoOfBags As System.Windows.Forms.Label
    Friend WithEvents lblMWDate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents lblEFId As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtConfrimationNo As System.Windows.Forms.TextBox
    Friend WithEvents lblConfrimationNO As System.Windows.Forms.Label
    Friend WithEvents lblSalesMode As System.Windows.Forms.Label
    Friend WithEvents txtDeliverySedule As System.Windows.Forms.TextBox
    Friend WithEvents lblDelSed As System.Windows.Forms.Label
    Friend WithEvents cmbPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSalesMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPartyCode As System.Windows.Forms.TextBox
    Friend WithEvents txtMillCode As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SelectAddress As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents INVOICEADDRESS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DELIVERYADDRESS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDeliveryAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceAddress As System.Windows.Forms.TextBox
    Friend WithEvents cmbCountGroup As System.Windows.Forms.ComboBox
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStaus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblNameInChange As System.Windows.Forms.Label
    Friend WithEvents txtNameInChange As System.Windows.Forms.TextBox
    Friend WithEvents lblParticulars As System.Windows.Forms.Label
    Friend WithEvents txtParticulars As System.Windows.Forms.TextBox
End Class
