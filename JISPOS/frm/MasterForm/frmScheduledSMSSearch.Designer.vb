﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduledSMSSearch
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
        Me.lblFormalName = New System.Windows.Forms.Label
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.pnlone = New System.Windows.Forms.Panel
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.txtFormalName = New System.Windows.Forms.TextBox
        Me.pnltwo = New System.Windows.Forms.Panel
        Me.rbnInfixMobile = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMobile = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMobile = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblUnitSymbolName = New System.Windows.Forms.Label
        Me.dgvUOM = New System.Windows.Forms.DataGridView
        Me.lblHeading = New System.Windows.Forms.Label
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlToolBar.SuspendLayout()
        Me.pnlone.SuspendLayout()
        Me.pnltwo.SuspendLayout()
        CType(Me.dgvUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormalName
        '
        Me.lblFormalName.AutoSize = True
        Me.lblFormalName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormalName.Location = New System.Drawing.Point(14, 60)
        Me.lblFormalName.Name = "lblFormalName"
        Me.lblFormalName.Size = New System.Drawing.Size(94, 16)
        Me.lblFormalName.TabIndex = 20
        Me.lblFormalName.Text = "Formal Name"
        Me.lblFormalName.Visible = False
        '
        'rbnInfixCustomer
        '
        Me.rbnInfixCustomer.AutoSize = True
        Me.rbnInfixCustomer.Checked = True
        Me.rbnInfixCustomer.Location = New System.Drawing.Point(72, 0)
        Me.rbnInfixCustomer.Name = "rbnInfixCustomer"
        Me.rbnInfixCustomer.Size = New System.Drawing.Size(44, 17)
        Me.rbnInfixCustomer.TabIndex = 13
        Me.rbnInfixCustomer.TabStop = True
        Me.rbnInfixCustomer.Text = "Infix"
        Me.rbnInfixCustomer.UseVisualStyleBackColor = True
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.pnlone)
        Me.pnlToolBar.Controls.Add(Me.txtMobileNo)
        Me.pnlToolBar.Controls.Add(Me.lblFormalName)
        Me.pnlToolBar.Controls.Add(Me.txtFormalName)
        Me.pnlToolBar.Controls.Add(Me.pnltwo)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.lblUnitSymbolName)
        Me.pnlToolBar.Location = New System.Drawing.Point(8, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(484, 107)
        Me.pnlToolBar.TabIndex = 0
        '
        'pnlone
        '
        Me.pnlone.Controls.Add(Me.rbnInfixCustomer)
        Me.pnlone.Controls.Add(Me.rbnSuffixCustomer)
        Me.pnlone.Controls.Add(Me.rbnPrefixCustomer)
        Me.pnlone.Location = New System.Drawing.Point(140, 9)
        Me.pnlone.Name = "pnlone"
        Me.pnlone.Size = New System.Drawing.Size(182, 20)
        Me.pnlone.TabIndex = 25
        '
        'rbnSuffixCustomer
        '
        Me.rbnSuffixCustomer.AutoSize = True
        Me.rbnSuffixCustomer.Location = New System.Drawing.Point(124, 0)
        Me.rbnSuffixCustomer.Name = "rbnSuffixCustomer"
        Me.rbnSuffixCustomer.Size = New System.Drawing.Size(51, 17)
        Me.rbnSuffixCustomer.TabIndex = 14
        Me.rbnSuffixCustomer.Text = "Suffix"
        Me.rbnSuffixCustomer.UseVisualStyleBackColor = True
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
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(12, 29)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(310, 20)
        Me.txtMobileNo.TabIndex = 11
        '
        'txtFormalName
        '
        Me.txtFormalName.Location = New System.Drawing.Point(14, 77)
        Me.txtFormalName.Name = "txtFormalName"
        Me.txtFormalName.Size = New System.Drawing.Size(310, 20)
        Me.txtFormalName.TabIndex = 21
        Me.txtFormalName.Visible = False
        '
        'pnltwo
        '
        Me.pnltwo.Controls.Add(Me.rbnInfixMobile)
        Me.pnltwo.Controls.Add(Me.rbnSuffixMobile)
        Me.pnltwo.Controls.Add(Me.rbnPrefixMobile)
        Me.pnltwo.Location = New System.Drawing.Point(140, 57)
        Me.pnltwo.Name = "pnltwo"
        Me.pnltwo.Size = New System.Drawing.Size(182, 20)
        Me.pnltwo.TabIndex = 26
        Me.pnltwo.Visible = False
        '
        'rbnInfixMobile
        '
        Me.rbnInfixMobile.AutoSize = True
        Me.rbnInfixMobile.Checked = True
        Me.rbnInfixMobile.Location = New System.Drawing.Point(67, 0)
        Me.rbnInfixMobile.Name = "rbnInfixMobile"
        Me.rbnInfixMobile.Size = New System.Drawing.Size(44, 17)
        Me.rbnInfixMobile.TabIndex = 23
        Me.rbnInfixMobile.TabStop = True
        Me.rbnInfixMobile.Text = "Infix"
        Me.rbnInfixMobile.UseVisualStyleBackColor = True
        '
        'rbnSuffixMobile
        '
        Me.rbnSuffixMobile.AutoSize = True
        Me.rbnSuffixMobile.Location = New System.Drawing.Point(127, 0)
        Me.rbnSuffixMobile.Name = "rbnSuffixMobile"
        Me.rbnSuffixMobile.Size = New System.Drawing.Size(51, 17)
        Me.rbnSuffixMobile.TabIndex = 24
        Me.rbnSuffixMobile.Text = "Suffix"
        Me.rbnSuffixMobile.UseVisualStyleBackColor = True
        '
        'rbnPrefixMobile
        '
        Me.rbnPrefixMobile.AutoSize = True
        Me.rbnPrefixMobile.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMobile.Name = "rbnPrefixMobile"
        Me.rbnPrefixMobile.Size = New System.Drawing.Size(51, 17)
        Me.rbnPrefixMobile.TabIndex = 22
        Me.rbnPrefixMobile.Text = "Prefix"
        Me.rbnPrefixMobile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.JISPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(405, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 21
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
        Me.btnSearch.Image = Global.JISPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(333, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblUnitSymbolName
        '
        Me.lblUnitSymbolName.AutoSize = True
        Me.lblUnitSymbolName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitSymbolName.Location = New System.Drawing.Point(12, 13)
        Me.lblUnitSymbolName.Name = "lblUnitSymbolName"
        Me.lblUnitSymbolName.Size = New System.Drawing.Size(72, 16)
        Me.lblUnitSymbolName.TabIndex = 10
        Me.lblUnitSymbolName.Text = "Mobile No"
        '
        'dgvUOM
        '
        Me.dgvUOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUOM.Location = New System.Drawing.Point(22, 17)
        Me.dgvUOM.Name = "dgvUOM"
        Me.dgvUOM.Size = New System.Drawing.Size(1338, 578)
        Me.dgvUOM.TabIndex = 0
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1393, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Scheduled SMS Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.dgvUOM)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 166)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1393, 660)
        Me.pnlContent.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1393, 836)
        Me.pnlMain.TabIndex = 15
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 826)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1393, 10)
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
        Me.pnlHeader.Size = New System.Drawing.Size(1393, 166)
        Me.pnlHeader.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmScheduledSMSSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1393, 836)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmScheduledSMSSearch"
        Me.Text = "Scheduled SMS Search"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlone.ResumeLayout(False)
        Me.pnlone.PerformLayout()
        Me.pnltwo.ResumeLayout(False)
        Me.pnltwo.PerformLayout()
        CType(Me.dgvUOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFormalName As System.Windows.Forms.Label
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents pnlone As System.Windows.Forms.Panel
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFormalName As System.Windows.Forms.TextBox
    Friend WithEvents pnltwo As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblUnitSymbolName As System.Windows.Forms.Label
    Friend WithEvents dgvUOM As System.Windows.Forms.DataGridView
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
