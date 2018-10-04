Imports System.Web.Mvc

Namespace Controllers
    Public Class NotaController
        Inherits Controller

        ' GET: Nota
        Function Index() As ActionResult
            Return View()
        End Function
        Function CalcularNota(nota1 As Double, nota2 As Double,
                              nota3 As Double, nota4 As Double) As ActionResult
            Dim vNotaFinal As Double
            vNotaFinal = ((nota1 + nota2 + nota3) / 3) * 0.5 + (nota4 * 0.5)
            Return Content(vNotaFinal)
        End Function
    End Class
End Namespace