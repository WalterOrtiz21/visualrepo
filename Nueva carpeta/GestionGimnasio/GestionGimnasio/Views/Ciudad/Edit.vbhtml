

@Code
    Layout = "~/Plantilla/Plantilla.vbhtml"
End Code

<div class="card card-plain">
    <div class="card-header card-header-primary">
        <h4 class="card-title mt-0">Modificar Ciudad</h4>
        <p class="card-category"> Holii</p>
    </div>
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
    </div>
