Imports ClasesGimnasio.Util
Public Class Ciudad
    Private CiudadID As Integer
    Private Descripcion As String

    Public Property pCiudadID As Integer
        Get
            Return CiudadID
        End Get
        Set(value As Integer)
            CiudadID = value
        End Set
    End Property

    Public Property pDescripcion As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Public Function RecuperarCiudades() As DataTable
        Return gDatos.TraerDataTable("spConsultarCiudades")
    End Function
    Sub Guardar()
        gDatos.Ejecutar("spInsertarCiudad", Me.Descripcion)
    End Sub
    Sub Actualizar()
        gDatos.Ejecutar("spActualizarCiudad", Me.CiudadID, Me.Descripcion)
    End Sub

    Sub Eliminar()
        gDatos.Ejecutar("spEliminarCiudad", Me.CiudadID)
    End Sub

    Public Function RecuperarCiudad(vCodCiudad As Integer) As Ciudad
        Dim tabla As New DataTable
        tabla = gDatos.TraerDataTable("spConsultarCiudadPorCodigo", vCodCiudad)
        If tabla.Rows.Count > 0 Then
            Dim vCiudad As New Ciudad
            vCiudad.CiudadID = tabla.Rows(0).Item("CiudadID")
            vCiudad.Descripcion = tabla.Rows(0).Item("Descripcion")
            Return vCiudad
        Else
            Return Nothing
        End If
    End Function

End Class
