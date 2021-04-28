Public Class TestPlugin
    Dim Test As String
    Public Function CountIndicator(ByVal Count As Integer, ByRef Message As String)
        If Count = 100 Then
            Message = "Percent"
        ElseIf Count > 120 Then
            Message = "Slightly Higher"
        Else
            Message = "Above"
        End If
    End Function
End Class
