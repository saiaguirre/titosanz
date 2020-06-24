Public Class FrmPlazofijo

    Private Sub FrmPlazofijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As Rectangle
        Dim hoy As Date
        hoy = Today
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - Me.Width) \ 2
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)
        lblMontoF.Text = ""
        btnValidar.Enabled = False
        lblFechaHoy.Text = hoy
        lblFechaV.Text = ""
        lblMontoF.Text = ""
    End Sub

    Private Sub btmConfDatos_Click(sender As Object, e As EventArgs) Handles btmConfDatos.Click
        If txtMontoI.Text <> "" Then
            If txtMontoI.Text >= 10000 And txtMontoI.Text < lblSaldo.Text Then
                If txtPlazo.Text <> "" Then
                    If txtPlazo.Text > 30 And txtPlazo.Text < 365 Then
                        btnValidar.Enabled = True
                    Else
                        MsgBox("La cantidad de dias ingresados no es válido para el plazo")
                    End If
                End If
            Else
                MsgBox("El saldo ingresado no es válido")
                txtMontoI.Text = ""
            End If
        End If
    End Sub

    Private Sub txtPlazo_TextChanged(sender As Object, e As EventArgs) Handles txtPlazo.TextChanged
        Dim interes As Single
        Dim montofinal As Double
        If txtMontoI.Text <> "" And txtMontoI.Text <= lblSaldo.Text Then
            If IsNumeric(txtPlazo.Text) = True Then
                If txtPlazo.Text >= 30 And txtPlazo.Text <= 365 Then
                    Dim hoy = Today.Day
                    Dim fechaEntrada As DateTime = DateTime.Parse(Today)
                    Dim numDias As Integer = Integer.Parse(txtPlazo.Text)
                    lblFechaV.Text = fechaEntrada.AddDays(numDias).ToString("dd/MM/yyyy")

                    If txtPlazo.Text >= 30 And txtPlazo.Text <= 44 Then
                        interes = txtMontoI.Text * (24.5 / 100) * (txtPlazo.Text / 365)
                        montofinal = txtMontoI.Text + interes
                        lblMontoF.Text = Math.Round(montofinal, 2, MidpointRounding.AwayFromZero)
                    End If

                    If txtPlazo.Text >= 45 And txtPlazo.Text <= 59 Then
                        interes = txtMontoI.Text * (25.5 / 100) * (txtPlazo.Text / 365)
                        montofinal = txtMontoI.Text + interes
                        lblMontoF.Text = Math.Round(montofinal, 2, MidpointRounding.AwayFromZero)
                    End If

                    If txtPlazo.Text >= 60 And txtPlazo.Text <= 89 Then
                        interes = txtMontoI.Text * (26 / 100) * (txtPlazo.Text / 365)
                        montofinal = txtMontoI.Text + interes
                        lblMontoF.Text = Math.Round(montofinal, 2, MidpointRounding.AwayFromZero)
                    End If

                    If txtPlazo.Text >= 90 And txtPlazo.Text <= 119 Then
                        interes = txtMontoI.Text * (26.5 / 100) * (txtPlazo.Text / 365)
                        montofinal = txtMontoI.Text + interes
                        lblMontoF.Text = Math.Round(montofinal, 2, MidpointRounding.AwayFromZero)
                    End If

                    If txtPlazo.Text >= 120 And txtPlazo.Text <= 179 Then
                        interes = txtMontoI.Text * (27 / 100) * (txtPlazo.Text / 365)
                        montofinal = txtMontoI.Text + interes
                        lblMontoF.Text = Math.Round(montofinal, 2, MidpointRounding.AwayFromZero)
                    End If

                    If txtPlazo.Text >= 180 And txtPlazo.Text <= 365 Then
                        interes = txtMontoI.Text * (27.5 / 100) * (txtPlazo.Text / 365)
                        montofinal = txtMontoI.Text + interes
                        lblMontoF.Text = Math.Round(montofinal, 2, MidpointRounding.AwayFromZero)
                    End If
                Else
                    MsgBox("El pazo debe ser entre 30 y 365 dias")
                End If
            Else
                MsgBox("agregue solo numeros al plazo")
            End If
        End If
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        lblSaldo.Text = lblSaldo.Text - txtMontoI.Text + lblMontoF.Text
        Dim usuario As String
        Dim builder As New System.Text.StringBuilder
        Dim fileName As String = "datos.txt"
        Using reader As New IO.StreamReader(fileName)
            While Not reader.EndOfStream()
                Dim input As String = reader.ReadLine()
                If lblUsuarioM.Text = usuario Then
                    builder.AppendLine(input)
                End If
            End While
        End Using
        Dim writer As New IO.StreamWriter(fileName)
        writer.Write(builder.ToString)
        writer.Close()
        FileOpen(1, "datos.txt", OpenMode.Append)
        WriteLine(1, lblUsuarioM.Text, lblContraseñaM.Text,
                  lblnombreM.Text, lblApellidoM.Text, lblDNIM.Text, lblCorreoM.Text, Format(lblFechaNacM.Text, "Short Date"), lblsaldoDM.Text, lblSaldo.Text)
        FileClose(1)
        MsgBox("Operación realizada correctamente")
        frmCompraVenta.lblSaldoP.Text = Me.lblSaldo.Text
        Me.Close()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub txtMontoI_TextChanged(sender As Object, e As EventArgs) Handles txtMontoI.TextChanged

    End Sub
End Class