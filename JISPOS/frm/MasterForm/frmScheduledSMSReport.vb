﻿Public Class frmScheduledSMSReport
    Dim db As New DBLib

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                If TypeOf ctl Is TextBox Then
                    Dim txt As TextBox = DirectCast(ctl, TextBox)
                    If txt.Multiline = True Then
                        If txt.Text.EndsWith(vbCrLf) Then
                            Me.SelectNextControl(ctl, True, True, True, True)
                        End If
                    Else
                        Me.SelectNextControl(ctl, True, True, True, True)
                    End If
                Else
                    Me.SelectNextControl(ctl, True, True, True, True)
                End If


            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If

    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

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

    Private Sub frmCustomersReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        ViewSearch()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()
        Dim WQry As String = ""

        If txtMobileNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "MobileNo Like '"
            If rbnUnderSuffix.Checked = True Or rbnUnderInfix.Checked = True Then WQry += "%"
            WQry += txtUnder.Text
            If rbnUnderPrefix.Checked = True Or rbnUnderInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If



        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTUnits As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        DTUnits = db.ScheduledSMS.Grid("*", WQry).ToTable("ScheduledSMS")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTUnits)
        ReportView(CrystalReportViewer1, "Master\cryScheduledSMS.rpt", ds)
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobileNo.Enter, txtUnder.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobileNo.Leave, txtUnder.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

End Class