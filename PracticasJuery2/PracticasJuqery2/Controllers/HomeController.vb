Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function

        Function Calcular(valor1 As Integer, valor2 As Integer) As ActionResult
            Dim vResultado As Integer
            vResultado = valor1 + valor2
            Return Content(vResultado)
        End Function
    End Class
End Namespace