<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSCREEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSCREEN))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BRAINSTORMER.My.Resources.Resources.QUIZ21
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 442)
        Me.Panel1.TabIndex = 0
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(338, 159)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.White
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(60, 50)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 0
        '
        'FSCREEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 442)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(762, 481)
        Me.Name = "FSCREEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUESTION2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
End Class
