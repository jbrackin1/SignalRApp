using Microsoft.EntityFrameworkCore;

namespace RealtimeDataApp.Data
{
    public class AppDbContext : DbContext
    {
        string _connectionString = "Server=/Users/jerodbrackin/CompanyDatabase2;Database=CompanyDatabase2;Trusted_Connection=True;";

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
