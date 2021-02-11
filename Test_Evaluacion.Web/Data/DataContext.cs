using Microsoft.EntityFrameworkCore;
using Test_Evaluacion.Common.Entities;

namespace Test_Evaluacion.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
