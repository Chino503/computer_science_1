<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathFun
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
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMath = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSqt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRound = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(284, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMath})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'mnuMath
        '
        Me.mnuMath.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbs, Me.mnuSqt, Me.mnuSign, Me.mnuRound})
        Me.mnuMath.Name = "mnuMath"
        Me.mnuMath.Size = New System.Drawing.Size(152, 22)
        Me.mnuMath.Text = "Math"
        '
        'mnuAbs
        '
        Me.mnuAbs.Name = "mnuAbs"
        Me.mnuAbs.Size = New System.Drawing.Size(153, 22)
        Me.mnuAbs.Text = "Absolute Value"
        '
        'mnuSqt
        '
        Me.mnuSqt.Name = "mnuSqt"
        Me.mnuSqt.Size = New System.Drawing.Size(153, 22)
        Me.mnuSqt.Text = "Square Root"
        '
        'mnuSign
        '
        Me.mnuSign.Name = "mnuSign"
        Me.mnuSign.Size = New System.Drawing.Size(153, 22)
        Me.mnuSign.Text = "Sign"
        '
        'mnuRound
        '
        Me.mnuRound.Name = "mnuRound"
        Me.mnuRound.Size = New System.Drawing.Size(153, 22)
        Me.mnuRound.Text = "Round"
        '
        'lblNumPrompt
        '
        Me.lblNumPrompt.AutoSize = True
        Me.lblNumPrompt.Location = New System.Drawing.Point(30, 55)
        Me.lblNumPrompt.Name = "lblNumPrompt"
        Me.lblNumPrompt.Size = New System.Drawing.Size(79, 13)
        Me.lblNumPrompt.TabIndex = 1
        Me.lblNumPrompt.Text = "Enter a number"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(136, 52)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(34, 93)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(201, 53)
        Me.lblAnswer.TabIndex = 3
        '
        'frmMathFun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 170)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblNumPrompt)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMathFun"
        Me.Text = "Math Fun"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSqt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNumPrompt As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents mnuRound As System.Windows.Forms.ToolStripMenuItem
End Class
