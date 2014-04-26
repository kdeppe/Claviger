Imports System.Data.SqlServerCe

Public Class Main

#Region "Member Variables"
    Private mdtbCategories As DataTable
    Private mdtbPasswords As DataTable
    Private mdtbSites As DataTable
    Private mcnn
#End Region


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNewCategory.Click
        Dim strCategory As String = InputBox("Enter Category Name: ")
        If strCategory <> "" Then
            Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
            cmd.CommandText = "SELECT MAX(flngCategoryID) AS id FROM tblCategory"
            Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
            Dim id As Int32
            If rs.ReadFirst() AndAlso Not IsDBNull(rs.GetValue(0)) Then
                id = Int(rs.GetValue(0)) + 1
            Else
                id = 1
            End If
            cmd.CommandText = "INSERT INTO tblCategory (flngCategoryID, fstrCategory) VALUES (@plngCategoryID, @pstrCategory)"
            Dim par As SqlCeParameter
            par = New SqlCeParameter("@plngCategoryID", id)
            cmd.Parameters.Add(par)
            par = New SqlCeParameter("@pstrCategory", strCategory)
            cmd.Parameters.Add(par)
            cmd.Prepare()
            cmd.ExecuteNonQuery()

            cmd.CommandText = "SELECT * FROM tblCategory ORDER BY fstrCategory"
            cbxCategory.DataSource = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        End If
    End Sub


End Class
