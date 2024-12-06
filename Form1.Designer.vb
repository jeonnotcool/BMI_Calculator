<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbImperial = New System.Windows.Forms.RadioButton()
        Me.rbMetric = New System.Windows.Forms.RadioButton()
        Me.reset = New System.Windows.Forms.Button()
        Me.calculate = New System.Windows.Forms.Button()
        Me.hShort = New System.Windows.Forms.Label()
        Me.wShort = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.calcLabel = New System.Windows.Forms.Label()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.weighLabel = New System.Windows.Forms.Label()
        Me.main_title = New System.Windows.Forms.Label()
        Me.calculated = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbImperial)
        Me.GroupBox1.Controls.Add(Me.rbMetric)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 57)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit"
        '
        'rbImperial
        '
        Me.rbImperial.AutoSize = True
        Me.rbImperial.Location = New System.Drawing.Point(93, 23)
        Me.rbImperial.Name = "rbImperial"
        Me.rbImperial.Size = New System.Drawing.Size(89, 17)
        Me.rbImperial.TabIndex = 1
        Me.rbImperial.Text = "imperial lbs/in"
        Me.rbImperial.UseVisualStyleBackColor = True
        '
        'rbMetric
        '
        Me.rbMetric.AutoSize = True
        Me.rbMetric.Location = New System.Drawing.Point(6, 23)
        Me.rbMetric.Name = "rbMetric"
        Me.rbMetric.Size = New System.Drawing.Size(81, 17)
        Me.rbMetric.TabIndex = 0
        Me.rbMetric.Text = "metric kg/m"
        Me.rbMetric.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.reset.Location = New System.Drawing.Point(396, 467)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(190, 49)
        Me.reset.TabIndex = 46
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'calculate
        '
        Me.calculate.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.calculate.Location = New System.Drawing.Point(124, 467)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(190, 49)
        Me.calculate.TabIndex = 45
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'hShort
        '
        Me.hShort.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hShort.Location = New System.Drawing.Point(235, 240)
        Me.hShort.Name = "hShort"
        Me.hShort.Size = New System.Drawing.Size(78, 45)
        Me.hShort.TabIndex = 44
        Me.hShort.Text = "m"
        '
        'wShort
        '
        Me.wShort.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wShort.Location = New System.Drawing.Point(235, 142)
        Me.wShort.Name = "wShort"
        Me.wShort.Size = New System.Drawing.Size(78, 45)
        Me.wShort.TabIndex = 43
        Me.wShort.Text = "kg"
        '
        'StatusLabel
        '
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(386, 229)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(171, 38)
        Me.StatusLabel.TabIndex = 42
        Me.StatusLabel.Text = "Status"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.White
        Me.Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Status.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Status.Location = New System.Drawing.Point(391, 281)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(342, 38)
        Me.Status.TabIndex = 41
        '
        'calcLabel
        '
        Me.calcLabel.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcLabel.Location = New System.Drawing.Point(386, 120)
        Me.calcLabel.Name = "calcLabel"
        Me.calcLabel.Size = New System.Drawing.Size(200, 38)
        Me.calcLabel.TabIndex = 40
        Me.calcLabel.Text = "Calculated BMI"
        '
        'heightLabel
        '
        Me.heightLabel.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightLabel.Location = New System.Drawing.Point(31, 201)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(246, 36)
        Me.heightLabel.TabIndex = 39
        Me.heightLabel.Text = "Height in meters"
        '
        'weighLabel
        '
        Me.weighLabel.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weighLabel.Location = New System.Drawing.Point(31, 105)
        Me.weighLabel.Name = "weighLabel"
        Me.weighLabel.Size = New System.Drawing.Size(218, 34)
        Me.weighLabel.TabIndex = 38
        Me.weighLabel.Text = "Weight in kg"
        '
        'main_title
        '
        Me.main_title.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_title.Location = New System.Drawing.Point(12, 37)
        Me.main_title.Name = "main_title"
        Me.main_title.Size = New System.Drawing.Size(383, 57)
        Me.main_title.TabIndex = 37
        Me.main_title.Text = "BMI Calculator"
        '
        'calculated
        '
        Me.calculated.BackColor = System.Drawing.Color.White
        Me.calculated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.calculated.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.calculated.Location = New System.Drawing.Point(391, 158)
        Me.calculated.Name = "calculated"
        Me.calculated.Size = New System.Drawing.Size(244, 38)
        Me.calculated.TabIndex = 36
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtHeight.Location = New System.Drawing.Point(33, 240)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(193, 38)
        Me.txtHeight.TabIndex = 35
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtWeight.Location = New System.Drawing.Point(36, 142)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(193, 38)
        Me.txtWeight.TabIndex = 34
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1088, 24)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.TagalogToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'TagalogToolStripMenuItem
        '
        Me.TagalogToolStripMenuItem.Name = "TagalogToolStripMenuItem"
        Me.TagalogToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TagalogToolStripMenuItem.Text = "Tagalog"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.hShort)
        Me.Controls.Add(Me.wShort)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.calcLabel)
        Me.Controls.Add(Me.heightLabel)
        Me.Controls.Add(Me.weighLabel)
        Me.Controls.Add(Me.main_title)
        Me.Controls.Add(Me.calculated)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbImperial As RadioButton
    Friend WithEvents rbMetric As RadioButton
    Friend WithEvents reset As Button
    Friend WithEvents calculate As Button
    Friend WithEvents hShort As Label
    Friend WithEvents wShort As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Status As Label
    Friend WithEvents calcLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents weighLabel As Label
    Friend WithEvents main_title As Label
    Friend WithEvents calculated As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
