Public Class multiplicationTable
    Private Sub multiplicationTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize an empty string to store the table
        Dim table As String = ""

        ' Outer loop for rows (1 to 10)
        For i As Integer = 1 To 10
            ' Inner loop for columns (1 to 10)
            For j As Integer = 1 To 10
                ' Calculate the product and add it to the table with tab spacing
                table &= (i * j).ToString().PadLeft(4) & " "
            Next
            ' Add a new line after each row
            table &= Environment.NewLine
        Next

        ' Display the multiplication table in one message box
        MessageBox.Show(table, "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
