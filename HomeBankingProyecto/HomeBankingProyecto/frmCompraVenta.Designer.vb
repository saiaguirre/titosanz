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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.efectuarButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.confirmarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ventaTxt = New System.Windows.Forms.TextBox()
        Me.compraTxt = New System.Windows.Forms.TextBox()
        Me.saldoPesosTxt = New System.Windows.Forms.TextBox()
        Me.saldoDolaresTxt = New System.Windows.Forms.TextBox()
        Me.compraRadio = New System.Windows.Forms.RadioButton()
        Me.ventaRadio = New System.Windows.Forms.RadioButton()
        Me.operacionCompraTxt = New System.Windows.Forms.TextBox()
        Me.operacionVentaTxt = New System.Windows.Forms.TextBox()
        Me.Importe = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.importeTxt = New System.Windows.Forms.TextBox()
        Me.impuestoPaisTxt = New System.Windows.Forms.TextBox()
        Me.totalADebitarTxt = New System.Windows.Forms.TextBox()
        Me.imagenDolarPicture = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.imagenDolarPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.compraTxt)
        Me.GroupBox1.Controls.Add(Me.ventaTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.saldoDolaresTxt)
        Me.GroupBox2.Controls.Add(Me.saldoPesosTxt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos actuales"
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
        Me.GroupBox3.Text = "Operación"
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
        'confirmarButton
        '
        Me.confirmarButton.Location = New System.Drawing.Point(191, 425)
        Me.confirmarButton.Name = "confirmarButton"
        Me.confirmarButton.Size = New System.Drawing.Size(75, 38)
        Me.confirmarButton.TabIndex = 5
        Me.confirmarButton.Text = "Confirmar operación"
        Me.confirmarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Saldo en pesos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Saldo en dolares:"
        '
        'ventaTxt
        '
        Me.ventaTxt.Location = New System.Drawing.Point(94, 30)
        Me.ventaTxt.Name = "ventaTxt"
        Me.ventaTxt.Size = New System.Drawing.Size(100, 20)
        Me.ventaTxt.TabIndex = 2
        '
        'compraTxt
        '
        Me.compraTxt.Location = New System.Drawing.Point(94, 78)
        Me.compraTxt.Name = "compraTxt"
        Me.compraTxt.Size = New System.Drawing.Size(100, 20)
        Me.compraTxt.TabIndex = 3
        '
        'saldoPesosTxt
        '
        Me.saldoPesosTxt.Location = New System.Drawing.Point(95, 33)
        Me.saldoPesosTxt.Name = "saldoPesosTxt"
        Me.saldoPesosTxt.Size = New System.Drawing.Size(100, 20)
        Me.saldoPesosTxt.TabIndex = 3
        '
        'saldoDolaresTxt
        '
        Me.saldoDolaresTxt.Location = New System.Drawing.Point(95, 74)
        Me.saldoDolaresTxt.Name = "saldoDolaresTxt"
        Me.saldoDolaresTxt.Size = New System.Drawing.Size(100, 20)
        Me.saldoDolaresTxt.TabIndex = 4
        '
        'compraRadio
        '
        Me.compraRadio.AutoSize = True
        Me.compraRadio.Location = New System.Drawing.Point(7, 20)
        Me.compraRadio.Name = "compraRadio"
        Me.compraRadio.Size = New System.Drawing.Size(61, 17)
        Me.compraRadio.TabIndex = 0
        Me.compraRadio.TabStop = True
        Me.compraRadio.Text = "Compra"
        Me.compraRadio.UseVisualStyleBackColor = True
        '
        'ventaRadio
        '
        Me.ventaRadio.AutoSize = True
        Me.ventaRadio.Location = New System.Drawing.Point(7, 64)
        Me.ventaRadio.Name = "ventaRadio"
        Me.ventaRadio.Size = New System.Drawing.Size(53, 17)
        Me.ventaRadio.TabIndex = 1
        Me.ventaRadio.TabStop = True
        Me.ventaRadio.Text = "Venta"
        Me.ventaRadio.UseVisualStyleBackColor = True
        '
        'operacionCompraTxt
        '
        Me.operacionCompraTxt.Location = New System.Drawing.Point(94, 20)
        Me.operacionCompraTxt.Name = "operacionCompraTxt"
        Me.operacionCompraTxt.Size = New System.Drawing.Size(100, 20)
        Me.operacionCompraTxt.TabIndex = 4
        '
        'operacionVentaTxt
        '
        Me.operacionVentaTxt.Location = New System.Drawing.Point(94, 61)
        Me.operacionVentaTxt.Name = "operacionVentaTxt"
        Me.operacionVentaTxt.Size = New System.Drawing.Size(100, 20)
        Me.operacionVentaTxt.TabIndex = 5
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Impuesto PAIS"
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
        'importeTxt
        '
        Me.importeTxt.Location = New System.Drawing.Point(115, 31)
        Me.importeTxt.Name = "importeTxt"
        Me.importeTxt.Size = New System.Drawing.Size(100, 20)
        Me.importeTxt.TabIndex = 5
        '
        'impuestoPaisTxt
        '
        Me.impuestoPaisTxt.Location = New System.Drawing.Point(115, 65)
        Me.impuestoPaisTxt.Name = "impuestoPaisTxt"
        Me.impuestoPaisTxt.Size = New System.Drawing.Size(100, 20)
        Me.impuestoPaisTxt.TabIndex = 6
        '
        'totalADebitarTxt
        '
        Me.totalADebitarTxt.Location = New System.Drawing.Point(115, 99)
        Me.totalADebitarTxt.Name = "totalADebitarTxt"
        Me.totalADebitarTxt.Size = New System.Drawing.Size(100, 20)
        Me.totalADebitarTxt.TabIndex = 7
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
        'frmCompraVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 486)
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

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents efectuarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents confirmarButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents compraTxt As System.Windows.Forms.TextBox
    Friend WithEvents ventaTxt As System.Windows.Forms.TextBox
    Friend WithEvents saldoDolaresTxt As System.Windows.Forms.TextBox
    Friend WithEvents saldoPesosTxt As System.Windows.Forms.TextBox
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
End Class
