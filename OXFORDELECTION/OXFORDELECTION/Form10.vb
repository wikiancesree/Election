Public Class Form10
    Public A As Integer = My.Settings.W
    Public B As Integer = My.Settings.X
    Dim Z As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton2.Checked = True Then
            B = B + 1
        End If
        My.Settings.W = A
        My.Settings.Save()
        My.Settings.X = B
        My.Settings.Save()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()
        For Me.Z = 1 To 2
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class