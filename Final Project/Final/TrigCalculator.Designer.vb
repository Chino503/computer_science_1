<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrigCalculator
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
        Me.lblSideA = New System.Windows.Forms.Label()
        Me.lblSideB = New System.Windows.Forms.Label()
        Me.lblSideC = New System.Windows.Forms.Label()
        Me.lblAngleA = New System.Windows.Forms.Label()
        Me.lblAngleB = New System.Windows.Forms.Label()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.txtAngleA = New System.Windows.Forms.TextBox()
        Me.txtAngleB = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picRightTriangle = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.picRightTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSideA
        '
        Me.lblSideA.AutoSize = True
        Me.lblSideA.Location = New System.Drawing.Point(29, 39)
        Me.lblSideA.Name = "lblSideA"
        Me.lblSideA.Size = New System.Drawing.Size(49, 13)
        Me.lblSideA.TabIndex = 0
        Me.lblSideA.Text = "Opposite"
        '
        'lblSideB
        '
        Me.lblSideB.AutoSize = True
        Me.lblSideB.Location = New System.Drawing.Point(29, 65)
        Me.lblSideB.Name = "lblSideB"
        Me.lblSideB.Size = New System.Drawing.Size(49, 13)
        Me.lblSideB.TabIndex = 1
        Me.lblSideB.Text = "Adjacent"
        '
        'lblSideC
        '
        Me.lblSideC.AutoSize = True
        Me.lblSideC.Location = New System.Drawing.Point(29, 91)
        Me.lblSideC.Name = "lblSideC"
        Me.lblSideC.Size = New System.Drawing.Size(64, 13)
        Me.lblSideC.TabIndex = 2
        Me.lblSideC.Text = "Hypotenuse"
        '
        'lblAngleA
        '
        Me.lblAngleA.AutoSize = True
        Me.lblAngleA.Location = New System.Drawing.Point(29, 117)
        Me.lblAngleA.Name = "lblAngleA"
        Me.lblAngleA.Size = New System.Drawing.Size(44, 13)
        Me.lblAngleA.TabIndex = 3
        Me.lblAngleA.Text = "Angle A"
        '
        'lblAngleB
        '
        Me.lblAngleB.AutoSize = True
        Me.lblAngleB.Location = New System.Drawing.Point(29, 143)
        Me.lblAngleB.Name = "lblAngleB"
        Me.lblAngleB.Size = New System.Drawing.Size(44, 13)
        Me.lblAngleB.TabIndex = 4
        Me.lblAngleB.Text = "Angle B"
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(102, 36)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(73, 20)
        Me.txtSideA.TabIndex = 5
        Me.txtSideA.Text = "0"
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(102, 62)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(73, 20)
        Me.txtSideB.TabIndex = 6
        Me.txtSideB.Text = "0"
        '
        'txtSideC
        '
        Me.txtSideC.Location = New System.Drawing.Point(102, 88)
        Me.txtSideC.Name = "txtSideC"
        Me.txtSideC.Size = New System.Drawing.Size(73, 20)
        Me.txtSideC.TabIndex = 7
        Me.txtSideC.Text = "0"
        '
        'txtAngleA
        '
        Me.txtAngleA.Location = New System.Drawing.Point(102, 114)
        Me.txtAngleA.Name = "txtAngleA"
        Me.txtAngleA.Size = New System.Drawing.Size(73, 20)
        Me.txtAngleA.TabIndex = 8
        Me.txtAngleA.Text = "0"
        '
        'txtAngleB
        '
        Me.txtAngleB.Enabled = False
        Me.txtAngleB.Location = New System.Drawing.Point(102, 140)
        Me.txtAngleB.Name = "txtAngleB"
        Me.txtAngleB.Size = New System.Drawing.Size(73, 20)
        Me.txtAngleB.TabIndex = 9
        Me.txtAngleB.Text = "0"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 178)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(79, 41)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'picRightTriangle
        '
        Me.picRightTriangle.Image = Global.Final.My.Resources.Resources.triangle_right
        Me.picRightTriangle.Location = New System.Drawing.Point(192, 36)
        Me.picRightTriangle.Name = "picRightTriangle"
        Me.picRightTriangle.Size = New System.Drawing.Size(312, 183)
        Me.picRightTriangle.TabIndex = 11
        Me.picRightTriangle.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(117, 178)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(58, 41)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmTrigCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 248)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.picRightTriangle)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAngleB)
        Me.Controls.Add(Me.txtAngleA)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.lblAngleB)
        Me.Controls.Add(Me.lblAngleA)
        Me.Controls.Add(Me.lblSideC)
        Me.Controls.Add(Me.lblSideB)
        Me.Controls.Add(Me.lblSideA)
        Me.Name = "frmTrigCalculator"
        Me.Text = "Trig Calculator"
        CType(Me.picRightTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSideA As System.Windows.Forms.Label
    Friend WithEvents lblSideB As System.Windows.Forms.Label
    Friend WithEvents lblSideC As System.Windows.Forms.Label
    Friend WithEvents lblAngleA As System.Windows.Forms.Label
    Friend WithEvents lblAngleB As System.Windows.Forms.Label
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents txtAngleA As System.Windows.Forms.TextBox
    Friend WithEvents txtAngleB As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents picRightTriangle As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
