<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhichFirst
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
        Me.btnWhich = New System.Windows.Forms.Button()
        Me.lblWordPrompt1 = New System.Windows.Forms.Label()
        Me.lblWordPrompt2 = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnWhich
        '
        Me.btnWhich.Location = New System.Drawing.Point(29, 21)
        Me.btnWhich.Name = "btnWhich"
        Me.btnWhich.Size = New System.Drawing.Size(226, 41)
        Me.btnWhich.TabIndex = 0
        Me.btnWhich.Text = "Which Word Comes First"
        Me.btnWhich.UseVisualStyleBackColor = True
        '
        'lblWordPrompt1
        '
        Me.lblWordPrompt1.AutoSize = True
        Me.lblWordPrompt1.Location = New System.Drawing.Point(26, 101)
        Me.lblWordPrompt1.Name = "lblWordPrompt1"
        Me.lblWordPrompt1.Size = New System.Drawing.Size(67, 13)
        Me.lblWordPrompt1.TabIndex = 1
        Me.lblWordPrompt1.Text = "Enter a word"
        '
        'lblWordPrompt2
        '
        Me.lblWordPrompt2.AutoSize = True
        Me.lblWordPrompt2.Location = New System.Drawing.Point(26, 139)
        Me.lblWordPrompt2.Name = "lblWordPrompt2"
        Me.lblWordPrompt2.Size = New System.Drawing.Size(67, 13)
        Me.lblWordPrompt2.TabIndex = 2
        Me.lblWordPrompt2.Text = "Enter a word"
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(116, 98)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(139, 20)
        Me.txtInput1.TabIndex = 3
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(116, 136)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(139, 20)
        Me.txtInput2.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(33, 186)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(221, 50)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmWhichFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblWordPrompt2)
        Me.Controls.Add(Me.lblWordPrompt1)
        Me.Controls.Add(Me.btnWhich)
        Me.Name = "frmWhichFirst"
        Me.Text = "Which First"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWhich As System.Windows.Forms.Button
    Friend WithEvents lblWordPrompt1 As System.Windows.Forms.Label
    Friend WithEvents lblWordPrompt2 As System.Windows.Forms.Label
    Friend WithEvents txtInput1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInput2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
