Public Class Form2
    Private Sub FontRadioButtons_CheckedChanged(sender As Object, e As EventArgs) _
   Handles GaramondRadioButton.CheckedChanged, MagnetoRadioButton.CheckedChanged, TahomaRadioButton.CheckedChanged

        If GaramondRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Garamond", SampleTestTextBox.Font.Size)
        ElseIf MagnetoRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Magneto", SampleTestTextBox.Font.Size)
        ElseIf TahomaRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Tahoma", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub FontStyleCheckBoxes_CheckedChanged(sender As Object, e As EventArgs) _
    Handles ItalicCheckBox.CheckedChanged, BoldCheckBox.CheckedChanged, BoldItalicCheckBox.CheckedChanged

        Dim style As FontStyle = FontStyle.Regular
        If ItalicCheckBox.Checked Then style = style Or FontStyle.Italic
        If BoldCheckBox.Checked Then style = style Or FontStyle.Bold
        If BoldItalicCheckBox.Checked Then style = style Or FontStyle.Bold Or FontStyle.Italic
        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, style)
    End Sub

    Private Sub FontColorRadioButtons_CheckedChanged(sender As Object, e As EventArgs) _
    Handles GreenRadioButton.CheckedChanged, BlueRadioButton.CheckedChanged, RedRadioButton.CheckedChanged

        If GreenRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Green
        ElseIf BlueRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Blue
        ElseIf RedRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Red
        End If
    End Sub


    Private Sub BtnLoadPicture_Click(sender As Object, e As EventArgs) Handles ImageLoaderPictureBox.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                ImageLoaderPictureBox.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() ' Closes the current form
    End Sub
End Class