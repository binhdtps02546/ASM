<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.loadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.prBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'loadTimer
        '
        Me.loadTimer.Enabled = True
        Me.loadTimer.Interval = 80
        '
        'prBar
        '
        Me.prBar.Location = New System.Drawing.Point(-1, 229)
        Me.prBar.Name = "prBar"
        Me.prBar.Size = New System.Drawing.Size(583, 23)
        Me.prBar.TabIndex = 0
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.binhdtps02546_ASM.My.Resources.Resources.banner_dat_viet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(581, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.prBar)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(597, 266)
        Me.MinimumSize = New System.Drawing.Size(597, 266)
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loadTimer As Timer
    Friend WithEvents prBar As ProgressBar
End Class
