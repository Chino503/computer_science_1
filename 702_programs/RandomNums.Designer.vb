<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRandomNums
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
        Me.btnGenerator = New System.Windows.Forms.Button()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.lstNums = New System.Windows.Forms.ListBox()
        Me.lblShowNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerator
        '
        Me.btnGenerator.Location = New System.Drawing.Point(12, 12)
        Me.btnGenerator.Name = "btnGenerator"
        Me.btnGenerator.Size = New System.Drawing.Size(212, 44)
        Me.btnGenerator.TabIndex = 0
        Me.btnGenerator.Text = "Generate Numbers"
        Me.btnGenerator.UseVisualStyleBackColor = True
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(12, 62)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(98, 43)
        Me.btnHigh.TabIndex = 1
        Me.btnHigh.Text = "Show High"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(129, 62)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(95, 43)
        Me.btnLow.TabIndex = 2
        Me.btnLow.Text = "Show Low"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'lstNums
        '
        Me.lstNums.FormattingEnabled = True
        Me.lstNums.Location = New System.Drawing.Point(12, 111)
        Me.lstNums.Name = "lstNums"
        Me.lstNums.Size = New System.Drawing.Size(212, 134)
        Me.lstNums.TabIndex = 3
        '
        'lblShowNum
        '
        Me.lblShowNum.Location = New System.Drawing.Point(12, 261)
        Me.lblShowNum.Name = "lblShowNum"
        Me.lblShowNum.Size = New System.Drawing.Size(212, 38)
        Me.lblShowNum.TabIndex = 4
        '
        'frmRandomNums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 310)
        Me.Controls.Add(Me.lblShowNum)
        Me.Controls.Add(Me.lstNums)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.btnGenerator)
        Me.Name = "frmRandomNums"
        Me.Text = "Generate Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerator As System.Windows.Forms.Button
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents lstNums As System.Windows.Forms.ListBox
    Friend WithEvents lblShowNum As System.Windows.Forms.Label
End Class
