<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMillConfrimationSearch
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
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.Period = New System.Windows.Forms.CheckBox
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Month = New System.Windows.Forms.Label
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.Year = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.CustomerName = New System.Windows.Forms.Label
        Me.btnEMailParty = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPartyName = New System.Windows.Forms.ComboBox
        Me.CountGroup = New System.Windows.Forms.Label
        Me.cmbCountGroup = New System.Windows.Forms.ComboBox
        Me.BillingName = New System.Windows.Forms.Label
        Me.cmbBillingName = New System.Windows.Forms.ComboBox
        Me.PayMode = New System.Windows.Forms.Label
        Me.cmbPayMode = New System.Windows.Forms.ComboBox
        Me.Total = New System.Windows.Forms.Label
        Me.Status = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.ConNo = New System.Windows.Forms.Label
        Me.txtConfirmationNo = New System.Windows.Forms.TextBox
        Me.InvoiceNo = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.btnEMailMill = New System.Windows.Forms.Button
        Me.btnBoth = New System.Windows.Forms.Button
        Me.lblTotalBags = New System.Windows.Forms.Label
        Me.txtTotalBags = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.checkBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.lblHeading = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlToolBar.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(1141, 23)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(106, 23)
        Me.dtpFDate.TabIndex = 7
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(1255, 23)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.Size = New System.Drawing.Size(124, 23)
        Me.dtpTDate.TabIndex = 8
        '
        'Period
        '
        Me.Period.AutoSize = True
        Me.Period.ForeColor = System.Drawing.Color.Red
        Me.Period.Location = New System.Drawing.Point(1141, 3)
        Me.Period.Name = "Period"
        Me.Period.Size = New System.Drawing.Size(56, 17)
        Me.Period.TabIndex = 6
        Me.Period.Text = "Period"
        Me.Period.UseVisualStyleBackColor = True
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.Button1)
        Me.pnlToolBar.Controls.Add(Me.txtYear)
        Me.pnlToolBar.Controls.Add(Me.dtpFDate)
        Me.pnlToolBar.Controls.Add(Me.Period)
        Me.pnlToolBar.Controls.Add(Me.dtpTDate)
        Me.pnlToolBar.Controls.Add(Me.lblCode)
        Me.pnlToolBar.Controls.Add(Me.txtCode)
        Me.pnlToolBar.Controls.Add(Me.Month)
        Me.pnlToolBar.Controls.Add(Me.cmbMonth)
        Me.pnlToolBar.Controls.Add(Me.Year)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.CustomerName)
        Me.pnlToolBar.Controls.Add(Me.btnEMailParty)
        Me.pnlToolBar.Controls.Add(Me.Label1)
        Me.pnlToolBar.Controls.Add(Me.cmbPartyName)
        Me.pnlToolBar.Controls.Add(Me.CountGroup)
        Me.pnlToolBar.Controls.Add(Me.cmbCountGroup)
        Me.pnlToolBar.Controls.Add(Me.BillingName)
        Me.pnlToolBar.Controls.Add(Me.cmbBillingName)
        Me.pnlToolBar.Controls.Add(Me.PayMode)
        Me.pnlToolBar.Controls.Add(Me.cmbPayMode)
        Me.pnlToolBar.Controls.Add(Me.Total)
        Me.pnlToolBar.Controls.Add(Me.Status)
        Me.pnlToolBar.Controls.Add(Me.cmbStatus)
        Me.pnlToolBar.Controls.Add(Me.cmbMillName)
        Me.pnlToolBar.Controls.Add(Me.ConNo)
        Me.pnlToolBar.Controls.Add(Me.txtConfirmationNo)
        Me.pnlToolBar.Controls.Add(Me.InvoiceNo)
        Me.pnlToolBar.Controls.Add(Me.txtInvoiceNo)
        Me.pnlToolBar.Controls.Add(Me.btnEMailMill)
        Me.pnlToolBar.Controls.Add(Me.btnBoth)
        Me.pnlToolBar.Controls.Add(Me.lblTotalBags)
        Me.pnlToolBar.Controls.Add(Me.txtTotalBags)
        Me.pnlToolBar.Controls.Add(Me.ProgressBar1)
        Me.pnlToolBar.Controls.Add(Me.dgvSearch)
        Me.pnlToolBar.Controls.Add(Me.RichTextBox1)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1604, 831)
        Me.pnlToolBar.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1006, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 35)
        Me.Button1.TabIndex = 161
        Me.Button1.Text = "Test"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(1528, 23)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 159
        Me.txtYear.Text = "2014 - 2015"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(9, 10)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(80, 16)
        Me.lblCode.TabIndex = 29
        Me.lblCode.Text = "Sales Code"
        Me.lblCode.Visible = False
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(12, 29)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(127, 22)
        Me.txtCode.TabIndex = 30
        Me.txtCode.Visible = False
        '
        'Month
        '
        Me.Month.AutoSize = True
        Me.Month.BackColor = System.Drawing.Color.Transparent
        Me.Month.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Month.ForeColor = System.Drawing.Color.Red
        Me.Month.Location = New System.Drawing.Point(1387, 6)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(47, 16)
        Me.Month.TabIndex = 9
        Me.Month.Text = "Month"
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"April", "May", "June", "July", "August", "September", "October", "November", "December", "January", "February", "March"})
        Me.cmbMonth.Location = New System.Drawing.Point(1387, 23)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(133, 22)
        Me.cmbMonth.TabIndex = 10
        '
        'Year
        '
        Me.Year.AutoSize = True
        Me.Year.BackColor = System.Drawing.Color.Transparent
        Me.Year.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year.ForeColor = System.Drawing.Color.Red
        Me.Year.Location = New System.Drawing.Point(1528, 6)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(36, 16)
        Me.Year.TabIndex = 11
        Me.Year.Text = "Year"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(1172, 63)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 25
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
        Me.btnView.Location = New System.Drawing.Point(1246, 63)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 26
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
        Me.btnSave.Location = New System.Drawing.Point(1320, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&Save"
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
        Me.btnExit.Location = New System.Drawing.Point(1394, 63)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'CustomerName
        '
        Me.CustomerName.AutoSize = True
        Me.CustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerName.ForeColor = System.Drawing.Color.Red
        Me.CustomerName.Location = New System.Drawing.Point(199, 6)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(72, 16)
        Me.CustomerName.TabIndex = 0
        Me.CustomerName.Text = "Mill Name"
        '
        'btnEMailParty
        '
        Me.btnEMailParty.BackColor = System.Drawing.Color.White
        Me.btnEMailParty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEMailParty.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEMailParty.Location = New System.Drawing.Point(643, 98)
        Me.btnEMailParty.Name = "btnEMailParty"
        Me.btnEMailParty.Size = New System.Drawing.Size(148, 35)
        Me.btnEMailParty.TabIndex = 23
        Me.btnEMailParty.Text = "E-Mail to Party"
        Me.btnEMailParty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEMailParty.UseVisualStyleBackColor = False
        Me.btnEMailParty.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(529, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Party Name"
        '
        'cmbPartyName
        '
        Me.cmbPartyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPartyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(529, 22)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(316, 22)
        Me.cmbPartyName.Sorted = True
        Me.cmbPartyName.TabIndex = 3
        '
        'CountGroup
        '
        Me.CountGroup.AutoSize = True
        Me.CountGroup.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountGroup.ForeColor = System.Drawing.Color.Red
        Me.CountGroup.Location = New System.Drawing.Point(643, 51)
        Me.CountGroup.Name = "CountGroup"
        Me.CountGroup.Size = New System.Drawing.Size(104, 16)
        Me.CountGroup.TabIndex = 17
        Me.CountGroup.Text = "COUNT GROUP"
        '
        'cmbCountGroup
        '
        Me.cmbCountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCountGroup.FormattingEnabled = True
        Me.cmbCountGroup.Location = New System.Drawing.Point(643, 67)
        Me.cmbCountGroup.Name = "cmbCountGroup"
        Me.cmbCountGroup.Size = New System.Drawing.Size(213, 21)
        Me.cmbCountGroup.TabIndex = 18
        '
        'BillingName
        '
        Me.BillingName.AutoSize = True
        Me.BillingName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingName.ForeColor = System.Drawing.Color.Red
        Me.BillingName.Location = New System.Drawing.Point(860, 6)
        Me.BillingName.Name = "BillingName"
        Me.BillingName.Size = New System.Drawing.Size(90, 16)
        Me.BillingName.TabIndex = 4
        Me.BillingName.Text = "Billing Name"
        '
        'cmbBillingName
        '
        Me.cmbBillingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbBillingName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBillingName.FormattingEnabled = True
        Me.cmbBillingName.Location = New System.Drawing.Point(860, 22)
        Me.cmbBillingName.Name = "cmbBillingName"
        Me.cmbBillingName.Size = New System.Drawing.Size(272, 22)
        Me.cmbBillingName.Sorted = True
        Me.cmbBillingName.TabIndex = 5
        '
        'PayMode
        '
        Me.PayMode.AutoSize = True
        Me.PayMode.BackColor = System.Drawing.Color.Transparent
        Me.PayMode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayMode.ForeColor = System.Drawing.Color.Red
        Me.PayMode.Location = New System.Drawing.Point(872, 47)
        Me.PayMode.Name = "PayMode"
        Me.PayMode.Size = New System.Drawing.Size(71, 16)
        Me.PayMode.TabIndex = 19
        Me.PayMode.Text = "Pay Mode"
        '
        'cmbPayMode
        '
        Me.cmbPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPayMode.FormattingEnabled = True
        Me.cmbPayMode.Items.AddRange(New Object() {"Regular", "Advance"})
        Me.cmbPayMode.Location = New System.Drawing.Point(872, 63)
        Me.cmbPayMode.Name = "cmbPayMode"
        Me.cmbPayMode.Size = New System.Drawing.Size(133, 20)
        Me.cmbPayMode.TabIndex = 20
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Red
        Me.Total.Location = New System.Drawing.Point(661, 91)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(238, 46)
        Me.Total.TabIndex = 158
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(1021, 47)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(47, 16)
        Me.Status.TabIndex = 21
        Me.Status.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"P", "F"})
        Me.cmbStatus.Location = New System.Drawing.Point(1021, 63)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(133, 20)
        Me.cmbStatus.TabIndex = 22
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(199, 22)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(316, 20)
        Me.cmbMillName.TabIndex = 1
        '
        'ConNo
        '
        Me.ConNo.AutoSize = True
        Me.ConNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConNo.ForeColor = System.Drawing.Color.Red
        Me.ConNo.Location = New System.Drawing.Point(199, 51)
        Me.ConNo.Name = "ConNo"
        Me.ConNo.Size = New System.Drawing.Size(111, 16)
        Me.ConNo.TabIndex = 13
        Me.ConNo.Text = "Confirmation No"
        '
        'txtConfirmationNo
        '
        Me.txtConfirmationNo.Location = New System.Drawing.Point(199, 67)
        Me.txtConfirmationNo.Name = "txtConfirmationNo"
        Me.txtConfirmationNo.Size = New System.Drawing.Size(212, 20)
        Me.txtConfirmationNo.TabIndex = 14
        '
        'InvoiceNo
        '
        Me.InvoiceNo.AutoSize = True
        Me.InvoiceNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceNo.ForeColor = System.Drawing.Color.Red
        Me.InvoiceNo.Location = New System.Drawing.Point(427, 51)
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.Size = New System.Drawing.Size(75, 16)
        Me.InvoiceNo.TabIndex = 15
        Me.InvoiceNo.Text = "Invoice No"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(427, 67)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(200, 20)
        Me.txtInvoiceNo.TabIndex = 16
        '
        'btnEMailMill
        '
        Me.btnEMailMill.BackColor = System.Drawing.Color.White
        Me.btnEMailMill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEMailMill.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEMailMill.Location = New System.Drawing.Point(799, 98)
        Me.btnEMailMill.Name = "btnEMailMill"
        Me.btnEMailMill.Size = New System.Drawing.Size(148, 35)
        Me.btnEMailMill.TabIndex = 24
        Me.btnEMailMill.Text = "E-Mail to Mill"
        Me.btnEMailMill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEMailMill.UseVisualStyleBackColor = False
        Me.btnEMailMill.Visible = False
        '
        'btnBoth
        '
        Me.btnBoth.BackColor = System.Drawing.Color.White
        Me.btnBoth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBoth.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoth.Location = New System.Drawing.Point(199, 99)
        Me.btnBoth.Name = "btnBoth"
        Me.btnBoth.Size = New System.Drawing.Size(148, 35)
        Me.btnBoth.TabIndex = 160
        Me.btnBoth.Text = "E-Mail to Both"
        Me.btnBoth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBoth.UseVisualStyleBackColor = False
        '
        'lblTotalBags
        '
        Me.lblTotalBags.AutoSize = True
        Me.lblTotalBags.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBags.Location = New System.Drawing.Point(510, 96)
        Me.lblTotalBags.Name = "lblTotalBags"
        Me.lblTotalBags.Size = New System.Drawing.Size(74, 16)
        Me.lblTotalBags.TabIndex = 156
        Me.lblTotalBags.Text = "Total Bags"
        '
        'txtTotalBags
        '
        Me.txtTotalBags.Location = New System.Drawing.Point(510, 113)
        Me.txtTotalBags.Name = "txtTotalBags"
        Me.txtTotalBags.ReadOnly = True
        Me.txtTotalBags.Size = New System.Drawing.Size(129, 20)
        Me.txtTotalBags.TabIndex = 157
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 140)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1798, 23)
        Me.ProgressBar1.TabIndex = 31
        Me.ProgressBar1.Visible = False
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkBoxColumn})
        Me.dgvSearch.Location = New System.Drawing.Point(12, 169)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(1798, 640)
        Me.dgvSearch.TabIndex = 32
        '
        'checkBoxColumn
        '
        Me.checkBoxColumn.HeaderText = ""
        Me.checkBoxColumn.Name = "checkBoxColumn"
        Me.checkBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.checkBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1784, 118)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(26, 16)
        Me.RichTextBox1.TabIndex = 162
        Me.RichTextBox1.Text = ""
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1604, 42)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "MILL CONFIRMATION SEARCH"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1604, 873)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1604, 873)
        Me.pnlMain.TabIndex = 18
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 863)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1604, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'frmMillConfrimationSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 873)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmMillConfrimationSearch"
        Me.Text = "frmMillConfrimationSearch"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Period As System.Windows.Forms.CheckBox
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cmbBillingName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyName As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BillingName As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnEMailMill As System.Windows.Forms.Button
    Friend WithEvents btnEMailParty As System.Windows.Forms.Button
    Friend WithEvents txtTotalBags As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBags As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Year As System.Windows.Forms.Label
    Friend WithEvents Month As System.Windows.Forms.Label
    Friend WithEvents cmbCountGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents PayMode As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents CountGroup As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtConfirmationNo As System.Windows.Forms.TextBox
    Friend WithEvents ConNo As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents checkBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents btnBoth As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
