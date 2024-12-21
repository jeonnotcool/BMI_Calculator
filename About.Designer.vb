<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
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
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.NameApp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tyPlace = New System.Windows.Forms.Label()
        Me.NameUser = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VersionLabel
        '
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(51, 152)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(177, 30)
        Me.VersionLabel.TabIndex = 52
        Me.VersionLabel.Text = "Version x.x.x (Alpha)"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameApp
        '
        Me.NameApp.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameApp.Location = New System.Drawing.Point(67, 106)
        Me.NameApp.Name = "NameApp"
        Me.NameApp.Size = New System.Drawing.Size(141, 36)
        Me.NameApp.TabIndex = 51
        Me.NameApp.Text = "BMIMe"
        Me.NameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BMIMe.My.Resources.Resources.B__1_
        Me.PictureBox1.Location = New System.Drawing.Point(104, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'tyPlace
        '
        Me.tyPlace.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tyPlace.Location = New System.Drawing.Point(51, 191)
        Me.tyPlace.Name = "tyPlace"
        Me.tyPlace.Size = New System.Drawing.Size(177, 30)
        Me.tyPlace.TabIndex = 55
        Me.tyPlace.Text = "Thank you for using BMIMe,"
        Me.tyPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameUser
        '
        Me.NameUser.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameUser.Location = New System.Drawing.Point(51, 221)
        Me.NameUser.Name = "NameUser"
        Me.NameUser.Size = New System.Drawing.Size(177, 30)
        Me.NameUser.TabIndex = 56
        Me.NameUser.Text = "Gabriel Martin!"
        Me.NameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(67, 268)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 41)
        Me.btnUpdate.TabIndex = 57
        Me.btnUpdate.Text = "Check for Updates"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 39)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Copyright © 2024 GMGuillergan LLC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(279, 492)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.NameUser)
        Me.Controls.Add(Me.tyPlace)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.NameApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About BMIMe"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents NameApp As Label
    Friend WithEvents tyPlace As Label
    Friend WithEvents NameUser As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
End Class
