
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Mantenimiento de Ciudades</title>
</head>
<body>
    <hi>Mantenimiento de Ciudades</hi>
    <a href=" Ciudad/Create">Nueva Ciudad>/a>
    <table>
        <tr>
            <th>codigo</th>
            <th>Descripcion</th>
            <th>Acciones</th>
        </tr>
        @For Each row In ViewData("Ciudades")
            @<tr>
                  <td>@row("CiudadID")</td>
                  <td>@row("Descripcion")</td>
                  <td>
                      <a href="Ciudad/Edit/@row("CiudadID")">Modificar</a>
                      <a href="Ciudad/Delete/@row("CiudadID")">Eliminar</a>
                  </td>
        </tr>
        Next


    </table>
</body>
</html>
