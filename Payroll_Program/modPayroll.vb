Module modPayroll
    Public dblDailyTotalOfGrossPay As Double
    Public dblDailyTotalOfNetPay As Double
    Public Function Calculate_FICA(ByVal dblGrossPay As Double, ByVal dblCumulativeYearlyGrossPay As Double) As Double
        Dim dblSocialSecurity As Double
        Dim dblMedicare As Double

        dblSocialSecurity = Calculate_Social_Security(dblGrossPay, dblCumulativeYearlyGrossPay)
        dblMedicare = Calculate_Medicare(dblGrossPay)

        Return dblSocialSecurity + dblMedicare
    End Function

    Public Function Calculate_Social_Security(ByVal dblGrossPay As Double, ByVal dblCumulativeYearlyGrossPay As Double) As Double
        Dim dblSocialSecurity As Double

        If dblCumulativeYearlyGrossPay > 125000 Then
            dblSocialSecurity = 0
        Else
            If dblCumulativeYearlyGrossPay + dblGrossPay < 125000 Then
                dblSocialSecurity = dblGrossPay * 0.062
            Else
                If dblCumulativeYearlyGrossPay < 125000 And dblCumulativeYearlyGrossPay + dblGrossPay > 125000 Then
                    dblSocialSecurity = (125000 - dblCumulativeYearlyGrossPay) * 0.062
                End If
            End If
        End If

        Return dblSocialSecurity
    End Function

    Public Function Calculate_Medicare(ByVal dblGrossPay As Double) As Double
        Dim dblMedicare As Double

        dblMedicare = 0.0145 * dblGrossPay

        Return dblMedicare
    End Function

    Public Function Calculate_Federal_Taxes(ByVal dblGrossPay As Double)
        Dim dblFederalTaxes As Double

        If dblGrossPay < 51 Then
            dblFederalTaxes = 0
        Else
            If dblGrossPay > 50 And dblGrossPay < 501 Then
                dblFederalTaxes = (dblGrossPay - 50) * 0.1
            Else
                If dblGrossPay > 500 And dblGrossPay < 2501 Then
                    dblFederalTaxes = 45 + (dblGrossPay - 500) * 0.15
                Else
                    If dblGrossPay > 2500 And dblGrossPay < 5001 Then
                        dblFederalTaxes = 345 + (dblGrossPay - 2500) * 0.2
                    Else
                        If dblGrossPay > 5000 Then
                            dblFederalTaxes = 845 + (dblGrossPay - 5000) * 0.25
                        End If
                    End If
                End If
            End If
        End If

        Return dblFederalTaxes
    End Function

    Public Function Calculate_Net_Pay(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTaxes As Double, ByVal dblFederalTaxes As Double)

        Return dblGrossPay - dblFICA - dblStateTaxes - dblFederalTaxes

    End Function

    Public Function Calculate_Daily_Total_Of_Gross_Pay(ByVal dblGrossPay As Double)
        Return dblDailyTotalOfGrossPay + dblGrossPay
    End Function

    Public Function Calculate_Daily_Total_Of_Net_Pay(ByVal dblNetPay As Double)
        Return dblDailyTotalOfNetPay + dblNetPay
    End Function


End Module
