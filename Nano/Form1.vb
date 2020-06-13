Imports System.IO
Public Class Form1
    Public index As Integer  'take the current playing songs index
    Public shuffle, Ri, Rm, Rh, Rh1, flag As Integer
    Dim sz As Integer ' store the current size of the panel2(inner panel)
    Enum animation
        formOpen 'for form load 
        formClose  'for form load
        mnuOpen
        mnuClose
        scrlOpen
        scrlClose
        pnlUp
        pnlDown
    End Enum
    Public action, action1 As animation

#Region "Music player main controls"

    ' start the player or music
    Private Sub play()
        Dim a As String ' store then file name from datagrid 
        a = fil.Rows(index).Cells(0).Value.ToString ' fetch thencurrent index music
        player.URL = a
        player.Ctlcontrols.play() ' start playing
        timmerStatus.Enabled = True ' timer for the status scroll bar
        btnPlayPause.Image = My.Resources.wpause
        btnPlayPause.OnHoverImage = My.Resources.pause
        btnPlayPause.Tag = "pause"
    End Sub

    ' when playercontrol is a music is pressed it encounted the function
    Public Sub clk(ByVal i As String)
        ' process to call dynamically created object's methords
        Dim l As playercontrol
        If i <> index Then
            l = pnlInner.Controls.Item("lbl" & index)
            l.col("#FFFFFF")
        End If
        index = i
        shuffle = i
        play()
    End Sub

    ' open music 
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        ' open music file from pc/hdd
        Dim file As TagLib.File ' this libary is udes to fetch the all information about a music file
        pnlInner.AutoSize = True
        pnlInner.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Dim openfile As OpenFileDialog = New OpenFileDialog
        openfile.Multiselect = True
        openfile.Filter = "Mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
        If openfile.ShowDialog = DialogResult.OK Then
            For Each fl As String In openfile.FileNames
                file = TagLib.File.Create(fl)
                Dim title As String
                If file.Tag.Title Is Nothing Then
                    'Dim finfo As FileInfo =
                    title = New FileInfo(fl).Name
                Else
                    title = file.Tag.Title
                End If
                ' dynamically create playercontrol and assign the value with it
                Dim lbl As New playercontrol
                lbl.Name = "lbl" & sz
                lbl.nam(title, file.Properties.Duration.ToString(), sz)
                lbl.Location = New Point(0, sz * lbl.Height)
                sz += 1
                fil.Rows.Add(fl)
                pnlInner.Controls.Add(lbl)
            Next
        Else
            Exit Sub
        End If
        ' if the size of the inner panel is big than outer panel then visivla the scroll bar
        If pnlInner.Height > pnlOuter.Height + 4 Then
            scroll.Visible = True
        End If
        scroll.Maximum = pnlInner.Height - 210 ' assign the maximus length of scrollbar
        ' shuffle calculation
        Rh1 = fil.Rows.Count
        If Rh1 Mod 2 = 0 Then
            Rh = Rh1 + 1
        Else
            Rh = Rh1
        End If
        Rm = (Rh - 1) / 2
        'end shuffle
        If player.playState <> WMPLib.WMPPlayState.wmppsPlaying And player.URL = Nothing Then
            action = animation.mnuOpen
            Timer1.Start()
            'pnlOuter.Location = New Point(23, 242)
            'pictureBanner.Location = New Point(-2, 460)
            'Me.Height = 570
            index = 0
            Dim l As playercontrol
            l = pnlInner.Controls.Item("lbl" & index)
            l.col("#F7A931")
            play()
        End If
    End Sub

    ' play bause button
    Private Sub btnPlayPause_Click(sender As Object, e As EventArgs) Handles btnPlayPause.Click
        ' change the play pos button image
        If btnPlayPause.Tag = "play" And player.URL <> "" Then
            player.Ctlcontrols.play()
            btnPlayPause.Image = My.Resources.wpause
            btnPlayPause.OnHoverImage = My.Resources.pause
            btnPlayPause.Tag = "pause"
            tooltip.SetToolTip(btnPlayPause, "Pause")
        ElseIf btnPlayPause.Tag = "pause" And player.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            player.Ctlcontrols.pause()
            btnPlayPause.Image = My.Resources.play
            btnPlayPause.OnHoverImage = My.Resources.wplay
            btnPlayPause.Tag = "play"
            tooltip.SetToolTip(btnPlayPause, "Play")
        End If
    End Sub

    ' next song 
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If shuffle <= fil.Rows.Count - 1 Then
            Dim l As playercontrol
            l = pnlInner.Controls.Item("lbl" & index)
            l.col("#FFFFFF")
            If shuffle = fil.Rows.Count - 1 Then
                shuffle = 0
                index = 0
            Else
                If btnShuffle.Tag = "on" Then
                    'calculation shuffle index
                    Ri = index
                    Ri = ((Ri + Rm) Mod Rh)
                    If Ri >= Rh1 Then
                        Ri = ((Ri + Rm) Mod Rh)
                    End If
                    'end shuffling
                    index = Ri ' change into next music
                ElseIf btnShuffle.Tag = "off" Then
                    index += 1
                End If
                shuffle += 1
            End If
            l = pnlInner.Controls.Item("lbl" & index)
            l.col("#F7A931")
            If ((l.valget * 35) + (pnlInner.Location.Y + 35)) > 210 Then
                pnlInner.Top -= ((l.valget * 35) + (pnlInner.Location.Y + 35)) - 210
                scroll.Value = -pnlInner.Top
            ElseIf ((l.valget * 35) + (pnlInner.Location.Y + 35)) < 35 Then
                pnlInner.Top = -(l.valget * 35)
                scroll.Value = -pnlInner.Top
            End If
            play()
        End If
    End Sub

    ' previous song
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If shuffle >= 0 Then
            Dim l As playercontrol
            l = pnlInner.Controls.Item("lbl" & index)
            l.col("#FFFFFF")
            If shuffle = 0 Then
                shuffle = fil.Rows.Count - 1
                index = shuffle
            Else
                If btnShuffle.Tag = "on" Then
                    'calculation shuffle index
                    Ri = index
                    Ri = ((Ri + Rm) Mod Rh)
                    If Ri >= Rh1 Then
                        Ri = ((Ri + Rm) Mod Rh)
                    End If
                    'end shuffling
                    index = Ri ' change into next music
                Else
                    index -= 1
                End If
                shuffle -= 1
            End If
            l = pnlInner.Controls.Item("lbl" & index)
            l.col("#F7A931")
            If ((l.valget * 35) + (pnlInner.Location.Y)) < 0 Then
                pnlInner.Top += -((l.valget * 35) + (pnlInner.Location.Y))
                scroll.Value = -pnlInner.Top
            ElseIf (l.valget * 35) + (pnlInner.Location.Y + 35) > 210 Then
                pnlInner.Top += -(((l.valget + 1) * 35) - 210 + pnlInner.Top)
                scroll.Value = -pnlInner.Top
            End If
            play()
        End If
    End Sub

    ' timer for music status bar
    Private Sub timmerStatus_Tick(sender As Object, e As EventArgs) Handles timmerStatus.Tick
        Dim pos As Integer = Convert.ToInt32(player.Ctlcontrols.currentPosition * 1000) ' current possition in ms of the curren playing music
        Dim duration As Integer = Convert.ToInt32(player.currentMedia.duration * 1000) ' total duration of the music in ms
        If duration > 0 Then
            Try
                statusTrackBar.Value = Convert.ToInt32((pos * 100) / duration) ' update the status scroll bar of current music 
                probarStatus.Value = statusTrackBar.Value
            Catch ex As Exception
            End Try
        End If
        ' update current playing music details
        lblCurrent.Text = player.Ctlcontrols.currentPositionString
        lblDuration.Text = player.currentMedia.durationString
        lblTitle.Text = player.currentMedia.name
        lblAlbum.Text = player.currentMedia.getItemInfo("Album")
        lblMinimizeTitle.Text = player.currentMedia.name
        lblMinimizeAlbum.Text = player.currentMedia.getItemInfo("Album")
        If player.playState = WMPLib.WMPPlayState.wmppsStopped Then
            If shuffle <> fil.Rows.Count - 1 Then
                If btnRepeat.Tag = "off" Or btnRepeat.Tag = "all" Then
                    Dim l As playercontrol
                    l = pnlInner.Controls.Item("lbl" & index)
                    l.col("#FFFFFF")
                    If btnShuffle.Tag = "on" Then
                        'calculation shuffle index
                        Ri = index
                        Ri = ((Ri + Rm) Mod Rh)
                        If Ri >= Rh1 Then
                            Ri = ((Ri + Rm) Mod Rh)
                        End If
                        index = Ri
                    ElseIf btnShuffle.Tag = "off" Then
                        index += 1
                    End If
                    l = pnlInner.Controls.Item("lbl" & index)
                    l.col("#F7A931")
                    shuffle += 1
                    ' change the control possition in updown
                    If ((l.valget * 35) + (pnlInner.Location.Y)) < 0 Then
                        pnlInner.Top += -((l.valget * 35) + (pnlInner.Location.Y))
                        scroll.Value = -pnlInner.Top
                    ElseIf (l.valget * 35) + (pnlInner.Location.Y + 35) > 210 Then
                        pnlInner.Top += -(((l.valget + 1) * 35) - 210 + pnlInner.Top)
                        scroll.Value = -pnlInner.Top
                    End If
                End If
                play()
            ElseIf shuffle = fil.Rows.Count - 1 Then
                ' reset all controls 
                lblCurrent.Text = "--:--"
                statusTrackBar.Value = 0
                lblDuration.Text = "00:00"
                timmerStatus.Enabled = False
                btnPlayPause.Image = My.Resources.play
                btnPlayPause.OnHoverImage = My.Resources.wplay
                btnPlayPause.Tag = "play"
                Dim l As playercontrol
                l = pnlInner.Controls.Item("lbl" & index)
                l.col("#FFFFFF")
                lblTitle.Text = ""
                lblAlbum.Text = ""
                scroll.Value = 0
                If btnRepeat.Tag = "all" Then
                    l = pnlInner.Controls.Item("lbl" & 0)
                    l.col("#F7A931")
                    index = 0
                    shuffle = 0
                    play()
                End If
            End If
        End If
    End Sub

