using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Automarket.DAL.Context;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Car entity)
        {
            _context.Car.Add(entity);
            _context.SaveChangesAsync();
        }

        public void Delete(Car entity)
        {
            _context.Car.Remove(entity);
            _context.SaveChangesAsync();
        }

        public Car Get(int id)
        {
            return _context.Car.FirstOrDefault(x => x.Id == id);
        }

        public  List<Car> GetAll()
        {
            return  _context.Car.ToList();
        }

        public Car GetByMark(string mark)
        {
            return _context.Car.FirstOrDefault(x => x.Mark == mark);
        }

        public Car GetByModel(string model)
        {
            return _context.Car.FirstOrDefault(x => x.Model == model);

        }

        public Car GetByPrice(decimal price)
        {
            return _context.Car.FirstOrDefault(x => x.Prise == price);
        }
    }
}