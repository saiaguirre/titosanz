Imports System.IO
Public Class frmCompraVenta
    Dim nombre, apellido, dni, fecha, correo, password, usuario, saldoP, saldoD As String
    Private Sub frmCompraVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim carpeta As String = "./bin/debug/ImagenDolar.jpg"
        imagenDolarPicture.Image = Image.FromFile("./ImagenDolar.jpg")
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - Me.Width) \ 2
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)
        lblCompra.Text = "64,25"
        lblVenta.Text = "69,25"
        operacionCompraTxt.Enabled = False
        operacionVentaTxt.Enabled = False
        importeTxt.Enabled = False
        impuestoPaisTxt.Enabled = False
        totalADebitarTxt.Enabled = False
    End Sub
    Private Sub efectuarButton_Click(sender As Object, e As EventArgs) Handles efectuarButton.Click
        If compraRadio.Checked = True And operacionCompraTxt.Text <> "" Then
            If IsNumeric(operacionCompraTxt.Text) = True Then
                Dim compra As Double
                Dim importe As Double
                Dim impuesto As Double
                compra = lblVenta.Text
                importe = operacionCompraTxt.Text * compra
                importeTxt.Text = importe
                impuesto = importe * 0.3
                impuestoPaisTxt.Text = impuesto
                totalADebitarTxt.Text = impuesto + importe
            Else
                MsgBox("Ingrese solo numeros en el monto.")
                operacionCompraTxt.Text = ""
            End If
        End If

        If ventaRadio.Checked = True And operacionVentaTxt.Text <> "" Then
            If IsNumeric(operacionVentaTxt.Text) = True Then
                Dim venta As Integer
                Dim compraDolar As Single
                compraDolar = lblCompra.Text
                venta = operacionVentaTxt.Text
                importeTxt.Text = venta
                totalADebitarTxt.Text = venta * compraDolar
            Else
                MsgBox("Ingrese solo numeros en el monto.")
                operacionVentaTxt.Text = ""
            End If
        End If
    End Sub

    Private Sub compraRadio_CheckedChanged(sender As Object, e As EventArgs) Handles compraRadio.CheckedChanged
        If compraRadio.Checked = True Then
            operacionCompraTxt.Enabled = True
        Else
            operacionCompraTxt.Enabled = False
        End If

        If Not totalADebitarTxt.Text = "" Then
            importeTxt.Text = ""
            impuestoPaisTxt.Text = ""
            totalADebitarTxt.Text = ""
        End If
    End Sub

    Private Sub ventaRadio_CheckedChanged(sender As Object, e As EventArgs) Handles ventaRadio.CheckedChanged
        If ventaRadio.Checked = True Then
            operacionVentaTxt.Enabled = True
        Else
            operacionVentaTxt.Enabled = False
        End If

        If Not totalADebitarTxt.Text = "" Then
            importeTxt.Text = ""
            impuestoPaisTxt.Text = ""
            totalADebitarTxt.Text = ""
        End If
    End Sub

    Private Sub confirmarButton_Click(sender As Object, e As EventArgs) Handles confirmarButton.Click
        Dim nombre, apellido, dni, fecha, correo, password, usuario, saldoP, saldoD As String
        Dim x As Integer
        Dim cuentaLineas = File.ReadAllLines("datos.txt").Length
        Dim debitar As Double
        Dim saldo As Double
        If compraRadio.Checked = True Then
            Dim saldoDolares As Double
            debitar = totalADebitarTxt.Text
            saldo = lblSaldoP.Text
            saldoDolares = lblSaldoD.Text
            If debitar > saldo Then
                MsgBox("El saldo no es suficiente para realizar la operación")
            Else
                lblSaldoP.Text = saldo - debitar
                lblSaldoD.Text = saldoDolares + operacionCompraTxt.Text
            End If
        End If

        If ventaRadio.Checked = True Then
            Dim saldoPesos As Double
            saldo = lblSaldoD.Text
            debitar = operacionVentaTxt.Text
            saldoPesos = lblSaldoP.Text
            If debitar > saldo Then
                MsgBox("El saldo no es suficiente para realizar la operación")
            Else
                lblSaldoD.Text = saldo - debitar
                lblSaldoP.Text = saldoPesos + totalADebitarTxt.Text
            End If
        End If

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
        WriteLine(1, lblUsuarioM.Text, lblContraseñaM.Text, lblnombreM.Text, lblapellido.Text, lblDNIM.Text, lblCorreoM.Text, Format(lblFechaNacM.Text, "Short Date"), lblSaldoD.Text, lblSaldoP.Text)
        FileClose(1)
        MsgBox("Operación realizada correctamente")

    End Sub

    Private Sub operacionCompraTxt_GotFocus(sender As Object, e As EventArgs) Handles operacionCompraTxt.GotFocus
        operacionVentaTxt.Text = ""
    End Sub

    Private Sub operacionVentaTxt_GotFocus(sender As Object, e As EventArgs) Handles operacionVentaTxt.GotFocus
        operacionCompraTxt.Text = ""
    End Sub
    Private Sub btmPlazoF_Click(sender As Object, e As EventArgs) Handles btmPlazoF.Click
        FrmPlazofijo.lblSaldo.Text = lblSaldoP.Text
        FrmPlazofijo.lblsaldoDM.Text = lblSaldoD.Text
        FrmPlazofijo.lblApellidoM.Text = lblapellido.Text
        FrmPlazofijo.lblUsuarioM.Text = lblUsuarioM.Text
        FrmPlazofijo.lblContraseñaM.Text = lblContraseñaM.Text
        FrmPlazofijo.lblnombreM.Text = lblnombreM.Text
        FrmPlazofijo.lblDNIM.Text = lblDNIM.Text
        FrmPlazofijo.lblCorreoM.Text = lblCorreoM.Text
        FrmPlazofijo.lblFechaNacM.Text = lblFechaNacM.Text
        FrmPlazofijo.Show()
    End Sub

    Private Sub btmMisPagos_Click(sender As Object, e As EventArgs) Handles btmMisPagos.Click
        frmMisPagos.lblSaldo.Text = lblSaldoP.Text
        frmMisPagos.lblsaldoDM.Text = lblSaldoD.Text
        frmMisPagos.lblApellidoM.Text = lblapellido.Text
        frmMisPagos.lblUsuarioM.Text = lblUsuarioM.Text
        frmMisPagos.lblContraseñaM.Text = lblContraseñaM.Text
        frmMisPagos.lblnombreM.Text = lblnombreM.Text
        frmMisPagos.lblDNIM.Text = lblDNIM.Text
        frmMisPagos.lblCorreoM.Text = lblCorreoM.Text
        frmMisPagos.lblFechaNacM.Text = lblFechaNacM.Text
        frmMisPagos.Show()
    End Sub
End Class