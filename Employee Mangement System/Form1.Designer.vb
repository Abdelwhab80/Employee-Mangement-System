<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.nudSalary = New System.Windows.Forms.NumericUpDown()
        Me.nudHourlyRate = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoPartTime = New System.Windows.Forms.RadioButton()
        Me.rdoFullTime = New System.Windows.Forms.RadioButton()
        Me.btnShowDetails = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Hours = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHourlyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(181, 20)
        Me.txtName.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(135, 59)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(181, 20)
        Me.txtID.TabIndex = 3
        '
        'nudSalary
        '
        Me.nudSalary.Location = New System.Drawing.Point(135, 124)
        Me.nudSalary.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudSalary.Name = "nudSalary"
        Me.nudSalary.Size = New System.Drawing.Size(120, 20)
        Me.nudSalary.TabIndex = 4
        '
        'nudHourlyRate
        '
        Me.nudHourlyRate.Location = New System.Drawing.Point(329, 124)
        Me.nudHourlyRate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHourlyRate.Name = "nudHourlyRate"
        Me.nudHourlyRate.Size = New System.Drawing.Size(120, 20)
        Me.nudHourlyRate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Salary:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hour Rate:"
        '
        'rdoPartTime
        '
        Me.rdoPartTime.AutoSize = True
        Me.rdoPartTime.Location = New System.Drawing.Point(304, 151)
        Me.rdoPartTime.Name = "rdoPartTime"
        Me.rdoPartTime.Size = New System.Drawing.Size(70, 17)
        Me.rdoPartTime.TabIndex = 8
        Me.rdoPartTime.TabStop = True
        Me.rdoPartTime.Text = "Part Time"
        Me.rdoPartTime.UseVisualStyleBackColor = True
        '
        'rdoFullTime
        '
        Me.rdoFullTime.AutoSize = True
        Me.rdoFullTime.Location = New System.Drawing.Point(135, 151)
        Me.rdoFullTime.Name = "rdoFullTime"
        Me.rdoFullTime.Size = New System.Drawing.Size(67, 17)
        Me.rdoFullTime.TabIndex = 9
        Me.rdoFullTime.TabStop = True
        Me.rdoFullTime.Text = "Full Time"
        Me.rdoFullTime.UseVisualStyleBackColor = True
        '
        'btnShowDetails
        '
        Me.btnShowDetails.Location = New System.Drawing.Point(179, 198)
        Me.btnShowDetails.Name = "btnShowDetails"
        Me.btnShowDetails.Size = New System.Drawing.Size(119, 23)
        Me.btnShowDetails.TabIndex = 10
        Me.btnShowDetails.Text = "Show Details"
        Me.btnShowDetails.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(170, 247)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(37, 13)
        Me.lblResults.TabIndex = 11
        Me.lblResults.Text = "Result"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "hours:"
        '
        'Hours
        '
        Me.Hours.Location = New System.Drawing.Point(499, 124)
        Me.Hours.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(120, 20)
        Me.Hours.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnShowDetails)
        Me.Controls.Add(Me.rdoFullTime)
        Me.Controls.Add(Me.rdoPartTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudHourlyRate)
        Me.Controls.Add(Me.nudSalary)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Employee Management"
        CType(Me.nudSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHourlyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents nudSalary As NumericUpDown
    Friend WithEvents nudHourlyRate As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rdoPartTime As RadioButton
    Friend WithEvents rdoFullTime As RadioButton
    Friend WithEvents btnShowDetails As Button
    Friend WithEvents lblResults As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Hours As NumericUpDown
End Class
