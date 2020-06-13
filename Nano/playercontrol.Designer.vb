<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class playercontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "music"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.Nano.My.Resources.Resources.wm
        Me.GunaButton1.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaButton1.Location = New System.Drawing.Point(0, 0)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.Size = New System.Drawing.Size(420, 34)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "GunaButton1"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.GunaButton1)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(510, 35)
        Me.GunaLinePanel1.TabIndex = 3
        '
        'playercontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "playercontrol"
        Me.Size = New System.Drawing.Size(510, 35)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
End Class
