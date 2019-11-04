Imports WMPLib 'Media Player in virtual form
Public Class CMDForm
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub CMDForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Importing Values from config
        ReadTxt.PerformClick()

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

        TextBox1.Text = 0

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

    Private Sub ReadTxt_Click(sender As Object, e As EventArgs) Handles ReadTxt.Click
        Dim Lines() As String = IO.File.ReadAllLines("C:\GoogleAssistant\config.txt")
        Dim i As Integer
        i = 1
        For Each Line As String In Lines

            Dim LineParts() As String = Strings.Split(Line, "=", 2) 'Split the current line into two chunks at the first =
            Dim Key As String = LineParts(0)
            Dim ValueConfig As String = LineParts(1)

            If i = 1 Then GProjectName.Text = ValueConfig
            If i = 2 Then GVirtualDeviceName.Text = ValueConfig
            i = i + 1
        Next
    End Sub
    Private Sub WriteTxt_Click(sender As Object, e As EventArgs) Handles WriteTxt.Click
        Dim Chemin As String = ("C:\GoogleAssistant\config.txt")
        'Setup the lines with info
        Dim ligne1 As String = ("projectname=" & GProjectName.Text)
        Dim ligne2 As String = ("vdevicename=" & GVirtualDeviceName.Text)
        Dim Lines() As String = System.IO.File.ReadAllLines(Chemin)
        Lines(0) = ligne1
        Lines(1) = ligne2
        System.IO.File.WriteAllLines(Chemin, Lines)
    End Sub
    Private Sub VoiceOkGoogle_Click(sender As Object, e As EventArgs) Handles VoiceOkGoogle.Click
        'Test if there is no project name and device
        If GVirtualDeviceName.Text = "" Or GProjectName.Text = "" Then
            MsgBox("Please Verify your Device/Project Name")
        End If

        'Play the sound File
        My.Computer.Audio.Play(My.Resources.okgooglesnd, AudioPlayMode.Background)

        'Launch the Vocal Code
        Dim OriginalVocalCode As String = "py -m googlesamples.assistant.grpc.pushtotalk --device-model-id VIRTUALDEVICE --project-id PROJECTNAME"
        Dim FinalVocalCode As String = Replace(Replace(OriginalVocalCode, "VIRTUALDEVICE", GVirtualDeviceName.Text), "PROJECTNAME", GProjectName.Text)
        InputTextBox.Text = FinalVocalCode
        ExecuteButton.PerformClick()
    End Sub
    Private Sub VoiceStop_Click(sender As System.Object, e As System.EventArgs) Handles VoiceStop.Click
        MyProcess.StandardInput.WriteLine("EXIT") 'send an EXIT command to the Command Prompt
    End Sub
    Private Sub TextInit_Click(sender As Object, e As EventArgs) Handles TextInit.Click
        Dim basecommand As String = ("python -m googlesamples.assistant.grpc.textinput --device-model-id DEVICENAME --device-id DEVICENAME")
        Dim fullcommand As String = Replace(basecommand, "DEVICENAME", GVirtualDeviceName.Text)

        Dim Textavant As String = InputTextBox.Text
        InputTextBox.Text = fullcommand
        MyProcess.StandardInput.WriteLine(fullcommand)
        InputTextBox.Text = ""
        System.Threading.Thread.Sleep(3000)
        MsgBox("Check Above if Google Assistant is listening")
    End Sub
    Private Sub StopTextButton_click(sender As Object, e As EventArgs) Handles StopTextButton.Click
        VoiceStop.PerformClick()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class