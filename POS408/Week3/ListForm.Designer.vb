<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListForm
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
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.lstMovie = New System.Windows.Forms.ListBox()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.Location = New System.Drawing.Point(13, 22)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(75, 13)
        Me.lblMovie.TabIndex = 0
        Me.lblMovie.Text = "List of Movies:"
        '
        'lstMovie
        '
        Me.lstMovie.FormattingEnabled = True
        Me.lstMovie.Location = New System.Drawing.Point(13, 39)
        Me.lstMovie.Name = "lstMovie"
        Me.lstMovie.Size = New System.Drawing.Size(120, 95)
        Me.lstMovie.TabIndex = 1
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(158, 39)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(75, 23)
        Me.btnFill.TabIndex = 2
        Me.btnFill.Text = "Fill"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(158, 82)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(158, 125)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(158, 168)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(13, 167)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 23)
        Me.btnCount.TabIndex = 6
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(13, 222)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(99, 13)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "Display Total Count"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Location = New System.Drawing.Point(158, 222)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(76, 13)
        Me.lblSelection.TabIndex = 8
        Me.lblSelection.Text = "Your Selection"
        '
        'ListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.lstMovie)
        Me.Controls.Add(Me.lblMovie)
        Me.Name = "ListForm"
        Me.Text = "ListForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMovie As System.Windows.Forms.Label
    Friend WithEvents lstMovie As System.Windows.Forms.ListBox
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblSelection As System.Windows.Forms.Label
End Class
