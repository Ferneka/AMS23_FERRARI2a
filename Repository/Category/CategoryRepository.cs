using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_Carousel.Models;
using AMS23_Carousel.Data.Repository;

namespace AMS23_Carousel.Repository.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDataContext _bancoContext;
        public CategoryRepository(ApplicationDataContext bancoContext){
            _bancoContext = bancoContext;
        }
        public CategoryModel Add(CategoryModel category)
        {
            _bancoContext.Category.Add(category);
            _bancoContext.SaveChanges();
            return category;
        }

        public List<CategoryModel> BuscarTodos()
        {
            return _bancoContext.Category.ToList();
        }
    }
}