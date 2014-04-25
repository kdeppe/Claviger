Public Class SignIn
    Friend mblnClick As Boolean = False

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        mblnClick = True
        Me.Hide()
    End Sub
End Class