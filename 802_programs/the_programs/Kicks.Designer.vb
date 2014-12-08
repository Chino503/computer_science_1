<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKicks
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
        Me.components = New System.ComponentModel.Container()
        Me.picIMG = New System.Windows.Forms.PictureBox()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIMG
        '
        Me.picIMG.Location = New System.Drawing.Point(30, 18)
        Me.picIMG.Name = "picIMG"
        Me.picIMG.Size = New System.Drawing.Size(154, 240)
        Me.picIMG.TabIndex = 0
        Me.picIMG.TabStop = False
        '
        'tmr
        '
        Me.tmr.Enabled = True
        Me.tmr.Interval = 500
        '
        'frmKicks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 288)
        Me.Controls.Add(Me.picIMG)
        Me.Name = "frmKicks"
        Me.Text = "Kicks"
        CType(Me.picIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picIMG As System.Windows.Forms.PictureBox
    Friend WithEvents tmr As System.Windows.Forms.Timer

End Class
