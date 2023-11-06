using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_Carousel.Models.Interfaces;

namespace AMS23_Carousel.Models.Category
{
    public interface ICategoryRepository : IRepositoryBase<CategoryModel, Guid>
    {
        
    }
}