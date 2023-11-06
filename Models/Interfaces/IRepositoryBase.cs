using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS23_Carousel.Models.Interfaces
{
    public interface IRepositoryBase<TEntity, TKey> where TEntity : class 
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll(); // lista em memória
        // IQueryable<TEntity> GetAll(); trabalha diretamente na base de dados
        // ICollection<TEntity> GetAll(); faz a mesma coisa que os outros dois 
    }
}