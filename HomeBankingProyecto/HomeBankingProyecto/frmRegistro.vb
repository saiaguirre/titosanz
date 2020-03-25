Imports System.Text.RegularExpressions

Public Class frmRegistro

    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function



    Private Sub registrarseButton_Click(sender As Object, e As EventArgs) Handles registrarseButton.Click
        Dim errores As String
        MsgBox(correoText.Text)
        If nombreText.Text = "" Or
           apellidoText.Text = "" Or
           dniText.Text = "" Or dniText.Text = "SOLO NÚMEROS" Or
           correoText.Text = "" Or
           usuarioText.Text = "" Or
           contraseñaText.Text = "" Then
            errores &= ("Rellene todos los campos antes de continuar." & vbNewLine)
            erroresLabel.Text = errores
        Else
            If Not Len(Me.dniText.Text) = 8 Then
                errores &= ("Por favor ingrese un DNI válido" & vbNewLine)
            End If

            If Not Regex.Match(nombreText.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Or nombreText.Text = "" Then
                errores &= ("Por favor solo letras en el campo NOMBRE" & vbNewLine)
            End If

            If Not Regex.Match(nombreText.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Or nombreText.Text = "" Then
                errores &= ("Por favor solo letras en el campo APELLIDO" & vbNewLine)
            End If

            If Not Regex.IsMatch(Me.correoText.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,63})$") Then
                errores &= ("El correo ingresado no es válido" & vbNewLine)
            End If

            erroresLabel.Text = errores

        End If




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
        dniText.Text = "SOLO NÚMEROS"
    End Sub

    Private Sub dniText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dniText.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If

    End Sub

    Private Sub dniText_GotFocus(sender As Object, e As EventArgs) Handles dniText.GotFocus
        If dniText.Text = "SOLO NÚMEROS" Then
            dniText.Text = ""
        End If
    End Sub



End Class