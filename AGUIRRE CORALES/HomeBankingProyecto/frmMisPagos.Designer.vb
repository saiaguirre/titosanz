<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisPagos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblFechaNacM = New System.Windows.Forms.Label()
        Me.lblCorreoM = New System.Windows.Forms.Label()
        Me.lblDNIM = New System.Windows.Forms.Label()
        Me.lblContraseñaM = New System.Windows.Forms.Label()
        Me.lblUsuarioM = New System.Windows.Forms.Label()
        Me.lblnombreM = New System.Windows.Forms.Label()
        Me.lblApellidoM = New System.Windows.Forms.Label()
        Me.lblsaldoDM = New System.Windows.Forms.Label()
        Me.CBAFIP = New System.Windows.Forms.CheckBox()
        Me.CBAGIP = New System.Windows.Forms.CheckBox()
        Me.CBCablevision = New System.Windows.Forms.CheckBox()
        Me.CBAysa = New System.Windows.Forms.CheckBox()
        Me.CBFibertel = New System.Windows.Forms.CheckBox()
        Me.CBEdesur = New System.Windows.Forms.CheckBox()
        Me.CBEdenor = New System.Windows.Forms.CheckBox()
        Me.CBPersonal = New System.Windows.Forms.CheckBox()
        Me.CBMetrogas = New System.Windows.Forms.CheckBox()
        Me.CBOsde = New System.Windows.Forms.CheckBox()
        Me.CBMovistar = New System.Windows.Forms.CheckBox()
        Me.CBClaro = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPagos = New System.Windows.Forms.Label()
        Me.btmConfirmar = New System.Windows.Forms.Button()
        Me.btmReset = New System.Windows.Forms.Button()
        Me.btmValidar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione los servicios que se debitarán de su cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(339, 13)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(57, 20)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Label3"
        '
        'lblFechaNacM
        '
        Me.lblFechaNacM.AutoSize = True
        Me.lblFechaNacM.Location = New System.Drawing.Point(579, 108)
        Me.lblFechaNacM.Name = "lblFechaNacM"
        Me.lblFechaNacM.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaNacM.TabIndex = 18
        Me.lblFechaNacM.Text = "Nacimiento"
        '
        'lblCorreoM
        '
        Me.lblCorreoM.AutoSize = True
        Me.lblCorreoM.Location = New System.Drawing.Point(579, 95)
        Me.lblCorreoM.Name = "lblCorreoM"
        Me.lblCorreoM.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreoM.TabIndex = 17
        Me.lblCorreoM.Text = "Correo"
        '
        'lblDNIM
        '
        Me.lblDNIM.AutoSize = True
        Me.lblDNIM.Location = New System.Drawing.Point(579, 82)
        Me.lblDNIM.Name = "lblDNIM"
        Me.lblDNIM.Size = New System.Drawing.Size(26, 13)
        Me.lblDNIM.TabIndex = 16
        Me.lblDNIM.Text = "DNI"
        '
        'lblContraseñaM
        '
        Me.lblContraseñaM.AutoSize = True
        Me.lblContraseñaM.Location = New System.Drawing.Point(580, 69)
        Me.lblContraseñaM.Name = "lblContraseñaM"
        Me.lblContraseñaM.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseñaM.TabIndex = 15
        Me.lblContraseñaM.Text = "Contraseña"
        '
        'lblUsuarioM
        '
        Me.lblUsuarioM.AutoSize = True
        Me.lblUsuarioM.Location = New System.Drawing.Point(580, 43)
        Me.lblUsuarioM.Name = "lblUsuarioM"
        Me.lblUsuarioM.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuarioM.TabIndex = 14
        Me.lblUsuarioM.Text = "Usuario"
        '
        'lblnombreM
        '
        Me.lblnombreM.AutoSize = True
        Me.lblnombreM.Location = New System.Drawing.Point(579, 56)
        Me.lblnombreM.Name = "lblnombreM"
        Me.lblnombreM.Size = New System.Drawing.Size(44, 13)
        Me.lblnombreM.TabIndex = 13
        Me.lblnombreM.Text = "Nombre"
        '
        'lblApellidoM
        '
        Me.lblApellidoM.AutoSize = True
        Me.lblApellidoM.Location = New System.Drawing.Point(581, 134)
        Me.lblApellidoM.Name = "lblApellidoM"
        Me.lblApellidoM.Size = New System.Drawing.Size(44, 13)
        Me.lblApellidoM.TabIndex = 42
        Me.lblApellidoM.Text = "Apellido"
        '
        'lblsaldoDM
        '
        Me.lblsaldoDM.AutoSize = True
        Me.lblsaldoDM.Location = New System.Drawing.Point(581, 121)
        Me.lblsaldoDM.Name = "lblsaldoDM"
        Me.lblsaldoDM.Size = New System.Drawing.Size(42, 13)
        Me.lblsaldoDM.TabIndex = 41
        Me.lblsaldoDM.Text = "SaldoD"
        '
        'CBAFIP
        '
        Me.CBAFIP.AutoSize = True
        Me.CBAFIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAFIP.Location = New System.Drawing.Point(12, 103)
        Me.CBAFIP.Name = "CBAFIP"
        Me.CBAFIP.Size = New System.Drawing.Size(64, 24)
        Me.CBAFIP.TabIndex = 43
        Me.CBAFIP.Text = "AFIP"
        Me.CBAFIP.UseVisualStyleBackColor = True
        '
        'CBAGIP
        '
        Me.CBAGIP.AutoSize = True
        Me.CBAGIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAGIP.Location = New System.Drawing.Point(12, 133)
        Me.CBAGIP.Name = "CBAGIP"
        Me.CBAGIP.Size = New System.Drawing.Size(67, 24)
        Me.CBAGIP.TabIndex = 44
        Me.CBAGIP.Text = "AGIP"
        Me.CBAGIP.UseVisualStyleBackColor = True
        '
        'CBCablevision
        '
        Me.CBCablevision.AutoSize = True
        Me.CBCablevision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCablevision.Location = New System.Drawing.Point(12, 163)
        Me.CBCablevision.Name = "CBCablevision"
        Me.CBCablevision.Size = New System.Drawing.Size(112, 24)
        Me.CBCablevision.TabIndex = 45
        Me.CBCablevision.Text = "CableVisión"
        Me.CBCablevision.UseVisualStyleBackColor = True
        '
        'CBAysa
        '
        Me.CBAysa.AutoSize = True
        Me.CBAysa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAysa.Location = New System.Drawing.Point(12, 223)
        Me.CBAysa.Name = "CBAysa"
        Me.CBAysa.Size = New System.Drawing.Size(63, 24)
        Me.CBAysa.TabIndex = 46
        Me.CBAysa.Text = "Aysa"
        Me.CBAysa.UseVisualStyleBackColor = True
        '
        'CBFibertel
        '
        Me.CBFibertel.AutoSize = True
        Me.CBFibertel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFibertel.Location = New System.Drawing.Point(12, 193)
        Me.CBFibertel.Name = "CBFibertel"
        Me.CBFibertel.Size = New System.Drawing.Size(81, 24)
        Me.CBFibertel.TabIndex = 47
        Me.CBFibertel.Text = "Fibertel"
        Me.CBFibertel.UseVisualStyleBackColor = True
        '
        'CBEdesur
        '
        Me.CBEdesur.AutoSize = True
        Me.CBEdesur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEdesur.Location = New System.Drawing.Point(139, 253)
        Me.CBEdesur.Name = "CBEdesur"
        Me.CBEdesur.Size = New System.Drawing.Size(79, 24)
        Me.CBEdesur.TabIndex = 48
        Me.CBEdesur.Text = "Edesur"
        Me.CBEdesur.UseVisualStyleBackColor = True
        '
        'CBEdenor
        '
        Me.CBEdenor.AutoSize = True
        Me.CBEdenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEdenor.Location = New System.Drawing.Point(12, 253)
        Me.CBEdenor.Name = "CBEdenor"
        Me.CBEdenor.Size = New System.Drawing.Size(80, 24)
        Me.CBEdenor.TabIndex = 49
        Me.CBEdenor.Text = "Edenor"
        Me.CBEdenor.UseVisualStyleBackColor = True
        '
        'CBPersonal
        '
        Me.CBPersonal.AutoSize = True
        Me.CBPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPersonal.Location = New System.Drawing.Point(12, 343)
        Me.CBPersonal.Name = "CBPersonal"
        Me.CBPersonal.Size = New System.Drawing.Size(90, 24)
        Me.CBPersonal.TabIndex = 50
        Me.CBPersonal.Text = "Personal"
        Me.CBPersonal.UseVisualStyleBackColor = True
        '
        'CBMetrogas
        '
        Me.CBMetrogas.AutoSize = True
        Me.CBMetrogas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMetrogas.Location = New System.Drawing.Point(12, 313)
        Me.CBMetrogas.Name = "CBMetrogas"
        Me.CBMetrogas.Size = New System.Drawing.Size(95, 24)
        Me.CBMetrogas.TabIndex = 51
        Me.CBMetrogas.Text = "Metrogas"
        Me.CBMetrogas.UseVisualStyleBackColor = True
        '
        'CBOsde
        '
        Me.CBOsde.AutoSize = True
        Me.CBOsde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOsde.Location = New System.Drawing.Point(12, 283)
        Me.CBOsde.Name = "CBOsde"
        Me.CBOsde.Size = New System.Drawing.Size(74, 24)
        Me.CBOsde.TabIndex = 52
        Me.CBOsde.Text = "OSDE"
        Me.CBOsde.UseVisualStyleBackColor = True
        '
        'CBMovistar
        '
        Me.CBMovistar.AutoSize = True
        Me.CBMovistar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMovistar.Location = New System.Drawing.Point(139, 343)
        Me.CBMovistar.Name = "CBMovistar"
        Me.CBMovistar.Size = New System.Drawing.Size(87, 24)
        Me.CBMovistar.TabIndex = 53
        Me.CBMovistar.Text = "Movistar"
        Me.CBMovistar.UseVisualStyleBackColor = True
        '
        'CBClaro
        '
        Me.CBClaro.AutoSize = True
        Me.CBClaro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBClaro.Location = New System.Drawing.Point(258, 343)
        Me.CBClaro.Name = "CBClaro"
        Me.CBClaro.Size = New System.Drawing.Size(65, 24)
        Me.CBClaro.TabIndex = 54
        Me.CBClaro.Text = "Claro"
        Me.CBClaro.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total de pagos:"
        '
        'lblPagos
        '
        Me.lblPagos.AutoSize = True
        Me.lblPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagos.Location = New System.Drawing.Point(403, 167)
        Me.lblPagos.Name = "lblPagos"
        Me.lblPagos.Size = New System.Drawing.Size(57, 20)
        Me.lblPagos.TabIndex = 56
        Me.lblPagos.Text = "Label4"
        '
        'btmConfirmar
        '
        Me.btmConfirmar.Location = New System.Drawing.Point(305, 103)
        Me.btmConfirmar.Name = "btmConfirmar"
        Me.btmConfirmar.Size = New System.Drawing.Size(82, 37)
        Me.btmConfirmar.TabIndex = 57
        Me.btmConfirmar.Text = "Confirmar selección"
        Me.btmConfirmar.UseVisualStyleBackColor = True
        '
        'btmReset
        '
        Me.btmReset.Location = New System.Drawing.Point(407, 103)
        Me.btmReset.Name = "btmReset"
        Me.btmReset.Size = New System.Drawing.Size(78, 37)
        Me.btmReset.TabIndex = 58
        Me.btmReset.Text = "Reiniciar selección"
        Me.btmReset.UseVisualStyleBackColor = True
        '
        'btmValidar
        '
        Me.btmValidar.Location = New System.Drawing.Point(432, 366)
        Me.btmValidar.Name = "btmValidar"
        Me.btmValidar.Size = New System.Drawing.Size(86, 40)
        Me.btmValidar.TabIndex = 59
        Me.btmValidar.Text = "Validar pagos"
        Me.btmValidar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(403, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Este botón es para testeo. Descuenta los pagos como si fuera principio de mes ->>" & _
    ">"
        '
        'frmMisPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 443)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btmValidar)
        Me.Controls.Add(Me.btmReset)
        Me.Controls.Add(Me.btmConfirmar)
        Me.Controls.Add(Me.lblPagos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBClaro)
        Me.Controls.Add(Me.CBMovistar)
        Me.Controls.Add(Me.CBOsde)
        Me.Controls.Add(Me.CBMetrogas)
        Me.Controls.Add(Me.CBPersonal)
        Me.Controls.Add(Me.CBEdenor)
        Me.Controls.Add(Me.CBEdesur)
        Me.Controls.Add(Me.CBFibertel)
        Me.Controls.Add(Me.CBAysa)
        Me.Controls.Add(Me.CBCablevision)
        Me.Controls.Add(Me.CBAGIP)
        Me.Controls.Add(Me.CBAFIP)
        Me.Controls.Add(Me.lblApellidoM)
        Me.Controls.Add(Me.lblsaldoDM)
        Me.Controls.Add(Me.lblFechaNacM)
        Me.Controls.Add(Me.lblCorreoM)
        Me.Controls.Add(Me.lblDNIM)
        Me.Controls.Add(Me.lblContraseñaM)
        Me.Controls.Add(Me.lblUsuarioM)
        Me.Controls.Add(Me.lblnombreM)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMisPagos"
        Me.Text = "Mis Pagos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacM As System.Windows.Forms.Label
    Friend WithEvents lblCorreoM As System.Windows.Forms.Label
    Friend WithEvents lblDNIM As System.Windows.Forms.Label
    Friend WithEvents lblContraseñaM As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioM As System.Windows.Forms.Label
    Friend WithEvents lblnombreM As System.Windows.Forms.Label
    Friend WithEvents lblApellidoM As System.Windows.Forms.Label
    Friend WithEvents lblsaldoDM As System.Windows.Forms.Label
    Friend WithEvents CBAFIP As System.Windows.Forms.CheckBox
    Friend WithEvents CBAGIP As System.Windows.Forms.CheckBox
    Friend WithEvents CBCablevision As System.Windows.Forms.CheckBox
    Friend WithEvents CBAysa As System.Windows.Forms.CheckBox
    Friend WithEvents CBFibertel As System.Windows.Forms.CheckBox
    Friend WithEvents CBEdesur As System.Windows.Forms.CheckBox
    Friend WithEvents CBEdenor As System.Windows.Forms.CheckBox
    Friend WithEvents CBPersonal As System.Windows.Forms.CheckBox
    Friend WithEvents CBMetrogas As System.Windows.Forms.CheckBox
    Friend WithEvents CBOsde As System.Windows.Forms.CheckBox
    Friend WithEvents CBMovistar As System.Windows.Forms.CheckBox
    Friend WithEvents CBClaro As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPagos As System.Windows.Forms.Label
    Friend WithEvents btmConfirmar As System.Windows.Forms.Button
    Friend WithEvents btmReset As System.Windows.Forms.Button
    Friend WithEvents btmValidar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
