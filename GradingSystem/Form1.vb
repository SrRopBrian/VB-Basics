Public Class GradingSystem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CheckGrade.Click
        Try
            Dim marks As Decimal
            If Decimal.TryParse(Marksdata.Text, marks) Then
                Console.WriteLine("Conversion Successful.")
            Else
                MessageBox.Show("Error! Please enter valid marks!")
            End If

            If marks > 100 Then
                MessageBox.Show("Error! Please enter valid marks (out of 100)!")
            ElseIf marks >= 75 Then
                MessageBox.Show("Way to go! You scored an A!")
            ElseIf marks >= 65 Then
                MessageBox.Show("Great! You scored a B!")
            ElseIf marks >= 50 Then
                MessageBox.Show("Keep on at it. You scored a C.")
            Else
                MessageBox.Show("You had a Fail. Try harder next time.")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred." & ex.Message)
        Finally
            Marksdata.Clear()
        End Try
    End Sub

    Private Sub GradingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
