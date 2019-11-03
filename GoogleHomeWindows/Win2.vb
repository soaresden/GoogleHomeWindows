Public Class Win2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text = "" Then
            MsgBox("Please enter a custom Device Name to register")
            Exit Sub
        End If

        Process.Start("cmd", "/K" & TextBox4.Text)
    End Sub

    Private Sub Win2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Generating the adress
        'Generating the Command for registering
        Dim MANU As String = Chr(34) & "Assistant SDK Developer" & Chr(34)
        Dim PROD As String = Chr(34) & "Assistant SDK Light" & Chr(34)
        Dim TYPO As String = Chr(34) & "LIGHT" & Chr(34)

        Dim adressebase As String = (" register-model --manufacturer " & MANU & " --product-name " & PROD & " --type " & TYPO & " --model ")
        TextBox2.Text = adressebase

        'Opening the project custom name
        'Read the first line (line 0) of the config file
        Dim ligneacopier As String = System.IO.File.ReadAllLines("c:\GoogleAssistant\config.txt")(0)

        'isolate the value
        Dim LineParts() As String = Strings.Split(ligneacopier, "=", 2)
        Dim Value As String = LineParts(1)

        TextBox6.Text = Value
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'Generating the full command
        TextBox4.Text = TextBox1.Text & " " & Chr(34) & TextBox6.Text & Chr(34) & TextBox2.Text & " " & Chr(34) & TextBox5.Text.ToLower & Chr(34)

        'Editing the config file with the custom device name
        Dim Chemin As String = ("C:\GoogleAssistant\config.txt")
        'Setup the lines with info
        Dim ligne2 As String = ("vdevicename=" & TextBox5.Text)
        Dim Lines() As String = System.IO.File.ReadAllLines(Chemin)
        Lines(1) = ligne2
        System.IO.File.WriteAllLines(Chemin, Lines)
    End Sub


End Class