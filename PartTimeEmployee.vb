Imports Microsoft.VisualBasic

Public Class PartTimeEmployee
    Inherits Employee

    ' خصائص إضافية للموظف بدوام جزئي
    Public Property HourlyRate As Decimal
    Public Property HoursWorked As Integer

    ' المُنشئ (Constructor)
    Public Sub New(name As String, id As Integer, hourlyRate As Decimal, hoursWorked As Integer)
        MyBase.New(name, id, hourlyRate * hoursWorked)
        Me.HourlyRate = hourlyRate
        Me.HoursWorked = hoursWorked
    End Sub

    ' تجاوز طريقة عرض التفاصيل
    Public Overrides Function GetDetails() As String
        Return $"Part-Time Employee - Name: {Name}, ID: {ID}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}, Total Salary: {Salary:C}"
    End Function
End Class
