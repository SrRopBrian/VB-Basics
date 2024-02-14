<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demonstrations
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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox3 = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox4 = New GroupBox()
        RadioButton9 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(46, 183)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(412, 399)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 30)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(121, 29)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "Garamond"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(133, 30)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(109, 29)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "Magneto"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(248, 30)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(99, 29)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(446, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(354, 80)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Font"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Location = New Point(97, 50)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 80)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Display Text"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(242, 31)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton6)
        GroupBox3.Controls.Add(RadioButton5)
        GroupBox3.Controls.Add(RadioButton4)
        GroupBox3.Location = New Point(492, 183)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(282, 399)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        RadioButton6.Location = New Point(25, 300)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(125, 29)
        RadioButton6.TabIndex = 2
        RadioButton6.TabStop = True
        RadioButton6.Text = "Italic Bold"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RadioButton5.Location = New Point(25, 175)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(76, 29)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "Bold"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        RadioButton4.Location = New Point(25, 61)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(76, 29)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "Italic"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RadioButton9)
        GroupBox4.Controls.Add(RadioButton8)
        GroupBox4.Controls.Add(RadioButton7)
        GroupBox4.Location = New Point(811, 183)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(300, 399)
        GroupBox4.TabIndex = 7
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(20, 300)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(67, 29)
        RadioButton9.TabIndex = 2
        RadioButton9.TabStop = True
        RadioButton9.Text = "Red"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(20, 175)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(70, 29)
        RadioButton8.TabIndex = 1
        RadioButton8.TabStop = True
        RadioButton8.Text = "Blue"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(20, 61)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(83, 29)
        RadioButton7.TabIndex = 0
        RadioButton7.TabStop = True
        RadioButton7.Text = "Green"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(726, 633)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 52)
        Button1.TabIndex = 8
        Button1.Text = "EXIT"
        ToolTip1.SetToolTip(Button1, "Close this Window")
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(203, 633)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 52)
        Button2.TabIndex = 9
        Button2.Text = "Load Picture"
        ToolTip2.SetToolTip(Button2, "Upload an Image from your computer")
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 100
        ToolTip1.ReshowDelay = 100
        ' 
        ' Object_Demonstrations
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1155, 724)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Object_Demonstrations"
        RightToLeft = RightToLeft.No
        Text = "Object Demonstrations"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
