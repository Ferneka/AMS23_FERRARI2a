using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_Carousel.Models;

namespace AMS23_Carousel.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Add(ProdutoModel produto)
    {
        var request = produto;
        return View();
    }
    public IActionResult ToEdit(){
        return View();
    }
    public IActionResult Delete(){
        return View();
    }
    [HttpPost]

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}