Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim prevy As Integer = player.Top
        Dim prevx As Integer = player.Left
        Select Case e.KeyCode
            Case Keys.W
                player.Top -= 5
            Case Keys.A
                player.Left -= 5
            Case Keys.S
                player.Top += 5
            Case Keys.D
                player.Left += 5
        End Select

        If testcollision(player, obdticle) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function testcollision(ByRef pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean
        If pic1.Top < pic2.Bottom And pic1.Left < pic2.Right And pic1.Bottom > pic2.Top And pic1.Right > pic2.Left Then
            Return True
        End If
        Return False
    End Function
End Class
