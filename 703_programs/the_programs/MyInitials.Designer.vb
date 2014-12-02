<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyInitials
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
        Me.lblNamePrompt = New System.Windows.Forms.Label()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInitials = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnShowInitials = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNamePrompt
        '
        Me.lblNamePrompt.AutoSize = True
        Me.lblNamePrompt.Location = New System.Drawing.Point(16, 39)
        Me.lblNamePrompt.Name = "lblNamePrompt"
        Me.lblNamePrompt.Size = New System.Drawing.Size(143, 13)
        Me.lblNamePrompt.TabIndex = 0
        Me.lblNamePrompt.Text = "Enter your first and last name"
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(172, 36)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(232, 20)
        Me.txtNameInput.TabIndex = 1
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(433, 24)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblInitials
        '
        Me.lblInitials.AutoSize = True
        Me.lblInitials.Location = New System.Drawing.Point(16, 84)
        Me.lblInitials.Name = "lblInitials"
        Me.lblInitials.Size = New System.Drawing.Size(78, 13)
        Me.lblInitials.TabIndex = 3
        Me.lblInitials.Text = "Your initials are"
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(120, 84)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(120, 18)
        Me.lblAnswer.TabIndex = 4
        '
        'btnShowInitials
        '
        Me.btnShowInitials.Location = New System.Drawing.Point(312, 74)
        Me.btnShowInitials.Name = "btnShowInitials"
        Me.btnShowInitials.Size = New System.Drawing.Size(92, 28)
        Me.btnShowInitials.TabIndex = 5
        Me.btnShowInitials.Text = "Show Initials"
        Me.btnShowInitials.UseVisualStyleBackColor = True
        '
        'frmMyInitials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 130)
        Me.Controls.Add(Me.btnShowInitials)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblInitials)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.lblNamePrompt)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMyInitials"
        Me.Text = "My Initials"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNamePrompt As System.Windows.Forms.Label
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInitials As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnShowInitials As System.Windows.Forms.Button
End Class
