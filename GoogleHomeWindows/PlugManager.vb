Public Class PlugManager
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub InputMinutes_TextChanged(sender As Object, e As EventArgs) Handles InputMinutes.TextChanged
        On Error Resume Next
        'Configuring Time
        Dim thismoment As TimeSpan = TimeSpan.Parse(Format(Now, "hh:mm:ss"))
        Dim nextmoment As TimeSpan = TimeSpan.Parse(InputMinutes.Text).Add(thismoment)

        LastCheck.Text = thismoment.ToString
        NextCheck.Text = nextmoment.ToString
        On Error GoTo 0
    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click
        'Check if smartdevicename is empty

        If SmartDeviceName.Text = "" Then
            MsgBox("Please Input your Device Name")
            Exit Sub
        End If

        'If it's the first time, just run the Python Init
        If InitPython.Text = 0 Then
            MyProcess.StandardInput.WriteLine(InputTextBox.Text)
            MyProcess.StandardInput.Flush()
            InputTextBox.Text = ""
            InitPython.Text = 1
            GoTo Fin
        End If

        'Conditionnally chosing what to do 
        If Val(BatteryLevel.Text) < Val(LowLevel.Text) Then
            InputTextBox.Text = "switch on " & SmartDeviceName.Text
            MyProcess.StandardInput.WriteLine(InputTextBox.Text)
            MyProcess.StandardInput.Flush()
            InputTextBox.Text = ""

        ElseIf Val(BatteryLevel.Text) > Val(HighLevel.Text) Then
            InputTextBox.Text = "switch off " & SmartDeviceName.Text
            MyProcess.StandardInput.WriteLine(InputTextBox.Text)
            MyProcess.StandardInput.Flush()
            InputTextBox.Text = ""
        Else
            'nothing to do because it's between [low level;HighLevel] = Discharging or Charging Action
        End If


        'Configuring time 
        Dim thismoment As TimeSpan = TimeSpan.Parse(Format(Now, "hh:mm:ss"))
        Dim nextmoment As TimeSpan = TimeSpan.Parse(InputMinutes.Text).Add(thismoment)

        LastCheck.Text = thismoment.ToString
        NextCheck.Text = nextmoment.ToString

        'Activating the timer and process again
        Dim tempsenminutes As TimeSpan = TimeSpan.Parse(InputMinutes.Text)
        Dim tempsenmilli As Double = tempsenminutes.TotalMilliseconds

        Timer1.Interval = tempsenmilli
        Timer1.Enabled = True

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
        Else
            statuschargeur = "Discharging"
        End If

        Charging.Text = statuschargeur
        BatteryLevel.Text = pourcentagebatterie

        'Import the device name
        'Read the first line (line 0) of the config file
        Dim ligneacopier As String = System.IO.File.ReadAllLines("c:\GoogleAssistant\config.txt")(1)

        'isolate the value
        Dim LineParts() As String = Strings.Split(ligneacopier, "=", 2)
        Dim Value As String = LineParts(1)
        DeviceName.Text = Value

        'Initialize Python
        Dim basecommand As String = ("python -m googlesamples.assistant.grpc.textinput --device-model-id DEVICENAME --device-id DEVICENAME")
        Dim fullcommand As String = Replace(basecommand, "DEVICENAME", DeviceName.Text)
        Dim initializepython As Boolean = 1
        Dim Textavant As String = InputTextBox.Text
        InputTextBox.Text = fullcommand
        MyProcess.StandardInput.WriteLine(fullcommand)
        InputTextBox.Text = ""
        System.Threading.Thread.Sleep(3000)

        'Configuring Time
        Dim thismoment As TimeSpan = TimeSpan.Parse(Format(Now, "hh:mm:ss"))
        Dim nextmoment As TimeSpan = TimeSpan.Parse(InputMinutes.Text).Add(thismoment)

        LastCheck.Text = thismoment.ToString
        NextCheck.Text = nextmoment.ToString

        'disabling for secure reason the time
        Timer1.Enabled = False

        'Set Focus on Smart Device Name
        SmartDeviceName.Focus()

    End Sub

    Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ExecuteButton.PerformClick()

    End Sub


    Private Sub PlugManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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




End Class