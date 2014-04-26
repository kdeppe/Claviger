Public Class SignIn
    Friend mblnClick As Boolean = False
    Friend mblnCancel As Boolean = False

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        mblnClick = True
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        mblnClick = True
        mblnCancel = True
    End Sub
End Class