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
    Private Const SettingsFile As String = "settings.txt"
    Private Const POUNDS_TO_KG As Double = 0.453592
    Private Const INCHES_TO_METERS As Double = 0.0254

    ' Variables
    Private languages As Dictionary(Of String, Dictionary(Of String, String))

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
        If languages.ContainsKey(currentLanguage) Then
            Dim translations = languages(currentLanguage)

            main_title.Text = translations("main.title")
            calculate.Text = translations("main.calculate")
            reset.Text = translations("main.reset")
            weighLabel.Text = translations("main.weighLabel")
            heightLabel.Text = translations("main.heightLabel")

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
                Using reader As New StreamReader(SettingsFile)
                    Dim unitSystem As String = reader.ReadLine()
                    Dim language As String = reader.ReadLine()

                    ' Set unit system and language WITHOUT triggering events
                    SetUnitSystemAndLanguage(unitSystem, language)

                End Using
            Else
                ' Use default settings
                MessageBox.Show("Settings file not found. Using default settings.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Set defaults WITHOUT triggering events
                SetUnitSystemAndLanguage("Metric", "en-US")
                UpdateUIAndSaveSettings()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Save user settings
    Private Sub SaveSettings()
        Try
            Using writer As New StreamWriter(SettingsFile)
                writer.WriteLine(If(rbMetric.Checked, "Metric", "Imperial"))
                writer.WriteLine(Thread.CurrentThread.CurrentUICulture.Name)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


End Class