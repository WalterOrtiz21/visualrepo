
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Grilla</title>

    <link href="~/css/bootstrap.min.css" rel="stylesheet" media="screen" />
    <link href="~/css/estilos.css" rel="stylesheet" media="screen" />
</head>
<body>
    <header>
        <div class="container">
            <h1>Visual Baisic <span class="small">Avanzado</span></h1>
        </div>
    </header>
    <div class="container">
        @***********************@
        @* Inicio primera fila *@
        @***********************@
        <div class="row">
            @* Inicio columna 1 *@
            <div class="col-sm-8 col-md-9 col-lg-9">
                <h3>ASP.NET MVC</h3>
                <p>
                    El ASP.NET MVC Framework es un framework de aplicaciones web que implementa el patrón modelo-vista-controlador (MVC).
                    <br />
                    Basado en ASP.NET, permite a los desarrolladores de software construir una aplicación web como una composición de tres funciones: modelo, vista y controlador.
                    <br />
                    En marzo de 2009 se hizo pública la primera versión de ASP.NET MVC. El patrón de arquitectura MVC (model-view-controller) no es nuevo (data de 1979) ni es algo que haya inventado Microsoft. Existen muchos frameworks de desarrollo web populares que utilizan MVC, como por ejemplo Ruby on Rails, Spring o Apache Struts. MVC es un patrón de arquitectura que ayuda a crear una separación lógica entre el modelo (información y lógica de negocio), la vista (la lógica de presentación) y el controlador (intermediario entre la vista y el modelo).
                </p>
            </div>
            @* Fin columna 1 *@

            @* Inicio columna 2 *@
            <div class="col-sm-4 col-md-3 col-lg-3 color3">
                <h3>POO</h3>
                <p>
                    La programación orientada a objetos (POO, u OOP según sus siglas en inglés) es un paradigma de programación que viene a innovar la forma de obtener resultados. Los objetos manipulan los datos de entrada para la obtención de datos de salida específicos, donde cada objeto ofrece una funcionalidad especial.
                </p>

            </div>
            @* Fin columna 2 *@

        </div>
        @***********************@
        @*  Fin primera fila   *@
        @***********************@

        @***********************@
        @* Inicio segunda fila *@
        @***********************@
        <div class="row">
            @* Inicio columna 1 *@
            <div class="col-sm-6 col-md-3 col-lg-3 color2">
                <h3>JavaScript</h3>
                <p>
                    JavaScript es un lenguaje de programación interpretado, dialecto del estándar ECMAScript. Se define como orientado a objetos, ​ basado en prototipos, imperativo, débilmente tipado y dinámico.
                </p>
            </div>
            @* Fin columna 1 *@

            @* Inicio columna 2 *@
            <div class="col-sm-6 col-md-3 col-lg-3 color1">
                <h3>jQuery</h3>
                <p>
                    Es una biblioteca multiplataforma de JavaScript, que permite simplificar la manera de interactuar con los documentos HTML, manejar eventos, desarrollar animaciones y agregar interacción con la técnica AJAX a páginas web.
                </p>
            </div>
            @* Fin columna 2 *@

            @* Inicio columna 3 *@
            <div class="col-sm-6 col-md-3 col-lg-3 color2">
                <h3>Bootstrap</h3>
                <p>
                    Es un framework web o conjunto de herramientas de código abierto para diseño de sitios y aplicaciones web. Contiene plantillas de diseño con tipografía, formularios, botones, cuadros, menús de navegación y otros elementos de diseño basado en HTML y CSS.
                </p>
            </div>
            @* Fin columna 3 *@

            @* Inicio columna 4 *@
            <div class="col-sm-6 col-md-3 col-lg-3 color1">
                <h3>Servicios web</h3>
                <p>
                    Es una tecnología que utiliza un conjunto de protocolos y estándares que sirven para intercambiar datos entre aplicaciones. Distintas aplicaciones de software desarrolladas en lenguajes de programación diferentes, y ejecutadas sobre cualquier plataforma.
                </p>
            </div>
            @* Fin columna 4 *@
        </div>

        @***********************@
        @*  Fin segunda fila   *@
        @***********************@
    </div>
    <footer>
        <div class="container">
            <h3>Universidad Autónoma de Asunción</h3>
        </div>
    </footer>

    <script src="~/js/jquery-3.2.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
</body>
</html>
