Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        Dim frmObjectDemo As New Form2

        frmObjectDemo.Show()
        frmObjectDemo.Focus()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit?", "exit FirstApp",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If response = vbYes Then

            Application.ExitThread()


        End If

    End Sub
End Class
