Imports System.Windows.Forms
Imports Sentry
Imports System.IO
Imports System.Text.Json
Imports System.Runtime.InteropServices
Imports Microsoft.Win32


Module Program

    Private DebugMode As Boolean = True

    Private Const SettingsFile As String = "settings.json"
    Private settings As Dictionary(Of String, String)
    Sub Main()


        ' Initialize the Sentry SDK
        SentrySdk.Init(Sub(o)
                           o.Dsn = "https://db3a0d97f01fd1e4ef98498e5c81ab8b@o4508515906093056.ingest.us.sentry.io/4508516268638208"
                           o.Debug = True
                           o.TracesSampleRate = 1.0
                       End Sub)

        ' Configure WinForms to throw exceptions so Sentry can capture them.
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

        ' Handle UI thread exceptions
        AddHandler Application.ThreadException, AddressOf Application_ThreadException

        ' Handle non-UI thread exceptions
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim Reg As Integer = GetKeyonHKCU("SetupComplete")

        If DebugMode = False Then

            If Reg = 1 Then
                Application.Run(New MainForm())
            Else
                Application.Run(New Onboarding())
            End If

        Else
            ' WRITE YOUR CODE WHEN DEBUGGING!
            Application.Run(New MainForm())
        End If

    End Sub

    Private Sub Application_ThreadException(sender As Object, e As Threading.ThreadExceptionEventArgs)
        LoadUserSettings()

        ' Capture the exception in Sentry
        Dim eventId = SentrySdk.CaptureException(e.Exception)

        ' Show a message box to the user
        Dim Message As DialogResult = MessageBox.Show($"An unexpected error occurred.{vbCrLf & vbCrLf} {e.Exception} {vbCrLf & vbCrLf} Event ID: {eventId} {vbCrLf & vbCrLf} The error has been sent to our developer. {vbCrLf & vbCrLf} Do you want to tell us more about the error to the developer? This will help us improve our application.", "BMIMe encountered an error.", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If Message = DialogResult.Yes Then
            ' Collect user feedback
            Dim userName As String = LoadSettings("UserName")
            Dim userEmail As String = InputBox("Please enter your email:", "BMIMe Error Handling System")
            Dim userComments As String = InputBox("Please provide related comments regarding to the error (e.g. what we're you doing before the error occured?):", "BMIMe Error Handling System")
            Dim userFeedback = New UserFeedback(eventId, userName, userEmail, userComments)
            ' Send user feedback to dashboard
            Try
                SentrySdk.CaptureUserFeedback(userFeedback)
                ShowWindowsNotification("Report sent successfully", "Thank you for helping BMIMe improve <3")
            Catch ex As Exception
                MessageBox.Show("Error sending user feedback: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        ' Capture the exception in Sentry
        Dim exception = CType(e.ExceptionObject, Exception)
        Dim eventId = SentrySdk.CaptureException(exception)

        ' Show a message box to the user
        MessageBox.Show($"A critical error has occurred!{vbCrLf & vbCrLf} {exception} {vbCrLf & vbCrLf} Event ID: {eventId} {vbCrLf & vbCrLf} The error has been sent to our developer. {vbCrLf & vbCrLf} The application will close.", "BMIMe encountered a critical error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ' Exit the application
        Application.Exit()
    End Sub

    Private Sub LoadUserSettings()
        Try
            Dim jsonString = File.ReadAllText(SettingsFile)
            Dim userSettings = JsonSerializer.Deserialize(Of UserSettings)(jsonString)
            settings = New Dictionary(Of String, String) From {
        {"UnitSystem", userSettings.UnitSystem},
        {"Language", userSettings.Language},
        {"UserName", userSettings.UserName}
    }
        Catch ex As Exception
            MessageBox.Show("Error reading user settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function LoadSettings(keyToCheck As String) As String
        Try
            If settings.ContainsKey(keyToCheck) Then
                Return settings(keyToCheck)
            Else
                MessageBox.Show($"Key '{keyToCheck}' doesn't exist", "Key Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As FileNotFoundException
        Catch ex As Exception
            MessageBox.Show("Error reading settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Private Sub ShowWindowsNotification(title As String, message As String)
        Dim notification As New NotifyIcon()
        notification.Visible = True
        notification.Icon = SystemIcons.Application
        notification.BalloonTipIcon = ToolTipIcon.Info
        notification.BalloonTipTitle = title
        notification.BalloonTipText = message
        notification.ShowBalloonTip(3000)
    End Sub


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

End Module
