Public Class Form2

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String
        a = Module1.nombre
        Label3.Text = "¡BIENVENIDO " & a + "!"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New Form3
        Module1.año = Año.Text

        Dim a, b As String

        b = Año.Text
        a = ""
        If b <> a Then
            f3.Show()
            Me.Hide()
        ElseIf Año.Text = a Then
            MsgBox("Ingrese un Año")

        End If
    End Sub
End Class