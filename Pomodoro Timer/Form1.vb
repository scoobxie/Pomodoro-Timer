Public Class Form1
    Dim totalTime As Integer = 25 * 60
    Dim isWorkSession As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimer.Text = "25:00"
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        timer1.Start()
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If totalTime > 0 Then
            totalTime -= 1
            Dim minutes As Integer = totalTime \ 60
            Dim seconds As Integer = totalTime Mod 60
            lblTimer.Text = minutes.ToString("D2") & ":" & seconds.ToString("D2")
        Else
            timer1.Stop()
            If isWorkSession Then
                MessageBox.Show("Work session complete! Time for a 5-minute break.", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                isWorkSession = False
                totalTime = 5 * 60
                lblTimer.Text = "05:00"
                timer1.Start()
            Else
                MessageBox.Show("Break is over! Time to get back to work!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                isWorkSession = True
                totalTime = 25 * 60
                lblTimer.Text = "25:00"
                timer1.Start()
            End If
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        timer1.Stop()
        isWorkSession = True
        totalTime = 25 * 60
        lblTimer.Text = "25:00"
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "What would you like to accomplish?" Then
            TextBox1.Clear()
        End If
    End Sub

End Class