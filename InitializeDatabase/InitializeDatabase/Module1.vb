Imports System.Data.SqlServerCe
Imports System.IO
Imports System.Windows.Forms

Module Module1

    Sub Main()
        Dim blnInvalid As Boolean = True
        Dim strPassword1,
            strPassword2,
            strUsername As String
        Dim Prompt As New PasswordPrompt()
        Prompt.AcceptButton = Prompt.btnOK

        strPassword1 = ""
        strPassword2 = ""
        strUsername = ""
        While blnInvalid
            Prompt.Show()
            Application.DoEvents()
            Prompt.tbxUsername.Focus()
            While Not Prompt.mblnClick
                System.Windows.Forms.Application.DoEvents()
            End While
            Prompt.mblnClick = False
            strUsername = Prompt.mstrUsername
            If File.Exists(strUsername & ".sdf") Then
                MsgBox("Username is already taken.")
                Continue While
            ElseIf strUsername = "" Then
                MsgBox("Username is required.")
                Continue While
            End If
            strPassword1 = Prompt.mstrPassword1
            If strPassword1 = "" Then
                MsgBox("Password is required.")
                Continue While
            End If
            strPassword2 = Prompt.mstrPassword2
            If strPassword1 = strPassword2 Then
                blnInvalid = False
            Else
                MsgBox("Passwords do not match.")
            End If
        End While

        Dim strConnection As String = "datasource = " & strUsername & ".sdf; " &
                                      "password = " & strPassword1 & "; " &
                                      "encryption mode = engine default; " &
                                      "encrypt = true;"

        Dim eng As New SqlCeEngine(strConnection)
        eng.CreateDatabase()
        eng.Dispose()

        Dim cnn As SqlCeConnection = Nothing

        Try
            cnn = New SqlCeConnection(strConnection)
            cnn.Open()

            Dim cmd As SqlCeCommand = cnn.CreateCommand()

            cmd.CommandText = "CREATE TABLE tblPassword (flngPasswordID bigint, fstrSiteName nvarchar(1000), fstrURL nvarchar(1000), flngCategoryID bigint, fstrUsername nvarchar(100), fstrPassword nvarchar(100), fstrNote ntext)"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "CREATE TABLE tblCategory (flngCategoryID bigint, fstrCategory nvarchar(100))"
            cmd.ExecuteNonQuery()
        Catch
        Finally
            cnn.Close()
        End Try
    End Sub

End Module
