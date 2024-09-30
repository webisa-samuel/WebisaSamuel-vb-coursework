Public Class userData
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub userData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim inputAge As Integer = txtAge.Text
        Dim inputName As String = txtName.Text
        Dim inputFavourite As String = txtFavourite.Text
        MessageBox.Show("Name:" & inputName & vbCrLf & "Age:" & inputAge & vbCrLf & "Favourite Color: " & inputFavourite & vbCrLf)

    End Sub

End Class
