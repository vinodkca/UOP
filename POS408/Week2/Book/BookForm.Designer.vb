<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtISDN = New System.Windows.Forms.TextBox()
        Me.lblISDN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(50, 20)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(63, 13)
        Me.lblBookName.TabIndex = 0
        Me.lblBookName.Text = "Book Name"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(120, 20)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(100, 20)
        Me.txtBookName.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(120, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtISDN
        '
        Me.txtISDN.Location = New System.Drawing.Point(120, 62)
        Me.txtISDN.Name = "txtISDN"
        Me.txtISDN.Size = New System.Drawing.Size(100, 20)
        Me.txtISDN.TabIndex = 4
        '
        'lblISDN
        '
        Me.lblISDN.AutoSize = True
        Me.lblISDN.Location = New System.Drawing.Point(50, 62)
        Me.lblISDN.Name = "lblISDN"
        Me.lblISDN.Size = New System.Drawing.Size(32, 13)
        Me.lblISDN.TabIndex = 3
        Me.lblISDN.Text = "ISBN"
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtISDN)
        Me.Controls.Add(Me.lblISDN)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.lblBookName)
        Me.Name = "BookForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtISDN As System.Windows.Forms.TextBox
    Friend WithEvents lblISDN As System.Windows.Forms.Label

End Class
