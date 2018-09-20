
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
    <hi>Nueva Ciudad</hi>
          <form action= "Ciudad/Create" method="post">
             Descripcion:
                 <input type="text" name="txtDescripcion"/>
                 <br />
                 <input type="submit" value="Guardar" />

   </form>
</body>
</html>
