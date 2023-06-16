Imports System.Configuration

Public Class WinOpciones
#Region "VARIABLES GLOBALES | WINHISTORIAL | VARIABLES DE ACCESO A LOS METODOS DE LA CLASE HISTORIAL"
    Dim NewOpcion As New ClassOpciones
    Dim NewExcel As New ClassExportarExcel
#End Region

    Private Sub WinOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewOpcion.ConfigLoad(CmbYear, BtnLFA)
        'NewOpcion.CargaMeses(CmbMes, CmbYear)
    End Sub


    Private Sub BtnLFA_Click(sender As Object, e As EventArgs) Handles BtnLFA.Click
        NewOpcion.BtnEmpresas(BtnLFA, BtnGLU, "LFA_REMS", LTablaRemisiones)
    End Sub
    Private Sub BtnGLU_Click(sender As Object, e As EventArgs) Handles BtnGLU.Click
        NewOpcion.BtnEmpresas(BtnGLU, BtnLFA, "GLU_REMS", LTablaRemisiones)
    End Sub


    Private Sub CmbMes_MouseClick(sender As Object, e As MouseEventArgs) Handles CmbMes.MouseClick
        NewOpcion.CargaMeses(CmbMes, CmbYear, LTablaRemisiones)
    End Sub

    Private Sub BtnGenerarExcel_Click(sender As Object, e As EventArgs) Handles BtnGenerarExcel.Click
        NewExcel.GenerarExcel(DTGSeriesDB, DtgExDiferencias, SaveFileExcel, LTablaRemisiones, CmbYear, CmbMes)
    End Sub
End Class