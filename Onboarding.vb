Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.Json
Imports Microsoft.Win32
Imports System.Windows.Forms


Public Class Onboarding
    Private Const SettingsFile As String = "settings.json"
    Private settings As Dictionary(Of String, String)
    Private languages As Dictionary(Of String, Dictionary(Of String, String))
    Dim UName As String

    ' Event handler for form load
    Private Sub Onboarding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user settings and translations
        Dim userSettings = LoadUserSettings()
        LoadLanguagesFromJson("translations.json")
        LoadLocalizedStrings()
        SetLanguageRadioButton()
        GoTab(welcome, welcome_letsgo)

        ' Check if all required settings have values
        If Not String.IsNullOrEmpty(userSettings.UnitSystem) AndAlso
           Not String.IsNullOrEmpty(userSettings.Language) AndAlso
           Not String.IsNullOrEmpty(userSettings.UserName) Then
            MessageBox.Show(GetTranslation("onboarding.interrupt_message"), "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Validate Settings
        UName = GetKeyFromSettings("UserName").ToString()
        txtName.Text = GetKeyFromSettings("UserName")
        usernameTab_next.Enabled = txtName.Text.Length >= 2

        ' Round corners of controls
        Round(Panel1)
        Round(PictureBox3)
        Round(WelcomeClubPic)
        Round(Panel2)
        Round(WelcomeClubPic)
    End Sub

    ' Event handler for form closing
    Private Sub Onboarding_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show(GetTranslation("onboarding.exit_message"), "BMIMe Onboarding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    ' Event handler for "Let's Go" button click
    Private Sub welcome_letsgo_Click(sender As Object, e As EventArgs) Handles welcome_letsgo.Click
        GoTab(usernameTab, usernameTab_next)
    End Sub

    ' Event handler for "Next" button click on username tab
    Private Sub usernameTab_next_Click(sender As Object, e As EventArgs) Handles usernameTab_next.Click
        GoTab(club)
        SaveSpecific("UserName", txtName.Text.ToString())
        supposed_name.Text = $"{LoadSettings("UserName")}!"
    End Sub

    ' Event handler for "Back" button click on username tab
    Private Sub usernameTab_back_Click(sender As Object, e As EventArgs) Handles usernameTab_back.Click
        GoTab(welcome, welcome_letsgo)
    End Sub

    ' Event handler for "Next" button click on club tab
    Private Sub club_next_Click(sender As Object, e As EventArgs) Handles club_next.Click
        GoTab(legalTab, legal_next)
        RoundAllControls(legalTab)
        System.Threading.Thread.Sleep(2000) ' Wait for 2 seconds
        legal_privacypolicy.Text = ObtainFromWeb("https://www.gmguillergan.com/bmipp.txt")
    End Sub

    ' Event handler for "Back" button click on club tab
    Private Sub club_back_Click(sender As Object, e As EventArgs) Handles club_back.Click
        GoTab(usernameTab, usernameTab_next)
    End Sub

    ' Event handler for username text change
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        usernameTab_next.Enabled = txtName.Text.Length >= 2
    End Sub

    ' Event handler for English language radio button checked change
    Private Sub welcome_english_CheckedChanged(sender As Object, e As EventArgs) Handles welcome_english.CheckedChanged
        welcome_letsgo.Enabled = True
        SaveSpecific("Language", "en-US")
        LoadLocalizedStrings()
    End Sub

    ' Event handler for Filipino language radio button checked change
    Private Sub welcome_filipino_CheckedChanged(sender As Object, e As EventArgs) Handles welcome_filipino.CheckedChanged
        welcome_letsgo.Enabled = True
        SaveSpecific("Language", "fil-PH")
        LoadLocalizedStrings()
    End Sub

    ' Sub to enable a specific tab, disable the rest, and optionally set the default button for the form
    Private Sub GoTab(tab As TabPage, Optional button As Button = Nothing)
        For Each t As TabPage In Onboard.TabPages
            t.Enabled = (t Is tab)
        Next
        Onboard.SelectedTab = tab
        If button IsNot Nothing Then
            Me.AcceptButton = button
        End If
    End Sub

    ' Sub to round all panels, textboxes, rich text boxes, and pictureboxes
    Private Sub RoundAllControls(parent As Control)
        For Each control As Control In parent.Controls
            If TypeOf control Is Panel OrElse TypeOf control Is TextBox OrElse TypeOf control Is RichTextBox OrElse TypeOf control Is PictureBox Then
                Round(control)
            End If
            If control.HasChildren Then
                RoundAllControls(control)
            End If
        Next
    End Sub

    ' Function to obtain data from a web link
    Private Function ObtainFromWeb(link As String) As String
        Try
            Using client As New Net.WebClient()
                Return client.DownloadString(link)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error obtaining data from web: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Set the language radio button based on settings
    Private Sub SetLanguageRadioButton()
        Dim currentLanguage = GetLanguageFromSettings()
        If currentLanguage = "en-US" Then
            welcome_english.Checked = True
        ElseIf currentLanguage = "fil-PH" Then
            welcome_filipino.Checked = True
        End If
    End Sub


    ' Function to count all controls in the form
    Private Function CountAllControls(parent As Control) As Integer
        Dim count As Integer = parent.Controls.Count
        For Each control As Control In parent.Controls
            If control.HasChildren Then
                count += CountAllControls(control)
            End If
        Next
        Return count
    End Function

    ' Stop the user from switching tabs using Ctrl + Tab or Ctrl + Shift + E.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.Tab) Then
            ' Handle Ctrl + Tab key press
            MessageBox.Show("what you're doing is illegal", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.Shift Or Keys.E) Then
            ' Handle Ctrl + Shift + E key press
            Dim totalControls As Integer = CountAllControls(Me) + CountAllControls(MainForm) + CountAllControls(About) + CountAllControls(Result) + CountAllControls(BMI_Result) + CountAllControls(Updater)
            MessageBox.Show($"Total controls in this app is: {totalControls & vbCrLf}Breakdown: Me :{CountAllControls(Me) & vbCrLf}MainForm :{CountAllControls(MainForm) & vbCrLf}About :{CountAllControls(About) & vbCrLf}Result :{CountAllControls(Result) & vbCrLf}BMI_Result :{CountAllControls(BMI_Result) & vbCrLf}Updater :{CountAllControls(Updater)})", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Round the corners of a control
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

    ' Registry related methods
    ' Function to get a DWORD value from HKCU
    Private Function GetKeyonHKCU(keyName As String) As Integer
        Try
            Using key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\GMGuillergan\BMIMe")
                If key IsNot Nothing Then
                    Return Convert.ToInt32(key.GetValue(keyName, 0))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading registry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    ' Function to get a DWORD value from HKLM
    Private Function GetKeyonHKLM(keyName As String) As Integer
        Try
            Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GMGuillergan\BMIMe")
                If key IsNot Nothing Then
                    Return Convert.ToInt32(key.GetValue(keyName, 0))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading registry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    ' Function to set a DWORD value in HKCU
    Private Sub SetKeyonHKCU(keyName As String, value As Integer)
        Try
            Using key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\GMGuillergan\BMIMe")
                If key IsNot Nothing Then
                    key.SetValue(keyName, value, RegistryValueKind.DWord)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error writing to registry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to set a DWORD value in HKLM
    Private Sub SetKeyonHKLM(keyName As String, value As Integer)
        Try
            Using key As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\GMGuillergan\BMIMe")
                If key IsNot Nothing Then
                    key.SetValue(keyName, value, RegistryValueKind.DWord)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error writing to registry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Ask for admin rights
    Private Sub AskForAdminRights()
        Dim result As DialogResult = MessageBox.Show("BMIMe requires administrator rights to continue. Do you want to restart the app with admin rights?", "BMIMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim startInfo As New ProcessStartInfo With {
                .FileName = Application.ExecutablePath,
                .UseShellExecute = True,
                .Verb = "runas"
            }
            Process.Start(startInfo)
            Application.Exit()
        End If
    End Sub

    ' Validate if the user has admin rights
    Private Function IsUserAdmin() As Boolean
        Try
            Dim identity = System.Security.Principal.WindowsIdentity.GetCurrent()
            Dim principal = New System.Security.Principal.WindowsPrincipal(identity)
            Return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)
        Catch ex As Exception
            MessageBox.Show("Error checking admin rights: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Settings related methods
    ' Class to hold user settings
    Public Class UserSettings
        Public Property UnitSystem As String
        Public Property Language As String
        Public Property UserName As String
    End Class

    ' Load a specific setting from the settings file
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

    ' Save a specific setting to the settings file
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

    ' Save user settings to the settings file
    Private Sub SaveUserSettings(userSettings As UserSettings)
        Try
            Dim jsonString = JsonSerializer.Serialize(userSettings)
            File.WriteAllText(SettingsFile, jsonString)
        Catch ex As Exception
            MessageBox.Show("Error saving user settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load user settings from the settings file
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

    ' Get a specific key from the settings file
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

    ' Language related methods
    ' Load languages from a JSON file
    Private Sub LoadLanguagesFromJson(filename As String)
        Try
            Dim jsonString = File.ReadAllText(filename)
            languages = JsonSerializer.Deserialize(Of Dictionary(Of String, Dictionary(Of String, String)))(jsonString)
        Catch ex As Exception
            MessageBox.Show("Error loading translations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load localized strings based on the current language
    Private Sub LoadLocalizedStrings()
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) Then
            Dim translations = languages(currentLanguage)
            UpdateControlText(Me, translations)
        Else
            MessageBox.Show($"Language '{currentLanguage}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Update the text of controls based on translations
    Private Sub UpdateControlText(parent As Control, translations As Dictionary(Of String, String))
        For Each control As Control In parent.Controls
            If translations.ContainsKey($"onboarding.{control.Name}") Then
                control.Text = translations($"onboarding.{control.Name}")
            End If
            If control.HasChildren Then
                UpdateControlText(control, translations)
            End If
        Next
    End Sub

    ' Get the current language from the settings file
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

    ' Get a translation for a specific key
    Private Function GetTranslation(key As String) As String
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) AndAlso languages(currentLanguage).ContainsKey(key) Then
            Return languages(currentLanguage)(key)
        Else
            Return $"Missing translation: {key}"
        End If
    End Function

    Private Sub legal_back_Click(sender As Object, e As EventArgs) Handles legal_back.Click
        GoTab(club, club_next)
    End Sub

    Private Sub legal_next_Click(sender As Object, e As EventArgs) Handles legal_next.Click
        GoTab(whuTab, whuTab_next)
    End Sub

    Private Sub whuTab_next_Click(sender As Object, e As EventArgs) Handles whuTab_next.Click
        GoTab(Summary)
    End Sub

    Private Sub whuTab_back_Click(sender As Object, e As EventArgs) Handles whuTab_back.Click
        GoTab(legalTab, legal_next)
    End Sub
End Class
