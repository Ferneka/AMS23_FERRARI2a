using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_Carousel.Models;

namespace AMS23_Carousel.Repository.Category
{
    public interface ICategoryRepository
    {
        CategoryModel Add(CategoryModel category);
        List<CategoryModel> GetAll();
    }
}