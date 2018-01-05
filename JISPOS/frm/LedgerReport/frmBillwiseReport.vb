Public Class frmBillwiseReport

    Dim db As New DBLib
    Public BType As String = ""
    Private Sub frmCompanyReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If cmbCustomerName.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbCustomerName, "Please Enter the Customer Name")
            cmbCustomerName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbCustomerName, "")

        End If
       

        Return RValue
    End Function

    Private Sub frmBillwiseReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim ctl As Control = Me.ActiveControl
            If TypeOf ctl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctl, TextBox)
                If txt.Multiline = False Then e.KeyChar = ChrW(0)
            Else
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub frmCompanyReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
                ReportView(CrystalReportViewer1, "LedgerReport\crySalesBillwiseReport.rpt", db.GetSalesWiseBill(SDate, EDate, cmbCustomerName.Text).ToTable())
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbSupplierName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.Enter, dtpFDate.Enter, dtpTDate.Enter, btnSearch.Enter

        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

        If sender.Name = cmbCustomerName.Name Then List_Datas(cmbCustomerName, db.Party.UserCodes())


        'List_Datas(cmbSupplierName,, True)

    End Sub

    Private Sub cmbSupplierName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.Leave, dtpFDate.Leave, dtpTDate.Leave, btnSearch.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub
End Class