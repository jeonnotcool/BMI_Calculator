Imports System.Globalization
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.Json
Imports System.Threading
Imports Microsoft.AppCenter
Imports Microsoft.AppCenter.Analytics
Imports Microsoft.AppCenter.Crashes
Imports Microsoft.AppCenter.Push

Public Class Form1

    ' Constants
    Private Const SettingsFile As String = "settings.txt"

    ' Variables
    Private languages As Dictionary(Of String, Dictionary(Of String, String))

    ' Load event
    Private Sub BMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AppCenter.Start("d31b68c5-b183-4505-b6e5-9F44395F8a41",
                GetType(Analytics), GetType(Crashes), GetType(Push))

        ' Load translations 
        LoadLanguagesFromJson("translations.json")
        ' Load user settings
        LoadSettings()
        ' Update UI with localized strings
        LoadLocalizedStrings()
    End Sub

    ' Calculate BMI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Try
            Dim weight As Double
            Dim height As Double

            ' Get weight and height based on unit system
            If rbMetric.Checked Then
                weight = Double.Parse(txtWeight.Text)
                height = Double.Parse(txtHeight.Text)
            Else
                weight = Double.Parse(txtWeight.Text) * 0.453592 ' Pounds to kg
                height = Double.Parse(txtHeight.Text) * 0.0254 ' Inches to meters
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

    ' Reset input fields and status
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles reset.Click
        calculated.Text = ""
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
        'AboutApp.Show()
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
        UpdateUIAndSaveSettings()
    End Sub

    Private Sub rbImperial_CheckedChanged(sender As Object, e As EventArgs) Handles rbImperial.CheckedChanged
        UpdateUIAndSaveSettings()
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

            If currentLanguage = "en-US" Then
                EnglishToolStripMenuItem.Checked = True
                TagalogToolStripMenuItem.Checked = False
            ElseIf currentLanguage = "fil-PH" Then
                EnglishToolStripMenuItem.Checked = False
                TagalogToolStripMenuItem.Checked = True
            End If

            ' Update labels based on unit system
            If rbMetric.Checked Then
                weighLabel.Text = translations("main.weighLabel_kg")
                heightLabel.Text = translations("main.heightLabel_m")
            Else
                weighLabel.Text = translations("main.weighLabel_lbs")
                heightLabel.Text = translations("main.heightLabel_in")
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
        UpdateUIAndSaveSettings()
        LoadLocalizedStrings()

    End Sub



    ' Load user settings
    Private Sub LoadSettings()
        Try
            If File.Exists(SettingsFile) Then
                Using reader As New StreamReader(SettingsFile)
                    Dim unitSystem As String = reader.ReadLine()
                    Dim language As String = reader.ReadLine()

                    ' Set unit system WITHOUT triggering the CheckedChanged event
                    RemoveHandler rbMetric.CheckedChanged, AddressOf rbMetric_CheckedChanged
                    RemoveHandler rbImperial.CheckedChanged, AddressOf rbImperial_CheckedChanged

                    rbMetric.Checked = (unitSystem = "Metric")

                    AddHandler rbMetric.CheckedChanged, AddressOf rbMetric_CheckedChanged
                    AddHandler rbImperial.CheckedChanged, AddressOf rbImperial_CheckedChanged

                    ' Set language
                    Thread.CurrentThread.CurrentUICulture = New CultureInfo(language)
                End Using
            Else
                ' Use default settings
                MessageBox.Show("Settings file not found. Using default settings.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Set defaults WITHOUT triggering the CheckedChanged event
                RemoveHandler rbMetric.CheckedChanged, AddressOf rbMetric_CheckedChanged
                RemoveHandler rbImperial.CheckedChanged, AddressOf rbImperial_CheckedChanged

                rbMetric.Checked = True

                AddHandler rbMetric.CheckedChanged, AddressOf rbMetric_CheckedChanged
                AddHandler rbImperial.CheckedChanged, AddressOf rbImperial_CheckedChanged

                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
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

End Class