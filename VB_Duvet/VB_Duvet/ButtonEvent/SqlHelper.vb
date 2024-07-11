Imports System.Data.SqlClient
Public Class SqlHelper
    Public connStr As String = "Server=192.9.200.196;Database=DuvetDB;User Id=sa;Password=Aa123;"
    Public TableName As String = "T_Duvet_Test"

    Private Function GetDataTable(sql As String, pms As SqlParameter()) As DataTable
        Dim dt As New DataTable
        Using adapter As New SqlDataAdapter(sql, connStr)
            adapter.SelectCommand.CommandType = CommandType.Text
            If pms.Count() > 0 And pms(0) IsNot Nothing Then
                adapter.SelectCommand.Parameters.AddRange(pms)
            End If
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetTableDuvet() As DataTable
        Dim sql = "select * from " + TableName
        Dim pms As SqlParameter() = New SqlParameter(0) {}
        Return GetDataTable(sql, pms)
    End Function

    Private Function ExecuteNonQuery(sql As String, pms As SqlParameter()) As Integer
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(sql, conn)
                Dim ret As Integer
                Try
                    cmd.CommandType = CommandType.Text
                    If pms.Count() > 0 And pms(0) IsNot Nothing Then
                        cmd.Parameters.AddRange(pms)
                    End If
                    conn.Open()
                    ret = cmd.ExecuteNonQuery
                Catch ex As Exception
                    ret = -1
                End Try
                Return ret
            End Using
        End Using
    End Function
    Public Function AddRow(name As String) As Boolean
        Dim sql = "insert into " + TableName + "(name) values(@name)"
        Dim pms = New SqlParameter() {New SqlParameter("@name", SqlDbType.VarChar, 255)}
        pms(0).Value = name
        Dim ret = ExecuteNonQuery(sql, pms)
        If ret > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function AddCol(colName As String) As Boolean
        Dim sql = "alter table " + TableName + " add " + colName + " varchar(64)"
        Dim pms As SqlParameter() = New SqlParameter(0) {}
        Dim ret = ExecuteNonQuery(sql, pms)
        Return True
    End Function

    Public Function UpdateCol(colName As String, value As String) As Boolean
        Dim sql = "update " + TableName + " set " + colName + "=@" + colName
        If value Is Nothing Then
            value = ""
        End If
        Dim pms = New SqlParameter() {New SqlParameter("@" + colName, SqlDbType.VarChar, 255)}
        pms(0).Value = value
        Dim ret = ExecuteNonQuery(sql, pms)
        If ret > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
