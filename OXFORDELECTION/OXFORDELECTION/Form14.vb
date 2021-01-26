Public Class Form14

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        Label1.Text = My.Settings.A
        Label2.Text = My.Settings.B
        Label3.Text = My.Settings.C

        Label4.Text = My.Settings.W
        Label5.Text = My.Settings.X

        Label6.Text = My.Settings.D
        Label7.Text = My.Settings.E

        Label8.Text = My.Settings.A1
        Label9.Text = My.Settings.B1

        Label10.Text = My.Settings.F
        Label11.Text = My.Settings.G
        Label12.Text = My.Settings.H

        Label13.Text = My.Settings.I
        Label14.Text = My.Settings.J
        Label15.Text = My.Settings.K
        Label16.Text = My.Settings.L

        Label17.Text = My.Settings.M
        Label18.Text = My.Settings.N
        Label19.Text = My.Settings.O
        Label20.Text = My.Settings.P

        Label21.Text = My.Settings.Y
        Label22.Text = My.Settings.Z

        Label23.Text = My.Settings.Q
        Label24.Text = My.Settings.R

        Label25.Text = My.Settings.C1
        Label26.Text = My.Settings.D1
        Label27.Text = My.Settings.E1

        Label28.Text = My.Settings.S
        Label29.Text = My.Settings.T
        Label30.Text = My.Settings.U
        Label31.Text = My.Settings.V

        Label32.Text = My.Settings.F1
        Label33.Text = My.Settings.G1
        Label34.Text = My.Settings.H1
        Label35.Text = My.Settings.I1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.Reset()
        Form1.GroupBox1.Visible = False
    End Sub
End Class