<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLedgersReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbnInfixMobile = New System.Windows.Forms.RadioButton
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMobile = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMobile = New System.Windows.Forms.RadioButton
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnInfixAddress = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress = New System.Windows.Forms.RadioButton
        Me.lblLedgerName = New System.Windows.Forms.Label
        Me.rbnPrefixAddress = New System.Windows.Forms.RadioButton
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtLedgerName = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rbnInfixMailId = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMailId = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMailId = New System.Windows.Forms.RadioButton
        Me.txtMailId = New System.Windows.Forms.TextBox
        Me.lblMailID = New System.Windows.Forms.Label
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.cmbOrderBy = New System.Windows.Forms.ComboBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.rbnDescending = New System.Windows.Forms.RadioButton
        Me.rbnAscending = New System.Windows.Forms.RadioButton
        Me.lblOrderBy = New System.Windows.Forms.Label
        Me.lblMobile = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnInfixMobile
        '
        Me.rbnInfixMobile.AutoSize = True
        Me.rbnInfixMobile.Checked = True
        Me.rbnInfixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMobile.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixMobile.Name = "rbnInfixMobile"
        Me.rbnInfixMobile.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixMobile.TabIndex = 23
        Me.rbnInfixMobile.TabStop = True
        Me.rbnInfixMobile.Text = "Infix"
        Me.rbnInfixMobile.UseVisualStyleBackColor = True
        '
        'rbnInfixCustomer
        '
        Me.rbnInfixCustomer.AutoSize = True
        Me.rbnInfixCustomer.Checked = True
        Me.rbnInfixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixCustomer.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixCustomer.Name = "rbnInfixCustomer"
        Me.rbnInfixCustomer.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixCustomer.TabIndex = 13
        Me.rbnInfixCustomer.TabStop = True
        Me.rbnInfixCustomer.Text = "Infix"
        Me.rbnInfixCustomer.UseVisualStyleBackColor = True
        '
        'rbnSuffixMobile
        '
        Me.rbnSuffixMobile.AutoSize = True
        Me.rbnSuffixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMobile.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixMobile.Name = "rbnSuffixMobile"
        Me.rbnSuffixMobile.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixMobile.TabIndex = 24
        Me.rbnSuffixMobile.Text = "Suffix"
        Me.rbnSuffixMobile.UseVisualStyleBackColor = True
        '
        'rbnPrefixMobile
        '
        Me.rbnPrefixMobile.AutoSize = True
        Me.rbnPrefixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMobile.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMobile.Name = "rbnPrefixMobile"
        Me.rbnPrefixMobile.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixMobile.TabIndex = 22
        Me.rbnPrefixMobile.Text = "Prefix"
        Me.rbnPrefixMobile.UseVisualStyleBackColor = True
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(14, 72)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(310, 20)
        Me.txtMobile.TabIndex = 4
        '
        'rbnSuffixCustomer
        '
        Me.rbnSuffixCustomer.AutoSize = True
        Me.rbnSuffixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixCustomer.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixCustomer.Name = "rbnSuffixCustomer"
        Me.rbnSuffixCustomer.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixCustomer.TabIndex = 14
        Me.rbnSuffixCustomer.Text = "Suffix"
        Me.rbnSuffixCustomer.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(7, 216)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1159, 439)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'rbnPrefixCustomer
        '
        Me.rbnPrefixCustomer.AutoSize = True
        Me.rbnPrefixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixCustomer.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixCustomer.Name = "rbnPrefixCustomer"
        Me.rbnPrefixCustomer.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixCustomer.TabIndex = 12
        Me.rbnPrefixCustomer.Text = "Prefix"
        Me.rbnPrefixCustomer.UseVisualStyleBackColor = True
        '
        'rbnInfixAddress
        '
        Me.rbnInfixAddress.AutoSize = True
        Me.rbnInfixAddress.Checked = True
        Me.rbnInfixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixAddress.Location = New System.Drawing.Point(484, 52)
        Me.rbnInfixAddress.Name = "rbnInfixAddress"
        Me.rbnInfixAddress.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixAddress.TabIndex = 8
        Me.rbnInfixAddress.TabStop = True
        Me.rbnInfixAddress.Text = "Infix"
        Me.rbnInfixAddress.UseVisualStyleBackColor = True
        '
        'rbnSuffixAddress
        '
        Me.rbnSuffixAddress.AutoSize = True
        Me.rbnSuffixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixAddress.Location = New System.Drawing.Point(552, 52)
        Me.rbnSuffixAddress.Name = "rbnSuffixAddress"
        Me.rbnSuffixAddress.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixAddress.TabIndex = 9
        Me.rbnSuffixAddress.Text = "Suffix"
        Me.rbnSuffixAddress.UseVisualStyleBackColor = True
        '
        'lblLedgerName
        '
        Me.lblLedgerName.AutoSize = True
        Me.lblLedgerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLedgerName.Location = New System.Drawing.Point(14, 11)
        Me.lblLedgerName.Name = "lblLedgerName"
        Me.lblLedgerName.Size = New System.Drawing.Size(94, 16)
        Me.lblLedgerName.TabIndex = 0
        Me.lblLedgerName.Text = "Ledger Name"
        '
        'rbnPrefixAddress
        '
        Me.rbnPrefixAddress.AutoSize = True
        Me.rbnPrefixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixAddress.Location = New System.Drawing.Point(409, 52)
        Me.rbnPrefixAddress.Name = "rbnPrefixAddress"
        Me.rbnPrefixAddress.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixAddress.TabIndex = 7
        Me.rbnPrefixAddress.Text = "Prefix"
        Me.rbnPrefixAddress.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(345, 72)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(312, 20)
        Me.txtAddress.TabIndex = 6
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(345, 52)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(755, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtLedgerName
        '
        Me.txtLedgerName.Location = New System.Drawing.Point(14, 27)
        Me.txtLedgerName.Name = "txtLedgerName"
        Me.txtLedgerName.Size = New System.Drawing.Size(310, 20)
        Me.txtLedgerName.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbnInfixMailId)
        Me.Panel3.Controls.Add(Me.rbnSuffixMailId)
        Me.Panel3.Controls.Add(Me.rbnPrefixMailId)
        Me.Panel3.Location = New System.Drawing.Point(142, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(182, 20)
        Me.Panel3.TabIndex = 27
        '
        'rbnInfixMailId
        '
        Me.rbnInfixMailId.AutoSize = True
        Me.rbnInfixMailId.Checked = True
        Me.rbnInfixMailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMailId.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixMailId.Name = "rbnInfixMailId"
        Me.rbnInfixMailId.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixMailId.TabIndex = 28
        Me.rbnInfixMailId.TabStop = True
        Me.rbnInfixMailId.Text = "Infix"
        Me.rbnInfixMailId.UseVisualStyleBackColor = True
        '
        'rbnSuffixMailId
        '
        Me.rbnSuffixMailId.AutoSize = True
        Me.rbnSuffixMailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMailId.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixMailId.Name = "rbnSuffixMailId"
        Me.rbnSuffixMailId.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixMailId.TabIndex = 29
        Me.rbnSuffixMailId.Text = "Suffix"
        Me.rbnSuffixMailId.UseVisualStyleBackColor = True
        '
        'rbnPrefixMailId
        '
        Me.rbnPrefixMailId.AutoSize = True
        Me.rbnPrefixMailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMailId.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMailId.Name = "rbnPrefixMailId"
        Me.rbnPrefixMailId.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixMailId.TabIndex = 27
        Me.rbnPrefixMailId.Text = "Prefix"
        Me.rbnPrefixMailId.UseVisualStyleBackColor = True
        '
        'txtMailId
        '
        Me.txtMailId.Location = New System.Drawing.Point(14, 114)
        Me.txtMailId.Name = "txtMailId"
        Me.txtMailId.Size = New System.Drawing.Size(310, 20)
        Me.txtMailId.TabIndex = 8
        '
        'lblMailID
        '
        Me.lblMailID.AutoSize = True
        Me.lblMailID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailID.Location = New System.Drawing.Point(14, 98)
        Me.lblMailID.Name = "lblMailID"
        Me.lblMailID.Size = New System.Drawing.Size(51, 16)
        Me.lblMailID.TabIndex = 7
        Me.lblMailID.Text = "Mail Id"
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.txtLedgerName)
        Me.pnlToolBar.Controls.Add(Me.cmbOrderBy)
        Me.pnlToolBar.Controls.Add(Me.Panel5)
        Me.pnlToolBar.Controls.Add(Me.txtMailId)
        Me.pnlToolBar.Controls.Add(Me.txtMobile)
        Me.pnlToolBar.Controls.Add(Me.lblMailID)
        Me.pnlToolBar.Controls.Add(Me.Panel3)
        Me.pnlToolBar.Controls.Add(Me.lblMobile)
        Me.pnlToolBar.Controls.Add(Me.Panel2)
        Me.pnlToolBar.Controls.Add(Me.lblLedgerName)
        Me.pnlToolBar.Controls.Add(Me.Panel1)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.rbnInfixAddress)
        Me.pnlToolBar.Controls.Add(Me.rbnSuffixAddress)
        Me.pnlToolBar.Controls.Add(Me.rbnPrefixAddress)
        Me.pnlToolBar.Controls.Add(Me.txtAddress)
        Me.pnlToolBar.Controls.Add(Me.lblAddress)
        Me.pnlToolBar.Location = New System.Drawing.Point(5, 56)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(835, 154)
        Me.pnlToolBar.TabIndex = 3
        '
        'cmbOrderBy
        '
        Me.cmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbOrderBy.FormattingEnabled = True
        Me.cmbOrderBy.Items.AddRange(New Object() {"Ledger Name", "Tin No", "CST", "Credit Limits"})
        Me.cmbOrderBy.Location = New System.Drawing.Point(342, 27)
        Me.cmbOrderBy.Name = "cmbOrderBy"
        Me.cmbOrderBy.Size = New System.Drawing.Size(317, 20)
        Me.cmbOrderBy.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rbnDescending)
        Me.Panel5.Controls.Add(Me.rbnAscending)
        Me.Panel5.Controls.Add(Me.lblOrderBy)
        Me.Panel5.Location = New System.Drawing.Point(340, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(319, 20)
        Me.Panel5.TabIndex = 29
        '
        'rbnDescending
        '
        Me.rbnDescending.AutoSize = True
        Me.rbnDescending.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnDescending.Location = New System.Drawing.Point(217, 0)
        Me.rbnDescending.Name = "rbnDescending"
        Me.rbnDescending.Size = New System.Drawing.Size(100, 20)
        Me.rbnDescending.TabIndex = 13
        Me.rbnDescending.Text = "Descending"
        Me.rbnDescending.UseVisualStyleBackColor = True
        '
        'rbnAscending
        '
        Me.rbnAscending.AutoSize = True
        Me.rbnAscending.Checked = True
        Me.rbnAscending.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnAscending.Location = New System.Drawing.Point(113, 0)
        Me.rbnAscending.Name = "rbnAscending"
        Me.rbnAscending.Size = New System.Drawing.Size(92, 20)
        Me.rbnAscending.TabIndex = 12
        Me.rbnAscending.TabStop = True
        Me.rbnAscending.Text = "Ascending"
        Me.rbnAscending.UseVisualStyleBackColor = True
        '
        'lblOrderBy
        '
        Me.lblOrderBy.AutoSize = True
        Me.lblOrderBy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderBy.Location = New System.Drawing.Point(3, 3)
        Me.lblOrderBy.Name = "lblOrderBy"
        Me.lblOrderBy.Size = New System.Drawing.Size(64, 16)
        Me.lblOrderBy.TabIndex = 0
        Me.lblOrderBy.Text = "Order By"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(14, 53)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(51, 16)
        Me.lblMobile.TabIndex = 3
        Me.lblMobile.Text = "Mobile"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbnInfixMobile)
        Me.Panel2.Controls.Add(Me.rbnSuffixMobile)
        Me.Panel2.Controls.Add(Me.rbnPrefixMobile)
        Me.Panel2.Location = New System.Drawing.Point(142, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 20)
        Me.Panel2.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnInfixCustomer)
        Me.Panel1.Controls.Add(Me.rbnSuffixCustomer)
        Me.Panel1.Controls.Add(Me.rbnPrefixCustomer)
        Me.Panel1.Location = New System.Drawing.Point(142, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 20)
        Me.Panel1.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(683, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Ledger Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLedgersReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.pnlToolBar)
        Me.KeyPreview = True
        Me.Name = "frmLedgersReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledgers Report"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbnInfixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents lblLedgerName As System.Windows.Forms.Label
    Friend WithEvents rbnPrefixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtLedgerName As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMailId As System.Windows.Forms.RadioButton
    Friend WithEvents txtMailId As System.Windows.Forms.TextBox
    Friend WithEvents lblMailID As System.Windows.Forms.Label
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rbnDescending As System.Windows.Forms.RadioButton
    Friend WithEvents rbnAscending As System.Windows.Forms.RadioButton
    Friend WithEvents lblOrderBy As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
End Class
