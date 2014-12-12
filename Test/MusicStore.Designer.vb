<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMusicStore
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
        Me.lblPromptNew = New System.Windows.Forms.Label()
        Me.lblPromptUsed = New System.Windows.Forms.Label()
        Me.lblPromptSingle = New System.Windows.Forms.Label()
        Me.txtNewCD = New System.Windows.Forms.TextBox()
        Me.txtUsedCD = New System.Windows.Forms.TextBox()
        Me.txtSong1CD = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromptNew
        '
        Me.lblPromptNew.AutoSize = True
        Me.lblPromptNew.Location = New System.Drawing.Point(12, 29)
        Me.lblPromptNew.Name = "lblPromptNew"
        Me.lblPromptNew.Size = New System.Drawing.Size(148, 13)
        Me.lblPromptNew.TabIndex = 0
        Me.lblPromptNew.Text = "Enter the number of new CD's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPromptUsed
        '
        Me.lblPromptUsed.AutoSize = True
        Me.lblPromptUsed.Location = New System.Drawing.Point(12, 56)
        Me.lblPromptUsed.Name = "lblPromptUsed"
        Me.lblPromptUsed.Size = New System.Drawing.Size(151, 13)
        Me.lblPromptUsed.TabIndex = 1
        Me.lblPromptUsed.Text = "Enter the number of used CD's"
        '
        'lblPromptSingle
        '
        Me.lblPromptSingle.AutoSize = True
        Me.lblPromptSingle.Location = New System.Drawing.Point(12, 81)
        Me.lblPromptSingle.Name = "lblPromptSingle"
        Me.lblPromptSingle.Size = New System.Drawing.Size(181, 13)
        Me.lblPromptSingle.TabIndex = 2
        Me.lblPromptSingle.Text = "Enter the number of single song CD's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNewCD
        '
        Me.txtNewCD.Location = New System.Drawing.Point(235, 22)
        Me.txtNewCD.Name = "txtNewCD"
        Me.txtNewCD.Size = New System.Drawing.Size(73, 20)
        Me.txtNewCD.TabIndex = 3
        '
        'txtUsedCD
        '
        Me.txtUsedCD.Location = New System.Drawing.Point(235, 48)
        Me.txtUsedCD.Name = "txtUsedCD"
        Me.txtUsedCD.Size = New System.Drawing.Size(73, 20)
        Me.txtUsedCD.TabIndex = 4
        '
        'txtSong1CD
        '
        Me.txtSong1CD.Location = New System.Drawing.Point(235, 74)
        Me.txtSong1CD.Name = "txtSong1CD"
        Me.txtSong1CD.Size = New System.Drawing.Size(73, 20)
        Me.txtSong1CD.TabIndex = 5
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(127, 121)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(181, 117)
        Me.lblAnswer.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 121)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 38)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Show Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmMusicStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 262)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtSong1CD)
        Me.Controls.Add(Me.txtUsedCD)
        Me.Controls.Add(Me.txtNewCD)
        Me.Controls.Add(Me.lblPromptSingle)
        Me.Controls.Add(Me.lblPromptUsed)
        Me.Controls.Add(Me.lblPromptNew)
        Me.Name = "frmMusicStore"
        Me.Text = "Music Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPromptNew As System.Windows.Forms.Label
    Friend WithEvents lblPromptUsed As System.Windows.Forms.Label
    Friend WithEvents lblPromptSingle As System.Windows.Forms.Label
    Friend WithEvents txtNewCD As System.Windows.Forms.TextBox
    Friend WithEvents txtUsedCD As System.Windows.Forms.TextBox
    Friend WithEvents txtSong1CD As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
