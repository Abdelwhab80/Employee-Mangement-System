Imports Microsoft.VisualBasic

Public Class Employee
    ' الخصائص الأساسية
    Public Property Name As String
    Public Property ID As Integer
    Public Property Salary As Decimal

    ' المُنشئ (Constructor)
    Public Sub New(name As String, id As Integer, salary As Decimal)
        Me.Name = name
        Me.ID = id
        Me.Salary = salary
    End Sub

    ' طريقة عرض التفاصيل - قابلة للتجاوز في الفئات المشتقة
    Public Overridable Function GetDetails() As String
        Return $"Name: {Name}, ID: {ID}, Salary: {Salary:C}"
    End Function
End Class

