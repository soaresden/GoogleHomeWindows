Public Class BatterySaver
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub InputMinutes_TextChanged(sender As Object, e As EventArgs) Handles InputMinutes.TextChanged
        On Error Resume Next
        'Configuring Time
        Dim thismoment As TimeSpan = TimeSpan.Parse(Format(Now, "HH:mm:ss"))
        Dim nextmoment As TimeSpan = TimeSpan.Parse(InputMinutes.Text).Add(thismoment)

        LastCheck.Text = thismoment.ToString
        NextCheck.Text = nextmoment.ToString
        On Error GoTo 0



    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click
        'If first run then exit this sub
        If InitPython.Text = 0 Then
            GoTo Fin
        End If

        'Check if smartdevicename is empty
        If SmartDeviceName.Text = "" Then
            MsgBox("Please Input your Device Name")
            Exit Sub
        End If

        'Check if AlwaysOn is checked
        If AlwaysOn.Checked = True Then
            TurnOn.PerformClick()
            GoTo sautecondition
        End If

        'Conditionnally chosing what to do 
        If Val(BatteryLevel.Text) <= Val(LowLevel.Text) Then
            InputTextBox.Text = "switch on " & SmartDeviceName.Text
            MyProcess.StandardInput.WriteLine(InputTextBox.Text)
            MyProcess.StandardInput.Flush()
            InputTextBox.Text = ""

            'incrementing
            TurnedOnNo.Text = Val(TurnedOnNo.Text) + 1

        ElseIf Val(BatteryLevel.Text) >= Val(HighLevel.Text) Then
            InputTextBox.Text = "switch off " & SmartDeviceName.Text
            MyProcess.StandardInput.WriteLine(InputTextBox.Text)
            MyProcess.StandardInput.Flush()
            InputTextBox.Text = ""

            'incrementing
            TurnedOffNo.Text = Val(TurnedOffNo.Text) + 1
        Else
            'nothing to do because it's between [low level;HighLevel] = Discharging or Charging Action
        End If

sautecondition:
        'Configuring timer1 : Timer for Google Command
        Dim thismoment As TimeSpan = TimeSpan.Parse(Format(Now, "HH:mm:ss"))
        Dim nextmoment As TimeSpan = TimeSpan.Parse(InputMinutes.Text).Add(thismoment)

        LastCheck.Text = thismoment.ToString
        NextCheck.Text = nextmoment.ToString

        'Activating the timer and process again
        Dim tempsenminutes As TimeSpan = TimeSpan.Parse(InputMinutes.Text)
        Dim tempsenmilli As Double = tempsenminutes.TotalMilliseconds

        Timer1.Interval = tempsenmilli
        Timer1.Enabled = True


        'Configuring Timer2 :Charging Status and Battery Level
        Timer2.Interval = "5000"
        Timer2.Enabled = True
