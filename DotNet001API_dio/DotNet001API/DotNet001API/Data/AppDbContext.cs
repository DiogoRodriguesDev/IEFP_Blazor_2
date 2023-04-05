using DotNet001API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet001API.Data
{
    public class AppDbContext : DbContext, IDataContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=DIO-PC\MSSQL_SERVER_DIO;Initial Catalog=AppDataBase; Trusted_Connection=True; TrustServerCertificate=True;");
        }

    }
}
