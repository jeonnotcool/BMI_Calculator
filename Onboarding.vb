Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.Json
Public Class Onboarding
    Private Const SettingsFile As String = "settings.json"
    Private settings As Dictionary(Of String, String)
    Private languages As Dictionary(Of String, Dictionary(Of String, String))
    Dim UName As String

    Private Sub Onboarding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserSettings()
        Dim userSettings = LoadUserSettings()
        LoadLanguagesFromJson("translations.json")
        LoadLocalizedStrings()
        SetLanguageRadioButton()

        ' Check if all required settings have values
        If Not String.IsNullOrEmpty(userSettings.UnitSystem) AndAlso
           Not String.IsNullOrEmpty(userSettings.Language) AndAlso
           Not String.IsNullOrEmpty(userSettings.UserName) Then
            MessageBox.Show(GetTranslation("interrupt_message"), "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Validate Settings
        txtName.Text = GetKeyFromSettings("UserName")
        Name_Next.Enabled = txtName.Text.Length >= 2

        Round(Panel1)
        Round(PictureBox3)
        Round(WelcomeClubPic)
        Round(Panel2)
        Round(WelcomeClubPic)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles welcome_letsgo.Click
        Onboard.SelectedTab = TabPage2
    End Sub

    Private Sub NameNext_Click(sender As Object, e As EventArgs) Handles Name_Next.Click
        Onboard.SelectedTab = TabPage3
        SaveSpecific("UserName", txtName.Text.ToString())
        supposed_name.Text = $"{LoadSettings("UserName")}!"
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Name_Next.Enabled = txtName.Text.Length >= 2
    End Sub

    Private Sub welcome_english_CheckedChanged(sender As Object, e As EventArgs) Handles welcome_english.CheckedChanged
        welcome_letsgo.Enabled = True
        SaveSpecific("Language", "en-US")
        LoadLocalizedStrings()
    End Sub

    Private Sub welcome_filipino_CheckedChanged(sender As Object, e As EventArgs) Handles welcome_filipino.CheckedChanged
        welcome_letsgo.Enabled = True
        SaveSpecific("Language", "fil-PH")
        LoadLocalizedStrings()
    End Sub

    Private Sub SetLanguageRadioButton()
        Dim currentLanguage = GetLanguageFromSettings()
        If currentLanguage = "en-US" Then
            welcome_english.Checked = True
        ElseIf currentLanguage = "fil-PH" Then
            welcome_filipino.Checked = True
        End If
    End Sub

    Private Sub Round(panel As Control)
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

    Private Function LoadSettings(keyToCheck As String) As String
        Try
            If Not File.Exists(SettingsFile) Then
                File.WriteAllText(SettingsFile, "{}")
            End If

            Dim jsonString = File.ReadAllText(SettingsFile)
            settings = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)

            If settings.ContainsKey(keyToCheck) Then
                Return settings(keyToCheck)
            Else
                MessageBox.Show($"Key '{keyToCheck}' doesn't exist", "Key Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Private Sub SaveSpecific(key As String, value As String)
        Try
            If File.Exists(SettingsFile) Then
                Dim jsonString = File.ReadAllText(SettingsFile)
                settings = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)
            Else
                settings = New Dictionary(Of String, String)()
            End If

            settings(key) = value

            Dim updatedJsonString = JsonSerializer.Serialize(settings)
            File.WriteAllText(SettingsFile, updatedJsonString)
        Catch ex As Exception
            MessageBox.Show("Error saving settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveUserSettings(userSettings As UserSettings)
        Try
            Dim jsonString = JsonSerializer.Serialize(userSettings)
            File.WriteAllText(SettingsFile, jsonString)
        Catch ex As Exception
            MessageBox.Show("Error saving user settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function LoadUserSettings() As UserSettings
        Try
            If Not File.Exists(SettingsFile) Then
                Dim defaultSettings As New UserSettings With {
                    .UnitSystem = "Metric",
                    .Language = "en-US",
                    .UserName = ""
                }

                Dim defaultJsonString = JsonSerializer.Serialize(defaultSettings)
                File.WriteAllText(SettingsFile, defaultJsonString)
            End If

            Dim jsonString = File.ReadAllText(SettingsFile)
            Return JsonSerializer.Deserialize(Of UserSettings)(jsonString)
        Catch ex As Exception
            MessageBox.Show("Error reading user settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Private Sub LoadLocalizedStrings()
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) Then
            Dim translations = languages(currentLanguage)
            UpdateControlText(Me, translations)
        Else
            MessageBox.Show($"Language '{currentLanguage}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdateControlText(parent As Control, translations As Dictionary(Of String, String))
        For Each control As Control In parent.Controls
            If translations.ContainsKey(control.Name) Then
                control.Text = translations(control.Name)
            End If
            If control.HasChildren Then
                UpdateControlText(control, translations)
            End If
        Next
    End Sub

    Private Function GetLanguageFromSettings() As String
        Dim language As String = "en-US"

        Try
            If File.Exists(SettingsFile) Then
                Dim jsonString = File.ReadAllText(SettingsFile)
                Dim settings = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)
                If settings.ContainsKey("Language") Then
                    language = settings("Language")

                    If Not languages.ContainsKey(language) Then
                        MessageBox.Show($"Invalid language '{language}' in settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        language = "en-US"
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading language from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return language
    End Function

    Private Function GetKeyFromSettings(key As String) As String
        Try
            If File.Exists(SettingsFile) Then
                Dim jsonString = File.ReadAllText(SettingsFile)
                Dim settings = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)
                If settings.ContainsKey(key) Then
                    Return settings(key)
                Else
                    MessageBox.Show($"Key '{key}' not found in settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading key from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Private Sub LoadLanguagesFromJson(filename As String)
        Try
            Dim jsonString = File.ReadAllText(filename)
            languages = JsonSerializer.Deserialize(Of Dictionary(Of String, Dictionary(Of String, String)))(jsonString)
        Catch ex As Exception
            MessageBox.Show("Error loading translations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetTranslation(key As String) As String
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) AndAlso languages(currentLanguage).ContainsKey(key) Then
            Return languages(currentLanguage)(key)
        Else
            Return $"Missing translation: {key}"
        End If
    End Function

    Public Class UserSettings
        Public Property UnitSystem As String
        Public Property Language As String
        Public Property UserName As String
    End Class
End Class