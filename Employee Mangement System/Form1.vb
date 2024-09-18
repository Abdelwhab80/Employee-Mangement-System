Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblResults.Click

    End Sub

    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click
        Dim name As String = txtName.Text
        Dim id As Integer
        Dim salary As Decimal
        Dim hourlyRate As Decimal
        Dim hoursWorked As Decimal

        Try
            id = Convert.ToInt32(txtID.Text)
            salary = nudSalary.Value
            hourlyRate = nudHourlyRate.Value
            hoursWorked = Hours.Value
        Catch ex As Exception
            MessageBox.Show("Please enter valid values.")
            Exit Sub
        End Try

        Dim employee As Employee
        If rdoFullTime.Checked Then
            employee = New FullTimeEmployee(name, id, salary)
        ElseIf rdoPartTime.Checked Then
            employee = New PartTimeEmployee(name, id, hourlyRate, hoursWorked)
        Else
            MessageBox.Show("Please select employee type.")
            Exit Sub
        End If

        lblResults.Text = employee.GetDetails()
    End Sub

End Class
