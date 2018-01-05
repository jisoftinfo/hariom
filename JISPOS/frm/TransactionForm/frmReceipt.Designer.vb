<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lblRefNo = New System.Windows.Forms.Label
        Me.lblRefType = New System.Windows.Forms.Label
        Me.txtPDNarration = New System.Windows.Forms.TextBox
        Me.txtJournalCode = New System.Windows.Forms.TextBox
        Me.lblSNo = New System.Windows.Forms.Label
        Me.txtpdid = New System.Windows.Forms.TextBox
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.JournalCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtPCode = New System.Windows.Forms.TextBox
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtpdcode = New System.Windows.Forms.TextBox
        Me.cmbRefNo = New System.Windows.Forms.ComboBox
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnSearch1 = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.lblNarration = New System.Windows.Forms.Label
        Me.lblPayMode = New System.Windows.Forms.Label
        Me.lblPayAmount = New System.Windows.Forms.Label
        Me.RefNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblPayname = New System.Windows.Forms.Label
        Me.lblPaymentTo = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblPaymentId = New System.Windows.Forms.Label
        Me.RefType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.lblRecDate = New System.Windows.Forms.Label
        Me.txtRecDate = New System.Windows.Forms.TextBox
        Me.dtpRecDate = New System.Windows.Forms.DateTimePicker
        Me.lblbalamt = New System.Windows.Forms.Label
        Me.txtbalamt = New System.Windows.Forms.TextBox
        Me.lbltotalamt = New System.Windows.Forms.Label
        Me.txttotamt = New System.Windows.Forms.TextBox
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.cmbReceiptName = New System.Windows.Forms.ComboBox
        Me.txtPayAmount = New System.Windows.Forms.TextBox
        Me.cmbReceiptFrom = New System.Windows.Forms.ComboBox
        Me.cmbReceiptMode = New System.Windows.Forms.ComboBox
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.pnlDetails = New System.Windows.Forms.Panel
        Me.txtDetails = New System.Windows.Forms.TextBox
        Me.txtSNo = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cmbRefType = New System.Windows.Forms.ComboBox
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Maroon
        Me.lblAmount.Location = New System.Drawing.Point(391, 1)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(157, 22)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Tag = "Heading"
        Me.lblAmount.Text = "Amount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRefNo
        '
        Me.lblRefNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRefNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblRefNo.Location = New System.Drawing.Point(237, 1)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(154, 22)
        Me.lblRefNo.TabIndex = 4
        Me.lblRefNo.Tag = "Heading"
        Me.lblRefNo.Text = "Ref No"
        Me.lblRefNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRefType
        '
        Me.lblRefType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRefType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefType.ForeColor = System.Drawing.Color.Maroon
        Me.lblRefType.Location = New System.Drawing.Point(31, 1)
        Me.lblRefType.Name = "lblRefType"
        Me.lblRefType.Size = New System.Drawing.Size(206, 22)
        Me.lblRefType.TabIndex = 2
        Me.lblRefType.Tag = "Heading"
        Me.lblRefType.Text = "Ref Type"
        Me.lblRefType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPDNarration
        '
        Me.txtPDNarration.Location = New System.Drawing.Point(265, 147)
        Me.txtPDNarration.Name = "txtPDNarration"
        Me.txtPDNarration.Size = New System.Drawing.Size(100, 20)
        Me.txtPDNarration.TabIndex = 0
        Me.txtPDNarration.Visible = False
        '
        'txtJournalCode
        '
        Me.txtJournalCode.Location = New System.Drawing.Point(148, 147)
        Me.txtJournalCode.Name = "txtJournalCode"
        Me.txtJournalCode.Size = New System.Drawing.Size(100, 20)
        Me.txtJournalCode.TabIndex = 14
        Me.txtJournalCode.Visible = False
        '
        'lblSNo
        '
        Me.lblSNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblSNo.Location = New System.Drawing.Point(0, 1)
        Me.lblSNo.Name = "lblSNo"
        Me.lblSNo.Size = New System.Drawing.Size(31, 22)
        Me.lblSNo.TabIndex = 0
        Me.lblSNo.Tag = "Heading"
        Me.lblSNo.Text = "No"
        Me.lblSNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpdid
        '
        Me.txtpdid.Location = New System.Drawing.Point(312, 106)
        Me.txtpdid.Name = "txtpdid"
        Me.txtpdid.Size = New System.Drawing.Size(100, 20)
        Me.txtpdid.TabIndex = 13
        Me.txtpdid.Visible = False
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(390, 12)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShowUpDown = True
        Me.dtpDate.Size = New System.Drawing.Size(175, 22)
        Me.dtpDate.TabIndex = 13
        '
        'JournalCode
        '
        Me.JournalCode.HeaderText = "JournalCode"
        Me.JournalCode.Name = "JournalCode"
        Me.JournalCode.Visible = False
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(110, 106)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(100, 20)
        Me.txtPCode.TabIndex = 9
        Me.txtPCode.Visible = False
        '
        'Narration
        '
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.Visible = False
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(113, 12)
        Me.txtCode.MaxLength = 50
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(161, 22)
        Me.txtCode.TabIndex = 1
        '
        'txtpdcode
        '
        Me.txtpdcode.Location = New System.Drawing.Point(210, 106)
        Me.txtpdcode.Name = "txtpdcode"
        Me.txtpdcode.Size = New System.Drawing.Size(100, 20)
        Me.txtpdcode.TabIndex = 12
        Me.txtpdcode.Visible = False
        '
        'cmbRefNo
        '
        Me.cmbRefNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbRefNo.FormattingEnabled = True
        Me.cmbRefNo.Location = New System.Drawing.Point(237, 23)
        Me.cmbRefNo.Name = "cmbRefNo"
        Me.cmbRefNo.Size = New System.Drawing.Size(154, 21)
        Me.cmbRefNo.TabIndex = 5
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 107)
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
        Me.pnlToolBar.TabIndex = 1
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(382, 3)
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
        Me.btnExit.Location = New System.Drawing.Point(308, 3)
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
        Me.btnView.Location = New System.Drawing.Point(234, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = " &VIEW"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(892, 61)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 2
        Me.txtSearchBox.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Credit"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(820, 48)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 3
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
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.BackColor = System.Drawing.Color.Transparent
        Me.lblNarration.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNarration.Location = New System.Drawing.Point(14, 105)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(67, 16)
        Me.lblNarration.TabIndex = 10
        Me.lblNarration.Text = "Narrat&ion"
        Me.lblNarration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayMode
        '
        Me.lblPayMode.AutoSize = True
        Me.lblPayMode.BackColor = System.Drawing.Color.Transparent
        Me.lblPayMode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayMode.Location = New System.Drawing.Point(14, 77)
        Me.lblPayMode.Name = "lblPayMode"
        Me.lblPayMode.Size = New System.Drawing.Size(27, 16)
        Me.lblPayMode.TabIndex = 6
        Me.lblPayMode.Text = "To."
        Me.lblPayMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayAmount
        '
        Me.lblPayAmount.AutoSize = True
        Me.lblPayAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblPayAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayAmount.Location = New System.Drawing.Point(303, 77)
        Me.lblPayAmount.Name = "lblPayAmount"
        Me.lblPayAmount.Size = New System.Drawing.Size(80, 16)
        Me.lblPayAmount.TabIndex = 8
        Me.lblPayAmount.Text = "Amount &Rs."
        Me.lblPayAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RefNo
        '
        Me.RefNo.HeaderText = "RefNo"
        Me.RefNo.Name = "RefNo"
        '
        'lblPayname
        '
        Me.lblPayname.AutoSize = True
        Me.lblPayname.BackColor = System.Drawing.Color.Transparent
        Me.lblPayname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayname.Location = New System.Drawing.Point(303, 45)
        Me.lblPayname.Name = "lblPayname"
        Me.lblPayname.Size = New System.Drawing.Size(45, 16)
        Me.lblPayname.TabIndex = 4
        Me.lblPayname.Text = "From."
        Me.lblPayname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaymentTo
        '
        Me.lblPaymentTo.AutoSize = True
        Me.lblPaymentTo.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentTo.Location = New System.Drawing.Point(14, 46)
        Me.lblPaymentTo.Name = "lblPaymentTo"
        Me.lblPaymentTo.Size = New System.Drawing.Size(93, 16)
        Me.lblPaymentTo.TabIndex = 2
        Me.lblPaymentTo.Text = "Receipt From"
        Me.lblPaymentTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(113, 12)
        Me.txtId.MaxLength = 50
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(161, 22)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(303, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Da&te"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaymentId
        '
        Me.lblPaymentId.AutoSize = True
        Me.lblPaymentId.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentId.Location = New System.Drawing.Point(14, 15)
        Me.lblPaymentId.Name = "lblPaymentId"
        Me.lblPaymentId.Size = New System.Drawing.Size(72, 16)
        Me.lblPaymentId.TabIndex = 0
        Me.lblPaymentId.Text = "Receipt Id"
        Me.lblPaymentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RefType
        '
        Me.RefType.HeaderText = "RefType"
        Me.RefType.Name = "RefType"
        '
        'SNo
        '
        Me.SNo.HeaderText = "SNo"
        Me.SNo.Name = "SNo"
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblRecDate)
        Me.pnlContent.Controls.Add(Me.txtRecDate)
        Me.pnlContent.Controls.Add(Me.dtpRecDate)
        Me.pnlContent.Controls.Add(Me.lblbalamt)
        Me.pnlContent.Controls.Add(Me.txtbalamt)
        Me.pnlContent.Controls.Add(Me.lbltotalamt)
        Me.pnlContent.Controls.Add(Me.txttotamt)
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 545)
        Me.pnlContent.TabIndex = 0
        '
        'lblRecDate
        '
        Me.lblRecDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblRecDate.Location = New System.Drawing.Point(688, 88)
        Me.lblRecDate.Name = "lblRecDate"
        Me.lblRecDate.Size = New System.Drawing.Size(104, 22)
        Me.lblRecDate.TabIndex = 1
        Me.lblRecDate.Tag = "Heading"
        Me.lblRecDate.Text = "Sales Date"
        Me.lblRecDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRecDate.Visible = False
        '
        'txtRecDate
        '
        Me.txtRecDate.Location = New System.Drawing.Point(688, 113)
        Me.txtRecDate.Name = "txtRecDate"
        Me.txtRecDate.ReadOnly = True
        Me.txtRecDate.Size = New System.Drawing.Size(104, 20)
        Me.txtRecDate.TabIndex = 2
        Me.txtRecDate.Visible = False
        '
        'dtpRecDate
        '
        Me.dtpRecDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRecDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRecDate.Location = New System.Drawing.Point(691, 113)
        Me.dtpRecDate.Name = "dtpRecDate"
        Me.dtpRecDate.ShowUpDown = True
        Me.dtpRecDate.Size = New System.Drawing.Size(85, 22)
        Me.dtpRecDate.TabIndex = 32
        Me.dtpRecDate.Visible = False
        '
        'lblbalamt
        '
        Me.lblbalamt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbalamt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalamt.ForeColor = System.Drawing.Color.Maroon
        Me.lblbalamt.Location = New System.Drawing.Point(691, 213)
        Me.lblbalamt.Name = "lblbalamt"
        Me.lblbalamt.Size = New System.Drawing.Size(103, 22)
        Me.lblbalamt.TabIndex = 5
        Me.lblbalamt.Tag = "Heading"
        Me.lblbalamt.Text = "Amount"
        Me.lblbalamt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblbalamt.Visible = False
        '
        'txtbalamt
        '
        Me.txtbalamt.Location = New System.Drawing.Point(691, 235)
        Me.txtbalamt.Name = "txtbalamt"
        Me.txtbalamt.Size = New System.Drawing.Size(103, 20)
        Me.txtbalamt.TabIndex = 6
        Me.txtbalamt.Visible = False
        '
        'lbltotalamt
        '
        Me.lbltotalamt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotalamt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamt.ForeColor = System.Drawing.Color.Maroon
        Me.lbltotalamt.Location = New System.Drawing.Point(691, 153)
        Me.lbltotalamt.Name = "lbltotalamt"
        Me.lbltotalamt.Size = New System.Drawing.Size(103, 22)
        Me.lbltotalamt.TabIndex = 3
        Me.lbltotalamt.Tag = "Heading"
        Me.lbltotalamt.Text = "TotalAmount"
        Me.lbltotalamt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltotalamt.Visible = False
        '
        'txttotamt
        '
        Me.txttotamt.Location = New System.Drawing.Point(691, 175)
        Me.txttotamt.Name = "txttotamt"
        Me.txttotamt.Size = New System.Drawing.Size(103, 20)
        Me.txttotamt.TabIndex = 4
        Me.txttotamt.Visible = False
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.cmbReceiptName)
        Me.pnlForm.Controls.Add(Me.txtPayAmount)
        Me.pnlForm.Controls.Add(Me.cmbReceiptFrom)
        Me.pnlForm.Controls.Add(Me.cmbReceiptMode)
        Me.pnlForm.Controls.Add(Me.txtNarration)
        Me.pnlForm.Controls.Add(Me.pnlDetails)
        Me.pnlForm.Controls.Add(Me.dtpDate)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.lblNarration)
        Me.pnlForm.Controls.Add(Me.lblPayMode)
        Me.pnlForm.Controls.Add(Me.lblPayAmount)
        Me.pnlForm.Controls.Add(Me.lblPayname)
        Me.pnlForm.Controls.Add(Me.lblPaymentTo)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Controls.Add(Me.Label15)
        Me.pnlForm.Controls.Add(Me.lblPaymentId)
        Me.pnlForm.Location = New System.Drawing.Point(86, 17)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(596, 345)
        Me.pnlForm.TabIndex = 0
        '
        'cmbReceiptName
        '
        Me.cmbReceiptName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReceiptName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReceiptName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbReceiptName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReceiptName.FormattingEnabled = True
        Me.cmbReceiptName.Location = New System.Drawing.Point(390, 42)
        Me.cmbReceiptName.Name = "cmbReceiptName"
        Me.cmbReceiptName.Size = New System.Drawing.Size(175, 22)
        Me.cmbReceiptName.TabIndex = 5
        '
        'txtPayAmount
        '
        Me.txtPayAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayAmount.Location = New System.Drawing.Point(390, 74)
        Me.txtPayAmount.MaxLength = 10
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.Size = New System.Drawing.Size(175, 22)
        Me.txtPayAmount.TabIndex = 9
        '
        'cmbReceiptFrom
        '
        Me.cmbReceiptFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReceiptFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReceiptFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbReceiptFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReceiptFrom.FormattingEnabled = True
        Me.cmbReceiptFrom.Items.AddRange(New Object() {"Customers", "Suppliers"})
        Me.cmbReceiptFrom.Location = New System.Drawing.Point(113, 42)
        Me.cmbReceiptFrom.Name = "cmbReceiptFrom"
        Me.cmbReceiptFrom.Size = New System.Drawing.Size(161, 24)
        Me.cmbReceiptFrom.TabIndex = 3
        '
        'cmbReceiptMode
        '
        Me.cmbReceiptMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReceiptMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReceiptMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbReceiptMode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReceiptMode.FormattingEnabled = True
        Me.cmbReceiptMode.Items.AddRange(New Object() {"Cash"})
        Me.cmbReceiptMode.Location = New System.Drawing.Point(113, 74)
        Me.cmbReceiptMode.Name = "cmbReceiptMode"
        Me.cmbReceiptMode.Size = New System.Drawing.Size(161, 22)
        Me.cmbReceiptMode.TabIndex = 7
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(113, 102)
        Me.txtNarration.MaxLength = 150
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(452, 22)
        Me.txtNarration.TabIndex = 11
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.txtDetails)
        Me.pnlDetails.Controls.Add(Me.txtPDNarration)
        Me.pnlDetails.Controls.Add(Me.txtJournalCode)
        Me.pnlDetails.Controls.Add(Me.lblAmount)
        Me.pnlDetails.Controls.Add(Me.lblRefNo)
        Me.pnlDetails.Controls.Add(Me.lblRefType)
        Me.pnlDetails.Controls.Add(Me.lblSNo)
        Me.pnlDetails.Controls.Add(Me.txtpdid)
        Me.pnlDetails.Controls.Add(Me.txtPCode)
        Me.pnlDetails.Controls.Add(Me.txtpdcode)
        Me.pnlDetails.Controls.Add(Me.cmbRefNo)
        Me.pnlDetails.Controls.Add(Me.txtSNo)
        Me.pnlDetails.Controls.Add(Me.txtAmount)
        Me.pnlDetails.Controls.Add(Me.cmbRefType)
        Me.pnlDetails.Controls.Add(Me.dgvDetails)
        Me.pnlDetails.Location = New System.Drawing.Point(17, 130)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(557, 196)
        Me.pnlDetails.TabIndex = 14
        Me.pnlDetails.Visible = False
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(228, 88)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtDetails.TabIndex = 10
        Me.txtDetails.Visible = False
        '
        'txtSNo
        '
        Me.txtSNo.Location = New System.Drawing.Point(0, 23)
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.Size = New System.Drawing.Size(31, 20)
        Me.txtSNo.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(391, 23)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(157, 20)
        Me.txtAmount.TabIndex = 7
        '
        'cmbRefType
        '
        Me.cmbRefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbRefType.FormattingEnabled = True
        Me.cmbRefType.Items.AddRange(New Object() {"AgainstRef", "NewRef"})
        Me.cmbRefType.Location = New System.Drawing.Point(31, 23)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(206, 21)
        Me.cmbRefType.TabIndex = 3
        '
        'dgvDetails
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.RefType, Me.RefNo, Me.Amount, Me.JournalCode, Me.Narration})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetails.Location = New System.Drawing.Point(1, 43)
        Me.dgvDetails.Name = "dgvDetails"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetails.Size = New System.Drawing.Size(547, 150)
        Me.dgvDetails.TabIndex = 11
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
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmReceipt"
        Me.Text = "Receipt Info"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblRefNo As System.Windows.Forms.Label
    Friend WithEvents lblRefType As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtPDNarration As System.Windows.Forms.TextBox
    Friend WithEvents txtJournalCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSNo As System.Windows.Forms.Label
    Friend WithEvents txtpdid As System.Windows.Forms.TextBox
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents JournalCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPCode As System.Windows.Forms.TextBox
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtpdcode As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefNo As System.Windows.Forms.ComboBox
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents cmbReceiptName As System.Windows.Forms.ComboBox
    Friend WithEvents txtPayAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbReceiptFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReceiptMode As System.Windows.Forms.ComboBox
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents txtSNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents lblPayMode As System.Windows.Forms.Label
    Friend WithEvents lblPayAmount As System.Windows.Forms.Label
    Friend WithEvents lblPayname As System.Windows.Forms.Label
    Friend WithEvents lblPaymentTo As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPaymentId As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRecDate As System.Windows.Forms.Label
    Friend WithEvents txtRecDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpRecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblbalamt As System.Windows.Forms.Label
    Friend WithEvents txtbalamt As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalamt As System.Windows.Forms.Label
    Friend WithEvents txttotamt As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
End Class
