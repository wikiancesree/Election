Public Class Form6
    Public A As Integer = My.Settings.M
    Public B As Integer = My.Settings.N
    Public C As Integer = My.Settings.O
    Public D As Integer = My.Settings.P
    Dim Z As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton2.Checked = True Then
            C = C + 1
        ElseIf RadioButton4.Checked = True Then
            B = B + 1
        ElseIf RadioButton3.Checked = True Then
            D = D + 1
        End If
        My.Settings.M = A
        My.Settings.Save()
        My.Settings.N = B
        My.Settings.Save()
        My.Settings.O = C
        My.Settings.Save()
        My.Settings.P = D
        My.Settings.Save()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()
        For Me.Z = 1 To 5
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form11.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class