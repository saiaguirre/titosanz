Public Class frmMisPagos
    Dim pagos As Integer
    Private Sub frmMisPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        lblPagos.Text = 0
    End Sub
    Private Sub btmConfirmar_Click(sender As Object, e As EventArgs) Handles btmConfirmar.Click
        If CBAFIP.Checked = True Then
            pagos = pagos + 5748
        End If

        If CBAGIP.Checked = True Then
            pagos = pagos + 783
        End If

        If CBCablevision.Checked = True Then
            pagos = pagos + 9217
        End If

        If CBFibertel.Checked = True Then
            pagos = pagos + 3854
        End If

        If CBAysa.Checked = True Then
            pagos = pagos + 2872
        End If

        If CBEdenor.Checked = True Then
            pagos = pagos + 794
        End If

        If CBEdesur.Checked = True Then
            pagos = pagos + 794
        End If

        If CBOsde.Checked = True Then
            pagos = pagos + 2885
        End If

        If CBMetrogas.Checked = True Then
            pagos = pagos + 2240
        End If

        If CBPersonal.Checked = True Then
            pagos = pagos + 2649
        End If

        If CBMovistar.Checked = True Then
            pagos = pagos + 2649
        End If

        If CBClaro.Checked = True Then
            pagos = pagos + 2649
        End If

        lblPagos.Text = pagos
        btmConfirmar.Enabled = False
    End Sub

    Private Sub btmReset_Click(sender As Object, e As EventArgs) Handles btmReset.Click
        CBAFIP.Checked = False
        CBAGIP.Checked = False
        CBAysa.Checked = False
        CBCablevision.Checked = False
        CBClaro.Checked = False
        CBEdenor.Checked = False
        CBEdesur.Checked = False
        CBFibertel.Checked = False
        CBMetrogas.Checked = False
        CBMovistar.Checked = False
        CBOsde.Checked = False
        CBPersonal.Checked = False
        pagos = 0
        lblPagos.Text = 0
        btmConfirmar.Enabled = True
    End Sub

    Private Sub btmValidar_Click(sender As Object, e As EventArgs) Handles btmValidar.Click
        If pagos > 0 And pagos < lblSaldo.Text Then
            lblSaldo.Text = lblSaldo.Text - pagos
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
            MsgBox("Operacion realizada con éxito")
            Me.Close()
        Else
            MsgBox("Los pagos no pueden ser nulos ni superar la cantidad de saldo en cuenta")
        End If
    End Sub
End Class