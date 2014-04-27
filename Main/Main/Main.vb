Imports System.Data.SqlServerCe

Public Class Main

#Region "Member Variables"
    Private mdtbCategories As DataTable
    Private mdtbPasswords As DataTable
    Private mdtbSites As DataTable
    Private mlngPasswordID As Int32
#End Region


    Private Sub btnNewCategory_Click(sender As Object, e As EventArgs) Handles btnNewCategory.Click
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

            PopulateTreeView()
        End If
    End Sub


    Private Sub btnAddSite_Click(sender As Object, e As EventArgs) Handles btnAddSite.Click
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT MAX(flngPasswordID) FROM tblPassword"
        Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        If rs.ReadFirst() AndAlso Not IsDBNull(rs.GetValue(0)) Then
            mlngPasswordID = rs.GetValue(0) + 1
        Else
            mlngPasswordID = 1
        End If

        ClearForm()
    End Sub

    Private Sub btnSaveSite_Click(sender As Object, e As EventArgs) Handles btnSaveSite.Click
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        Dim rs As SqlCeResultSet
        If mlngPasswordID = 0 Then
            cmd.CommandText = "SELECT MAX(flngPasswordID) from tblPassword"
            rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
            If rs.ReadFirst() AndAlso Not IsDBNull(rs.GetValue(0)) Then
                mlngPasswordID = rs.GetValue(0) + 1
            Else
                mlngPasswordID = 1
            End If
        End If
        cmd.CommandText = "SELECT flngCategoryID FROM tblPassword WHERE flngPasswordID = @plngPasswordID"
        cmd.Parameters.AddWithValue("@plngPasswordID", mlngPasswordID)
        rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        cmd.Parameters.Clear()
        Dim lngLastCategoryID As Int32 = 0
        If rs.HasRows() Then
            cmd.CommandText = "UPDATE tblPassword SET fstrSiteName = @pstrSiteName, fstrURL = @pstrURL, flngCategoryID = @plngCategoryID, " &
                              "fstrUsername = @pstrUsername, fstrPassword = @pstrPassword, fstrNote = @pstrNote " &
                              "WHERE flngPasswordID = @plngPasswordID"
            rs.ReadFirst()
            lngLastCategoryID = rs.GetValue(0)
        Else
            cmd.CommandText = "INSERT INTO tblPassword (flngPasswordID, fstrSiteName, fstrURL, flngCategoryID, fstrUsername, fstrPassword, fstrNote) " &
                              "VALUES (@plngPasswordID, @pstrSiteName, @pstrURL, @plngCategoryID, @pstrUsername, @pstrPassword, @pstrNote)"
        End If
        cmd.Parameters.AddWithValue("@plngPasswordID", mlngPasswordID)
        cmd.Parameters.AddWithValue("@pstrSiteName", tbxSiteName.Text)
        cmd.Parameters.AddWithValue("@pstrURL", tbxURL.Text)
        cmd.Parameters.AddWithValue("@plngCategoryID", cbxCategory.SelectedValue)
        cmd.Parameters.AddWithValue("@pstrUsername", tbxUsername.Text)
        cmd.Parameters.AddWithValue("@pstrPassword", tbxPassword.Text)
        cmd.Parameters.AddWithValue("@pstrNote", rtbNotes.Text)

        cmd.ExecuteNonQuery()
        If lngLastCategoryID <> 0 AndAlso lngLastCategoryID <> cbxCategory.SelectedValue Then
            DeleteFromTree(mlngPasswordID, lngLastCategoryID)
        End If
        InsertIntoTree(mlngPasswordID)
    End Sub

    Private Sub tvwSiteList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwSiteList.AfterSelect
        If e.Node.Level = 1 Then
            mlngPasswordID = e.Node.Tag
            Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
            cmd.CommandText = "SELECT fstrSiteName, fstrURL, flngCategoryID, fstrUsername, fstrPassword, fstrNote " &
                              "FROM tblPassword WHERE flngPasswordID = @plngPasswordID"
            cmd.Parameters.AddWithValue("@plngPasswordID", mlngPasswordID)
            Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
            If rs.HasRows() Then
                rs.ReadFirst()
                tbxSiteName.Text = rs.GetValue(0)
                tbxURL.Text = rs.GetValue(1)
                cbxCategory.SelectedValue = rs.GetValue(2)
                tbxUsername.Text = rs.GetValue(3)
                tbxPassword.Text = rs.GetValue(4)
                rtbNotes.Text = rs.GetValue(5)
            End If
        End If
    End Sub

    Private Sub btnDeleteSite_Click(sender As Object, e As EventArgs) Handles btnDeleteSite.Click
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT fstrSiteName, flngCategoryID FROM tblPassword WHERE flngPasswordID = @plngPasswordID"
        cmd.Parameters.AddWithValue("@plngPasswordID", mlngPasswordID)
        Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        If rs.HasRows() Then
            rs.ReadFirst()
            Dim strSiteToDelete As String = rs.GetValue(0)
            Dim strConfirm As String = MsgBox("Are you sure you want to delete data for " & strSiteToDelete & "?", vbYesNo)
            If strConfirm = vbYes Then
                cmd.CommandText = "DELETE FROM tblPassword WHERE flngPasswordID = @plngPasswordID"
                cmd.ExecuteNonQuery()
            End If
        Else
            MsgBox("No item selected to delete.")
        End If
        ClearForm()
        DeleteFromTree(mlngPasswordID, rs.GetValue(1))
    End Sub

    Private Sub ClearForm()
        tbxUsername.Clear()
        tbxPassword.Clear()
        tbxSiteName.Clear()
        tbxURL.Clear()
        rtbNotes.Clear()
    End Sub

    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        Dim lngCategoryID As Int32 = cbxCategory.SelectedValue
        For i As Int32 = 0 To tvwSiteList.Nodes.Count - 1
            If tvwSiteList.Nodes.Item(i).Tag = lngCategoryID Then
                If tvwSiteList.Nodes.Item(i).Nodes.Count <> 0 Then
                    MsgBox("Sites are using this category. Change or delete them before you delete the category.")
                    Exit Sub
                Else
                    Dim strConfirm As String = MsgBox("Are you sure you want to delete this category?", vbYesNo)
                    If strConfirm = vbYes Then
                        tvwSiteList.Nodes.RemoveAt(i)
                        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
                        cmd.CommandText = "DELETE FROM tblCategory WHERE flngCategoryID = @plngCategoryID"
                        cmd.Parameters.AddWithValue("@plngCategoryID", lngCategoryID)
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "SELECT * FROM tblCategory ORDER BY fstrCategory"
                        cbxCategory.DataSource = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
                        PopulateTreeView()
                        Exit Sub
                    End If
                End If
            End If
        Next
    End Sub
End Class
