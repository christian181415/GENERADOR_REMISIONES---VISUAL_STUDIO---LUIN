Imports System.Configuration
Imports System.Data.OleDb

Public Class ClassHistorial
    Dim CadenaConexionAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
    Dim TablaRemisiones As String = String.Empty

    Public Function MostrarRemisiones(CmbHistorial As ComboBox, DateHistorial As DateTime, DtgHistorial As DataGridView)
        Dim ConexionDB As OleDbConnection = New OleDbConnection(CadenaConexionAccess)
        Try
            ConexionDB.Open()
            Dim Consulta = "SELECT Serie, Folio, Codigo, Producto, Unidad, CostoTotal FROM " & TablaRemisiones & " WHERE Almacen = '" & CmbHistorial.Text & "' AND Fecha_Registro = DateValue('" & DateHistorial & "')"
            Dim DataAdapter As New OleDbDataAdapter(Consulta, ConexionDB)
            Dim DT As New DataTable
            DataAdapter.Fill(DT)
            DtgHistorial.DataSource = DT
            ConexionDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
