<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasons
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
        Me.btnComputerScience = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnComputerScience
        '
        Me.btnComputerScience.Location = New System.Drawing.Point(31, 12)
        Me.btnComputerScience.Name = "btnComputerScience"
        Me.btnComputerScience.Size = New System.Drawing.Size(228, 32)
        Me.btnComputerScience.TabIndex = 0
        Me.btnComputerScience.Text = "Why Take Computer Science"
        Me.btnComputerScience.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(28, 60)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(231, 136)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnComputerScience)
        Me.Name = "frmReasons"
        Me.Text = "CS is for you!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnComputerScience As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
