Public Class frmCompraVenta

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles confirmarButton.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

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
    End Sub

    Private Sub imagenDolarPicture_Click(sender As Object, e As EventArgs) Handles imagenDolarPicture.Click

    End Sub
End Class