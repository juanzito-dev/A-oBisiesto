Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nombrein, añoin As String
        nombrein = Module1.nombre
        añoin = Module1.año
        Label1.Text = "¡BIENVENIDO " & nombrein + "!"
        TextBox2.Text = añoin

        If añoin Mod 4 = 0 And añoin Mod 100 <> 0 Or añoin Mod 400 = 0 Then
            Label6.ForeColor = Color.Green
            Label6.Text = "¡El año " & añoin + " es bisiesto!"
        Else
            Label6.ForeColor = Color.Red
            Label6.Text = "¡El año " & añoin + " no es bisiesto!"
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()
    End Sub
End Class