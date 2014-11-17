<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiply
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
        Me.lblPromptNum1 = New System.Windows.Forms.Label()
        Me.lblPromptNum2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPromptNum1
        '
        Me.lblPromptNum1.AutoSize = True
        Me.lblPromptNum1.Location = New System.Drawing.Point(22, 39)
        Me.lblPromptNum1.Name = "lblPromptNum1"
        Me.lblPromptNum1.Size = New System.Drawing.Size(79, 13)
        Me.lblPromptNum1.TabIndex = 0
        Me.lblPromptNum1.Text = "Enter a number"
        '
        'lblPromptNum2
        '
        Me.lblPromptNum2.AutoSize = True
        Me.lblPromptNum2.Location = New System.Drawing.Point(22, 76)
        Me.lblPromptNum2.Name = "lblPromptNum2"
        Me.lblPromptNum2.Size = New System.Drawing.Size(79, 13)
        Me.lblPromptNum2.TabIndex = 1
        Me.lblPromptNum2.Text = "Enter a number"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(160, 39)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(78, 20)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(160, 73)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(78, 20)
        Me.txtNum2.TabIndex = 3
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(25, 114)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(110, 40)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(160, 115)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(101, 39)
        Me.lblAnswer.TabIndex = 5
        '
        'frmMultiply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 179)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblPromptNum2)
        Me.Controls.Add(Me.lblPromptNum1)
        Me.Name = "frmMultiply"
        Me.Text = "Multiply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPromptNum1 As System.Windows.Forms.Label
    Friend WithEvents lblPromptNum2 As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
