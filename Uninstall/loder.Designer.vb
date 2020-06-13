<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loder
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
        Me.components = New System.ComponentModel.Container()
        Me.animation = New System.Windows.Forms.Timer(Me.components)
        Me.circle = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.SuspendLayout()
        '
        'animation
        '
        '
        'circle
        '
        Me.circle.Animated = True
        Me.circle.AnimationSpeed = 0.5!
        Me.circle.BaseColor = System.Drawing.SystemColors.Control
        Me.circle.IdleColor = System.Drawing.SystemColors.Control
        Me.circle.IdleOffset = 20
        Me.circle.IdleThickness = 0
        Me.circle.Image = Nothing
        Me.circle.ImageSize = New System.Drawing.Size(52, 52)
        Me.circle.Location = New System.Drawing.Point(0, 0)
        Me.circle.Name = "circle"
        Me.circle.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.circle.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.circle.ProgressOffset = 13
        Me.circle.ProgressThickness = 5
        Me.circle.Size = New System.Drawing.Size(77, 77)
        Me.circle.TabIndex = 12
        Me.circle.Value = 50
        '
        'loder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.circle)
        Me.Name = "loder"
        Me.Size = New System.Drawing.Size(77, 77)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents animation As Timer
    Friend WithEvents circle As Guna.UI.WinForms.GunaCircleProgressBar
End Class
