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
        'Acción para llamar a la vista Create de ciudad
        Function Create() As ActionResult
            Return View()
        End Function
        'Acción para recibir los datos de la nueva ciudad
        'para insertar

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase ciudad
            Dim vCiudad As New Ciudad
            'Asignamos en la propiedad los datos que vienen del formulario
            vCiudad.pDescripcion = form("txtDescripcion")
            'Llamamos al metodo de la clase para registrar la nueva ciudad
            vCiudad.Guardar()
            'Retornamos a la acción Index del controlador
            Return RedirectToAction("Index")
        End Function
        'Acción para llamar a vista para modificar un registro
        Function Edit(id As Integer) As ActionResult
            Dim vCiudad As New Ciudad
            vCiudad = vCiudad.RecuperarCiudad(id)
            Return View(vCiudad)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase ciudad
            Dim vCiudad As New Ciudad
            'Asignamos en la propiedad los datos que vienen del formulario
            vCiudad.pDescripcion = form("txtDescripcion")
            vCiudad.pCiudadID = form("txtCiudadID")
            'Llamamos al metodo de la clase para registrar la nueva ciudad
            vCiudad.Actualizar()
            'Retornamos a la acción Index del controlador
            Return RedirectToAction("Index")
        End Function

        'Acción para eliminar un registro de la tabla ciudad
        Function Delete(id As Integer) As ActionResult
            Dim vCiudad As New Ciudad
            vCiudad.pCiudadID = id
            vCiudad.Eliminar()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace