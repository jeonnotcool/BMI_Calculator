Imports System.Drawing.Drawing2D

Public Class BMI_Result
    Private Sub BMI_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakePanelRounded(Panel1)
    End Sub


    Private Sub MakePanelRounded(panel As Panel)
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddLine(radius, 0, panel.Width - radius, 0)
        path.AddArc(New Rectangle(panel.Width - radius, 0, radius, radius), -90, 90)
        path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius)
        path.AddArc(New Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90)
        path.AddLine(panel.Width - radius, panel.Height, radius, panel.Height)
        path.AddArc(New Rectangle(0, panel.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

End Class