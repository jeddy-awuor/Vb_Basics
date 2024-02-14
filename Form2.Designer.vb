<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DisplayTextGroupText = New GroupBox()
        SampleTestTextBox = New TextBox()
        FontGroupBox = New GroupBox()
        TahomaRadioButton = New RadioButton()
        GaramondRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        ImageLoaderPictureBox = New PictureBox()
        FontStyleGroupBox = New GroupBox()
        BoldItalicCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        ItalicCheckBox = New CheckBox()
        FontColorGroupBox = New GroupBox()
        RedRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        LoadPictureButton = New Button()
        ExitButton = New Button()
        DisplayTextGroupText.SuspendLayout()
        FontGroupBox.SuspendLayout()
        CType(ImageLoaderPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        FontStyleGroupBox.SuspendLayout()
        FontColorGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' DisplayTextGroupText
        ' 
        DisplayTextGroupText.Controls.Add(SampleTestTextBox)
        DisplayTextGroupText.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DisplayTextGroupText.Location = New Point(13, 22)
        DisplayTextGroupText.Name = "DisplayTextGroupText"
        DisplayTextGroupText.Size = New Size(182, 73)
        DisplayTextGroupText.TabIndex = 2
        DisplayTextGroupText.TabStop = False
        DisplayTextGroupText.Text = "Display Test"
        ' 
        ' SampleTestTextBox
        ' 
        SampleTestTextBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SampleTestTextBox.Location = New Point(6, 22)
        SampleTestTextBox.Name = "SampleTestTextBox"
        SampleTestTextBox.Size = New Size(143, 26)
        SampleTestTextBox.TabIndex = 0
        SampleTestTextBox.Text = "Sample Test"
        ' 
        ' FontGroupBox
        ' 
        FontGroupBox.Controls.Add(TahomaRadioButton)
        FontGroupBox.Controls.Add(GaramondRadioButton)
        FontGroupBox.Controls.Add(MagnetoRadioButton)
        FontGroupBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FontGroupBox.Location = New Point(201, 22)
        FontGroupBox.Name = "FontGroupBox"
        FontGroupBox.Size = New Size(334, 73)
        FontGroupBox.TabIndex = 3
        FontGroupBox.TabStop = False
        FontGroupBox.Text = "Font"
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(215, 26)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(75, 23)
        TahomaRadioButton.TabIndex = 5
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.FlatAppearance.BorderColor = Color.Black
        GaramondRadioButton.Location = New Point(15, 26)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(91, 23)
        GaramondRadioButton.TabIndex = 4
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.TextAlign = ContentAlignment.BottomCenter
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(122, 26)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(81, 23)
        MagnetoRadioButton.TabIndex = 4
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ImageLoaderPictureBox
        ' 
        ImageLoaderPictureBox.Location = New Point(13, 126)
        ImageLoaderPictureBox.Name = "ImageLoaderPictureBox"
        ImageLoaderPictureBox.Size = New Size(241, 162)
        ImageLoaderPictureBox.TabIndex = 4
        ImageLoaderPictureBox.TabStop = False
        ' 
        ' FontStyleGroupBox
        ' 
        FontStyleGroupBox.Controls.Add(BoldItalicCheckBox)
        FontStyleGroupBox.Controls.Add(BoldCheckBox)
        FontStyleGroupBox.Controls.Add(ItalicCheckBox)
        FontStyleGroupBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FontStyleGroupBox.Location = New Point(272, 126)
        FontStyleGroupBox.Name = "FontStyleGroupBox"
        FontStyleGroupBox.Size = New Size(124, 162)
        FontStyleGroupBox.TabIndex = 5
        FontStyleGroupBox.TabStop = False
        FontStyleGroupBox.Text = "Font Style"
        ' 
        ' BoldItalicCheckBox
        ' 
        BoldItalicCheckBox.AutoSize = True
        BoldItalicCheckBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicCheckBox.Location = New Point(14, 94)
        BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        BoldItalicCheckBox.Size = New Size(100, 23)
        BoldItalicCheckBox.TabIndex = 3
        BoldItalicCheckBox.Text = "Bold Italic"
        BoldItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldCheckBox.Location = New Point(14, 58)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(59, 23)
        BoldCheckBox.TabIndex = 2
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicCheckBox.Location = New Point(14, 23)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(61, 23)
        ItalicCheckBox.TabIndex = 1
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' FontColorGroupBox
        ' 
        FontColorGroupBox.Controls.Add(RedRadioButton)
        FontColorGroupBox.Controls.Add(BlueRadioButton)
        FontColorGroupBox.Controls.Add(GreenRadioButton)
        FontColorGroupBox.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FontColorGroupBox.Location = New Point(402, 126)
        FontColorGroupBox.Name = "FontColorGroupBox"
        FontColorGroupBox.Size = New Size(133, 162)
        FontColorGroupBox.TabIndex = 0
        FontColorGroupBox.TabStop = False
        FontColorGroupBox.Text = "Font Color"
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(3, 94)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(52, 23)
        RedRadioButton.TabIndex = 2
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "&Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(3, 58)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(54, 23)
        BlueRadioButton.TabIndex = 1
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "&Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(3, 22)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(64, 23)
        GreenRadioButton.TabIndex = 0
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "&Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' LoadPictureButton
        ' 
        LoadPictureButton.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadPictureButton.Location = New Point(40, 306)
        LoadPictureButton.Name = "LoadPictureButton"
        LoadPictureButton.Size = New Size(155, 58)
        LoadPictureButton.TabIndex = 6
        LoadPictureButton.Text = "&Load Picture"
        LoadPictureButton.TextAlign = ContentAlignment.TopLeft
        LoadPictureButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(449, 323)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(86, 41)
        ExitButton.TabIndex = 7
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(LoadPictureButton)
        Controls.Add(FontColorGroupBox)
        Controls.Add(FontStyleGroupBox)
        Controls.Add(ImageLoaderPictureBox)
        Controls.Add(FontGroupBox)
        Controls.Add(DisplayTextGroupText)
        Name = "Form2"
        Text = "ObjectDemonstrationsForm"
        DisplayTextGroupText.ResumeLayout(False)
        DisplayTextGroupText.PerformLayout()
        FontGroupBox.ResumeLayout(False)
        FontGroupBox.PerformLayout()
        CType(ImageLoaderPictureBox, ComponentModel.ISupportInitialize).EndInit()
        FontStyleGroupBox.ResumeLayout(False)
        FontStyleGroupBox.PerformLayout()
        FontColorGroupBox.ResumeLayout(False)
        FontColorGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DisplayTextGroupText As GroupBox
    Friend WithEvents SampleTestTextBox As TextBox
    Friend WithEvents FontGroupBox As GroupBox
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents ImageLoaderPictureBox As PictureBox
    Friend WithEvents FontStyleGroupBox As GroupBox
    Friend WithEvents FontColorGroupBox As GroupBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
End Class
