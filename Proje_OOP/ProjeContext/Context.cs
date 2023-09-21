using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ROOT\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;");
        }
        public DbSet<Product> tblProduct { get; set; }
        public DbSet <Customer> tblCustomer { get; set; }
        public DbSet<Category> tblCategory { get; set; }
    }
}
