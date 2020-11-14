Public Class GHome2
    Private Sub GHome2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Read the first line (line 0) of the config file
        Dim ligneacopier As String = System.IO.File.ReadAllLines("c:\GoogleAssistant\config.txt")(0)
        'isolate the value
        Dim LineParts() As String = Strings.Split(ligneacopier, "=", 2)
        Dim Value As String = LineParts(1)
        RichTextBox5.Text = Value
    End Sub
    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseClick
        Process.Start("https://console.developers.google.com/apis/api/embeddedassistant.googleapis.com/overview")
    End Sub

    Private Sub GHome2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ProjectName IsNot Nothing Then RichTextBox5.Text = My.Settings.ProjectName
    End Sub
End Class