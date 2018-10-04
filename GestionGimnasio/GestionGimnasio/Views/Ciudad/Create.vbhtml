
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Nueva Ciudad</title>
</head>
<body>
    <h1>Nueva Ciudad</h1>

   
    <form action="~/Ciudad/Create" method="post">
        Descripción:
        <input type="text" name="txtDescripcion" />
        <br />
        <input type="submit" value="Guardar" />
    </form>
</body>
</html>
