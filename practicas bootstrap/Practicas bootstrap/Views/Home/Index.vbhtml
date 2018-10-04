
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Practicas Bootstrap</title>
    @*Llamar al archivo css del bootstrap*@

    <link href="~/css/bootstrap.min.css" rel="stylesheet" media="screen" />


</head>
<body>
   
    <h1>Hola Mundo</h1>
    <p>Mi primera web con bootstrap. </p>

    <h2>H2 Encabezado de bootstrap</h2>
    <h3>H3 Encabezado de bootstrap</h3>
    <h4>H4 Encabezado de bootstrap</h4>
    <h5>H5 Encabezado de bootstrap</h5>
    <h6>H6 Encabezado de bootstrap</h6>

    <p class="lead">
        Compressed and uncompressed copies of jQuery files are available.
    </p>
    <p>
         The uncompressed file is best used during development or debugging;
         the compressed file saves bandwidth and improves performance in production. 
        You can also download a sourcemap file for use when debugging with a compressed file.
         The map file is not required for users to run jQuery, it just improves the developer's debugger 
        experience. As of jQuery 1.11.0/2.1.0 the //# sourceMappingURL comment is not included in the 
        compressed file.
    </p>

    <h2>Bloque de Cita</h2>
    <blockquote>
        <p>Esto seria la frase o párrafo a citar</p>
        <footer>Hugo Galeano</footer>
    </blockquote>

    <h1>Tablas</h1>
    <table class="table table-striped">
        <thead>
            <tr>
                <td>Nombre</td>
                <td>Apellido</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Hugo</td>
                <td>Galeano</td>
            </tr>
            <tr>
                <td>Luis</td>
                <td>Ortiz</td>
            </tr>
            <tr>
                <td>Cecilia</td>
                <td>Corvalan</td>
            </tr>
        </tbody>
    </table>
    <br />
    <table class="table table-hover">
        <thead>
            <tr>
                <td>Nombre</td>
                <td>Apellido</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Hugo</td>
                <td>Galeano</td>
            </tr>
            <tr>
                <td>Luis</td>
                <td>Ortiz</td>
            </tr>
            <tr>
                <td>Cecilia</td>
                <td>Corvalan</td>
            </tr>
        </tbody>
    </table>
    
    @*Importante agregar la referencia al jquery*@
    <script src="~/js/jquery-3.2.1.min.js"></script>

    @*Llamamos al javascript del bootstrap*@
    <script src="~/js/bootstrap.min.js"></script>
</body>
</html>
