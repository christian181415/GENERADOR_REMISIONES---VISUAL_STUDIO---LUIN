Imports System.Configuration
Imports System.Data.OleDb

Public Class ClassOpciones
#Region "WINHISTORIAL LOAD | WINHISTORIAL | CONFIGURACION DE CARGA INICIAL DEL FORMULARIO"
    Public Function ConfigLoad(CmbYear As ComboBox, BtnLFA As Button)
        Try
            CmbYear.Items.Add(DateTime.Now.Year - 3)
            CmbYear.Items.Add(DateTime.Now.Year - 2)
            CmbYear.Items.Add(DateTime.Now.Year - 1)
            CmbYear.Items.Add(DateTime.Now.Year)
            CmbYear.Items.Add(DateTime.Now.Year + 1)
            CmbYear.Items.Add(DateTime.Now.Year + 2)
            CmbYear.Items.Add(DateTime.Now.Year + 3)

            BtnLFA.BackColor = Color.Red
            CmbYear.Text = DateTime.Now.Year
        Catch ex As Exception
            MsgBox("Error al cargar la configuracion inicial.", MsgBoxStyle.Exclamation, "Error | Corporativo LUIN | #CO11CL24")
        End Try
    End Function
#End Region


#Region "BTN EMPRESAS | WINHISTORIAL | ACCIONES PARA LOS BOTONES DE LAS EMPRESAS GLU Y LFA"
    Public Function BtnEmpresas(BtnActive As Button, BtnDisable As Button, Empresa As String, LTablaRemisiones As Label)
        Try
            BtnActive.BackColor = Color.Red
            BtnDisable.BackColor = Color.FromArgb(138, 42, 43)
            LTablaRemisiones.Text = Empresa
        Catch ex As Exception
            MsgBox("Error al cambiar el boton.", MsgBoxStyle.Exclamation, "Error | Corporativo LUIN | #CO31BE37")
        End Try
    End Function
#End Region


#Region "CMB MES | WINHISTORIAL | COMBO BOX QUE CARGA LOS MESES REGISTRADOS EN DB"
    Public Function CargaMeses(CmbMes As ComboBox, CmbYear As ComboBox, LTablaRemisiones As Label)
        Try
            If LTablaRemisiones.Text <> String.Empty Then
                CmbMes.Items.Clear()
                CmbMes.DataSource = Nothing
                Dim CadenaConexionAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
                Try
                    Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                        Dim ConsultaMes As String = "SELECT FORMAT(FechaArchivo, 'MM') FROM " & LTablaRemisiones.Text &
                                            " WHERE FORMAT(FechaArchivo, 'yyyy') = " & CmbYear.Text &
                                            " GROUP BY FORMAT(FechaArchivo, 'MM');"
                        Dim ComandoConsultaMes As OleDbCommand = New OleDbCommand(ConsultaMes)
                        ComandoConsultaMes.Connection = ConexionDB
                        ConexionDB.Open()
                        Dim Reader As OleDbDataReader = ComandoConsultaMes.ExecuteReader
                        While Reader.Read
                            CmbMes.Items.Add(MonthName(Reader.GetString(0)))
                        End While
                        CmbMes.Text = MonthName(Date.Now.Month - 1)
                    End Using
                Catch ex As Exception
                    MsgBox("Error" & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CO44CM65")
                End Try
            Else
                MsgBox("Seleccione una empresa a consultar.", MsgBoxStyle.Exclamation, "Información | Corporativo LUIN")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los meses.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CO44CM71")
        End Try
    End Function
#End Region
End Class
