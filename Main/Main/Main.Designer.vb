Imports System.Data.SqlServerCe

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tvwSiteList = New System.Windows.Forms.TreeView()
        Me.btnSaveSite = New System.Windows.Forms.Button()
        Me.btnDeleteSite = New System.Windows.Forms.Button()
        Me.btnAddSite = New System.Windows.Forms.Button()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.tbxURL = New System.Windows.Forms.TextBox()
        Me.tbxSiteName = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblSiteName = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.btnNewCategory = New System.Windows.Forms.Button()
        Me.btnDeleteCategory = New System.Windows.Forms.Button()
        Me.btnShowHide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tvwSiteList
        '
        Me.tvwSiteList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvwSiteList.HideSelection = False
        Me.tvwSiteList.Location = New System.Drawing.Point(12, 12)
        Me.tvwSiteList.Name = "tvwSiteList"
        Me.tvwSiteList.Size = New System.Drawing.Size(299, 551)
        Me.tvwSiteList.TabIndex = 11
        '
        'btnSaveSite
        '
        Me.btnSaveSite.Location = New System.Drawing.Point(494, 12)
        Me.btnSaveSite.Name = "btnSaveSite"
        Me.btnSaveSite.Size = New System.Drawing.Size(105, 22)
        Me.btnSaveSite.TabIndex = 2
        Me.btnSaveSite.Text = "Save Site"
        Me.btnSaveSite.UseVisualStyleBackColor = True
        '
        'btnDeleteSite
        '
        Me.btnDeleteSite.Location = New System.Drawing.Point(605, 12)
        Me.btnDeleteSite.Name = "btnDeleteSite"
        Me.btnDeleteSite.Size = New System.Drawing.Size(105, 22)
        Me.btnDeleteSite.TabIndex = 3
        Me.btnDeleteSite.Text = "Delete Site"
        Me.btnDeleteSite.UseVisualStyleBackColor = True
        '
        'btnAddSite
        '
        Me.btnAddSite.Location = New System.Drawing.Point(383, 12)
        Me.btnAddSite.Name = "btnAddSite"
        Me.btnAddSite.Size = New System.Drawing.Size(105, 22)
        Me.btnAddSite.TabIndex = 1
        Me.btnAddSite.Text = "Add New Site"
        Me.btnAddSite.UseVisualStyleBackColor = True
        '
        'tbxUsername
        '
        Me.tbxUsername.Location = New System.Drawing.Point(386, 128)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(324, 20)
        Me.tbxUsername.TabIndex = 8
        '
        'tbxURL
        '
        Me.tbxURL.Location = New System.Drawing.Point(386, 102)
        Me.tbxURL.Name = "tbxURL"
        Me.tbxURL.Size = New System.Drawing.Size(324, 20)
        Me.tbxURL.TabIndex = 7
        '
        'tbxSiteName
        '
        Me.tbxSiteName.Location = New System.Drawing.Point(386, 50)
        Me.tbxSiteName.Name = "tbxSiteName"
        Me.tbxSiteName.Size = New System.Drawing.Size(324, 20)
        Me.tbxSiteName.TabIndex = 4
        '
        'tbxPassword
        '
        Me.tbxPassword.Location = New System.Drawing.Point(386, 154)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword.Size = New System.Drawing.Size(269, 20)
        Me.tbxPassword.TabIndex = 9
        '
        'rtbNotes
        '
        Me.rtbNotes.Location = New System.Drawing.Point(386, 191)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(321, 190)
        Me.rtbNotes.TabIndex = 10
        Me.rtbNotes.Text = ""
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(345, 194)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 23
        Me.lblNotes.Text = "Notes"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(327, 157)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(325, 131)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 21
        Me.lblUsername.Text = "Username"
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(351, 105)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(29, 13)
        Me.lblURL.TabIndex = 20
        Me.lblURL.Text = "URL"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(331, 79)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 19
        Me.lblCategory.Text = "Category"
        '
        'lblSiteName
        '
        Me.lblSiteName.AutoSize = True
        Me.lblSiteName.Location = New System.Drawing.Point(324, 53)
        Me.lblSiteName.Name = "lblSiteName"
        Me.lblSiteName.Size = New System.Drawing.Size(56, 13)
        Me.lblSiteName.TabIndex = 18
        Me.lblSiteName.Text = "Site Name"
        '
        'cbxCategory
        '
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(386, 76)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(213, 21)
        Me.cbxCategory.TabIndex = 5
        '
        'btnNewCategory
        '
        Me.btnNewCategory.Location = New System.Drawing.Point(605, 75)
        Me.btnNewCategory.Name = "btnNewCategory"
        Me.btnNewCategory.Size = New System.Drawing.Size(41, 22)
        Me.btnNewCategory.TabIndex = 6
        Me.btnNewCategory.Text = "New"
        Me.btnNewCategory.UseVisualStyleBackColor = True
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.Location = New System.Drawing.Point(652, 75)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(58, 22)
        Me.btnDeleteCategory.TabIndex = 24
        Me.btnDeleteCategory.Text = "Delete"
        Me.btnDeleteCategory.UseVisualStyleBackColor = True
        '
        'btnShowHide
        '
        Me.btnShowHide.Location = New System.Drawing.Point(664, 153)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.Size = New System.Drawing.Size(45, 20)
        Me.btnShowHide.TabIndex = 25
        Me.btnShowHide.Text = "Show"
        Me.btnShowHide.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 575)
        Me.Controls.Add(Me.btnShowHide)
        Me.Controls.Add(Me.btnDeleteCategory)
        Me.Controls.Add(Me.btnNewCategory)
        Me.Controls.Add(Me.cbxCategory)
        Me.Controls.Add(Me.tvwSiteList)
        Me.Controls.Add(Me.btnSaveSite)
        Me.Controls.Add(Me.btnDeleteSite)
        Me.Controls.Add(Me.btnAddSite)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.tbxURL)
        Me.Controls.Add(Me.tbxSiteName)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.rtbNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblSiteName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Claviger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvwSiteList As System.Windows.Forms.TreeView
    Friend WithEvents btnSaveSite As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSite As System.Windows.Forms.Button
    Friend WithEvents btnAddSite As System.Windows.Forms.Button
    Friend WithEvents tbxUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbxURL As System.Windows.Forms.TextBox
    Friend WithEvents tbxSiteName As System.Windows.Forms.TextBox
    Friend WithEvents tbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblSiteName As System.Windows.Forms.Label
    Friend WithEvents cbxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewCategory As System.Windows.Forms.Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT flngCategoryID, fstrCategory FROM tblCategory ORDER BY fstrCategory"
        Dim rsCategories As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable Or ResultSetOptions.Sensitive)

        Me.cbxCategory.DataSource = rsCategories
        Me.cbxCategory.DisplayMember = "fstrCategory"
        Me.cbxCategory.ValueMember = "flngCategoryID"

        PopulateTreeView()
    End Sub

    Friend Sub PopulateTreeView()
        tvwSiteList.Nodes.Clear()
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT flngCategoryID, fstrCategory FROM tblCategory ORDER BY fstrCategory"
        Dim rsCategories As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable Or ResultSetOptions.Sensitive)

        cmd.CommandText = "SELECT flngCategoryID, fstrSiteName, flngPasswordID FROM tblPassword"
        Dim rsSiteCategories As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        While rsCategories.Read()
            Dim strNode As String = rsCategories.GetValue(1)
            Dim lngCurrentCategoryID As Int32 = rsCategories.GetValue(0)
            Dim nod As TreeNode
            nod = Me.tvwSiteList.Nodes.Add(strNode)
            nod.Tag = lngCurrentCategoryID
            If rsSiteCategories.ReadFirst() Then
                Do
                    Dim lngThisCategoryID As Int32 = Int(rsSiteCategories.GetValue(0))
                    Dim strThisSite As String = rsSiteCategories.GetValue(1)
                    If lngCurrentCategoryID = lngThisCategoryID Then
                        Dim nodChild As TreeNode = nod.Nodes.Add(strThisSite)
                        nodChild.Tag = Int(rsSiteCategories.GetValue(2))
                    End If
                Loop While rsSiteCategories.Read()
            End If
        End While
    End Sub

    Friend Sub InsertIntoTree(plngPasswordID As Int32)
        Dim cmd As SqlCeCommand = My.Application.cnn.CreateCommand()
        cmd.CommandText = "SELECT fstrSiteName, flngCategoryID FROM tblPassword WHERE flngPasswordID = @plngPasswordID"
        cmd.Parameters.AddWithValue("@plngPasswordID", plngPasswordID)
        Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        Dim lngCategoryID As Int32 = 0
        Dim strSiteName As String = ""
        If rs.HasRows() Then
            rs.ReadFirst()
            strSiteName = rs.GetValue(0)
            lngCategoryID = rs.GetValue(1)
        Else
            Exit Sub
        End If
        Dim nodCategory As TreeNode = Nothing
        For i As Int32 = 0 To tvwSiteList.Nodes.Count - 1
            If tvwSiteList.Nodes.Item(i).Tag = lngCategoryID Then
                nodCategory = tvwSiteList.Nodes.Item(i)
                Exit For
            End If
        Next
        For i As Int32 = 0 To nodCategory.Nodes.Count - 1
            If nodCategory.Nodes.Item(i).Tag = plngPasswordID Then
                Exit Sub
            End If
        Next
        If nodCategory IsNot Nothing Then
            Dim nod As TreeNode = nodCategory.Nodes.Add(strSiteName)
            nod.Tag = plngPasswordID
        End If
    End Sub

    Friend Sub DeleteFromTree(plngPasswordID As Int32, plngCategoryID As Int32)
        Dim nodCategory As TreeNode = Nothing
        Dim nodSite As TreeNode = Nothing
        For i As Int32 = 0 To tvwSiteList.Nodes.Count - 1
            If tvwSiteList.Nodes.Item(i).Tag = plngCategoryID Then
                nodCategory = tvwSiteList.Nodes.Item(i)
                Exit For
            End If
        Next
        For i As Int32 = 0 To nodCategory.Nodes.Count - 1
            If nodCategory.Nodes.Item(i).Tag = plngPasswordID Then
                nodCategory.Nodes.RemoveAt(i)
                Exit For
            End If
        Next

    End Sub
    Friend WithEvents btnDeleteCategory As System.Windows.Forms.Button
    Friend WithEvents btnShowHide As System.Windows.Forms.Button
End Class
