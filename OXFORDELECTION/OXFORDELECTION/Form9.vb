Public Class Form9
    Public A As Integer = My.Settings.F1
    Public B As Integer = My.Settings.G1
    Public C As Integer = My.Settings.H1
    Public D As Integer = My.Settings.I1
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
        My.Settings.F1 = A
        My.Settings.Save()
        My.Settings.G1 = B
        My.Settings.Save()
        My.Settings.H1 = C
        My.Settings.Save()
        My.Settings.I1 = D
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
        MsgBox("THANKS FOR VOTING" + Environment.NewLine + "THANKS FOR USING A LEGEND'S PRODUCT")
        For Me.C = 1 To 50
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Form1.Show()
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

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class