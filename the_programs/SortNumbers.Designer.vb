﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortNumbers
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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(28, 26)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(217, 44)
        Me.btnSort.TabIndex = 0
        Me.btnSort.Text = "Sort two numbers"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblSort
        '
        Me.lblSort.Location = New System.Drawing.Point(27, 94)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(217, 84)
        Me.lblSort.TabIndex = 1
        '
        'frmSortNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 200)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.btnSort)
        Me.Name = "frmSortNumbers"
        Me.Text = "Sort Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblSort As System.Windows.Forms.Label
End Class
