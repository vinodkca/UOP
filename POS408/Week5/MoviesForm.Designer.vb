<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoviesForm
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
        Me.dgrMovies = New System.Windows.Forms.DataGridView()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.btnSorted = New System.Windows.Forms.Button()
        Me.btnStartsA = New System.Windows.Forms.Button()
        CType(Me.dgrMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrMovies
        '
        Me.dgrMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrMovies.Location = New System.Drawing.Point(36, 41)
        Me.dgrMovies.Name = "dgrMovies"
        Me.dgrMovies.Size = New System.Drawing.Size(591, 150)
        Me.dgrMovies.TabIndex = 0
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(36, 219)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(75, 23)
        Me.btnFill.TabIndex = 1
        Me.btnFill.Text = "Fill"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'btnSorted
        '
        Me.btnSorted.Location = New System.Drawing.Point(303, 219)
        Me.btnSorted.Name = "btnSorted"
        Me.btnSorted.Size = New System.Drawing.Size(75, 23)
        Me.btnSorted.TabIndex = 2
        Me.btnSorted.Text = "Sorted By Year"
        Me.btnSorted.UseVisualStyleBackColor = True
        '
        'btnStartsA
        '
        Me.btnStartsA.Location = New System.Drawing.Point(163, 219)
        Me.btnStartsA.Name = "btnStartsA"
        Me.btnStartsA.Size = New System.Drawing.Size(75, 23)
        Me.btnStartsA.TabIndex = 3
        Me.btnStartsA.Text = "Starts with A"
        Me.btnStartsA.UseVisualStyleBackColor = True
        '
        'MoviesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 262)
        Me.Controls.Add(Me.btnStartsA)
        Me.Controls.Add(Me.btnSorted)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.dgrMovies)
        Me.Name = "MoviesForm"
        Me.Text = "Movies Form"
        CType(Me.dgrMovies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgrMovies As System.Windows.Forms.DataGridView
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents btnSorted As System.Windows.Forms.Button
    Friend WithEvents btnStartsA As System.Windows.Forms.Button
End Class
