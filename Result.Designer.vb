<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Me.NameApp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameApp
        '
        Me.NameApp.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 20.0!, System.Drawing.FontStyle.Bold)
        Me.NameApp.Location = New System.Drawing.Point(10, 58)
        Me.NameApp.Name = "NameApp"
        Me.NameApp.Size = New System.Drawing.Size(243, 36)
        Me.NameApp.TabIndex = 43
        Me.NameApp.Text = "Your BMI Result"
        Me.NameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(28, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 72)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "23.5"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameApp)
        Me.Name = "Result"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Result"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NameApp As Label
    Friend WithEvents Label1 As Label
End Class
