﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.usuarioText = New System.Windows.Forms.TextBox()
        Me.contrasenaText = New System.Windows.Forms.TextBox()
        Me.aceptarButton = New System.Windows.Forms.Button()
        Me.registrarseLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'usuarioText
        '
        Me.usuarioText.Location = New System.Drawing.Point(161, 51)
        Me.usuarioText.Name = "usuarioText"
        Me.usuarioText.Size = New System.Drawing.Size(100, 20)
        Me.usuarioText.TabIndex = 2
        '
        'contrasenaText
        '
        Me.contrasenaText.Location = New System.Drawing.Point(161, 98)
        Me.contrasenaText.Name = "contrasenaText"
        Me.contrasenaText.Size = New System.Drawing.Size(100, 20)
        Me.contrasenaText.TabIndex = 3
        '
        'aceptarButton
        '
        Me.aceptarButton.Location = New System.Drawing.Point(113, 184)
        Me.aceptarButton.Name = "aceptarButton"
        Me.aceptarButton.Size = New System.Drawing.Size(80, 26)
        Me.aceptarButton.TabIndex = 4
        Me.aceptarButton.Text = "Aceptar"
        Me.aceptarButton.UseVisualStyleBackColor = True
        '
        'registrarseLinkLabel
        '
        Me.registrarseLinkLabel.AutoSize = True
        Me.registrarseLinkLabel.Location = New System.Drawing.Point(223, 257)
        Me.registrarseLinkLabel.Name = "registrarseLinkLabel"
        Me.registrarseLinkLabel.Size = New System.Drawing.Size(60, 13)
        Me.registrarseLinkLabel.TabIndex = 5
        Me.registrarseLinkLabel.TabStop = True
        Me.registrarseLinkLabel.Text = "Registrarse"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 318)
        Me.Controls.Add(Me.registrarseLinkLabel)
        Me.Controls.Add(Me.aceptarButton)
        Me.Controls.Add(Me.contrasenaText)
        Me.Controls.Add(Me.usuarioText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usuarioText As System.Windows.Forms.TextBox
    Friend WithEvents contrasenaText As System.Windows.Forms.TextBox
    Friend WithEvents aceptarButton As System.Windows.Forms.Button
    Friend WithEvents registrarseLinkLabel As System.Windows.Forms.LinkLabel

End Class