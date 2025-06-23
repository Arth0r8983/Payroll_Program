Public Class frmMain

    Private Sub btnSalaried_Click(sender As Object, e As EventArgs) Handles btnSalaried.Click
        Dim frmSalary As New frmSalaryPayroll

        frmSalary.ShowDialog()

        MessageBox.Show("Thanks for filling out the salary payroll")

    End Sub

    Private Sub btnHourly_Click(sender As Object, e As EventArgs) Handles btnHourly.Click
        Dim frmHourly As New frmHourlyPayroll

        frmHourly.ShowDialog()

        MessageBox.Show("Thanks for filling out the hourly payroll")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub HourlyEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourlyEmployeeToolStripMenuItem.Click
        Dim frmHourly As New frmHourlyPayroll

        frmHourly.ShowDialog()

        MessageBox.Show("Thanks for filling out the hourly payroll")
    End Sub

    Private Sub SalaryEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryEmployeeToolStripMenuItem.Click
        Dim frmSalary As New frmSalaryPayroll

        frmSalary.ShowDialog()

        MessageBox.Show("Thanks for filling out the salary payroll")
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()

    End Sub

    Private Sub btnDailyTotals_Click(sender As Object, e As EventArgs) Handles btnDailyTotals.Click
        MessageBox.Show("Daily Gross Totals:" & dblDailyTotalOfGrossPay.ToString("c") & vbCr & "Daily Net Totals: " & dblDailyTotalOfNetPay.ToString("c"))
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Daily Gross Totals:" & dblDailyTotalOfGrossPay.ToString("c") & vbCr & "Daily Net Totals: " & dblDailyTotalOfNetPay.ToString("c"))
    End Sub
End Class
