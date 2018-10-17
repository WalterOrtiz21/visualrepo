
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Modficar Ciudad</title>
</head>
<body>
    <h1>Modificar Ciudad</h1>
    <form action="~/Ciudad/Edit" method="post">
        <input type="hidden" name="txtCiudadID" value="@Model.pCiudadID" />
        Descripción:
        <input type="text" name="txtDescripcion" value="@Model.pDescripcion" />
        <br />
        <input type="submit" value="Guardar" />
    </form>
</body>
</html>
