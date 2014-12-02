<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewWord
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
        Me.lblWordPrompt = New System.Windows.Forms.Label()
        Me.lblReplaceLetterPrompt = New System.Windows.Forms.Label()
        Me.lblReplacementLetterPrompt = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtToReplace = New System.Windows.Forms.TextBox()
        Me.txtReplacementLetter = New System.Windows.Forms.TextBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWordPrompt
        '
        Me.lblWordPrompt.AutoSize = True
        Me.lblWordPrompt.Location = New System.Drawing.Point(26, 42)
        Me.lblWordPrompt.Name = "lblWordPrompt"
        Me.lblWordPrompt.Size = New System.Drawing.Size(67, 13)
        Me.lblWordPrompt.TabIndex = 0
        Me.lblWordPrompt.Text = "Enter a word"
        '
        'lblReplaceLetterPrompt
        '
        Me.lblReplaceLetterPrompt.AutoSize = True
        Me.lblReplaceLetterPrompt.Location = New System.Drawing.Point(26, 80)
        Me.lblReplaceLetterPrompt.Name = "lblReplaceLetterPrompt"
        Me.lblReplaceLetterPrompt.Size = New System.Drawing.Size(126, 13)
        Me.lblReplaceLetterPrompt.TabIndex = 1
        Me.lblReplaceLetterPrompt.Text = "Enter the letter to replace"
        '
        'lblReplacementLetterPrompt
        '
        Me.lblReplacementLetterPrompt.AutoSize = True
        Me.lblReplacementLetterPrompt.Location = New System.Drawing.Point(26, 118)
        Me.lblReplacementLetterPrompt.Name = "lblReplacementLetterPrompt"
        Me.lblReplacementLetterPrompt.Size = New System.Drawing.Size(137, 13)
        Me.lblReplacementLetterPrompt.TabIndex = 2
        Me.lblReplacementLetterPrompt.Text = "Enter the replacement letter"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(136, 35)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(95, 20)
        Me.txtWord.TabIndex = 3
        '
        'txtToReplace
        '
        Me.txtToReplace.Location = New System.Drawing.Point(185, 77)
        Me.txtToReplace.Name = "txtToReplace"
        Me.txtToReplace.Size = New System.Drawing.Size(46, 20)
        Me.txtToReplace.TabIndex = 4
        '
        'txtReplacementLetter
        '
        Me.txtReplacementLetter.Location = New System.Drawing.Point(185, 115)
        Me.txtReplacementLetter.Name = "txtReplacementLetter"
        Me.txtReplacementLetter.Size = New System.Drawing.Size(46, 20)
        Me.txtReplacementLetter.TabIndex = 5
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(29, 156)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(202, 33)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace Letter"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(29, 205)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(202, 28)
        Me.lblAnswer.TabIndex = 7
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmNewWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtReplacementLetter)
        Me.Controls.Add(Me.txtToReplace)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblReplacementLetterPrompt)
        Me.Controls.Add(Me.lblReplaceLetterPrompt)
        Me.Controls.Add(Me.lblWordPrompt)
        Me.Name = "frmNewWord"
        Me.Text = "New Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWordPrompt As System.Windows.Forms.Label
    Friend WithEvents lblReplaceLetterPrompt As System.Windows.Forms.Label
    Friend WithEvents lblReplacementLetterPrompt As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents txtToReplace As System.Windows.Forms.TextBox
    Friend WithEvents txtReplacementLetter As System.Windows.Forms.TextBox
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
