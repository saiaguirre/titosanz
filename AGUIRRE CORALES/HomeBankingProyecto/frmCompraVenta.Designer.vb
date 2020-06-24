<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.lblCompraDolar = New System.Windows.Forms.Label()
        Me.lblVentaDolar = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSaldoD = New System.Windows.Forms.Label()
        Me.lblSaldoP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.operacionVentaTxt = New System.Windows.Forms.TextBox()
        Me.operacionCompraTxt = New System.Windows.Forms.TextBox()
        Me.ventaRadio = New System.Windows.Forms.RadioButton()
        Me.compraRadio = New System.Windows.Forms.RadioButton()
        Me.efectuarButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.imagenDolarPicture = New System.Windows.Forms.PictureBox()
        Me.totalADebitarTxt = New System.Windows.Forms.TextBox()
        Me.impuestoPaisTxt = New System.Windows.Forms.TextBox()
        Me.importeTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Importe = New System.Windows.Forms.Label()
        Me.confirmarButton = New System.Windows.Forms.Button()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblnombreM = New System.Windows.Forms.Label()
        Me.lblUsuarioM = New System.Windows.Forms.Label()
        Me.lblContraseñaM = New System.Windows.Forms.Label()
        Me.lblDNIM = New System.Windows.Forms.Label()
        Me.lblCorreoM = New System.Windows.Forms.Label()
        Me.lblFechaNacM = New System.Windows.Forms.Label()
        Me.btmPlazoF = New System.Windows.Forms.Button()
        Me.btmMisPagos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.imagenDolarPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVenta)
        Me.GroupBox1.Controls.Add(Me.lblCompra)
        Me.GroupBox1.Controls.Add(Me.lblCompraDolar)
        Me.GroupBox1.Controls.Add(Me.lblVentaDolar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización"
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(98, 38)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(18, 20)
        Me.lblVenta.TabIndex = 4
        Me.lblVenta.Text = "+"
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.Location = New System.Drawing.Point(98, 86)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(18, 20)
        Me.lblCompra.TabIndex = 3
        Me.lblCompra.Text = "+"
        '
        'lblCompraDolar
        '
        Me.lblCompraDolar.AutoSize = True
        Me.lblCompraDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompraDolar.Location = New System.Drawing.Point(25, 86)
        Me.lblCompraDolar.Name = "lblCompraDolar"
        Me.lblCompraDolar.Size = New System.Drawing.Size(65, 20)
        Me.lblCompraDolar.TabIndex = 1
        Me.lblCompraDolar.Text = "Compra"
        '
        'lblVentaDolar
        '
        Me.lblVentaDolar.AutoSize = True
        Me.lblVentaDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentaDolar.Location = New System.Drawing.Point(26, 38)
        Me.lblVentaDolar.Name = "lblVentaDolar"
        Me.lblVentaDolar.Size = New System.Drawing.Size(52, 20)
        Me.lblVentaDolar.TabIndex = 0
        Me.lblVentaDolar.Text = "Venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSaldoD)
        Me.GroupBox2.Controls.Add(Me.lblSaldoP)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos actuales"
        '
        'lblSaldoD
        '
        Me.lblSaldoD.AutoSize = True
        Me.lblSaldoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoD.Location = New System.Drawing.Point(121, 90)
        Me.lblSaldoD.Name = "lblSaldoD"
        Me.lblSaldoD.Size = New System.Drawing.Size(54, 16)
        Me.lblSaldoD.TabIndex = 6
        Me.lblSaldoD.Text = "SaldoD"
        '
        'lblSaldoP
        '
        Me.lblSaldoP.AutoSize = True
        Me.lblSaldoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoP.Location = New System.Drawing.Point(121, 42)
        Me.lblSaldoP.Name = "lblSaldoP"
        Me.lblSaldoP.Size = New System.Drawing.Size(53, 16)
        Me.lblSaldoP.TabIndex = 5
        Me.lblSaldoP.Text = "SaldoP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Saldo en dolares:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Saldo en pesos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.operacionVentaTxt)
        Me.GroupBox3.Controls.Add(Me.operacionCompraTxt)
        Me.GroupBox3.Controls.Add(Me.ventaRadio)
        Me.GroupBox3.Controls.Add(Me.compraRadio)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 97)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operación (Dolares)"
        '
        'operacionVentaTxt
        '
        Me.operacionVentaTxt.Location = New System.Drawing.Point(94, 61)
        Me.operacionVentaTxt.Name = "operacionVentaTxt"
        Me.operacionVentaTxt.Size = New System.Drawing.Size(100, 20)
        Me.operacionVentaTxt.TabIndex = 5
        '
        'operacionCompraTxt
        '
        Me.operacionCompraTxt.Location = New System.Drawing.Point(94, 20)
        Me.operacionCompraTxt.Name = "operacionCompraTxt"
        Me.operacionCompraTxt.Size = New System.Drawing.Size(100, 20)
        Me.operacionCompraTxt.TabIndex = 4
        '
        'ventaRadio
        '
        Me.ventaRadio.AutoSize = True
        Me.ventaRadio.Location = New System.Drawing.Point(7, 64)
        Me.ventaRadio.Name = "ventaRadio"
        Me.ventaRadio.Size = New System.Drawing.Size(59, 17)
        Me.ventaRadio.TabIndex = 1
        Me.ventaRadio.TabStop = True
        Me.ventaRadio.Text = "Vender"
        Me.ventaRadio.UseVisualStyleBackColor = True
        '
        'compraRadio
        '
        Me.compraRadio.AutoSize = True
        Me.compraRadio.Location = New System.Drawing.Point(7, 20)
        Me.compraRadio.Name = "compraRadio"
        Me.compraRadio.Size = New System.Drawing.Size(64, 17)
        Me.compraRadio.TabIndex = 0
        Me.compraRadio.TabStop = True
        Me.compraRadio.Text = "Comprar"
        Me.compraRadio.UseVisualStyleBackColor = True
        '
        'efectuarButton
        '
        Me.efectuarButton.Location = New System.Drawing.Point(290, 195)
        Me.efectuarButton.Name = "efectuarButton"
        Me.efectuarButton.Size = New System.Drawing.Size(75, 52)
        Me.efectuarButton.TabIndex = 3
        Me.efectuarButton.Text = "Efectuar operación"
        Me.efectuarButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.imagenDolarPicture)
        Me.GroupBox4.Controls.Add(Me.totalADebitarTxt)
        Me.GroupBox4.Controls.Add(Me.impuestoPaisTxt)
        Me.GroupBox4.Controls.Add(Me.importeTxt)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Importe)
        Me.GroupBox4.Location = New System.Drawing.Point(41, 278)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 141)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Importes a debitar"
        '
        'imagenDolarPicture
        '
        Me.imagenDolarPicture.Location = New System.Drawing.Point(237, 31)
        Me.imagenDolarPicture.Name = "imagenDolarPicture"
        Me.imagenDolarPicture.Size = New System.Drawing.Size(129, 88)
        Me.imagenDolarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenDolarPicture.TabIndex = 8
        Me.imagenDolarPicture.TabStop = False
        '
        'totalADebitarTxt
        '
        Me.totalADebitarTxt.Location = New System.Drawing.Point(115, 99)
        Me.totalADebitarTxt.Name = "totalADebitarTxt"
        Me.totalADebitarTxt.Size = New System.Drawing.Size(100, 20)
        Me.totalADebitarTxt.TabIndex = 7
        '
        'impuestoPaisTxt
        '
        Me.impuestoPaisTxt.Location = New System.Drawing.Point(115, 65)
        Me.impuestoPaisTxt.Name = "impuestoPaisTxt"
        Me.impuestoPaisTxt.Size = New System.Drawing.Size(100, 20)
        Me.impuestoPaisTxt.TabIndex = 6
        '
        'importeTxt
        '
        Me.importeTxt.Location = New System.Drawing.Point(115, 31)
        Me.importeTxt.Name = "importeTxt"
        Me.importeTxt.Size = New System.Drawing.Size(100, 20)
        Me.importeTxt.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total a debitar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Impuesto PAIS"
        '
        'Importe
        '
        Me.Importe.AutoSize = True
        Me.Importe.Location = New System.Drawing.Point(27, 34)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(42, 13)
        Me.Importe.TabIndex = 0
        Me.Importe.Text = "Importe"
        '
        'confirmarButton
        '
        Me.confirmarButton.Location = New System.Drawing.Point(191, 425)
        Me.confirmarButton.Name = "confirmarButton"
        Me.confirmarButton.Size = New System.Drawing.Size(75, 38)
        Me.confirmarButton.TabIndex = 5
        Me.confirmarButton.Text = "Confirmar operación"
        Me.confirmarButton.UseVisualStyleBackColor = True
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(12, 9)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(39, 13)
        Me.lblapellido.TabIndex = 6
        Me.lblapellido.Text = "Label7"
        '
        'lblnombreM
        '
        Me.lblnombreM.AutoSize = True
        Me.lblnombreM.Location = New System.Drawing.Point(722, 68)
        Me.lblnombreM.Name = "lblnombreM"
        Me.lblnombreM.Size = New System.Drawing.Size(44, 13)
        Me.lblnombreM.TabIndex = 7
        Me.lblnombreM.Text = "Nombre"
        '
        'lblUsuarioM
        '
        Me.lblUsuarioM.AutoSize = True
        Me.lblUsuarioM.Location = New System.Drawing.Point(723, 55)
        Me.lblUsuarioM.Name = "lblUsuarioM"
        Me.lblUsuarioM.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuarioM.TabIndex = 8
        Me.lblUsuarioM.Text = "Usuario"
        '
        'lblContraseñaM
        '
        Me.lblContraseñaM.AutoSize = True
        Me.lblContraseñaM.Location = New System.Drawing.Point(723, 81)
        Me.lblContraseñaM.Name = "lblContraseñaM"
        Me.lblContraseñaM.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseñaM.TabIndex = 9
        Me.lblContraseñaM.Text = "Contraseña"
        '
        'lblDNIM
        '
        Me.lblDNIM.AutoSize = True
        Me.lblDNIM.Location = New System.Drawing.Point(722, 94)
        Me.lblDNIM.Name = "lblDNIM"
        Me.lblDNIM.Size = New System.Drawing.Size(26, 13)
        Me.lblDNIM.TabIndex = 10
        Me.lblDNIM.Text = "DNI"
        '
        'lblCorreoM
        '
        Me.lblCorreoM.AutoSize = True
        Me.lblCorreoM.Location = New System.Drawing.Point(722, 107)
        Me.lblCorreoM.Name = "lblCorreoM"
        Me.lblCorreoM.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreoM.TabIndex = 11
        Me.lblCorreoM.Text = "Correo"
        '
        'lblFechaNacM
        '
        Me.lblFechaNacM.AutoSize = True
        Me.lblFechaNacM.Location = New System.Drawing.Point(722, 120)
        Me.lblFechaNacM.Name = "lblFechaNacM"
        Me.lblFechaNacM.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaNacM.TabIndex = 12
        Me.lblFechaNacM.Text = "Nacimiento"
        '
        'btmPlazoF
        '
        Me.btmPlazoF.Location = New System.Drawing.Point(487, 68)
        Me.btmPlazoF.Name = "btmPlazoF"
        Me.btmPlazoF.Size = New System.Drawing.Size(95, 39)
        Me.btmPlazoF.TabIndex = 13
        Me.btmPlazoF.Text = "Solicitar Plazo Fijo"
        Me.btmPlazoF.UseVisualStyleBackColor = True
        '
        'btmMisPagos
        '
        Me.btmMisPagos.Location = New System.Drawing.Point(487, 124)
        Me.btmMisPagos.Name = "btmMisPagos"
        Me.btmMisPagos.Size = New System.Drawing.Size(95, 39)
        Me.btmMisPagos.TabIndex = 15
        Me.btmMisPagos.Text = "Mis pagos"
        Me.btmMisPagos.UseVisualStyleBackColor = True
        '
        'frmCompraVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 504)
        Me.Controls.Add(Me.btmMisPagos)
        Me.Controls.Add(Me.btmPlazoF)
        Me.Controls.Add(Me.lblFechaNacM)
        Me.Controls.Add(Me.lblCorreoM)
        Me.Controls.Add(Me.lblDNIM)
        Me.Controls.Add(Me.lblContraseñaM)
        Me.Controls.Add(Me.lblUsuarioM)
        Me.Controls.Add(Me.lblnombreM)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.confirmarButton)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.efectuarButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCompraVenta"
        Me.Text = "Compra/Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.imagenDolarPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents efectuarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents confirmarButton As System.Windows.Forms.Button
    Friend WithEvents lblCompraDolar As System.Windows.Forms.Label
    Friend WithEvents lblVentaDolar As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents operacionVentaTxt As System.Windows.Forms.TextBox
    Friend WithEvents operacionCompraTxt As System.Windows.Forms.TextBox
    Friend WithEvents ventaRadio As System.Windows.Forms.RadioButton
    Friend WithEvents compraRadio As System.Windows.Forms.RadioButton
    Friend WithEvents imagenDolarPicture As System.Windows.Forms.PictureBox
    Friend WithEvents totalADebitarTxt As System.Windows.Forms.TextBox
    Friend WithEvents impuestoPaisTxt As System.Windows.Forms.TextBox
    Friend WithEvents importeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Importe As System.Windows.Forms.Label
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents lblVenta As System.Windows.Forms.Label
    Friend WithEvents lblSaldoD As System.Windows.Forms.Label
    Friend WithEvents lblSaldoP As System.Windows.Forms.Label
    Friend WithEvents lblapellido As System.Windows.Forms.Label
    Friend WithEvents lblnombreM As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioM As System.Windows.Forms.Label
    Friend WithEvents lblContraseñaM As System.Windows.Forms.Label
    Friend WithEvents lblDNIM As System.Windows.Forms.Label
    Friend WithEvents lblCorreoM As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacM As System.Windows.Forms.Label
    Friend WithEvents btmPlazoF As System.Windows.Forms.Button
    Friend WithEvents btmMisPagos As System.Windows.Forms.Button
End Class
