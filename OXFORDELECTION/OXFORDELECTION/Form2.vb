Public Class Form2
    Public A As Integer = My.Settings.A
    Public B As Integer = My.Settings.B
    Public C As Integer = My.Settings.C
    Dim Z As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton2.Checked = True Then
            B = B + 1
        ElseIf RadioButton4.Checked = True Then
            C = C + 1
        End If
        My.Settings.A = A
        My.Settings.Save()
        My.Settings.B = B
        My.Settings.Save()
        My.Settings.C = C
        My.Settings.Save()
        ProgressBar1.Visible = True
        RadioButton1.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()
        For Me.Z = 1 To 2
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form10.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class