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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton9 = New RadioButton()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        OpenFileDialogue1 = New OpenFileDialog()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 52)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(100, 24)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "Garamond"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(133, 52)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(90, 24)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "Magneto"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(288, 52)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(82, 24)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        RadioButton4.Location = New Point(19, 55)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(62, 24)
        RadioButton4.TabIndex = 5
        RadioButton4.TabStop = True
        RadioButton4.Text = "Italic"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RadioButton5.Location = New Point(19, 129)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(62, 24)
        RadioButton5.TabIndex = 5
        RadioButton5.TabStop = True
        RadioButton5.Text = "Bold"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        RadioButton6.Location = New Point(19, 202)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(104, 24)
        RadioButton6.TabIndex = 5
        RadioButton6.TabStop = True
        RadioButton6.Text = "Bold Italic"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.ForeColor = Color.Black
        RadioButton7.Location = New Point(16, 49)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(69, 24)
        RadioButton7.TabIndex = 5
        RadioButton7.TabStop = True
        RadioButton7.Text = "Green"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(19, 184)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(56, 24)
        RadioButton8.TabIndex = 5
        RadioButton8.TabStop = True
        RadioButton8.Text = "Red"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(16, 128)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(59, 24)
        RadioButton9.TabIndex = 5
        RadioButton9.TabStop = True
        RadioButton9.Text = "Blue"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(37, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(302, 97)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Test"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(18, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(146, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Sample Text"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(361, 48)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(512, 115)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton4)
        GroupBox3.Controls.Add(RadioButton5)
        GroupBox3.Controls.Add(RadioButton6)
        GroupBox3.Location = New Point(361, 169)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(244, 241)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RadioButton7)
        GroupBox4.Controls.Add(RadioButton9)
        GroupBox4.Controls.Add(RadioButton8)
        GroupBox4.Location = New Point(648, 174)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(218, 236)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(749, 430)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 46)
        Button1.TabIndex = 10
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(37, 134)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(281, 261)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(98, 423)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 53)
        Button2.TabIndex = 12
        Button2.Text = "Load Picture"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialogue1
        ' 
        OpenFileDialogue1.FileName = "OpenFileDialogue1"
        OpenFileDialogue1.InitialDirectory = """C:\"""
        OpenFileDialogue1.Title = "Load Image"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(318, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 28)
        Label1.TabIndex = 13
        Label1.Text = "Object Demonstrations"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 488)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form2"
        RightToLeft = RightToLeft.No
        Text = "Object Demonstrations"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialogue1 As OpenFileDialog
    Friend WithEvents Label1 As Label
End Class
