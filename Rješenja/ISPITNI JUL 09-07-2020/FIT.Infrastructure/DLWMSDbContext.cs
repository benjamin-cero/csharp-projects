using FIT.Data;
using FIT.Data.IspitIB200172;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<SemestriIB200172> Semestri { get; set; }
        public DbSet<PredmetiIB200172> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB200172> PolozeniPredmeti { get; set; }

    }
}