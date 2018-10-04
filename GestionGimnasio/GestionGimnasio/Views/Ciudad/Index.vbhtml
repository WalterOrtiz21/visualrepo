
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Mantenimiento de Ciudades</title>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <h1>Mantenimiento de Ciudades</h1>
        <a href="Ciudad/Create" class="btn btn-outline-success">Nueva Ciudad</a>
        <table class="table table-dark table-hover">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Descripción</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                @For Each row In ViewData("Ciudades")
                    @<tr>
                        <td>@row("CiudadID")</td>
                        <td>@row("Descripcion")</td>
                        <td>
                            <a href="Ciudad/Edit/@row("CiudadID")" class="btn btn-outline-primary">Modificar</a>

                            <a href="Ciudad/Delete/@row("CiudadID")" class="btn btn-outline-danger">Eliminar</a>
                        </td>
                    </tr>
                Next
            </tbody>





        </table>
    </div>
    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
