Imports Excel = Microsoft.Office.Interop.Excel
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO

Public Class frmMillConfrimationSearch

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, cmbMillName.Enter, cmbBillingName.Enter, cmbPartyName.Enter, txtTotalBags.Enter, cmbStatus.Enter, cmbPayMode.Enter, cmbMonth.Enter, cmbCountGroup.Enter, txtConfirmationNo.Enter, txtInvoiceNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name = cmbMillName.Name Then
            List_Datas(cmbMillName, db.Mill.Column("MillName"))
        End If
        If sender.name = cmbPartyName.Name Then
            List_Datas(cmbPartyName, db.Party.Column("PartyName"))
        End If
        If sender.name = cmbBillingName.Name Then
            List_Datas(cmbBillingName, db.Party.Column("LedgerName", "PartyName='" + cmbPartyName.Text + "'"))
        End If
        If sender.name = cmbCountGroup.Name Then
            List_Datas(cmbCountGroup, db.Mill.Column("CountGroup"))
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, cmbMillName.Leave, cmbBillingName.Leave, cmbPartyName.Leave, txtTotalBags.Leave, cmbStatus.Leave, cmbPayMode.Leave, cmbMonth.Leave, cmbCountGroup.Leave, txtConfirmationNo.Leave, txtInvoiceNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        'ViewSearch()
        dgvSearch.AllowUserToResizeColumns = True
        'dgvSearch.AllowUserToAddRows = True
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()

        Dim SalesType As String = ""
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()
        Dim WQry, MCode, PCode, CCode, Qry As String
        WQry = ""
        MCode = db.Mill.Data("MillCode", "MillName='" + cmbMillName.Text + "'")
        PCode = db.Party.Data("PartyCode", "PartyName='" + cmbPartyName.Text + "'")
        CCode = db.Mill.Data("MillCode", "CountGroup='" + cmbCountGroup.Text + "'")
        If Period.Checked = True Then
            If WQry <> "" Then WQry += " and "
            WQry = "MCDate>=#" + SDate + "# and  MCDate<=#" + EDate + "# "
        End If
        If cmbMillName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += " MillCode='" + MCode + "'"
        End If
        If cmbPartyName.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PartyCode In (Select PartyCode from Party where PartyName='" + cmbPartyName.Text + "')"
            'WQry += " PartyCode='" + PCode + "'"
        End If
        If cmbPartyName.Text.Trim() <> "" And cmbBillingName.Text <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PartyCode In (Select PartyCode from Party where PartyName='" + cmbPartyName.Text + "' and LedgerName='" + cmbBillingName.Text + "')"
            'WQry += " PartyCode='" + PCode + "'"
        End If
        If cmbCountGroup.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and"
            WQry += " MillCode='" + CCode + "'"
        End If
        If cmbPayMode.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and"
            WQry += " PayMode='" + cmbPayMode.Text + "'"
        End If
        If cmbStatus.Text.Trim() <> "" Then
            If WQry <> "" Then WQry += " and"
            WQry += " Status='" + cmbStatus.Text + "'"
        End If
        If cmbMonth.Text.Trim() <> "" Then
            Dim TmpSDate, TmpEDate As String
            If cmbMonth.Text.Trim() = "April" Then
                TmpSDate = "4/1/2o17 12:00:00 AM"
                TmpEDate = "4/30/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "May" Then
                TmpSDate = "5/1/2017 12:00:00 AM"
                TmpEDate = "5/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "June" Then
                TmpSDate = "6/1/2017 12:00:00 AM"
                TmpEDate = "6/30/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "July" Then
                TmpSDate = "7/1/2017 12:00:00 AM"
                TmpEDate = "7/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "August" Then
                TmpSDate = "8/1/2017 12:00:00 AM"
                TmpEDate = "8/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "September" Then
                TmpSDate = "9/1/2017 12:00:00 AM"
                TmpEDate = "9/30/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "March" Then
                TmpSDate = "3/1/2017 12:00:00 AM"
                TmpEDate = "3/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "October" Then
                TmpSDate = "10/1/2017 12:00:00 AM"
                TmpEDate = "10/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "November" Then
                TmpSDate = "11/1/2017 12:00:00 AM"
                TmpEDate = "11/30/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "December" Then
                TmpSDate = "12/1/2017 12:00:00 AM"
                TmpEDate = "12/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "January" Then
                TmpSDate = "01/1/2017 12:00:00 AM"
                TmpEDate = "01/31/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            ElseIf cmbMonth.Text.Trim() = "February" Then
                TmpSDate = "02/1/2017 12:00:00 AM"
                TmpEDate = "02/10/2017 11:59:59 PM"
                If WQry <> "" Then WQry += " and "
                WQry += "MCDate>=#" + TmpSDate + "# and  MCDate<=#" + TmpEDate + "# "
            End If

        End If

        Dim dv As DataView

        If WQry = "" Then
            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as ConfirmNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LotNo, SalesMode, IDiscount,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM MillWorking)FROM MillWorking) As [Balance], Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount , PayMode FROM MillConfrimation UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS ConfirmNo, (select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],'' AS [Status],'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],'' AS [Status],'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],'' AS [Status],'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],'' AS [Status],'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName], BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' Order by [MILL NAME],ConfirmNo ASC"
            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as ConfirmNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount , PayMode,LotNo, SalesMode, IDiscount, Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup FROM MillConfrimation UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS ConfirmNo, (select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName], BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' Order by [MILL NAME],ConfirmNo ASC"

            Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as ConfirmNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME],NameInChange, ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount , PayMode,LotNo, SalesMode, IDiscount, Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,Particulars FROM MillConfrimation UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS ConfirmNo, (select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME],'' AS NameInChange , '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup,'' AS Particulars from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameinChange, '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup,'' AS Particulars from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameinChange, '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup,'' AS Particulars from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS ConfirmNo,(select MillName from Mill where MillCode=MillWorking.MillName) AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameinChange, '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName], BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,  '' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS [Status],'' AS CountGroup,'' AS Particulars from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' Order by [MILL NAME],ConfirmNo ASC"

            dv = db.ExecuteQuery(Qry)
            dgvSearch.DataSource = dv

            If dv Is Nothing Then
                Exit Sub
            End If
        Else

            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LotNo, SalesMode, IDiscount,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance], Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,PayMode FROM MillConfrimation where " + WQry + " UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],  '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo<>''  UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],  '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo2<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule, '' As [Balance], '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo3<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule, '' As [Balance], '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo4<>'' Order by CONNO ASC"
            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,PayMode,LotNo, SalesMode, IDiscount, Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup FROM MillConfrimation where " + WQry + " UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo<>''  UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo2<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo3<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo4<>'' Order by CONNO ASC"
            Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], NameInChange,ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,PayMode,LotNo, SalesMode, IDiscount, Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,Particulars FROM MillConfrimation where " + WQry + " UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameInChange,'' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo<>''  UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameInChange,'' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo2<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameInChange,'' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo3<>'' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS NameInChange,'' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation where " + WQry + ") AND ConNo4<>'' Order by CONNO ASC"

            dv = db.ExecuteQuery(Qry)
            dgvSearch.DataSource = dv
            If dv Is Nothing Then
                Exit Sub
            End If
        End If

        If txtInvoiceNo.Text.Trim() <> "" Then

            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,'' AS PayMode,LotNo, SalesMode, IDiscount,Status, (select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup FROM MillConfrimation where Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>''AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' AND Invoice='" + txtInvoiceNo.Text + "' Order by CONNO ASC"
            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,'' AS PayMode,LotNo, SalesMode, IDiscount,Status, (select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup FROM MillConfrimation where ConfrimationNo In (Select ConNo from MillWorking where Invoice='" + txtInvoiceNo.Text + "') OR ConfrimationNo In (Select ConNo2 from MillWorking where Invoice='1') OR ConfrimationNo In (Select ConNo3 from MillWorking where Invoice='" + txtInvoiceNo.Text + "') OR ConfrimationNo In (Select ConNo4 from MillWorking where Invoice='" + txtInvoiceNo.Text + "') UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>''AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' AND Invoice='" + txtInvoiceNo.Text + "' Order by CONNO ASC"
            Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME],NameInChange,ICount,  NoOfBags, IRate,LRBreakUp, DSedule,NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,'' AS PayMode,LotNo, SalesMode, IDiscount,Status, (select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,Particulars FROM MillConfrimation where ConfrimationNo In (Select ConNo from MillWorking where Invoice='" + txtInvoiceNo.Text + "') OR ConfrimationNo In (Select ConNo2 from MillWorking where Invoice='1') OR ConfrimationNo In (Select ConNo3 from MillWorking where Invoice='" + txtInvoiceNo.Text + "') OR ConfrimationNo In (Select ConNo4 from MillWorking where Invoice='" + txtInvoiceNo.Text + "') UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],'' AS NameInChange,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>''AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],'' AS NameInChange,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],'' AS NameInChange,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' AND Invoice='" + txtInvoiceNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],(select LedgerName from Party where PartyCode=MillWorking.PartyName) as [BillingName],'' AS NameInChange,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,'' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' AND Invoice='" + txtInvoiceNo.Text + "' Order by CONNO ASC"
            dv = db.ExecuteQuery(Qry)
            dgvSearch.DataSource = dv
            If dv Is Nothing Then
                Exit Sub
            End If
        End If

        If txtConfirmationNo.Text.Trim() <> "" Then
            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LotNo, SalesMode, IDiscount,LRBreakUp, DSedule, NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance], Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,PayMode FROM MillConfrimation where ConfrimationNo='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],  '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>'' AND ConNo='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],  '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' AND ConNo2='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule, '' As [Balance], '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' AND ConNo3='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate,'' AS LotNo, '' AS SalesMode, '' AS IDiscount, '' AS LRBreakUp,'' AS DSedule, '' As [Balance], '' AS Status,'' AS CountGroup,(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' AND ConNo4='" + txtConfirmationNo.Text + "' Order by CONNO ASC"
            'Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], ICount,  NoOfBags, IRate,LRBreakUp, DSedule, NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,PayMode,LotNo, SalesMode, IDiscount, Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup FROM MillConfrimation where ConfrimationNo='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>'' AND ConNo='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' AND ConNo2='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' AND ConNo3='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME], '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' AND ConNo4='" + txtConfirmationNo.Text + "' Order by CONNO ASC"
            Qry = "SELECT MCCode as CODE, Format([MCDate],'dd/mm/yyyy') as CDATE,ConfrimationNo as CONNo,(select MillName from Mill where MillCode=MillConfrimation.MillCode) as [MILL NAME], (Select PartyName from Party where PartyCode=MillConfrimation.PartyCode) as [PARTY NAME],(Select LedgerName from Party where PartyCode=MillConfrimation.PartyCode) as [BILLING NAME], NameInChange,ICount,  NoOfBags, IRate,LRBreakUp, DSedule, NoOfBags-(SELECT SUM(IIF(ConNo=ConfrimationNo, IIF(ActualBags =  null, 0, ActualBags), 0)) +(SELECT  SUM(IIF(ConNo2=ConfrimationNo, IIF(ActuallBags2 =  null, 0, ActuallBags2), 0))  FROM    MillWorking)+(SELECT  SUM(IIF(ConNo3=ConfrimationNo, IIF(ActualBags3 =  null, 0, ActualBags3), 0))  FROM MillWorking) +(SELECT  SUM(IIF(ConNo4=ConfrimationNo, IIF(ActualBags4 =  null, 0, ActualBags4), 0)) FROM    MillWorking)FROM MillWorking) As [Balance],'' AS PartyName,'' as BillingName,'' AS InvoiceDate,Invoice,'' as [Despatch Bags],'' as [Actual Bags] ,'' as TotalKg,'' AS Rate, '' AS Amount,PayMode,LotNo, SalesMode, IDiscount, Status,(select CountGroup from Mill where MillCode=MillConfrimation.MillCode) AS CountGroup,Particulars FROM MillConfrimation where ConfrimationNo='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo AS CONNO, '' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME],'' AS NameInChange, '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars from MillWorking where ConNo In (Select ConfrimationNo from MillConfrimation) AND ConNo<>'' AND ConNo='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo2 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME],'' AS NameInChange, '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule,'' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActuallBags2 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars  from MillWorking where ConNo2 In (Select ConfrimationNo from MillConfrimation) AND ConNo2<>'' AND ConNo2='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo3 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME],'' AS NameInChange, '' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags3 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars  from MillWorking where ConNo3 In (Select ConfrimationNo from MillConfrimation) AND ConNo3<>'' AND ConNo3='" + txtConfirmationNo.Text + "' UNION SELECT MWCode AS CODE, '' AS [CDATE],ConNo4 AS CONNO,'' AS [MILL NAME], '' AS [PARTY NAME],'' AS [BILLING NAME],'' AS NameInChange,'' AS ICount,'' AS NoOfBags,  '' AS IRate, '' AS LRBreakUp,'' AS DSedule, '' As [Balance],(select PartyName from Party where PartyCode=MillWorking.PartyName) As [PartyName],BillingName,Format([MWDate],'dd/mm/yyyy') as InvoiceDate,Invoice,NoOfBags As [Despatch Bags],ActualBags4 As [Actual Bags],TotalKg,Rate,Amount,'' AS PayMode,'' AS LotNo, '' AS SalesMode, '' AS IDiscount,  '' AS Status,'' AS CountGroup,'' AS Particulars  from MillWorking where ConNo4 In (Select ConfrimationNo from MillConfrimation) AND ConNo4<>'' AND ConNo4='" + txtConfirmationNo.Text + "' Order by CONNO ASC"

            dv = db.ExecuteQuery(Qry)
            dgvSearch.DataSource = dv
            If dv Is Nothing Then
                Exit Sub
            End If

        End If


        Dim i As Integer = 0
        Dim TotBags As Integer
        TotBags = 0
        ProgressBar1.Visible = True
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = dgvSearch.RowCount + 1
        While (i < dgvSearch.RowCount)
            TotBags += Val(dgvSearch.Item("NoOfBags", i).Value)
            i = i + 1
            ProgressBar1.Value += 1
            Application.DoEvents()
        End While
        ProgressBar1.Visible = False
        txtTotalBags.Text = TotBags
        dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red
        'dgvSearch.Columns(0).HeaderCell.Value = "SELECT"
        dgvSearch.Columns(0).Width = 40
        'dgvSearch.Columns(1).HeaderCell.Value = "CODE"
        dgvSearch.Columns(1).Visible = False
        dgvSearch.Columns(2).HeaderCell.Value = "DATE"
        dgvSearch.Columns(2).Width = 70
        dgvSearch.Columns(3).HeaderCell.Value = "CON.No"
        dgvSearch.Columns(3).Width = 50
        dgvSearch.Columns("MILL NAME").HeaderCell.Value = "MILL NAME"
        dgvSearch.Columns("MILL NAME").Width = 200
        dgvSearch.Columns("PARTY NAME").HeaderCell.Value = "PARTY NAME"
        dgvSearch.Columns("PARTY NAME").Width = 120
        dgvSearch.Columns("BILLING NAME").HeaderCell.Value = "BILLING NAME"
        dgvSearch.Columns("BILLING NAME").Width = 150
        dgvSearch.Columns("NameInChange").HeaderCell.Value = "NAME IN CHANGE"
        dgvSearch.Columns("NameInChange").Width = 150
        dgvSearch.Columns("ICount").HeaderCell.Value = "COUNT"
        dgvSearch.Columns("ICount").Width = 70
        dgvSearch.Columns("NoOfBags").HeaderCell.Value = "NO OF BAGS"
        dgvSearch.Columns("NoOfBags").Width = 50
        dgvSearch.Columns("IRate").HeaderCell.Value = "RATE"
        dgvSearch.Columns("IRate").Width = 50
        dgvSearch.Columns("LotNo").HeaderCell.Value = "LOT NO"
        dgvSearch.Columns("LotNo").Width = 60
        dgvSearch.Columns("SalesMode").HeaderCell.Value = "SALES MODE"
        dgvSearch.Columns("SalesMode").Width = 70
        dgvSearch.Columns("IDiscount").HeaderCell.Value = "DISCOUNT"
        dgvSearch.Columns("IDiscount").Width = 70
        dgvSearch.Columns("LRBreakUp").HeaderCell.Value = "LR BREAKUP"
        dgvSearch.Columns("DSedule").HeaderCell.Value = "SCHEDULE"
        dgvSearch.Columns("DSedule").Width = 60
        dgvSearch.Columns("Balance").HeaderCell.Value = "BALANCE"
        dgvSearch.Columns("Balance").Width = 50
        dgvSearch.Columns("Status").HeaderCell.Value = "STATUS"
        dgvSearch.Columns("Status").Width = 50
        dgvSearch.Columns("CountGroup").HeaderCell.Value = "COUNT GROUP"
        dgvSearch.Columns("CountGroup").Width = 70
        dgvSearch.Columns("PartyName").HeaderCell.Value = "PARTY NAME"
        dgvSearch.Columns("PartyName").Width = 150

        dgvSearch.Columns("BillingName").HeaderCell.Value = "BILLING NAME"
        dgvSearch.Columns("BillingName").Width = 170
        dgvSearch.Columns("InvoiceDate").HeaderCell.Value = "INVOICE DATE"
        dgvSearch.Columns("InvoiceDate").Width = 70
        dgvSearch.Columns("Invoice").HeaderCell.Value = "INVOICE NO"
        dgvSearch.Columns("Invoice").Width = 70
        dgvSearch.Columns("Despatch Bags").HeaderCell.Value = "DESPATCH BAGS"
        dgvSearch.Columns("Despatch Bags").Width = 70
        dgvSearch.Columns("Actual Bags").HeaderCell.Value = "ACTUAL BAGS"
        dgvSearch.Columns("Actual Bags").Width = 70
        dgvSearch.Columns("TotalKg").HeaderCell.Value = "TOTAL KG"
        dgvSearch.Columns("TotalKg").Width = 70
        dgvSearch.Columns("Rate").HeaderCell.Value = "RATE"
        dgvSearch.Columns("Rate").Width = 70
        dgvSearch.Columns("Amount").HeaderCell.Value = "AMOUNT"
        dgvSearch.Columns("Amount").Width = 70
        dgvSearch.Columns("PayMode").HeaderCell.Value = "PAY MODE"
        dgvSearch.Columns("PayMode").Width = 80
        dgvSearch.Columns("Particulars").HeaderCell.Value = "PARTICULARS"
        dgvSearch.Columns("Particulars").Width = 150
        dgvSearch.Columns("PartyName").ReadOnly = True
        dgvSearch.Columns("BillingName").ReadOnly = True
        dgvSearch.Columns("InvoiceDate").ReadOnly = True
        dgvSearch.Columns("PayMode").ReadOnly = True

        dgvSearch.EditMode = DataGridViewEditMode.EditOnEnter
        'dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgvSearch.EditMode = DataGridViewEditMode.EditOnKeystroke
        dgvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        Try
            Dim rowindex As String
            For Each row As DataGridViewRow In dgvSearch.Rows
                row.Cells("Balance").Style.ForeColor = Color.Red
                If row.Cells.Item("CODE").Value.StartsWith("MWK") Then
                    rowindex = row.Index.ToString()
                    dgvSearch.Rows(rowindex).Cells(3).Style.ForeColor = Color.White
                    dgvSearch.Rows(rowindex).Cells(4).Style.ForeColor = Color.White
                    ' dgvSearch.Rows(rowindex - 1).Cells(15).Style.ForeColor = Color.Red
                    'If dgvSearch.Rows(rowindex - 1).Cells(3).Value = dgvSearch.Rows(rowindex).Cells(3).Value Then
                    '    If dgvSearch.Rows(rowindex - 1).Cells(1).Value.StartsWith("MCN") Then
                    '        dgvSearch.Rows(rowindex - 1).Cells(15).Value = dgvSearch.Rows(rowindex - 1).Cells(8).Value - dgvSearch.Rows(rowindex).Cells(23).Value
                    '        If dgvSearch.Rows(rowindex + 1).Cells.Item("CODE").Value.StartsWith("MWK") Then
                    '            dgvSearch.Rows(rowindex - 1).Cells(15).Value = dgvSearch.Rows(rowindex - 1).Cells(8).Value - dgvSearch.Rows(rowindex).Cells(23).Value - dgvSearch.Rows(rowindex + 1).Cells(23).Value
                    '        End If
                    '        If dgvSearch.Rows(rowindex + 2).Cells.Item("CODE").Value.StartsWith("MWK") Then
                    '            dgvSearch.Rows(rowindex - 1).Cells(15).Value = dgvSearch.Rows(rowindex - 1).Cells(8).Value - dgvSearch.Rows(rowindex).Cells(23).Value - dgvSearch.Rows(rowindex + 1).Cells(23).Value - dgvSearch.Rows(rowindex + 2).Cells(23).Value
                    '        End If
                    '        
                    '    End If

                    'End If


                End If
            Next

        Catch ex As Exception

        End Try



    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            Dim selectedRows As List(Of DataGridViewRow) = (From row In dgvSearch.Rows.Cast(Of DataGridViewRow)() _
                                                            Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList()
            For Each row As DataGridViewRow In selectedRows
                txtCode.Text = row.Cells(1).Value
            Next
            frmMillConfrimation.txtSearchBox.Text = txtCode.Text
            frmMillConfrimation.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub cmbSalesCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMillName.TextChanged, cmbPartyName.TextChanged, cmbBillingName.TextChanged
    '    ViewSearch()
    'End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Enabled = False
        ExportDataGridView(dgvSearch)
        Me.Enabled = True
    End Sub

    Sub ExportDataGridView(ByVal dgv As DataGridView)
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Int16, j As Int16

            xlApp = New Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            ProgressBar1.Visible = True
            ProgressBar1.Maximum = dgv.Rows.Count

            Dim CCol As Integer = 1

            For j = 1 To dgv.ColumnCount - 1
                If dgv.Columns(j).Visible = True Then
                    xlWorkSheet.Cells(1, CCol) = dgv.Columns(j).HeaderText
                    xlWorkSheet.Cells(1, CCol).ColumnWidth = dgv.Columns(j).Width / 10
                    xlWorkSheet.Cells(1, CCol).Font.Bold = True
                    CCol = CCol + 1
                End If
            Next

            For i = 0 To dgv.RowCount - 1

                CCol = 1
                For j = 1 To dgv.ColumnCount - 1
                    If dgv.Columns(j).Visible = True Then
                        If IsDate(dgv(j, i).Value) Then
                            xlWorkSheet.Cells(i + 2, CCol).value = String.Format("{0:dd/MM/yyyy}", dgv(j, i).Value)
                        Else
                            xlWorkSheet.Cells(i + 2, CCol).value = dgv(j, i).Value.ToString()
                        End If
                        dgvSetBackColor(dgvSearch)
                        ' xlWorkSheet.Cells(i + 2, CCol).Interior.Color = RGB(dgv.Rows(i).DefaultCellStyle.BackColor.R, dgv.Rows(i).DefaultCellStyle.BackColor.G, dgv.Rows(i).DefaultCellStyle.BackColor.B)

                        CCol = CCol + 1

                    End If

                Next
            Next
            xlWorkSheet.Cells.Borders.LineStyle = 1

            xlWorkBook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
             Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)
            ProgressBar1.Visible = False
            If (MsgBox("Process completed, Would you like to open file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Process.Start(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub dgvSearch_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSearch.Sorted
        dgvSetBackColor(dgvSearch)
        Try
            Dim rowindex As String
            For Each row As DataGridViewRow In dgvSearch.Rows
                row.Cells("Balance").Style.ForeColor = Color.Red
                If row.Cells.Item("CODE").Value.StartsWith("MWK") Then
                    rowindex = row.Index.ToString()
                    'dgvSearch.Rows(rowindex - 1).Cells(15).Style.ForeColor = Color.Red
                    dgvSearch.Rows(rowindex).Cells(3).Style.ForeColor = Color.White
                    dgvSearch.Rows(rowindex).Cells(4).Style.ForeColor = Color.White
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub dgvSetBackColor(ByVal dgv As DataGridView, Optional ByVal SColor As String = "StatusColor")
        Try
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Item("StatusColor", i).Value <> 0 Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(Val(dgv.Item(SColor, i).Value.ToString()))

                Else
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEMailParty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEMailParty.Click
        Dim MCCode, EMailId, EMailSub, EMailMsg, IAddress, DAddress, Note As String
        Dim ConNo, ConDate, MillName, BillingName, Count, NoOfBags, Rate, SalesMode, DisAmt, DeliverySedule, LRBreakUp, PayMode As String
        Dim selectedRows As List(Of DataGridViewRow) = (From row In dgvSearch.Rows.Cast(Of DataGridViewRow)() _
                                                            Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList()
        If MessageBox.Show(String.Format("Do you want to Send Email {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                MCCode = row.Cells(1).Value.ToString()
                ConNo = row.Cells(3).Value.ToString()
                ConDate = row.Cells(2).Value.ToString()
                MillName = row.Cells(4).Value.ToString()
                BillingName = row.Cells(6).Value.ToString()
                Count = row.Cells(7).Value.ToString()
                NoOfBags = row.Cells(8).Value.ToString()
                Rate = row.Cells(9).Value.ToString()

                SalesMode = row.Cells(11).Value.ToString()
                DisAmt = row.Cells(12).Value.ToString()
                DeliverySedule = row.Cells(14).Value.ToString()
                LRBreakUp = row.Cells(13).Value.ToString()
                PayMode = row.Cells(27).Value.ToString()
                EMailId = ""

                EMailMsg = ""
                IAddress = ""
                DAddress = ""
                Note = ""
                EMailSub = String.Format("we confirmed {0} Bags of {1} @ RS {2} /- ( {3} - {4} )", NoOfBags, Count, Rate, MillName, BillingName).ToUpper
                Dim Arr_Data As New ArrayList
                Arr_Data = db.MillConfrimation.Row("(select EMailId from party where PartyCode=MillConfrimation.PartyCode) as EMailId,InvoiceAddress,DeliveryAddress,(select Note from partyAddress where PartyCode=MillConfrimation.PartyCode) as Notes", "MCCode='" + MCCode + "'")
                If Not Arr_Data Is Nothing Then
                    If Arr_Data.Count > 0 Then
                        EMailId = Arr_Data(0).ToString()
                        IAddress = Arr_Data(1).ToString()
                        DAddress = Arr_Data(2).ToString()
                        Note = Arr_Data(3).ToString()
                    End If
                End If


                EMailMsg += "<html><head><style>*{color:blue} .t1 td{border: 1px solid green;}</style></head><body>"
                EMailMsg += "<font style='color:blue'>DINESH TULSYAN</font><br>"
                EMailMsg += "<font style='color:blue'>HARIOM YARN AGENCY</font><br>"
                EMailMsg += "<font style='color:blue'>2/569,VAGAI ST.,GOMATHIPURAM 6TH</font><br>"
                EMailMsg += "<font style='color:blue'>MAIN(ROAD.MADURAI - 625020)</font><br>"
                EMailMsg += "<font style='color:blue'>TAMILNADU</font><br>"
                EMailMsg += "<font style='color:blue'>tulsyandinesh@(gmail.com)</font><br>"
                EMailMsg += "<font style='color:blue'>Cell(+9345213033, 8220010234)</font><br>"
                EMailMsg += "<font style='color:blue'>Ph :  0452-4516303, 4383033, 82206-60044</font><br>"
                EMailMsg += "<hr style='color:black'><br>"


                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td>"

                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'><b>CONFIRMATION NO :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>&nbsp;{0}</b><br></td>", ConNo)
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DATE :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>&nbsp;{0}</b><br></td>", ConDate)
                EMailMsg += "</tr>"
                EMailMsg += "</table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"


                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"
                EMailMsg += "<b>&nbsp;DEAR SIR,</b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-left:20px'>WE CONFRIMED AS FOLLOWING BAG : </td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "<table border=1 cellspacing=0>"


                EMailMsg += String.Format("<tr><td>COUNT</td><td style='padding-right:100px'>{0}</td></tr>", Count)
                EMailMsg += String.Format("<tr><td>NO OF BAGS</td><td style='padding-right:100px'>{0}</td></tr>", NoOfBags)
                EMailMsg += String.Format("<tr><td>RATE</td><td style='padding-right:100px'>RS {0} /-</td></tr>", Rate)
                EMailMsg += String.Format("<tr><td>SALES MODE</td><td style='padding-right:100px'>{0}</td></tr>", SalesMode)
                If DisAmt <> "" Then
                    EMailMsg += String.Format("<tr><td>DISCOUNT</td><td style='padding-right:100px'>{0}</td></tr>", DisAmt)
                End If
                EMailMsg += String.Format("<tr><td>DELIVERY SCHEDULE</td><td style='padding-right:100px'>{0}</td></tr>", DeliverySedule)
                EMailMsg += String.Format("<tr><td>LR BREAK UP</td><td style='padding-right:100px'>{0}</td></tr>", LRBreakUp)
                EMailMsg += String.Format("<tr><td>PAYMENT MODE</td><td style='padding-right:100px'>{0}</td></tr>", PayMode)

                If SalesMode.ToUpper() = "DISCOUNT" Then
                    EMailMsg += String.Format("<td style='padding-right:100px'>{0}</td>", 0)
                End If

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-top:20px'>"

                EMailMsg += "<table width='600px'><tr>"
                EMailMsg += "<td style='width:300px'><b><u>INVOICE ADDRESS</u></b></td><td style='width:300px'><b><u>DELIVERY ADDRESS</u></b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += String.Format("<td style='padding-left:10px;vertical-align:top;width:300px'><pre style='font-size:14px;font-family:times new roman'>{0}</pre></td><td style='padding-left:10px;vertical-align:top;width:300px;'><pre style='font-size:14px;font-family:times new roman'>{1}</pre></td>", IAddress, DAddress)

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                If Note <> "" Then
                    EMailMsg += "<tr>"
                    EMailMsg += String.Format("<td style='padding-left:10px;vertical-align:top;'><b>{0}</b></td>", Note)
                    EMailMsg += "</tr>"
                End If


                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-top:30px;color:blue'>"
                EMailMsg += "Regards<br>"
                EMailMsg += "DINESH TULSYAN<br>"
                EMailMsg += "HARIOM YARN AGENCY<br>"


                EMailMsg += "</td>"
                EMailMsg += "</tr>"
                EMailMsg += "</table></body></html>"

                RichTextBox1.Text = EMailMsg

                Dim oApp As Word.Application
                Dim oDoc As Word.Document
                oApp = New Word.Application

                If Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower()) Then
                    System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower())
                    If Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower() + "\MillConfirm") Then
                        System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower() + "\MillConfirm")
                    End If
                End If
                RichTextBox1.SaveFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower() + "\MillConfirm\HariOmYarnAgency.html", RichTextBoxStreamType.PlainText)

                oDoc = oApp.Documents.Open(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower() + "\MillConfirm\HariOmYarnAgency.html")
                oDoc.SaveAs(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower() + "\MillConfirm\HariOmYarnAgency.doc")

                Dim sSource As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Computer.Name.ToLower() + "\MillConfirm\HariOmYarnAgency.doc"
                oDoc.Close(False)
                oApp.Quit()
                oDoc = Nothing
                oApp = Nothing

                System.Threading.Thread.Sleep(2000)
                OutLookEMail(EMailId, EMailSub, EMailMsg, sSource, True)

                'RichTextBox1.Text = ""
                'OutLookEMail(EMailId, EMailSub, EMailMsg, True)

            Next
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim PCode, PartyCode, PartyName, BillingName, InvoiceNo, Bags, ActualBag, TotalKg, MRate, MAmount, ConNo As String
        Dim ActBag, ActBag2, ActBag3, ActBag4, Qry, Str As String
        Dim selectedRows As List(Of DataGridViewRow) = (From row In dgvSearch.Rows.Cast(Of DataGridViewRow)() _
                                                            Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList()
        If MessageBox.Show(String.Format("Do you want to Save {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows

                PCode = row.Cells(1).Value
                ConNo = row.Cells(3).Value
                PartyName = row.Cells(18).Value
                PartyCode = db.Party.Data("PartyCode", "PartyName='" + PartyName + "'")
                BillingName = row.Cells(19).Value
                InvoiceNo = row.Cells(21).Value
                Bags = row.Cells(22).Value
                ActualBag = row.Cells(23).Value
                TotalKg = row.Cells(24).Value
                MRate = row.Cells(25).Value
                MAmount = row.Cells(26).Value

                ActBag = db.MillWorking.Data("ActualBags", "MWCode='" + PCode + "'")
                ActBag2 = db.MillWorking.Data("ActuallBags2", "MWCode='" + PCode + "'")
                ActBag3 = db.MillWorking.Data("ActualBags3", "MWCode='" + PCode + "'")
                ActBag4 = db.MillWorking.Data("ActualBags4", "MWCode='" + PCode + "'")

                If db.MillWorking.ExistData("ConNo", ConNo) Then
                    Qry = String.Format("update MillWorking Set PartyName='{0}',BillingName='{1}',Invoice='{2}',NoOfBags={3},ActualBags={4},TotalKg={5},Rate={6},Amount={7} where MWCode='{8}'", PartyCode, BillingName, InvoiceNo, Bags, ActualBag, TotalKg, MRate, MAmount, PCode)
                    Str = db.ExecuteQuery(Qry)
                    If Str = 1 Then
                        MsgBox("Saved Successfully")
                    Else
                        MsgBox("Not Saved")
                    End If
                ElseIf db.MillWorking.ExistData("ConNo2", ConNo) Then
                    Qry = String.Format("update MillWorking Set PartyName='{0}',BillingName='{1}',Invoice='{2}',NoOfBags={3},ActuallBags2={4},TotalKg={5},Rate={6},Amount={7} where MWCode='{8}'", PartyCode, BillingName, InvoiceNo, Bags, ActualBag, TotalKg, MRate, MAmount, PCode)
                    Str = db.ExecuteQuery(Qry)
                    If Str = 1 Then
                        MsgBox("Saved Successfully")
                    Else
                        MsgBox("Not Saved")
                    End If
                ElseIf db.MillWorking.ExistData("ConNo3", ConNo) Then
                    Qry = String.Format("update MillWorking Set PartyName='{0}',BillingName='{1}',Invoice='{2}',NoOfBags={3},ActualBags3={4},TotalKg={5},Rate={6},Amount={7} where MWCode='{8}'", PartyCode, BillingName, InvoiceNo, Bags, ActualBag, TotalKg, MRate, MAmount, PCode)
                    Str = db.ExecuteQuery(Qry)
                    If Str = 1 Then
                        MsgBox("Saved Successfully")
                    Else
                        MsgBox("Not Saved")
                    End If
                ElseIf db.MillWorking.ExistData("ConNo4", ConNo) Then
                    Qry = String.Format("update MillWorking Set PartyName='{0}',BillingName='{1}',Invoice='{2}',NoOfBags={3},ActualBags4={4},TotalKg={5},Rate={6},Amount={7} where MWCode='{8}'", PartyCode, BillingName, InvoiceNo, Bags, ActualBag, TotalKg, MRate, MAmount, PCode)
                    Str = db.ExecuteQuery(Qry)
                    If Str = 1 Then
                        MsgBox("Saved Successfully")
                    Else
                        MsgBox("Not Saved")
                    End If
                End If

            Next
        End If

    End Sub
    Private Sub dgvSearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSearch.SelectionChanged
        Try
            Dim tot As Long = 0
            For i As Integer = 0 To dgvSearch.SelectedCells.Count - 1
                If IsNumeric(dgvSearch.SelectedCells(i).Value) Then
                    tot = tot + dgvSearch.SelectedCells(i).Value
                End If
            Next
            Total.Text = tot
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEMailMill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEMailMill.Click
        Dim MCCode, EMailId, EMailSub, EMailMsg, IAddress, DAddress, Note As String
        Dim ConNo, ConDate, MillName, BillingName, Count, NoOfBags, Rate, SalesMode, DisAmt, DeliverySedule, LRBreakUp, PayMode As String
        Dim selectedRows As List(Of DataGridViewRow) = (From row In dgvSearch.Rows.Cast(Of DataGridViewRow)() _
                                                            Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList()
        If MessageBox.Show(String.Format("Do you want to Send Email {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                MCCode = row.Cells(1).Value.ToString()
                ConNo = row.Cells(3).Value.ToString()
                ConDate = row.Cells(2).Value.ToString()
                MillName = row.Cells(4).Value.ToString()
                BillingName = row.Cells(6).Value.ToString()
                Count = row.Cells(7).Value.ToString()
                NoOfBags = row.Cells(8).Value.ToString()
                Rate = row.Cells(9).Value.ToString()

                SalesMode = row.Cells(11).Value.ToString()
                DisAmt = row.Cells(12).Value.ToString()
                DeliverySedule = row.Cells(14).Value.ToString()
                LRBreakUp = row.Cells(13).Value.ToString()
                PayMode = row.Cells(27).Value.ToString()
                EMailId = ""

                EMailMsg = ""
                IAddress = ""
                DAddress = ""
                Note = ""
                EMailSub = String.Format("we confirmed {0} Bags of {1} @ RS {2} /- ( {3} - {4} )", NoOfBags, Count, Rate, MillName, BillingName).ToUpper
                Dim Arr_Data As New ArrayList
                Arr_Data = db.MillConfrimation.Row("(select EMailId from Mill where MillCode=MillConfrimation.MillCode) as EMailId,InvoiceAddress,DeliveryAddress,(select Note from partyAddress where PartyCode=MillConfrimation.PartyCode) as Notes", "MCCode='" + MCCode + "'")
                If Not Arr_Data Is Nothing Then
                    If Arr_Data.Count > 0 Then
                        EMailId = Arr_Data(0).ToString()
                        IAddress = Arr_Data(1).ToString()
                        DAddress = Arr_Data(2).ToString()
                        Note = Arr_Data(3).ToString()
                    End If
                End If


                EMailMsg += "<html><head><style>*{color:blue} .t1 td{border: 1px solid green;}</style></head><body>"
                EMailMsg += "<font style='color:blue'>DINESH TULSYAN</font><br>"
                EMailMsg += "<font style='color:blue'>HARIOM YARN AGENCY</font><br>"
                EMailMsg += "<font style='color:blue'>2/569,VAGAI ST.,GOMATHIPURAM 6TH</font><br>"
                EMailMsg += "<font style='color:blue'>MAIN(ROAD.MADURAI - 625020)</font><br>"
                EMailMsg += "<font style='color:blue'>TAMILNADU</font><br>"
                EMailMsg += "<font style='color:blue'>tulsyandinesh@(gmail.com)</font><br>"
                EMailMsg += "<font style='color:blue'>Cell(+9345213033, 8220010234)</font><br>"
                EMailMsg += "<font style='color:blue'>Ph :  0452-4516303, 4383033, 82206-60044</font><br>"
                EMailMsg += "<hr style='color:black'><br>"


                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td>"

                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'><b>CONFIRMATION NO :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>&nbsp;{0}</b><br></td>", ConNo)
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>DATE :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>&nbsp;{0}</b><br></td>", ConDate)
                EMailMsg += "</tr>"
                EMailMsg += "</table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"


                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"
                EMailMsg += "<b>&nbsp;DEAR SIR,</b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-left:20px'>WE CONFRIMED AS FOLLOWING BAG : </td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "<table border=1 cellspacing=0>"


                EMailMsg += String.Format("<tr><td>COUNT</td><td style='padding-right:100px'>{0}</td></tr>", Count)
                EMailMsg += String.Format("<tr><td>NO OF BAGS</td><td style='padding-right:100px'>{0}</td></tr>", NoOfBags)
                EMailMsg += String.Format("<tr><td>RATE</td><td style='padding-right:100px'>RS {0} /-</td></tr>", Rate)
                EMailMsg += String.Format("<tr><td>SALES MODE</td><td style='padding-right:100px'>{0}</td></tr>", SalesMode)
                If DisAmt <> "" Then
                    EMailMsg += String.Format("<tr><td>DISCOUNT</td><td style='padding-right:100px'>{0}</td></tr>", DisAmt)
                End If
                EMailMsg += String.Format("<tr><td>DELIVERY SCHEDULE</td><td style='padding-right:100px'>{0}</td></tr>", DeliverySedule)
                EMailMsg += String.Format("<tr><td>LR BREAK UP</td><td style='padding-right:100px'>{0}</td></tr>", LRBreakUp)
                EMailMsg += String.Format("<tr><td>PAYMENT MODE</td><td style='padding-right:100px'>{0}</td></tr>", PayMode)

                If SalesMode.ToUpper() = "DISCOUNT" Then
                    EMailMsg += String.Format("<td style='padding-right:100px'>{0}</td>", 0)
                End If

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-top:20px'>"

                EMailMsg += "<table Width='600px'><tr>"
                EMailMsg += "<td style='width:300px'><b><u>INVOICE ADDRESS</u></b></td><td style='width:300px'><b><u>DELIVERY ADDRESS</u></b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += String.Format("<td style='padding-left:10px;vertical-align:top;width:300px'><pre style='font-size:14px;font-family:times new roman'>{0}</pre></td><td style='padding-left:10px;vertical-align:top;width:300px'><pre style='font-size:14px;font-family:times new roman'>{1}</pre></td>", IAddress, DAddress)

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                If Note <> "" Then
                    EMailMsg += "<tr>"
                    EMailMsg += String.Format("<td style='padding-left:10px;vertical-align:top;'><b>{0}</b></td>", Note)
                    EMailMsg += "</tr>"
                End If

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-top:30px;color:blue'>"
                EMailMsg += "Regards<br>"
                EMailMsg += "DINESH TULSYAN<br>"
                EMailMsg += "HARIOM YARN AGENCY<br>"


                EMailMsg += "</td>"
                EMailMsg += "</tr>"
                EMailMsg += "</table></body></html>"

                RichTextBox1.Text = EMailMsg

                RichTextBox1.SaveFile(Application.StartupPath + "\\Images\\MillConfirm\\" + MCCode + ".html", RichTextBoxStreamType.PlainText)
                ' RichTextBox1.SaveFile(Application.StartupPath + "\\Images\\MillConfirm\\HariOmYarnAgency.html", RichTextBoxStreamType.PlainText)

                Dim oApp As Word.Application
                Dim oDoc As Word.Document

                oApp = New Word.Application
                'oDoc = oApp.Documents.Open(Application.StartupPath + "\\MillConfirm\\test.html")
                oDoc = oApp.Documents.Open(Application.StartupPath + "\\Images\\MillConfirm\\" + MCCode + ".html")
                oDoc.SaveAs(Application.StartupPath + "\\Images\\MillConfirm\\HariOmYarnAgency.doc")
                Dim sSource As String = Application.StartupPath + "\\Images\\MillConfirm\\" + MCCode + ".doc"
                oDoc.Close(False)
                oApp.Quit()
                oDoc = Nothing
                oApp = Nothing

                RichTextBox1.Text = ""
                OutLookEMail(EMailId, EMailSub, EMailMsg, sSource, True)


                'OutLookEMail(EMailId, EMailSub, EMailMsg, True)

            Next
        End If
    End Sub

    Private Sub btnBoth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoth.Click
        Dim MCCode, EMailId, EMailSub, EMailMsg, IAddress, DAddress, Note As String
        Dim ConNo, ConDate, MillName, BillingName, Count, NoOfBags, Rate, SalesMode, DisAmt, DeliverySedule, LRBreakUp, PayMode, EMailMsgAttach As String
        Dim selectedRows As List(Of DataGridViewRow) = (From row In dgvSearch.Rows.Cast(Of DataGridViewRow)() _
                                                            Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList()
        If MessageBox.Show(String.Format("Do you want to Send Email {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                MCCode = row.Cells(1).Value.ToString().ToUpper
                ConNo = row.Cells(3).Value.ToString().ToUpper
                ConDate = row.Cells(2).Value.ToString().ToUpper
                MillName = row.Cells(4).Value.ToString().ToUpper
                BillingName = row.Cells(6).Value.ToString().ToUpper
                Count = row.Cells(8).Value.ToString().ToUpper
                NoOfBags = row.Cells(9).Value.ToString()
                Rate = row.Cells(10).Value.ToString()

                SalesMode = row.Cells(25).Value.ToString().ToUpper
                DisAmt = row.Cells(26).Value.ToString()
                DeliverySedule = row.Cells(12).Value.ToString().ToUpper
                LRBreakUp = row.Cells(11).Value.ToString().ToUpper
                PayMode = row.Cells(23).Value.ToString().ToUpper
                EMailId = ""

                EMailMsg = ""
                IAddress = ""
                DAddress = ""
                Note = ""
                EMailSub = String.Format("we confirmed {0} Bags of {1} @ RS {2} /- ( {3} - {4} )", NoOfBags, Count, Rate, MillName, BillingName).ToUpper

                Dim Arr_Data As New ArrayList
                Arr_Data = db.MillConfrimation.Row("(select EMailId from party where PartyCode=MillConfrimation.PartyCode) as EMailId,InvoiceAddress,DeliveryAddress", "MCCode='" + MCCode + "'")
                If Not Arr_Data Is Nothing Then
                    If Arr_Data.Count > 0 Then
                        EMailId = Arr_Data(0).ToString()
                        IAddress = Arr_Data(1).ToString()
                        DAddress = Arr_Data(2).ToString()
                        Note = db.PartyAddress.Data("Note", String.Format("InvoiceAddress='{0}' And DeliveryAddress='{1}'", IAddress, DAddress))
                    End If
                End If

                Dim Arr_BothData As New ArrayList
                Dim MIllCode As String = db.MillConfrimation.Data("MillCode", String.Format("MCCode='{0}'", MCCode))
                Arr_BothData = db.Mill.Row("EMailId", "MillCode='" + MIllCode + "'")
                If Not Arr_BothData Is Nothing Then
                    If Arr_BothData.Count > 0 Then
                        If EMailId <> "" Then
                            EMailId += ","
                            EMailId += Arr_BothData(0).ToString()
                        End If
                    End If
                End If

                Dim MillEMailId As String = db.Mill.Data("EMailId", String.Format("MillCode='{0}'", MIllCode))
                If EMailId <> "" And MillEMailId <> "" Then
                    EMailId += ","
                End If
                EMailId += MillEMailId
                EMailMsg += "<style>*{color:blue} .t1 td{border: 1px solid green;}</style>"
                EMailMsg += "<font style='color:blue'>DINESH TULSYAN</font><br>"
                EMailMsg += "<font style='color:blue'>HARIOM YARN AGENCY</font><br>"
                EMailMsg += "<font style='color:blue'>2/569,VAGAI ST.,GOMATHIPURAM 6TH</font><br>"
                EMailMsg += "<font style='color:blue'>MAIN(ROAD.MADURAI - 625020)</font><br>"
                EMailMsg += "<font style='color:blue'>TAMILNADU</font><br>"
                EMailMsg += "<font style='color:blue'>tulsyandinesh@(gmail.com)</font><br>"
                EMailMsg += "<font style='color:blue'>Cell(+9345213033, 8220010234)</font><br>"
                EMailMsg += "<font style='color:blue'>Ph :  0452-4516303, 4383033, 82206-60044</font><br>"
                EMailMsg += "<hr style='color:black'><br>"


                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td>"

                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'><b>CONFIRMATION NO :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>&nbsp;{0}</b><br></td>", ConNo)
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>DATE :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>&nbsp;{0}</b><br></td>", ConDate)
                EMailMsg += "</tr>"
                EMailMsg += "</table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"


                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"
                EMailMsg += "<b>&nbsp;DEAR SIR,</b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-left:20px'>WE CONFRIMED AS FOLLOWING BAG : </td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "<table border=1 cellspacing=0>"

                EMailMsg += String.Format("<tr><td>MILL NAME</td><td style='padding-right:100px'>{0}</td></tr>", MillName)
                EMailMsg += String.Format("<tr><td>PARTY NAME</td><td style='padding-right:100px'>{0}</td></tr>", BillingName)
                EMailMsg += String.Format("<tr><td>COUNT</td><td style='padding-right:100px'>{0}</td></tr>", Count)
                EMailMsg += String.Format("<tr><td>NO OF BAGS</td style='padding-right:100px'><td>{0}</td></tr>", NoOfBags)
                EMailMsg += String.Format("<tr><td>RATE</td><td style='padding-right:100px'>RS {0} /-</td></tr>", Rate)
                EMailMsg += String.Format("<tr><td>SALES MODE</td><td style='padding-right:100px'>{0}</td></tr>", SalesMode)
                If DisAmt <> "" Then
                    EMailMsg += String.Format("<tr><td>DISCOUNT</td><td style='padding-right:100px'>{0}</td></tr>", DisAmt)
                End If
                EMailMsg += String.Format("<tr><td>DELIVERY SCHEDULE</td><td style='padding-right:100px'>{0}</td></tr>", DeliverySedule)
                EMailMsg += String.Format("<tr><td>LR BREAK UP</td><td style='padding-right:100px'>{0}</td></tr>", LRBreakUp)
                EMailMsg += String.Format("<tr><td>PAYMENT MODE</td><td style='padding-right:100px'>{0}</td></tr>", PayMode)

                If SalesMode.ToUpper() = "DISCOUNT" Then
                    EMailMsg += String.Format("<td>{0}</td>", 0)
                End If

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-top:20px'>"

                EMailMsg += "<table width='600px'>"

                EMailMsgAttach = ""
                EMailMsgAttach += EMailMsg
                EMailMsgAttach += "<tr><td style='width:300px'><b><u>INVOICE ADDRESS</u></b></td><td style='width:300px'><b><u>DELIVERY ADDRESS</u></b></td>"
                EMailMsgAttach += "</tr>"

                EMailMsgAttach += "<tr>"
                EMailMsgAttach += String.Format("<td style='padding-left:10px;vertical-align:top;width:300px'><pre style='font-size:14px;font-family:times new roman'>{0}</pre></td><td style='padding-left:10px;vertical-align:top;width:300px'><pre style='font-size:14px;font-family:times new roman'>{1}</pre></td>", IAddress, DAddress)

                EMailMsgAttach += "</tr></table>"

                EMailMsgAttach += "</td>"
                EMailMsgAttach += "</tr>"

                If Note <> "" Then
                    EMailMsgAttach += "<tr>"
                    EMailMsgAttach += String.Format("<td style='padding-left:10px;vertical-align:top;'><b>{0}</b></td>", Note)
                    EMailMsgAttach += "</tr>"
                End If

                EMailMsg += "<tr>"
                EMailMsgAttach += "<tr>"
                EMailMsg += "<td style='padding-top:30px;color:blue'>"
                EMailMsgAttach += "<td style='padding-top:30px;color:blue'>"
                EMailMsg += "Regards<br>"
                EMailMsgAttach += "Regards<br>"
                EMailMsg += "DINESH TULSYAN<br>"
                EMailMsgAttach += "DINESH TULSYAN<br>"
                EMailMsg += "HARIOM YARN AGENCY<br>"
                EMailMsgAttach += "HARIOM YARN AGENCY<br>"

                EMailMsg += "</td>"
                EMailMsgAttach += "</td>"
                EMailMsg += "</tr>"
                EMailMsgAttach += "</tr>"
                EMailMsg += "</table>"
                EMailMsgAttach += "</table>"

                RichTextBox1.Text = EMailMsgAttach
                RichTextBox1.SaveFile(Application.StartupPath + "\\Images\\BothConfirm\\HariOmYarnAgency - " + ConNo + ".html", RichTextBoxStreamType.PlainText)

                Dim oApp As Word.Application
                Dim oDoc As Word.Document

                oApp = New Word.Application
                oDoc = oApp.Documents.Open(Application.StartupPath + "\\Images\\BothConfirm\\HariOmYarnAgency - " + ConNo + ".html")
                oDoc.SaveAs(Application.StartupPath + "\\Images\\BothConfirm\\HariOmYarnAgency - " + ConNo + ".doc")
                Dim sSource As String = Application.StartupPath + "\\Images\\BothConfirm\\HariOmYarnAgency - " + ConNo + ".doc"
                oDoc.Close(False)
                oApp.Quit()
                oDoc = Nothing
                oApp = Nothing

                RichTextBox1.Text = ""

                OutLookEMail(EMailId, EMailSub, EMailMsg, sSource, True)


                'OutLookEMail(EMailId, EMailSub, EMailMsg, True)

            Next
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim MCCode, EMailId, EMailSub, EMailMsg, IAddress, DAddress As String
        Dim ConNo, ConDate, MillName, BillingName, Count, NoOfBags, Rate, SalesMode, DisAmt, DeliverySedule, LRBreakUp, PayMode As String
        Dim selectedRows As List(Of DataGridViewRow) = (From row In dgvSearch.Rows.Cast(Of DataGridViewRow)() _
                                                            Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList()
        If MessageBox.Show(String.Format("Do you want to Send Email {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                MCCode = row.Cells(1).Value.ToString()
                ConNo = row.Cells(3).Value.ToString()
                ConDate = row.Cells(2).Value.ToString()
                MillName = row.Cells(4).Value.ToString()
                BillingName = row.Cells(6).Value.ToString()
                Count = row.Cells(7).Value.ToString()
                NoOfBags = row.Cells(8).Value.ToString()
                Rate = row.Cells(9).Value.ToString()

                SalesMode = row.Cells(11).Value.ToString()
                DisAmt = row.Cells(12).Value.ToString()
                DeliverySedule = row.Cells(14).Value.ToString()
                LRBreakUp = row.Cells(13).Value.ToString()
                PayMode = row.Cells(27).Value.ToString()
                EMailId = ""

                EMailMsg = ""
                IAddress = ""
                DAddress = ""

                EMailSub = String.Format("we confirmed {0} Bags of {1} @ RS {2} ( {3} - {4} )", NoOfBags, Count, Rate, MillName, BillingName).ToUpper
                Dim Arr_Data As New ArrayList
                Arr_Data = db.MillConfrimation.Row("(select EMailId from party where PartyCode=MillConfrimation.PartyCode) as EMailId,InvoiceAddress,DeliveryAddress", "MCCode='" + MCCode + "'")
                If Not Arr_Data Is Nothing Then
                    If Arr_Data.Count > 0 Then
                        EMailId = Arr_Data(0).ToString()
                        IAddress = Arr_Data(1).ToString()
                        DAddress = Arr_Data(2).ToString()
                    End If
                End If


                EMailMsg += "<html><head><style>*{color:blue} .t1 td{border: 1px solid green;}</style></head><body>"
                EMailMsg += "<font style='color:blue'>DINESH TULSYAN</font><br>"
                EMailMsg += "<font style='color:blue'>HARIOM YARN AGENCY</font><br>"
                EMailMsg += "<font style='color:blue'>2/569,VAGAI ST.,GOMATHIPURAM 6TH</font><br>"
                EMailMsg += "<font style='color:blue'>MAIN(ROAD.MADURAI - 625020)</font><br>"
                EMailMsg += "<font style='color:blue'>TAMILNADU</font><br>"
                EMailMsg += "<font style='color:blue'>tulsyandinesh@(gmail.com)</font><br>"
                EMailMsg += "<font style='color:blue'>Cell(+9345213033, 8220010234)</font><br>"
                EMailMsg += "<font style='color:blue'>Ph :  0452-4516303, 4383033, 82206-60044</font><br>"
                EMailMsg += "<hr style='color:black'><br>"


                EMailMsg += "<table>"
                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:left'><b>CONFIRMATION NO :</b>"
                EMailMsg += String.Format("<b style='text-align:right'>{0}</b><br></td>", ConNo)
                EMailMsg += "<td style='padding-bottom:20px' style='text-align:right'>"
                EMailMsg += String.Format("<b style='text-align:right'>{0}</b><br></td>", ConDate)
                EMailMsg += "</tr>"


                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"
                EMailMsg += "<b>DEAR SIR,</b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-left:20px'>WE CONFRIMED AS FOLLOWING BAG : </td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "<table border=1 cellspacing=0>"


                EMailMsg += String.Format("<tr><td>COUNT</td><td>{0}</td></tr>", Count)
                EMailMsg += String.Format("<tr><td>NO OF BAGS</td><td>{0}</td></tr>", NoOfBags)
                EMailMsg += String.Format("<tr><td>RATE</td><td>{0} /-RS</td></tr>", Rate)
                EMailMsg += String.Format("<tr><td>SALES MODE</td><td>{0}</td></tr>", SalesMode)
                If DisAmt <> "" Then
                    EMailMsg += String.Format("<tr><td>DISCOUNT</td><td>{0}</td></tr>", DisAmt)
                End If
                EMailMsg += String.Format("<tr><td>DELIVERY SCHEDULE</td><td>{0}</td></tr>", DeliverySedule)
                EMailMsg += String.Format("<tr><td>LR BREAK UP</td><td>{0}</td></tr>", LRBreakUp)
                EMailMsg += String.Format("<tr><td>PAYMENT MODE</td><td>{0}</td></tr>", PayMode)

                If SalesMode.ToUpper() = "DISCOUNT" Then
                    EMailMsg += String.Format("<td>{0}</td>", 0)
                End If

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px'>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-bottom:20px;padding-top:20px'>"

                EMailMsg += "<table><tr>"
                EMailMsg += "<td style='width:250px'><b><u>INVOICE ADDRESS</u></b></td><td><b><u>DELIVERY ADDRESS</u></b></td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += String.Format("<td style='padding-left:10px;vertical-align:top'><pre>{0}</pre></td><td style='padding-left:10px;vertical-align:top'><pre>{1}</pre></td>", IAddress, DAddress)

                EMailMsg += "</tr></table>"

                EMailMsg += "</td>"
                EMailMsg += "</tr>"

                EMailMsg += "<tr>"
                EMailMsg += "<td style='padding-top:30px;color:blue'>"
                EMailMsg += "Regards<br>"
                EMailMsg += "DINESH TULSYAN<br>"
                EMailMsg += "HARIOM YARN AGENCY<br>"


                EMailMsg += "</td>"
                EMailMsg += "</tr>"
                EMailMsg += "</table></body></html>"


                RichTextBox1.Text = EMailMsg
                RichTextBox1.SaveFile(Application.StartupPath + "\\MillConfirm\\" & ConNo & MCCode & ".html", RichTextBoxStreamType.PlainText)

                Dim oApp As Word.Application
                Dim oDoc As Word.Document

                oApp = New Word.Application
                'oDoc = oApp.Documents.Open(Application.StartupPath + "\\MillConfirm\\test.html")
                oDoc = oApp.Documents.Open(Application.StartupPath + "\\MillConfirm\\" & ConNo & MCCode & ".html")
                oDoc.SaveAs(Application.StartupPath + "\\MillConfirm\\" & ConNo & MCCode & ".doc")
                Dim sSource As String = Application.StartupPath + "\\MillConfirm\\" & ConNo & MCCode & ".doc"
                oDoc.Close(False)
                oApp.Quit()
                oDoc = Nothing
                oApp = Nothing

                OutLookEMail(EMailId, EMailSub, EMailMsg, sSource, True)
            Next
        End If
        Application.DoEvents()

    End Sub

    
End Class