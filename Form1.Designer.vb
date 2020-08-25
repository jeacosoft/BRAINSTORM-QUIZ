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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaButtonRESUME = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonPAUSE = New Guna.UI.WinForms.GunaButton()
        Me.Labelsub = New System.Windows.Forms.Label()
        Me.GunaRadioButtonD = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaRadioButtonC = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaRadioButtonB = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaRadioButtonA = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaTextBoxQTNDIP = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaTextBoxQST = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBoxSCO = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeleftlabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Silver
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.MinExtra = 50
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(203, 524)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "QUESTION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.GunaButtonPAUSE)
        Me.Panel1.Controls.Add(Me.Labelsub)
        Me.Panel1.Controls.Add(Me.GunaRadioButtonD)
        Me.Panel1.Controls.Add(Me.GunaRadioButtonC)
        Me.Panel1.Controls.Add(Me.GunaRadioButtonB)
        Me.Panel1.Controls.Add(Me.GunaRadioButtonA)
        Me.Panel1.Controls.Add(Me.GunaTextBoxQTNDIP)
        Me.Panel1.Controls.Add(Me.GunaButtonRESUME)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(203, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 524)
        Me.Panel1.TabIndex = 13
        '
        'GunaButtonRESUME
        '
        Me.GunaButtonRESUME.AnimationHoverSpeed = 0.07!
        Me.GunaButtonRESUME.AnimationSpeed = 0.03!
        Me.GunaButtonRESUME.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonRESUME.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButtonRESUME.BorderColor = System.Drawing.Color.White
        Me.GunaButtonRESUME.BorderSize = 3
        Me.GunaButtonRESUME.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GunaButtonRESUME.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButtonRESUME.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonRESUME.ForeColor = System.Drawing.Color.White
        Me.GunaButtonRESUME.Image = Nothing
        Me.GunaButtonRESUME.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonRESUME.Location = New System.Drawing.Point(227, 440)
        Me.GunaButtonRESUME.Name = "GunaButtonRESUME"
        Me.GunaButtonRESUME.OnHoverBaseColor = System.Drawing.Color.Olive
        Me.GunaButtonRESUME.OnHoverBorderColor = System.Drawing.Color.DimGray
        Me.GunaButtonRESUME.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonRESUME.OnHoverImage = Nothing
        Me.GunaButtonRESUME.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonRESUME.Radius = 20
        Me.GunaButtonRESUME.Size = New System.Drawing.Size(124, 53)
        Me.GunaButtonRESUME.TabIndex = 23
        Me.GunaButtonRESUME.Text = "RESUME"
        Me.GunaButtonRESUME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButtonPAUSE
        '
        Me.GunaButtonPAUSE.AnimationHoverSpeed = 0.07!
        Me.GunaButtonPAUSE.AnimationSpeed = 0.03!
        Me.GunaButtonPAUSE.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonPAUSE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButtonPAUSE.BorderColor = System.Drawing.Color.White
        Me.GunaButtonPAUSE.BorderSize = 3
        Me.GunaButtonPAUSE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonPAUSE.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonPAUSE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonPAUSE.ForeColor = System.Drawing.Color.White
        Me.GunaButtonPAUSE.Image = Nothing
        Me.GunaButtonPAUSE.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonPAUSE.Location = New System.Drawing.Point(227, 440)
        Me.GunaButtonPAUSE.Name = "GunaButtonPAUSE"
        Me.GunaButtonPAUSE.OnHoverBaseColor = System.Drawing.Color.Olive
        Me.GunaButtonPAUSE.OnHoverBorderColor = System.Drawing.Color.DimGray
        Me.GunaButtonPAUSE.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonPAUSE.OnHoverImage = Nothing
        Me.GunaButtonPAUSE.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonPAUSE.Radius = 20
        Me.GunaButtonPAUSE.Size = New System.Drawing.Size(124, 53)
        Me.GunaButtonPAUSE.TabIndex = 19
        Me.GunaButtonPAUSE.Text = "PAUSE"
        Me.GunaButtonPAUSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Labelsub
        '
        Me.Labelsub.AutoSize = True
        Me.Labelsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelsub.Location = New System.Drawing.Point(174, 8)
        Me.Labelsub.Name = "Labelsub"
        Me.Labelsub.Size = New System.Drawing.Size(0, 20)
        Me.Labelsub.TabIndex = 18
        '
        'GunaRadioButtonD
        '
        Me.GunaRadioButtonD.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButtonD.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButtonD.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButtonD.FillColor = System.Drawing.Color.White
        Me.GunaRadioButtonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaRadioButtonD.Location = New System.Drawing.Point(131, 344)
        Me.GunaRadioButtonD.Name = "GunaRadioButtonD"
        Me.GunaRadioButtonD.Size = New System.Drawing.Size(20, 20)
        Me.GunaRadioButtonD.TabIndex = 17
        '
        'GunaRadioButtonC
        '
        Me.GunaRadioButtonC.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButtonC.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButtonC.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButtonC.FillColor = System.Drawing.Color.White
        Me.GunaRadioButtonC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaRadioButtonC.Location = New System.Drawing.Point(131, 288)
        Me.GunaRadioButtonC.Name = "GunaRadioButtonC"
        Me.GunaRadioButtonC.Size = New System.Drawing.Size(20, 20)
        Me.GunaRadioButtonC.TabIndex = 16
        '
        'GunaRadioButtonB
        '
        Me.GunaRadioButtonB.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButtonB.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButtonB.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButtonB.FillColor = System.Drawing.Color.White
        Me.GunaRadioButtonB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaRadioButtonB.Location = New System.Drawing.Point(131, 237)
        Me.GunaRadioButtonB.Name = "GunaRadioButtonB"
        Me.GunaRadioButtonB.Size = New System.Drawing.Size(20, 20)
        Me.GunaRadioButtonB.TabIndex = 15
        '
        'GunaRadioButtonA
        '
        Me.GunaRadioButtonA.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButtonA.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButtonA.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButtonA.FillColor = System.Drawing.Color.White
        Me.GunaRadioButtonA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaRadioButtonA.Location = New System.Drawing.Point(131, 187)
        Me.GunaRadioButtonA.Name = "GunaRadioButtonA"
        Me.GunaRadioButtonA.Size = New System.Drawing.Size(20, 20)
        Me.GunaRadioButtonA.TabIndex = 14
        '
        'GunaTextBoxQTNDIP
        '
        Me.GunaTextBoxQTNDIP.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBoxQTNDIP.BaseColor = System.Drawing.Color.White
        Me.GunaTextBoxQTNDIP.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBoxQTNDIP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBoxQTNDIP.Enabled = False
        Me.GunaTextBoxQTNDIP.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBoxQTNDIP.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBoxQTNDIP.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBoxQTNDIP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBoxQTNDIP.Location = New System.Drawing.Point(6, 41)
        Me.GunaTextBoxQTNDIP.Name = "GunaTextBoxQTNDIP"
        Me.GunaTextBoxQTNDIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBoxQTNDIP.Radius = 10
        Me.GunaTextBoxQTNDIP.Size = New System.Drawing.Size(668, 105)
        Me.GunaTextBoxQTNDIP.TabIndex = 1
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.White
        Me.GunaButton3.BorderSize = 3
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(12, 290)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.Olive
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.DimGray
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 20
        Me.GunaButton3.Size = New System.Drawing.Size(178, 53)
        Me.GunaButton3.TabIndex = 21
        Me.GunaButton3.Text = "RESTART"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.Maroon
        Me.GunaButton2.BorderColor = System.Drawing.Color.White
        Me.GunaButton2.BorderSize = 3
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(12, 363)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.Olive
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.DimGray
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 20
        Me.GunaButton2.Size = New System.Drawing.Size(178, 53)
        Me.GunaButton2.TabIndex = 20
        Me.GunaButton2.Text = "EXIT"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBoxQST
        '
        Me.GunaTextBoxQST.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBoxQST.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaTextBoxQST.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBoxQST.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBoxQST.Enabled = False
        Me.GunaTextBoxQST.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBoxQST.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBoxQST.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBoxQST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBoxQST.Location = New System.Drawing.Point(48, 66)
        Me.GunaTextBoxQST.Name = "GunaTextBoxQST"
        Me.GunaTextBoxQST.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBoxQST.Radius = 10
        Me.GunaTextBoxQST.Size = New System.Drawing.Size(106, 44)
        Me.GunaTextBoxQST.TabIndex = 14
        '
        'GunaTextBoxSCO
        '
        Me.GunaTextBoxSCO.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBoxSCO.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaTextBoxSCO.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBoxSCO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBoxSCO.Enabled = False
        Me.GunaTextBoxSCO.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBoxSCO.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBoxSCO.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBoxSCO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBoxSCO.Location = New System.Drawing.Point(41, 155)
        Me.GunaTextBoxSCO.Name = "GunaTextBoxSCO"
        Me.GunaTextBoxSCO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBoxSCO.Radius = 10
        Me.GunaTextBoxSCO.Size = New System.Drawing.Size(110, 39)
        Me.GunaTextBoxSCO.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "SCORE"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'timeleftlabel
        '
        Me.timeleftlabel.AutoSize = True
        Me.timeleftlabel.BackColor = System.Drawing.Color.Black
        Me.timeleftlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.timeleftlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.timeleftlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeleftlabel.ForeColor = System.Drawing.Color.White
        Me.timeleftlabel.Location = New System.Drawing.Point(102, 6)
        Me.timeleftlabel.Name = "timeleftlabel"
        Me.timeleftlabel.Size = New System.Drawing.Size(2, 27)
        Me.timeleftlabel.TabIndex = 18
        Me.timeleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Time Left"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(169, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Sec"
        Me.Label4.Visible = False
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.White
        Me.GunaButton4.BorderSize = 3
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(12, 220)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.Olive
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.DimGray
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 20
        Me.GunaButton4.Size = New System.Drawing.Size(178, 53)
        Me.GunaButton4.TabIndex = 22
        Me.GunaButton4.Text = "START"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.Teal
        Me.GunaButton5.BorderColor = System.Drawing.Color.White
        Me.GunaButton5.BorderSize = 3
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton5.ForeColor = System.Drawing.Color.White
        Me.GunaButton5.Image = Nothing
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(12, 440)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.Olive
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.DimGray
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Radius = 20
        Me.GunaButton5.Size = New System.Drawing.Size(178, 53)
        Me.GunaButton5.TabIndex = 25
        Me.GunaButton5.Text = "HELP"
        Me.GunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 524)
        Me.Controls.Add(Me.GunaButton5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.timeleftlabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaTextBoxSCO)
        Me.Controls.Add(Me.GunaTextBoxQST)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(911, 563)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BRAINSTORMER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaTextBoxQST As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBoxSCO As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaRadioButtonD As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaRadioButtonC As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaRadioButtonB As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaRadioButtonA As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeleftlabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GunaTextBoxQTNDIP As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Labelsub As Label
    Friend WithEvents GunaButtonPAUSE As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonRESUME As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
End Class
