using EFCoreParkbeheer.DL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL
{
    public class ParkbeheerContext : DbContext
    {
        private string connectionString;

        public DbSet<HuisEF> Huizen { get; set; }
        public DbSet<HuurcontractEF> Huurcontracten { get; set; }
        public DbSet<HuurderEF> Huurders { get; set; }
        public DbSet<ParkEF> Parken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseLoggerFactory(factory)  //tie-up DbContext with LoggerFactory object
            //.EnableSensitiveDataLogging()
            optionsBuilder.UseSqlServer(@"Data Source=vizing;Initial Catalog=parkbeheer;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
