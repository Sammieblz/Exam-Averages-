Public Class Form1
    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculate the average of the three scores
        Dim score1 As Double = CDbl(txtScore1.Text)
        Dim score2 As Double = CDbl(txtScore2.Text)
        Dim score3 As Double = CDbl(txtScore3.Text)
        Dim average As Double = (score1 + score2 + score3) / 3

        'Display the average in the label box
        lblAvg.Text = average.ToString("F2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text in the text boxes and label box
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore1.KeyPress, txtScore2.KeyPress, txtScore3.KeyPress
        'Allow only numeric input and the backspace key
        If (Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub


End Class
