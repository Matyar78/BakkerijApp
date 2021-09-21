using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataContext
{
    public class BakkerijDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            bool useLocalDb = true;

            Boolean.TryParse(ConfigurationManager.AppSettings["UseLocalDb"], out useLocalDb);

            if (useLocalDb)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BakkerijAppDb;");
            }
            else
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "BakkerijAppDb");               
            }
            
        }

        public virtual DbSet<Klant> Klanten { get; set; }
        public virtual DbSet<Medewerker> Medewerkers { get; set; }
        public virtual DbSet<Product> Producten { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Medewerker>().ToTable("Medewerker");
            modelBuilder.Entity<Product>().ToTable("Product");

        }
    }
}
