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
Imports System.Text.Json
Imports System.Threading

Public Class Updater

    ' Do not edit. Other components will not work.
    Private ReadOnly Property CurrentVersion As String
        Get
            Return My.Settings.VersionNumber
        End Get
    End Property
    Private updateDownloaded As Boolean = False
    Private Const GitHubRepo As String = "jeonnotcool/BMI_Calculator"
    Private languages As Dictionary(Of String, Dictionary(Of String, String))

    Private Const SettingsFile As String = "settings.txt"

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpdate.Enabled = False
        ProgressBar1.Value = 0
        VersionLabel.Text = $"Version {CurrentVersion} (Alpha)" ' used this instead because concatenation is complicated
        MakePanelRounded(Panel1)
        LoadLanguagesFromJson("translations.json")
        LoadLocalizedStrings()
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
            lblStatus.Text = GetTranslation("updater.lblStatus.checking")
            Await Task.Delay(1000) ' Wait to initialize

            Using client As New HttpClient()
                client.DefaultRequestHeaders.Add("User-Agent", "request")
                Dim response As HttpResponseMessage = Await client.GetAsync($"https://api.github.com/repos/{GitHubRepo}/releases/latest")
                response.EnsureSuccessStatusCode()

                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim latestRelease As JObject = JObject.Parse(responseBody)
                Dim latestVersion As String = latestRelease("tag_name").ToString()

                If IsNewerVersion(latestVersion, CurrentVersion) Then
                    lblStatus.Text = GetTranslation("updater.lblStatus.available")
                    txtReleaseNotes.Text = latestRelease("body").ToString()
                    btnUpdate.Text = GetTranslation("updater.btnUpdate")
                    btnUpdate.Enabled = True
                Else
                    lblStatus.Text = GetTranslation("updater.lblStatus.none")
                    txtReleaseNotes.Text = GetTranslation("updater.txtReleaseNotes.latest")
                End If
            End Using
        Catch ex As Exception
            lblStatus.Text = GetTranslation("updater.lblStatus.error")
            MessageBox.Show(String.Format(GetTranslation("updater.error.checking"), ex.Message), "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Function IsNewerVersion(latestVersion As String, currentVersion As String) As Boolean
        Dim latest As Version = New Version(latestVersion.TrimStart("v"c))
        Dim current As Version = New Version(currentVersion.TrimStart("v"c))
        Return latest.CompareTo(current) > 0
    End Function

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = GetTranslation("updater.btnUpdate") Then
            btnUpdate.Enabled = False
            lblStatus.Text = GetTranslation("updater.lblStatus.downloading")
            ProgressBar1.Value = 0
            Await DownloadAndUpdate()
            btnUpdate.Text = GetTranslation("updater.btnUpdate.install")
            updateDownloaded = True
            btnUpdate.Enabled = True
        ElseIf updateDownloaded AndAlso btnUpdate.Text = GetTranslation("updater.btnUpdate.install") Then
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

            lblStatus.Text = GetTranslation("updater.lblStatus.extracting")
            ProgressBar1.Value = 50
            Dim extractPath As String = Path.Combine(Path.GetTempPath(), "update")
            If Directory.Exists(extractPath) Then
                Directory.Delete(extractPath, True)
            End If
            ZipFile.ExtractToDirectory(tempFilePath, extractPath)

            lblStatus.Text = GetTranslation("updater.lblStatus.downloaded")
            ProgressBar1.Value = 100
            updateDownloaded = True
        Catch ex As Exception
            lblStatus.Text = GetTranslation("updater.lblStatus.error")
            MessageBox.Show(String.Format(GetTranslation("updater.error.downloading"), ex.Message), "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub InstallAndRestart()
        Try
            Dim currentPath As String = Application.StartupPath
            Dim exePath As String = Path.Combine(currentPath, "BMIMe.exe")

            If Not File.Exists(exePath) Then
                lblStatus.Text = GetTranslation("updater.lblStatus.updateFailed")
                MessageBox.Show(GetTranslation("updater.error.notInstalled"), "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim processes As Process() = Process.GetProcessesByName("BMIMe")
            For Each process As Process In processes
                process.Kill()
                process.WaitForExit()
            Next
            lblStatus.Text = GetTranslation("updater.lblStatus.installing")
            Dim extractPath As String = Path.Combine(Path.GetTempPath(), "update")

            For Each filez In Directory.GetFiles(extractPath)
                lblStatus.Text = GetTranslation("updater.lblStatus.copying")
                Dim fileName As String = Path.GetFileName(filez)
                Dim destinationFile As String = Path.Combine(currentPath, fileName)
                If Not fileName.Equals("gmupdateapp.exe", StringComparison.OrdinalIgnoreCase) AndAlso
                   Not fileName.Equals("Newtonsoft.Json.dll", StringComparison.OrdinalIgnoreCase) AndAlso
                   Not fileName.Equals("Newtonsoft.Json.xml", StringComparison.OrdinalIgnoreCase) Then
                    File.Copy(filez, destinationFile, True)
                End If
                lblStatus.Text = GetTranslation("updater.lblStatus.finalizing")
            Next

            lblStatus.Text = GetTranslation("updater.lblStatus.installed")
            Process.Start(Application.ExecutablePath)
            Application.Exit()

        Catch ex As Exception
            lblStatus.Text = GetTranslation("updater.lblStatus.error")
            MessageBox.Show(String.Format(GetTranslation("updater.error.installing"), ex.Message), "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    ' Load localized strings
    Private Sub LoadLocalizedStrings()
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) Then
            Dim translations = languages(currentLanguage)

            If translations.ContainsKey("updater.btnUpdate") Then
                btnUpdate.Text = If(updateDownloaded, translations("updater.btnUpdate.install"), translations("updater.btnUpdate"))
            End If

            If translations.ContainsKey("updater.lblStatus.checking") Then
                lblStatus.Text = translations("updater.lblStatus.checking")
            End If

            If translations.ContainsKey("updater.versionLabel") Then
                VersionLabel.Text = String.Format(translations("updater.versionLabel"), CurrentVersion)
            End If

            ' Update other controls as needed
        Else
            MessageBox.Show($"Language '{currentLanguage}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' Get language from settings file
    Private Function GetLanguageFromSettings() As String
        Dim language As String = "en-US" ' Default

        Try
            If File.Exists(SettingsFile) Then
                Using reader As New StreamReader(SettingsFile)
                    reader.ReadLine() ' Skip unit system line
                    language = reader.ReadLine() ' Read language line
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading language from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return language
    End Function

    ' Load translations from JSON
    Private Sub LoadLanguagesFromJson(filename As String)
        Try
            Dim jsonString = File.ReadAllText(filename)
            languages = JsonSerializer.Deserialize(Of Dictionary(Of String, Dictionary(Of String, String)))(jsonString)

        Catch ex As Exception
            MessageBox.Show("Error loading translations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Get translation for a specific key
    Private Function GetTranslation(key As String) As String
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) AndAlso languages(currentLanguage).ContainsKey(key) Then
            Return languages(currentLanguage)(key)
        Else
            Return $"Missing translation: {key}"
        End If
    End Function

End Class
