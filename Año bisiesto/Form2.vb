Public Class Form2

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Nombre As String
        Nombre = Module1.nombre
        Label3.Text = "¡BIENVENIDO " & Nombre + "!"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New Form3
        Module1.año = Año.Text

        Dim vacio, añoin As String

        añoin = Año.Text
        vacio = ""
        If añoin <> vacio Then
            f3.Show()
            Me.Hide()
        ElseIf Año.Text = vacio Then
            MsgBox("Ingrese un Año")

        End If
    End Sub
End Class