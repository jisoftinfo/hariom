Imports System.IO
Imports System.IO.Packaging

Public Class frmMaster

    Private Sub frmMaster_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmLogin.Show()
    End Sub
    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Type <> "Admin" Then
            MenuStrip1.Visible = False
        Else
            MenuStrip1.Visible = True
        End If

        Me.Text = CompName

        Dim ComCode As String = db.CompanyDetails.CodeByUserCode(CompName)
        If File.Exists(Application.StartupPath + "\Images\CompanyBG\" + ComCode + ".jpg") Then
            Dim buffer As Byte() = File.ReadAllBytes(Application.StartupPath + "\Images\CompanyBG\" + ComCode + ".jpg")
            Dim stream As MemoryStream = New MemoryStream(buffer)

            Dim bm As Bitmap = CType(Bitmap.FromStream(stream), Bitmap)

            Me.BackgroundImage = bm.Clone
            stream.Dispose()
            bm.Dispose()
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Me.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersToolStripMenuItem.Click
        FormShow(frmCustomers)
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        FormShow(frmSuppliers)
    End Sub
   
    Private Sub UnitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitsToolStripMenuItem.Click
        FormShow(frmUnits)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CashLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashLedgerToolStripMenuItem.Click
        frmLDR_CashLedger.txtLedgerType.Text = "Cash"
        FormShow(frmLDR_CashLedger)
        frmLDR_CashLedger.ViewReport()
    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc")
    End Sub

    Private Sub AutoNumberGenerationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoNumberGenerationToolStripMenuItem.Click
        FormShow(frmAutoGeneration)
    End Sub

    Private Sub HowDoIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowDoIToolStripMenuItem.Click
        FormShow(frmHowDoI)
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        FormShow(frmAboutUs)
    End Sub

    Private Sub TextTranslationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTranslationToolStripMenuItem.Click
        FormShow(frmTextTranslation)
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        EnglishToolStripMenuItem.Checked = True
        TamilToolStripMenuItem.Checked = False
        LangDisplay = "English"
        FormsRefresh()
        LangCurrent = LangDisplay
    End Sub

    Private Sub TamilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TamilToolStripMenuItem.Click
        EnglishToolStripMenuItem.Checked = False
        TamilToolStripMenuItem.Checked = True
        LangDisplay = "Tamil"
        FormsRefresh()
        LangCurrent = LangDisplay
    End Sub

    Private Sub OnScreenKeybaordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnScreenKeybaordToolStripMenuItem.Click
        Shell("osk")
    End Sub

    Private Sub CompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyToolStripMenuItem.Click
        FormShow(frmCompanyDetails)
        frmCompanyDetails.ViewForm(CompName)
    End Sub

    Private Sub UserAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountToolStripMenuItem.Click
        FormShow(frmUserAccount)
    End Sub
    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        FormShow(frmReceiptBill)
    End Sub

    Private Sub DebitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitToolStripMenuItem.Click
        FormShow(frmPayment)
    End Sub

    Private Sub CreditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditToolStripMenuItem.Click
        FormShow(frmReceipt)
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileName As String = SaveFileDialog1.FileName
            Dim arr As New ArrayList
            arr = db.CompanyDetails.UserCodes()
            For i As Integer = 0 To arr.Count - 1
                arr(i) = GetDBName() + "_" + arr(i).ToString().Replace(" ", "")

                DBBackup(arr(i).ToString())
                arr(i) = DBBackupPath + arr(i).ToString().Replace(" ", "")
            Next
            DBBackup(GetDBName())
            arr.Add(DBBackupPath + GetDBName())

            ZipFile(FileName, arr)
            MsgBox("Backup is Completed")
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileName As String = OpenFileDialog1.FileName
            Try
                Directory.Delete(DBBackupPath + "Restore", True)
            Catch ex As Exception

            End Try

            Dim DInfo As DirectoryInfo = Directory.CreateDirectory(DBBackupPath + "Restore")
            UnZipFile(DBBackupPath + "Restore", FileName)
            Dim FileNames() As String = Directory.GetFiles(DBBackupPath + "Restore")

            JISDb.Disconnect()
            JISDbTransaction.Disconnect()

            For i As Integer = 0 To FileNames.Length - 1
                DBRestore(Mid(FileNames(i), InStrRev(FileNames(i), "\") + 1), FileNames(i))
            Next

            JISDb = New JISDatabase("Data Source=" + DBServerName + ";Initial Catalog=" + DBName + ";User ID=" + DBUserName + ";Password=" + DBPassword, "SQL")
            JISDbTransaction = New JISDatabase("Data Source=" + DBServerName + ";Initial Catalog=JISDB_Private_" + CompName.Replace(" ", "").Trim() + ";User ID=" + DBUserName + ";Password=" + DBPassword, "SQL")

            db = New DBLib()

            MsgBox("Restore is Completed")
        End If
    End Sub


    Sub ZipFile(ByVal ZipPath As String, ByVal FileNames As ArrayList)
        If FileNames.Count = 0 Then Exit Sub

        Dim Zip As Package = ZipPackage.Open(ZipPath, FileMode.OpenOrCreate, FileAccess.ReadWrite)

        For i As Integer = 0 To FileNames.Count - 1

            Dim uriFileName As String = FileNames(i).ToString().Replace(" ", "_")
            Dim zipUri As String = String.Concat("/", IO.Path.GetFileName(uriFileName))

            Dim partUri As New Uri(zipUri, UriKind.Relative)
            Dim contentType As String = Net.Mime.MediaTypeNames.Application.Zip

            Dim pkgPart As PackagePart = Zip.CreatePart(partUri, contentType, CompressionOption.Normal)
            Dim bites As Byte() = File.ReadAllBytes(FileNames(i).ToString())
            pkgPart.GetStream().Write(bites, 0, bites.Length)

        Next

        Zip.Close()
    End Sub

    Private Sub UnZipFile(ByVal UnZipPath As String, ByVal ZipFilePath As String)

        Dim zip As Package = ZipPackage.Open(ZipFilePath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
        For Each pkgPart As PackagePart In zip.GetParts()
            Dim fileName As String = pkgPart.Uri.OriginalString.Substring(1)

            If IO.Path.GetExtension(fileName) = ".psmdcp" OrElse fileName.IndexOf("_rels") > -1 Then Continue For

            Dim stream As Stream = pkgPart.GetStream()
            'Read all of the bytes from the file to add to the zip file
            Dim bites(CInt(stream.Length - 1)) As Byte
            stream.Read(bites, 0, bites.Length)
            'fileName = fileName.Replace("_", " ")  'replace underscore with space
            File.WriteAllBytes(String.Concat(UnZipPath, "\", fileName), bites)

        Next

        zip.Close()

    End Sub

    Private Sub TaxDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxDetailsToolStripMenuItem.Click
        FormShow(frmTaxMaster)
    End Sub

    Private Sub MillWorkingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MillWorkingToolStripMenuItem.Click
        FormShow(frmMillWorking)
    End Sub
    Private Sub DebitNoteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitNoteToolStripMenuItem1.Click
        FormShow(frmDebitTransaction)
    End Sub

    Private Sub MillLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MillLedgerToolStripMenuItem.Click
        frmLDR_CashLedger.txtLedgerType.Text = "Mill"
        FormShow(frmLDR_CashLedger)
        frmLDR_CashLedger.ViewReport()
    End Sub

    Private Sub EFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EFormToolStripMenuItem.Click
        FormShow(frmCForm)
    End Sub

    Private Sub PartyPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyPaymentToolStripMenuItem.Click
        FormShow(frmPartyPayment)
    End Sub

    Private Sub CompanyInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyInfoToolStripMenuItem.Click
        FormShow(frmCompany)
    End Sub

    Private Sub PartyDebitNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyDebitNoteToolStripMenuItem.Click
        FormShow(frmPartyDebitNote)
    End Sub

    Private Sub MillPaymentDebitNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MillPaymentDebitNoteToolStripMenuItem.Click
        FormShow(frmMillPaymenyDebitNote)
    End Sub

    Private Sub PartyPaymentDebitNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyPaymentDebitNoteToolStripMenuItem.Click
        FormShow(frmPartyPaymentDebitNote)
    End Sub

    Private Sub PendingBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingBillToolStripMenuItem.Click
        FormShow(frmPendingBill)
    End Sub

    Private Sub CFormToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFormToolStripMenuItem.Click
        FormShow(frmCFormEntry)
    End Sub

    Private Sub PartyPendingDebitNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyPendingDebitNoteToolStripMenuItem.Click
        FormShow(frmPendingBillParty)
    End Sub

    Private Sub E1FormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1FormToolStripMenuItem.Click
        FormShow(frmE1Form)
    End Sub

    Private Sub NewCFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCFormToolStripMenuItem.Click
        FormShow(frmCFormAdd)
    End Sub

    Private Sub EMailSentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailSentToolStripMenuItem.Click
        FormShow(frmEMail)
    End Sub

    Private Sub PartywiseEMailSendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartywiseEMailSendingToolStripMenuItem.Click
        FormShow(frmPartywiseEMail)
    End Sub

    Private Sub MillwiseEMailSendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MillwiseEMailSendingToolStripMenuItem.Click
        FormShow(frmMillwiseEMail)
    End Sub

    Private Sub ScheduledEMailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduledEMailToolStripMenuItem.Click
        FormShow(frmScheduledEMail)
    End Sub

    Private Sub SMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSToolStripMenuItem.Click
        FormShow(frmScheduledSMS)
    End Sub

    Private Sub AutoEmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoEmailToolStripMenuItem.Click
        FormShow(frmAutoEMailPending)
    End Sub

    Private Sub MILLCONFIRMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MILLCONFIRMATIONToolStripMenuItem.Click
        FormShow(frmMillConfrimation)
    End Sub

    Private Sub DRAFTSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DRAFTSMSToolStripMenuItem.Click
        FormShow(frmSMSDraft)
    End Sub

    Private Sub COUNTGROUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COUNTGROUPToolStripMenuItem.Click
        FormShow(frmCountGroup)
    End Sub
End Class