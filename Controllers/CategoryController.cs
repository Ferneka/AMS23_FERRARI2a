using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_Carousel.Models;

namespace AMS23_Carousel.Controllers;

public class CategoryController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Add(CategoryModel category)
    {
        var request = category;
        return View();
    }
    public IActionResult ToEdit(){
        return View();
    }
    public IActionResult DeleteConfirmation(){
        return View();
    }
    [HttpPost]
    // public IActionResult Add(CategoryModel category){
    //     return RedirectToAction("Index");
    // }   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
