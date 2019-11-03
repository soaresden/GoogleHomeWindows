Public Class Win1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/K" & RichTextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Process.Start("CMD")
    End Sub
End Class