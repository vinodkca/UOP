<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeData
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
        Me.gbxEmployeeData = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEmpNum = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblExt = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblEmpNum = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lbMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbxDept = New System.Windows.Forms.ComboBox()
        Me.gbxEmployeeData.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxEmployeeData
        '
        Me.gbxEmployeeData.Controls.Add(Me.cbxDept)
        Me.gbxEmployeeData.Controls.Add(Me.txtEmail)
        Me.gbxEmployeeData.Controls.Add(Me.txtExt)
        Me.gbxEmployeeData.Controls.Add(Me.txtTel)
        Me.gbxEmployeeData.Controls.Add(Me.txtEmpNum)
        Me.gbxEmployeeData.Controls.Add(Me.txtLast)
        Me.gbxEmployeeData.Controls.Add(Me.txtMiddle)
        Me.gbxEmployeeData.Controls.Add(Me.txtFirst)
        Me.gbxEmployeeData.Controls.Add(Me.lblEmail)
        Me.gbxEmployeeData.Controls.Add(Me.lblExt)
        Me.gbxEmployeeData.Controls.Add(Me.lblTel)
        Me.gbxEmployeeData.Controls.Add(Me.lblDepartment)
        Me.gbxEmployeeData.Controls.Add(Me.lblEmpNum)
        Me.gbxEmployeeData.Controls.Add(Me.lblLastName)
        Me.gbxEmployeeData.Controls.Add(Me.lbMiddleName)
        Me.gbxEmployeeData.Controls.Add(Me.lblFirstName)
        Me.gbxEmployeeData.Location = New System.Drawing.Point(25, 23)
        Me.gbxEmployeeData.Name = "gbxEmployeeData"
        Me.gbxEmployeeData.Size = New System.Drawing.Size(231, 258)
        Me.gbxEmployeeData.TabIndex = 0
        Me.gbxEmployeeData.TabStop = False
        Me.gbxEmployeeData.Text = "Enter Employee Data"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(112, 210)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 14
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(112, 185)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(100, 20)
        Me.txtExt.TabIndex = 13
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(112, 160)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 12
        '
        'txtEmpNum
        '
        Me.txtEmpNum.Location = New System.Drawing.Point(112, 109)
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpNum.TabIndex = 11
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(112, 84)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 10
        '
        'txtMiddle
        '
        Me.txtMiddle.Location = New System.Drawing.Point(112, 59)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(100, 20)
        Me.txtMiddle.TabIndex = 9
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(112, 34)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(15, 216)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(79, 13)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "E-mail Address:"
        '
        'lblExt
        '
        Me.lblExt.AutoSize = True
        Me.lblExt.Location = New System.Drawing.Point(38, 190)
        Me.lblExt.Name = "lblExt"
        Me.lblExt.Size = New System.Drawing.Size(56, 13)
        Me.lblExt.TabIndex = 6
        Me.lblExt.Text = "Extension:"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(33, 164)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(61, 13)
        Me.lblTel.TabIndex = 5
        Me.lblTel.Text = "Telephone:"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(29, 138)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(65, 13)
        Me.lblDepartment.TabIndex = 4
        Me.lblDepartment.Text = "Department:"
        '
        'lblEmpNum
        '
        Me.lblEmpNum.AutoSize = True
        Me.lblEmpNum.Location = New System.Drawing.Point(-2, 112)
        Me.lblEmpNum.Name = "lblEmpNum"
        Me.lblEmpNum.Size = New System.Drawing.Size(96, 13)
        Me.lblEmpNum.TabIndex = 3
        Me.lblEmpNum.Text = "Employee Number:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(33, 86)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'lbMiddleName
        '
        Me.lbMiddleName.AutoSize = True
        Me.lbMiddleName.Location = New System.Drawing.Point(22, 60)
        Me.lbMiddleName.Name = "lbMiddleName"
        Me.lbMiddleName.Size = New System.Drawing.Size(72, 13)
        Me.lbMiddleName.TabIndex = 1
        Me.lbMiddleName.Text = "Middle Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(34, 34)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(25, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(103, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbxDept
        '
        Me.cbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDept.FormattingEnabled = True
        Me.cbxDept.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.cbxDept.Location = New System.Drawing.Point(112, 134)
        Me.cbxDept.Name = "cbxDept"
        Me.cbxDept.Size = New System.Drawing.Size(100, 21)
        Me.cbxDept.Sorted = True
        Me.cbxDept.TabIndex = 15
        '
        'frmEmployeeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 387)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxEmployeeData)
        Me.Name = "frmEmployeeData"
        Me.Text = "Employee Data"
        Me.gbxEmployeeData.ResumeLayout(False)
        Me.gbxEmployeeData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxEmployeeData As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtExt As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpNum As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddle As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblExt As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblEmpNum As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lbMiddleName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cbxDept As System.Windows.Forms.ComboBox
End Class
