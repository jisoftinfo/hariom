<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TaxDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COUNTGROUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MillWorkingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MILLCONFIRMATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DebitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DebitNoteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PartyDebitNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PartyPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MillPaymentDebitNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PartyPaymentDebitNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.E1FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DRAFTSMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewCFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EMailSentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PartywiseEMailSendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MillwiseEMailSendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ScheduledEMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PendingBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PartyPendingDebitNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LedgerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CashLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MillLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.AutoNumberGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnScreenKeybaordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TamilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextTranslationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowDoIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.InventoryReportToolStripMenuItem, Me.LedgerReportToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitsToolStripMenuItem, Me.TaxDetailsToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.CompanyInfoToolStripMenuItem, Me.COUNTGROUPToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MasterToolStripMenuItem.Text = "&MASTER"
        '
        'UnitsToolStripMenuItem
        '
        Me.UnitsToolStripMenuItem.Name = "UnitsToolStripMenuItem"
        Me.UnitsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.UnitsToolStripMenuItem.Text = "&Units"
        Me.UnitsToolStripMenuItem.Visible = False
        '
        'TaxDetailsToolStripMenuItem
        '
        Me.TaxDetailsToolStripMenuItem.Name = "TaxDetailsToolStripMenuItem"
        Me.TaxDetailsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TaxDetailsToolStripMenuItem.Text = "Tax Details"
        Me.TaxDetailsToolStripMenuItem.Visible = False
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CustomersToolStripMenuItem.Text = "&PARTY"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SuppliersToolStripMenuItem.Text = "&MILL"
        '
        'CompanyInfoToolStripMenuItem
        '
        Me.CompanyInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CompanyInfoToolStripMenuItem.Name = "CompanyInfoToolStripMenuItem"
        Me.CompanyInfoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CompanyInfoToolStripMenuItem.Text = "&COMPANY INFO"
        '
        'COUNTGROUPToolStripMenuItem
        '
        Me.COUNTGROUPToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.COUNTGROUPToolStripMenuItem.Name = "COUNTGROUPToolStripMenuItem"
        Me.COUNTGROUPToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.COUNTGROUPToolStripMenuItem.Text = "COUNT GROUP"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "EXIT"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MillWorkingToolStripMenuItem, Me.MILLCONFIRMATIONToolStripMenuItem, Me.EFormToolStripMenuItem, Me.DebitToolStripMenuItem, Me.CreditToolStripMenuItem, Me.BillToolStripMenuItem, Me.DebitNoteToolStripMenuItem1, Me.PartyDebitNoteToolStripMenuItem, Me.PartyPaymentToolStripMenuItem, Me.MillPaymentDebitNoteToolStripMenuItem, Me.PartyPaymentDebitNoteToolStripMenuItem, Me.CFormToolStripMenuItem, Me.E1FormToolStripMenuItem, Me.DRAFTSMSToolStripMenuItem, Me.SMSToolStripMenuItem, Me.NewCFormToolStripMenuItem, Me.EMailToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.TransactionsToolStripMenuItem.Text = "&TRANSACTIONS"
        '
        'MillWorkingToolStripMenuItem
        '
        Me.MillWorkingToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MillWorkingToolStripMenuItem.Name = "MillWorkingToolStripMenuItem"
        Me.MillWorkingToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MillWorkingToolStripMenuItem.Text = "MONTHLY WORKING"
        '
        'MILLCONFIRMATIONToolStripMenuItem
        '
        Me.MILLCONFIRMATIONToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MILLCONFIRMATIONToolStripMenuItem.Name = "MILLCONFIRMATIONToolStripMenuItem"
        Me.MILLCONFIRMATIONToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MILLCONFIRMATIONToolStripMenuItem.Text = "MILL CONFIRMATION"
        '
        'EFormToolStripMenuItem
        '
        Me.EFormToolStripMenuItem.Name = "EFormToolStripMenuItem"
        Me.EFormToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EFormToolStripMenuItem.Text = "C Form & E1 Form"
        Me.EFormToolStripMenuItem.Visible = False
        '
        'DebitToolStripMenuItem
        '
        Me.DebitToolStripMenuItem.Name = "DebitToolStripMenuItem"
        Me.DebitToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DebitToolStripMenuItem.Text = "Payment"
        Me.DebitToolStripMenuItem.Visible = False
        '
        'CreditToolStripMenuItem
        '
        Me.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem"
        Me.CreditToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CreditToolStripMenuItem.Text = "Receipt"
        Me.CreditToolStripMenuItem.Visible = False
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.BillToolStripMenuItem.Text = "Receipt Bill"
        Me.BillToolStripMenuItem.Visible = False
        '
        'DebitNoteToolStripMenuItem1
        '
        Me.DebitNoteToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue
        Me.DebitNoteToolStripMenuItem1.Name = "DebitNoteToolStripMenuItem1"
        Me.DebitNoteToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.DebitNoteToolStripMenuItem1.Text = "MILL DEBIT NOTE"
        '
        'PartyDebitNoteToolStripMenuItem
        '
        Me.PartyDebitNoteToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PartyDebitNoteToolStripMenuItem.Name = "PartyDebitNoteToolStripMenuItem"
        Me.PartyDebitNoteToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PartyDebitNoteToolStripMenuItem.Text = "PARTY DEBIT NOTE"
        '
        'PartyPaymentToolStripMenuItem
        '
        Me.PartyPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PartyPaymentToolStripMenuItem.Name = "PartyPaymentToolStripMenuItem"
        Me.PartyPaymentToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PartyPaymentToolStripMenuItem.Text = "PARTY OUTSTANDING"
        '
        'MillPaymentDebitNoteToolStripMenuItem
        '
        Me.MillPaymentDebitNoteToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MillPaymentDebitNoteToolStripMenuItem.Name = "MillPaymentDebitNoteToolStripMenuItem"
        Me.MillPaymentDebitNoteToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MillPaymentDebitNoteToolStripMenuItem.Text = "MILL PAYMENT"
        '
        'PartyPaymentDebitNoteToolStripMenuItem
        '
        Me.PartyPaymentDebitNoteToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PartyPaymentDebitNoteToolStripMenuItem.Name = "PartyPaymentDebitNoteToolStripMenuItem"
        Me.PartyPaymentDebitNoteToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PartyPaymentDebitNoteToolStripMenuItem.Text = "PARTY PAYMENT"
        '
        'CFormToolStripMenuItem
        '
        Me.CFormToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CFormToolStripMenuItem.Name = "CFormToolStripMenuItem"
        Me.CFormToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CFormToolStripMenuItem.Text = "C FORM"
        '
        'E1FormToolStripMenuItem
        '
        Me.E1FormToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.E1FormToolStripMenuItem.Name = "E1FormToolStripMenuItem"
        Me.E1FormToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.E1FormToolStripMenuItem.Text = "E1 FORM"
        '
        'DRAFTSMSToolStripMenuItem
        '
        Me.DRAFTSMSToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.DRAFTSMSToolStripMenuItem.Name = "DRAFTSMSToolStripMenuItem"
        Me.DRAFTSMSToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DRAFTSMSToolStripMenuItem.Text = "DRAFT SMS"
        Me.DRAFTSMSToolStripMenuItem.Visible = False
        '
        'SMSToolStripMenuItem
        '
        Me.SMSToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        Me.SMSToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SMSToolStripMenuItem.Text = "SMS"
        Me.SMSToolStripMenuItem.Visible = False
        '
        'NewCFormToolStripMenuItem
        '
        Me.NewCFormToolStripMenuItem.Name = "NewCFormToolStripMenuItem"
        Me.NewCFormToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NewCFormToolStripMenuItem.Text = "New C Form"
        Me.NewCFormToolStripMenuItem.Visible = False
        '
        'EMailToolStripMenuItem
        '
        Me.EMailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSentToolStripMenuItem, Me.PartywiseEMailSendingToolStripMenuItem, Me.MillwiseEMailSendingToolStripMenuItem, Me.ScheduledEMailToolStripMenuItem, Me.AutoEmailToolStripMenuItem})
        Me.EMailToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.EMailToolStripMenuItem.Name = "EMailToolStripMenuItem"
        Me.EMailToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EMailToolStripMenuItem.Text = "EMAIL"
        Me.EMailToolStripMenuItem.Visible = False
        '
        'EMailSentToolStripMenuItem
        '
        Me.EMailSentToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.EMailSentToolStripMenuItem.Name = "EMailSentToolStripMenuItem"
        Me.EMailSentToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.EMailSentToolStripMenuItem.Text = "EMAIL SENT"
        '
        'PartywiseEMailSendingToolStripMenuItem
        '
        Me.PartywiseEMailSendingToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PartywiseEMailSendingToolStripMenuItem.Name = "PartywiseEMailSendingToolStripMenuItem"
        Me.PartywiseEMailSendingToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PartywiseEMailSendingToolStripMenuItem.Text = "PARTYWISE EMAIL SENDING"
        '
        'MillwiseEMailSendingToolStripMenuItem
        '
        Me.MillwiseEMailSendingToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MillwiseEMailSendingToolStripMenuItem.Name = "MillwiseEMailSendingToolStripMenuItem"
        Me.MillwiseEMailSendingToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.MillwiseEMailSendingToolStripMenuItem.Text = "MILLWISE EMAIL SENDING"
        '
        'ScheduledEMailToolStripMenuItem
        '
        Me.ScheduledEMailToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ScheduledEMailToolStripMenuItem.Name = "ScheduledEMailToolStripMenuItem"
        Me.ScheduledEMailToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ScheduledEMailToolStripMenuItem.Text = "SCHEDULED EMAIL"
        '
        'AutoEmailToolStripMenuItem
        '
        Me.AutoEmailToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AutoEmailToolStripMenuItem.Name = "AutoEmailToolStripMenuItem"
        Me.AutoEmailToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.AutoEmailToolStripMenuItem.Text = "AUTO EMAIL"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendingBillToolStripMenuItem, Me.PartyPendingDebitNoteToolStripMenuItem})
        Me.InventoryReportToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.InventoryReportToolStripMenuItem.Text = "&INVENTORY REPORT"
        '
        'PendingBillToolStripMenuItem
        '
        Me.PendingBillToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PendingBillToolStripMenuItem.Name = "PendingBillToolStripMenuItem"
        Me.PendingBillToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PendingBillToolStripMenuItem.Text = "MILL PENDING DEBIT NOTE"
        '
        'PartyPendingDebitNoteToolStripMenuItem
        '
        Me.PartyPendingDebitNoteToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PartyPendingDebitNoteToolStripMenuItem.Name = "PartyPendingDebitNoteToolStripMenuItem"
        Me.PartyPendingDebitNoteToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PartyPendingDebitNoteToolStripMenuItem.Text = "PARTY PENDING REPORT"
        '
        'LedgerReportToolStripMenuItem
        '
        Me.LedgerReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashLedgerToolStripMenuItem, Me.MillLedgerToolStripMenuItem})
        Me.LedgerReportToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.LedgerReportToolStripMenuItem.Name = "LedgerReportToolStripMenuItem"
        Me.LedgerReportToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LedgerReportToolStripMenuItem.Text = "LEDGER REPORT"
        '
        'CashLedgerToolStripMenuItem
        '
        Me.CashLedgerToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CashLedgerToolStripMenuItem.Name = "CashLedgerToolStripMenuItem"
        Me.CashLedgerToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CashLedgerToolStripMenuItem.Text = "CASH LEDGER"
        '
        'MillLedgerToolStripMenuItem
        '
        Me.MillLedgerToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MillLedgerToolStripMenuItem.Name = "MillLedgerToolStripMenuItem"
        Me.MillLedgerToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.MillLedgerToolStripMenuItem.Text = "MILL LEDGER"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorPreferencesToolStripMenuItem, Me.CompanyToolStripMenuItem, Me.UserAccountToolStripMenuItem, Me.ToolStripMenuItem6, Me.AutoNumberGenerationToolStripMenuItem, Me.OnScreenKeybaordToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.TextTranslationToolStripMenuItem, Me.ToolStripMenuItem1, Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ToolsToolStripMenuItem.Text = "TO&OLS"
        '
        'ColorPreferencesToolStripMenuItem
        '
        Me.ColorPreferencesToolStripMenuItem.Name = "ColorPreferencesToolStripMenuItem"
        Me.ColorPreferencesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ColorPreferencesToolStripMenuItem.Text = "Color Preferences"
        Me.ColorPreferencesToolStripMenuItem.Visible = False
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CompanyToolStripMenuItem.Text = "COMPANY"
        '
        'UserAccountToolStripMenuItem
        '
        Me.UserAccountToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem"
        Me.UserAccountToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.UserAccountToolStripMenuItem.Text = "USER ACCOUNT"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(196, 6)
        '
        'AutoNumberGenerationToolStripMenuItem
        '
        Me.AutoNumberGenerationToolStripMenuItem.Name = "AutoNumberGenerationToolStripMenuItem"
        Me.AutoNumberGenerationToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AutoNumberGenerationToolStripMenuItem.Text = "Auto ID Generation"
        Me.AutoNumberGenerationToolStripMenuItem.Visible = False
        '
        'OnScreenKeybaordToolStripMenuItem
        '
        Me.OnScreenKeybaordToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.OnScreenKeybaordToolStripMenuItem.Name = "OnScreenKeybaordToolStripMenuItem"
        Me.OnScreenKeybaordToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.OnScreenKeybaordToolStripMenuItem.Text = "ON SCREEN KEYBOARD"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CalculatorToolStripMenuItem.Text = "CALCULATOR"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.TamilToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LanguageToolStripMenuItem.Text = "Language"
        Me.LanguageToolStripMenuItem.Visible = False
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Checked = True
        Me.EnglishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'TamilToolStripMenuItem
        '
        Me.TamilToolStripMenuItem.Name = "TamilToolStripMenuItem"
        Me.TamilToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.TamilToolStripMenuItem.Text = "Tamil"
        '
        'TextTranslationToolStripMenuItem
        '
        Me.TextTranslationToolStripMenuItem.Name = "TextTranslationToolStripMenuItem"
        Me.TextTranslationToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.TextTranslationToolStripMenuItem.Text = "Text Translation"
        Me.TextTranslationToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(196, 6)
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.BackupToolStripMenuItem.Text = "BACKUP"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        Me.RestoreToolStripMenuItem.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowDoIToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.Visible = False
        '
        'HowDoIToolStripMenuItem
        '
        Me.HowDoIToolStripMenuItem.Name = "HowDoIToolStripMenuItem"
        Me.HowDoIToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.HowDoIToolStripMenuItem.Text = "How Do I"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Backup File|*.jbk"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Backup File|*.jbk"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 612)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JISPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LedgerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorPreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoNumberGenerationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnScreenKeybaordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TamilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextTranslationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowDoIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TaxDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MillWorkingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitNoteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MillLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyDebitNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MillPaymentDebitNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyPaymentDebitNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendingBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PartyPendingDebitNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents E1FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailSentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartywiseEMailSendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MillwiseEMailSendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduledEMailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents AutoEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MILLCONFIRMATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DRAFTSMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COUNTGROUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
