Option Strict Off
Imports System.Runtime.InteropServices.Automation

Partial Public Class COM
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmdTextToSpeech_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If TestForComSupport() Then
            Using speech As Object = AutomationFactory.CreateObject("Sapi.SpVoice")
                speech.Volume = 100
                speech.Speak("This is a test")
            End Using
        End If
    End Sub

    Private Sub cmdRunWord_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If TestForComSupport() Then
            Using word As Object = AutomationFactory.CreateObject("Word.Application")
                Dim document As Object = word.Documents.Add()

                Dim paragraph As Object = document.Content.Paragraphs.Add
                paragraph.Range.Text = "Heading 1"
                paragraph.Range.Font.Bold = True
                paragraph.Format.SpaceAfter = 18
                paragraph.Range.InsertParagraphAfter()

                paragraph = document.Content.Paragraphs.Add
                paragraph.Range.Font.Bold = False
                paragraph.Range.Text = "This is some more text"

                word.Visible = True
            End Using
        End If

    End Sub

    Private Sub cmdReadAndWriteAnywhere_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If TestForComSupport() Then
            Using shell As Object = AutomationFactory.CreateObject("WScript.Shell")
                Dim desktopPath As String = shell.RegRead("HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders\Desktop")

                Using fso As Object = AutomationFactory.CreateObject("Scripting.FileSystemObject")
                    Dim filePath As String = System.IO.Path.Combine(desktopPath, "TestFile.txt")
                    Dim file As Object = fso.CreateTextFile(filePath, True)
                    file.WriteLine("An elevated trust Silverlight application can write anywhere that doesn't require adminsitrative privileges.")
                    file.Close()

                    file = fso.OpenTextFile(filePath, 1, True)
                    MessageBox.Show(file.ReadAll())
                    file.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub cmdRunProcess_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If TestForComSupport() Then
            Using shell As Object = AutomationFactory.CreateObject("WScript.Shell")
                shell.Run("calc.exe")
            End Using
        End If
    End Sub

    Private Sub cmdReadRegistry_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If TestForComSupport() Then
            Using shell As Object = AutomationFactory.CreateObject("WScript.Shell")
                Dim desktopPath As String = shell.RegRead("HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders\Desktop")
                MessageBox.Show("The desktop files on this machine are placed in: " & desktopPath)
            End Using
        End If
    End Sub

    Private Function TestForComSupport() As Boolean
        If App.Current.InstallState <> InstallState.Installed Then
            MessageBox.Show("This feature is not available because the application is not installed.")
        ElseIf (Not App.Current.IsRunningOutOfBrowser) Then
            MessageBox.Show("This feature is not available because you are running in the browser.")
        ElseIf (Not App.Current.HasElevatedPermissions) Then
            MessageBox.Show("This feature is not available because the application does not have elevated trust.")
        ElseIf (Not AutomationFactory.IsAvailable) Then
            MessageBox.Show("This feature is not available because the operating system does not appear to support COM.")
        Else
            Return True
        End If
        Return False
    End Function

End Class
