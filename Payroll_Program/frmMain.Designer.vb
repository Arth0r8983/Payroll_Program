<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSalaried = New System.Windows.Forms.Button()
        Me.btnHourly = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeeTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourlyEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDailyTotals = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalaried
        '
        Me.btnSalaried.Location = New System.Drawing.Point(37, 87)
        Me.btnSalaried.Name = "btnSalaried"
        Me.btnSalaried.Size = New System.Drawing.Size(149, 71)
        Me.btnSalaried.TabIndex = 0
        Me.btnSalaried.Text = "Salaried Employee"
        Me.btnSalaried.UseVisualStyleBackColor = True
        '
        'btnHourly
        '
        Me.btnHourly.Location = New System.Drawing.Point(224, 87)
        Me.btnHourly.Name = "btnHourly"
        Me.btnHourly.Size = New System.Drawing.Size(149, 71)
        Me.btnHourly.TabIndex = 1
        Me.btnHourly.Text = "Hourly Employee"
        Me.btnHourly.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 189)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 71)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeTypeToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(420, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeeTypeToolStripMenuItem
        '
        Me.EmployeeTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HourlyEmployeeToolStripMenuItem, Me.SalaryEmployeeToolStripMenuItem})
        Me.EmployeeTypeToolStripMenuItem.Name = "EmployeeTypeToolStripMenuItem"
        Me.EmployeeTypeToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.EmployeeTypeToolStripMenuItem.Text = "Employee Type"
        '
        'HourlyEmployeeToolStripMenuItem
        '
        Me.HourlyEmployeeToolStripMenuItem.Name = "HourlyEmployeeToolStripMenuItem"
        Me.HourlyEmployeeToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.HourlyEmployeeToolStripMenuItem.Text = "Hourly Employee"
        '
        'SalaryEmployeeToolStripMenuItem
        '
        Me.SalaryEmployeeToolStripMenuItem.Name = "SalaryEmployeeToolStripMenuItem"
        Me.SalaryEmployeeToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.SalaryEmployeeToolStripMenuItem.Text = "Salary Employee"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ExitToolStripMenuItem.Text = "Daily Totals"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'btnDailyTotals
        '
        Me.btnDailyTotals.Location = New System.Drawing.Point(37, 189)
        Me.btnDailyTotals.Name = "btnDailyTotals"
        Me.btnDailyTotals.Size = New System.Drawing.Size(149, 71)
        Me.btnDailyTotals.TabIndex = 4
        Me.btnDailyTotals.Text = "Daily Totals"
        Me.btnDailyTotals.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 311)
        Me.Controls.Add(Me.btnDailyTotals)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHourly)
        Me.Controls.Add(Me.btnSalaried)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Payroll"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalaried As Button
    Friend WithEvents btnHourly As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeeTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourlyEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDailyTotals As Button
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
