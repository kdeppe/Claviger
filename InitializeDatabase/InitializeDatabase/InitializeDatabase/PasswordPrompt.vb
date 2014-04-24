Imports System.Windows.Forms

Public Class PasswordPrompt
    Friend mstrPassword1 As String
    Friend mstrPassword2 As String
    Friend mstrUsername As String
    Friend mblnClick As Boolean

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        mstrPassword1 = tbxPassword1.Text
        mstrPassword2 = tbxPassword2.Text
        mstrUsername = tbxUsername.Text
        tbxPassword1.Clear()
        tbxPassword2.Clear()
        tbxUsername.Clear()
        Me.Hide()
        mblnClick = True
    End Sub
End Class