<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.registrarseButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dniText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apellidoText = New System.Windows.Forms.TextBox()
        Me.nombreText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NacimientoPicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.erroresLabel = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblReqContraseña = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.correoText = New System.Windows.Forms.TextBox()
        Me.usuarioText = New System.Windows.Forms.TextBox()
        Me.contraseñaText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(286, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Registro"
        '
        'registrarseButton
        '
        Me.registrarseButton.Location = New System.Drawing.Point(277, 457)
        Me.registrarseButton.Name = "registrarseButton"
        Me.registrarseButton.Size = New System.Drawing.Size(95, 37)
        Me.registrarseButton.TabIndex = 25
        Me.registrarseButton.Text = "Registrarse"
        Me.registrarseButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 370)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dniText)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.apellidoText)
        Me.GroupBox2.Controls.Add(Me.nombreText)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 184)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos personales"
        '
        'dniText
        '
        Me.dniText.Location = New System.Drawing.Point(136, 124)
        Me.dniText.Name = "dniText"
        Me.dniText.Size = New System.Drawing.Size(100, 20)
        Me.dniText.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "DNI"
        '
        'apellidoText
        '
        Me.apellidoText.Location = New System.Drawing.Point(136, 87)
        Me.apellidoText.Name = "apellidoText"
        Me.apellidoText.Size = New System.Drawing.Size(100, 20)
        Me.apellidoText.TabIndex = 17
        '
        'nombreText
        '
        Me.nombreText.Location = New System.Drawing.Point(136, 50)
        Me.nombreText.Name = "nombreText"
        Me.nombreText.Size = New System.Drawing.Size(100, 20)
        Me.nombreText.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NacimientoPicker)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 75)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha de nacimiento"
        '
        'NacimientoPicker
        '
        Me.NacimientoPicker.Location = New System.Drawing.Point(21, 32)
        Me.NacimientoPicker.Name = "NacimientoPicker"
        Me.NacimientoPicker.Size = New System.Drawing.Size(215, 20)
        Me.NacimientoPicker.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.Panel1.Controls.Add(Me.erroresLabel)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(360, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 100)
        Me.Panel1.TabIndex = 27
        '
        'erroresLabel
        '
        Me.erroresLabel.AutoSize = True
        Me.erroresLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erroresLabel.ForeColor = System.Drawing.Color.Red
        Me.erroresLabel.Location = New System.Drawing.Point(8, 13)
        Me.erroresLabel.Name = "erroresLabel"
        Me.erroresLabel.Size = New System.Drawing.Size(74, 16)
        Me.erroresLabel.TabIndex = 0
        Me.erroresLabel.Text = "erroresLabel"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblReqContraseña)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.correoText)
        Me.GroupBox4.Controls.Add(Me.usuarioText)
        Me.GroupBox4.Controls.Add(Me.contraseñaText)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(345, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 263)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de cuenta"
        '
        'lblReqContraseña
        '
        Me.lblReqContraseña.AutoSize = True
        Me.lblReqContraseña.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqContraseña.ForeColor = System.Drawing.Color.Red
        Me.lblReqContraseña.Location = New System.Drawing.Point(32, 170)
        Me.lblReqContraseña.Name = "lblReqContraseña"
        Me.lblReqContraseña.Size = New System.Drawing.Size(41, 15)
        Me.lblReqContraseña.TabIndex = 36
        Me.lblReqContraseña.Text = "Label9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, -24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Datos de cuenta"
        '
        'correoText
        '
        Me.correoText.Location = New System.Drawing.Point(90, 44)
        Me.correoText.Name = "correoText"
        Me.correoText.Size = New System.Drawing.Size(171, 20)
        Me.correoText.TabIndex = 34
        '
        'usuarioText
        '
        Me.usuarioText.Location = New System.Drawing.Point(99, 92)
        Me.usuarioText.Name = "usuarioText"
        Me.usuarioText.Size = New System.Drawing.Size(162, 20)
        Me.usuarioText.TabIndex = 33
        '
        'contraseñaText
        '
        Me.contraseñaText.Location = New System.Drawing.Point(99, 144)
        Me.contraseñaText.Name = "contraseñaText"
        Me.contraseñaText.Size = New System.Drawing.Size(162, 20)
        Me.contraseñaText.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Correo"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 506)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.registrarseButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents registrarseButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dniText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents apellidoText As System.Windows.Forms.TextBox
    Friend WithEvents nombreText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents erroresLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents correoText As System.Windows.Forms.TextBox
    Friend WithEvents usuarioText As System.Windows.Forms.TextBox
    Friend WithEvents contraseñaText As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NacimientoPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReqContraseña As System.Windows.Forms.Label
End Class
