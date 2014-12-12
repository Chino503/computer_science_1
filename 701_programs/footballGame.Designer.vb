<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrFootballGame
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
        Me.lblFirstQuarterPrompt = New System.Windows.Forms.Label()
        Me.lblSecondQuarterPrompt = New System.Windows.Forms.Label()
        Me.lblThirdQuarterPrompt = New System.Windows.Forms.Label()
        Me.lblFourthQuarterPrompt = New System.Windows.Forms.Label()
        Me.txtQ1 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstQuarterPrompt
        '
        Me.lblFirstQuarterPrompt.AutoSize = True
        Me.lblFirstQuarterPrompt.Location = New System.Drawing.Point(12, 20)
        Me.lblFirstQuarterPrompt.Name = "lblFirstQuarterPrompt"
        Me.lblFirstQuarterPrompt.Size = New System.Drawing.Size(98, 13)
        Me.lblFirstQuarterPrompt.TabIndex = 0
        Me.lblFirstQuarterPrompt.Text = "Enter the Q1 points"
        '
        'lblSecondQuarterPrompt
        '
        Me.lblSecondQuarterPrompt.AutoSize = True
        Me.lblSecondQuarterPrompt.Location = New System.Drawing.Point(12, 47)
        Me.lblSecondQuarterPrompt.Name = "lblSecondQuarterPrompt"
        Me.lblSecondQuarterPrompt.Size = New System.Drawing.Size(98, 13)
        Me.lblSecondQuarterPrompt.TabIndex = 1
        Me.lblSecondQuarterPrompt.Text = "Enter the Q2 points"
        '
        'lblThirdQuarterPrompt
        '
        Me.lblThirdQuarterPrompt.AutoSize = True
        Me.lblThirdQuarterPrompt.Location = New System.Drawing.Point(12, 75)
        Me.lblThirdQuarterPrompt.Name = "lblThirdQuarterPrompt"
        Me.lblThirdQuarterPrompt.Size = New System.Drawing.Size(98, 13)
        Me.lblThirdQuarterPrompt.TabIndex = 2
        Me.lblThirdQuarterPrompt.Text = "Enter the Q3 points"
        '
        'lblFourthQuarterPrompt
        '
        Me.lblFourthQuarterPrompt.AutoSize = True
        Me.lblFourthQuarterPrompt.Location = New System.Drawing.Point(12, 101)
        Me.lblFourthQuarterPrompt.Name = "lblFourthQuarterPrompt"
        Me.lblFourthQuarterPrompt.Size = New System.Drawing.Size(98, 13)
        Me.lblFourthQuarterPrompt.TabIndex = 3
        Me.lblFourthQuarterPrompt.Text = "Enter the Q4 points"
        '
        'txtQ1
        '
        Me.txtQ1.Location = New System.Drawing.Point(156, 17)
        Me.txtQ1.Name = "txtQ1"
        Me.txtQ1.Size = New System.Drawing.Size(100, 20)
        Me.txtQ1.TabIndex = 4
        '
        'txtQ2
        '
        Me.txtQ2.Location = New System.Drawing.Point(156, 46)
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.Size = New System.Drawing.Size(100, 20)
        Me.txtQ2.TabIndex = 5
        '
        'txtQ3
        '
        Me.txtQ3.Location = New System.Drawing.Point(156, 72)
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.Size = New System.Drawing.Size(100, 20)
        Me.txtQ3.TabIndex = 6
        '
        'txtQ4
        '
        Me.txtQ4.Location = New System.Drawing.Point(156, 101)
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(100, 20)
        Me.txtQ4.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 130)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(240, 38)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Compute The Total Number Of Points"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 186)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(243, 44)
        Me.lblAnswer.TabIndex = 9
        '
        'fmrFootballGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 261)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtQ4)
        Me.Controls.Add(Me.txtQ3)
        Me.Controls.Add(Me.txtQ2)
        Me.Controls.Add(Me.txtQ1)
        Me.Controls.Add(Me.lblFourthQuarterPrompt)
        Me.Controls.Add(Me.lblThirdQuarterPrompt)
        Me.Controls.Add(Me.lblSecondQuarterPrompt)
        Me.Controls.Add(Me.lblFirstQuarterPrompt)
        Me.Name = "fmrFootballGame"
        Me.Text = "Football Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstQuarterPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSecondQuarterPrompt As System.Windows.Forms.Label
    Friend WithEvents lblThirdQuarterPrompt As System.Windows.Forms.Label
    Friend WithEvents lblFourthQuarterPrompt As System.Windows.Forms.Label
    Friend WithEvents txtQ1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ4 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
