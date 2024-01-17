Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = ComboBox1.Text

        Select Case grade
            Case "A"
                TextBox1.Text = "High Distinction"
            Case "B"
                TextBox1.Text = "Distinction"
            Case "C"
                TextBox1.Text = "Credit"
            Case "D"
                TextBox1.Text = "Fail"
            Case Else
                TextBox1.Text = "Fail"
        End Select
    End Sub
End Class
