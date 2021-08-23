Public Class Form1
    Dim input As String
    Dim speak = CreateObject("sapi.spvoice")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        input = TextBox2.Text
        If input.Contains("hello my ai") Then
            TextBox1.AppendText("hi abraham" & vbNewLine)
            speak.speak("hi abraham")
        ElseIf input.Contains("say my name") Then
            TextBox1.AppendText("your name is abraham ekio" & vbNewLine)
            speak.speak("your name is abraham ekio")
        ElseIf input.Contains("open notepad") Then
            TextBox1.AppendText("notepad open successfully" & vbNewLine)
            System.Diagnostics.Process.Start("notepad")
            speak.speak("notepad open successfully")
        ElseIf input.Contains("cmd") Then
            TextBox1.AppendText("cmd open successfully" & vbNewLine)
            System.Diagnostics.Process.Start("cmd")
            speak.speak("cmd open successfully")
        ElseIf input.Contains("close") Then
            TextBox1.AppendText("thanks visit again" & vbNewLine)
            speak.speak("ok goodbye")
            Me.Close()
        ElseIf input.Contains("how are you") Then
            TextBox1.AppendText("my computer temprature is cool" & vbNewLine)
            speak.speak("i'm cool")
        ElseIf input.Contains("read my profile") Then
            TextBox1.AppendText("Name:abrahamekio|Age:15|" & vbNewLine)
            speak.speak("Reading profile")
        ElseIf input.Contains("shutdown my pc") Then
            System.Diagnostics.Process.Start("shutdown", "-s -t 00")
            speak.speak("shutdown your pc sir")
        ElseIf input.Contains("restart my pc") Then
            System.Diagnostics.Process.Start("restart", "-r -t 00")
            speak.speak("restarting your pc sir")
        End If
    End Sub
End Class
