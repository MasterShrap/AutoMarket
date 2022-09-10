using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<T>
    {
        void Create(T entity);

        void Delete (T entity);

        T Get(int id);

        List<T> GetAll();
    }
}