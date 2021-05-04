<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatterySaver
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BatterySaver))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WhatTimeIsIt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeviceName = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.SmartDeviceName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AlwaysOn = New System.Windows.Forms.CheckBox()
        Me.ConfirmTime = New System.Windows.Forms.Button()
        Me.NextCheck = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LastCheck = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InputMinutes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BatteryLevel = New System.Windows.Forms.TextBox()
        Me.LowLevel = New System.Windows.Forms.TextBox()
        Me.HighLevel = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Charging = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.InitPython = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TurnOn = New System.Windows.Forms.Button()
        Me.TurnOff = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TurnedOnNo = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TurnedOffNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PlugManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PlugManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.WhatTimeIsIt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(640, 176)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'WhatTimeIsIt
        '
        Me.WhatTimeIsIt.BackColor = System.Drawing.Color.Navy
        Me.WhatTimeIsIt.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhatTimeIsIt.ForeColor = System.Drawing.Color.White
        Me.WhatTimeIsIt.Location = New System.Drawing.Point(457, 74)
        Me.WhatTimeIsIt.Margin = New System.Windows.Forms.Padding(4)
        Me.WhatTimeIsIt.Name = "WhatTimeIsIt"
        Me.WhatTimeIsIt.ReadOnly = True
        Me.WhatTimeIsIt.Size = New System.Drawing.Size(175, 61)
        Me.WhatTimeIsIt.TabIndex = 30
        Me.WhatTimeIsIt.Text = "18:58:52"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Font = New System.Drawing.Font("Roboto Cn", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(11, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(407, 72)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Script That Will Check PC Battery Level and Switch On/Off the Charge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Extending " &
    "your PC Battery Life and Planet Energy ..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can input a light instead of a" &
    " plug ...etc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Roboto", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smart Plug Manager"
        '
        'DeviceName
        '
        Me.DeviceName.Location = New System.Drawing.Point(12, 151)
        Me.DeviceName.Margin = New System.Windows.Forms.Padding(4)
        Me.DeviceName.Name = "DeviceName"
        Me.DeviceName.ReadOnly = True
        Me.DeviceName.Size = New System.Drawing.Size(112, 22)
        Me.DeviceName.TabIndex = 27
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.Black
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.OutputTextBox.Location = New System.Drawing.Point(384, 347)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(383, 128)
        Me.OutputTextBox.TabIndex = 18
        '
        'InputTextBox
        '
        Me.InputTextBox.BackColor = System.Drawing.Color.Black
        Me.InputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.InputTextBox.Location = New System.Drawing.Point(384, 476)
        Me.InputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.ReadOnly = True
        Me.InputTextBox.Size = New System.Drawing.Size(383, 22)
        Me.InputTextBox.TabIndex = 1
        Me.InputTextBox.TabStop = False
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(259, 75)
        Me.ExecuteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(103, 69)
        Me.ExecuteButton.TabIndex = 1
        Me.ExecuteButton.Text = "5) Confirm and Start Script"
        Me.ExecuteButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'SmartDeviceName
        '
        Me.SmartDeviceName.Location = New System.Drawing.Point(31, 130)
        Me.SmartDeviceName.Margin = New System.Windows.Forms.Padding(4)
        Me.SmartDeviceName.Name = "SmartDeviceName"
        Me.SmartDeviceName.Size = New System.Drawing.Size(132, 22)
        Me.SmartDeviceName.TabIndex = 0
        Me.SmartDeviceName.Text = "prise pc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Please Input your Plug Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(43, 39)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox2.Controls.Add(Me.AlwaysOn)
        Me.GroupBox2.Controls.Add(Me.ConfirmTime)
        Me.GroupBox2.Controls.Add(Me.NextCheck)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LastCheck)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.InputMinutes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(532, 175)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(235, 164)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "3) Time Configuration"
        '
        'AlwaysOn
        '
        Me.AlwaysOn.AutoSize = True
        Me.AlwaysOn.Location = New System.Drawing.Point(4, 41)
        Me.AlwaysOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AlwaysOn.Name = "AlwaysOn"
        Me.AlwaysOn.Size = New System.Drawing.Size(141, 38)
        Me.AlwaysOn.TabIndex = 18
        Me.AlwaysOn.Text = "Force On" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(For Games ..etc)"
        Me.AlwaysOn.UseVisualStyleBackColor = True
        '
        'ConfirmTime
        '
        Me.ConfirmTime.Location = New System.Drawing.Point(52, 79)
        Me.ConfirmTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConfirmTime.Name = "ConfirmTime"
        Me.ConfirmTime.Size = New System.Drawing.Size(133, 32)
        Me.ConfirmTime.TabIndex = 37
        Me.ConfirmTime.Text = "Confirm Above"
        Me.ConfirmTime.UseVisualStyleBackColor = True
        '
        'NextCheck
        '
        Me.NextCheck.Location = New System.Drawing.Point(153, 134)
        Me.NextCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.NextCheck.Name = "NextCheck"
        Me.NextCheck.ReadOnly = True
        Me.NextCheck.Size = New System.Drawing.Size(75, 22)
        Me.NextCheck.TabIndex = 29
        Me.NextCheck.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(144, 113)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Next Check :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 112)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Last Check :"
        '
        'LastCheck
        '
        Me.LastCheck.Location = New System.Drawing.Point(12, 133)
        Me.LastCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.LastCheck.Name = "LastCheck"
        Me.LastCheck.ReadOnly = True
        Me.LastCheck.Size = New System.Drawing.Size(75, 22)
        Me.LastCheck.TabIndex = 26
        Me.LastCheck.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "hh:mm:ss"
        '
        'InputMinutes
        '
        Me.InputMinutes.Location = New System.Drawing.Point(148, 39)
        Me.InputMinutes.Margin = New System.Windows.Forms.Padding(4)
        Me.InputMinutes.Name = "InputMinutes"
        Me.InputMinutes.Size = New System.Drawing.Size(79, 22)
        Me.InputMinutes.TabIndex = 0
        Me.InputMinutes.Text = "00:05:00"
        Me.InputMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Time-Checking Interval"
        '
        'BatteryLevel
        '
        Me.BatteryLevel.Location = New System.Drawing.Point(104, 46)
        Me.BatteryLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.BatteryLevel.Name = "BatteryLevel"
        Me.BatteryLevel.ReadOnly = True
        Me.BatteryLevel.Size = New System.Drawing.Size(81, 22)
        Me.BatteryLevel.TabIndex = 1
        Me.BatteryLevel.TabStop = False
        Me.BatteryLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LowLevel
        '
        Me.LowLevel.Location = New System.Drawing.Point(31, 135)
        Me.LowLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.LowLevel.Name = "LowLevel"
        Me.LowLevel.Size = New System.Drawing.Size(33, 22)
        Me.LowLevel.TabIndex = 0
        Me.LowLevel.Text = "10"
        Me.LowLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HighLevel
        '
        Me.HighLevel.Location = New System.Drawing.Point(181, 135)
        Me.HighLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.HighLevel.Name = "HighLevel"
        Me.HighLevel.Size = New System.Drawing.Size(33, 22)
        Me.HighLevel.TabIndex = 1
        Me.HighLevel.Text = "100"
        Me.HighLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PC Battery :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.HighLevel)
        Me.GroupBox3.Controls.Add(Me.LowLevel)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Charging)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.BatteryLevel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(219, 175)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(305, 164)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2) Battery Config"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 78)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(291, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Please Set-Up Your Lower and Upper values"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(12, 139)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "at ____ it'll Switch On"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(163, 139)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "at ____ it'll Switch Off"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Gray
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox3.Location = New System.Drawing.Point(223, 107)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(52, 22)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(11, 107)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(68, 22)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TabStop = False
        '
        'Charging
        '
        Me.Charging.ForeColor = System.Drawing.SystemColors.Window
        Me.Charging.Location = New System.Drawing.Point(104, 16)
        Me.Charging.Margin = New System.Windows.Forms.Padding(4)
        Me.Charging.Name = "Charging"
        Me.Charging.ReadOnly = True
        Me.Charging.Size = New System.Drawing.Size(81, 22)
        Me.Charging.TabIndex = 11
        Me.Charging.TabStop = False
        Me.Charging.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Plug Status :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox2.Location = New System.Drawing.Point(77, 107)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 22)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.TabStop = False
        '
        'Timer1
        '
        '
        'InitPython
        '
        Me.InitPython.Location = New System.Drawing.Point(636, 438)
        Me.InitPython.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InitPython.Name = "InitPython"
        Me.InitPython.Size = New System.Drawing.Size(19, 22)
        Me.InitPython.TabIndex = 27
        Me.InitPython.Text = "0"
        Me.InitPython.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "4) Init Python"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 134)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Virtual Device Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox4.Controls.Add(Me.SmartDeviceName)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(200, 164)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "1) Device Setup"
        '
        'TurnOn
        '
        Me.TurnOn.Image = CType(resources.GetObject("TurnOn.Image"), System.Drawing.Image)
        Me.TurnOn.Location = New System.Drawing.Point(188, 47)
        Me.TurnOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TurnOn.Name = "TurnOn"
        Me.TurnOn.Size = New System.Drawing.Size(61, 34)
        Me.TurnOn.TabIndex = 2
        Me.TurnOn.UseVisualStyleBackColor = True
        '
        'TurnOff
        '
        Me.TurnOff.Image = CType(resources.GetObject("TurnOff.Image"), System.Drawing.Image)
        Me.TurnOff.Location = New System.Drawing.Point(188, 98)
        Me.TurnOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TurnOff.Name = "TurnOff"
        Me.TurnOff.Size = New System.Drawing.Size(61, 34)
        Me.TurnOff.TabIndex = 3
        Me.TurnOff.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox5.Controls.Add(Me.TurnedOnNo)
        Me.GroupBox5.Controls.Add(Me.RichTextBox1)
        Me.GroupBox5.Controls.Add(Me.TurnedOffNo)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.TurnOff)
        Me.GroupBox5.Controls.Add(Me.TurnOn)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.ExecuteButton)
        Me.GroupBox5.Controls.Add(Me.RichTextBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 345)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(363, 153)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Direct Command"
        '
        'TurnedOnNo
        '
        Me.TurnedOnNo.BackColor = System.Drawing.Color.Bisque
        Me.TurnedOnNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TurnedOnNo.Location = New System.Drawing.Point(5, 59)
        Me.TurnedOnNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TurnedOnNo.Name = "TurnedOnNo"
        Me.TurnedOnNo.ReadOnly = True
        Me.TurnedOnNo.Size = New System.Drawing.Size(47, 22)
        Me.TurnedOnNo.TabIndex = 33
        Me.TurnedOnNo.TabStop = False
        Me.TurnedOnNo.Text = "0"
        Me.TurnedOnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Bisque
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 39)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(183, 47)
        Me.RichTextBox1.TabIndex = 33
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = "The Script Turned ON :" & Global.Microsoft.VisualBasic.ChrW(10) & "_______ times the Plug"
        '
        'TurnedOffNo
        '
        Me.TurnedOffNo.BackColor = System.Drawing.Color.Bisque
        Me.TurnedOffNo.Location = New System.Drawing.Point(5, 111)
        Me.TurnedOffNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TurnedOffNo.Name = "TurnedOffNo"
        Me.TurnedOffNo.ReadOnly = True
        Me.TurnedOffNo.Size = New System.Drawing.Size(47, 22)
        Me.TurnedOffNo.TabIndex = 35
        Me.TurnedOffNo.TabStop = False
        Me.TurnedOffNo.Text = "0"
        Me.TurnedOffNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1, 18)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 17)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Force On/Off"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Bisque
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 94)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(183, 47)
        Me.RichTextBox2.TabIndex = 36
        Me.RichTextBox2.TabStop = False
        Me.RichTextBox2.Text = "The Script Turned OFF :" & Global.Microsoft.VisualBasic.ChrW(10) & "_______ times the Plug"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(443, 420)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 4
        '
        'Timer3
        '
        '
        'PlugManagerBindingSource
        '
        Me.PlugManagerBindingSource.DataSource = GetType(GoogleHomeWindows.BatterySaver)
        '
        'BatterySaver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 505)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DeviceName)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.InitPython)
        Me.Controls.Add(Me.TextBox4)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(854, 552)
        Me.MinimumSize = New System.Drawing.Size(798, 552)
        Me.Name = "BatterySaver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battery Saver"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PlugManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents ExecuteButton As Button
    Friend WithEvents SmartDeviceName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents HighLevel As TextBox
    Friend WithEvents LowLevel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents InputMinutes As TextBox
    Friend WithEvents BatteryLevel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LastCheck As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NextCheck As TextBox
    Friend WithEvents Charging As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DeviceName As TextBox
    Friend WithEvents InitPython As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents PlugManagerBindingSource As BindingSource
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TurnOn As Button
    Friend WithEvents TurnOff As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TurnedOffNo As TextBox
    Friend WithEvents TurnedOnNo As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ConfirmTime As Button
    Friend WithEvents WhatTimeIsIt As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents AlwaysOn As CheckBox
End Class
