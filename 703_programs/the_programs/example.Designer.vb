<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExample
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
        Me.lblNumPrompt = New System.Windows.Forms.Label()
        Me.txtNumInput = New System.Windows.Forms.TextBox()
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnSqr = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnRnd = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumPrompt
        '
        Me.lblNumPrompt.AutoSize = True
        Me.lblNumPrompt.Location = New System.Drawing.Point(47, 33)
        Me.lblNumPrompt.Name = "lblNumPrompt"
        Me.lblNumPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblNumPrompt.TabIndex = 0
        Me.lblNumPrompt.Text = "Enter a number "
        '
        'txtNumInput
        '
        Me.txtNumInput.Location = New System.Drawing.Point(146, 26)
        Me.txtNumInput.Name = "txtNumInput"
        Me.txtNumInput.Size = New System.Drawing.Size(64, 20)
        Me.txtNumInput.TabIndex = 1
        '
        'btnAbs
        '
        Me.btnAbs.Location = New System.Drawing.Point(50, 69)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(160, 28)
        Me.btnAbs.TabIndex = 2
        Me.btnAbs.Text = "Absolute Value"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnSqr
        '
        Me.btnSqr.Location = New System.Drawing.Point(50, 103)
        Me.btnSqr.Name = "btnSqr"
        Me.btnSqr.Size = New System.Drawing.Size(160, 28)
        Me.btnSqr.TabIndex = 3
        Me.btnSqr.Text = "Square Root"
        Me.btnSqr.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(50, 137)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(160, 28)
        Me.btnSign.TabIndex = 4
        Me.btnSign.Text = "Sign"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnRnd
        '
        Me.btnRnd.Location = New System.Drawing.Point(50, 171)
        Me.btnRnd.Name = "btnRnd"
        Me.btnRnd.Size = New System.Drawing.Size(160, 28)
        Me.btnRnd.TabIndex = 5
        Me.btnRnd.Text = "Round It!"
        Me.btnRnd.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(47, 211)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(163, 44)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 291)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnRnd)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnSqr)
        Me.Controls.Add(Me.btnAbs)
        Me.Controls.Add(Me.txtNumInput)
        Me.Controls.Add(Me.lblNumPrompt)
        Me.Name = "frmExample"
        Me.Text = "Math Class Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumInput As System.Windows.Forms.TextBox
    Friend WithEvents btnAbs As System.Windows.Forms.Button
    Friend WithEvents btnSqr As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnRnd As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
