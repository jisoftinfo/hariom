<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendingBillParty
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.lblHeading = New System.Windows.Forms.Label
        Me.cbxBillPeriod = New System.Windows.Forms.CheckBox
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.s = New System.Windows.Forms.DataGridView
        Me.cbxPendingPeriod = New System.Windows.Forms.CheckBox
        Me.dgvPending = New System.Windows.Forms.DataGridView
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.dtpTDate2 = New System.Windows.Forms.DateTimePicker
        Me.pnlOne = New System.Windows.Forms.Panel
        Me.rbnInfixMill = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMill = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMill = New System.Windows.Forms.RadioButton
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblMillName = New System.Windows.Forms.Label
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFDate2 = New System.Windows.Forms.DateTimePicker
        Me.dtpTDate = New System.Windows.Forms.DateTimePicker
        Me.btnView = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlHeader.SuspendLayout()
        CType(Me.s, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.pnlOne.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbMillName
        '
        Me.cmbMillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMillName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMillName.FormattingEnabled = True
        Me.cmbMillName.Items.AddRange(New Object() {"First", "Fourth", "Second", "Third"})
        Me.cmbMillName.Location = New System.Drawing.Point(101, 33)
        Me.cmbMillName.Name = "cmbMillName"
        Me.cmbMillName.Size = New System.Drawing.Size(307, 22)
        Me.cmbMillName.Sorted = True
        Me.cmbMillName.TabIndex = 144
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xls"
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1565, 51)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1565, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Party Pending Debit Note"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxBillPeriod
        '
        Me.cbxBillPeriod.AutoSize = True
        Me.cbxBillPeriod.Location = New System.Drawing.Point(652, 11)
        Me.cbxBillPeriod.Name = "cbxBillPeriod"
        Me.cbxBillPeriod.Size = New System.Drawing.Size(72, 17)
        Me.cbxBillPeriod.TabIndex = 152
        Me.cbxBillPeriod.Text = "Bill Period"
        Me.cbxBillPeriod.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 793)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1565, 10)
        Me.pnlFooter.TabIndex = 1
        '
        's
        '
        Me.s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.s.Location = New System.Drawing.Point(592, 61)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(961, 675)
        Me.s.TabIndex = 1
        '
        'cbxPendingPeriod
        '
        Me.cbxPendingPeriod.AutoSize = True
        Me.cbxPendingPeriod.Location = New System.Drawing.Point(414, 11)
        Me.cbxPendingPeriod.Name = "cbxPendingPeriod"
        Me.cbxPendingPeriod.Size = New System.Drawing.Size(98, 17)
        Me.cbxPendingPeriod.TabIndex = 151
        Me.cbxPendingPeriod.Text = "Pending Period"
        Me.cbxPendingPeriod.UseVisualStyleBackColor = True
        '
        'dgvPending
        '
        Me.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPending.Location = New System.Drawing.Point(12, 61)
        Me.dgvPending.Name = "dgvPending"
        Me.dgvPending.Size = New System.Drawing.Size(571, 675)
        Me.dgvPending.TabIndex = 0
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.dtpTDate2)
        Me.pnlContent.Controls.Add(Me.dtpFDate2)
        Me.pnlContent.Controls.Add(Me.cmbMillName)
        Me.pnlContent.Controls.Add(Me.cbxBillPeriod)
        Me.pnlContent.Controls.Add(Me.s)
        Me.pnlContent.Controls.Add(Me.cbxPendingPeriod)
        Me.pnlContent.Controls.Add(Me.dgvPending)
        Me.pnlContent.Controls.Add(Me.pnlOne)
        Me.pnlContent.Controls.Add(Me.btnSearch)
        Me.pnlContent.Controls.Add(Me.btnExit)
        Me.pnlContent.Controls.Add(Me.lblMillName)
        Me.pnlContent.Controls.Add(Me.dtpFDate)
        Me.pnlContent.Controls.Add(Me.dtpTDate)
        Me.pnlContent.Controls.Add(Me.btnView)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 51)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1565, 742)
        Me.pnlContent.TabIndex = 0
        '
        'dtpTDate2
        '
        Me.dtpTDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate2.Location = New System.Drawing.Point(775, 31)
        Me.dtpTDate2.Name = "dtpTDate2"
        Me.dtpTDate2.Size = New System.Drawing.Size(116, 23)
        Me.dtpTDate2.TabIndex = 140
        '
        'pnlOne
        '
        Me.pnlOne.Controls.Add(Me.rbnInfixMill)
        Me.pnlOne.Controls.Add(Me.rbnSuffixMill)
        Me.pnlOne.Controls.Add(Me.rbnPrefixMill)
        Me.pnlOne.Location = New System.Drawing.Point(226, 14)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(182, 20)
        Me.pnlOne.TabIndex = 142
        '
        'rbnInfixMill
        '
        Me.rbnInfixMill.AutoSize = True
        Me.rbnInfixMill.Checked = True
        Me.rbnInfixMill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMill.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixMill.Name = "rbnInfixMill"
        Me.rbnInfixMill.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixMill.TabIndex = 13
        Me.rbnInfixMill.TabStop = True
        Me.rbnInfixMill.Text = "Infix"
        Me.rbnInfixMill.UseVisualStyleBackColor = True
        '
        'rbnSuffixMill
        '
        Me.rbnSuffixMill.AutoSize = True
        Me.rbnSuffixMill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMill.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixMill.Name = "rbnSuffixMill"
        Me.rbnSuffixMill.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixMill.TabIndex = 14
        Me.rbnSuffixMill.Text = "Suffix"
        Me.rbnSuffixMill.UseVisualStyleBackColor = True
        '
        'rbnPrefixMill
        '
        Me.rbnPrefixMill.AutoSize = True
        Me.rbnPrefixMill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMill.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMill.Name = "rbnPrefixMill"
        Me.rbnPrefixMill.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixMill.TabIndex = 12
        Me.rbnPrefixMill.Text = "Prefix"
        Me.rbnPrefixMill.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(907, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1055, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblMillName
        '
        Me.lblMillName.AutoSize = True
        Me.lblMillName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillName.Location = New System.Drawing.Point(98, 16)
        Me.lblMillName.Name = "lblMillName"
        Me.lblMillName.Size = New System.Drawing.Size(82, 16)
        Me.lblMillName.TabIndex = 143
        Me.lblMillName.Text = "Party Name"
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(413, 31)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(116, 23)
        Me.dtpFDate.TabIndex = 19
        '
        'dtpFDate2
        '
        Me.dtpFDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpFDate2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate2.Location = New System.Drawing.Point(651, 31)
        Me.dtpFDate2.Name = "dtpFDate2"
        Me.dtpFDate2.Size = New System.Drawing.Size(116, 23)
        Me.dtpFDate2.TabIndex = 139
        '
        'dtpTDate
        '
        Me.dtpTDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTDate.Location = New System.Drawing.Point(529, 31)
        Me.dtpTDate.Name = "dtpTDate"
        Me.dtpTDate.Size = New System.Drawing.Size(116, 23)
        Me.dtpTDate.TabIndex = 20
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.JISPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(981, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 138
        Me.btnView.Text = "&Export"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1565, 803)
        Me.pnlMain.TabIndex = 13
        '
        'frmPendingBillParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1565, 803)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPendingBillParty"
        Me.Text = "frmPendingBillParty"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.s, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbMillName As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents cbxBillPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents s As System.Windows.Forms.DataGridView
    Friend WithEvents cbxPendingPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents dgvPending As System.Windows.Forms.DataGridView
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents dtpTDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMill As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMill As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMill As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMillName As System.Windows.Forms.Label
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
End Class
