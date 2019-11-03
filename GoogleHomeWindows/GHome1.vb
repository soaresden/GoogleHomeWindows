Imports System.IO
Public Class GHome1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create a Blank text file
        Dim Chemin As String = ("C:\GoogleAssistant\Config.txt")
        Dim fPath = Chemin

        File.WriteAllText(Chemin, "")

        'Setup the lines with info
        Dim afile As New IO.StreamWriter(fPath, True)

        Dim line1 As String = ("projectname=" & TextBox2.Text)

        afile.WriteLine(line1)
        afile.Close()
        MsgBox("Project Name Registered in Config File")
    End Sub

    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseClick
        Process.Start("https://console.cloud.google.com/cloud-resource-manager")
    End Sub
End Class