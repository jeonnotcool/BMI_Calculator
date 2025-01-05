'// BMIMe \ Onboarding.vb

'// This is used for the first-time setup of the application.

'// Note to Sir Rey Mark:
'   Hi sir!! HAHAHAHAHA Parang hindi na ata 'to BMI Calculator pero don't worry sir,
'   I added some comments and documentation to make it easier for you to understand and check our code.

'// 2024/10/20 revised 2024/11/22 GMGuillergan LLC.

'// This project is developed by Group #2 in collaboration with the GRASP Health Advocacy Program.
'// Major PT Collab of Science x MAPEH x TLE x [Computer]: Health Advocacy Informercial

'// Licensed to GMGuillergan LLC.
'// https://github.com/jeonnotcool/BMI_Calculator

'// Documentation of the functions of this file will be provided at https://docs.gmguiller+gan.com/bmime/onboarding

'// I would like to thank GitHub Copilot for helping me code this file.
'// Without you, it would take ages for me to code this. I love you, Copilot! <3

Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.Json
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports Sentry ' Import the Sentry SDK namespace

Public Class Onboarding




    Private Const SettingsFile As String = "settings.json"
    Private settings As Dictionary(Of String, String)
    Private languages As Dictionary(Of String, Dictionary(Of String, String))

    Private Const POUNDS_TO_KG As Double = 0.453592
    Private Const INCHES_TO_METERS As Double = 0.0254

    ' --- Form Events ---

    Private Sub Onboarding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load user settings and translations
        LoadUserSettings()
        LoadLanguagesFromJson("translations.json")
        LoadLocalizedStrings()
        SetLanguageRadioButton()

        ' Start on the welcome tab
        GoTab(welcome, welcome_letsgo)

        ' Check if onboarding is already complete
        If IsOnboardingComplete() Then
            Dim Decision As DialogResult = MessageBox.Show(GetTranslation("onboarding.interrupt_message"), "BMIMe", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Decision = DialogResult.No Then
                RemoveHandler Me.FormClosing, AddressOf Onboarding_FormClosing
                ' Clear all variables
                settings = New Dictionary(Of String, String)()
                languages = New Dictionary(Of String, Dictionary(Of String, String))()
                ResetOnboarding() ' Delete settings file and restart the 
            End If
        End If

        ' Initialize values from settings
        If GetKeyFromSettings("UserName") <> "User" Then
            txtName.Text = GetKeyFromSettings("UserName")
        Else
            txtName.Text = ""
        End If
        usernameTab_next.Enabled = txtName.Text.Length >= 2

        ' Check UnitSystem and set the appropriate checkbox
        If GetKeyFromSettings("UnitSystem") = "Metric" Then
            unitBox_metric.Checked = True
        Else
            unitBox_imperial.Checked = True
        End If

        ' Check gender and set the appropriate checkbox
        Dim gender = GetKeyFromSettings("Gender")
        If gender = "Male" Then
            genderbox_m.Checked = True
        ElseIf gender = "Female" Then
            genderbox_f.Checked = True
        ElseIf gender = "Other" Then
            genderbox_other.Checked = True
        End If

        ' Set the age, weight, and height
        Dim age = GetKeyFromSettings("Age")
        If Not CInt(age) = 0 Or String.IsNullOrEmpty(age) Then
            whuTab_agetxt.Text = age
        Else
            whuTab_agetxt.Text = ""
        End If

        Dim weight = GetKeyFromSettings("Weight")
        If Not CInt(weight) = 0 Or String.IsNullOrEmpty(weight) Then
            whuTab_wtxt.Text = weight
        Else
            whuTab_wtxt.Text = ""
        End If

        Dim height = GetKeyFromSettings("Height")
        If Not CInt(height) = 0 Or String.IsNullOrEmpty(height) Then
            whuTab_htxt.Text = height
        Else
            whuTab_htxt.Text = ""
        End If

        ' Round corners of controls
        RoundControls(Me)
    End Sub

    Private Sub Onboarding_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Reg As Integer = GetKeyonHKCU("SetupComplete")
        If Reg = 0 Then
            Dim result As DialogResult = MessageBox.Show(GetTranslation("onboarding.exit_message"), "BMIMe Onboarding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.Tab) Then ' Ctrl + Tab
            MainForm.Show()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.Shift Or Keys.R) Then ' Ctrl + Shift + R
            Dim prompt As DialogResult = MessageBox.Show("Are you sure you want to restart from the beginning?", "BMIMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If prompt = DialogResult.Yes Then ' Decision to restart the onboarding process
                RemoveHandler Me.FormClosing, AddressOf Onboarding_FormClosing
                ResetOnboarding() ' Delete settings file and restart the app
            End If
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' --- Welcome Tab ---

    Private Sub welcome_letsgo_Click(sender As Object, e As EventArgs) Handles welcome_letsgo.Click
        GoTab(usernameTab, usernameTab_next, usernameTab_back)
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

    ' --- Username Tab ---

    Private Sub usernameTab_next_Click(sender As Object, e As EventArgs) Handles usernameTab_next.Click
        GoTab(club, club_next, club_back)
        SaveSpecific("UserName", txtName.Text.ToString())
        supposed_name.Text = $"{LoadSettings("UserName")}!"
    End Sub

    Private Sub usernameTab_back_Click(sender As Object, e As EventArgs) Handles usernameTab_back.Click
        GoTab(welcome, welcome_letsgo)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        usernameTab_next.Enabled = txtName.Text.Length >= 2
    End Sub

    ' --- Club Tab ---

    Private Sub club_next_Click(sender As Object, e As EventArgs) Handles club_next.Click
        GoTab(legalTab, legal_next, legal_back)
        RoundControls(legalTab)
        System.Threading.Thread.Sleep(2000) ' Consider removing or reducing this delay
        legal_privacypolicy.Text = ObtainFromWeb("https://www.gmguillergan.com/bmipp.txt")
    End Sub

    Private Sub club_back_Click(sender As Object, e As EventArgs) Handles club_back.Click
        GoTab(usernameTab, usernameTab_next, usernameTab_back)
    End Sub

    ' --- Legal Tab ---

    Private Sub legal_back_Click(sender As Object, e As EventArgs) Handles legal_back.Click
        GoTab(club, club_next, club_back)
    End Sub

    Private Sub legal_next_Click(sender As Object, e As EventArgs) Handles legal_next.Click
        GoTab(whuTab, whuTab_next, whuTab_back)

        ' Set the age, weight, and height
        Dim age = GetKeyFromSettings("Age")
        If Not CInt(age) = 0 Or String.IsNullOrEmpty(age) Then
            whuTab_agetxt.Text = age
        Else
            whuTab_agetxt.Text = ""
        End If

        Dim weight = GetKeyFromSettings("Weight")
        If Not CInt(weight) = 0 Or String.IsNullOrEmpty(weight) Then
            whuTab_wtxt.Text = weight
        Else
            whuTab_wtxt.Text = ""
        End If

        Dim height = GetKeyFromSettings("Height")
        If Not CInt(height) = 0 Or String.IsNullOrEmpty(height) Then
            whuTab_htxt.Text = height
        Else
            whuTab_htxt.Text = ""
        End If

        ' Check UnitSystem and set the appropriate checkbox
        If GetKeyFromSettings("UnitSystem") = "Metric" Then
            unitBox_metric.Checked = True
        Else
            unitBox_imperial.Checked = True
        End If

        ' Check gender and set the appropriate checkbox
        Dim gender = GetKeyFromSettings("Gender")
        If gender = "Male" Then
            genderbox_m.Checked = True
        ElseIf gender = "Female" Then
            genderbox_f.Checked = True
        ElseIf gender = "Other" Then
            genderbox_other.Checked = True
        End If


    End Sub

    ' --- WHU Tab (it means WeightHeightUnit) ---

    Private Sub whuTab_next_Click(sender As Object, e As EventArgs) Handles whuTab_next.Click
        Dim isValid = ValidateWHU()

        If isValid = True Then
            GoTab(summaryTab)
            LoadSummaryTabTranslations()
        End If
    End Sub

    Private Sub whuTab_back_Click(sender As Object, e As EventArgs) Handles whuTab_back.Click
        GoTab(legalTab, legal_next, legal_back)
    End Sub

    Private Sub genderbox_m_CheckedChanged(sender As Object, e As EventArgs) Handles genderbox_m.CheckedChanged
        SaveSpecific("Gender", "Male")
    End Sub

    Private Sub genderbox_f_CheckedChanged(sender As Object, e As EventArgs) Handles genderbox_f.CheckedChanged
        SaveSpecific("Gender", "Female")
    End Sub

    Private Sub genderbox_other_CheckedChanged(sender As Object, e As EventArgs) Handles genderbox_other.CheckedChanged
        SaveSpecific("Gender", "Other")
    End Sub

    Private Sub unitBox_metric_CheckedChanged(sender As Object, e As EventArgs) Handles unitBox_metric.CheckedChanged
        If unitBox_metric.Checked Then
            SaveSpecific("UnitSystem", "Metric")
            whuTab_hlbl.Text = GetTranslation("onboarding.whuTab_hlbl_m")
            whuTab_wlbl.Text = GetTranslation("onboarding.whuTab_wlbl_kg")
            ConvertUnits(convertToMetric:=True)
        End If

    End Sub

    Private Sub unitBox_imperial_CheckedChanged(sender As Object, e As EventArgs) Handles unitBox_imperial.CheckedChanged
        If unitBox_imperial.Checked Then
            SaveSpecific("UnitSystem", "Imperial")
            whuTab_hlbl.Text = GetTranslation("onboarding.whuTab_hlbl_in")
            whuTab_wlbl.Text = GetTranslation("onboarding.whuTab_wlbl_lbs")
            ConvertUnits(convertToMetric:=False)
        End If
    End Sub

    ' --- Summary Tab ---
    Private Sub LoadSummaryTabTranslations()
        summaryPanel_lang.Text = $"{GetTranslation("onboarding.summaryPanel_lang")}: {GetKeyFromSettings("Language")}"
        summaryPanel_name.Text = $"{GetTranslation("onboarding.summaryPanel_name")}: {GetKeyFromSettings("UserName")}"
        summaryPanel_privacy.Text = $"{GetTranslation("onboarding.summaryPanel_privacy")}"
        summaryPanel_unit.Text = $"{GetTranslation("onboarding.summaryPanel_unit")}: {GetKeyFromSettings("UnitSystem")}"
        summaryPanel_weight.Text = $"{GetTranslation("onboarding.summaryPanel_weight")}: {GetKeyFromSettings("Weight")}"
        summaryPanel_height.Text = $"{GetTranslation("onboarding.summaryPanel_height")}: {GetKeyFromSettings("Height")}"
        summaryPanel_age.Text = $"{GetTranslation("onboarding.summaryPanel_age")}: {GetKeyFromSettings("Age")}"
    End Sub

    Private Sub summaryTab_back_Click(sender As Object, e As EventArgs) Handles summaryTab_back.Click
        GoTab(whuTab, whuTab_next, whuTab_back)
    End Sub
    Private Sub summaryTab_next_Click(sender As Object, e As EventArgs) Handles summaryTab_next.Click
        GoTab(last, last_launchBMIMe)
        SetKeyonHKCU("SetupComplete", 1) ' This marks the registry key as 1, indicating that the setup is complete.
    End Sub

    ' --- Last Tab ---

    Private Sub last_launchBMIMe_Click(sender As Object, e As EventArgs) Handles last_launchBMIMe.Click
        MainForm.Show()
        MainForm.BringToFront()
        Me.Hide()
    End Sub


    ' --- Helper Methods ---
    ' Comments:

    ' The helper methods are there in order to break down the code into smaller, and more manageable parts.
    ' This makes the code easier to read and understand.

    Private Sub GoTab(tab As TabPage, Optional button As Button = Nothing, Optional cancel As Button = Nothing)
        For Each t As TabPage In OnboardFrame.TabPages
            t.Enabled = (t Is tab)
        Next
        OnboardFrame.SelectedTab = tab
        If button IsNot Nothing Then
            Me.AcceptButton = button
        End If
        If cancel IsNot Nothing Then
            Me.CancelButton = cancel
        End If
    End Sub

    Private Sub Round(control As Control)
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddLine(radius, 0, control.Width - radius, 0)
        path.AddArc(New Rectangle(control.Width - radius, 0, radius, radius), -90, 90)
        path.AddLine(control.Width, radius, control.Width, control.Height - radius)
        path.AddArc(New Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90)
        path.AddLine(control.Width - radius, control.Height, radius, control.Height)
        path.AddArc(New Rectangle(0, control.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        control.Region = New Region(path)
    End Sub

    Private Sub RoundControls(parent As Control)
        For Each control As Control In parent.Controls
            If TypeOf control Is Panel OrElse TypeOf control Is TextBox OrElse TypeOf control Is RichTextBox OrElse TypeOf control Is PictureBox Then
                Round(control)
            End If
            If control.HasChildren Then
                RoundControls(control)
            End If
        Next
    End Sub

    Private Function ObtainFromWeb(link As String) As String
        Try
            Using client As New Net.Http.HttpClient()
                Return client.GetStringAsync(link).Result
            End Using
        Catch ex As Exception
            MessageBox.Show("Error obtaining data from web: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Function ValidateWHU() As Boolean
        ' Validate if all fields are entered
        If String.IsNullOrEmpty(whuTab_agetxt.Text) OrElse String.IsNullOrEmpty(whuTab_wtxt.Text) OrElse String.IsNullOrEmpty(whuTab_htxt.Text) Then
            MessageBox.Show("Please fill in all fields before proceeding.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate if the checkboxes are checked
        If Not (unitBox_metric.Checked OrElse unitBox_imperial.Checked) Then
            MessageBox.Show("Please select a unit system.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not (genderbox_m.Checked OrElse genderbox_f.Checked OrElse genderbox_other.Checked) Then
            MessageBox.Show("Please select a gender.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate if the height and weight are numeric
        If Not IsNumeric(whuTab_wtxt.Text) OrElse Not IsNumeric(whuTab_htxt.Text) Then
            MessageBox.Show("Please enter valid numeric values for height and weight.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function



    ' --- Registry Methods ---
    ' Comments:

    ' BMIMe uses registry keys on the computer for validating settings and storing user data.

    ' The application only accesses the registry keys under the HKCU (HKEY_CURRENT_USER) and HKLM (HKEY_LOCAL_MACHINE) hives.

    ' The code strictly accesses the registry keys under the Software\GMGuillergan\BMIMe path.

    ' The application does not access other registry keys for safety.

    ' i love playing with registry keys:) - gab

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

    ' --- Admin Rights Methods ---
    ' Comments:

    ' There are cases where the application needs to run with administrator rights to access certain resources.
    ' The AskForAdminRights method will ask for admin rights and restart the application with admin rights if necessary.
    ' The IsUserAdmin method checks if the application is running with admin rights.

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

    ' --- Settings Methods ---
    ' Comments:
    ' These methods are used in connection with the settings.json.
    ' This sections has sooooo many methods, hence the documentation will be provided at https://docs.gmguillergan.com/bmime/onboarding

    Public Class UserSettings
        Public Property UnitSystem As String
        Public Property Language As String
        Public Property UserName As String
        Public Property Gender As String
        Public Property WeightString As String
            Get
                Return Weight.ToString()
            End Get
            Set(value As String)
                Weight = Convert.ToDouble(value)
            End Set
        End Property
        Public Property HeightString As String
            Get
                Return Height.ToString()
            End Get
            Set(value As String)
                Height = Convert.ToDouble(value)
            End Set
        End Property
        Public Property Weight As Double
        Public Property Height As Double
        Public Property Age As Integer
    End Class


    Private Sub LoadUserSettings()
        Try
            If Not File.Exists(SettingsFile) Then
                Dim defaultSettings As New UserSettings With { ' This is the default settings.
                .UnitSystem = "Metric",
                .Language = "en-US",
                .UserName = "User",
                .Gender = "",
                .Weight = 0.0,
                .Height = 0.0,
                .Age = 0
            }
                SaveUserSettings(defaultSettings)
            End If

            Dim jsonString = File.ReadAllText(SettingsFile)
            Dim userSettings = JsonSerializer.Deserialize(Of UserSettings)(jsonString)
            settings = New Dictionary(Of String, String) From {
            {"UnitSystem", userSettings.UnitSystem},
            {"Language", userSettings.Language},
            {"UserName", userSettings.UserName},
            {"Gender", userSettings.Gender},
            {"Weight", userSettings.WeightString},
            {"Height", userSettings.HeightString},
            {"Age", userSettings.Age.ToString()}
        }
        Catch ex As Exception
            MessageBox.Show("Error reading user settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Function LoadSettings(keyToCheck As String) As String
        Try
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
            settings(key) = value
            Dim userSettings As New UserSettings With {
            .UnitSystem = settings("UnitSystem"),
            .Language = settings("Language"),
            .UserName = settings("UserName"),
            .Gender = settings("Gender"),
            .WeightString = settings("Weight"),
            .HeightString = settings("Height"),
            .Age = Convert.ToInt32(settings("Age"))
        }
            SaveUserSettings(userSettings)
        Catch ex As FormatException
        Catch ex As Exception
            MessageBox.Show("Error saving settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetKeyFromSettings(key As String) As String
        Try
            If settings.ContainsKey(key) Then
                Return settings(key)
            Else
                MessageBox.Show($"Key '{key}' not found in settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading key from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Private Function IsOnboardingComplete() As Boolean
        Return Not String.IsNullOrEmpty(GetKeyFromSettings("UnitSystem")) AndAlso
               Not String.IsNullOrEmpty(GetKeyFromSettings("Language")) AndAlso
               Not GetKeyFromSettings("UserName") = "User"
    End Function

    Private Sub ResetOnboarding()
        File.Delete(SettingsFile)
        SetKeyonHKCU("SetupComplete", 0)
        MessageBox.Show("BMIMe has been initialized. Restarting the app...", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Restart()
    End Sub

    ' --- Language Methods ---
    ' Comments:

    ' BMIMe supports multi-language translations, specifically English and Filipino. (of course, this app is developed in the Philippines)
    ' These methods are used in connection with the translations.json file.

    ' Ang dami ng comments dito sa code na 'to no?
    ' json makes my life easier!!! pero kailangan ko pang i-manual HSHSHSHS

    ' kaya pa bang basahin? HAHAHAHAHAHAHA syempre kaya pa yan! kinaya ko ngang i-program yan nang magisa HAHAHAH

    Private Sub LoadLanguagesFromJson(filename As String)
        Try
            Dim jsonString = File.ReadAllText(filename)
            languages = JsonSerializer.Deserialize(Of Dictionary(Of String, Dictionary(Of String, String)))(jsonString)
        Catch ex As Exception
            MessageBox.Show("Error loading translations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
            If translations.ContainsKey($"onboarding.{control.Name}") Then
                control.Text = translations($"onboarding.{control.Name}")
            End If
            If control.HasChildren Then
                UpdateControlText(control, translations)
            End If
        Next
    End Sub

    Private Function GetLanguageFromSettings() As String
        Dim language As String = "en-US" ' Default language

        Try
            If settings.ContainsKey("Language") Then
                language = settings("Language")
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading language from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return language
    End Function

    Private Function GetTranslation(key As String) As String
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) AndAlso languages(currentLanguage).ContainsKey(key) Then
            Return languages(currentLanguage)(key)
        Else
            Return $"Missing translation: {key}"
        End If
    End Function

    Private Sub whuTab_agetxt_TextChanged(sender As Object, e As EventArgs) Handles whuTab_agetxt.TextChanged
        Dim ageText As String = whuTab_agetxt.Text

        ' Check if the input contains non-numeric characters and is not empty
        If Not String.IsNullOrEmpty(ageText) AndAlso Not IsNumeric(ageText) Then
            MessageBox.Show("Please enter a valid age.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            whuTab_agetxt.Text = ""
            Return
        End If

        ' Check if the input length is greater than 3
        If ageText.Length >= 3 Then
            Dim result As DialogResult = MessageBox.Show($"Are you really {ageText}?", "BMIMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                MessageBox.Show("I'm actually surprised that you can do that.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Try
            SaveSpecific("Age", ageText)
        Catch ex As FormatException
        End Try
    End Sub

    Private Sub whuTab_wtxt_TextChanged(sender As Object, e As EventArgs) Handles whuTab_wtxt.TextChanged
        Dim weightText As String = whuTab_wtxt.Text

        ' Check if the input contains non-numeric characters and is not empty
        If Not String.IsNullOrEmpty(weightText) AndAlso Not IsNumeric(weightText) Then
            MessageBox.Show("Please enter a valid weight.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            whuTab_wtxt.Text = ""
            Return
        End If

        Try
            SaveSpecific("Weight", weightText)
        Catch ex As FormatException
        End Try
    End Sub

    Private Sub whuTab_htxt_TextChanged(sender As Object, e As EventArgs) Handles whuTab_htxt.TextChanged
        Dim heightText As String = whuTab_htxt.Text

        ' Check if the input contains non-numeric characters and is not empty
        If Not String.IsNullOrEmpty(heightText) AndAlso Not IsNumeric(heightText) Then
            MessageBox.Show("Please enter a valid height.", "BMIMe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            whuTab_htxt.Text = ""
            Return
        End If
        Try
            SaveSpecific("Height", heightText)
        Catch ex As FormatException
        End Try
    End Sub

    ' Convert units in the text boxes
    Private Sub ConvertUnits(convertToMetric As Boolean)
        Try
            If whuTab_wtxt.Text <> "" And whuTab_htxt.Text <> "" Then
                Dim weight As Double = Double.Parse(whuTab_wtxt.Text)
                Dim height As Double = Double.Parse(whuTab_htxt.Text)

                If convertToMetric Then
                    weight = weight / 2.205  ' Pounds to kg 
                    height = height / 39.37  ' Inches to meters 
                Else
                    weight = weight * 2.205  ' Kg to pounds 
                    height = height * 39.37  ' Meters to inches 
                End If

                whuTab_wtxt.Text = String.Format("{0:f}", weight)
                whuTab_htxt.Text = String.Format("{0:f}", height)

                Console.WriteLine("Converted weight: " & weight) ' Debugging output
                Console.WriteLine("Converted height: " & height) ' Debugging output
            End If
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numbers for weight and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class