<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBirthdays
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
        Me.btnGetBirthdates = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGetBirthdates
        '
        Me.btnGetBirthdates.Location = New System.Drawing.Point(12, 12)
        Me.btnGetBirthdates.Name = "btnGetBirthdates"
        Me.btnGetBirthdates.Size = New System.Drawing.Size(199, 42)
        Me.btnGetBirthdates.TabIndex = 0
        Me.btnGetBirthdates.Text = "Birthdates"
        Me.btnGetBirthdates.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 70)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(199, 95)
        Me.lstDisplay.TabIndex = 1
        '
        'frmBirthdays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 187)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnGetBirthdates)
        Me.Name = "frmBirthdays"
        Me.Text = "Birthdays"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetBirthdates As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
End Class
