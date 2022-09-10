using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Automarket.DAL.Context;
using Automarket.DAL.Repository;
using Automarket.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Automarket.Controllers
{
    

    public class CarController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly CarRepository _carRepository;

        public CarController(ApplicationDbContext dbContext, CarRepository carRepository)
        {
            _dbContext =  dbContext;
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var cars = _carRepository.GetAll();
            
            return View(cars);
        }

       
    }
}