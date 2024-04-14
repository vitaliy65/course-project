using Microsoft.EntityFrameworkCore;
using Курсовая_работа.model;

namespace Курсовая_работа.Data
{
    internal class Le_PeTa_context : DbContext
    {
        public DbSet<Customer> customers { get; set; } = null!;
        public DbSet<Order> orders { get; set; } = null!;
        public DbSet<Product> products { get; set; } = null!;
        public DbSet<Restaurant> restaurants { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VITALII\\MSSQLSERVER01;Initial Catalog=Le-PeTa-Part1;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
