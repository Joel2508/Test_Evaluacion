using Microsoft.EntityFrameworkCore;
using Test_Evaluacion.Web.Data.Entities;

namespace Test_Evaluacion.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Invoice>().HasIndex(t => t.Name).IsUnique();
        }

    }
}
