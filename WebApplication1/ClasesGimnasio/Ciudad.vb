Imports ClasesGimnasio.Util

Public Class Ciudad
    Private CodCiudad As Integer
    Private Descripcion As String

    Public Property CodCiudad1 As Integer
        Get
            Return CodCiudad
        End Get
        Set(value As Integer)
            CodCiudad = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Public Function RecuperarCiudades() As DataTable
        Return gDatos.TraerDataTable("SpConsultarCiudades")
    End Function

    Sub Guardar()
        gDatos.Ejecutar("spInsertarCiudad", Me.Descripcion)
    End Sub
End Class
