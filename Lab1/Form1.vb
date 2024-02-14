Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Click, AddressOf Form1_Click
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Object_Demonstrations()
        newForm.Show()
        Me.Hide()
    End Sub
End Class
