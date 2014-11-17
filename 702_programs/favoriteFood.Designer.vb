<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class favoriteFood
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
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstFavFood = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(12, 12)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(260, 38)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "Enter your favorite food"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 56)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(260, 38)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display your favorite food"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstFavFood
        '
        Me.lstFavFood.FormattingEnabled = True
        Me.lstFavFood.Location = New System.Drawing.Point(12, 113)
        Me.lstFavFood.Name = "lstFavFood"
        Me.lstFavFood.Size = New System.Drawing.Size(260, 95)
        Me.lstFavFood.TabIndex = 2
        '
        'favoriteFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstFavFood)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnGet)
        Me.Name = "favoriteFood"
        Me.Text = "Favorite Food"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lstFavFood As System.Windows.Forms.ListBox
End Class
