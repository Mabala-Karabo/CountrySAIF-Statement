<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtGreetings = New Button()
        Label1 = New Label()
        txtLanguage = New TextBox()
        SuspendLayout()
        ' 
        ' txtGreetings
        ' 
        txtGreetings.Location = New Point(510, 329)
        txtGreetings.Name = "txtGreetings"
        txtGreetings.Size = New Size(235, 34)
        txtGreetings.TabIndex = 0
        txtGreetings.Text = "Country Greetings"
        txtGreetings.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(118, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your SA Official language"
        ' 
        ' txtLanguage
        ' 
        txtLanguage.Location = New Point(382, 92)
        txtLanguage.Name = "txtLanguage"
        txtLanguage.Size = New Size(150, 31)
        txtLanguage.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtLanguage)
        Controls.Add(Label1)
        Controls.Add(txtGreetings)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGreetings As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLanguage As TextBox
End Class
