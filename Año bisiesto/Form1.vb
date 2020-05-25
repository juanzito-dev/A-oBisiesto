Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New Form2
        Module1.nombre = TextBox1.Text

        Dim a, b As String

        b = TextBox1.Text
        a = ""
        If b <> a Then
            f2.Show()
            Me.Hide()
        ElseIf TextBox1.Text = a Then
            MsgBox("Ingrese un nombre")

        End If
    End Sub

End Class
