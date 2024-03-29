﻿Imports System.Text.RegularExpressions
Imports System.IO


Public Class frmRegistro

    Function IsPasswordValid(password As String) As Boolean
        Dim existeNumero As Boolean
        Dim existeLetraMayuscula As Boolean

        If (password Is Nothing) Then Return False
        If (password.Length < 8) Then Return False
        For Each c As Char In password

            If (Char.IsDigit(c)) Then
                existeNumero = True
                Continue For
            End If

            If (c = c.ToString().ToUpper()) Then
                existeLetraMayuscula = True
            End If
        Next

        Return ((existeNumero) And (existeLetraMayuscula))

    End Function

    Private Sub registrarseButton_Click(sender As Object, e As EventArgs) Handles registrarseButton.Click
        Dim cuentaLineas = File.ReadAllLines("datos.txt").Length
        Dim usuarioExistente, correoExistente, dniExistente As Boolean
        Dim nombre, apellido, dni, correo, password, usuario As String
        Dim x = 0
        Dim errores As String
        Dim Años As Integer
        Dim Edad As Integer
        Dim FechaNac As Date
        Dim day = NacimientoPicker.Value.Day
        Dim diahoy = Today.Day
        Dim isValid As Boolean = IsPasswordValid(contraseñaText.Text)
        Dim saldoP As Integer
        Dim saldoD As Integer


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

            If Not Regex.Match(nombreText.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
                errores &= ("Por favor solo letras en el campo NOMBRE" & vbNewLine)
            End If

            If Not Regex.Match(apellidoText.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
                errores &= ("Por favor solo letras en el campo APELLIDO" & vbNewLine)
            End If

            If Not Regex.IsMatch(Me.correoText.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,63})$") Then
                errores &= ("El correo ingresado no es válido" & vbNewLine)
            End If

            If (Not (isValid)) Or contraseñaText.Text = usuarioText.Text Then
                errores &= ("La contraseña no es suficientemente segura." & vbNewLine)
            End If

            FechaNac = NacimientoPicker.Value
            Años = Year(Now) - Year(FechaNac)
            If Month(Now) < Month(FechaNac) Then Años = Años - 1
            If Month(Now) = Month(FechaNac) And diahoy < day Then Años = Años - 1
            Edad = Años
            If Años < 18 Then errores &= ("Debe ser mayor de edad para registrarse" & vbNewLine)

            While x < cuentaLineas
                FileOpen(1, "datos.txt", OpenMode.Input)
                While Not EOF(1)
                    Input(1, usuario)
                    Input(1, password)
                    Input(1, nombre)
                    Input(1, apellido)
                    Input(1, dni)
                    Input(1, correo)
                    x = x + 1
                    If usuarioText.Text = usuario Then
                        usuarioExistente = True
                    End If

                    If correoText.Text = correo Then
                        correoExistente = True
                    End If

                    If dniText.Text = dni Then
                        dniExistente = True
                    End If
                End While
            End While

            If usuarioExistente = True Then
                errores &= ("El usuario seleccionado ya está registrado." & vbNewLine)
            End If

            If correoExistente = True Then
                errores &= ("El correo seleccionado ya está registrado." & vbNewLine)
            End If

            If dniExistente = True Then
                errores &= ("El DNI seleccionado ya está registrado." & vbNewLine)
            End If

            erroresLabel.Text = errores
            If errores = "" Then
                saldoD = 1000
                saldoP = 100000
                FileOpen(1, "datos.txt", OpenMode.Append)
                WriteLine(1, usuarioText.Text, contraseñaText.Text, nombreText.Text, apellidoText.Text, dniText.Text, correoText.Text, Format(NacimientoPicker.Value, "Short Date"), saldoD, saldoP)
                FileClose()
                If MsgBox("Registrado con exito, ¿desea volver al login?", vbYesNo, "Registro exitoso") = vbYes Then
                    Me.Hide()
                End If
            End If
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
        lblReqContraseña.Text = ""
        erroresLabel.Text = ""
        contraseñaText.UseSystemPasswordChar = True
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

    Private Sub contraseñaText_GotFocus(sender As Object, e As EventArgs) Handles contraseñaText.GotFocus
        lblReqContraseña.Text = ("Recuerde los requisitos de la contraseña:" & vbNewLine &
                                  "1. Debe contener al menos 8 caracteres" & vbNewLine &
                                  "2. Debe contener por lo menos una mayúscula, " & vbNewLine &
                                  "una minúscula y un número" & vbNewLine &
                                  "3. No puede ser igual al nombre de usuario.")
    End Sub

    Private Sub contraseñaText_LostFocus(sender As Object, e As EventArgs) Handles contraseñaText.LostFocus
        lblReqContraseña.Text = ""
    End Sub

    Private Sub dniText_TextChanged(sender As Object, e As EventArgs) Handles dniText.LostFocus
        If dniText.Text = "" Then
            dniText.Text = "SOLO NÚMEROS"
        End If

    End Sub


    Private Sub btnMostrContr_Click(sender As Object, e As EventArgs) Handles btnMostrContr.Click
        If contraseñaText.UseSystemPasswordChar = True Then
            contraseñaText.UseSystemPasswordChar = False
        Else
            contraseñaText.UseSystemPasswordChar = True
        End If
    End Sub

End Class