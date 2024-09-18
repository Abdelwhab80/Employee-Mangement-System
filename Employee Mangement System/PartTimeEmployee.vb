Public Class PartTimeEmployee
    Inherits Employee

    Public Property HourlyRate As Decimal
    Public Property Hours As Decimal

    Public Sub New(name As String, id As Integer, hourlyRate As Decimal, hours As Decimal)
        MyBase.New(name, id, hourlyRate * hours)
        Me.HourlyRate = hourlyRate
        Me.Hours = hours
    End Sub

    Public Overrides Function GetDetails() As String
        Return $"Part-Time Employee - Name: {Name}, ID: {ID}, Hourly Rate: {HourlyRate:C}, Hours Worked: {Hours}, Total Salary: {Salary:C}"
    End Function
End Class
