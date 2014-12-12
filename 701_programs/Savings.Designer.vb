<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Me.lblMonthlyPrompt = New System.Windows.Forms.Label()
        Me.frmMonthsPrompt = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMonthlyPrompt
        '
        Me.lblMonthlyPrompt.AutoSize = True
        Me.lblMonthlyPrompt.Location = New System.Drawing.Point(12, 38)
        Me.lblMonthlyPrompt.Name = "lblMonthlyPrompt"
        Me.lblMonthlyPrompt.Size = New System.Drawing.Size(215, 13)
        Me.lblMonthlyPrompt.TabIndex = 0
        Me.lblMonthlyPrompt.Text = "Enter the amount put in savings each month"
        '
        'frmMonthsPrompt
        '
        Me.frmMonthsPrompt.AutoSize = True
        Me.frmMonthsPrompt.Location = New System.Drawing.Point(12, 64)
        Me.frmMonthsPrompt.Name = "frmMonthsPrompt"
        Me.frmMonthsPrompt.Size = New System.Drawing.Size(285, 13)
        Me.frmMonthsPrompt.TabIndex = 1
        Me.frmMonthsPrompt.Text = "Enter the number of month you deposited money in savings"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(346, 35)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 2
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(346, 61)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtMonths.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 104)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(185, 44)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate the amount of savings"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(222, 104)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(224, 44)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 188)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMonths)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.frmMonthsPrompt)
        Me.Controls.Add(Me.lblMonthlyPrompt)
        Me.Name = "frmSavings"
        Me.Text = "Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonthlyPrompt As System.Windows.Forms.Label
    Friend WithEvents frmMonthsPrompt As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
