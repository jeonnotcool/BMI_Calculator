'// BMIMe \ MainForm.vb

'// 2024/08/20 revised 2024/11/22 GMGuillergan LLC.

'// This project is developed by Group #2 in collaboration with the GRASP Health Advocacy Program.
'// Major PT Collab of Science x MAPEH x TLE x [Computer]: Health Advocacy Informercial

'// Licensed to GMGuillergan LLC.
'// https://github.com/jeonnotcool/BMI_Calculator

Imports System.Globalization
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.Json
Imports System.Threading

Public Class MainForm
    ' Version -- Change the version in My Project -> Settings -> VersionNumber
    Private ReadOnly Property CurrentVersion As String
        Get
            Return My.Settings.VersionNumber
        End Get
    End Property

    ' Constants
    Private Const SettingsFile As String = "settings.json"
    Private Const POUNDS_TO_KG As Double = 0.453592
    Private Const INCHES_TO_METERS As Double = 0.0254

    ' Variables
    Private languages As Dictionary(Of String, Dictionary(Of String, String))
    Private UName As String

    ' Load event
    Private Sub BMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load translations 
        LoadLanguagesFromJson("translations.json")
        ' Load user settings
        LoadSettings()
        ' Update UI with localized strings
        LoadLocalizedStrings()
    End Sub

    ' Calculate BMI
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Try
            Dim weight As Double
            Dim height As Double

            ' Get weight and height based on unit system
            If rbMetric.Checked Then
                weight = Double.Parse(txtWeight.Text)
                height = Double.Parse(txtHeight.Text)
            Else
                weight = Double.Parse(txtWeight.Text) * POUNDS_TO_KG ' Pounds to kg
                height = Double.Parse(txtHeight.Text) * INCHES_TO_METERS ' Inches to meters
            End If

            ' Calculate BMI
            Dim bmi As Double = weight / (height * height)
            calculated.Text = String.Format("{0:f}", bmi)

            ' Update status label and color
            UpdateStatus(bmi)

        Catch ex As FormatException
            MessageBox.Show("Please enter valid numbers for weight and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LoadLocalizedStrings() ' Refresh UI
    End Sub

    ' Reset text boxes and status label
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        calculated.Text = "Enter value"

        txtHeight.Clear()

        txtWeight.Clear()

        Status.Text = ""

        Status.BackColor = Color.White
    End Sub

    ' Exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' About dialog (implementation not provided)
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Updater.ShowDialog()
    End Sub


    ' Set language to English
    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        SetLanguage("en-US")
    End Sub

    ' Set language to Tagalog
    Private Sub TagalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagalogToolStripMenuItem.Click
        SetLanguage("fil-PH")
    End Sub

    ' Update UI and save settings when unit system changes
    Private Sub rbMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rbMetric.CheckedChanged
        If rbMetric.Checked Then ' Only convert if the radio button is checked
            ConvertUnits(convertToMetric:=True)
        End If
        UpdateUIAndSaveSettings()
    End Sub

    Private Sub rbImperial_CheckedChanged(sender As Object, e As EventArgs) Handles rbImperial.CheckedChanged
        If rbImperial.Checked Then ' Only convert if the radio button is checked
            ConvertUnits(convertToMetric:=False)
        End If
        UpdateUIAndSaveSettings()
    End Sub

    ' Convert units in the text boxes
    Private Sub ConvertUnits(convertToMetric As Boolean)
        Try
            If txtWeight.Text <> "" And txtHeight.Text <> "" Then
                Dim weight As Double = Double.Parse(txtWeight.Text)
                Dim height As Double = Double.Parse(txtHeight.Text)

                If convertToMetric Then
                    weight = weight / 2.205  ' Pounds to kg 
                    height = height / 39.37  ' Inches to meters 
                Else
                    weight = weight * 2.205  ' Kg to pounds 
                    height = height * 39.37  ' Meters to inches 
                End If

                txtWeight.Text = String.Format("{0:f}", weight)
                txtHeight.Text = String.Format("{0:f}", height)

                Console.WriteLine("Converted weight: " & weight) ' Debugging output
                Console.WriteLine("Converted height: " & height) ' Debugging output
            End If
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numbers for weight and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Helper Methods ---

    ' Load localized strings
    Private Sub LoadLocalizedStrings()
        Dim currentLanguage = GetLanguageFromSettings()
        If currentLanguage Is Nothing Then
            MessageBox.Show("Error: Language setting is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If languages Is Nothing OrElse Not languages.ContainsKey(currentLanguage) Then
            MessageBox.Show($"Language '{currentLanguage}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim translations = languages(currentLanguage)

        main_title.Text = translations("main.title")
        calculate.Text = translations("main.calculate")
        reset.Text = translations("main.reset")
        weighLabel.Text = translations("main.weighLabel")
        heightLabel.Text = translations("main.heightLabel")
        ageLabel.Text = translations("main.ageLabel")
        aShort.Text = translations("main.aShort")

        If currentLanguage = "en-US" Then
            EnglishToolStripMenuItem.Checked = True
            TagalogToolStripMenuItem.Checked = False
        ElseIf currentLanguage = "fil-PH" Then
            EnglishToolStripMenuItem.Checked = False
            TagalogToolStripMenuItem.Checked = True
        End If

        ' Update labels based on unit system
        If rbMetric.Checked Then
            wShort.Text = translations("main.weighLabel_kg")
            hShort.Text = translations("main.heightLabel_m")
        Else
            wShort.Text = translations("main.weighLabel_lbs")
            hShort.Text = translations("main.heightLabel_in")
        End If
    End Sub

    ' Get language from settings file
    Private Function GetLanguageFromSettings() As String
        Dim language As String = "en-US" ' Default

        Try
            If File.Exists(SettingsFile) Then
                Dim jsonString = File.ReadAllText(SettingsFile)
                Dim settings = JsonSerializer.Deserialize(Of UserSettings)(jsonString)
                language = settings.Language
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading language from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return language
    End Function

    ' Update status label and color
    Private Sub UpdateStatus(bmi As Double)
        Dim currentLanguage = GetLanguageFromSettings()
        Dim translations = languages(currentLanguage)

        If bmi < 18.5 Then
            Status.BackColor = Color.SkyBlue
            Status.Text = translations("underweight")
        ElseIf bmi <= 24.9 Then
            Status.BackColor = Color.LightGreen
            Status.Text = translations("normal_range")
        ElseIf bmi <= 29.9 Then
            Status.BackColor = Color.LightYellow
            Status.Text = translations("overweight")
        ElseIf bmi >= 30 Then
            Status.BackColor = Color.Red
            Status.Text = translations("obese")
        End If
    End Sub

    Private Function AssessHealthRisks(bmi As Double, gender As String, age As Integer) As String
        Dim riskAssessment As String = ""

        If bmi < 18.5 Then
            riskAssessment = "You might be at risk of malnutrition, weakened immune system, and other health issues."
        ElseIf bmi >= 18.5 And bmi <= 24.9 Then
            riskAssessment = "You're generally healthy. Keep it up!"
        ElseIf bmi >= 25 And bmi <= 29.9 Then
            riskAssessment = "You might be at increased risk of heart disease, stroke, and type 2 diabetes."
        ElseIf bmi >= 30 Then
            riskAssessment = "You might be at significantly increased risk of serious health conditions."
        End If

        ' Add gender-specific considerations
        If gender = "female" Then
            If bmi < 18.5 Then
                riskAssessment &= " Especially at risk for irregular periods and osteoporosis."
            ElseIf bmi >= 25 Then
                riskAssessment &= " Increased risk of polycystic ovary syndrome (PCOS) and pregnancy complications."
            End If
        End If

        ' Add age-specific considerations
        If age < 18 Then
            riskAssessment &= " Pay attention to growth and development. Consult a pediatrician for advice."
        ElseIf age >= 65 Then
            riskAssessment &= " Consider age-related health issues like sarcopenia and osteoporosis. Consult a healthcare provider."
        End If

        Return riskAssessment
    End Function

    Private Function GenerateRecommendations(healthRisks As String, gender As String, age As Integer) As String
        Dim recommendations As String = ""

        If healthRisks.Contains("Underweight") Then
            recommendations = "Consult a healthcare provider. Increase calorie intake, focus on nutrient-dense foods, and engage in gentle exercise."
        ElseIf healthRisks.Contains("Normal Weight") Then
            recommendations = "Maintain a healthy lifestyle, prioritize nutrient-rich foods, and engage in moderate physical activity."
        ElseIf healthRisks.Contains("Overweight") OrElse healthRisks.Contains("Obese") Then
            recommendations = "Consult a healthcare provider. Reduce calorie intake, increase physical activity, and adopt a balanced diet. Consider seeking support from a registered dietitian."
        End If

        ' Add gender-specific recommendations
        If gender = "female" And healthRisks.Contains("Underweight") Then
            recommendations &= " Pay attention to menstrual health and bone health."
        ElseIf gender = "female" And healthRisks.Contains("Overweight") OrElse healthRisks.Contains("Obese") Then
            recommendations &= " Consider the impact on fertility and pregnancy."
        End If

        ' Add age-specific recommendations
        If age < 18 Then
            recommendations &= " Prioritize healthy growth and development. Avoid unhealthy weight gain or loss."
        ElseIf age >= 65 Then
            recommendations &= " Consider age-related factors like metabolism and muscle mass. Consult a healthcare provider for personalized advice."
        End If

        Return recommendations
    End Function


    ' Update UI and save settings
    Private Sub UpdateUIAndSaveSettings()
        LoadLocalizedStrings()
        SaveSettings()
    End Sub

    ' Set language and update UI
    Private Sub SetLanguage(languageCode As String)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(languageCode)
        SaveSettings()
        LoadLocalizedStrings()
    End Sub

    ' Load user settings
    Private Sub LoadSettings()
        Try
            If File.Exists(SettingsFile) Then
                Dim jsonString = File.ReadAllText(SettingsFile)
                Dim settings = JsonSerializer.Deserialize(Of UserSettings)(jsonString)

                ' Set unit system and language WITHOUT triggering events
                SetUnitSystemAndLanguage(settings.UnitSystem, settings.Language)
            Else
                ' Use default settings
                MessageBox.Show("Settings file not found. Using default settings.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Set defaults WITHOUT triggering events
                SetUnitSystemAndLanguage("Metric", "en-US")
                UpdateUIAndSaveSettings()
            End If
        Catch ex As FileNotFoundException
            MessageBox.Show("Settings file not found. Using default settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Set defaults WITHOUT triggering events
            SetUnitSystemAndLanguage("Metric", "en-US")
            UpdateUIAndSaveSettings()
        Catch ex As JsonException
            MessageBox.Show("Error parsing settings file. Using default settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Set defaults WITHOUT triggering events
            SetUnitSystemAndLanguage("Metric", "en-US")
            UpdateUIAndSaveSettings()
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred while loading settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Set defaults WITHOUT triggering events
            SetUnitSystemAndLanguage("Metric", "en-US")
            UpdateUIAndSaveSettings()
        End Try
    End Sub

    ' Save user settings
    Private Sub SaveSettings()
        Try
            Dim settings As New UserSettings With {
                .UnitSystem = If(rbMetric.Checked, "Metric", "Imperial"),
                .Language = Thread.CurrentThread.CurrentUICulture.Name,
                .UserName = UName
            }
            Dim jsonString = JsonSerializer.Serialize(settings)
            File.WriteAllText(SettingsFile, jsonString)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Error saving settings: Access to the path is denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As IOException
            MessageBox.Show("Error saving settings: An I/O error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred while saving settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load translations from JSON
    Private Sub LoadLanguagesFromJson(filename As String)
        Try
            Dim jsonString = File.ReadAllText(filename)
            languages = JsonSerializer.Deserialize(Of Dictionary(Of String, Dictionary(Of String, String)))(jsonString)
        Catch ex As FileNotFoundException
            Throw New Exception("Error loading translations: ERR_MISS_TRANSFILE - " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error loading translations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to set unit system and language without triggering events
    Private Sub SetUnitSystemAndLanguage(unitSystem As String, languageCode As String)
        RemoveHandler rbMetric.CheckedChanged, AddressOf rbMetric_CheckedChanged
        RemoveHandler rbImperial.CheckedChanged, AddressOf rbImperial_CheckedChanged

        rbMetric.Checked = (unitSystem = "Metric")
        rbImperial.Checked = (unitSystem = "Imperial")

        AddHandler rbMetric.CheckedChanged, AddressOf rbMetric_CheckedChanged
        AddHandler rbImperial.CheckedChanged, AddressOf rbImperial_CheckedChanged

        Thread.CurrentThread.CurrentUICulture = New CultureInfo(languageCode)
    End Sub

    ' Test Values
    Private Sub MetricToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetricToolStripMenuItem.Click
        txtWeight.Text = "68"
        txtHeight.Text = "1.7"
    End Sub

    Private Sub ImperialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImperialToolStripMenuItem.Click
        txtWeight.Text = "149.94"
        txtHeight.Text = "66.93"
    End Sub

    Private Sub LaunchBMIResultTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchBMIResultTestToolStripMenuItem.Click
        BMI_Result.ShowDialog()
    End Sub
End Class

' UserSettings class to represent settings
Public Class UserSettings
    Public Property UnitSystem As String
    Public Property Language As String

    Public Property UserName As String
End Class
