Public Class Win2

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        'Opening the project custom name
        'Read the first line (line 0) of the config file
        Dim ligneacopier As String = System.IO.File.ReadAllLines("c:\GoogleAssistant\config.txt")(0)

        'isolate the value
        Dim LineParts() As String = Strings.Split(ligneacopier, "=", 2)
        Dim Value As String = LineParts(1)

        TextBox3.Text = Value

        'Generating the Command for registering
        Dim manufacturer As String = Chr(34) & "Assistant SDK Developer" & Chr(34)
        Dim productname As String = Chr(34) & "Assistant SDK Light" & Chr(34)
        Dim typedevice As String = Chr(34) & "LIGHT" & Chr(34)

        Dim adressebase As String = ("register-model --manufacturer " & manufacturer & " --product-name " & productname & " --type " & typedevice & " --model CUSTOMNAME")

        If TextBox5.Text = "" Then
            TextBox2.Text = ""
        Else
            TextBox2.Text = Replace(adressebase, "CUSTOMNAME", TextBox5.Text)
        End If


        'Editing the config file with the custom device name
        Dim Chemin As String = ("C:\GoogleAssistant\config.txt")
        'Setup the lines with info
        Dim ligne2 As String = ("vdevicename=" & TextBox5.Text)
        Dim Lines() As String = System.IO.File.ReadAllLines(Chemin)
        Lines(1) = ligne2
        System.IO.File.WriteAllLines(Chemin, Lines)


        'Generating the full command
        TextBox4.Text = TextBox1.Text & TextBox3.Text & TextBox2.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/K" & TextBox4.Text)
    End Sub
End Class