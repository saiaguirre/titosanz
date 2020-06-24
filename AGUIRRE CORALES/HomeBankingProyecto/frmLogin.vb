Imports System
Imports System.IO.File
Imports System.Collections
Imports System.IO

Public Class loginForm


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
        Dim nombre, apellido, dni, fecha, correo, password, usuario, saldoP, saldoD As String
        Dim usuarioEncontrado As Boolean
        Dim cuentaLineas = File.ReadAllLines("datos.txt").Length
        Dim x = 0
        usuarioEncontrado = False

        If usuarioText.Text = "" Or contrasenaText.Text = "" Then
            MsgBox("Rellene los campos")
        Else
            While x < cuentaLineas
                FileOpen(1, "datos.txt", OpenMode.Input)
                While Not EOF(1)
                    Input(1, usuario)
                    Input(1, password)
                    Input(1, nombre)
                    Input(1, apellido)
                    Input(1, dni)
                    Input(1, correo)
                    Input(1, fecha)
                    Input(1, saldoD)
                    Input(1, saldoP)
                    x = x + 1
                    If usuarioText.Text = usuario And contrasenaText.Text = password Then  ' And contrasenaText.Text = password
                        usuarioEncontrado = True
                    Else
                        MsgBox("Los datos ingresados no son correctos")
                        usuarioText.Text = ""
                        contrasenaText.Text = ""
                    End If
                End While
            End While
            If usuarioEncontrado = True Then
                MsgBox("Iniciado correctamente")
                Dim frmCompraVenta As New frmCompraVenta
                frmCompraVenta.lblSaldoD.Text = saldoD
                frmCompraVenta.lblSaldoP.Text = saldoP
                frmCompraVenta.lblapellido.Text = apellido
                frmCompraVenta.lblUsuarioM.Text = usuario
                frmCompraVenta.lblContraseñaM.Text = password
                frmCompraVenta.lblnombreM.Text = nombre
                frmCompraVenta.lblDNIM.Text = dni
                frmCompraVenta.lblCorreoM.Text = correo
                frmCompraVenta.lblFechaNacM.Text = fecha
                frmCompraVenta.Show()
            End If
        End If
        FileClose(1)

    End Sub

    Private Sub usuarioText_KeyDown(sender As Object, e As KeyEventArgs) Handles usuarioText.KeyDown
        If e.KeyCode = Keys.Enter Then
            aceptarButton_Click("", e)
        End If
    End Sub
End Class
