using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAngular.Models
{
    public class Car
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Trim { get; set; }

        public int HorsePower { get; set; }

        public int WeightKilograms { get; set; }
    }
}