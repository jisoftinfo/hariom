Public Class DBTBOBJ


    'Common Obj
    Public AutoGeneration As JISTable = JISDb.Table("AutoGeneration")
    Public CompanyDetails As JISTable = JISDb.Table("CompanyDetails")
    Public UserAccount As JISTable = JISDb.Table("UserAccount")
    Public ColorSchema As JISTable = JISDb.Table("ColorSchema")
    Public Softvalidation As JISTable = JISDb.Table("SoftValidation")
    Public TextTranslation As JISTable = JISDb.Table("TextTranslation")
    Public LedgerReport As JISTable = JISDbTransaction.Table("LedgerReport")
    Public ScheduledSMSStatus As JISTable = JISDbTransaction.Table("ScheduledSMSStatus")

    'Public Stock As JISTable = JISDbTransaction.Table("Stock")


    'Master Obj
    Public CountGroup As JISTable = JISDb.Table("CountGroup")
    Public Party As JISTable = JISDb.Table("Party")
    Public PartyContactInfo As JISTable = JISDb.Table("PartyContactInfo")
    Public Banks As JISTable = JISDb.Table("Banks")
    Public TaxMaster As JISTable = JISDb.Table("TaxMaster")
    Public Ledger As JISTable = JISDb.Table("Ledger")
    Public Products As JISTable = JISDb.Table("Products")
    Public UnitsOfMeasurement As JISTable = JISDb.Table("UnitsOfMeasurement")
    Public Mill As JISTable = JISDb.Table("Mill")
    Public CForm As JISTable = JISDb.Table("CForm")
    Public CFormMaster As JISTable = JISDb.Table("CFormMaster")
    Public EForm As JISTable = JISDbTransaction.Table("EForm")
    Public CFormDetails As JISTable = JISDbTransaction.Table("CFormDetails")
    Public CompanyInfo As JISTable = JISDb.Table("CompanyInfo")
    Public ScheduledSMS As JISTable = JISDb.Table("ScheduledSMS")
    Public ScheduledSMSMobile As JISTable = JISDb.Table("ScheduledSMSMobileNo")
    Public ScheduledSMSDate As JISTable = JISDb.Table("ScheduledSMSDate")
    Public SMSSending As JISTable = JISDb.Table("SMSSending")
    Public EMailSending As JISTable = JISDb.Table("EMailSending")

    Public ScheduledEMail As JISTable = JISDb.Table("ScheduledEMail")
    Public ScheduledEMailDate As JISTable = JISDb.Table("ScheduledEMailDate")
    Public ScheduledEMailId As JISTable = JISDb.Table("ScheduledEMailId")
    Public ScheduledEmailAttach As JISTable = JISDb.Table("ScheduledEmailAttach")

    Public AutoEMailPending As JISTable = JISDb.Table("AutoEMailPending")
    Public AutoEMailPendingDate As JISTable = JISDb.Table("AutoEMaiPendinglDate")
    Public AutoEMailPendingEMailId As JISTable = JISDb.Table("AutoEMailPendingEMailId")
    Public PartyAddress As JISTable = JISDb.Table("PartyAddress")

    'Transaction
    Public MillConfrimation As JISTable = JISDbTransaction.Table("MillConfrimation")
    Public DebitNote As JISTable = JISDbTransaction.Table("DebitNote")
    Public DebitNodeDetials As JISTable = JISDbTransaction.Table("DebitNodeDetials")
    Public MillDebitNoteReceipt As JISTable = JISDbTransaction.Table("MillDebitNoteReceipt")
    Public PartyDebitNoteReceipt As JISTable = JISDbTransaction.Table("PartyDebitNoteReceipt")
    Public DebitNoteParty As JISTable = JISDbTransaction.Table("DebitNoteParty")
    Public DebitNoteDetailsParty As JISTable = JISDbTransaction.Table("DebitNoteDetailsParty")
    Public StockGroups As JISTable = JISDbTransaction.Table("StockGroups")
    Public StockDetail As JISTable = JISDbTransaction.Table("StockDetail")
    Public StockInwards As JISTable = JISDbTransaction.Table("StockInwards")
    Public StockOutwards As JISTable = JISDbTransaction.Table("StockOutwards")
    Public Payment As JISTable = JISDbTransaction.Table("Payment")
    Public MillWorking As JISTable = JISDbTransaction.Table("MillWorking")
    Public SMSDraft As JISTable = JISDbTransaction.Table("SMSDraft")
    Public MillWorkingDetails As JISTable = JISDbTransaction.Table("MillWorkingDetails")
    Public SubMillWorking As JISTable = JISDbTransaction.Table("SubMillWorking")
    Public MonthlyWorking As JISTable = JISDbTransaction.Table("MonthlyWorking")
    Public MonthlyWorkingDetails As JISTable = JISDbTransaction.Table("MonthlyWorkingDetails")
    Public Receipt As JISTable = JISDbTransaction.Table("Receipt")
    Public PartyWorking As JISTable = JISDbTransaction.Table("PartyWorking")
    Public PartyWorkingDetails As JISTable = JISDbTransaction.Table("PartyWorkingDetails")
    Public SalesReturn As JISTable = JISDbTransaction.Table("SalesReturn")
    Public SalesReturnDetails As JISTable = JISDbTransaction.Table("SalesReturnDetails")
    Public SalesOrder As JISTable = JISDbTransaction.Table("SalesOrder")
    Public SODetails As JISTable = JISDbTransaction.Table("SODetails")
    Public ReceiptBill As JISTable = JISDbTransaction.Table("ReceiptBill")
    Public Stock As JISTable = JISDbTransaction.Table("Stock")
    Public SMSLog As JISTable = JISDbTransaction.Table("SMSLog")
    'Views
    Public ViewConfirm As JISTable = JISDbTransaction.View("ViewConfirm")
    Public ViewMillWorking As JISTable = JISDbTransaction.View("ViewMillWorking")
    Public ViewEForm As JISTable = JISDbTransaction.View("ViewEForm")
    Public ViewDebitNote As JISTable = JISDbTransaction.View("ViewDebitNote")
    Public ViewDebitNoteMill As JISTable = JISDbTransaction.View("ViewDebitNoteMill")
    Public ViewDebitNoteParty As JISTable = JISDbTransaction.View("ViewDebitNoteParty")
    Public ViewCFormMaster As JISTable = JISDbTransaction.View("ViewCFormMaster")

    Sub New()

    End Sub

    Public Function ExecuteQuery(ByVal Qry As String) As Object
        Return JISDb.ExecuteQuery(Qry)
    End Function
End Class

