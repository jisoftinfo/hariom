Public Class frmSMSDraft

    Private Sub frmSMSDraft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
        ViewSearch()
        'dvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub
    Sub ViewSearch()
        Dim dv As DataView
        dv = db.SMSDraft.Grid("DraftId,DraftCode,Message,PhoneNo,ContactPerson,Department")
        dvSearch.EditMode = DataGridViewEditMode.EditProgrammatically
        dvSearch.Rows.Clear()
        For i As Integer = 0 To dv.Count - 1
            dvSearch.Rows.Add()
            dvSearch.Item("DraftId", i).Value = dv.Item(i)("DraftId").ToString()
            dvSearch.Item("DraftCode", i).Value = dv.Item(i)("DraftCode").ToString()
            dvSearch.Item("Message", i).Value = dv.Item(i)("Message").ToString()
            dvSearch.Item("ContactPerson", i).Value = dv.Item(i)("ContactPerson").ToString()
            dvSearch.Item("PhoneNo", i).Value = dv.Item(i)("PhoneNo").ToString()
            dvSearch.Item("Department", i).Value = dv.Item(i)("Department").ToString()
        Next
        
        dvSearch.AllowUserToAddRows = True
        dvSearch.AllowUserToResizeColumns = True
        'dvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        dvSearch.EditMode = DataGridViewEditMode.EditOnEnter


        dvSearch.Columns("DraftId").Visible = False
        dvSearch.Columns("DraftCode").Visible = False
        ProgressBar1.Visible = False

    End Sub
    Sub NewItem()
        For Each row As DataGridViewRow In dvSearch.SelectedRows
            'dgvSearch.Rows.Insert(row.Index, 1)
            dvSearch.Rows.Insert(3, 1)
            'dgvSearch.Rows.Add(row.Index, 1)
        Next
    End Sub

    Sub ViewItem(ByVal i As Integer)
        dvSearch.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NewItem()
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        ViewItem(dvSearch.CurrentRow.Index)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgDialog.ShowMsgDlg("Do you Delete this Item?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then
            '   DeleteItem()
            MsgDialog.ShowMsgDlg("Deleted", Me.Text, "I")
        End If
    End Sub
   

    Private Sub frmSMSDraft_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
            'ElseIf e.KeyCode = Keys.V And Keys.ControlKey Then
            '    Paste()
            'ElseIf e.KeyCode = Keys.C Then
            'CopyToClipboard()
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    'Private Sub dgvHeader_RowSelect(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvSearch.RowHeaderMouseClick
    '    dvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    'End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        

        ProgressBar1.Visible = True
        ProgressBar1.Maximum = dvSearch.Rows.Count
        dvSearch.AllowUserToAddRows = True

        Dim FRomIndex, ToIndex, SelRowCount As Integer

        SelRowCount = dvSearch.SelectedRows.Count
        Dim SelDatas(SelRowCount, dvSearch.Columns.Count) As String

        For row As Integer = 0 To dvSearch.SelectedRows.Count - 1
            FRomIndex = dvSearch.SelectedRows(row).Index
            For col As Integer = 0 To dvSearch.Columns.Count - 1
                SelDatas(row, col) = dvSearch.Item(col, FRomIndex).Value.ToString()
            Next
        Next
        dvSearch.EditMode = DataGridViewEditMode.EditProgrammatically
        For row As Integer = 0 To SelRowCount - 1

            ToIndex = dvSearch.RowCount - 1
            dvSearch.Rows.Add()
            'dvSearch.CurrentCell = dvSearch.Rows(ToIndex).Cells(2)
            'SendKeys.Send(" ")
            For col As Integer = 0 To dvSearch.Columns.Count - 1
                dvSearch.Item(col, ToIndex).Value = SelDatas(row, col)
                dvSearch.Item("DraftId", ToIndex).Value = ""
                dvSearch.Item("DraftCode", ToIndex).Value = ""
            Next

        Next
        ProgressBar1.Visible = False
        MsgDialog.ShowMsgDlg("Pasted", "Pasted Successfully", "I")
        dvSearch.CurrentCell = dvSearch.Rows(dvSearch.RowCount - 1).Cells(2)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim DraftId, DraftCode, Message, PhoneNo, Qry, WQry As String

            ProgressBar1.Visible = True
            ProgressBar1.Value = 1
            ProgressBar1.Maximum = dvSearch.RowCount + 1
            For i As Integer = 0 To dvSearch.Rows.Count - 2
                ProgressBar1.Value = i
                Application.DoEvents()


                DraftId = dvSearch.Item("DraftId", i).Value.ToString()
                DraftCode = dvSearch.Item("DraftCode", i).Value.ToString()
                Message = dvSearch.Item("Message", i).Value.ToString()
                PhoneNo = dvSearch.Item("PhoneNo", i).Value.ToString()

                If DraftId = "" And DraftCode = "" Then
                    DraftId = db.SMSDraft.NewId()
                    DraftCode = db.SMSDraft.NewCode()
                    db.SMSDraft.SaveRecord(DraftId, DraftCode, Message, PhoneNo)
                Else
                    If db.SMSDraft.ExistCode(DraftCode) Then
                        WQry = String.Format("DraftCode='{0}'", DraftCode)
                        Qry = String.Format("UPDATE SMSDraft SET Message='{0}', PhoneNo='{1}' WHERE DraftCode='{2}'", Message, PhoneNo, DraftCode)
                        JISDb.ExecuteQuery(Qry)
                    End If
                End If


            Next
            ProgressBar1.Visible = False
            MsgDialog.ShowMsgDlg("Saved", "Saved", "I")
            ViewSearch()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub
            Dim DCode, str As String
            For i As Integer = 0 To dvSearch.SelectedRows.Count - 1
                DCode = dvSearch.SelectedRows(i).Cells(1).Value.ToString()
                str = db.SMSDraft.DeleteRecordByCode(DCode)
            Next
            
            MsgDialog.ShowMsgDlg("DELETE", "DELETE", "I")
            ViewSearch()
        Catch ex As Exception

        End Try

    End Sub

    'Public Sub Paste()
    '    PasteData(dvSearch)
    'End Sub

    Public Sub PasteData(ByRef dgv As DataGridView)

        Dim TotArr() As String

        Dim rowSplitter As Char() = {vbTab}
        Dim columnSplitter As Char() = {","}

        Dim dataInClipboard As IDataObject = Clipboard.GetDataObject()
        Dim stringInClipboard As String = CStr(dataInClipboard.GetData(DataFormats.Text))

        Dim rowsInClipboard As String() = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries)

        Dim r As Integer = dgv.SelectedCells(0).RowIndex
        Dim c As Integer = dgv.SelectedCells(1).ColumnIndex
        Dim cc As Integer


        For i = 0 To rowsInClipboard.Length - 1
            TotArr = rowsInClipboard(i).Split(vbCrLf)
            cc = c
            'dgv.Rows.Add()
            For ii = 0 To TotArr.Length - 1

                With dgv.Item(cc, r)
                    .Value = TotArr(ii).TrimStart
                End With
                cc = cc + 1
            Next
            r = r + 1
        Next


    End Sub

    Private Sub dgvSearch_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvSearch.CellDoubleClick
        Try
            Dim f As New frmSMSDraftSend()
            f.txtSearchBox.Text = dvSearch.SelectedRows(0).Cells(1).Value()
            f.Show()
            f.ViewForm()
            FormShow(f)
            dvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub chkSMSDeleted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSMSDeleted.CheckedChanged
        If chkSMSDeleted.Checked = True Then
            dvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            dvSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
        End If
    End Sub
End Class