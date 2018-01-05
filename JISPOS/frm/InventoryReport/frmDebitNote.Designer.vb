<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitNote
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblHeading = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.lblFDate = New System.Windows.Forms.Label
        Me.lblTDate = New System.Windows.Forms.Label
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.txtTaxAmt = New System.Windows.Forms.TextBox
        Me.txtTaxPer = New System.Windows.Forms.TextBox
        Me.lblTax = New System.Windows.Forms.Label
        Me.txtComAmt = New System.Windows.Forms.TextBox
        Me.txtComPer = New System.Windows.Forms.TextBox
        Me.lblCommissionPer = New System.Windows.Forms.Label
        Me.txtExMillAmt = New System.Windows.Forms.TextBox
        Me.lblExMillAmt = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCusName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.txtNoOfBags = New System.Windows.Forms.TextBox
        Me.lblNoOfBags = New System.Windows.Forms.Label
        Me.txtTotalKg = New System.Windows.Forms.TextBox
        Me.lblTotalKg = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Debit Note"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(84, 61)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(227, 20)
        Me.txtAmount.TabIndex = 7
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCustomerName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(84, 7)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(227, 22)
        Me.cmbCustomerName.Sorted = True
        Me.cmbCustomerName.TabIndex = 1
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.dtpFDate)
        Me.pnlToolBar.Controls.Add(Me.txtCode)
        Me.pnlToolBar.Controls.Add(Me.txtId)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.txtTotalKg)
        Me.pnlToolBar.Controls.Add(Me.lblTotalKg)
        Me.pnlToolBar.Controls.Add(Me.txtNoOfBags)
        Me.pnlToolBar.Controls.Add(Me.lblNoOfBags)
        Me.pnlToolBar.Controls.Add(Me.cmbCustomerName)
        Me.pnlToolBar.Controls.Add(Me.lblFDate)
        Me.pnlToolBar.Controls.Add(Me.lblTDate)
        Me.pnlToolBar.Controls.Add(Me.dtpTDate)
        Me.pnlToolBar.Controls.Add(Me.txtAmount)
        Me.pnlToolBar.Controls.Add(Me.txtTotalAmount)
        Me.pnlToolBar.Controls.Add(Me.lblTotalAmount)
        Me.pnlToolBar.Controls.Add(Me.txtTaxAmt)
        Me.pnlToolBar.Controls.Add(Me.txtTaxPer)
        Me.pnlToolBar.Controls.Add(Me.lblTax)
        Me.pnlToolBar.Controls.Add(Me.txtComAmt)
        Me.pnlToolBar.Controls.Add(Me.txtComPer)
        Me.pnlToolBar.Controls.Add(Me.lblCommissionPer)
        Me.pnlToolBar.Controls.Add(Me.txtExMillAmt)
        Me.pnlToolBar.Controls.Add(Me.lblExMillAmt)
        Me.pnlToolBar.Controls.Add(Me.txtAddress)
        Me.pnlToolBar.Controls.Add(Me.lblAddress)
        Me.pnlToolBar.Controls.Add(Me.Label2)
        Me.pnlToolBar.Controls.Add(Me.lblCusName)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1184, 109)
        Me.pnlToolBar.TabIndex = 0
        '
        'lblFDate
        '
        Me.lblFDate.AutoSize = True
        Me.lblFDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFDate.Location = New System.Drawing.Point(6, 37)
        Me.lblFDate.Name = "lblFDate"
        Me.lblFDate.Size = New System.Drawing.Size(74, 16)
        Me.lblFDate.TabIndex = 2
        Me.lblFDate.Text = "From Date"
        '
        'lblTDate
        '
        Me.lblTDate.AutoSize = True
        Me.lblTDate.BackColor = System.Drawing.Color.Transparent
        Me.lblTDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDate.Location = New System.Drawing.Point(184, 38)
        Me.lblTDate.Name = "lblTDate"
        Me.lblTDate.Size = New System.Drawing.Size(23, 16)
        Me.lblTDate.TabIndex = 4
        Me.lblTDate.Text = "To"
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(206, 34)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.ShowUpDown = True
        Me.dtpTDate.Size = New System.Drawing.Size(101, 23)
        Me.dtpTDate.TabIndex = 5
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "MMMM of yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(84, 35)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.ShowUpDown = True
        Me.dtpFDate.Size = New System.Drawing.Size(157, 23)
        Me.dtpFDate.TabIndex = 3
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(765, 58)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(178, 20)
        Me.txtTotalAmount.TabIndex = 23
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(651, 60)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(92, 16)
        Me.lblTotalAmount.TabIndex = 22
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'txtTaxAmt
        '
        Me.txtTaxAmt.Location = New System.Drawing.Point(831, 33)
        Me.txtTaxAmt.Name = "txtTaxAmt"
        Me.txtTaxAmt.Size = New System.Drawing.Size(112, 20)
        Me.txtTaxAmt.TabIndex = 21
        '
        'txtTaxPer
        '
        Me.txtTaxPer.Location = New System.Drawing.Point(765, 32)
        Me.txtTaxPer.Name = "txtTaxPer"
        Me.txtTaxPer.Size = New System.Drawing.Size(60, 20)
        Me.txtTaxPer.TabIndex = 20
        Me.txtTaxPer.Text = "12.36"
        Me.txtTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(651, 34)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(83, 16)
        Me.lblTax.TabIndex = 19
        Me.lblTax.Text = "Service Tax"
        '
        'txtComAmt
        '
        Me.txtComAmt.Location = New System.Drawing.Point(831, 7)
        Me.txtComAmt.Name = "txtComAmt"
        Me.txtComAmt.Size = New System.Drawing.Size(112, 20)
        Me.txtComAmt.TabIndex = 18
        '
        'txtComPer
        '
        Me.txtComPer.Location = New System.Drawing.Point(765, 6)
        Me.txtComPer.Name = "txtComPer"
        Me.txtComPer.Size = New System.Drawing.Size(60, 20)
        Me.txtComPer.TabIndex = 17
        Me.txtComPer.Text = "1"
        Me.txtComPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCommissionPer
        '
        Me.lblCommissionPer.AutoSize = True
        Me.lblCommissionPer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommissionPer.Location = New System.Drawing.Point(651, 8)
        Me.lblCommissionPer.Name = "lblCommissionPer"
        Me.lblCommissionPer.Size = New System.Drawing.Size(111, 16)
        Me.lblCommissionPer.TabIndex = 16
        Me.lblCommissionPer.Text = "Commission Per"
        '
        'txtExMillAmt
        '
        Me.txtExMillAmt.Location = New System.Drawing.Point(425, 58)
        Me.txtExMillAmt.Name = "txtExMillAmt"
        Me.txtExMillAmt.Size = New System.Drawing.Size(221, 20)
        Me.txtExMillAmt.TabIndex = 13
        '
        'lblExMillAmt
        '
        Me.lblExMillAmt.AutoSize = True
        Me.lblExMillAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExMillAmt.Location = New System.Drawing.Point(318, 59)
        Me.lblExMillAmt.Name = "lblExMillAmt"
        Me.lblExMillAmt.Size = New System.Drawing.Size(104, 16)
        Me.lblExMillAmt.TabIndex = 12
        Me.lblExMillAmt.Text = "Ex-Mill Amount"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(425, 4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(221, 45)
        Me.txtAddress.TabIndex = 11
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(318, 10)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Amount"
        '
        'lblCusName
        '
        Me.lblCusName.AutoSize = True
        Me.lblCusName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusName.Location = New System.Drawing.Point(6, 10)
        Me.lblCusName.Name = "lblCusName"
        Me.lblCusName.Size = New System.Drawing.Size(72, 16)
        Me.lblCusName.TabIndex = 0
        Me.lblCusName.Text = "Mill Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1097, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 26
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
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(1023, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Print"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.CrystalReportViewer1)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 151)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 501)
        Me.pnlContent.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1184, 501)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        Me.pnlMain.TabIndex = 12
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
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 151)
        Me.pnlHeader.TabIndex = 0
        '
        'txtNoOfBags
        '
        Me.txtNoOfBags.Location = New System.Drawing.Point(84, 85)
        Me.txtNoOfBags.Name = "txtNoOfBags"
        Me.txtNoOfBags.Size = New System.Drawing.Size(227, 20)
        Me.txtNoOfBags.TabIndex = 9
        '
        'lblNoOfBags
        '
        Me.lblNoOfBags.AutoSize = True
        Me.lblNoOfBags.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfBags.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBags.Location = New System.Drawing.Point(6, 87)
        Me.lblNoOfBags.Name = "lblNoOfBags"
        Me.lblNoOfBags.Size = New System.Drawing.Size(78, 16)
        Me.lblNoOfBags.TabIndex = 8
        Me.lblNoOfBags.Text = "No Of Bags"
        '
        'txtTotalKg
        '
        Me.txtTotalKg.Location = New System.Drawing.Point(425, 85)
        Me.txtTotalKg.Name = "txtTotalKg"
        Me.txtTotalKg.Size = New System.Drawing.Size(221, 20)
        Me.txtTotalKg.TabIndex = 15
        '
        'lblTotalKg
        '
        Me.lblTotalKg.AutoSize = True
        Me.lblTotalKg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalKg.Location = New System.Drawing.Point(318, 87)
        Me.lblTotalKg.Name = "lblTotalKg"
        Me.lblTotalKg.Size = New System.Drawing.Size(60, 16)
        Me.lblTotalKg.TabIndex = 14
        Me.lblTotalKg.Text = "Total Kg"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.JISPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(949, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(654, 86)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(130, 20)
        Me.txtId.TabIndex = 27
        Me.txtId.Visible = False
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(790, 84)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(130, 20)
        Me.txtCode.TabIndex = 28
        Me.txtCode.Visible = False
        '
        'frmDebitNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmDebitNote"
        Me.Text = "Debit Note"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents lblCusName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTDate As System.Windows.Forms.Label
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFDate As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblExMillAmt As System.Windows.Forms.Label
    Friend WithEvents lblCommissionPer As System.Windows.Forms.Label
    Friend WithEvents txtExMillAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents txtTaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxPer As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtComAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtComPer As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfBags As System.Windows.Forms.TextBox
    Friend WithEvents lblNoOfBags As System.Windows.Forms.Label
    Friend WithEvents txtTotalKg As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalKg As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
End Class
