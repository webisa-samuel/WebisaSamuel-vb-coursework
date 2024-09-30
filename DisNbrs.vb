Public Class displayNumbers
    Private Sub displayNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize an empty string to store the numbers
        Dim message As String = " "


        ' Loop through numbers 1 to 10
        For i As Integer = 1 To 10
            ' Append each number to the message string with a new line
            message &= "Number: " & i.ToString() & Environment.NewLine


        Next

        ' Display all numbers in one message box
        MessageBox.Show(message, "Numbers 1 to 10", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If MsgBoxResult.Ok Then
            Me.Hide()


        End If
    End Sub
End Class