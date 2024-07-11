
Public Class FrmMain
    Dim sqlHelper As New SqlHelper
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRefresh_Click(vbNull, Nothing)
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        Dim name = txtName.Text
        If name.Length > 0 Then
            Dim bRet = sqlHelper.AddRow(name)
            If bRet = True Then
                btnRefresh_Click(vbNull, Nothing)
                MessageBox.Show("Add row success!")
            Else
                MessageBox.Show("Add Row Fail!")
            End If
        End If
    End Sub

    Private Sub btnAddColumns_Click(sender As Object, e As EventArgs) Handles btnAddColumns.Click
        Dim colMin = txtColMin.Text + "_Min"
        Dim colMax = txtColMax.Text + "_Max"
        Dim bRetMin As Boolean
        Dim bRetMax As Boolean
        If colMin.Length > 0 And colMax.Length > 0 Then
            Dim dt As DataTable = dgv.DataSource
            If dt.Columns.Contains(colMin) Or dt.Columns.Contains(colMax) Then
                If MessageBox.Show("Columns is exist,Are you sure you want to replace it", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If dt.Columns.Contains(colMin) Then
                        bRetMin = sqlHelper.UpdateCol(colMin, "")
                    Else
                        bRetMin = sqlHelper.AddCol(colMin)
                    End If
                    If dt.Columns.Contains(colMax) Then
                        bRetMax = sqlHelper.UpdateCol(colMax, "")
                    Else
                        bRetMax = sqlHelper.AddCol(colMax)
                    End If
                End If
            Else
                bRetMin = sqlHelper.AddCol(colMin)
                bRetMax = sqlHelper.AddCol(colMax)
            End If
            If bRetMin = True And bRetMax = True Then
                btnRefresh_Click(vbNull, Nothing)
                MessageBox.Show("Add column success!")
            Else
                If bRetMin = True Or bRetMax = True Then
                    btnRefresh_Click(vbNull, Nothing)
                End If
                MessageBox.Show("Add Row Fail!")
            End If

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim dt = sqlHelper.GetTableDuvet
        If dt.Rows.Count > 0 Then
            dgv.DataSource = dt
        End If
    End Sub

    Private Sub btnModifyConnStr_Click(sender As Object, e As EventArgs) Handles btnModifyConnStr.Click
        sqlHelper.connStr = txtConnStr.Text
        sqlHelper.TableName = txtTableName.Text
    End Sub
End Class
