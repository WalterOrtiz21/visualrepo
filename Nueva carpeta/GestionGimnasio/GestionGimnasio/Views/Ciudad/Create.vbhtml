
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
           
            <input type="submit" class="material-icons"> save/>
            <i class="material-icons">save</i>
        </form>
        <script src="~/scripts/jquery-3.3.1.min.js"></script>
    </body>

    </div>
   