#End Region

#Region "All scroll bar's proparty"

    ' music status bar scroll
    Private Sub statusTrackBar_Scroll(sender As Object, e As ScrollEventArgs) Handles statusTrackBar.Scroll
        Try
            If player.URL <> Nothing Then ' check that the currently any music is active or not
                If (player.playState <> WMPLib.WMPPlayState.wmppsStopped And player.currentMedia.duration <> 0) Then
                    Dim NewPerc As Double = Convert.ToDouble(statusTrackBar.Value) / 100
                    Dim DurationVar As Integer = Convert.ToInt32(player.currentMedia.duration * 1000) ' milliseconds
                    Dim NewPos As Integer = (DurationVar * NewPerc) / 1000
                    player.Ctlcontrols.currentPosition = NewPos
                Else
                    statusTrackBar.Value = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' inner panel scroll bar
    Private Sub scroll_ValueChanged(sender As Object, e As EventArgs) Handles scroll.ValueChanged
        pnlInner.Top = -scroll.Value
    End Sub

    ' inner panel scroll bar size change
    Private Sub scroll_MouseHover(sender As Object, e As EventArgs) Handles scroll.MouseHover
        'scroll.Radius = 5
        action = animation.scrlOpen
        Timer1.Interval = 1
        Timer1.Start()
        'scroll.ScrollbarSize = 10
    End Sub

    ' inner panel scroll bar size change
    Private Sub scroll_MouseLeave(sender As Object, e As EventArgs) Handles scroll.MouseLeave
        action = animation.scrlClose
        Timer1.Interval = 1
        Timer1.Start()
        'scroll.Radius = 1
        'scroll.ScrollbarSize = 2
    End Sub

    ' volume scroll bar hover
    Private Sub volTrackBar_MouseHover(sender As Object, e As EventArgs) Handles volTrackBar.MouseHover
        ' volume button image according to volume intencity
        player.settings.volume = volTrackBar.Value
        If volTrackBar.Value > 65 Then
            btnSound.Image = My.Resources.wspeaker
            btnSound.OnHoverImage = My.Resources.speaker
            tooltip.SetToolTip(btnSound, "Mute: Off")
        ElseIf volTrackBar.Value > 32 And volTrackBar.Value <= 65 Then
            btnSound.Image = My.Resources.wspeaker65
            btnSound.OnHoverImage = My.Resources.speaker65
            tooltip.SetToolTip(btnSound, "Mute: Off")
        ElseIf volTrackBar.Value > 0 And volTrackBar.Value <= 32 Then
            btnSound.Image = My.Resources.wspeaker32
            btnSound.OnHoverImage = My.Resources.speaker32
            tooltip.SetToolTip(btnSound, "Mute: Off")
        Else
            btnSound.Image = My.Resources.wspeakermute
            btnSound.OnHoverImage = My.Resources.speakermute
            tooltip.SetToolTip(btnSound, "Mute: On")
        End If
        lblVol.Text = volTrackBar.Value
    End Sub

    ' volume scroll bar 
    Private Sub volTrackBar_Scroll(sender As Object, e As ScrollEventArgs) Handles volTrackBar.Scroll
        ' volume button image according to volume intencity
        player.settings.volume = volTrackBar.Value
        If volTrackBar.Value > 65 Then
            btnSound.Image = My.Resources.wspeaker
            btnSound.OnHoverImage = My.Resources.speaker
            tooltip.SetToolTip(btnSound, "Mute: Off")
        ElseIf volTrackBar.Value > 32 And volTrackBar.Value <= 65 Then
            btnSound.Image = My.Resources.wspeaker65
            btnSound.OnHoverImage = My.Resources.speaker65
            tooltip.SetToolTip(btnSound, "Mute: Off")
        ElseIf volTrackBar.Value > 0 And volTrackBar.Value <= 32 Then
            btnSound.Image = My.Resources.wspeaker32
            btnSound.OnHoverImage = My.Resources.speaker32
            tooltip.SetToolTip(btnSound, "Mute: Off")
        Else
            btnSound.Image = My.Resources.wspeakermute
            btnSound.OnHoverImage = My.Resources.speakermute
            tooltip.SetToolTip(btnSound, "Mute: On")
        End If
        lblVol.Text = volTrackBar.Value
    End Sub

