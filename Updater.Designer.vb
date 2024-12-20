<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Updater
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtReleaseNotes = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.NameApp = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtReleaseNotes)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(289, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 468)
        Me.Panel1.TabIndex = 53
        '
        'txtReleaseNotes
        '
        Me.txtReleaseNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtReleaseNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReleaseNotes.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!)
        Me.txtReleaseNotes.Location = New System.Drawing.Point(34, 65)
        Me.txtReleaseNotes.Name = "txtReleaseNotes"
        Me.txtReleaseNotes.ReadOnly = True
        Me.txtReleaseNotes.Size = New System.Drawing.Size(437, 386)
        Me.txtReleaseNotes.TabIndex = 51
        Me.txtReleaseNotes.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 30)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Release Notes:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(68, 377)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(140, 23)
        Me.ProgressBar1.TabIndex = 57
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(68, 317)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 41)
        Me.btnUpdate.TabIndex = 56
        Me.btnUpdate.Text = "Download Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(39, 266)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(201, 36)
        Me.lblStatus.TabIndex = 55
        Me.lblStatus.Text = "No updates available"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BMIMe.My.Resources.Resources.B__1_
        Me.PictureBox1.Location = New System.Drawing.Point(104, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(51, 220)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(177, 30)
        Me.VersionLabel.TabIndex = 52
        Me.VersionLabel.Text = "Version x.x.x (Alpha)"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameApp
        '
        Me.NameApp.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameApp.Location = New System.Drawing.Point(67, 174)
        Me.NameApp.Name = "NameApp"
        Me.NameApp.Size = New System.Drawing.Size(141, 36)
        Me.NameApp.TabIndex = 51
        Me.NameApp.Text = "BMIMe"
        Me.NameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(787, 492)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.NameApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Updater"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMIMe Updater"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtReleaseNotes As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents NameApp As Label
End Class
