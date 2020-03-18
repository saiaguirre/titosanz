Public Class loginForm

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub contrasenaText_TextChanged(sender As Object, e As EventArgs) Handles contrasenaText.TextChanged

    End Sub

    Private Sub registrarseLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registrarseLinkLabel.LinkClicked
        Me.Hide()
        frmRegistro.ShowDialog()
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
End Class
