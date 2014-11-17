<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandy
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
        Me.lblCandyPrompt = New System.Windows.Forms.Label()
        Me.lblOzPrompt = New System.Windows.Forms.Label()
        Me.lblPricePrompt = New System.Windows.Forms.Label()
        Me.txtCandy = New System.Windows.Forms.TextBox()
        Me.txtPrize = New System.Windows.Forms.TextBox()
        Me.txtOz = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCandyPrompt
        '
        Me.lblCandyPrompt.AutoSize = True
        Me.lblCandyPrompt.Location = New System.Drawing.Point(12, 48)
        Me.lblCandyPrompt.Name = "lblCandyPrompt"
        Me.lblCandyPrompt.Size = New System.Drawing.Size(128, 13)
        Me.lblCandyPrompt.TabIndex = 0
        Me.lblCandyPrompt.Text = "Enter your favorite candy "
        '
        'lblOzPrompt
        '
        Me.lblOzPrompt.AutoSize = True
        Me.lblOzPrompt.Location = New System.Drawing.Point(12, 76)
        Me.lblOzPrompt.Name = "lblOzPrompt"
        Me.lblOzPrompt.Size = New System.Drawing.Size(152, 13)
        Me.lblOzPrompt.TabIndex = 1
        Me.lblOzPrompt.Text = "Enter number of ounces to buy"
        '
        'lblPricePrompt
        '
        Me.lblPricePrompt.AutoSize = True
        Me.lblPricePrompt.Location = New System.Drawing.Point(12, 105)
        Me.lblPricePrompt.Name = "lblPricePrompt"
        Me.lblPricePrompt.Size = New System.Drawing.Size(127, 13)
        Me.lblPricePrompt.TabIndex = 2
        Me.lblPricePrompt.Text = "Enter the price per ounce"
        '
        'txtCandy
        '
        Me.txtCandy.Location = New System.Drawing.Point(172, 45)
        Me.txtCandy.Name = "txtCandy"
        Me.txtCandy.Size = New System.Drawing.Size(100, 20)
        Me.txtCandy.TabIndex = 3
        '
        'txtPrize
        '
        Me.txtPrize.Location = New System.Drawing.Point(172, 105)
        Me.txtPrize.Name = "txtPrize"
        Me.txtPrize.Size = New System.Drawing.Size(100, 20)
        Me.txtPrize.TabIndex = 4
        '
        'txtOz
        '
        Me.txtOz.Location = New System.Drawing.Point(172, 76)
        Me.txtOz.Name = "txtOz"
        Me.txtOz.Size = New System.Drawing.Size(100, 20)
        Me.txtOz.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 143)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(260, 29)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(9, 187)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(263, 47)
        Me.lblAnswer.TabIndex = 7
        '
        'frmCandy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtOz)
        Me.Controls.Add(Me.txtPrize)
        Me.Controls.Add(Me.txtCandy)
        Me.Controls.Add(Me.lblPricePrompt)
        Me.Controls.Add(Me.lblOzPrompt)
        Me.Controls.Add(Me.lblCandyPrompt)
        Me.Name = "frmCandy"
        Me.Text = "Candy Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCandyPrompt As System.Windows.Forms.Label
    Friend WithEvents lblOzPrompt As System.Windows.Forms.Label
    Friend WithEvents lblPricePrompt As System.Windows.Forms.Label
    Friend WithEvents txtCandy As System.Windows.Forms.TextBox
    Friend WithEvents txtPrize As System.Windows.Forms.TextBox
    Friend WithEvents txtOz As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
