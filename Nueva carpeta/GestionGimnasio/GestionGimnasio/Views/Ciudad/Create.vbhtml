
@Code
    Layout = "~/Plantilla/Plantilla.vbhtml"
End Code

<div class="card card-plain">
    <div class="card-header card-header-primary">
        <h4 class="card-title mt-0">Nueva Ciudad</h4>
        <p class="card-category"> Holii</p>
    </div>
    <body>
        <h1>Nueva Ciudad</h1>


        <form action="~/Ciudad/Create" method="post">
            Descripción:
            <input type="text" name="txtDescripcion" />
            <br />
            <input type="submit" value="Guardar" />
        </form>
    </body>
    </div>
   
