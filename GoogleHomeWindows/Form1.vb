Public Class Welcome
    Dim WorkingFolder As String = "C:\GoogleAssistant\"


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Forcing Creating WOrking Folder
        If (Not System.IO.Directory.Exists(WorkingFolder)) Then System.IO.Directory.CreateDirectory(WorkingFolder)

        'Check if there is a JSON Config file from google 
        Dim JsonPresence As Integer = IO.Directory.GetFiles(WorkingFolder, "*.json").Length
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Dim MyForm As New Python0
        MyForm.Show(Python0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm As New GHome1
        MyForm.Show(GHome1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm As New GHome2
        MyForm.Show(GHome2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyForm As New GHome3
        MyForm.Show(GHome3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MyForm As New Win1
        MyForm.Show(Win1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MyForm As New Win2
        MyForm.Show(Win2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim MyForm As New CMDForm
        MyForm.Show(CMDForm)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim MyForm As New PlugManager
        MyForm.Show(PlugManager)
    End Sub
End Class