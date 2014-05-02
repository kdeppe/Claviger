Imports System.Data.SqlServerCe

Public Class DeleteCategory

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim lngCategoryID As Int32 = lbxCategories.SelectedValue
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT 1 FROM tblPassword WHERE flngCategoryID = @plngCategoryID"
        cmd.Parameters.AddWithValue("@plngCategoryID", lngCategoryID)
        If cmd.ExecuteResultSet(ResultSetOptions.Scrollable).HasRows() Then
            MsgBox("Sites are using this category. Delete or update them before you delete the category.")
            Exit Sub
        End If
        cmd.CommandText = "SELECT fstrCategory FROM tblCategory WHERE flngCategoryID = @plngCategoryID"
        Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        rs.ReadFirst()
        Dim strConfirm As String = MsgBox("Are you sure you want to delete " & rs.GetValue(0) & "?", vbYesNo)
        If strConfirm = vbYes Then
            cmd.CommandText = "DELETE FROM tblCategory WHERE flngCategoryID = @plngCategoryID"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT * FROM tblCategory ORDER BY fstrCategory"
            Main.cbxCategory.DataSource = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
            If Not Main.cbxCategory.DataSource.HasRows() Then
                Main.cbxCategory.Text = ""
            End If
            Main.PopulateTreeView()
            Me.Dispose()
        End If
    End Sub

    Friend Sub PopulateList()
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT * FROM tblCategory ORDER BY fstrCategory"
        Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        lbxCategories.DataSource = rs
        lbxCategories.DisplayMember = "fstrCategory"
        lbxCategories.ValueMember = "flngCategoryID"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class