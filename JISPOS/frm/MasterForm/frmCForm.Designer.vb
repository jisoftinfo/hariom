<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCForm
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
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblAmount = New System.Windows.Forms.Label
        Me.txtCFormNo = New System.Windows.Forms.TextBox
        Me.lblCFormNo = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtCourierNo = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblProductName = New System.Windows.Forms.Label
        Me.lblCourierNo = New System.Windows.Forms.Label
        Me.lblEFId = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnView = New System.Windows.Forms.Button
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnSearch1 = New System.Windows.Forms.Button
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtpSendDate2 = New System.Windows.Forms.DateTimePicker
        Me.dtpSendDate1 = New System.Windows.Forms.DateTimePicker
        Me.lblE3Date = New System.Windows.Forms.Label
        Me.lblE3FormNo = New System.Windows.Forms.Label
        Me.lblCourier3 = New System.Windows.Forms.Label
        Me.lblCourierNo3 = New System.Windows.Forms.Label
        Me.txtCourierNo3 = New System.Windows.Forms.TextBox
        Me.lblC2Amount = New System.Windows.Forms.Label
        Me.lblC2FormNo = New System.Windows.Forms.Label
        Me.txtC2Amount = New System.Windows.Forms.TextBox
        Me.lblE2Date = New System.Windows.Forms.Label
        Me.lblE2FormNo = New System.Windows.Forms.Label
        Me.lblCourier1 = New System.Windows.Forms.Label
        Me.lblCourierNo1 = New System.Windows.Forms.Label
        Me.txtCourierNo1 = New System.Windows.Forms.TextBox
        Me.lblC1Amount = New System.Windows.Forms.Label
        Me.lblC1FormNo = New System.Windows.Forms.Label
        Me.txtC1Amount = New System.Windows.Forms.TextBox
        Me.lblEStatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBillingName = New System.Windows.Forms.Label
        Me.lblCAmount = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblE1FormNo = New System.Windows.Forms.Label
        Me.lblSendDate = New System.Windows.Forms.Label
        Me.lblCFormRCDate = New System.Windows.Forms.Label
        Me.lblPartyName = New System.Windows.Forms.Label
        Me.lblCourierName = New System.Windows.Forms.Label
        Me.lblE1Date = New System.Windows.Forms.Label
        Me.lblPeriodFrom = New System.Windows.Forms.Label
        Me.cmbPartyName = New System.Windows.Forms.ComboBox
        Me.cmbPeriodFrom = New System.Windows.Forms.ComboBox
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker
        Me.txtCourierName = New System.Windows.Forms.TextBox
        Me.txtE1FormNo = New System.Windows.Forms.TextBox
        Me.cmbMillName = New System.Windows.Forms.ComboBox
        Me.cmbBillingName = New System.Windows.Forms.ComboBox
        Me.txtCAmount = New System.Windows.Forms.TextBox
        Me.dtpSendDate = New System.Windows.Forms.DateTimePicker
        Me.txtE1Amount = New System.Windows.Forms.TextBox
        Me.dtpE1SentDate = New System.Windows.Forms.DateTimePicker
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.cmbE1Status = New System.Windows.Forms.ComboBox
        Me.txtC1FormNo = New System.Windows.Forms.TextBox
        Me.txtCourier1 = New System.Windows.Forms.TextBox
        Me.txtE2FormNo = New System.Windows.Forms.TextBox
        Me.txtC2FormNo = New System.Windows.Forms.TextBox
        Me.txtCourier3 = New System.Windows.Forms.TextBox
        Me.txtE3Form = New System.Windows.Forms.TextBox
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.txtMonth = New System.Windows.Forms.TextBox
        Me.lblMonth = New System.Windows.Forms.Label
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPartyCode = New System.Windows.Forms.TextBox
        Me.txtMillCode = New System.Windows.Forms.TextBox
        Me.pnlToolBar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(452, 85)
        Me.txtAmount.MaxLength = 100
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(318, 22)
        Me.txtAmount.TabIndex = 12
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(356, 88)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(57, 16)
        Me.lblAmount.TabIndex = 11
        Me.lblAmount.Text = "Amount"
        '
        'txtCFormNo
        '
        Me.txtCFormNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCFormNo.Location = New System.Drawing.Point(127, 116)
        Me.txtCFormNo.MaxLength = 100
        Me.txtCFormNo.Name = "txtCFormNo"
        Me.txtCFormNo.Size = New System.Drawing.Size(223, 22)
        Me.txtCFormNo.TabIndex = 14
        '
        'lblCFormNo
        '
        Me.lblCFormNo.AutoSize = True
        Me.lblCFormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFormNo.Location = New System.Drawing.Point(32, 119)
        Me.lblCFormNo.Name = "lblCFormNo"
        Me.lblCFormNo.Size = New System.Drawing.Size(75, 16)
        Me.lblCFormNo.TabIndex = 13
        Me.lblCFormNo.Text = "C Form No"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.JISPOS.My.Resources.Resources.adds35
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(933, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
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
        Me.txtSearchBox.TabIndex = 2
        Me.txtSearchBox.Visible = False
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(127, 20)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(223, 22)
        Me.txtCode.TabIndex = 1
        '
        'txtCourierNo
        '
        Me.txtCourierNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourierNo.Location = New System.Drawing.Point(452, 178)
        Me.txtCourierNo.MaxLength = 100
        Me.txtCourierNo.Name = "txtCourierNo"
        Me.txtCourierNo.Size = New System.Drawing.Size(318, 22)
        Me.txtCourierNo.TabIndex = 24
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(127, 20)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(223, 22)
        Me.txtId.TabIndex = 6
        Me.txtId.Visible = False
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(356, 23)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(72, 16)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "Mill Name"
        '
        'lblCourierNo
        '
        Me.lblCourierNo.AutoSize = True
        Me.lblCourierNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierNo.Location = New System.Drawing.Point(356, 181)
        Me.lblCourierNo.Name = "lblCourierNo"
        Me.lblCourierNo.Size = New System.Drawing.Size(76, 16)
        Me.lblCourierNo.TabIndex = 23
        Me.lblCourierNo.Text = "Courier No"
        '
        'lblEFId
        '
        Me.lblEFId.AutoSize = True
        Me.lblEFId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFId.Location = New System.Drawing.Point(32, 23)
        Me.lblEFId.Name = "lblEFId"
        Me.lblEFId.Size = New System.Drawing.Size(65, 16)
        Me.lblEFId.TabIndex = 0
        Me.lblEFId.Text = "EForm Id"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(386, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
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
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Location = New System.Drawing.Point(168, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(515, 56)
        Me.pnlToolBar.TabIndex = 0
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
        Me.pnlHeader.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "E1 Form"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(689, 45)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch1.TabIndex = 1
        Me.btnSearch1.Text = "SEARC&H"
        Me.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch1.UseVisualStyleBackColor = False
        Me.btnSearch1.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.txtPartyCode)
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Controls.Add(Me.dgvDetails)
        Me.pnlContent.Controls.Add(Me.txtYear)
        Me.pnlContent.Controls.Add(Me.txtMonth)
        Me.pnlContent.Controls.Add(Me.lblMonth)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 545)
        Me.pnlContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpSendDate2)
        Me.Panel1.Controls.Add(Me.txtMillCode)
        Me.Panel1.Controls.Add(Me.dtpSendDate1)
        Me.Panel1.Controls.Add(Me.lblE3Date)
        Me.Panel1.Controls.Add(Me.lblE3FormNo)
        Me.Panel1.Controls.Add(Me.lblCourier3)
        Me.Panel1.Controls.Add(Me.lblCourierNo3)
        Me.Panel1.Controls.Add(Me.txtCourierNo3)
        Me.Panel1.Controls.Add(Me.lblC2Amount)
        Me.Panel1.Controls.Add(Me.lblC2FormNo)
        Me.Panel1.Controls.Add(Me.txtC2Amount)
        Me.Panel1.Controls.Add(Me.lblE2Date)
        Me.Panel1.Controls.Add(Me.lblE2FormNo)
        Me.Panel1.Controls.Add(Me.lblCourier1)
        Me.Panel1.Controls.Add(Me.lblCourierNo1)
        Me.Panel1.Controls.Add(Me.txtCourierNo1)
        Me.Panel1.Controls.Add(Me.lblC1Amount)
        Me.Panel1.Controls.Add(Me.lblC1FormNo)
        Me.Panel1.Controls.Add(Me.txtC1Amount)
        Me.Panel1.Controls.Add(Me.lblEStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblBillingName)
        Me.Panel1.Controls.Add(Me.lblCAmount)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.lblE1FormNo)
        Me.Panel1.Controls.Add(Me.lblSendDate)
        Me.Panel1.Controls.Add(Me.lblCFormRCDate)
        Me.Panel1.Controls.Add(Me.lblPartyName)
        Me.Panel1.Controls.Add(Me.lblCourierName)
        Me.Panel1.Controls.Add(Me.lblE1Date)
        Me.Panel1.Controls.Add(Me.lblPeriodFrom)
        Me.Panel1.Controls.Add(Me.lblAmount)
        Me.Panel1.Controls.Add(Me.lblCFormNo)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblProductName)
        Me.Panel1.Controls.Add(Me.lblCourierNo)
        Me.Panel1.Controls.Add(Me.lblEFId)
        Me.Panel1.Controls.Add(Me.cmbPartyName)
        Me.Panel1.Controls.Add(Me.cmbPeriodFrom)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.txtCFormNo)
        Me.Panel1.Controls.Add(Me.dtpReceiveDate)
        Me.Panel1.Controls.Add(Me.txtCourierName)
        Me.Panel1.Controls.Add(Me.txtE1FormNo)
        Me.Panel1.Controls.Add(Me.cmbMillName)
        Me.Panel1.Controls.Add(Me.cmbBillingName)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.txtCAmount)
        Me.Panel1.Controls.Add(Me.dtpSendDate)
        Me.Panel1.Controls.Add(Me.txtCourierNo)
        Me.Panel1.Controls.Add(Me.txtE1Amount)
        Me.Panel1.Controls.Add(Me.dtpE1SentDate)
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.cmbE1Status)
        Me.Panel1.Controls.Add(Me.txtC1FormNo)
        Me.Panel1.Controls.Add(Me.txtCourier1)
        Me.Panel1.Controls.Add(Me.txtE2FormNo)
        Me.Panel1.Controls.Add(Me.txtC2FormNo)
        Me.Panel1.Controls.Add(Me.txtCourier3)
        Me.Panel1.Controls.Add(Me.txtE3Form)
        Me.Panel1.Location = New System.Drawing.Point(151, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 508)
        Me.Panel1.TabIndex = 1
        '
        'dtpSendDate2
        '
        Me.dtpSendDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpSendDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSendDate2.Location = New System.Drawing.Point(452, 466)
        Me.dtpSendDate2.Name = "dtpSendDate2"
        Me.dtpSendDate2.ShowUpDown = True
        Me.dtpSendDate2.Size = New System.Drawing.Size(318, 20)
        Me.dtpSendDate2.TabIndex = 57
        Me.dtpSendDate2.Visible = False
        '
        'dtpSendDate1
        '
        Me.dtpSendDate1.CustomFormat = "dd/MM/yyyy"
        Me.dtpSendDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSendDate1.Location = New System.Drawing.Point(452, 376)
        Me.dtpSendDate1.Name = "dtpSendDate1"
        Me.dtpSendDate1.ShowUpDown = True
        Me.dtpSendDate1.Size = New System.Drawing.Size(318, 20)
        Me.dtpSendDate1.TabIndex = 45
        Me.dtpSendDate1.Visible = False
        '
        'lblE3Date
        '
        Me.lblE3Date.AutoSize = True
        Me.lblE3Date.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE3Date.Location = New System.Drawing.Point(363, 468)
        Me.lblE3Date.Name = "lblE3Date"
        Me.lblE3Date.Size = New System.Drawing.Size(74, 16)
        Me.lblE3Date.TabIndex = 56
        Me.lblE3Date.Text = "Send Date"
        Me.lblE3Date.Visible = False
        '
        'lblE3FormNo
        '
        Me.lblE3FormNo.AutoSize = True
        Me.lblE3FormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE3FormNo.Location = New System.Drawing.Point(32, 468)
        Me.lblE3FormNo.Name = "lblE3FormNo"
        Me.lblE3FormNo.Size = New System.Drawing.Size(81, 16)
        Me.lblE3FormNo.TabIndex = 54
        Me.lblE3FormNo.Text = "E1 Form No"
        Me.lblE3FormNo.Visible = False
        '
        'lblCourier3
        '
        Me.lblCourier3.AutoSize = True
        Me.lblCourier3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourier3.Location = New System.Drawing.Point(32, 436)
        Me.lblCourier3.Name = "lblCourier3"
        Me.lblCourier3.Size = New System.Drawing.Size(96, 16)
        Me.lblCourier3.TabIndex = 50
        Me.lblCourier3.Text = "Courier Name"
        Me.lblCourier3.Visible = False
        '
        'lblCourierNo3
        '
        Me.lblCourierNo3.AutoSize = True
        Me.lblCourierNo3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierNo3.Location = New System.Drawing.Point(363, 434)
        Me.lblCourierNo3.Name = "lblCourierNo3"
        Me.lblCourierNo3.Size = New System.Drawing.Size(76, 16)
        Me.lblCourierNo3.TabIndex = 52
        Me.lblCourierNo3.Text = "Courier No"
        Me.lblCourierNo3.Visible = False
        '
        'txtCourierNo3
        '
        Me.txtCourierNo3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourierNo3.Location = New System.Drawing.Point(452, 431)
        Me.txtCourierNo3.MaxLength = 100
        Me.txtCourierNo3.Name = "txtCourierNo3"
        Me.txtCourierNo3.Size = New System.Drawing.Size(318, 22)
        Me.txtCourierNo3.TabIndex = 53
        Me.txtCourierNo3.Visible = False
        '
        'lblC2Amount
        '
        Me.lblC2Amount.AutoSize = True
        Me.lblC2Amount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Amount.Location = New System.Drawing.Point(363, 406)
        Me.lblC2Amount.Name = "lblC2Amount"
        Me.lblC2Amount.Size = New System.Drawing.Size(73, 16)
        Me.lblC2Amount.TabIndex = 48
        Me.lblC2Amount.Text = "C1Amount"
        Me.lblC2Amount.Visible = False
        '
        'lblC2FormNo
        '
        Me.lblC2FormNo.AutoSize = True
        Me.lblC2FormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2FormNo.Location = New System.Drawing.Point(32, 405)
        Me.lblC2FormNo.Name = "lblC2FormNo"
        Me.lblC2FormNo.Size = New System.Drawing.Size(82, 16)
        Me.lblC2FormNo.TabIndex = 46
        Me.lblC2FormNo.Text = "C1 Form No"
        Me.lblC2FormNo.Visible = False
        '
        'txtC2Amount
        '
        Me.txtC2Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC2Amount.Location = New System.Drawing.Point(452, 403)
        Me.txtC2Amount.MaxLength = 100
        Me.txtC2Amount.Name = "txtC2Amount"
        Me.txtC2Amount.Size = New System.Drawing.Size(318, 22)
        Me.txtC2Amount.TabIndex = 49
        Me.txtC2Amount.Visible = False
        '
        'lblE2Date
        '
        Me.lblE2Date.AutoSize = True
        Me.lblE2Date.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE2Date.Location = New System.Drawing.Point(363, 378)
        Me.lblE2Date.Name = "lblE2Date"
        Me.lblE2Date.Size = New System.Drawing.Size(74, 16)
        Me.lblE2Date.TabIndex = 44
        Me.lblE2Date.Text = "Send Date"
        Me.lblE2Date.Visible = False
        '
        'lblE2FormNo
        '
        Me.lblE2FormNo.AutoSize = True
        Me.lblE2FormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE2FormNo.Location = New System.Drawing.Point(32, 378)
        Me.lblE2FormNo.Name = "lblE2FormNo"
        Me.lblE2FormNo.Size = New System.Drawing.Size(81, 16)
        Me.lblE2FormNo.TabIndex = 42
        Me.lblE2FormNo.Text = "E1 Form No"
        Me.lblE2FormNo.Visible = False
        '
        'lblCourier1
        '
        Me.lblCourier1.AutoSize = True
        Me.lblCourier1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourier1.Location = New System.Drawing.Point(32, 346)
        Me.lblCourier1.Name = "lblCourier1"
        Me.lblCourier1.Size = New System.Drawing.Size(96, 16)
        Me.lblCourier1.TabIndex = 39
        Me.lblCourier1.Text = "Courier Name"
        Me.lblCourier1.Visible = False
        '
        'lblCourierNo1
        '
        Me.lblCourierNo1.AutoSize = True
        Me.lblCourierNo1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierNo1.Location = New System.Drawing.Point(363, 344)
        Me.lblCourierNo1.Name = "lblCourierNo1"
        Me.lblCourierNo1.Size = New System.Drawing.Size(76, 16)
        Me.lblCourierNo1.TabIndex = 41
        Me.lblCourierNo1.Text = "Courier No"
        Me.lblCourierNo1.Visible = False
        '
        'txtCourierNo1
        '
        Me.txtCourierNo1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourierNo1.Location = New System.Drawing.Point(452, 341)
        Me.txtCourierNo1.MaxLength = 100
        Me.txtCourierNo1.Name = "txtCourierNo1"
        Me.txtCourierNo1.Size = New System.Drawing.Size(318, 22)
        Me.txtCourierNo1.TabIndex = 42
        Me.txtCourierNo1.Visible = False
        '
        'lblC1Amount
        '
        Me.lblC1Amount.AutoSize = True
        Me.lblC1Amount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Amount.Location = New System.Drawing.Point(363, 316)
        Me.lblC1Amount.Name = "lblC1Amount"
        Me.lblC1Amount.Size = New System.Drawing.Size(73, 16)
        Me.lblC1Amount.TabIndex = 37
        Me.lblC1Amount.Text = "C1Amount"
        Me.lblC1Amount.Visible = False
        '
        'lblC1FormNo
        '
        Me.lblC1FormNo.AutoSize = True
        Me.lblC1FormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1FormNo.Location = New System.Drawing.Point(32, 315)
        Me.lblC1FormNo.Name = "lblC1FormNo"
        Me.lblC1FormNo.Size = New System.Drawing.Size(82, 16)
        Me.lblC1FormNo.TabIndex = 35
        Me.lblC1FormNo.Text = "C1 Form No"
        Me.lblC1FormNo.Visible = False
        '
        'txtC1Amount
        '
        Me.txtC1Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC1Amount.Location = New System.Drawing.Point(452, 313)
        Me.txtC1Amount.MaxLength = 100
        Me.txtC1Amount.Name = "txtC1Amount"
        Me.txtC1Amount.Size = New System.Drawing.Size(318, 22)
        Me.txtC1Amount.TabIndex = 38
        Me.txtC1Amount.Visible = False
        '
        'lblEStatus
        '
        Me.lblEStatus.AutoSize = True
        Me.lblEStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEStatus.Location = New System.Drawing.Point(32, 279)
        Me.lblEStatus.Name = "lblEStatus"
        Me.lblEStatus.Size = New System.Drawing.Size(66, 16)
        Me.lblEStatus.TabIndex = 33
        Me.lblEStatus.Text = "E1 Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "E1 Amount"
        '
        'lblBillingName
        '
        Me.lblBillingName.AutoSize = True
        Me.lblBillingName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingName.Location = New System.Drawing.Point(356, 55)
        Me.lblBillingName.Name = "lblBillingName"
        Me.lblBillingName.Size = New System.Drawing.Size(90, 16)
        Me.lblBillingName.TabIndex = 6
        Me.lblBillingName.Text = "Billing Name"
        '
        'lblCAmount
        '
        Me.lblCAmount.AutoSize = True
        Me.lblCAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAmount.Location = New System.Drawing.Point(356, 120)
        Me.lblCAmount.Name = "lblCAmount"
        Me.lblCAmount.Size = New System.Drawing.Size(66, 16)
        Me.lblCAmount.TabIndex = 15
        Me.lblCAmount.Text = "CAmount"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(32, 247)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 16)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "C Status"
        '
        'lblE1FormNo
        '
        Me.lblE1FormNo.AutoSize = True
        Me.lblE1FormNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE1FormNo.Location = New System.Drawing.Point(32, 215)
        Me.lblE1FormNo.Name = "lblE1FormNo"
        Me.lblE1FormNo.Size = New System.Drawing.Size(81, 16)
        Me.lblE1FormNo.TabIndex = 25
        Me.lblE1FormNo.Text = "E1 Form No"
        '
        'lblSendDate
        '
        Me.lblSendDate.AutoSize = True
        Me.lblSendDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSendDate.Location = New System.Drawing.Point(356, 152)
        Me.lblSendDate.Name = "lblSendDate"
        Me.lblSendDate.Size = New System.Drawing.Size(87, 16)
        Me.lblSendDate.TabIndex = 19
        Me.lblSendDate.Text = "C Send Date"
        '
        'lblCFormRCDate
        '
        Me.lblCFormRCDate.AutoSize = True
        Me.lblCFormRCDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFormRCDate.Location = New System.Drawing.Point(32, 151)
        Me.lblCFormRCDate.Name = "lblCFormRCDate"
        Me.lblCFormRCDate.Size = New System.Drawing.Size(86, 16)
        Me.lblCFormRCDate.TabIndex = 17
        Me.lblCFormRCDate.Text = "C Recd Date"
        '
        'lblPartyName
        '
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.Location = New System.Drawing.Point(32, 55)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(82, 16)
        Me.lblPartyName.TabIndex = 4
        Me.lblPartyName.Text = "Party Name"
        '
        'lblCourierName
        '
        Me.lblCourierName.AutoSize = True
        Me.lblCourierName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierName.Location = New System.Drawing.Point(32, 183)
        Me.lblCourierName.Name = "lblCourierName"
        Me.lblCourierName.Size = New System.Drawing.Size(96, 16)
        Me.lblCourierName.TabIndex = 21
        Me.lblCourierName.Text = "Courier Name"
        '
        'lblE1Date
        '
        Me.lblE1Date.AutoSize = True
        Me.lblE1Date.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE1Date.Location = New System.Drawing.Point(356, 243)
        Me.lblE1Date.Name = "lblE1Date"
        Me.lblE1Date.Size = New System.Drawing.Size(89, 16)
        Me.lblE1Date.TabIndex = 31
        Me.lblE1Date.Text = "E1 Sent Date"
        '
        'lblPeriodFrom
        '
        Me.lblPeriodFrom.AutoSize = True
        Me.lblPeriodFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodFrom.Location = New System.Drawing.Point(32, 87)
        Me.lblPeriodFrom.Name = "lblPeriodFrom"
        Me.lblPeriodFrom.Size = New System.Drawing.Size(87, 16)
        Me.lblPeriodFrom.TabIndex = 8
        Me.lblPeriodFrom.Text = "Period From"
        '
        'cmbPartyName
        '
        Me.cmbPartyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(127, 53)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(223, 21)
        Me.cmbPartyName.TabIndex = 5
        '
        'cmbPeriodFrom
        '
        Me.cmbPeriodFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPeriodFrom.FormattingEnabled = True
        Me.cmbPeriodFrom.Items.AddRange(New Object() {"Apr - Jun", "Jun - Sep", "Oct - Dec", "Jan - Mar"})
        Me.cmbPeriodFrom.Location = New System.Drawing.Point(127, 85)
        Me.cmbPeriodFrom.Name = "cmbPeriodFrom"
        Me.cmbPeriodFrom.Size = New System.Drawing.Size(116, 21)
        Me.cmbPeriodFrom.TabIndex = 9
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2014 - 2015", "2015 - 2016", "2016 - 2017", "2017 - 2018", "2018 - 2019", "2019 - 2020", "2020 - 2021", "2021 - 2022", "2022 - 2023", "2023 - 2024", "2024 - 2025"})
        Me.cmbYear.Location = New System.Drawing.Point(249, 85)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(101, 21)
        Me.cmbYear.TabIndex = 10
        '
        'dtpReceiveDate
        '
        Me.dtpReceiveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReceiveDate.Location = New System.Drawing.Point(127, 149)
        Me.dtpReceiveDate.Name = "dtpReceiveDate"
        Me.dtpReceiveDate.ShowUpDown = True
        Me.dtpReceiveDate.Size = New System.Drawing.Size(223, 20)
        Me.dtpReceiveDate.TabIndex = 18
        '
        'txtCourierName
        '
        Me.txtCourierName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourierName.Location = New System.Drawing.Point(128, 180)
        Me.txtCourierName.MaxLength = 100
        Me.txtCourierName.Name = "txtCourierName"
        Me.txtCourierName.Size = New System.Drawing.Size(223, 22)
        Me.txtCourierName.TabIndex = 22
        '
        'txtE1FormNo
        '
        Me.txtE1FormNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE1FormNo.Location = New System.Drawing.Point(127, 212)
        Me.txtE1FormNo.MaxLength = 100
        Me.txtE1FormNo.Name = "txtE1FormNo"
        Me.txtE1FormNo.Size = New System.Drawing.Size(223, 22)
        Me.txtE1FormNo.TabIndex = 26
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Location = New System.Drawing.Point(452, 21)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(318, 21)
        Me.cmbMillName.TabIndex = 3
        '
        'cmbBillingName
        '
        Me.cmbBillingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbBillingName.FormattingEnabled = True
        Me.cmbBillingName.Location = New System.Drawing.Point(452, 53)
        Me.cmbBillingName.Name = "cmbBillingName"
        Me.cmbBillingName.Size = New System.Drawing.Size(318, 21)
        Me.cmbBillingName.TabIndex = 7
        '
        'txtCAmount
        '
        Me.txtCAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAmount.Location = New System.Drawing.Point(452, 117)
        Me.txtCAmount.MaxLength = 100
        Me.txtCAmount.Name = "txtCAmount"
        Me.txtCAmount.Size = New System.Drawing.Size(318, 22)
        Me.txtCAmount.TabIndex = 16
        '
        'dtpSendDate
        '
        Me.dtpSendDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpSendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSendDate.Location = New System.Drawing.Point(452, 150)
        Me.dtpSendDate.Name = "dtpSendDate"
        Me.dtpSendDate.ShowUpDown = True
        Me.dtpSendDate.Size = New System.Drawing.Size(318, 20)
        Me.dtpSendDate.TabIndex = 20
        '
        'txtE1Amount
        '
        Me.txtE1Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE1Amount.Location = New System.Drawing.Point(452, 209)
        Me.txtE1Amount.MaxLength = 100
        Me.txtE1Amount.Name = "txtE1Amount"
        Me.txtE1Amount.Size = New System.Drawing.Size(318, 22)
        Me.txtE1Amount.TabIndex = 28
        '
        'dtpE1SentDate
        '
        Me.dtpE1SentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpE1SentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpE1SentDate.Location = New System.Drawing.Point(452, 241)
        Me.dtpE1SentDate.Name = "dtpE1SentDate"
        Me.dtpE1SentDate.ShowUpDown = True
        Me.dtpE1SentDate.Size = New System.Drawing.Size(318, 20)
        Me.dtpE1SentDate.TabIndex = 32
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Finished", "Pending"})
        Me.cmbStatus.Location = New System.Drawing.Point(127, 245)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(223, 21)
        Me.cmbStatus.TabIndex = 30
        '
        'cmbE1Status
        '
        Me.cmbE1Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbE1Status.FormattingEnabled = True
        Me.cmbE1Status.Items.AddRange(New Object() {"Finished", "Pending"})
        Me.cmbE1Status.Location = New System.Drawing.Point(127, 277)
        Me.cmbE1Status.Name = "cmbE1Status"
        Me.cmbE1Status.Size = New System.Drawing.Size(223, 21)
        Me.cmbE1Status.TabIndex = 34
        '
        'txtC1FormNo
        '
        Me.txtC1FormNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC1FormNo.Location = New System.Drawing.Point(130, 312)
        Me.txtC1FormNo.MaxLength = 100
        Me.txtC1FormNo.Name = "txtC1FormNo"
        Me.txtC1FormNo.Size = New System.Drawing.Size(223, 22)
        Me.txtC1FormNo.TabIndex = 36
        Me.txtC1FormNo.Visible = False
        '
        'txtCourier1
        '
        Me.txtCourier1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourier1.Location = New System.Drawing.Point(130, 343)
        Me.txtCourier1.MaxLength = 100
        Me.txtCourier1.Name = "txtCourier1"
        Me.txtCourier1.Size = New System.Drawing.Size(223, 22)
        Me.txtCourier1.TabIndex = 40
        Me.txtCourier1.Visible = False
        '
        'txtE2FormNo
        '
        Me.txtE2FormNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE2FormNo.Location = New System.Drawing.Point(130, 375)
        Me.txtE2FormNo.MaxLength = 100
        Me.txtE2FormNo.Name = "txtE2FormNo"
        Me.txtE2FormNo.Size = New System.Drawing.Size(223, 22)
        Me.txtE2FormNo.TabIndex = 43
        Me.txtE2FormNo.Visible = False
        '
        'txtC2FormNo
        '
        Me.txtC2FormNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC2FormNo.Location = New System.Drawing.Point(130, 402)
        Me.txtC2FormNo.MaxLength = 100
        Me.txtC2FormNo.Name = "txtC2FormNo"
        Me.txtC2FormNo.Size = New System.Drawing.Size(223, 22)
        Me.txtC2FormNo.TabIndex = 47
        Me.txtC2FormNo.Visible = False
        '
        'txtCourier3
        '
        Me.txtCourier3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourier3.Location = New System.Drawing.Point(130, 433)
        Me.txtCourier3.MaxLength = 100
        Me.txtCourier3.Name = "txtCourier3"
        Me.txtCourier3.Size = New System.Drawing.Size(223, 22)
        Me.txtCourier3.TabIndex = 51
        Me.txtCourier3.Visible = False
        '
        'txtE3Form
        '
        Me.txtE3Form.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE3Form.Location = New System.Drawing.Point(130, 465)
        Me.txtE3Form.MaxLength = 100
        Me.txtE3Form.Name = "txtE3Form"
        Me.txtE3Form.Size = New System.Drawing.Size(223, 22)
        Me.txtE3Form.TabIndex = 55
        Me.txtE3Form.Visible = False
        '
        'dgvDetails
        '
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.ColumnHeadersVisible = False
        Me.dgvDetails.Location = New System.Drawing.Point(5, 342)
        Me.dgvDetails.Name = "dgvDetails"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDetails.Size = New System.Drawing.Size(121, 57)
        Me.dgvDetails.TabIndex = 33
        Me.dgvDetails.Visible = False
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(36, 237)
        Me.txtYear.MaxLength = 100
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(109, 22)
        Me.txtYear.TabIndex = 32
        Me.txtYear.Visible = False
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(12, 477)
        Me.txtMonth.MaxLength = 100
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(140, 22)
        Me.txtMonth.TabIndex = 33
        Me.txtMonth.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(47, 437)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(47, 16)
        Me.lblMonth.TabIndex = 32
        Me.lblMonth.Text = "Month"
        Me.lblMonth.Visible = False
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
        Me.pnlMain.TabIndex = 8
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtPartyCode
        '
        Me.txtPartyCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartyCode.Location = New System.Drawing.Point(93, 86)
        Me.txtPartyCode.MaxLength = 100
        Me.txtPartyCode.Name = "txtPartyCode"
        Me.txtPartyCode.Size = New System.Drawing.Size(84, 22)
        Me.txtPartyCode.TabIndex = 54
        Me.txtPartyCode.Visible = False
        '
        'txtMillCode
        '
        Me.txtMillCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMillCode.Location = New System.Drawing.Point(776, 17)
        Me.txtMillCode.MaxLength = 100
        Me.txtMillCode.Name = "txtMillCode"
        Me.txtMillCode.Size = New System.Drawing.Size(84, 22)
        Me.txtMillCode.TabIndex = 53
        Me.txtMillCode.Visible = False
        '
        'frmCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmCForm"
        Me.Text = "C Form"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtCFormNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCFormNo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCourierNo As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblCourierNo As System.Windows.Forms.Label
    Friend WithEvents lblEFId As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblPeriodFrom As System.Windows.Forms.Label
    Friend WithEvents dtpE1SentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblE1Date As System.Windows.Forms.Label
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents lblCourierName As System.Windows.Forms.Label
    Friend WithEvents txtCourierName As System.Windows.Forms.TextBox
    Friend WithEvents dtpSendDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSendDate As System.Windows.Forms.Label
    Friend WithEvents dtpReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCFormRCDate As System.Windows.Forms.Label
    Friend WithEvents cmbPartyName As System.Windows.Forms.ComboBox
    Friend WithEvents lblPartyName As System.Windows.Forms.Label
    Friend WithEvents txtE1FormNo As System.Windows.Forms.TextBox
    Friend WithEvents lblE1FormNo As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblCAmount As System.Windows.Forms.Label
    Friend WithEvents txtCAmount As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblBillingName As System.Windows.Forms.Label
    Friend WithEvents cmbBillingName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPeriodFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtE1Amount As System.Windows.Forms.TextBox
    Friend WithEvents lblEStatus As System.Windows.Forms.Label
    Friend WithEvents cmbE1Status As System.Windows.Forms.ComboBox
    Friend WithEvents lblE2Date As System.Windows.Forms.Label
    Friend WithEvents lblE2FormNo As System.Windows.Forms.Label
    Friend WithEvents lblCourier1 As System.Windows.Forms.Label
    Friend WithEvents lblCourierNo1 As System.Windows.Forms.Label
    Friend WithEvents txtCourier1 As System.Windows.Forms.TextBox
    Friend WithEvents txtE2FormNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCourierNo1 As System.Windows.Forms.TextBox
    Friend WithEvents lblC1Amount As System.Windows.Forms.Label
    Friend WithEvents lblC1FormNo As System.Windows.Forms.Label
    Friend WithEvents txtC1FormNo As System.Windows.Forms.TextBox
    Friend WithEvents txtC1Amount As System.Windows.Forms.TextBox
    Friend WithEvents lblE3Date As System.Windows.Forms.Label
    Friend WithEvents lblE3FormNo As System.Windows.Forms.Label
    Friend WithEvents lblCourier3 As System.Windows.Forms.Label
    Friend WithEvents lblCourierNo3 As System.Windows.Forms.Label
    Friend WithEvents txtCourier3 As System.Windows.Forms.TextBox
    Friend WithEvents txtE3Form As System.Windows.Forms.TextBox
    Friend WithEvents txtCourierNo3 As System.Windows.Forms.TextBox
    Friend WithEvents lblC2Amount As System.Windows.Forms.Label
    Friend WithEvents lblC2FormNo As System.Windows.Forms.Label
    Friend WithEvents txtC2FormNo As System.Windows.Forms.TextBox
    Friend WithEvents txtC2Amount As System.Windows.Forms.TextBox
    Friend WithEvents dtpSendDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSendDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPartyCode As System.Windows.Forms.TextBox
    Friend WithEvents txtMillCode As System.Windows.Forms.TextBox
End Class
