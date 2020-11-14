Imports System.IO
Public Class GHome1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.ProjectName = TextBox2.Text
        My.Settings.Save()
    End Sub

    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseClick
        Process.Start("https://console.cloud.google.com/cloud-resource-manager")
    End Sub

    Private Sub GHome1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ProjectName IsNot Nothing Then TextBox2.Text = My.Settings.ProjectName
    End Sub
End Class