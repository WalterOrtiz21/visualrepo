Imports System.Web.Mvc
Imports ClasesGimnasio
Namespace Controllers
    Public Class CiudadController
        Inherits Controller

        ' GET: Ciudad
        Function Index() As ActionResult
            Dim tabla As New DataTable
            Dim vCiudad As New Ciudad
            tabla = vCiudad.RecuperarCiudades()
            ViewData("Ciudades") = tabla.AsEnumerable
            Return View()
        End Function
        ''Accion para llamnar a la vista Create de Ciudad
        Function Create() As ActionResult
            Return View()
        End Function
        ''accion para recibir lso datos de la nueva ciudad para insertar
        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            'creamos el objeto de LA CLASE CIUDAD
            Dim vCiudad As New Ciudad
            'ASIGNAMOS LA PROPIEDAD LOS DATOS QUE VIENEN DEL FORMULARIO
            vCiudad.pDescripcion = form("txtDescripcion")
            'LLAMAMOS AL METODO DE LA CLASE PARA REGISTRAR LA NUEVA CIUDAD
            vCiudad.Guardar()
            'RETORNAMOS A LA ACCION DEL CONTROLADOR

            Return RedirectToAction("Index")


        End Function
        'accion para llamar a vista para modificar un registro
        Function Edit(id As Integer) As ActionResult
            Dim vCiudad As New Ciudad
            vCiudad = vCiudad.RecuperarCiudad(id)
            Return View(vCiudad)
        End Function
        ''accion para recibir lso datos de la nueva ciudad para insertar
        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            'creamos el objeto de LA CLASE CIUDAD
            Dim vCiudad As New Ciudad
            'ASIGNAMOS LA PROPIEDAD LOS DATOS QUE VIENEN DEL FORMULARIO
            vCiudad.pDescripcion = form("txtDescripcion")
            vCiudad.pCiudadID = form("txtCiudadID")
            'LLAMAMOS AL METODO DE LA CLASE PARA REGISTRAR LA NUEVA CIUDAD
            vCiudad.Actualizar()
            'RETORNAMOS A LA ACCION index DEL CONTROLADOR
            Return RedirectToAction("Index")
        End Function

        ' 
        Function Eliminar(id As Integer) As ActionResult
            Dim vCiudad As New Ciudad
            vCiudad.pCiudadID = id
            vCiudad.Eliminar()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace