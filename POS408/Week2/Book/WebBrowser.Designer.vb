<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.webDisplay = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URL"
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(81, 12)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(533, 20)
        Me.txtURL.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(659, 9)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'webDisplay
        '
        Me.webDisplay.Location = New System.Drawing.Point(17, 38)
        Me.webDisplay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webDisplay.Name = "webDisplay"
        Me.webDisplay.Size = New System.Drawing.Size(659, 499)
        Me.webDisplay.TabIndex = 3
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 549)
        Me.Controls.Add(Me.webDisplay)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WebBrowser"
        Me.Text = "WebBrowser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents webDisplay As System.Windows.Forms.WebBrowser
End Class
