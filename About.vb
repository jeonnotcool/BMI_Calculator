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
Imports Microsoft.Win32

Public Class About

    ' Do not edit. Other components will not work.
    Private ReadOnly Property CurrentVersion As String
        Get
            Return My.Settings.VersionNumber
        End Get
    End Property
    Private languages As Dictionary(Of String, Dictionary(Of String, String))

    Private Const SettingsFile As String = "settings.json"

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = $"Version {CurrentVersion} (Alpha)" ' used this instead because concatenation is complicated
        LoadLanguagesFromJson("translations.json")
        LoadLocalizedStrings()
        NameUser.Text = GetNameFromSettings()
    End Sub

    ' Load localized strings
    Private Sub LoadLocalizedStrings()
        Dim currentLanguage = GetLanguageFromSettings()
        If languages.ContainsKey(currentLanguage) Then
            Dim translations = languages(currentLanguage)

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
                Dim jsonString = File.ReadAllText(SettingsFile)
                Dim settings = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)
                If settings.ContainsKey("Language") Then
                    language = settings("Language")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading language from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return language
    End Function

    ' Get name from settings file
    Private Function GetNameFromSettings() As String
        Dim UName As String = "User" ' Default

        Try
            If File.Exists(SettingsFile) Then
                Dim jsonString = File.ReadAllText(SettingsFile)
                Dim settings = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)
                If settings.ContainsKey("UserName") Then
                    If String.IsNullOrEmpty(settings("UserName")) Then
                        settings("UserName") = UName
                    End If
                    UName = settings("UserName")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading name from settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return UName
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Updater.ShowDialog()
        Me.Close()
    End Sub
End Class
