Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New Form2
        Module1.nombre = TextBox1.Text

        Dim vacio, nombre As String

        nombre = TextBox1.Text
        vacio = ""
        If nombre <> vacio Then
            f2.Show()
            Me.Hide()
        ElseIf TextBox1.Text = vacio Then
            MsgBox("Ingrese un nombre")

        End If
    End Sub

End Class
