using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AMS23_Carousel.Models;


namespace AMS23_Carousel.Data.Repository
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options):base(options)
        {
            
        }
        public DbSet<CategoryModel> Category {get; set;}
    }
}