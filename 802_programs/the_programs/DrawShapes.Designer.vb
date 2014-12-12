<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawShapes
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
        Me.btnDrawShapes = New System.Windows.Forms.Button()
        Me.lblTheShapes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDrawShapes
        '
        Me.btnDrawShapes.Location = New System.Drawing.Point(27, 32)
        Me.btnDrawShapes.Name = "btnDrawShapes"
        Me.btnDrawShapes.Size = New System.Drawing.Size(201, 52)
        Me.btnDrawShapes.TabIndex = 0
        Me.btnDrawShapes.Text = "Draw Shapes"
        Me.btnDrawShapes.UseVisualStyleBackColor = True
        '
        'lblTheShapes
        '
        Me.lblTheShapes.Location = New System.Drawing.Point(24, 87)
        Me.lblTheShapes.Name = "lblTheShapes"
        Me.lblTheShapes.Size = New System.Drawing.Size(524, 486)
        Me.lblTheShapes.TabIndex = 1
        '
        'frmDrawShapes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 599)
        Me.Controls.Add(Me.lblTheShapes)
        Me.Controls.Add(Me.btnDrawShapes)
        Me.Name = "frmDrawShapes"
        Me.Text = "Draw Shapes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDrawShapes As System.Windows.Forms.Button
    Friend WithEvents lblTheShapes As System.Windows.Forms.Label
End Class
