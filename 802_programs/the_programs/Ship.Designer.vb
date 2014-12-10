<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShip
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblShip = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShow, Me.mnuHide, Me.mnuClose})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(629, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuShow
        '
        Me.mnuShow.Name = "mnuShow"
        Me.mnuShow.Size = New System.Drawing.Size(48, 20)
        Me.mnuShow.Text = "Show"
        '
        'mnuHide
        '
        Me.mnuHide.Name = "mnuHide"
        Me.mnuHide.Size = New System.Drawing.Size(44, 20)
        Me.mnuHide.Text = "Hide"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'lblShip
        '
        Me.lblShip.Location = New System.Drawing.Point(12, 24)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(600, 400)
        Me.lblShip.TabIndex = 1
        '
        'frmShip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 427)
        Me.Controls.Add(Me.lblShip)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmShip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ship"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblShip As System.Windows.Forms.Label
End Class
