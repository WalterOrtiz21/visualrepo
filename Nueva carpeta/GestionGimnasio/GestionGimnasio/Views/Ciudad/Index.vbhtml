
@Code
    Layout = "~/Plantilla/Plantilla.vbhtml"
End Code


    <div class="card card-plain">
        <div class="card-header card-header-primary">
            <h4 class="card-title mt-0">Titulos</h4>
            <p class="card-category"> Holii</p>
        </div>
        <body>
            <h1>Mantenimiento de Ciudades</h1>
            <a href="Ciudad/Create">Nueva Ciudad</a>
            <table>
                <tr>
                    <th>Código</th>
                    <th>Descripción</th>
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
        </div>
        </html>
