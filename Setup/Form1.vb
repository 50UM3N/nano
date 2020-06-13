Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Win32
Imports IWshRuntimeLibrary
Imports WSHControllerLibrary
Public Class Form1

    Public directoryTargetLocation As String ' = "E:\Documents\Projects\Visual Studio\Music Player\Music Player Install\bin\Debug\file\Debug" 'Selected file path
    Public Destinydirectory As String 'Selected dest directory path
    Public index, totalsize As Integer

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim parts As String() = directoryTargetLocation.Split(New Char() {"\"c})
        Dim filename As String = parts(parts.Count - 1) 'target folder name

        Dim dir_path As String = "" 'directory without target folder name
        For f As Integer = 0 To parts.Count - 2
            dir_path += parts(f) + "\"
        Next
        Dim copied As Integer = 0
        Dim counter As Integer = IO.Directory.GetFiles(directoryTargetLocation, "*.*", IO.SearchOption.AllDirectories).Length 'counts the number of files
        SetProgressbar(counter, ProgressBar2) 'Sets ProgressBar maximum to number of files
        setLabelTxt("Copied (0/" + counter.ToString + ")", Label4) 'displays the amount of copied files
        Dim FolderList As New List(Of String)
        FolderList.Add(directoryTargetLocation) 'Set first folder
        Do While True
            If (BackgroundWorker1.CancellationPending = True) Then 'cancel loop
                e.Cancel = True
                Exit Do
            End If
            Dim FoldersInsideDirectory As New List(Of String)
            If FolderList.Count = 0 Then
                Exit Do 'If there is no folder to copy Exit Do
            Else
                For l As Integer = 0 To FolderList.Count - 1

                    If (BackgroundWorker1.CancellationPending = True) Then 'stop for loop
                        e.Cancel = True
                        Exit For
                    End If
                    Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(FolderList(l))
                    Dim dest As String = FolderList(l).Replace(dir_path, "")
                    If (Not System.IO.Directory.Exists(Destinydirectory + "\" + dest)) Then 'create subFolder inside directory
                        System.IO.Directory.CreateDirectory(Destinydirectory + "\" + dest)
                    End If
                    Dim fileSystemInfo As System.IO.FileSystemInfo
                    For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
                        If (BackgroundWorker1.CancellationPending = True) Then
                            e.Cancel = True
                            Exit For
                        End If
                        Dim destinationFileName As String = System.IO.Path.Combine(Destinydirectory + "\" + dest, fileSystemInfo.Name)
                        If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                            Dim streamRead As New System.IO.FileStream(fileSystemInfo.FullName, System.IO.FileMode.Open)
                            setLabelTxt(fileSystemInfo.FullName.ToString, Label3)
                            setDgCol(Label3.Text, dgDetails)
                            Dim streamWrite As New System.IO.FileStream(Destinydirectory + "\" + dest + "\" + fileSystemInfo.Name, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
                            Dim lngLen As Long = streamRead.Length - 1
                            Dim byteBuffer(1048576) As Byte   'our stream buffer
                            Dim intBytesRead As Integer    'number of bytes read
                            While streamRead.Position < lngLen    'keep streaming until EOF
                                If (BackgroundWorker1.CancellationPending = True) Then
                                    e.Cancel = True
                                    Exit While
                                End If
                                BackgroundWorker1.ReportProgress(CInt(streamRead.Position / lngLen * 100))
                                intBytesRead = (streamRead.Read(byteBuffer, 0, 1048576))
                                streamWrite.Write(byteBuffer, 0, intBytesRead)
                                totalsize += intBytesRead
                                'Debug.Print(intBytesRead)
                            End While
                            'Clean up 
                            streamWrite.Flush()
                            streamWrite.Close()
                            streamRead.Close()
                            addProgress(1, ProgressBar2)
                            copied += 1
                            setLabelTxt("Copied (" + copied.ToString + "/" + counter.ToString + ")", Label4)
                        Else
                            FoldersInsideDirectory.Add(fileSystemInfo.FullName)
                        End If
                    Next
                Next
                FolderList.Clear()
                FolderList = FoldersInsideDirectory
            End If
        Loop
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Copy canceled!")
        Else
            'btnBack.Enabled = True
            btnNext.Enabled = True
            'MsgBox("Copy complete!")
        End If
    End Sub

    Private Sub setDgCol(ByVal text As String, ByVal dg As DataGridView)
        If dg.InvokeRequired Then
            dg.Invoke(New setDgColInvoker(AddressOf setDgCol), text, dg)
        Else
            dg.Rows.Add(text)
            dg.Rows(dg.Rows.Count - 1).Selected = True
        End If
    End Sub

    Private Delegate Sub setDgColInvoker(ByVal text As String, ByVal lst As DataGridView)

    Private Sub setLabelTxt(ByVal text As String, ByVal lbl As Label)
        If lbl.InvokeRequired Then
            lbl.Invoke(New setLabelTxtInvoker(AddressOf setLabelTxt), text, lbl)
        Else
            lbl.Text = text
        End If
    End Sub

    Private Delegate Sub setLabelTxtInvoker(ByVal text As String, ByVal lbl As Label)

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub SetProgressbar(ByVal val As Integer, ByVal progressba As ProgressBar)
        If progressba.InvokeRequired Then
            progressba.Invoke(New SetProgressbarInvoker(AddressOf SetProgressbar), val, progressba)
        Else
            progressba.Value = 0
            progressba.Maximum = val
        End If
    End Sub

    Private Delegate Sub SetProgressbarInvoker(ByVal val As Integer, ByVal progressba As ProgressBar)

    Private Sub addProgress(ByVal val As Integer, ByVal progressba As ProgressBar)
        If progressba.InvokeRequired Then
            progressba.Invoke(New addProgressInvoker(AddressOf addProgress), val, progressba)
        Else
            progressba.Value += val
        End If
    End Sub
    Private Delegate Sub addProgressInvoker(ByVal val As Integer, ByVal progressba As ProgressBar)

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < 4 Then
            index += 1
            BunifuPages1.PageIndex = index
            If index = 3 Then
                btnNext.Enabled = False
                btnBack.Enabled = False
                BackgroundWorker1.RunWorkerAsync()
            ElseIf index = 4 Then
                btnNext.Text = "Finish"
                'Close()
            ElseIf index = 1 Then
                btnBack.Enabled = True
            End If
        Else
            Debug.Print(totalsize)
            registryEntry()
            createShortcut()
            Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If index > 0 Then
            index -= 1
            BunifuPages1.PageIndex = index
            If index = 0 Then
                btnBack.Enabled = False
            End If
        End If
    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click
        If MsgBox("Doy you exit", vbOKCancel) = vbOK Then
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        If btnDetails.Tag Then
            btnDetails.Tag = 0
            dgDetails.Visible = False
        Else
            btnDetails.Tag = 1
            dgDetails.Visible = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        f.Description = "Select Directory"
        If f.ShowDialog() = DialogResult.OK Then
            Destinydirectory = f.SelectedPath
            txtDestination.Text = f.SelectedPath
        End If
    End Sub

    Private Sub registryEntry()
        Dim regKey As RegistryKey
        totalsize = totalsize / 1024
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", True)
        regKey.CreateSubKey("nano")
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\nano", True)
        regKey.SetValue("DisplayVersion", "2.0.1.0")
        regKey.SetValue("Publisher", "NINJAHYDRA")
        regKey.SetValue("DisplayName", "Nano")
        regKey.SetValue("UrlInfoAbout", "www.ninjahydra.com")
        regKey.SetValue("EstimatedSize", totalsize, RegistryValueKind.DWord)
        regKey.SetValue("Comments", "")
        regKey.SetValue("Contact", "")
        regKey.SetValue("DisplayIcon", Destinydirectory & "\Nano\icon.ico")
        regKey.SetValue("UninstallString", Destinydirectory & "\Nano\Uninstall.exe")
        regKey.SetValue("InstallLocation", Destinydirectory & "\Nano")
        regKey.SetValue("NoModify", "1")
        regKey.SetValue("NoRepair", "1")
        regKey.Close()
        Debug.Print("Registry Added")
    End Sub
    Private Sub createShortcut()
        Dim Ws As WshShellClass = New WshShellClass
        Dim shortcur As IWshRuntimeLibrary.IWshShortcut
        If chkboxDesktop.Checked = True Then
            Dim desktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            shortcur = CType(Ws.CreateShortcut(desktopFolder & "\Nano.lnk"), IWshRuntimeLibrary.IWshShortcut)
            shortcur.TargetPath = Destinydirectory & "\Nano\Nano.exe"
            shortcur.Save()
        End If
        If chkboxStart.Checked = True Then
            Dim startmenufolder As String = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
            shortcur = CType(Ws.CreateShortcut(startmenufolder & "\Programs\Nano.lnk"), IWshRuntimeLibrary.IWshShortcut)
            shortcur.TargetPath = Destinydirectory & "\Nano\Nano.exe"
            shortcur.Save()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        directoryTargetLocation = Directory.GetCurrentDirectory() & "\file\Nano"
        Destinydirectory = txtDestination.Text
    End Sub

End Class
