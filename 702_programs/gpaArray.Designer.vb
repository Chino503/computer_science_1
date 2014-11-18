<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPAArray
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstGPAs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(28, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 34)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add GPA's"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstGPAs
        '
        Me.lstGPAs.FormattingEnabled = True
        Me.lstGPAs.Location = New System.Drawing.Point(28, 79)
        Me.lstGPAs.Name = "lstGPAs"
        Me.lstGPAs.Size = New System.Drawing.Size(155, 121)
        Me.lstGPAs.TabIndex = 1
        '
        'frmGPAArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 262)
        Me.Controls.Add(Me.lstGPAs)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmGPAArray"
        Me.Text = "GPA Array"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstGPAs As System.Windows.Forms.ListBox
End Class
