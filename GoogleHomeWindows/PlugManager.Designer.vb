<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlugManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlugManager))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeviceName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.SmartDeviceName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Charging = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.InitPython = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.DeviceName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(607, 113)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'DeviceName
        '
        Me.DeviceName.Location = New System.Drawing.Point(468, 85)
        Me.DeviceName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeviceName.Name = "DeviceName"
        Me.DeviceName.ReadOnly = True
        Me.DeviceName.Size = New System.Drawing.Size(132, 22)
        Me.DeviceName.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Font = New System.Drawing.Font("Roboto Cn", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(9, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(407, 36)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Script That Will Check PC Battery Level and Switch On/Off the Charge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Extending " &
    "your PC Battery Life and Planet Energy ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Roboto", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smart Plug Manager"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.Black
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.OutputTextBox.Location = New System.Drawing.Point(401, 140)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(391, 267)
        Me.OutputTextBox.TabIndex = 18
        '
        'InputTextBox
        '
        Me.InputTextBox.BackColor = System.Drawing.Color.Black
        Me.InputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.InputTextBox.Location = New System.Drawing.Point(401, 420)
        Me.InputTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(361, 22)
        Me.InputTextBox.TabIndex = 1
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(289, 178)
        Me.ExecuteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(83, 64)
        Me.ExecuteButton.TabIndex = 20
        Me.ExecuteButton.Text = "Confirm Options"
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'SmartDeviceName
        '
        Me.SmartDeviceName.Location = New System.Drawing.Point(96, 245)
        Me.SmartDeviceName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SmartDeviceName.Name = "SmartDeviceName"
        Me.SmartDeviceName.Size = New System.Drawing.Size(132, 22)
        Me.SmartDeviceName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "What the name of your Smart Plug on Google ?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(68, 127)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(184, 162)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "You can edit the name on your phone"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox2.Controls.Add(Me.NextCheck)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LastCheck)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.InputMinutes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 297)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(183, 151)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Configuration"
        '
        'NextCheck
        '
        Me.NextCheck.Location = New System.Drawing.Point(100, 106)
        Me.NextCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NextCheck.Name = "NextCheck"
        Me.NextCheck.ReadOnly = True
        Me.NextCheck.Size = New System.Drawing.Size(75, 22)
        Me.NextCheck.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Next Check :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Last Check :"
        '
        'LastCheck
        '
        Me.LastCheck.Location = New System.Drawing.Point(100, 79)
        Me.LastCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LastCheck.Name = "LastCheck"
        Me.LastCheck.ReadOnly = True
        Me.LastCheck.Size = New System.Drawing.Size(75, 22)
        Me.LastCheck.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "hh:mm:ss"
        '
        'InputMinutes
        '
        Me.InputMinutes.Location = New System.Drawing.Point(12, 47)
        Me.InputMinutes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InputMinutes.Name = "InputMinutes"
        Me.InputMinutes.Size = New System.Drawing.Size(79, 22)
        Me.InputMinutes.TabIndex = 2
        Me.InputMinutes.Text = "00:10:00"
        Me.InputMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Launch the Script every :"
        '
        'BatteryLevel
        '
        Me.BatteryLevel.Location = New System.Drawing.Point(104, 44)
        Me.BatteryLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BatteryLevel.Name = "BatteryLevel"
        Me.BatteryLevel.ReadOnly = True
        Me.BatteryLevel.Size = New System.Drawing.Size(81, 22)
        Me.BatteryLevel.TabIndex = 1
        Me.BatteryLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LowLevel
        '
        Me.LowLevel.Location = New System.Drawing.Point(63, 98)
        Me.LowLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LowLevel.Name = "LowLevel"
        Me.LowLevel.Size = New System.Drawing.Size(33, 22)
        Me.LowLevel.TabIndex = 3
        Me.LowLevel.Text = "20"
        Me.LowLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HighLevel
        '
        Me.HighLevel.Location = New System.Drawing.Point(109, 98)
        Me.HighLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HighLevel.Name = "HighLevel"
        Me.HighLevel.Size = New System.Drawing.Size(33, 22)
        Me.HighLevel.TabIndex = 4
        Me.HighLevel.Text = "80"
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
        Me.Label7.Location = New System.Drawing.Point(19, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PC Battery :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox3.Controls.Add(Me.HighLevel)
        Me.GroupBox3.Controls.Add(Me.LowLevel)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Charging)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.BatteryLevel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(187, 297)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(195, 151)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Battery Config"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(8, 126)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Switch On"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(119, 128)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Switch Off"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Gray
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox3.Location = New System.Drawing.Point(124, 69)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(65, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox2.Location = New System.Drawing.Point(77, 69)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(47, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(11, 69)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(67, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Charging
        '
        Me.Charging.Location = New System.Drawing.Point(104, 17)
        Me.Charging.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Charging.Name = "Charging"
        Me.Charging.ReadOnly = True
        Me.Charging.Size = New System.Drawing.Size(81, 22)
        Me.Charging.TabIndex = 11
        Me.Charging.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 17)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Plug Status :"
        '
        'Timer1
        '
        '
        'InitPython
        '
        Me.InitPython.Location = New System.Drawing.Point(771, 422)
        Me.InitPython.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InitPython.Name = "InitPython"
        Me.InitPython.Size = New System.Drawing.Size(19, 22)
        Me.InitPython.TabIndex = 27
        Me.InitPython.Text = "0"
        Me.InitPython.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlugManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InitPython)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SmartDeviceName)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PlugManager"
        Me.Text = "PlugManager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents Label3 As Label
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
End Class
