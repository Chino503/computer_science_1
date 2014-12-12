<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheProgram
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
        Me.StringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLength = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrim = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpperCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSquareRoot = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStringPrompt = New System.Windows.Forms.Label()
        Me.lblDecPrompt = New System.Windows.Forms.Label()
        Me.txtTheString = New System.Windows.Forms.TextBox()
        Me.txtTheDecimal = New System.Windows.Forms.TextBox()
        Me.lblTheAnswer = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StringToolStripMenuItem, Me.MathToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(284, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'StringToolStripMenuItem
        '
        Me.StringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLength, Me.mnuTrim, Me.mnuUpperCase, Me.mnuFind})
        Me.StringToolStripMenuItem.Name = "StringToolStripMenuItem"
        Me.StringToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.StringToolStripMenuItem.Text = "String"
        '
        'mnuLength
        '
        Me.mnuLength.Name = "mnuLength"
        Me.mnuLength.Size = New System.Drawing.Size(152, 22)
        Me.mnuLength.Text = "Length"
        '
        'mnuTrim
        '
        Me.mnuTrim.Name = "mnuTrim"
        Me.mnuTrim.Size = New System.Drawing.Size(152, 22)
        Me.mnuTrim.Text = "Trim"
        '
        'mnuUpperCase
        '
        Me.mnuUpperCase.Name = "mnuUpperCase"
        Me.mnuUpperCase.Size = New System.Drawing.Size(152, 22)
        Me.mnuUpperCase.Text = "Upper Case"
        '
        'mnuFind
        '
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(152, 22)
        Me.mnuFind.Text = "Find"
        '
        'MathToolStripMenuItem
        '
        Me.MathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSquareRoot})
        Me.MathToolStripMenuItem.Name = "MathToolStripMenuItem"
        Me.MathToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.MathToolStripMenuItem.Text = "Math"
        '
        'mnuSquareRoot
        '
        Me.mnuSquareRoot.Name = "mnuSquareRoot"
        Me.mnuSquareRoot.Size = New System.Drawing.Size(152, 22)
        Me.mnuSquareRoot.Text = "Square Root"
        '
        'lblStringPrompt
        '
        Me.lblStringPrompt.AutoSize = True
        Me.lblStringPrompt.Location = New System.Drawing.Point(12, 53)
        Me.lblStringPrompt.Name = "lblStringPrompt"
        Me.lblStringPrompt.Size = New System.Drawing.Size(69, 13)
        Me.lblStringPrompt.TabIndex = 1
        Me.lblStringPrompt.Text = "Enter a string"
        '
        'lblDecPrompt
        '
        Me.lblDecPrompt.AutoSize = True
        Me.lblDecPrompt.Location = New System.Drawing.Point(12, 82)
        Me.lblDecPrompt.Name = "lblDecPrompt"
        Me.lblDecPrompt.Size = New System.Drawing.Size(80, 13)
        Me.lblDecPrompt.TabIndex = 2
        Me.lblDecPrompt.Text = "Enter a decimal"
        '
        'txtTheString
        '
        Me.txtTheString.Location = New System.Drawing.Point(105, 50)
        Me.txtTheString.Name = "txtTheString"
        Me.txtTheString.Size = New System.Drawing.Size(167, 20)
        Me.txtTheString.TabIndex = 3
        '
        'txtTheDecimal
        '
        Me.txtTheDecimal.Location = New System.Drawing.Point(172, 79)
        Me.txtTheDecimal.Name = "txtTheDecimal"
        Me.txtTheDecimal.Size = New System.Drawing.Size(100, 20)
        Me.txtTheDecimal.TabIndex = 4
        '
        'lblTheAnswer
        '
        Me.lblTheAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheAnswer.Location = New System.Drawing.Point(12, 119)
        Me.lblTheAnswer.Name = "lblTheAnswer"
        Me.lblTheAnswer.Size = New System.Drawing.Size(260, 58)
        Me.lblTheAnswer.TabIndex = 5
        '
        'frmTheProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 196)
        Me.Controls.Add(Me.lblTheAnswer)
        Me.Controls.Add(Me.txtTheDecimal)
        Me.Controls.Add(Me.txtTheString)
        Me.Controls.Add(Me.lblDecPrompt)
        Me.Controls.Add(Me.lblStringPrompt)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmTheProgram"
        Me.Text = "The Program"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents StringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLength As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTrim As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpperCase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSquareRoot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStringPrompt As System.Windows.Forms.Label
    Friend WithEvents lblDecPrompt As System.Windows.Forms.Label
    Friend WithEvents txtTheString As System.Windows.Forms.TextBox
    Friend WithEvents txtTheDecimal As System.Windows.Forms.TextBox
    Friend WithEvents lblTheAnswer As System.Windows.Forms.Label

End Class
