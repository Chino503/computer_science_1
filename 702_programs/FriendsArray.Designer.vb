<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFriendsArray
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
        Me.btnGetFriends = New System.Windows.Forms.Button()
        Me.lblBffs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGetFriends
        '
        Me.btnGetFriends.Location = New System.Drawing.Point(12, 12)
        Me.btnGetFriends.Name = "btnGetFriends"
        Me.btnGetFriends.Size = New System.Drawing.Size(232, 39)
        Me.btnGetFriends.TabIndex = 0
        Me.btnGetFriends.Text = "Show your 5 BFF's"
        Me.btnGetFriends.UseVisualStyleBackColor = True
        '
        'lblBffs
        '
        Me.lblBffs.Location = New System.Drawing.Point(12, 71)
        Me.lblBffs.Name = "lblBffs"
        Me.lblBffs.Size = New System.Drawing.Size(231, 146)
        Me.lblBffs.TabIndex = 1
        '
        'frmFriendsArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 262)
        Me.Controls.Add(Me.lblBffs)
        Me.Controls.Add(Me.btnGetFriends)
        Me.Name = "frmFriendsArray"
        Me.Text = "Friends Array"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetFriends As System.Windows.Forms.Button
    Friend WithEvents lblBffs As System.Windows.Forms.Label

End Class
