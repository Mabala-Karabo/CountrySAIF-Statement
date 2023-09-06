Public Class Form1
    Private Sub txtGreetings_Click(sender As Object, e As EventArgs) Handles txtGreetings.Click
        Dim language As String
        language = txtLanguage.Text.ToLower
        If language = "sepedi" Then
            MsgBox("Dumela")
        ElseIf language = "venda" Then
            MsgBox("Hee Ndaa")
        ElseIf language = "xhosa" Then
            MsgBox("Molo")
        ElseIf language = "isizulu" Then
            MsgBox("Sawubona")
        ElseIf language = "Tsonga" Then
            MsgBox("Avuxeni")
        ElseIf language = "english" Then
            MsgBox("hello")
        ElseIf language = "isindebele" Then
            MsgBox("lothjani")
        Else
            MsgBox("hello, your language is not specified")
        End If
    End Sub
End Class
