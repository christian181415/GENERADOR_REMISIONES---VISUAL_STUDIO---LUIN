Public Class WinHistorial
    Private Sub WinHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add(DateTime.Now.Year - 3)
        ComboBox1.Items.Add(DateTime.Now.Year - 2)
        ComboBox1.Items.Add(DateTime.Now.Year - 1)

        ComboBox1.Items.Add(DateTime.Now.Year)

        ComboBox1.Items.Add(DateTime.Now.Year + 1)
        ComboBox1.Items.Add(DateTime.Now.Year + 2)
        ComboBox1.Items.Add(DateTime.Now.Year + 3)

        ComboBox1.Text = DateTime.Now.Year
        ComboBox2.Text = MonthName(DateTime.Now.Month)
    End Sub

    Private Sub BtnMostrarRemisiones_Click(sender As Object, e As EventArgs) Handles BtnMostrarRemisiones.Click

    End Sub
End Class