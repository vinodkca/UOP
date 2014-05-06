<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Looping
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
        Me.lstLoop = New System.Windows.Forms.ListBox()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLoop
        '
        Me.lstLoop.FormattingEnabled = True
        Me.lstLoop.Location = New System.Drawing.Point(55, 46)
        Me.lstLoop.Name = "lstLoop"
        Me.lstLoop.Size = New System.Drawing.Size(120, 95)
        Me.lstLoop.TabIndex = 0
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(22, 176)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnWhile.TabIndex = 1
        Me.btnWhile.Text = "While"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(104, 176)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnDoWhile.TabIndex = 2
        Me.btnDoWhile.Text = "Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(197, 176)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(75, 23)
        Me.btnFor.TabIndex = 3
        Me.btnFor.Text = "For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'Looping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.lstLoop)
        Me.Name = "Looping"
        Me.Text = "Looping"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstLoop As System.Windows.Forms.ListBox
    Friend WithEvents btnWhile As System.Windows.Forms.Button
    Friend WithEvents btnDoWhile As System.Windows.Forms.Button
    Friend WithEvents btnFor As System.Windows.Forms.Button
End Class
