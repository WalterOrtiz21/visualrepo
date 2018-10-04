
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Modficar Ciudad</title>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h1>Modificar Ciudad</h1>
    <form action="~/Ciudad/Edit" method="post">
        <div class="form-group">
            <input type="hidden" name="txtCiudadID" value="@Model.pCiudadID" />
            <label for="Descripcion">Descripcion</label>
            <input type="text" class="form-control col-md-4 col-lg-4 " required name="txtDescripcion" placeholder="Ingrese el nombre de la ciudad"  value="@Model.pDescripcion" />

         </div>
            <input type="submit" value="Guardar" class="btn btn-outline-success col-sm-12 col-lg-4 col-md-4"/>
</form>
    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
