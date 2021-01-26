Public Class Form1
    Public I, K(500), J, C(500) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        I = TextBox2.Text
        TextBox2.Text = " "
        For Me.J = 101 To 500
            K(J) = J
        Next
        For Me.J = 101 To 500
            If I = K(J) Then
                C(J) = C(J) + 1
                If C(J) = 1 Then
                    MsgBox("YOU ARE LOGGED IN")
                    Me.Hide()
                    Form2.Show()
                Else
                    MsgBox("THE VOTER KEY IS ALREADY USED")
                End If
            ElseIf I = 1001 Then
                GroupBox1.Visible = True
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "2019oxfordELECTION" Then
            TextBox1.Text = " "
            Form14.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class
