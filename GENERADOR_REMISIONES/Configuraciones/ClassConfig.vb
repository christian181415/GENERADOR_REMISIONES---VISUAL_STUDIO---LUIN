Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ClassConfig
    Public Function ExitApp()
        If MsgBox("Deseas cerrar la aplicaión?", vbYesNo Or vbQuestion, "Exit | Corporativo LUIN") = vbYes Then
            End
            Application.Exit()
        End If
    End Function

    Public Function MinimizeApp(Form As Form)
        Form.WindowState = FormWindowState.Minimized
    End Function
    Public Function MaximizeApp(Form As Form)

    End Function

    Public Function ResponsiveTaskBar(PTaskBar As Panel)
        If PTaskBar.Size.Width = 152 Then
            PTaskBar.Size = New Size(55, 0)
        ElseIf PTaskBar.Size.Width = 55 Then
            PTaskBar.Size = New Size(152, 0)
        End If
    End Function
End Class