Fin:

    End Sub

    Private Sub PlugManager_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Get PC Battery and Plug Status
        Dim powerstatus As PowerStatus = SystemInformation.PowerStatus
        Dim plugged As String = powerstatus.PowerLineStatus
        Dim percent As Single = SystemInformation.PowerStatus.BatteryLifePercent
        Dim pourcentagebatterie As Integer = percent * 100
        Dim statuschargeur As String
        If plugged = 1 Then
            statuschargeur = "Charging"
            Charging.BackColor = Color.FromArgb(0, 176, 80)
        Else
            statuschargeur = "Discharging"
            Charging.BackColor = Color.FromArgb(192, 0, 0)
        End If

        Charging.Text = statuschargeur
        BatteryLevel.Text = pourcentagebatterie

        'Configuring Time
        Dim thismoment As TimeSpan = TimeSpan.Parse(Format(Now, "HH:mm:ss"))
        Dim nextmoment As TimeSpan = TimeSpan.Parse(InputMinutes.Text).Add(thismoment)

        LastCheck.Text = thismoment.ToString
        NextCheck.Text = nextmoment.ToString

        'disabling for secure reason the time
        Timer1.Enabled = False

        'Enable the clock
        Timer3.Enabled = True

        'Set Focus on Smart Device Name
        SmartDeviceName.Focus()

    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub CMDForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True

            'Calculate next time check 
            Dim remaining As TimeSpan = TimeSpan.Parse(NextCheck.Text).Subtract(TimeSpan.Parse(Format(Now, "HH:mm:ss")))
            Dim nexttime As String = "GHome-PlugManager " & Chr(10) & "Next Check in " & remaining.ToString

            NotifyIcon1.Text = nexttime
            NotifyIcon1.Icon = My.Resources.logo_notif
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "GHome-PlugManager"
            NotifyIcon1.BalloonTipText = "Continue Running in TrayIcon"
            NotifyIcon1.ShowBalloonTip(30000)

            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub


    Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ExecuteButton.PerformClick()
    End Sub


    Private Sub PlugManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Settings.DeviceName IsNot Nothing Then DeviceName.Text = My.Settings.DeviceName

        'Hide the Buttons for security reasons
        TurnOn.Visible = False
        TurnOff.Visible = False
        Label15.Visible = False
        ConfirmTime.Visible = False

        'CMD
        Me.AcceptButton = ExecuteButton
        MyProcess = New Process
        With MyProcess.StartInfo
            .FileName = "CMD.EXE"
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        MyProcess.Start()

        MyProcess.BeginErrorReadLine()
        MyProcess.BeginOutputReadLine()
        AppendOutputText("Process Started at: " & MyProcess.StartTime.ToString)
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Secure disable the time 
        Timer1.Enabled = False

        'Send an EXIT command to the Command Prompt
        MyProcess.StandardInput.WriteLine("exit") 'send an EXIT command to the Command Prompt
        MyProcess.StandardInput.Flush()
        MyProcess.Kill()
        MyProcess.Close()
    End Sub
    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & "Error: " & e.Data)
    End Sub
    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub
    Private Sub AppendOutputText(ByVal text As String)
        On Error Resume Next
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            OutputTextBox.AppendText(text)
        End If
        On Error GoTo 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Check if smartdevicename is empty
        If SmartDeviceName.Text = "" Then
            MsgBox("Please Input your Device Name")
            DeviceName.Focus()
            Exit Sub
        End If

        'Increment the value
        InitPython.Text = Val(InitPython.Text) + 1

        'Initialize Python
        Dim basecommand As String = ("py -m googlesamples.assistant.grpc.textinput --device-model-id DEVICENAME --device-id DEVICENAME")
        Dim fullcommand As String = Replace(basecommand, "DEVICENAME", DeviceName.Text)
        InputTextBox.Text = fullcommand
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
        InitPython.Text = 1
        System.Threading.Thread.Sleep(3000)

        'Now Buttons can be pushed
        TurnOn.Visible = True
        TurnOff.Visible = True
        Label15.Visible = True
        ConfirmTime.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Get PC Battery and Plug Status
        Dim powerstatus As PowerStatus = SystemInformation.PowerStatus
        Dim plugged As String = powerstatus.PowerLineStatus
        Dim percent As Single = SystemInformation.PowerStatus.BatteryLifePercent
        Dim pourcentagebatterie As Integer = percent * 100
        Dim statuschargeur As String
        If plugged = 1 Then
            statuschargeur = "Charging"
        Else
            statuschargeur = "Discharging"
        End If

        Charging.Text = statuschargeur
        BatteryLevel.Text = pourcentagebatterie
    End Sub

    Private Sub TurnOn_Click(sender As Object, e As EventArgs) Handles TurnOn.Click
        'Force Switch On
        InputTextBox.Text = "switch on " & SmartDeviceName.Text
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""

        'Increment the number
        TurnedOnNo.Text = Val(TurnedOnNo.Text) + 1
    End Sub

    Private Sub TurnOff_Click(sender As Object, e As EventArgs) Handles TurnOff.Click
        'Force Switch Off
        InputTextBox.Text = "switch off " & SmartDeviceName.Text
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""

        'Increment the number
        TurnedOffNo.Text = Val(TurnedOffNo.Text) + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ConfirmTime.Click
        'Confirm changes
        ExecuteButton.PerformClick()

        MsgBox("Changed Confirmed")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'Get the time
        WhatTimeIsIt.Text = TimeSpan.Parse(Format(Now, "HH:mm:ss")).ToString

        'Update the Time in Notification   
        Dim remaining As TimeSpan = TimeSpan.Parse(NextCheck.Text).Subtract(TimeSpan.Parse(Format(Now, "HH:mm:ss")))
        Dim nexttime As String = "GHome-PlugManager " & Chr(10) & "Next Check in " & remaining.ToString

        NotifyIcon1.Text = nexttime
    End Sub

    Private Sub AlwaysOn_CheckedChanged(sender As Object, e As EventArgs) Handles AlwaysOn.CheckedChanged
        ExecuteButton.PerformClick()
    End Sub
End Class