Imports System.Configuration
Imports System.Data.OleDb

Public Class ClassOpciones
#Region "VARIABLES GLOBALES | WINHISTORIAL | VARIABLES DE ACCESO A LOS METODOS DE LA CLASE HISTORIAL"
    Dim TablaRemisiones As String = "LFA_REMS"
#End Region


#Region "WINHISTORIAL LOAD | WINHISTORIAL | CONFIGURACION DE CARGA INICIAL DEL FORMULARIO"
    Public Function ConfigLoad(CmbYear As ComboBox, BtnLFA As Button)
        CmbYear.Items.Add(DateTime.Now.Year - 3)
        CmbYear.Items.Add(DateTime.Now.Year - 2)
        CmbYear.Items.Add(DateTime.Now.Year - 1)
        CmbYear.Items.Add(DateTime.Now.Year)
        CmbYear.Items.Add(DateTime.Now.Year + 1)
        CmbYear.Items.Add(DateTime.Now.Year + 2)
        CmbYear.Items.Add(DateTime.Now.Year + 3)

        BtnLFA.BackColor = Color.Red
        CmbYear.Text = DateTime.Now.Year
    End Function
#End Region


#Region "BTN EMPRESAS | WINHISTORIAL | ACCIONES PARA LOS BOTONES DE LAS EMPRESAS GLU Y LFA"
    Public Function BtnEmpresas(BtnActive As Button, BtnDisable As Button, Empresa As String)
        BtnActive.BackColor = Color.Red
        BtnDisable.BackColor = Color.FromArgb(138, 42, 43)
        TablaRemisiones = Empresa
    End Function
#End Region


#Region "CMB MES | WINHISTORIAL | COMBO BOX QUE CARGA LOS MESES REGISTRADOS EN DB"
    Public Function CargaMeses(CmbMes As ComboBox, CmbYear As ComboBox)
        If TablaRemisiones <> String.Empty Then
            CmbMes.Items.Clear()
            CmbMes.DataSource = Nothing
            Dim CadenaConexionAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
            Try
                Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                    Dim ConsultaMes As String = "SELECT FORMAT(FechaArchivo, 'MM') FROM " & TablaRemisiones &
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
                MsgBox("Error" & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | CmbYear")
            End Try
        Else
            MsgBox("Seleccione una empresa a consultar.", MsgBoxStyle.Information, "Información | Corporativo LUIN | CmbYear")
        End If
    End Function
#End Region
End Class
