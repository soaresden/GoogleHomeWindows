Public Class GHome3
    Private Sub GHome3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox3.AllowDrop = True
    End Sub
    Private Sub RichTextBox3_DragEnter(sender As Object, e As DragEventArgs) Handles RichTextBox3.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub RichTextBox3_DragDrop(sender As Object, e As DragEventArgs) Handles RichTextBox3.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            Dim filepathname As String = MyFiles(0)


            Dim right As String = filepathname.Substring(filepathname.Length - 4, 4)
            RichTextBox3.Text = filepathname
            Dim filenamejson As String = GetFileName(filepathname)
            JsonFilename.Text = filenamejson


            'test if it's a json
            If right <> "json" Then
                MsgBox("Try Again, it's not a JSON File")
                Exit Sub
            End If

            'Move the file to C:\GoogleAssistant
            Dim FileToMove As String
            Dim MoveLocation As String

            FileToMove = RichTextBox3.Text
            MoveLocation = ("C:\GoogleAssistant\" & filenamejson)

            If System.IO.File.Exists(FileToMove) = True Then
                System.IO.File.Move(FileToMove, MoveLocation)
                MessageBox.Show("OK !")
            End If

        End If
    End Sub
    Private Function GetFileName(ByVal path As String) As String
        Dim _filename As String = System.IO.Path.GetFileName(path)
        Return _filename
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/k py -m pip install google-assistant-sdk[samples]")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("cmd", "/k py -m pip install --upgrade google-auth-oauthlib[tool]")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("cmd", "/K py -m pip install --upgrade pip")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        Process.Start("CMD")
    End Sub

    Private Sub JsonFilename_TextChanged(sender As Object, e As EventArgs) Handles JsonFilename.TextChanged
        Dim partie1 As String = ("google-oauthlib-tool --client-secrets " & Chr(34) & "C:\GoogleAssistant\")
        Dim partie2 As String = (JsonFilename.Text & Chr(34))
        Dim partie3 As String = (" --scope https://www.googleapis.com/auth/assistant-sdk-prototype --save --headless")

        fullcmd.Text = partie1 & partie2 & partie3

        Process.Start("cmd", "/K " & fullcmd.Text)
    End Sub
End Class