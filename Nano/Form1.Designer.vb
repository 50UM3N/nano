<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.volTrackBar = New Guna.UI.WinForms.GunaTrackBar()
        Me.statusTrackBar = New Guna.UI.WinForms.GunaTrackBar()
        Me.timmerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnMinimize = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.fil = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlOuter = New System.Windows.Forms.Panel()
        Me.pnlInner = New System.Windows.Forms.Panel()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.lblVol = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.tooltip = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.menustrip = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMediaManupulation = New System.Windows.Forms.Panel()
        Me.btnFile = New Guna.UI.WinForms.GunaImageButton()
        Me.btnSound = New Guna.UI.WinForms.GunaImageButton()
        Me.btnEqulizer = New Guna.UI.WinForms.GunaImageButton()
        Me.btnRepeat = New Guna.UI.WinForms.GunaImageButton()
        Me.btnShuffle = New Guna.UI.WinForms.GunaImageButton()
        Me.pnlMediaControl = New System.Windows.Forms.Panel()
        Me.btnPlayPause = New Guna.UI.WinForms.GunaImageButton()
        Me.btnNext = New Guna.UI.WinForms.GunaImageButton()
        Me.btnPrevious = New Guna.UI.WinForms.GunaImageButton()
        Me.pnlMediaStatus = New System.Windows.Forms.Panel()
        Me.pnlMediaDetails = New System.Windows.Forms.Panel()
        Me.pnlUpperControl = New System.Windows.Forms.Panel()
        Me.btnGitHub = New Guna.UI.WinForms.GunaImageButton()
        Me.btnAbout = New Guna.UI.WinForms.GunaImageButton()
        Me.btnPlaylist = New Guna.UI.WinForms.GunaImageButton()
        Me.lblMinimizeTitle = New System.Windows.Forms.Label()
        Me.lblMinimizeAlbum = New System.Windows.Forms.Label()
        Me.probarStatus = New Guna.UI.WinForms.GunaProgressBar()
        Me.pictureBanner = New System.Windows.Forms.PictureBox()
        Me.btnMiniView = New Guna.UI.WinForms.GunaImageButton()
        Me.albumart = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.notification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOuter.SuspendLayout()
        Me.menustrip.SuspendLayout()
        Me.pnlMediaManupulation.SuspendLayout()
        Me.pnlMediaControl.SuspendLayout()
        Me.pnlMediaStatus.SuspendLayout()
        Me.pnlMediaDetails.SuspendLayout()
        Me.pnlUpperControl.SuspendLayout()
        CType(Me.pictureBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.lblDuration.Location = New System.Drawing.Point(332, 10)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(34, 13)
        Me.lblDuration.TabIndex = 36
        Me.lblDuration.Text = "00:00"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltip.SetToolTip(Me.lblDuration, "")
        Me.tooltip.SetToolTipIcon(Me.lblDuration, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblDuration, "")
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.lblCurrent.Location = New System.Drawing.Point(4, 10)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(22, 13)
        Me.lblCurrent.TabIndex = 35
        Me.lblCurrent.Text = "--:--"
        Me.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltip.SetToolTip(Me.lblCurrent, "")
        Me.tooltip.SetToolTipIcon(Me.lblCurrent, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblCurrent, "")
        '
        'volTrackBar
        '
        Me.volTrackBar.LargeChange = 1
        Me.volTrackBar.Location = New System.Drawing.Point(207, 8)
        Me.volTrackBar.MouseWheelBarPartitions = 50
        Me.volTrackBar.Name = "volTrackBar"
        Me.volTrackBar.Size = New System.Drawing.Size(110, 31)
        Me.volTrackBar.TabIndex = 34
        Me.tooltip.SetToolTip(Me.volTrackBar, "")
        Me.tooltip.SetToolTipIcon(Me.volTrackBar, Nothing)
        Me.tooltip.SetToolTipTitle(Me.volTrackBar, "")
        Me.volTrackBar.TrackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.volTrackBar.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.volTrackBar.TrackIdleColor = System.Drawing.Color.Silver
        Me.volTrackBar.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.volTrackBar.Value = 66
        '
        'statusTrackBar
        '
        Me.statusTrackBar.LargeChange = 0
        Me.statusTrackBar.Location = New System.Drawing.Point(39, 5)
        Me.statusTrackBar.MouseWheelBarPartitions = 100
        Me.statusTrackBar.Name = "statusTrackBar"
        Me.statusTrackBar.Size = New System.Drawing.Size(287, 23)
        Me.statusTrackBar.TabIndex = 33
        Me.tooltip.SetToolTip(Me.statusTrackBar, "")
        Me.tooltip.SetToolTipIcon(Me.statusTrackBar, Nothing)
        Me.tooltip.SetToolTipTitle(Me.statusTrackBar, "")
        Me.statusTrackBar.TrackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusTrackBar.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.statusTrackBar.TrackIdleColor = System.Drawing.Color.Silver
        Me.statusTrackBar.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusTrackBar.Value = 0
        '
        'timmerStatus
        '
        Me.timmerStatus.Interval = 1
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Blogger Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblTitle.Location = New System.Drawing.Point(5, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(358, 24)
        Me.lblTitle.TabIndex = 26
        Me.tooltip.SetToolTip(Me.lblTitle, "")
        Me.tooltip.SetToolTipIcon(Me.lblTitle, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblTitle, "")
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Blogger Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.LightGray
        Me.lblName.Location = New System.Drawing.Point(3, 2)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(178, 34)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "NANO PLAYER"
        Me.tooltip.SetToolTip(Me.lblName, "")
        Me.tooltip.SetToolTipIcon(Me.lblName, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblName, "")
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.btnMinimize.IconColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnMinimize.IconSize = 15.0!
        Me.btnMinimize.Location = New System.Drawing.Point(488, 8)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.OnHoverIconColor = System.Drawing.Color.White
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.Black
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 23
        Me.tooltip.SetToolTip(Me.btnMinimize, "Minimize")
        Me.tooltip.SetToolTipIcon(Me.btnMinimize, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnMinimize, "")
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(524, 8)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(30, 30)
        Me.GunaControlBox1.TabIndex = 22
        Me.tooltip.SetToolTip(Me.GunaControlBox1, "Close")
        Me.tooltip.SetToolTipIcon(Me.GunaControlBox1, Nothing)
        Me.tooltip.SetToolTipTitle(Me.GunaControlBox1, "")
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(1077, 44)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(26, 21)
        Me.player.TabIndex = 21
        Me.tooltip.SetToolTip(Me.player, "")
        Me.tooltip.SetToolTipIcon(Me.player, Nothing)
        Me.tooltip.SetToolTipTitle(Me.player, "")
        '
        'fil
        '
        Me.fil.AllowUserToAddRows = False
        Me.fil.AllowUserToDeleteRows = False
        Me.fil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.fil.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.fil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.fil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fil.ColumnHeadersVisible = False
        Me.fil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fil.DefaultCellStyle = DataGridViewCellStyle2
        Me.fil.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.fil.Location = New System.Drawing.Point(1077, 55)
        Me.fil.Name = "fil"
        Me.fil.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fil.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.fil.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fil.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.fil.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fil.Size = New System.Drawing.Size(11, 10)
        Me.fil.TabIndex = 42
        Me.tooltip.SetToolTip(Me.fil, "")
        Me.tooltip.SetToolTipIcon(Me.fil, Nothing)
        Me.tooltip.SetToolTipTitle(Me.fil, "")
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'pnlOuter
        '
        Me.pnlOuter.Controls.Add(Me.pnlInner)
        Me.pnlOuter.Location = New System.Drawing.Point(23, 242)
        Me.pnlOuter.Name = "pnlOuter"
        Me.pnlOuter.Size = New System.Drawing.Size(530, 210)
        Me.pnlOuter.TabIndex = 44
        Me.tooltip.SetToolTip(Me.pnlOuter, "")
        Me.tooltip.SetToolTipIcon(Me.pnlOuter, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlOuter, "")
        '
        'pnlInner
        '
        Me.pnlInner.Location = New System.Drawing.Point(0, 0)
        Me.pnlInner.Name = "pnlInner"
        Me.pnlInner.Size = New System.Drawing.Size(530, 210)
        Me.pnlInner.TabIndex = 45
        Me.tooltip.SetToolTip(Me.pnlInner, "")
        Me.tooltip.SetToolTipIcon(Me.pnlInner, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlInner, "")
        '
        'scroll
        '
        Me.scroll.BackColor = System.Drawing.Color.Transparent
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(542, 243)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.Radius = 1
        Me.scroll.ScrollbarSize = 2
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(10, 213)
        Me.scroll.TabIndex = 46
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.scroll.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tooltip.SetToolTip(Me.scroll, "")
        Me.tooltip.SetToolTipIcon(Me.scroll, Nothing)
        Me.tooltip.SetToolTipTitle(Me.scroll, "")
        Me.scroll.Visible = False
        '
        'lblVol
        '
        Me.lblVol.AutoSize = True
        Me.lblVol.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblVol.Location = New System.Drawing.Point(321, 12)
        Me.lblVol.Name = "lblVol"
        Me.lblVol.Size = New System.Drawing.Size(30, 23)
        Me.lblVol.TabIndex = 53
        Me.lblVol.Text = "66"
        Me.tooltip.SetToolTip(Me.lblVol, "")
        Me.tooltip.SetToolTipIcon(Me.lblVol, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblVol, "")
        '
        'lblAlbum
        '
        Me.lblAlbum.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbum.ForeColor = System.Drawing.Color.White
        Me.lblAlbum.Location = New System.Drawing.Point(6, 63)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(357, 23)
        Me.lblAlbum.TabIndex = 54
        Me.tooltip.SetToolTip(Me.lblAlbum, "")
        Me.tooltip.SetToolTipIcon(Me.lblAlbum, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblAlbum, "")
        '
        'tooltip
        '
        Me.tooltip.Active = True
        Me.tooltip.AlignTextWithTitle = False
        Me.tooltip.AllowAutoClose = True
        Me.tooltip.AllowFading = True
        Me.tooltip.AutoCloseDuration = 5000
        Me.tooltip.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tooltip.BorderColor = System.Drawing.Color.Gainsboro
        Me.tooltip.ClickToShowDisplayControl = False
        Me.tooltip.ConvertNewlinesToBreakTags = True
        Me.tooltip.DisplayControl = Nothing
        Me.tooltip.EntryAnimationSpeed = 350
        Me.tooltip.ExitAnimationSpeed = 200
        Me.tooltip.GenerateAutoCloseDuration = False
        Me.tooltip.IconMargin = 6
        Me.tooltip.InitialDelay = 2000
        Me.tooltip.Name = "tooltip"
        Me.tooltip.Opacity = 1.0R
        Me.tooltip.OverrideToolTipTitles = False
        Me.tooltip.Padding = New System.Windows.Forms.Padding(10)
        Me.tooltip.ReshowDelay = 2000
        Me.tooltip.ShowAlways = True
        Me.tooltip.ShowBorders = True
        Me.tooltip.ShowIcons = True
        Me.tooltip.ShowShadows = True
        Me.tooltip.Tag = Nothing
        Me.tooltip.TextFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tooltip.TextForeColor = System.Drawing.Color.White
        Me.tooltip.TextMargin = 2
        Me.tooltip.TitleFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tooltip.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tooltip.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.tooltip.ToolTipTitle = Nothing
        '
        'menustrip
        '
        Me.menustrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.GitHubToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.menustrip.Name = "GunaContextMenuStrip1"
        Me.menustrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.menustrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.menustrip.RenderStyle.ColorTable = Nothing
        Me.menustrip.RenderStyle.RoundedEdges = True
        Me.menustrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.menustrip.RenderStyle.SelectionBackColor = System.Drawing.Color.Transparent
        Me.menustrip.RenderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.menustrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.menustrip.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.menustrip.Size = New System.Drawing.Size(113, 92)
        Me.tooltip.SetToolTip(Me.menustrip, "")
        Me.tooltip.SetToolTipIcon(Me.menustrip, Nothing)
        Me.tooltip.SetToolTipTitle(Me.menustrip, "")
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ShowToolStripMenuItem.Image = Global.Nano.My.Resources.Resources.wm
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'GitHubToolStripMenuItem
        '
        Me.GitHubToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.GitHubToolStripMenuItem.Image = Global.Nano.My.Resources.Resources.wgithub1
        Me.GitHubToolStripMenuItem.Name = "GitHubToolStripMenuItem"
        Me.GitHubToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.GitHubToolStripMenuItem.Text = "GitHub"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.AboutToolStripMenuItem.Image = Global.Nano.My.Resources.Resources.winfo
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.CloseToolStripMenuItem.Image = Global.Nano.My.Resources.Resources.close
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'pnlMediaManupulation
        '
        Me.pnlMediaManupulation.Controls.Add(Me.btnFile)
        Me.pnlMediaManupulation.Controls.Add(Me.volTrackBar)
        Me.pnlMediaManupulation.Controls.Add(Me.btnSound)
        Me.pnlMediaManupulation.Controls.Add(Me.lblVol)
        Me.pnlMediaManupulation.Controls.Add(Me.btnEqulizer)
        Me.pnlMediaManupulation.Controls.Add(Me.btnRepeat)
        Me.pnlMediaManupulation.Controls.Add(Me.btnShuffle)
        Me.pnlMediaManupulation.Location = New System.Drawing.Point(181, 136)
        Me.pnlMediaManupulation.Name = "pnlMediaManupulation"
        Me.pnlMediaManupulation.Size = New System.Drawing.Size(367, 48)
        Me.pnlMediaManupulation.TabIndex = 62
        Me.tooltip.SetToolTip(Me.pnlMediaManupulation, "")
        Me.tooltip.SetToolTipIcon(Me.pnlMediaManupulation, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlMediaManupulation, "")
        '
        'btnFile
        '
        Me.btnFile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFile.Image = Global.Nano.My.Resources.Resources.cfile
        Me.btnFile.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFile.Location = New System.Drawing.Point(3, 3)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.OnHoverImage = Global.Nano.My.Resources.Resources.file
        Me.btnFile.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnFile.Size = New System.Drawing.Size(40, 40)
        Me.btnFile.TabIndex = 49
        Me.tooltip.SetToolTip(Me.btnFile, "Add Music")
        Me.tooltip.SetToolTipIcon(Me.btnFile, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnFile, "")
        '
        'btnSound
        '
        Me.btnSound.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSound.Image = Global.Nano.My.Resources.Resources.wspeaker
        Me.btnSound.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSound.Location = New System.Drawing.Point(163, 3)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.OnHoverImage = Global.Nano.My.Resources.Resources.speaker
        Me.btnSound.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnSound.Size = New System.Drawing.Size(40, 40)
        Me.btnSound.TabIndex = 48
        Me.tooltip.SetToolTip(Me.btnSound, "Mute: Off")
        Me.tooltip.SetToolTipIcon(Me.btnSound, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnSound, "")
        '
        'btnEqulizer
        '
        Me.btnEqulizer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEqulizer.Image = Global.Nano.My.Resources.Resources.wequlizer
        Me.btnEqulizer.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEqulizer.Location = New System.Drawing.Point(123, 3)
        Me.btnEqulizer.Name = "btnEqulizer"
        Me.btnEqulizer.OnHoverImage = Global.Nano.My.Resources.Resources.equlizer
        Me.btnEqulizer.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnEqulizer.Size = New System.Drawing.Size(40, 40)
        Me.btnEqulizer.TabIndex = 55
        Me.tooltip.SetToolTip(Me.btnEqulizer, "Add Music")
        Me.tooltip.SetToolTipIcon(Me.btnEqulizer, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnEqulizer, "")
        '
        'btnRepeat
        '
        Me.btnRepeat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRepeat.Image = Global.Nano.My.Resources.Resources.wrepeatoff
        Me.btnRepeat.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRepeat.Location = New System.Drawing.Point(83, 3)
        Me.btnRepeat.Name = "btnRepeat"
        Me.btnRepeat.OnHoverImage = Global.Nano.My.Resources.Resources.repeatoff
        Me.btnRepeat.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnRepeat.Size = New System.Drawing.Size(40, 40)
        Me.btnRepeat.TabIndex = 56
        Me.btnRepeat.Tag = "off"
        Me.tooltip.SetToolTip(Me.btnRepeat, "Repeat: Off")
        Me.tooltip.SetToolTipIcon(Me.btnRepeat, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnRepeat, "")
        '
        'btnShuffle
        '
        Me.btnShuffle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnShuffle.Image = CType(resources.GetObject("btnShuffle.Image"), System.Drawing.Image)
        Me.btnShuffle.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnShuffle.Location = New System.Drawing.Point(43, 3)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.OnHoverImage = Global.Nano.My.Resources.Resources.shuffleoff
        Me.btnShuffle.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnShuffle.Size = New System.Drawing.Size(40, 40)
        Me.btnShuffle.TabIndex = 57
        Me.btnShuffle.Tag = "off"
        Me.tooltip.SetToolTip(Me.btnShuffle, "Shuffle: Off")
        Me.tooltip.SetToolTipIcon(Me.btnShuffle, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnShuffle, "")
        '
        'pnlMediaControl
        '
        Me.pnlMediaControl.Controls.Add(Me.btnPlayPause)
        Me.pnlMediaControl.Controls.Add(Me.btnNext)
        Me.pnlMediaControl.Controls.Add(Me.btnPrevious)
        Me.pnlMediaControl.Location = New System.Drawing.Point(27, 169)
        Me.pnlMediaControl.Name = "pnlMediaControl"
        Me.pnlMediaControl.Size = New System.Drawing.Size(150, 66)
        Me.pnlMediaControl.TabIndex = 63
        Me.tooltip.SetToolTip(Me.pnlMediaControl, "")
        Me.tooltip.SetToolTipIcon(Me.pnlMediaControl, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlMediaControl, "")
        '
        'btnPlayPause
        '
        Me.btnPlayPause.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPlayPause.Image = Global.Nano.My.Resources.Resources.play
        Me.btnPlayPause.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnPlayPause.Location = New System.Drawing.Point(45, 3)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.OnHoverImage = Global.Nano.My.Resources.Resources.wplay
        Me.btnPlayPause.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPlayPause.Size = New System.Drawing.Size(60, 60)
        Me.btnPlayPause.TabIndex = 52
        Me.tooltip.SetToolTip(Me.btnPlayPause, "Play")
        Me.tooltip.SetToolTipIcon(Me.btnPlayPause, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnPlayPause, "")
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.Image = Global.Nano.My.Resources.Resources.wnext
        Me.btnNext.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnNext.Location = New System.Drawing.Point(107, 13)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverImage = Global.Nano.My.Resources.Resources._next
        Me.btnNext.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnNext.Size = New System.Drawing.Size(40, 40)
        Me.btnNext.TabIndex = 50
        Me.tooltip.SetToolTip(Me.btnNext, "Next")
        Me.tooltip.SetToolTipIcon(Me.btnNext, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnNext, "")
        '
        'btnPrevious
        '
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrevious.Image = Global.Nano.My.Resources.Resources.wback
        Me.btnPrevious.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnPrevious.Location = New System.Drawing.Point(3, 13)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.OnHoverImage = Global.Nano.My.Resources.Resources.back
        Me.btnPrevious.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPrevious.Size = New System.Drawing.Size(40, 40)
        Me.btnPrevious.TabIndex = 51
        Me.tooltip.SetToolTip(Me.btnPrevious, "Previous")
        Me.tooltip.SetToolTipIcon(Me.btnPrevious, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnPrevious, "")
        '
        'pnlMediaStatus
        '
        Me.pnlMediaStatus.Controls.Add(Me.statusTrackBar)
        Me.pnlMediaStatus.Controls.Add(Me.lblCurrent)
        Me.pnlMediaStatus.Controls.Add(Me.lblDuration)
        Me.pnlMediaStatus.Location = New System.Drawing.Point(181, 180)
        Me.pnlMediaStatus.Name = "pnlMediaStatus"
        Me.pnlMediaStatus.Size = New System.Drawing.Size(367, 33)
        Me.pnlMediaStatus.TabIndex = 64
        Me.tooltip.SetToolTip(Me.pnlMediaStatus, "")
        Me.tooltip.SetToolTipIcon(Me.pnlMediaStatus, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlMediaStatus, "")
        '
        'pnlMediaDetails
        '
        Me.pnlMediaDetails.Controls.Add(Me.lblName)
        Me.pnlMediaDetails.Controls.Add(Me.lblTitle)
        Me.pnlMediaDetails.Controls.Add(Me.lblAlbum)
        Me.pnlMediaDetails.Location = New System.Drawing.Point(181, 42)
        Me.pnlMediaDetails.Name = "pnlMediaDetails"
        Me.pnlMediaDetails.Size = New System.Drawing.Size(367, 92)
        Me.pnlMediaDetails.TabIndex = 65
        Me.tooltip.SetToolTip(Me.pnlMediaDetails, "")
        Me.tooltip.SetToolTipIcon(Me.pnlMediaDetails, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlMediaDetails, "")
        '
        'pnlUpperControl
        '
        Me.pnlUpperControl.Controls.Add(Me.btnGitHub)
        Me.pnlUpperControl.Controls.Add(Me.btnAbout)
        Me.pnlUpperControl.Controls.Add(Me.btnPlaylist)
        Me.pnlUpperControl.Location = New System.Drawing.Point(380, 8)
        Me.pnlUpperControl.Name = "pnlUpperControl"
        Me.pnlUpperControl.Size = New System.Drawing.Size(102, 30)
        Me.pnlUpperControl.TabIndex = 66
        Me.tooltip.SetToolTip(Me.pnlUpperControl, "")
        Me.tooltip.SetToolTipIcon(Me.pnlUpperControl, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlUpperControl, "")
        '
        'btnGitHub
        '
        Me.btnGitHub.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGitHub.Image = Global.Nano.My.Resources.Resources.wgithub2
        Me.btnGitHub.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGitHub.Location = New System.Drawing.Point(36, 0)
        Me.btnGitHub.Name = "btnGitHub"
        Me.btnGitHub.OnHoverImage = Global.Nano.My.Resources.Resources.github
        Me.btnGitHub.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnGitHub.Size = New System.Drawing.Size(30, 30)
        Me.btnGitHub.TabIndex = 58
        Me.tooltip.SetToolTip(Me.btnGitHub, "GitHub")
        Me.tooltip.SetToolTipIcon(Me.btnGitHub, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnGitHub, "")
        '
        'btnAbout
        '
        Me.btnAbout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAbout.Image = Global.Nano.My.Resources.Resources.winfo
        Me.btnAbout.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAbout.Location = New System.Drawing.Point(72, 0)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.OnHoverImage = Global.Nano.My.Resources.Resources.info
        Me.btnAbout.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnAbout.Size = New System.Drawing.Size(30, 30)
        Me.btnAbout.TabIndex = 59
        Me.tooltip.SetToolTip(Me.btnAbout, "About")
        Me.tooltip.SetToolTipIcon(Me.btnAbout, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnAbout, "")
        '
        'btnPlaylist
        '
        Me.btnPlaylist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPlaylist.Image = Global.Nano.My.Resources.Resources.wlist
        Me.btnPlaylist.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnPlaylist.Location = New System.Drawing.Point(0, 0)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.OnHoverImage = Global.Nano.My.Resources.Resources.list
        Me.btnPlaylist.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPlaylist.Size = New System.Drawing.Size(30, 30)
        Me.btnPlaylist.TabIndex = 60
        Me.btnPlaylist.Tag = "open"
        Me.tooltip.SetToolTip(Me.btnPlaylist, "Hide Playlist")
        Me.tooltip.SetToolTipIcon(Me.btnPlaylist, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnPlaylist, "")
        '
        'lblMinimizeTitle
        '
        Me.lblMinimizeTitle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeTitle.Location = New System.Drawing.Point(601, 498)
        Me.lblMinimizeTitle.Name = "lblMinimizeTitle"
        Me.lblMinimizeTitle.Size = New System.Drawing.Size(301, 23)
        Me.lblMinimizeTitle.TabIndex = 67
        Me.lblMinimizeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltip.SetToolTip(Me.lblMinimizeTitle, "")
        Me.tooltip.SetToolTipIcon(Me.lblMinimizeTitle, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblMinimizeTitle, "")
        '
        'lblMinimizeAlbum
        '
        Me.lblMinimizeAlbum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeAlbum.Location = New System.Drawing.Point(601, 525)
        Me.lblMinimizeAlbum.Name = "lblMinimizeAlbum"
        Me.lblMinimizeAlbum.Size = New System.Drawing.Size(301, 23)
        Me.lblMinimizeAlbum.TabIndex = 68
        Me.lblMinimizeAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltip.SetToolTip(Me.lblMinimizeAlbum, "")
        Me.tooltip.SetToolTipIcon(Me.lblMinimizeAlbum, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblMinimizeAlbum, "")
        '
        'probarStatus
        '
        Me.probarStatus.BorderColor = System.Drawing.Color.Black
        Me.probarStatus.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.probarStatus.IdleColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.probarStatus.Location = New System.Drawing.Point(590, 561)
        Me.probarStatus.Name = "probarStatus"
        Me.probarStatus.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.probarStatus.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.probarStatus.Size = New System.Drawing.Size(325, 6)
        Me.probarStatus.TabIndex = 69
        Me.tooltip.SetToolTip(Me.probarStatus, "")
        Me.tooltip.SetToolTipIcon(Me.probarStatus, Nothing)
        Me.tooltip.SetToolTipTitle(Me.probarStatus, "")
        '
        'pictureBanner
        '
        Me.pictureBanner.Image = CType(resources.GetObject("pictureBanner.Image"), System.Drawing.Image)
        Me.pictureBanner.Location = New System.Drawing.Point(-4, 460)
        Me.pictureBanner.Name = "pictureBanner"
        Me.pictureBanner.Size = New System.Drawing.Size(570, 114)
        Me.pictureBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBanner.TabIndex = 47
        Me.pictureBanner.TabStop = False
        Me.tooltip.SetToolTip(Me.pictureBanner, "")
        Me.tooltip.SetToolTipIcon(Me.pictureBanner, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pictureBanner, "")
        '
        'btnMiniView
        '
        Me.btnMiniView.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMiniView.Image = Global.Nano.My.Resources.Resources.wminiview
        Me.btnMiniView.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMiniView.Location = New System.Drawing.Point(344, 8)
        Me.btnMiniView.Name = "btnMiniView"
        Me.btnMiniView.OnHoverImage = Global.Nano.My.Resources.Resources.miniview
        Me.btnMiniView.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMiniView.Size = New System.Drawing.Size(30, 30)
        Me.btnMiniView.TabIndex = 61
        Me.btnMiniView.Tag = "max"
        Me.tooltip.SetToolTip(Me.btnMiniView, "Play in Mini View")
        Me.tooltip.SetToolTipIcon(Me.btnMiniView, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnMiniView, "")
        '
        'albumart
        '
        Me.albumart.Image = Global.Nano.My.Resources.Resources.music
        Me.albumart.Location = New System.Drawing.Point(27, 24)
        Me.albumart.Name = "albumart"
        Me.albumart.Size = New System.Drawing.Size(150, 150)
        Me.albumart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.albumart.TabIndex = 24
        Me.albumart.TabStop = False
        Me.tooltip.SetToolTip(Me.albumart, "Maker: Soumen Khara" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version: 2.0.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Website: www.ninjahydra.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-mail: ninjahy" &
        "dra@gmail.com")
        Me.tooltip.SetToolTipIcon(Me.albumart, Nothing)
        Me.tooltip.SetToolTipTitle(Me.albumart, "Nano Music Player" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Timer1
        '
        '
        'notification
        '
        Me.notification.BalloonTipText = "Nano Player"
        Me.notification.BalloonTipTitle = "Player"
        Me.notification.ContextMenuStrip = Me.menustrip
        Me.notification.Icon = CType(resources.GetObject("notification.Icon"), System.Drawing.Icon)
        Me.notification.Text = "Nano Player"
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(564, 570)
        Me.Controls.Add(Me.pictureBanner)
        Me.Controls.Add(Me.scroll)
        Me.Controls.Add(Me.btnMiniView)
        Me.Controls.Add(Me.probarStatus)
        Me.Controls.Add(Me.lblMinimizeAlbum)
        Me.Controls.Add(Me.lblMinimizeTitle)
        Me.Controls.Add(Me.pnlUpperControl)
        Me.Controls.Add(Me.pnlMediaDetails)
        Me.Controls.Add(Me.pnlMediaStatus)
        Me.Controls.Add(Me.pnlMediaControl)
        Me.Controls.Add(Me.pnlMediaManupulation)
        Me.Controls.Add(Me.pnlOuter)
        Me.Controls.Add(Me.fil)
        Me.Controls.Add(Me.albumart)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.player)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOuter.ResumeLayout(False)
        Me.menustrip.ResumeLayout(False)
        Me.pnlMediaManupulation.ResumeLayout(False)
        Me.pnlMediaManupulation.PerformLayout()
        Me.pnlMediaControl.ResumeLayout(False)
        Me.pnlMediaStatus.ResumeLayout(False)
        Me.pnlMediaStatus.PerformLayout()
        Me.pnlMediaDetails.ResumeLayout(False)
        Me.pnlMediaDetails.PerformLayout()
        Me.pnlUpperControl.ResumeLayout(False)
        CType(Me.pictureBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents volTrackBar As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents statusTrackBar As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents albumart As PictureBox
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents timmerStatus As Timer
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents fil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents pnlInner As Panel
    Friend WithEvents pnlOuter As Panel
    Friend WithEvents btnSound As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnFile As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnPrevious As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnPlayPause As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents lblVol As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents tooltip As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents btnEqulizer As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnShuffle As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnRepeat As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnGitHub As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnAbout As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents notification As NotifyIcon
    Friend WithEvents menustrip As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GitHubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPlaylist As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents pictureBanner As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnMiniView As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents pnlMediaStatus As Panel
    Friend WithEvents pnlMediaControl As Panel
    Friend WithEvents pnlMediaManupulation As Panel
    Friend WithEvents probarStatus As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents lblMinimizeAlbum As Label
    Friend WithEvents lblMinimizeTitle As Label
    Friend WithEvents pnlUpperControl As Panel
    Friend WithEvents pnlMediaDetails As Panel
End Class