#End Region

#Region "Top button's controls"

    ' minimize button
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Minimized Then
            Me.Hide()
            notification.Visible = True
            notification.ShowBalloonTip(1000)
        ElseIf FormWindowState.Normal = Me.WindowState Then
            notification.Visible = False
        End If
    End Sub

    ' btn minimize view
    Private Sub btnMiniView_Click(sender As Object, e As EventArgs) Handles btnMiniView.Click
        If player.URL <> Nothing Then
            If btnMiniView.Tag = "max" Then
                ' necessary control location set
                btnMiniView.Location = New Point(289, 246)
                albumart.Location = New Point(87, -3)
                lblMinimizeTitle.Location = New Point(12, 150)
                lblMinimizeAlbum.Location = New Point(12, 177)
                pnlMediaControl.Location = New Point(87, 203)
                probarStatus.Location = New Point(0, 280)
                ' end location set
                ' necessary control visibility set
                pnlUpperControl.Visible = False
                pnlMediaDetails.Visible = False
                pnlMediaManupulation.Visible = False
                pnlMediaStatus.Visible = False
                pnlOuter.Visible = False
                pictureBanner.Visible = False
                ' end visibility set
                If btnPlaylist.Tag = "open" Then
                    Me.Size = New Point(325, 286)
                Else
                    Me.Size = New Point(325, 286)
                End If
                Me.StartPosition = FormStartPosition.Manual
                Dim x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 10
                Dim y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 10
                Me.Location = New Point(x, y)
                tooltip.SetToolTip(btnMiniView, "Play in Maximize View")
                btnMiniView.Tag = "min"
            ElseIf btnMiniView.Tag = "min" Then
                ' necessary control location set
                btnMiniView.Location = New Point(344, 8)
                albumart.Location = New Point(27, 24)
                lblMinimizeTitle.Location = New Point(601, 498)
                lblMinimizeAlbum.Location = New Point(601, 525)
                pnlMediaControl.Location = New Point(27, 169)
                probarStatus.Location = New Point(590, 561)
                ' end location set
                ' necessary control visibility set
                pnlUpperControl.Visible = True
                pnlMediaDetails.Visible = True
                pnlMediaManupulation.Visible = True
                pnlMediaStatus.Visible = True
                pnlOuter.Visible = True
                pictureBanner.Visible = True
                ' end visibility set
                If btnPlaylist.Tag = "open" Then
                    Me.Size = New Point(564, 570)
                Else
                    Me.Size = New Point(564, 346)
                End If
                Me.StartPosition = FormStartPosition.Manual
                Dim x = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)
                Dim y = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)
                Me.Location = New Point(x, y)
                tooltip.SetToolTip(btnMiniView, "Play in Minimize View")
                btnMiniView.Tag = "max"
            End If
        End If
    End Sub

    ' show playlist
    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        If player.URL <> Nothing Then
            If btnPlaylist.Tag = "open" Then
                action = animation.mnuClose
                Timer1.Interval = 1
                Timer1.Start()
                'pictureBanner.Location = New Point(-2, 236)
                'Me.Height = 346
                tooltip.SetToolTip(btnPlaylist, "Show Playlist")
                btnPlaylist.Tag = "close"
            ElseIf btnPlaylist.Tag = "close" Then
                action = animation.mnuOpen
                Timer1.Interval = 1
                Timer1.Start()
                'pictureBanner.Location = New Point(-2, 460)
                'Me.Height = 570
                tooltip.SetToolTip(btnPlaylist, "Hide Playlist")
                btnPlaylist.Tag = "open"
            End If
        End If
    End Sub

    ' github buttom
    Private Sub btnGitHub_Click(sender As Object, e As EventArgs) Handles btnGitHub.Click
        Process.Start("https://www.github.com/50UM3N")
    End Sub

    ' about button
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Form2.info(Me.Location.X, Me.Location.Y, Me.Height)
    End Sub

