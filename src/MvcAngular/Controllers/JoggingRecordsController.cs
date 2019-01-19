using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MvcAngular.Data;
using MvcAngular.Models;

namespace MvcAngular.Controllers
{
    public class JoggingRecordsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/JoggingRecords
        public IQueryable<JoggingRecord> GetJoggingRecords() => db.JoggingRecords;

        // GET: api/JoggingRecords/5
        [ResponseType(typeof(JoggingRecord))]
        public async Task<IHttpActionResult> GetJoggingRecord(int id)
        {
            JoggingRecord joggingRecord = await db.JoggingRecords.FindAsync(id);
            if (joggingRecord == null)
            {
                return NotFound();
            }

            return Ok(joggingRecord);
        }
    }
}
