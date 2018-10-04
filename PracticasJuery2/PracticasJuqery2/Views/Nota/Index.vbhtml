
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Nota Alumno</title>
</head>
<body>
    <h1>Calcular Nota</h1>
    <div>
        <table>
            <tr>
                <td>Primer Parcial :</td>
                <td><input id="txtValor1" type="text" /></td>
            </tr>
            <tr>
                <td>Segundo Parcia:</td>
                <td><input id="txtValor2" type="text" /></td>
            </tr>
            <tr>
                <td>Tercer Parcia:</td>
                <td><input id="txtValor3" type="text" /></td>
            </tr>
            <tr>
                <td>Final Parcia:</td>
                <td><input id="txtValor4" type="text" /></td>

            </tr>
            <tr>
                <td>Nota Final</td>
                <td>
                    <input id="txtResultado" type="text" />
                </td>
            </tr>
        </table>
        <h1 id="lblResultado"></h1>
        <input type="button" value="Calcular" onclick="javascript:Calcular()" />

    </div>
   
    <script src="~/scripts/jquery-3.3.1.min.js"></script>

    <script type="text/javascript">
        function Calcular() {

            $.ajax({
                //La url para la petición
                url: '/Nota/CalcularNota',
                //Definimos parametros que se va enviar
                data: {
                    nota1: $("#txtValor1").val(),
                    nota2: $("#txtValor2").val(),
                    nota3: $("#txtValor3").val(),
                    nota4: $("#txtValor4").val()
                },
                //La forma de envio Post o get
                type: 'GET',
                //El tipo de dato de dato que va retornar la acción
                dateType: 'json',
                success: function (retorno) {
                    $("#txtResultado").val(retorno);
                    $("#lblResultado").html(retorno);
                }
            }) //Fin de la Funcion Ajax

        } //Fin de la Funcion Calcular

    </script>

</body>
</html>