#End Region

#Region "Music playlist controls"

    ' shuffle button
    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click
        If btnShuffle.Tag = "off" Then
            btnShuffle.Image = My.Resources.wshuffleon
            btnShuffle.OnHoverImage = My.Resources.shuffleon
            btnShuffle.Tag = "on"
            tooltip.SetToolTip(btnShuffle, "Shuffle: On")
        ElseIf btnShuffle.Tag = "on" Then
            btnShuffle.Image = My.Resources.wshuffleoff
            btnShuffle.OnHoverImage = My.Resources.shuffleoff
            btnShuffle.Tag = "off"
            tooltip.SetToolTip(btnShuffle, "Shuffle: Off")
            shuffle = index
        End If
    End Sub

    ' repeat button
    Private Sub btnRepeat_Click(sender As Object, e As EventArgs) Handles btnRepeat.Click
        If btnRepeat.Tag = "off" Then
            btnRepeat.Image = My.Resources.wrepeatone
            btnRepeat.OnHoverImage = My.Resources.repeatone
            btnRepeat.Tag = "one"
            tooltip.SetToolTip(btnRepeat, "Repeat: One")
        ElseIf btnRepeat.Tag = "one" Then
            btnRepeat.Image = My.Resources.wrepeatall
            btnRepeat.OnHoverImage = My.Resources.repeatall
            btnRepeat.Tag = "all"
            tooltip.SetToolTip(btnRepeat, "Repeat: All")
        ElseIf btnRepeat.Tag = "all" Then
            btnRepeat.Image = My.Resources.wrepeatoff
            btnRepeat.OnHoverImage = My.Resources.repeatoff
            btnRepeat.Tag = "off"
            tooltip.SetToolTip(btnRepeat, "Repeat: Off")
        End If
    End Sub

    ' equlizer button
    Private Sub btnEqulizer_Click(sender As Object, e As EventArgs) Handles btnEqulizer.Click

    End Sub

    ' mute button
    Private Sub btnSound_Click(sender As Object, e As EventArgs) Handles btnSound.Click
        ' volume button click for mute 
        If player.settings.volume = 0 Then
            player.settings.volume = 66
            volTrackBar.Value = 66
            btnSound.Image = My.Resources.wspeaker
            btnSound.OnHoverImage = My.Resources.speaker
            lblVol.Text = 66
            tooltip.SetToolTip(btnSound, "Mute: Off")
        Else
            player.settings.volume = 0
            volTrackBar.Value = 0
            btnSound.Image = My.Resources.wspeakermute
            btnSound.OnHoverImage = My.Resources.speakermute
            lblVol.Text = 0
            tooltip.SetToolTip(btnSound, "Mute: On")
        End If
    End Sub

