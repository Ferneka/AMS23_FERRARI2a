using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_Carousel.Models;
using AMS23_Carousel.Models.Category;
// using AMS23_Carousel.Repository.Category;

namespace AMS23_Carousel.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryController(ICategoryRepository categoryRepository){
        _categoryRepository = categoryRepository;
    }
    public async Task<IActionResult> Index()
    {
        IEnumerable<CategoryModel> categories  = await _categoryRepository.GetAll();
        return View(categories);
    }
    public IActionResult Add()
    {
        // var request = category;
        return View();
    }
    public IActionResult ToEdit(Guid id){
        CategoryModel category =  _categoryRepository.GetById(id);
        return View(category);
    }
    public IActionResult DeleteConfirmation(Guid id){
        CategoryModel category = _categoryRepository.GetById(id);
        return View(category);
    }
    public IActionResult Delete(CategoryModel category){
        _categoryRepository.Delete(category);
        _categoryRepository.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Add(CategoryModel category){
        _categoryRepository.Add(category);
        _categoryRepository.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Alter(CategoryModel category){
        _categoryRepository.ToEdit(category);
        _categoryRepository.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
