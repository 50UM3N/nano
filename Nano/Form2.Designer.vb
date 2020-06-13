<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.PictureBox1)
        Me.GunaLinePanel1.Controls.Add(Me.Label4)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.Controls.Add(Me.Label7)
        Me.GunaLinePanel1.Controls.Add(Me.Label6)
        Me.GunaLinePanel1.Controls.Add(Me.Label3)
        Me.GunaLinePanel1.Controls.Add(Me.Label2)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaLinePanel1.LineLeft = 1
        Me.GunaLinePanel1.LineRight = 1
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.LineTop = 1
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(418, 184)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nano.My.Resources.Resources.small
        Me.PictureBox1.Location = New System.Drawing.Point(20, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(126, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "E-mail: ninjahydra@gmail.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Blogger Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nano Music Player"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(151, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Made BY: @50UM3N"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(148, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "<> with ❤ by GitHub"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(127, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Open Source Software Licence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Blogger Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(156, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Version: 2.0.1 x64"
        '
        'Timer1
        '
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaLinePanel1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 184)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class
