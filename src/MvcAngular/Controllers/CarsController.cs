using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MvcAngular.Models;

namespace MvcAngular.Controllers
{
    public class CarsController : ApiController
    {
        private List<Car> _records;

        public CarsController()
        {
            _records = new List<Car>
            {
                new Car { Id = 1, Year = 2018, Make = "Chevy", Model = "Camaro", Trim = "Exorcist", HorsePower = 1000, WeightKilograms = 2100 },
                new Car { Id = 2, Year = 2018, Make = "Dodge", Model = "Challenger", Trim = "Demon", HorsePower = 840, WeightKilograms = 2300 },
                new Car { Id = 3, Year = 2018, Make = "Ford", Model = "Mustang", Trim = "Boss", HorsePower = 750, WeightKilograms = 1900 }
            };
        }

        // GET: api/cars
        public List<Car> GetCars() => _records;

        // GET: api/cars/5
        [ResponseType(typeof(Car))]
        public Car GetCarRecord(int id)
        {
            Car carRecord = _records.Where(r => r.Id == id).FirstOrDefault();
            return carRecord != null ? carRecord : new Car();
        }
    }
}
