Imports Microsoft.Win32
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BunifuPages1.PageIndex = 1
        If My.Computer.FileSystem.FileExists("C:\Users\SOUMEN\Desktop\Nano.lnk") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\SOUMEN\Desktop\Nano.lnk")
        End If
        If My.Computer.FileSystem.FileExists("C:\Users\SOUMEN\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Nano.lnk") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\SOUMEN\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Nano.lnk")
        End If
        delFiles()
        delRegistry()
        timer.Interval = 5000
        timer.Start()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        BunifuPages1.PageIndex = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub delRegistry()
        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", True)
        regKey.DeleteSubKey("nano", True)
        regKey.Close()
        'MsgBox("Deleted subkey MyApp")
    End Sub
    Private Sub delFiles()
        Dim file As IO.FileInfo() = New IO.DirectoryInfo(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\nano", "InstallLocation", Nothing)).GetFiles("*.*")
        For Each fi As IO.FileInfo In file
            If fi.Name <> "Bunifu.Core.dll" And fi.Name <> "Bunifu.UI.WinForms.BunifuPages.dll" And fi.Name <> "Guna.UI.dll" And fi.Name <> "Uninstall.exe" Then
                fi.Delete()
            End If
        Next
    End Sub
End Class
