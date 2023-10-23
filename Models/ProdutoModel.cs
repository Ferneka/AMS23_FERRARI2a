using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS23_Carousel.Models
{
    public class ProdutoModel
    {
        public Guid Id {get; set;}
        public string Description {get; set;}
        public bool IsActive {get; set;} = true;
        public string ImageURL {get; set;}
        public double Value {get; set;}
    }
}