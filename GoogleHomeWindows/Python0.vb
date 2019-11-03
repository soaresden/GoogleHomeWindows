Imports Microsoft.Win32
Public Class Python0
    Private Sub Python0_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call CheckPython()
    End Sub
    Private Sub CheckPython()
        Dim rk1 As RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey _
                                           (Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64)
        Dim rk2 As RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey _
                                    (Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64)
        Dim rk3 As RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey _
                                    (Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64)
        Dim extensionpath As String

        rk1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
        Dim regpath As String
        regpath = "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products"
        rk2 = rk1.OpenSubKey(regpath)

        For Each subk As String In rk2.GetSubKeyNames


            extensionpath = "InstallProperties\"
            rk3 = rk2.OpenSubKey(subk & "\" & extensionpath, False)
            Dim valuer As String
            Dim valueleft As String

            On Error Resume Next
            valuer = rk3.GetValue("DisplayName", "")
            valueleft = valuer.Substring(0, 6)
            On Error GoTo 0

            If valueleft = "Python" Then
                CheckBox1.Checked = 1
                GoTo finish
            Else
                CheckBox1.Checked = 0
            End If
        Next
finish:
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("CMD")
    End Sub

    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseClick
        Process.Start("https://www.python.org/downloads/release/python-373/")
    End Sub
End Class