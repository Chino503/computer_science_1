<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveWord
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
        Me.lblStringPrompt = New System.Windows.Forms.Label()
        Me.lblWordPrompt = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStringPrompt
        '
        Me.lblStringPrompt.AutoSize = True
        Me.lblStringPrompt.Location = New System.Drawing.Point(16, 33)
        Me.lblStringPrompt.Name = "lblStringPrompt"
        Me.lblStringPrompt.Size = New System.Drawing.Size(71, 13)
        Me.lblStringPrompt.TabIndex = 0
        Me.lblStringPrompt.Text = "Enter a String"
        '
        'lblWordPrompt
        '
        Me.lblWordPrompt.AutoSize = True
        Me.lblWordPrompt.Location = New System.Drawing.Point(16, 61)
        Me.lblWordPrompt.Name = "lblWordPrompt"
        Me.lblWordPrompt.Size = New System.Drawing.Size(117, 13)
        Me.lblWordPrompt.TabIndex = 1
        Me.lblWordPrompt.Text = "Enter a word to remove"
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(16, 94)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(243, 38)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(103, 30)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(156, 20)
        Me.txtString.TabIndex = 3
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(159, 58)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 4
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(77, 159)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(116, 26)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmRemoveWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblWordPrompt)
        Me.Controls.Add(Me.lblStringPrompt)
        Me.Name = "frmRemoveWord"
        Me.Text = "Remove Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStringPrompt As System.Windows.Forms.Label
    Friend WithEvents lblWordPrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
