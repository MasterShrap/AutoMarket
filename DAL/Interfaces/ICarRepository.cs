using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Automarket.Domain.Models;
using DAL.Interfaces;

namespace Automarket.DAL.Interfaces
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        Car GetByMark(string mark);
        Car GetByModel(string model);
        Car GetByPrice(decimal price);
    }
}