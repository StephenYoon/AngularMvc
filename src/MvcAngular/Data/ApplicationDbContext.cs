using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcAngular.Models;

namespace MvcAngular.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("OktaConnectionString")
        {
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<JoggingRecord> JoggingRecords { get; set; }
    }
}