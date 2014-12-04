<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShapes
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
        Me.ShapeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCircle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSquare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTriangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShapeToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(284, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'ShapeToolStripMenuItem
        '
        Me.ShapeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCircle, Me.mnuStar, Me.mnuSquare, Me.mnuTriangle, Me.mnuClose})
        Me.ShapeToolStripMenuItem.Name = "ShapeToolStripMenuItem"
        Me.ShapeToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ShapeToolStripMenuItem.Text = "Shape"
        '
        'mnuCircle
        '
        Me.mnuCircle.Name = "mnuCircle"
        Me.mnuCircle.Size = New System.Drawing.Size(152, 22)
        Me.mnuCircle.Text = "Circle"
        '
        'mnuStar
        '
        Me.mnuStar.Name = "mnuStar"
        Me.mnuStar.Size = New System.Drawing.Size(152, 22)
        Me.mnuStar.Text = "Star"
        '
        'mnuSquare
        '
        Me.mnuSquare.Name = "mnuSquare"
        Me.mnuSquare.Size = New System.Drawing.Size(152, 22)
        Me.mnuSquare.Text = "Square"
        '
        'mnuTriangle
        '
        Me.mnuTriangle.Name = "mnuTriangle"
        Me.mnuTriangle.Size = New System.Drawing.Size(152, 22)
        Me.mnuTriangle.Text = "Triangle"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'frmShapes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmShapes"
        Me.Text = "Shapes"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents ShapeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCircle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSquare As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTriangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem

End Class
