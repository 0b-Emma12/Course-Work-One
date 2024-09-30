Public Class Form1
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer = txtEnterMarks.Text
        If Integer.TryParse(txtEnterMarks.Text, marks) Then

            If marks > 100 Then
                MessageBox.Show("Wrong entry, Please re-enter the mark.")
                txtEnterMarks.Clear()
                txtEnterMarks.Focus()


            ElseIf marks >= 90 AndAlso marks <= 100 Then
                txtGrade.Text = "Excellent"
            ElseIf marks >= 80 AndAlso marks <= 89 Then
                txtGrade.Text = "Very Good"
            ElseIf marks >= 70 AndAlso marks <= 79 Then
                txtGrade.Text = "Good"
            ElseIf marks >= 60 AndAlso marks <= 69 Then
                txtGrade.Text = "Medium"
            ElseIf marks >= 50 AndAlso marks <= 59 Then
                txtGrade.Text = "Pass"
            ElseIf marks >= 0 AndAlso marks <= 49 Then
                txtGrade.Text = "Fail"

            End If



        End If



    End Sub
End Class
