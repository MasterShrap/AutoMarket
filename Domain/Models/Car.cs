using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automarket.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public decimal Prise { get; set; }
    }
}