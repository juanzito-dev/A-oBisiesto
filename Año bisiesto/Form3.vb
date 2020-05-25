Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim a, b As String
        a = Module1.nombre
        b = Module1.año
        Label1.Text = "¡BIENVENIDO " & a + "!"
        TextBox2.Text = b

        If b Mod 4 = 0 And b Mod 100 <> 0 Or b Mod 400 = 0 Then
            Label6.ForeColor = Color.Green
            Label6.Text = "¡El año " & b + " es bisiesto!"
        Else
            Label6.ForeColor = Color.Red
            Label6.Text = "¡El año " & b + " no es bisiesto!"
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()
    End Sub
End Class