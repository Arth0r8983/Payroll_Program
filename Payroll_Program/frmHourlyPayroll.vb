Public Class frmHourlyPayroll


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblHoursWorked As Double
        Dim dblHourlyWage As Double
        Dim dblCumulativeYearlyGrossPay As Double

        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTaxes As Double
        Dim dblFederalTaxes As Double
        Dim dblNetPay As Double

        Dim blnValidated As Boolean = True

        Call Get_And_Validate_Input(dblHoursWorked, dblHourlyWage, dblCumulativeYearlyGrossPay, blnValidated)

        If blnValidated = True Then
            Call Calculate_Hourly_Employee_Pay(dblHoursWorked, dblHourlyWage, dblCumulativeYearlyGrossPay, dblGrossPay, dblFICA, dblStateTaxes, dblFederalTaxes, dblNetPay)
            Call Display_Totals(dblGrossPay, dblFICA, dblStateTaxes, dblFederalTaxes, dblNetPay)
        End If

    End Sub



    Private Sub Get_And_Validate_Input(ByRef dblHoursWorked As Double, ByRef dblHourlyWage As Double, ByRef dblCumulativeYearlyGrossPay As Double, ByRef blnValidated As Boolean)
        Call Get_And_Validate_First_Name(blnValidated)
        If blnValidated = True Then
            Call Get_And_Validate_Last_Name(blnValidated)
        End If

        If blnValidated = True Then
            Call Get_And_Validate_Hourly_Wage(dblHourlyWage, blnValidated)
        End If

        If blnValidated = True Then
            Call Get_And_Validate_Hours_Worked(dblHoursWorked, blnValidated)
        End If

        If blnValidated = True Then
            Call Get_And_Validate_Cumulative_Yearly_Gross_Pay(dblCumulativeYearlyGrossPay, blnValidated)
        End If

        If blnValidated = True Then
            Call Get_And_Validate_State(blnValidated)
        End If
    End Sub

    Private Sub Get_And_Validate_First_Name(ByRef blnValidated As Boolean)
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("First Name Must Exist")
            txtFirstName.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Get_And_Validate_Last_Name(ByRef blnValidated As Boolean)
        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Last Name Must Exist")
            txtLastName.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Get_And_Validate_State(ByRef blnValidated As Boolean)
        If cboState.Text = String.Empty Then
            MessageBox.Show("Must Select State")
            cboState.Focus()
            blnValidated = False
            Exit Sub
        End If


    End Sub

    Private Sub Get_And_Validate_Hourly_Wage(ByRef dblHourlyWage As Double, ByRef blnValidated As Boolean)

        If Double.TryParse(txtHourlyWage.Text, dblHourlyWage) Then
            dblHourlyWage = txtHourlyWage.Text
            If dblHourlyWage < 1 Then
                MessageBox.Show("Hourly Wage Must be Greater Than 0")
                txtHourlyWage.Focus()
                blnValidated = False
                Exit Sub
            End If
        Else
            MessageBox.Show("Hourly Wage Must Exist and Must be Numeric")
            txtHourlyWage.Focus()
            blnValidated = False
            Exit Sub
        End If

    End Sub

    Private Sub Get_And_Validate_Hours_Worked(ByRef dblHoursWorked As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtHoursWorked.Text, dblHoursWorked) Then
            dblHoursWorked = txtHoursWorked.Text
            If dblHoursWorked < 1 Then
                MessageBox.Show("Hours Worked Must be Greater Than 0")
                txtHoursWorked.Focus()
                blnValidated = False
                Exit Sub
            End If
        Else
            MessageBox.Show("Hours Worked Must Exist and Must be Numeric")
            txtHoursWorked.Focus()
            blnValidated = False
            Exit Sub
        End If

    End Sub

    Private Sub Get_And_Validate_Cumulative_Yearly_Gross_Pay(ByRef dblCumulativeYearlyGrossPay As Double, ByRef blnValidated As Boolean)

        If Double.TryParse(txtCumulativeYearlyGrossPay.Text, dblCumulativeYearlyGrossPay) Then
            dblCumulativeYearlyGrossPay = txtCumulativeYearlyGrossPay.Text
            If txtCumulativeYearlyGrossPay.Text < 1 Then
                MessageBox.Show("YTD Total Pay Must be Greater Than 0")
                txtCumulativeYearlyGrossPay.Focus()
                blnValidated = False
                Exit Sub
            End If
        Else
            MessageBox.Show("YTD Total Pay Must Exist and be Numeric")
            txtCumulativeYearlyGrossPay.Focus()
            blnValidated = False
            Exit Sub
        End If

    End Sub


    Private Sub Calculate_Hourly_Employee_Pay(ByVal dblHoursWorked As Double, ByVal dblHourlyWage As Double, ByVal dblCumulativeYearlyGrossPay As Double, ByRef dblGrossPay As Double, ByRef dblFICA As Double, ByRef dblStateTaxes As Double, ByRef dblFederalTaxes As Double, ByRef dblNetPay As Double)
        dblGrossPay = Calculate_Gross_Pay(dblHoursWorked, dblHourlyWage)
        dblFICA = Calculate_FICA(dblGrossPay, dblCumulativeYearlyGrossPay)
        dblStateTaxes = Calculate_State_Taxes(dblGrossPay)
        dblFederalTaxes = Calculate_Federal_Taxes(dblGrossPay)
        dblNetPay = Calculate_Net_Pay(dblGrossPay, dblFICA, dblStateTaxes, dblFederalTaxes)
        dblDailyTotalOfGrossPay = Calculate_Daily_Total_Of_Gross_Pay(dblGrossPay)
        dblDailyTotalOfNetPay = Calculate_Daily_Total_Of_Net_Pay(dblNetPay)


    End Sub

    Private Function Calculate_Gross_Pay(ByVal dblHoursWorked As Double, ByVal dblHourlyWage As Double) As Double
        Dim dblGrossPay As Double

        If dblHoursWorked < 41 Then
            dblGrossPay = dblHoursWorked * dblHourlyWage
        Else
            If dblHoursWorked > 40 Then
                dblGrossPay = (dblHourlyWage * 1.5) * (dblHoursWorked - 40) + 40 * dblHourlyWage
            End If
        End If

        Return dblGrossPay

    End Function



    Private Function Calculate_State_Taxes(ByVal dblGrossPay As Double)
        Dim dblStateTaxes As Double

        If cboState.Text = "Ohio" Then
            dblStateTaxes = 0.065 * dblGrossPay
        Else
            If cboState.Text = "Kentucky" Then
                dblStateTaxes = 0.06 * dblGrossPay
            Else
                If cboState.Text = "Indiana" Then
                    dblStateTaxes = 0.055 * dblGrossPay
                End If
            End If
        End If

        Return dblStateTaxes
    End Function





    Private Sub Display_Totals(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTaxes As Double, ByVal dblFederalTaxes As Double, ByVal dblNetPay As Double)

        lblGrossPay.Text = dblGrossPay.ToString("c")
        lblFICA.Text = dblFICA.ToString("c")
        lblStateTaxes.Text = dblStateTaxes.ToString("c")
        lblFederalTaxes.Text = dblFederalTaxes.ToString("c")
        lblNetPay.Text = dblNetPay.ToString("c")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()
        txtCumulativeYearlyGrossPay.Clear()

        cboState.ResetText()

        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTaxes.ResetText()
        lblFederalTaxes.ResetText()
        lblNetPay.ResetText()

        txtFirstName.Focus()

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        Dim dblHoursWorked As Double
        Dim dblHourlyWage As Double
        Dim dblCumulativeYearlyGrossPay As Double

        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTaxes As Double
        Dim dblFederalTaxes As Double
        Dim dblNetPay As Double

        Dim blnValidated As Boolean = True

        Call Get_And_Validate_Input(dblHoursWorked, dblHourlyWage, dblCumulativeYearlyGrossPay, blnValidated)

        If blnValidated = True Then
            Call Calculate_Hourly_Employee_Pay(dblHoursWorked, dblHourlyWage, dblCumulativeYearlyGrossPay, dblGrossPay, dblFICA, dblStateTaxes, dblFederalTaxes, dblNetPay)
            Call Display_Totals(dblGrossPay, dblFICA, dblStateTaxes, dblFederalTaxes, dblNetPay)
        End If

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()
        txtCumulativeYearlyGrossPay.Clear()

        cboState.ResetText()

        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTaxes.ResetText()
        lblFederalTaxes.ResetText()
        lblNetPay.ResetText()

        txtFirstName.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub
End Class