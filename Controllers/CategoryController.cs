using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_Carousel.Models;
using AMS23_Carousel.Repository.Category;

namespace AMS23_Carousel.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryController(ICategoryRepository categoryRepository){
        _categoryRepository = categoryRepository;
    }
    public IActionResult Index()
    {
        var categorys = _categoryRepository.GetAll();
        return View(categorys);
    }
    public IActionResult Add()
    {
        // var request = category;
        return View();
    }
    public IActionResult ToEdit(){
        return View();
    }
    public IActionResult DeleteConfirmation(){
        return View();
    }
    [HttpPost]
    public IActionResult Add(CategoryModel category){
        _categoryRepository.Add(category);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
