Public Class frmFullCustomerDetails
    Dim db As New DBLib
    Dim ItemState As String
    Private Sub frmFullCustomerDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmFullCustomerDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)

        loaddata()

    End Sub

    Sub loaddata()
        Dim dv As New DataView

        Dim i As Integer
        Dim cust As New ArrayList
        cust = db.Party.UserCodes
        dv = db.Ledger.Grid("*", "'" + cust(i) + "'")
        dgvDetails.Rows.Clear()
        For i = 0 To dv.Count - 1
            dgvDetails.Rows.Add()
            dgvDetails.Item("SNo", i).Value = i + 1
            dgvDetails.Item("CustomerName", i).Value = dv.Item(i)("LedgerName").ToString()
            dgvDetails.Item("Balance", i).Value = dv.Item(i)("CRAmount").ToString()
        Next
    End Sub

    
End Class