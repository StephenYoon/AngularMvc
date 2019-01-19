using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MvcAngular.Models;

namespace MvcAngular.Controllers
{
    public class JoggingRecordsController : ApiController
    {
        private List<JoggingRecord> _records;

        public JoggingRecordsController()
        {
            _records = new List<JoggingRecord>
            {
                new JoggingRecord { Id = 1, Description = "Friday Evening", Distance = 5.5f, CreatedAt = new DateTime(2018, 5, 1) },
                new JoggingRecord { Id = 2, Description = "Saturday morning", Distance = 6.15f, CreatedAt = new DateTime(2018, 4, 4) },
                new JoggingRecord { Id = 3, Description = "Marathon", Distance = 20, CreatedAt = new DateTime(2018, 5, 13) },
                new JoggingRecord { Id = 4, Description = "Short one", Distance = 3.5f, CreatedAt = new DateTime(2018, 6, 6) }
            };
        }

        // GET: api/JoggingRecords
        public List<JoggingRecord> GetJoggingRecords() => _records;

        // GET: api/JoggingRecords/5
        [ResponseType(typeof(JoggingRecord))]
        public JoggingRecord GetJoggingRecord(int id)
        {
            JoggingRecord joggingRecord = _records.Where(r => r.Id == id).FirstOrDefault();
            if (joggingRecord == null)
            {
                return new JoggingRecord();
            }

            return joggingRecord;
        }
    }
}
