Imports System.Configuration
Imports System.Data.OleDb

Public Class ClassExportarExcel
    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    Public Function GenerarExcel(DtgExportarDiferencias As DataGridView, SaveFileExcel As SaveFileDialog)
        Dim RutaAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
        Dim ConexionDB As OleDbConnection = New OleDbConnection(RutaAccess)

        If SaveFileExcel.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim RutaExcel = SaveFileExcel.FileName

            Try
                'If 
            Catch ex As Exception
                MsgBox("Error al crear el archivo Excel.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CEE9GE19")
            End Try
        End If
    End Function
End Class
