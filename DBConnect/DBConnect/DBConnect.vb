Public Class DBConnect

    Public Function ExecuteSelect(ByVal pstrConnectString As String,
                                  ByVal pstrQueryText As String,
                                  ByVal pstrParameters As Dictionary(Of String, String)) As DataTable
        Dim cnn As New SqlClient.SqlConnection
        cnn.ConnectionString = pstrConnectString
        Dim strQuery As String
        If pstrParameters.Count = 0 Then
            strQuery = pstrQueryText
        Else
            strQuery = BuildQuery(pstrQueryText, pstrParameters)
        End If
        Dim com As New SqlClient.SqlCommand(strQuery, cnn)

    End Function

    Public Function ExecuteModify(ByVal pstrConnectString As String,
                                  ByVal pstrQueryText As String,
                                  ByVal ParamArray pstrParameters() As String) As Int32

    End Function

    Private Function BuildQuery(ByVal pstrQueryText As String,
                                ByVal pstrParameters As Dictionary(Of String, String)) As String
        pstrQueryText.IndexOf()
    End Function
End Class
