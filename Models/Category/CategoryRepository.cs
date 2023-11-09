using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_Carousel.Data.Repository;

namespace AMS23_Carousel.Models.Category
{
    public class CategoryRepository : RepositoryBase<CategoryModel, Guid>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDataContext  applicationDataContext) : base(applicationDataContext){
            
        }
    }
}