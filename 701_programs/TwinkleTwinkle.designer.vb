<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwinkleTwinkle
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
        Me.btnShowPoem = New System.Windows.Forms.Button()
        Me.lblShowSong = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowPoem
        '
        Me.btnShowPoem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPoem.Location = New System.Drawing.Point(42, 40)
        Me.btnShowPoem.Name = "btnShowPoem"
        Me.btnShowPoem.Size = New System.Drawing.Size(297, 60)
        Me.btnShowPoem.TabIndex = 0
        Me.btnShowPoem.Text = "Show Poem"
        Me.btnShowPoem.UseVisualStyleBackColor = True
        '
        'lblShowSong
        '
        Me.lblShowSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowSong.Location = New System.Drawing.Point(38, 114)
        Me.lblShowSong.Name = "lblShowSong"
        Me.lblShowSong.Size = New System.Drawing.Size(301, 279)
        Me.lblShowSong.TabIndex = 1
        '
        'TwinkleTwinkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 428)
        Me.Controls.Add(Me.lblShowSong)
        Me.Controls.Add(Me.btnShowPoem)
        Me.Name = "TwinkleTwinkle"
        Me.Text = "Twinkle Twinke"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowPoem As System.Windows.Forms.Button
    Friend WithEvents lblShowSong As System.Windows.Forms.Label
End Class
