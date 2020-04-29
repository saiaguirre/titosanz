﻿Public Class loginForm


    Private Sub contrasenaText_KeyDown(sender As Object, e As KeyEventArgs) Handles contrasenaText.KeyDown
        If e.KeyCode = Keys.Enter Then
            aceptarButton_Click("", e)
        End If
    End Sub

    Private Sub registrarseLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registrarseLinkLabel.LinkClicked
        frmRegistro.Show()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub aceptarButton_Click(sender As Object, e As EventArgs) Handles aceptarButton.Click
        Dim nombre, apellido, dni, fecha, correo, password, usuario As String
        Dim usuarioEncontrado As Boolean
        usuarioEncontrado = False
        If usuarioText.Text = "" Or contrasenaText.Text = "" Then
            MsgBox("Rellene los campos")
        Else
            FileOpen(1, "datos.txt", OpenMode.Input)
            While Not EOF(1)
                Input(1, usuario)
                Input(1, password)
                Input(1, nombre)
                Input(1, apellido)
                Input(1, dni)
                Input(1, correo)
                Input(1, fecha)
                If usuarioText.Text = usuario And contrasenaText.Text = password Then
                    MsgBox("Iniciado Correctamente")
                    usuarioEncontrado = True
                    Dim frmCompraVenta As New frmCompraVenta

                    frmCompraVenta.Show()
                End If
            End While
            FileClose()
            If usuarioEncontrado = False Then
                MsgBox("Usuario no encontrado")
            End If
        End If
    End Sub

    Private Sub usuarioText_KeyDown(sender As Object, e As KeyEventArgs) Handles usuarioText.KeyDown
        If e.KeyCode = Keys.Enter Then
            aceptarButton_Click("", e)
        End If
    End Sub
End Class
