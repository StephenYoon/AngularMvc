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
                new Car { Id = 1, Year = 2018, Make = "Chevy", Model = "Camaro", Trim = "ZL1 Exorcist", HorsePower = 1000, WeightKilograms = 1732 },
                new Car { Id = 2, Year = 2018, Make = "Dodge", Model = "Challenger", Trim = "Demon", HorsePower = 840, WeightKilograms = 1939},
                new Car { Id = 3, Year = 2018, Make = "Ford", Model = "Mustang", Trim = "RTR", HorsePower = 700, WeightKilograms = 1720 },
                new Car { Id = 3, Year = 2019, Make = "Genesis", Model = "G70", Trim = "Dynamic", HorsePower = 365, WeightKilograms = 1670 }
            };
        }

        // GET: api/carrecords
        [Route("api/carrecords")]
        public List<Car> GetCarRecords() => _records;

        // GET: api/cars/5
        [Route("api/carrecords/{id}")]
        [ResponseType(typeof(Car))]
        public Car GetCarRecord(int id)
        {
            Car carRecord = _records.Where(r => r.Id == id).FirstOrDefault();
            return carRecord != null ? carRecord : new Car();
        }
    }
}
