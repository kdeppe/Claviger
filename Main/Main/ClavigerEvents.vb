Imports System.IO
Imports System.Data.SqlServerCe

Namespace My


    Partial Friend Class MyApplication
        Friend cnn As SqlCeConnection

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            cnn.Close()
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim sgn As New SignIn
            Dim blnInvalid As Boolean = True
            sgn.AcceptButton = sgn.btnOK
            sgn.CancelButton = sgn.btnCancel

            While blnInvalid
                sgn.Show()
                sgn.Focus()
                sgn.tbxUsername.Focus()
                While Not sgn.mblnClick
                    System.Windows.Forms.Application.DoEvents()
                End While
                sgn.mblnClick = False
                If sgn.mblnCancel Then
                    sgn.Dispose()
                    e.Cancel = True
                    Exit Sub
                End If
                If Not File.Exists(sgn.tbxUsername.Text & ".sdf") Then
                    MsgBox("Username does not exist.")
                    Continue While
                Else
                    blnInvalid = False
                End If
            End While

            cnn = New SqlCeConnection("datasource = " & sgn.tbxUsername.Text & ".sdf; " &
                                           "password = " & sgn.tbxPassword.Text)
            sgn.tbxPassword.Clear()

            Do
                Try
                    cnn.Open()
                    blnInvalid = False
                    sgn.Dispose()
                Catch ex As SqlCeException
                    blnInvalid = True
                    MsgBox("Database connection error: " & ex.Message)
                    If ex.ErrorCode = -2147467259 Then
                        While blnInvalid
                            sgn.Show()
                            sgn.Focus()
                            sgn.tbxUsername.Focus()
                            While Not sgn.mblnClick
                                System.Windows.Forms.Application.DoEvents()
                            End While
                            sgn.mblnClick = False
                            If Not File.Exists(sgn.tbxUsername.Text & ".sdf") Then
                                MsgBox("Username does not exist.")
                                Continue While
                            Else
                                blnInvalid = False
                            End If
                        End While
                        blnInvalid = True
                        cnn.ConnectionString = "datasource = " & sgn.tbxUsername.Text & ".sdf; " &
                                               "password = " & sgn.tbxPassword.Text
                        sgn.tbxPassword.Clear()
                    End If
                    cnn.Close()
                End Try
            Loop While blnInvalid
        End Sub
    End Class


End Namespace

