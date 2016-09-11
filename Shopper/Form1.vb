Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares the variables:
        Dim decClientPurchases As Decimal
        Dim decTotalRewardPoints As Decimal

        'Assigns variable to text box:
        Decimal.TryParse(txtClientPurchases.Text, decClientPurchases)

        'Decision structure:
        Select Case True
            Case rdoBasic.Checked
                If (decClientPurchases < 100) Then
                    decTotalRewardPoints = (decClientPurchases * 0.05)
                    lblTotalPoints.Text = decTotalRewardPoints.ToString("N0")
                ElseIf (decClientPurchases >= 100) Then
                    decTotalRewardPoints = (decClientPurchases * 0.07)
                    lblTotalPoints.Text = decTotalRewardPoints.ToString("N0")
                End If


        End Select
    End Sub
End Class
