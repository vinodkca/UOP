<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINQForm
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
        Me.lstSample = New System.Windows.Forms.ListBox()
        Me.btnReadObjects = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReadXML = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSample
        '
        Me.lstSample.FormattingEnabled = True
        Me.lstSample.Location = New System.Drawing.Point(41, 46)
        Me.lstSample.Name = "lstSample"
        Me.lstSample.Size = New System.Drawing.Size(327, 95)
        Me.lstSample.TabIndex = 0
        '
        'btnReadObjects
        '
        Me.btnReadObjects.Location = New System.Drawing.Point(41, 186)
        Me.btnReadObjects.Name = "btnReadObjects"
        Me.btnReadObjects.Size = New System.Drawing.Size(75, 38)
        Me.btnReadObjects.TabIndex = 1
        Me.btnReadObjects.Text = "Read Objects"
        Me.btnReadObjects.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(392, 46)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReadXML
        '
        Me.btnReadXML.Location = New System.Drawing.Point(123, 186)
        Me.btnReadXML.Name = "btnReadXML"
        Me.btnReadXML.Size = New System.Drawing.Size(75, 38)
        Me.btnReadXML.TabIndex = 3
        Me.btnReadXML.Text = "Read XML"
        Me.btnReadXML.UseVisualStyleBackColor = True
        '
        'LINQForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 262)
        Me.Controls.Add(Me.btnReadXML)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReadObjects)
        Me.Controls.Add(Me.lstSample)
        Me.Name = "LINQForm"
        Me.Text = "LINQ Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSample As System.Windows.Forms.ListBox
    Friend WithEvents btnReadObjects As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReadXML As System.Windows.Forms.Button

End Class
