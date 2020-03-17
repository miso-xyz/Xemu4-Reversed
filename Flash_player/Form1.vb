Imports System.Windows.Forms
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Stop" Then
            Button1.Text = "Play"
        Else
            Button1.Text = "Stop"
        End If
        AxShockwaveFlash1.Play()
    End Sub

    ' Unused [Button2]
    '
    ' Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Dim openfiledialog As New OpenFileDialog()
    '    openfiledialog.Filter = "DVD/SO Files(*.mp4)|*.MP4"
    '    If openfiledialog.ShowDialog() = DialogResult.OK Then
    '        AxShockwaveFlash1.Movie = openFileDialog.FileName
    '    End If
    ' End Sub
    '

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenToolStripMenuItem.Click
    End Sub

    Private Sub OpenISODVDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenISODVDToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "DVD/ISO Files(*.iso)|*.swf"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            AxShockwaveFlash1.Movie = openFileDialog.FileName
        End If
    End Sub

    Private Sub Xemu1V361ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xemu1V361ToolStripMenuItem.Click
    End Sub
End Class