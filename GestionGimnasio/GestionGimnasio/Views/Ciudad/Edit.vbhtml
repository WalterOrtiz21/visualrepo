
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Modificar Ciudad</title>
</head>
<body>
    <hi>Modificar Ciudad</hi>
    <form action="Ciudad/Edit" method="post">
        <input type="hidden" name="txtCiudadID" value="@Model.pCiudadID" />
        Descripcion:
        <input type="text" name="txtDescripcion" value="@Model.pDescripcion"/>
        <br />
        <input type="submit" value="Guardar" />

    </form>
</body>
</html>
