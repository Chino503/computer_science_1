<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStopLight
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
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.picbxStopLigh = New System.Windows.Forms.PictureBox()
        CType(Me.picbxStopLigh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.Location = New System.Drawing.Point(12, 21)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(86, 38)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.Yellow
        Me.btnYellow.Location = New System.Drawing.Point(12, 65)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(86, 42)
        Me.btnYellow.TabIndex = 1
        Me.btnYellow.Text = "Yellow"
        Me.btnYellow.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGreen.Location = New System.Drawing.Point(12, 113)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(86, 41)
        Me.btnGreen.TabIndex = 2
        Me.btnGreen.Text = "Green"
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'picbxStopLigh
        '
        Me.picbxStopLigh.Image = Global.the_programs.My.Resources.Resources.stopLight
        Me.picbxStopLigh.Location = New System.Drawing.Point(124, 12)
        Me.picbxStopLigh.Name = "picbxStopLigh"
        Me.picbxStopLigh.Size = New System.Drawing.Size(124, 265)
        Me.picbxStopLigh.TabIndex = 3
        Me.picbxStopLigh.TabStop = False
        '
        'frmStopLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 299)
        Me.Controls.Add(Me.picbxStopLigh)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "frmStopLight"
        Me.Text = "Stop Light"
        CType(Me.picbxStopLigh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnYellow As System.Windows.Forms.Button
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents picbxStopLigh As System.Windows.Forms.PictureBox
End Class
