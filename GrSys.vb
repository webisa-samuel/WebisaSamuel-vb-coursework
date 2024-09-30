Public Class gradingSystem1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim marks As Decimal
        If Not Decimal.TryParse(txtMarks.Text, marks) Then
            MessageBox.Show("please enter valid number")
        End If
        If marks > 100 Then
            MessageBox.Show("please enter marks between 0 and 100 ")
        End If
        Select Case marks
            Case 90 To 100
                txtGrade.Text = "Excellent"
            Case 80 To 89
                txtGrade.Text = "Invalid Marks"
            Case 70 To 79
                txtGrade.Text = "Good"
            Case 60 To 69
                txtGrade.Text = "Medium"
            Case 50 To 59
                txtGrade.Text = "Pass"
            Case 0 To 49
                txtGrade.Text = "Fail"
            Case Else
                txtGrade.Text = "Invalid Marks"


        End Select

    End Sub
End Class
