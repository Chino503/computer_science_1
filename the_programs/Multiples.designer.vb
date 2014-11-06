<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiples
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
        Me.lblEnterNumberPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnShowMultiples = New System.Windows.Forms.Button()
        Me.lblMultiples = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEnterNumberPrompt
        '
        Me.lblEnterNumberPrompt.AutoSize = True
        Me.lblEnterNumberPrompt.Location = New System.Drawing.Point(32, 39)
        Me.lblEnterNumberPrompt.Name = "lblEnterNumberPrompt"
        Me.lblEnterNumberPrompt.Size = New System.Drawing.Size(79, 13)
        Me.lblEnterNumberPrompt.TabIndex = 0
        Me.lblEnterNumberPrompt.Text = "Enter a number"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(161, 36)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 1
        '
        'btnShowMultiples
        '
        Me.btnShowMultiples.Location = New System.Drawing.Point(35, 62)
        Me.btnShowMultiples.Name = "btnShowMultiples"
        Me.btnShowMultiples.Size = New System.Drawing.Size(224, 36)
        Me.btnShowMultiples.TabIndex = 2
        Me.btnShowMultiples.Text = "Show Multiples"
        Me.btnShowMultiples.UseVisualStyleBackColor = True
        '
        'lblMultiples
        '
        Me.lblMultiples.Location = New System.Drawing.Point(35, 121)
        Me.lblMultiples.Name = "lblMultiples"
        Me.lblMultiples.Size = New System.Drawing.Size(224, 182)
        Me.lblMultiples.TabIndex = 3
        '
        'frmMultiples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 312)
        Me.Controls.Add(Me.lblMultiples)
        Me.Controls.Add(Me.btnShowMultiples)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblEnterNumberPrompt)
        Me.Name = "frmMultiples"
        Me.Text = "Multiples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnShowMultiples As System.Windows.Forms.Button
    Friend WithEvents lblMultiples As System.Windows.Forms.Label
End Class
