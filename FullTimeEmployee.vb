Imports Microsoft.VisualBasic

Public Class FullTimeEmployee
    Inherits Employee

    ' المُنشئ (Constructor)
    Public Sub New(name As String, id As Integer, salary As Decimal)
        MyBase.New(name, id, salary)
    End Sub

    ' تجاوز طريقة عرض التفاصيل
    Public Overrides Function GetDetails() As String
        Return $"Full-Time Employee - {MyBase.GetDetails()}"
    End Function
End Class
