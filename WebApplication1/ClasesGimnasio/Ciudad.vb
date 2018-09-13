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

    Sub actualizar()
        gDatos.Ejecutar("spActulizarCiudad", Me.CodCiudad, Me.Descripcion)
    End Sub

    Sub Eliminar()
        gDatos.Ejecutar("spEliminarCiudad", Me.CodCiudad)
    End Sub

    Public Function RecuperarCiudad(CodCiudad1 As Integer) As Ciudad
        Dim tabla As New DataTable
        tabla = gDatos.TraerDataTable("spConsultarCiudadPorCodigo", CodCiudad1)
        If tabla.Rows.Count > 0 Then
            Dim vciudad As New Ciudad
            vciudad.CodCiudad = tabla.Rows(0).Item("CodCiudad")
            vciudad.Descripcion = tabla.Rows(0).Item("Descripcion")
            Return vciudad
        Else
            Return Nothing
        End If

    End Function
End Class
