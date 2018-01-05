﻿Public Class frmPartyWiseReport
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

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim WQry As String = ""

        If cmbMillName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PartyName like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += cmbMillName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If cmbMonth.Text.Trim <> "" Then
            
            If WQry <> "" Then WQry += " and "
            WQry += "PeriodFrom='" + cmbYear.Text + "'"
            End If

            If cmbYear.Text.Trim <> "" Then
                If WQry <> "" Then WQry += " and "
            WQry += "PeriodYear='" + cmbYear.Text + "'"

            End If

            Dim ds As New DataSet
            Dim DTCompanyDetails As New DataTable()
            Dim DTProducts As New DataTable()
        'DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName=N'" + CompName + "'").ToTable("CompanyDetails")

        DTProducts = db.ViewEForm.Grid("*", WQry).ToTable("EForm")

            ds.Clear()
            ds.Tables.Add(DTCompanyDetails)
            ds.Tables.Add(DTProducts)
        '            ReportView(CrystalReportViewer1, "Master\cryCAmountPartyName.rpt", ds)
        DataGridView1.DataSource = db.ViewEForm.Grid("MillName, PartyName, BillingName, PeriodFrom, PeriodYear, Amount, CFormNo, CAmount, CFormRcDate, CFormSentDate, CourierName, CourierNo, E1FormNo, E1Amount, E1Date, CStatus, E1Status, C2FormNo, C2Amount, Courier2, CourierNo2, E2FormNo, E2Date, C3FormNo, C3Amount, Courier3, CourierNo3, E3FormNo, E3Date", WQry)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMillName.Enter, cmbYear.Enter, cmbMonth.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Party.Column("PartyName"))
        End If
       
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMillName.Leave, cmbMonth.Leave, cmbYear.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

End Class