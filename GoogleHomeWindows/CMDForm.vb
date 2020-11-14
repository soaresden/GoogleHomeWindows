Imports WMPLib 'Media Player in virtual form
Public Class CMDForm
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub CMDForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Importing Values from config
        If My.Settings.ProjectName IsNot Nothing Then GProjectName.Text = My.Settings.ProjectName
        If My.Settings.DeviceName IsNot Nothing Then GVirtualDeviceName.Text = My.Settings.DeviceName

        'Placing Ourselves in Working Folder
        InputTextBox.Text = "cd C:\GoogleAssistant\"
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        InputTextBox.Text = ""
        TextBox1.Text = 0
        InputTextBox.Focus()
        InputTextBox.Text = "Press Init to initialize Python"
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
            NotifyIcon1.Icon = My.Resources.logo_home
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "WinGoogleHome"
            NotifyIcon1.BalloonTipText = "Is still Running in TrayIcon"
            NotifyIcon1.ShowBalloonTip(30000)
            'Me.Hide()
            ShowInTaskbar = False
        End If

    End Sub

    Private Sub CMDForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        'Hide Groupbox Input and Voice

        GroupBoxInput.Visible = False
        GroupBoxVoice.Visible = True


        TextBox1.Text = 0

        'load values
        If My.Settings.ProjectName IsNot Nothing Then GProjectName.Text = My.Settings.ProjectName
        If My.Settings.DeviceName IsNot Nothing Then GVirtualDeviceName.Text = My.Settings.DeviceName

    End Sub
    Private Sub OverlayMode_Button(sender As Object, e As EventArgs) Handles OverlayMode.Click
        'Hiding Boxes
        GroupBoxVoice.Hide()
        GroupBoxInput.Hide()
        RichTextBox1.Hide()

        'Moving Stuff
        OutputTextBox.Size = New Size(575, 80)
        OutputTextBox.Location = New Point(10, 290)

        Me.Size = New Size(600, 516)

        Mode.Text = "Overlay"

    End Sub
    Private Sub NormalMode_Button(sender As Object, e As EventArgs) Handles NormalMode.Click
        'Showing Boxes
        GroupBoxVoice.Show()
        GroupBoxInput.Show()
        RichTextBox1.Show()

        Me.Size = New Size(1181, 516)

        'Default Size
        OutputTextBox.Location = New Point(585, 137)
        OutputTextBox.Size = New Size(285, 250)

        Me.Opacity = 1

        Mode.Text = "Normal"
    End Sub
    Private Sub CMDForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub CMDForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Mode.Text = "Normal" Then
            Exit Sub
        Else
            Me.Opacity = 0.25
        End If

    End Sub

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & "Error: " & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        InputTextBox.Text = "exit"
        ExecuteButton.PerformClick()

        MyProcess.StandardInput.WriteLine("exit") 'send an EXIT command to the Command Prompt
        MyProcess.StandardInput.Flush()
        MyProcess.Kill()
        MyProcess.Close()

        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("py")
        For Each p As Process In pProcess
            p.Kill()
        Next

        Dim pProcess2() As Process = System.Diagnostics.Process.GetProcessesByName("python")
        For Each p As Process In pProcess2
            p.Kill()
        Next

        On Error GoTo 0
    End Sub


    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        InputTextBox.Text = ""
        InputTextBox.Focus()
        System.Threading.Thread.Sleep(3000)
        TextBox1.Text = Val(TextBox1.Text) + 1
    End Sub

    Private Sub AppendOutputText(ByVal text As String)
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            On Error Resume Next
            Me.Invoke(myDelegate, text)
            On Error GoTo 0
        Else
            On Error Resume Next
            OutputTextBox.AppendText(text)
            On Error GoTo 0
        End If
    End Sub

    Private Sub WriteTxt_Click(sender As Object, e As EventArgs) Handles WriteTxt.Click
        My.Settings.ProjectName = GProjectName.Text
        My.Settings.DeviceName = GVirtualDeviceName.Text
        My.Settings.Save()
    End Sub
    Private Sub VoiceOkGoogle_Click(sender As Object, e As EventArgs) Handles VoiceOkGoogle.Click
        'Test if there is no project name and device
        If GVirtualDeviceName.Text = "" Or GProjectName.Text = "" Then
            MsgBox("Please Verify your Device/Project Name")
        End If

        'Launch VocalCode
        Dim OriginalVocalCode As String = "py -m googlesamples.assistant.grpc.pushtotalk --device-model-id VIRTUALDEVICE --project-id PROJECTNAME"
        Dim FinalVocalCode As String = Replace(Replace(OriginalVocalCode, "VIRTUALDEVICE", GVirtualDeviceName.Text), "PROJECTNAME", GProjectName.Text)

        Dim Textavant As String = InputTextBox.Text
        InputTextBox.Text = FinalVocalCode
        MyProcess.StandardInput.WriteLine(FinalVocalCode)
        InputTextBox.Text = ""
        System.Threading.Thread.Sleep(3000)

        'hide the button
        TextInit.Visible = False

        'Groupboxes Appears
        GroupBoxInput.Visible = True
        GroupBoxVoice.Visible = True


        'Play the sound File
        My.Computer.Audio.Play(My.Resources.okgooglesnd, AudioPlayMode.Background)

    End Sub
    Private Sub TextInit_Click(sender As Object, e As EventArgs) Handles TextInit.Click
        Dim basecommand As String = ("python -m googlesamples.assistant.grpc.textinput --device-model-id DEVICENAME --device-id DEVICENAME")
        Dim fullcommand As String = Replace(basecommand, "DEVICENAME", GVirtualDeviceName.Text)

        Dim Textavant As String = InputTextBox.Text
        InputTextBox.Text = fullcommand
        MyProcess.StandardInput.WriteLine(fullcommand)
        InputTextBox.Text = ""
        System.Threading.Thread.Sleep(3000)

        'hide the button
        TextInit.Visible = False

        'Groupboxes Appears
        GroupBoxInput.Visible = True
        GroupBoxVoice.Visible = True

    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CleanDevices.Click
        lamp1.Text = ""
        lamp2.Text = ""

        chromecast1.Text = ""
        chromecast2.Text = ""

        camera1.Text = ""
        camera2.Text = ""

        aspirateur1.Text = ""
        aspirateur2.Text = ""

        prise1.Text = ""
        prise2.Text = ""

    End Sub

    Private Sub Lamp1on_Click(sender As Object, e As EventArgs) Handles lamp1on.Click
        InputTextBox.Text = "Switch on " & lamp1.Text
        ExecuteButton.PerformClick()
    End Sub
    Private Sub Lamp2on_Click(sender As Object, e As EventArgs) Handles lamp2on.Click
        InputTextBox.Text = "Switch on " & lamp2.Text
        ExecuteButton.PerformClick()
    End Sub
    Private Sub Chromecast1on_Click(sender As Object, e As EventArgs) Handles chromecast1on.Click
        InputTextBox.Text = "Switch on " & chromecast1on.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Chromecast2on_Click(sender As Object, e As EventArgs) Handles chromecast2on.Click
        InputTextBox.Text = "Switch on " & chromecast2on.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Camera1on_Click(sender As Object, e As EventArgs) Handles camera1on.Click
        InputTextBox.Text = "Switch on " & camera1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Camera2on_Click(sender As Object, e As EventArgs) Handles camera2on.Click
        InputTextBox.Text = "Switch on " & camera2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Aspirateur1on_Click(sender As Object, e As EventArgs) Handles aspirateur1on.Click
        InputTextBox.Text = "Switch on " & aspirateur1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Aspirateur2on_Click(sender As Object, e As EventArgs) Handles aspirateur2on.Click
        InputTextBox.Text = "Switch on " & aspirateur2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Prise1on_Click(sender As Object, e As EventArgs) Handles prise1on.Click
        InputTextBox.Text = "Switch on " & prise1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Prise2on_Click(sender As Object, e As EventArgs) Handles prise2on.Click
        InputTextBox.Text = "Switch on " & prise2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Lamp1off_Click(sender As Object, e As EventArgs) Handles lamp1off.Click
        InputTextBox.Text = "Switch off " & lamp1.Text
        ExecuteButton.PerformClick()

    End Sub

    Private Sub Lamp2off_Click(sender As Object, e As EventArgs) Handles lamp2off.Click
        InputTextBox.Text = "Switch off " & lamp2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Chromecast1off_Click(sender As Object, e As EventArgs) Handles chromecast1off.Click
        InputTextBox.Text = "Switch off " & chromecast1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Chromecast2off_Click(sender As Object, e As EventArgs) Handles chromecast2off.Click
        InputTextBox.Text = "Switch off " & chromecast2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Camera1off_Click(sender As Object, e As EventArgs) Handles camera1off.Click
        InputTextBox.Text = "Switch off " & camera1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Camera2off_Click(sender As Object, e As EventArgs) Handles camera2off.Click
        InputTextBox.Text = "Switch off " & camera2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Aspirateur1off_Click(sender As Object, e As EventArgs) Handles aspirateur1off.Click
        InputTextBox.Text = "Switch off " & aspirateur1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Aspirateur2off_Click(sender As Object, e As EventArgs) Handles aspirateur2off.Click
        InputTextBox.Text = "Switch off " & aspirateur2.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Prise1off_Click(sender As Object, e As EventArgs) Handles prise1off.Click
        InputTextBox.Text = "Switch off " & prise1.Text
        ExecuteButton.PerformClick()
    End Sub

    Private Sub Prise2off_Click(sender As Object, e As EventArgs) Handles prise2off.Click
        InputTextBox.Text = "Switch off " & prise2.Text
        ExecuteButton.PerformClick()
    End Sub


End Class