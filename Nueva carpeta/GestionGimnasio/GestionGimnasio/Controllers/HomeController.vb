Imports System.Web.Mvc
Imports ClasesGimnasio
Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Util.inicializaSesion("M203-06", "Gym", "sa", "@lumno123")
            Return View()
        End Function
    End Class
End Namespace