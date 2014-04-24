Imports System.Data.SqlServerCe
Imports System.IO

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
            Prompt.Focus()
            Prompt.tbxPassword1.Focus()
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

            cmd.CommandText = "CREATE TABLE tblPassword (flngPasswordID bigint, flngSiteID bigint, flngCategoryID bigint, fstrUsername ntext, fstrPassword ntext, fstrNote ntext)"
            Console.WriteLine(cmd.ExecuteNonQuery())

            cmd.CommandText = "CREATE TABLE tblSite (flngSiteID bigint, fstrName ntext, fstrURL ntext)"
            Console.WriteLine(cmd.ExecuteNonQuery())

            cmd.CommandText = "CREATE TABLE tblCategory (flngCategoryID bigint, fstrCategory ntext)"
            Console.WriteLine(cmd.ExecuteNonQuery())
        Catch
        Finally
            cnn.Close()
        End Try
    End Sub

End Module
