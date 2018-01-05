<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapture
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
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.picImage = New System.Windows.Forms.PictureBox
        Me.cmbGodownName = New System.Windows.Forms.ComboBox
        Me.txtSignature = New System.Windows.Forms.TextBox
        Me.lblBarCode = New System.Windows.Forms.Label
        Me.lblGodownName = New System.Windows.Forms.Label
        Me.RecNoLbl = New System.Windows.Forms.Label
        Me.lblSig = New System.Windows.Forms.Label
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.lblHeading = New System.Windows.Forms.Label
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.pnlForm.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.picImage)
        Me.pnlForm.Controls.Add(Me.cmbGodownName)
        Me.pnlForm.Controls.Add(Me.txtSignature)
        Me.pnlForm.Controls.Add(Me.lblBarCode)
        Me.pnlForm.Controls.Add(Me.lblGodownName)
        Me.pnlForm.Controls.Add(Me.RecNoLbl)
        Me.pnlForm.Controls.Add(Me.lblSig)
        Me.pnlForm.Location = New System.Drawing.Point(67, 38)
        Me.pnlForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(277, 265)
        Me.pnlForm.TabIndex = 0
        '
        'picImage
        '
        Me.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picImage.Location = New System.Drawing.Point(16, 18)
        Me.picImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(241, 222)
        Me.picImage.TabIndex = 68
        Me.picImage.TabStop = False
        '
        'cmbGodownName
        '
        Me.cmbGodownName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbGodownName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGodownName.FormattingEnabled = True
        Me.cmbGodownName.Location = New System.Drawing.Point(843, 327)
        Me.cmbGodownName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbGodownName.Name = "cmbGodownName"
        Me.cmbGodownName.Size = New System.Drawing.Size(265, 26)
        Me.cmbGodownName.TabIndex = 8
        Me.cmbGodownName.Visible = False
        '
        'txtSignature
        '
        Me.txtSignature.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSignature.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignature.Location = New System.Drawing.Point(812, 425)
        Me.txtSignature.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSignature.MaxLength = 10
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Size = New System.Drawing.Size(265, 26)
        Me.txtSignature.TabIndex = 12
        Me.txtSignature.Visible = False
        '
        'lblBarCode
        '
        Me.lblBarCode.AutoSize = True
        Me.lblBarCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarCode.Location = New System.Drawing.Point(785, 393)
        Me.lblBarCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(78, 19)
        Me.lblBarCode.TabIndex = 62
        Me.lblBarCode.Text = "BarCode"
        Me.lblBarCode.Visible = False
        '
        'lblGodownName
        '
        Me.lblGodownName.AutoSize = True
        Me.lblGodownName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGodownName.Location = New System.Drawing.Point(701, 330)
        Me.lblGodownName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGodownName.Name = "lblGodownName"
        Me.lblGodownName.Size = New System.Drawing.Size(124, 19)
        Me.lblGodownName.TabIndex = 54
        Me.lblGodownName.Text = "Godo&wn Name"
        Me.lblGodownName.Visible = False
        '
        'RecNoLbl
        '
        Me.RecNoLbl.AutoSize = True
        Me.RecNoLbl.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecNoLbl.ForeColor = System.Drawing.Color.Red
        Me.RecNoLbl.Location = New System.Drawing.Point(645, 388)
        Me.RecNoLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RecNoLbl.Name = "RecNoLbl"
        Me.RecNoLbl.Size = New System.Drawing.Size(0, 18)
        Me.RecNoLbl.TabIndex = 61
        Me.RecNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RecNoLbl.Visible = False
        '
        'lblSig
        '
        Me.lblSig.AutoSize = True
        Me.lblSig.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSig.Location = New System.Drawing.Point(711, 427)
        Me.lblSig.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSig.Name = "lblSig"
        Me.lblSig.Size = New System.Drawing.Size(85, 19)
        Me.lblSig.TabIndex = 40
        Me.lblSig.Text = "Signature"
        Me.lblSig.Visible = False
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Location = New System.Drawing.Point(83, 55)
        Me.pnlToolBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(216, 69)
        Me.pnlToolBar.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.JISPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(17, 5)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 60)
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
        Me.btnExit.Location = New System.Drawing.Point(116, 5)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 60)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(421, 132)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(421, 52)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Capture"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 458)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(421, 12)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(421, 470)
        Me.pnlMain.TabIndex = 7
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 132)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(421, 326)
        Me.pnlContent.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 470)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCapture"
        Me.Text = "Capture"
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents cmbGodownName As System.Windows.Forms.ComboBox
    Friend WithEvents txtSignature As System.Windows.Forms.TextBox
    Friend WithEvents lblBarCode As System.Windows.Forms.Label
    Friend WithEvents lblGodownName As System.Windows.Forms.Label
    Friend WithEvents RecNoLbl As System.Windows.Forms.Label
    Friend WithEvents lblSig As System.Windows.Forms.Label
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
