<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradingSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        CheckGrade = New Button()
        MarksLabel = New Label()
        Marksdata = New TextBox()
        SuspendLayout()
        ' 
        ' CheckGrade
        ' 
        CheckGrade.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        CheckGrade.Location = New Point(257, 225)
        CheckGrade.Name = "CheckGrade"
        CheckGrade.Size = New Size(148, 37)
        CheckGrade.TabIndex = 0
        CheckGrade.Text = "CHECK GRADE"
        CheckGrade.UseVisualStyleBackColor = True
        ' 
        ' MarksLabel
        ' 
        MarksLabel.AutoSize = True
        MarksLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        MarksLabel.Location = New Point(149, 180)
        MarksLabel.Name = "MarksLabel"
        MarksLabel.Size = New Size(82, 28)
        MarksLabel.TabIndex = 1
        MarksLabel.Text = "MARKS"
        ' 
        ' Marksdata
        ' 
        Marksdata.Font = New Font("Segoe UI", 10F)
        Marksdata.Location = New Point(248, 174)
        Marksdata.Name = "Marksdata"
        Marksdata.Size = New Size(168, 34)
        Marksdata.TabIndex = 2
        ' 
        ' GradingSystem
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(825, 474)
        Controls.Add(Marksdata)
        Controls.Add(MarksLabel)
        Controls.Add(CheckGrade)
        Name = "GradingSystem"
        Text = "Grading System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckGrade As Button
    Friend WithEvents MarksLabel As Label
    Friend WithEvents Marksdata As TextBox

End Class
