
'// GMUpdateApp
'// 2023/02/15 revised 2024/12/03 GMGuillergan LLC.

'// This application is revised as part of the BMIMe project.
'// https://github.com/jeonnotcool/BMI_Calculator

Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.IO.Compression
Imports System.Reflection
Imports System.Drawing.Drawing2D
Imports System.Diagnostics

Public Class Updater

    ' Do not edit. Other components will not work.
    Private ReadOnly Property CurrentVersion As String
        Get
            Return My.Settings.VersionNumber
        End Get
    End Property
    Private updateDownloaded As Boolean = False
    Private Const GitHubRepo As String = "jeonnotcool/BMI_Calculator"
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpdate.Enabled = False
        ProgressBar1.Value = 0
        VersionLabel.Text = $"Version {CurrentVersion} (Alpha)" ' used this instead because concatenation is complicated
        MakePanelRounded(Panel1)
        Await CheckForUpdates()
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

    Private Async Function CheckForUpdates() As Task
        Try
            lblStatus.Text = "Checking for updates..."
            Await Task.Delay(1000) ' Wait to initialize

            Using client As New HttpClient()
                client.DefaultRequestHeaders.Add("User-Agent", "request")
                Dim response As HttpResponseMessage = Await client.GetAsync($"https://api.github.com/repos/{GitHubRepo}/releases/latest")
                response.EnsureSuccessStatusCode()

                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim latestRelease As JObject = JObject.Parse(responseBody)
                Dim latestVersion As String = latestRelease("tag_name").ToString()

                If IsNewerVersion(latestVersion, CurrentVersion) Then
                    lblStatus.Text = "Update available"
                    txtReleaseNotes.Text = latestRelease("body").ToString()
                    btnUpdate.Text = "Download Update"
                    btnUpdate.Enabled = True
                Else
                    lblStatus.Text = "No update available."
                    txtReleaseNotes.Text = "You are using the latest version."
                End If
            End Using
        Catch ex As Exception
            lblStatus.Text = "Error checking for updates."
            MessageBox.Show($"Error checking for updates: {ex.Message}", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Function IsNewerVersion(latestVersion As String, currentVersion As String) As Boolean
        Dim latest As Version = New Version(latestVersion.TrimStart("v"c))
        Dim current As Version = New Version(currentVersion.TrimStart("v"c))
        Return latest.CompareTo(current) > 0
    End Function

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Download Update" Then
            btnUpdate.Enabled = False
            lblStatus.Text = "Downloading update..."
            ProgressBar1.Value = 0
            Await DownloadAndUpdate()
            btnUpdate.Text = "Install and Restart"
            updateDownloaded = True
            btnUpdate.Enabled = True
        ElseIf updateDownloaded AndAlso btnUpdate.Text = "Install and Restart" Then
            InstallAndRestart()
        End If
    End Sub

    Private Async Function DownloadAndUpdate() As Task
        Try
            Dim downloadUrl As String = Await GetDownloadUrl()
            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "update.zip")

            Using client As New HttpClient()
                Using response As HttpResponseMessage = Await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead)
                    response.EnsureSuccessStatusCode()
                    Using fileStream As New FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None)
                        Await response.Content.CopyToAsync(fileStream)
                    End Using
                End Using
            End Using

            lblStatus.Text = "Extracting update..."
            ProgressBar1.Value = 50
            Dim extractPath As String = Path.Combine(Path.GetTempPath(), "update")
            If Directory.Exists(extractPath) Then
                Directory.Delete(extractPath, True)
            End If
            ZipFile.ExtractToDirectory(tempFilePath, extractPath)

            lblStatus.Text = "Update downloaded."
            ProgressBar1.Value = 100
            updateDownloaded = True
        Catch ex As Exception
            lblStatus.Text = "Error downloading update."
            MessageBox.Show($"Error downloading update: {ex.Message}", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub InstallAndRestart()
        Try
            Dim currentPath As String = Application.StartupPath
            Dim exePath As String = Path.Combine(currentPath, "BMIMe.exe")

            If Not File.Exists(exePath) Then
                lblStatus.Text = "Update Failed."
                MessageBox.Show("BMIMe is not installed. (how did you get this?)", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim processes As Process() = Process.GetProcessesByName("BMIMe")
            For Each process As Process In processes
                process.Kill()
                process.WaitForExit()
            Next
            lblStatus.Text = "Installing update..."
            Dim extractPath As String = Path.Combine(Path.GetTempPath(), "update")

            For Each filez In Directory.GetFiles(extractPath)
                lblStatus.Text = "Copying Files..."
                Dim fileName As String = Path.GetFileName(filez)
                Dim destinationFile As String = Path.Combine(currentPath, fileName)
                If Not fileName.Equals("gmupdateapp.exe", StringComparison.OrdinalIgnoreCase) AndAlso
                   Not fileName.Equals("Newtonsoft.Json.dll", StringComparison.OrdinalIgnoreCase) AndAlso
                   Not fileName.Equals("Newtonsoft.Json.xml", StringComparison.OrdinalIgnoreCase) Then
                    File.Copy(filez, destinationFile, True)
                End If
                lblStatus.Text = "Finalizing update..."
            Next

            lblStatus.Text = "Update installed. Restarting application..."
            Process.Start(Application.ExecutablePath)
            Application.Exit()

        Catch ex As Exception
            lblStatus.Text = "Error installing update."
            MessageBox.Show($"Error installing update: {ex.Message}", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Async Function GetDownloadUrl() As Task(Of String)
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "request")
            Dim response As HttpResponseMessage = Await client.GetAsync($"https://api.github.com/repos/{GitHubRepo}/releases/latest")
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim latestRelease As JObject = JObject.Parse(responseBody)
            Dim downloadUrl As String = latestRelease("assets")(0)("browser_download_url").ToString()
            Return downloadUrl
        End Using
    End Function

End Class
