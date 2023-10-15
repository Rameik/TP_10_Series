using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.ObtenerListaSeries();
        return View();
    }

    [HttpPost]
    public Serie VerDetalleSerieAjax(int IdSerie)
    {
        ViewBag.Serie = BD.VerInfoSerie(IdSerie);
        return ViewBag.Serie;
    }

    public List<Temporada> VerTemporadasAjax(int IdSerie)
    {
        ViewBag.Temporadas = BD.VerTemporadas(IdSerie);
        return ViewBag.Temporadas;
    }

    public List<Actor> VerActoresAjax(int IdSerie)
    {
        ViewBag.Actores = BD.VerActores(IdSerie);
        return ViewBag.Actores;
    }
    
}
