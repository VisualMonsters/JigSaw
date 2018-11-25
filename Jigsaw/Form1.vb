Public Class Form1
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) _
        Handles startPB.Click
        startPB.Visible = False

        Dim jigsaw As New jigsaw(mainBoard,
                             PanelTop,
                             firstLeftTop,
                             firstLeftBottom,
                             firstRightTop,
                             firstRightBottom,
                             secondLeftTop,
                             secondLeftBottom,
                             secondRightTop,
                             secondRightBottom,
                             2,
                             hiddenLeftTop,
                             hiddenRightTop,
                             hiddenLeftBottom,
                             hiddenRightBottom,
                             1,
                             points,
                             steps)

        PanelTop.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://visualmonsters.cba.pl")
    End Sub
End Class
