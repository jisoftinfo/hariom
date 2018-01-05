Public Class frmPurchaseBillWiseReport
    Dim db As New DBLib
    Public BType As String = ""
    Private Sub frmPurchaseBillWiseReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbSupplierName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbSupplierName, "Please Enter the Supplier Name")
            cmbSupplierName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbSupplierName, "")

        End If


        Return RValue
    End Function

    Private Sub frmPurchaseBillWiseReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)

    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            If FormValidate() Then
                dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
                dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
                Dim SDate As String = dtpFDate.Value.ToString()
                Dim EDate As String = dtpTDate.Value.ToString()
                ReportView(CrystalReportViewer1, "LedgerReport\cryPurchaseBillwiseReport.rpt", db.GetPurchaseWiseBill(SDate, EDate, cmbSupplierName.Text).ToTable())
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbSupplierName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupplierName.Enter, dtpFDate.Enter, dtpTDate.Enter, btnSearch.Enter

        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

        If sender.Name = cmbSupplierName.Name Then List_Datas(cmbSupplierName, db.Mill.UserCodes())


        'List_Datas(cmbSupplierName,, True)

    End Sub

    Private Sub cmbSupplierName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupplierName.Leave, dtpFDate.Leave, dtpTDate.Leave, btnSearch.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

End Class