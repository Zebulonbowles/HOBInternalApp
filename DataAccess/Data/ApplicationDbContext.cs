using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<BiomassBatch> BiomassBatches { get; set; }
        public DbSet<DistillateBatch> DistillateBatches { get; set; }
        public DbSet<BiomassExtraction> BiomassExtractions { get; set; }
        public DbSet<Distillation> Distillations { get; set; } 
        public DbSet<CrudeBatch> CrudeBatches { get; set; }


    }
}
