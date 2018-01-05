<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEMail
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
        Me.lblHeading = New System.Windows.Forms.Label
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.lblAttachFiles = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lblSubject = New System.Windows.Forms.Label
        Me.lblToMail = New System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnBrowser = New System.Windows.Forms.Button
        Me.lstAttachedFiles = New System.Windows.Forms.ListBox
        Me.rtxtMessage = New System.Windows.Forms.RichTextBox
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.txtSendMail = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1084, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "E-Mail"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 607)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1084, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1084, 47)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 47)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1084, 560)
        Me.pnlContent.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.btnExit)
        Me.pnlForm.Controls.Add(Me.lblAttachFiles)
        Me.pnlForm.Controls.Add(Me.lblMessage)
        Me.pnlForm.Controls.Add(Me.lblToMail)
        Me.pnlForm.Controls.Add(Me.btnRemove)
        Me.pnlForm.Controls.Add(Me.btnBrowser)
        Me.pnlForm.Controls.Add(Me.lstAttachedFiles)
        Me.pnlForm.Controls.Add(Me.rtxtMessage)
        Me.pnlForm.Controls.Add(Me.txtSubject)
        Me.pnlForm.Controls.Add(Me.txtSendMail)
        Me.pnlForm.Controls.Add(Me.btnSend)
        Me.pnlForm.Controls.Add(Me.lblSubject)
        Me.pnlForm.Location = New System.Drawing.Point(33, 6)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1046, 548)
        Me.pnlForm.TabIndex = 0
        '
        'lblAttachFiles
        '
        Me.lblAttachFiles.AutoSize = True
        Me.lblAttachFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttachFiles.Location = New System.Drawing.Point(679, 19)
        Me.lblAttachFiles.Name = "lblAttachFiles"
        Me.lblAttachFiles.Size = New System.Drawing.Size(74, 13)
        Me.lblAttachFiles.TabIndex = 14
        Me.lblAttachFiles.Text = "Attach Files"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(26, 96)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(57, 13)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "Message"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(26, 65)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(50, 13)
        Me.lblSubject.TabIndex = 6
        Me.lblSubject.Text = "Subject"
        '
        'lblToMail
        '
        Me.lblToMail.AutoSize = True
        Me.lblToMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToMail.Location = New System.Drawing.Point(26, 38)
        Me.lblToMail.Name = "lblToMail"
        Me.lblToMail.Size = New System.Drawing.Size(22, 13)
        Me.lblToMail.TabIndex = 4
        Me.lblToMail.Text = "To"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(881, 14)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnBrowser
        '
        Me.btnBrowser.Location = New System.Drawing.Point(798, 14)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowser.TabIndex = 9
        Me.btnBrowser.Text = "Browse"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'lstAttachedFiles
        '
        Me.lstAttachedFiles.FormattingEnabled = True
        Me.lstAttachedFiles.Location = New System.Drawing.Point(682, 35)
        Me.lstAttachedFiles.Name = "lstAttachedFiles"
        Me.lstAttachedFiles.Size = New System.Drawing.Size(274, 69)
        Me.lstAttachedFiles.TabIndex = 8
        '
        'rtxtMessage
        '
        Me.rtxtMessage.Location = New System.Drawing.Point(29, 112)
        Me.rtxtMessage.Name = "rtxtMessage"
        Me.rtxtMessage.Size = New System.Drawing.Size(927, 420)
        Me.rtxtMessage.TabIndex = 11
        Me.rtxtMessage.Text = ""
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(78, 61)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(598, 20)
        Me.txtSubject.TabIndex = 7
        '
        'txtSendMail
        '
        Me.txtSendMail.Location = New System.Drawing.Point(78, 34)
        Me.txtSendMail.Name = "txtSendMail"
        Me.txtSendMail.Size = New System.Drawing.Size(598, 20)
        Me.txtSendMail.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(962, 480)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1084, 617)
        Me.pnlMain.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(962, 509)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 617)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmEMail"
        Me.Text = "EMail"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblToMail As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnBrowser As System.Windows.Forms.Button
    Friend WithEvents lstAttachedFiles As System.Windows.Forms.ListBox
    Friend WithEvents rtxtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtSendMail As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblAttachFiles As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
