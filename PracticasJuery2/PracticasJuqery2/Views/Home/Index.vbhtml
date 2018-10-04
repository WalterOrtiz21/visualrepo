
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <h1>Calculadora con Jquery</h1>

    Valor 1:<input type="text" id="txtValor1" />
    <br>
    Valor 2:<input type="text" id="txtValor2" />
    
    <br />
    Resultado: <input type="text" id="txtResultado" />
    <br />

    <h1 id="lblResultado"></h1>

    <input type="button" value="Calcular" onclick="javascript:Calcular()" />
    <script src="~/scripts/jquery-3.3.1.min.js"></script>
    <script type="text/javascript">
        function Calcular() {
            //alert("Prueba de javascript");
            //alert($("#txtValor1").val());
            //Asignar un valor al cuadro de texto
           // $("#txtValor2").val(100);

            $.ajax({
                //La url para la petición
                url: '/Home/Calcular',
                //Definimos parametros que se va enviar
                data: { valor1: $("#txtValor1").val(), valor2: $("#txtValor2").val()},
                //La forma de envio Post o get
                type: 'GET',
                //El tipo de dato de dato que va retornar la acción
                dateType: 'json',
                success: function (retorno) {
                    //Operación
                   // alert(retorno);
                    $("#txtResultado").val(retorno);
                    $("#lblResultado").html("El resultado es: " + retorno);
                }
            })// fin metodo ajax
        }// Fin Función  Calcular
    </script>
</body>
</html>
