Imports Microsoft.VisualBasic

Public Class FullTimeEmployee
    Inherits Employee

    Public Sub New(name As String, id As Integer, salary As Decimal)
        MyBase.New(name, id, salary * 12)
    End Sub

    Public Overrides Function GetDetails() As String
        Return $"Full-Time Employee - {MyBase.GetDetails()}"
    End Function
End Class
