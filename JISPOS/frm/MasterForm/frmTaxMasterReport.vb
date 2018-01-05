Public Class frmTaxMasterReport
    Dim db As New DBLib

    Private Sub frmUnitsReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTTax As New DataTable()

        DTCompanyDetails = db.CompanyDetails.Grid().ToTable("CompanyDetails")
        DTTax = db.TaxMaster.Grid("*").ToTable("TaxMaster")
        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTTax)
        ReportView(CrystalReportViewer1, "Master\cryTaxMaster.rpt", ds)

    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                Me.SelectNextControl(ctl, True, True, True, True)
            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If

    End Sub

End Class