#End Region

#Region "menu strip item's functions"

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        notification.Visible = False
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub GitHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitHubToolStripMenuItem.Click
        Process.Start("https://www.github.com/50UM3N")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.info(Me.Location.X, Me.Location.Y, Me.Height)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Interval = 3000
        action = animation.formClose
        Timer1.Start()
        Dim f As Form2 = New Form2
        f.setOpen()
        player.settings.volume = volTrackBar.Value
        pnlOuter.Location = New Point(23, 458)
        pictureBanner.Location = New Point(-2, 236)
        Me.Height = 346
    End Sub

    ' scroll in outer panel or autoscroll
    Private Sub pnlInner_MouseHover(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlInner.MouseWheel
        Dim s As Integer
        s = (pnlInner.Height - 210) / 10
        If e.Delta > 0 And scroll.Visible = True Then
            scroll.Value -= s
        ElseIf e.Delta < 0 And scroll.Visible = True Then
            scroll.Value -= -s
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notification.MouseDoubleClick
        Me.Show()
        notification.Visible = False
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case animation.formClose
                Me.ShowInTaskbar = True
                action = animation.formOpen
                Timer1.Interval = 10
            Case animation.formOpen
                If Me.Opacity = 1 Then
                    action = Nothing
                    Timer1.Stop()
                Else
                    Me.Opacity += 0.1
                End If
            Case animation.mnuClose
                If pictureBanner.Location.Y = 236 And Me.Height = 346 Then
                    action = Nothing
                    Timer1.Stop()
                Else
                    pictureBanner.Location = New Point(-2, pictureBanner.Location.Y - 8)
                    Me.Height -= 8
                    If pictureBanner.Location.Y = 452 Then
                        Timer2.Interval = 1
                        action1 = animation.pnlDown
                        Timer2.Start()
                        'pnlOuter.Location = New Point(23, 460)
                    End If
                End If
            Case animation.mnuOpen
                If pictureBanner.Location.Y = 460 And Me.Height = 570 Then
                    action = Nothing
                    Timer1.Stop()
                Else
                    pictureBanner.Location = New Point(-2, pictureBanner.Location.Y + 8)
                    Me.Height += 8
                    'Debug.Print(pictureBanner.Location.Y)
                    If pictureBanner.Location.Y = 112 + 236 Then
                        Timer2.Interval = 1
                        action1 = animation.pnlUp
                        Timer2.Start()
                        'pnlOuter.Location = New Point(23, 242)
                        'Debug.Print(pnlOuter.Location.ToString)
                    End If
                End If
            Case animation.scrlClose
                If scroll.ScrollbarSize = 2 Then
                    action = Nothing
                    Timer1.Stop()
                Else
                    scroll.ScrollbarSize -= 1
                    If scroll.ScrollbarSize Mod 2 = 0 Then
                        scroll.Radius -= 1
                    End If
                End If
            Case animation.scrlOpen
                If scroll.ScrollbarSize = 10 Then
                    action = Nothing
                    Timer1.Stop()
                Else
                    scroll.ScrollbarSize += 1
                    If scroll.ScrollbarSize Mod 2 = 0 Then
                        scroll.Radius += 1
                    End If
                End If
        End Select
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case action1
            Case animation.pnlDown
                If pnlOuter.Location.Y = 458 Then
                    action1 = Nothing
                    Timer2.Stop()
                Else
                    pnlOuter.Location = New Point(23, pnlOuter.Location.Y + 8)
                End If
            Case animation.pnlUp
                If pnlOuter.Location.Y = 242 Then
                    action1 = Nothing
                    Timer2.Stop()
                Else
                    pnlOuter.Location = New Point(23, pnlOuter.Location.Y - 8)
                End If
        End Select
    End Sub
End Class
