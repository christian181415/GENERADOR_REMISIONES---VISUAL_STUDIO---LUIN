Public Class FormPrincipal
    Dim NewConfig As New ClassConfig
#Region "BOTONES PMENU ACCIONES"
    Private Sub PBoxExit_Click(sender As Object, e As EventArgs) Handles PBoxExit.Click
        NewConfig.ExitApp()
    End Sub
    Private Sub PBoxMinimize_Click(sender As Object, e As EventArgs) Handles PBoxMinimize.Click
        NewConfig.MinimizeApp(Me)
    End Sub
    Private Sub PBoxMaximize_Click(sender As Object, e As EventArgs) Handles PBoxMaximize.Click
        'NewConfig.MaximizeApp(Me)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub PBoxLogo_Click(sender As Object, e As EventArgs) Handles PBoxLogo.Click
        NewConfig.ResponsiveTaskBar(PTaskBar)
    End Sub
#End Region
End Class
