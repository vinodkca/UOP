﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadioForm
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.pnlRadioButton = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(86, 172)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(132, 23)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'pnlRadioButton
        '
        Me.pnlRadioButton.Location = New System.Drawing.Point(160, 42)
        Me.pnlRadioButton.Name = "pnlRadioButton"
        Me.pnlRadioButton.Size = New System.Drawing.Size(278, 100)
        Me.pnlRadioButton.TabIndex = 1
        '
        'RadioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 262)
        Me.Controls.Add(Me.pnlRadioButton)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "RadioForm"
        Me.Text = "Radio Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents pnlRadioButton As System.Windows.Forms.Panel

End Class
