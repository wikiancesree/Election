Public Class Form7
    Public A As Integer = My.Settings.Q
    Public B As Integer = My.Settings.R
    Dim Z As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton4.Checked = True Then
            B = B + 1
        End If
        My.Settings.Q = A
        My.Settings.Save()
        My.Settings.R = B
        My.Settings.Save()
        RadioButton1.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()
        For Me.Z = 1 To 5
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form13.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class