<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawCards
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
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.lblDrawPrompt = New System.Windows.Forms.Label()
        Me.txtDraws = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(17, 21)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(243, 29)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw Cards"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'lblDrawPrompt
        '
        Me.lblDrawPrompt.AutoSize = True
        Me.lblDrawPrompt.Location = New System.Drawing.Point(14, 67)
        Me.lblDrawPrompt.Name = "lblDrawPrompt"
        Me.lblDrawPrompt.Size = New System.Drawing.Size(94, 13)
        Me.lblDrawPrompt.TabIndex = 1
        Me.lblDrawPrompt.Text = "How many draws?"
        '
        'txtDraws
        '
        Me.txtDraws.Location = New System.Drawing.Point(187, 67)
        Me.txtDraws.Name = "txtDraws"
        Me.txtDraws.Size = New System.Drawing.Size(73, 20)
        Me.txtDraws.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(14, 110)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(246, 198)
        Me.lblAnswer.TabIndex = 3
        '
        'frmDrawCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 325)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtDraws)
        Me.Controls.Add(Me.lblDrawPrompt)
        Me.Controls.Add(Me.btnDraw)
        Me.Name = "frmDrawCards"
        Me.Text = "DrawCards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents lblDrawPrompt As System.Windows.Forms.Label
    Friend WithEvents txtDraws As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
