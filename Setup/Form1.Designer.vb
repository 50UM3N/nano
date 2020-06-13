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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation2 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgDetails = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkboxStart = New System.Windows.Forms.CheckBox()
        Me.chkboxDesktop = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.dgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.BunifuPages1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDetails
        '
        Me.dgDetails.AllowUserToAddRows = False
        Me.dgDetails.AllowUserToDeleteRows = False
        Me.dgDetails.AllowUserToResizeColumns = False
        Me.dgDetails.AllowUserToResizeRows = False
        Me.dgDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetails.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgDetails.ColumnHeadersVisible = False
        Me.dgDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDetails.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgDetails.GridColor = System.Drawing.SystemColors.Control
        Me.dgDetails.Location = New System.Drawing.Point(6, 87)
        Me.dgDetails.Name = "dgDetails"
        Me.dgDetails.ReadOnly = True
        Me.dgDetails.RowHeadersVisible = False
        Me.dgDetails.RowHeadersWidth = 100
        Me.dgDetails.Size = New System.Drawing.Size(477, 124)
        Me.dgDetails.TabIndex = 28
        Me.dgDetails.Tag = "0"
        Me.dgDetails.Visible = False
        '
        'Column1
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 27
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(6, 64)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(477, 17)
        Me.ProgressBar2.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 19)
        Me.Label3.TabIndex = 23
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Setup.My.Resources.Resources.small
        Me.PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Blogger Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 44)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nano Music Player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nano is a simple music player for windows developed by Soumen Khara." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(490, 217)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Folder"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(418, 28)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "To install on this forlder, click ""Next"". To install to a different folder enter " &
    "it " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "billow and, click ""Browse"""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(289, 14)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "The application will install on  the following Folder"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(417, 89)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(56, 20)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtDestination
        '
        Me.txtDestination.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(14, 89)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(397, 22)
        Me.txtDestination.TabIndex = 0
        Me.txtDestination.Text = "C:\Program Files"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnBrowse)
        Me.TabPage2.Controls.Add(Me.txtDestination)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(490, 217)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 14)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Click ""Next"" To start the installation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Installer Is redy to install Nano Player."
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(490, 217)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'btnDetails
        '
        Me.btnDetails.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.Location = New System.Drawing.Point(394, 40)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(89, 20)
        Me.btnDetails.TabIndex = 7
        Me.btnDetails.Tag = "0"
        Me.btnDetails.Text = "Show Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(276, 14)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Please wait while Nano Player is being installed."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Installing"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.ProgressBar2)
        Me.TabPage4.Controls.Add(Me.dgDetails)
        Me.TabPage4.Controls.Add(Me.btnDetails)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(490, 217)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 14)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Add Shortcut Link"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 14)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Finishing Installation"
        '
        'chkboxStart
        '
        Me.chkboxStart.AutoSize = True
        Me.chkboxStart.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxStart.Location = New System.Drawing.Point(34, 84)
        Me.chkboxStart.Name = "chkboxStart"
        Me.chkboxStart.Size = New System.Drawing.Size(51, 18)
        Me.chkboxStart.TabIndex = 5
        Me.chkboxStart.Text = "Start"
        Me.chkboxStart.UseVisualStyleBackColor = True
        '
        'chkboxDesktop
        '
        Me.chkboxDesktop.AutoSize = True
        Me.chkboxDesktop.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxDesktop.Location = New System.Drawing.Point(34, 61)
        Me.chkboxDesktop.Name = "chkboxDesktop"
        Me.chkboxDesktop.Size = New System.Drawing.Size(71, 18)
        Me.chkboxDesktop.TabIndex = 4
        Me.chkboxDesktop.Text = "Desktop"
        Me.chkboxDesktop.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.chkboxStart)
        Me.TabPage5.Controls.Add(Me.chkboxDesktop)
        Me.TabPage5.Location = New System.Drawing.Point(4, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(490, 217)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.AllowTransitions = False
        Me.BunifuPages1.Controls.Add(Me.TabPage1)
        Me.BunifuPages1.Controls.Add(Me.TabPage2)
        Me.BunifuPages1.Controls.Add(Me.TabPage3)
        Me.BunifuPages1.Controls.Add(Me.TabPage4)
        Me.BunifuPages1.Controls.Add(Me.TabPage5)
        Me.BunifuPages1.Location = New System.Drawing.Point(9, 78)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.Page = Me.TabPage1
        Me.BunifuPages1.PageIndex = 0
        Me.BunifuPages1.PageName = "TabPage1"
        Me.BunifuPages1.PageTitle = "TabPage1"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(498, 243)
        Me.BunifuPages1.TabIndex = 3
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BunifuPages1.Transition = Animation2
        Me.BunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.HorizBlind
        '
        'btnBack
        '
        Me.btnBack.Enabled = False
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(338, 306)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(418, 306)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(412, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 8
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(463, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 9
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(23, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "E-mail: ninjahydra@gmail.com"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(23, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 16)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Made BY: @50UM3N"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(23, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "<> with ❤ by GitHub"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(23, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(163, 16)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Open Source Software Licence"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(23, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 16)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Version: 2.0.1 x64"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(23, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "E-mail: www.ninjahydra.com"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(23, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(390, 16)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Tester : Snehasish Moldal (For any kind of proble contact with snehashsh)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 341)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuPages1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.BunifuPages1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgDetails As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnDetails As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents chkboxStart As CheckBox
    Friend WithEvents chkboxDesktop As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
