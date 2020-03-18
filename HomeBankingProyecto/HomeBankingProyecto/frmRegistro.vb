Public Class frmRegistro

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub registrarseButton_Click(sender As Object, e As EventArgs) Handles registrarseButton.Click
        Dim errores As ArrayList = New ArrayList
        If nombreText.TextLength() = 0 Then
            For i As Integer = 0 To nombreText.TextLength()
                If IsNumeric(nombreText.Text(i)) Then
                    errores.Add("No debe poner numeros en el campo nombre")
                    Return
                End If
            Next
        Else
            errores.Add("Debe escribir en el campo Nombre")
        End If
        erroresLabel.Text = errores
    End Sub

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - Me.Width) \ 2
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)
    End Sub
End Class