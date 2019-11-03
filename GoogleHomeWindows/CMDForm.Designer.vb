<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMDForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMDForm))
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.VoiceStop = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GProjectName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WriteTxt = New System.Windows.Forms.Button()
        Me.ReadTxt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GVirtualDeviceName = New System.Windows.Forms.TextBox()
        Me.VoiceOkGoogle = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StopTextButton = New System.Windows.Forms.Button()
        Me.TextInit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.Black
        Me.OutputTextBox.ForeColor = System.Drawing.Color.White
        Me.OutputTextBox.Location = New System.Drawing.Point(9, 23)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputTextBox.Size = New System.Drawing.Size(452, 362)
        Me.OutputTextBox.TabIndex = 0
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(57, 15)
        Me.InputTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(227, 20)
        Me.InputTextBox.TabIndex = 0
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(109, 38)
        Me.ExecuteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(111, 39)
        Me.ExecuteButton.TabIndex = 2
        Me.ExecuteButton.Text = "Send Instruction to Google"
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'VoiceStop
        '
        Me.VoiceStop.Location = New System.Drawing.Point(77, 27)
        Me.VoiceStop.Margin = New System.Windows.Forms.Padding(2)
        Me.VoiceStop.Name = "VoiceStop"
        Me.VoiceStop.Size = New System.Drawing.Size(50, 39)
        Me.VoiceStop.TabIndex = 3
        Me.VoiceStop.Text = "STOP"
        Me.VoiceStop.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Windows Console Log :"
        '
        'GProjectName
        '
        Me.GProjectName.Location = New System.Drawing.Point(7, 49)
        Me.GProjectName.Margin = New System.Windows.Forms.Padding(2)
        Me.GProjectName.Name = "GProjectName"
        Me.GProjectName.Size = New System.Drawing.Size(132, 25)
        Me.GProjectName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Google Project Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.WriteTxt)
        Me.GroupBox1.Controls.Add(Me.ReadTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GVirtualDeviceName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GProjectName)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(464, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(142, 262)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Settings"
        '
        'WriteTxt
        '
        Me.WriteTxt.ForeColor = System.Drawing.Color.Black
        Me.WriteTxt.Location = New System.Drawing.Point(7, 217)
        Me.WriteTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.WriteTxt.Name = "WriteTxt"
        Me.WriteTxt.Size = New System.Drawing.Size(132, 40)
        Me.WriteTxt.TabIndex = 11
        Me.WriteTxt.Text = "Write ConfigFile"
        Me.WriteTxt.UseVisualStyleBackColor = True
        '
        'ReadTxt
        '
        Me.ReadTxt.ForeColor = System.Drawing.Color.Black
        Me.ReadTxt.Location = New System.Drawing.Point(7, 172)
        Me.ReadTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.ReadTxt.Name = "ReadTxt"
        Me.ReadTxt.Size = New System.Drawing.Size(132, 40)
        Me.ReadTxt.TabIndex = 10
        Me.ReadTxt.Text = "Read ConfigFile"
        Me.ReadTxt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Virtual Device Name"
        '
        'GVirtualDeviceName
        '
        Me.GVirtualDeviceName.Location = New System.Drawing.Point(7, 128)
        Me.GVirtualDeviceName.Margin = New System.Windows.Forms.Padding(2)
        Me.GVirtualDeviceName.Name = "GVirtualDeviceName"
        Me.GVirtualDeviceName.Size = New System.Drawing.Size(132, 25)
        Me.GVirtualDeviceName.TabIndex = 8
        '
        'VoiceOkGoogle
        '
        Me.VoiceOkGoogle.BackColor = System.Drawing.Color.LemonChiffon
        Me.VoiceOkGoogle.Image = CType(resources.GetObject("VoiceOkGoogle.Image"), System.Drawing.Image)
        Me.VoiceOkGoogle.Location = New System.Drawing.Point(11, 16)
        Me.VoiceOkGoogle.Margin = New System.Windows.Forms.Padding(2)
        Me.VoiceOkGoogle.Name = "VoiceOkGoogle"
        Me.VoiceOkGoogle.Size = New System.Drawing.Size(36, 60)
        Me.VoiceOkGoogle.TabIndex = 12
        Me.VoiceOkGoogle.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox2.Controls.Add(Me.VoiceStop)
        Me.GroupBox2.Controls.Add(Me.VoiceOkGoogle)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 388)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(150, 81)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GoogleHome Voice Control"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Azure
        Me.GroupBox3.Controls.Add(Me.StopTextButton)
        Me.GroupBox3.Controls.Add(Me.TextInit)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.InputTextBox)
        Me.GroupBox3.Controls.Add(Me.ExecuteButton)
        Me.GroupBox3.Location = New System.Drawing.Point(172, 388)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(288, 81)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GoogleHome Text Control : Confirm with Enter"
        '
        'StopTextButton
        '
        Me.StopTextButton.Location = New System.Drawing.Point(224, 38)
        Me.StopTextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopTextButton.Name = "StopTextButton"
        Me.StopTextButton.Size = New System.Drawing.Size(60, 38)
        Me.StopTextButton.TabIndex = 19
        Me.StopTextButton.Text = "STOP"
        Me.StopTextButton.UseVisualStyleBackColor = True
        '
        'TextInit
        '
        Me.TextInit.Location = New System.Drawing.Point(5, 38)
        Me.TextInit.Margin = New System.Windows.Forms.Padding(2)
        Me.TextInit.Name = "TextInit"
        Me.TextInit.Size = New System.Drawing.Size(100, 40)
        Me.TextInit.TabIndex = 18
        Me.TextInit.Text = "Init Python"
        Me.TextInit.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(49, 20)
        Me.TextBox1.TabIndex = 17
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DimGray
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(462, 314)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(144, 155)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = "Tips for Bugs : " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "* Check your network and connection" & Global.Microsoft.VisualBasic.ChrW(10) & "* Appears that Google limit" &
    " to 500 request/day" & Global.Microsoft.VisualBasic.ChrW(10) & "* Read well the errors to understand" & Global.Microsoft.VisualBasic.ChrW(10) & "* Don't mix Vocal and T" &
    "ext" & Global.Microsoft.VisualBasic.ChrW(10) & "* Exit this Form and Open Again"
        '
        'CMDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 477)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CMDForm"
        Me.Text = "CMDForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents ExecuteButton As Button
    Friend WithEvents VoiceStop As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GProjectName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GVirtualDeviceName As TextBox
    Friend WithEvents VoiceOkGoogle As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ReadTxt As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents WriteTxt As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents StopTextButton As Button
    Friend WithEvents TextInit As Button
End Class
