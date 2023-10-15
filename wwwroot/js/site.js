function MostrarInfoSerie(IDS) {
    $.ajax(
        {
            url: '/Home/VerDetalleSerieAjax',
            type: 'POST',
            dataType: 'JSON',
            data: { IdSerie: IDS },
            success: function (response) {
                    $("#NombreSerie").html(response.nombre);
                    $("#SerieImagen").attr("src", response.imagenSerie);
                    $("#SerieAñoInicio").html("Año de inicio: " + response.añoInicio);
                    $("#SerieSinopsis").html("Sinopsis: " + response.sinopsis);
                    esconderTemporada();
                    esconderActores();
                }
        });
}

function MostrarTemporadas(IDS) {
    let Temp = "";

    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerTemporadasAjax',
            data: { IdSerie: IDS },
            success:
                function (response) 
                {
                    response.forEach(element => {
                        Temp += "Numero de temporada: " + element.numeroTemporada + "<br>";
                        Temp += "Titulo de temporada: " + element.tituloTemporada + "<br>" + "<br>";
                        $("#Temporadas").html(Temp);
                    });

                    esconderInfoSerie();
                    esconderActores();
                }
        });

    // Traer nombre serie
    $.ajax(
        {
            url: '/Home/VerDetalleSerieAjax',
            type: 'POST',
            dataType: 'JSON',
            data: { IdSerie: IDS },
            success: function (response) {
                $("#NombreSerie").html("Temporadas de " + response.nombre);
                $("#SerieImagen").attr("src", response.imagenSerie);
            }
    });
}

function MostrarActores(IDS) {
    let nomActores = "";

    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerActoresAjax',
            data: { IdSerie: IDS },
            success:
                function (response) 
                {
                    response.forEach(element => {
                        nomActores += "Nombre actor/actriz: " + element.nombre + "<br>" + "<br>"
                    });

                    $("#NombreActores").html(nomActores);
                    esconderInfoSerie();
                    esconderTemporada();
                }
        });

    // Traer nombre serie
    $.ajax(
        {
            url: '/Home/VerDetalleSerieAjax',
            type: 'POST',
            dataType: 'JSON',
            data: { IdSerie: IDS },
            success: function (response) {
                $("#NombreSerie").html("Actores de " + response.nombre);
                $("#SerieImagen").attr("src", response.imagenSerie);
            }
    });
}


function esconderInfoSerie() {
    // $("#SerieImagen").attr("src", "");
    $("#SerieAñoInicio").html("");
    $("#SerieSinopsis").html("");
}

function esconderTemporada() {
    $("#Temporadas").html("");
}

function esconderActores() {
    $("#NombreActores").html("");
}