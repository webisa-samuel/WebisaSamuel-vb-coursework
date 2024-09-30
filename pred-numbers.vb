Public Class predictNumber
    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        Dim number As Decimal = txtInput.Text

        If number > 0 Then
            MessageBox.Show("Positive Number")
        ElseIf number = 0 Then
            MessageBox.Show("Zero")
        Else
            MessageBox.Show("Negative Number")
        End If

    End Sub
End Class
