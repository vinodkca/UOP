<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkshopSelectorForm
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
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.lstCost = New System.Windows.Forms.ListBox()
        Me.lblWorkshop = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.Location = New System.Drawing.Point(30, 31)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(120, 95)
        Me.lstWorkshop.TabIndex = 0
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(180, 34)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(120, 95)
        Me.lstLocation.TabIndex = 1
        '
        'lstCost
        '
        Me.lstCost.FormattingEnabled = True
        Me.lstCost.Location = New System.Drawing.Point(332, 34)
        Me.lstCost.Name = "lstCost"
        Me.lstCost.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstCost.Size = New System.Drawing.Size(120, 95)
        Me.lstCost.TabIndex = 2
        '
        'lblWorkshop
        '
        Me.lblWorkshop.AutoSize = True
        Me.lblWorkshop.Location = New System.Drawing.Point(27, 15)
        Me.lblWorkshop.Name = "lblWorkshop"
        Me.lblWorkshop.Size = New System.Drawing.Size(89, 13)
        Me.lblWorkshop.TabIndex = 3
        Me.lblWorkshop.Text = "Pick a Workshop"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(177, 15)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(81, 13)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Pick a Location"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(329, 15)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(64, 13)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "List of Costs"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(76, 155)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "Total Cost"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(180, 155)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 7
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(134, 202)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 38)
        Me.btnTotal.TabIndex = 8
        Me.btnTotal.Text = "Calculate Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(225, 202)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 38)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 202)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(43, 202)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 38)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add Workshop"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'WorkshopSelectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 262)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblWorkshop)
        Me.Controls.Add(Me.lstCost)
        Me.Controls.Add(Me.lstLocation)
        Me.Controls.Add(Me.lstWorkshop)
        Me.Name = "WorkshopSelectorForm"
        Me.Text = "WorkshopSelectorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWorkshop As System.Windows.Forms.ListBox
    Friend WithEvents lstLocation As System.Windows.Forms.ListBox
    Friend WithEvents lstCost As System.Windows.Forms.ListBox
    Friend WithEvents lblWorkshop As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
