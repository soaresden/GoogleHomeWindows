Public Class GHome2
    Private Sub GHome2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RichTextBox5.Text = My.Settings.ProjectName
    End Sub
    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseClick
        Process.Start("https://console.developers.google.com/apis/api/embeddedassistant.googleapis.com/overview")
    End Sub

    Private Sub GHome2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ProjectName IsNot Nothing Then RichTextBox5.Text = My.Settings.ProjectName
    End Sub
End Class