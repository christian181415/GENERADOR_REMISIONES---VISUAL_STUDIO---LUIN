Public Class WinRemisiones
    'EL ARCHIVO DE REMISIONES BRUTO SE ENCUENTRA EN LA SIGUIENTE RUTA: \\192.168.16.16\Sistemas IT\22_GLU_DOCUMENTACION\23_REPORTES\22_REMISIONES\23_REMISIONES\23_GLU_REMS\Originales
    'Dim CadenaConexion As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
    Dim RutaArchivo, NombreArchivo As String
    Dim TablasAccessGLU As String = "GLU_REMS (Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo, Sucursal_ID)"
    Dim TablasAccessLFA As String = "LFA_REMS (Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo, Sucursal_ID)"


#Region "LOAD REMISIONES | WINREMISIONES | CARGA INICIAL DEL FORMULARIO REMISIONES"
    Private Sub WinRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BWRemisiones.WorkerReportsProgress = True
        BWRemisiones.WorkerSupportsCancellation = True
    End Sub
#End Region


    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Try
            OFDRemisiones.Title = "Seleccione el archivo Excel a cargar."
            OFDRemisiones.Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            If OFDRemisiones.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RutaArchivo = OFDRemisiones.FileName
                NombreArchivo = OFDRemisiones.SafeFileName

                BWRemisiones.RunWorkerAsync()
            End If
        Catch ex As Exception
            MsgBox("Error en la carga del archivo." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | BtnCargar")
        End Try
    End Sub
End Class