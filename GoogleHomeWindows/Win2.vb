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
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'Generating the full command
        TextBox4.Text = TextBox1.Text & " " & Chr(34) & TextBox6.Text & Chr(34) & TextBox2.Text & " " & Chr(34) & TextBox5.Text.ToLower & Chr(34)

        My.Settings.DeviceName = TextBox5.Text
        My.Settings.Save()
    End Sub

    Private Sub Win2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ProjectName IsNot Nothing Then TextBox6.Text = My.Settings.ProjectName
        If My.Settings.DeviceName IsNot Nothing Then TextBox6.Text = My.Settings.DeviceName
    End Sub
End Class