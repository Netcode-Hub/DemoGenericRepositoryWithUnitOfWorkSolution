using CompanyManagement.Domain.DatabaseEntities;
using Microsoft.EntityFrameworkCore;
namespace CompanyManagement.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Create Database Tables
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding employee's table
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Frederick Hughes", Address = "Accra, Ghana" },
                new Employee() { Id = 2, Name = "John Doe", Address = "New York, USA" },
                new Employee() { Id = 3, Name = "Moses Roberts", Address = "London, UK" }
                );

            //seeding customer's table
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Name = "Joseph Darling", Location = "Kumasi, Ghana" },
                new Customer() { Id = 2, Name = "Hurbert Rockingston", Location = "Abuja, Nigeria" },
                new Customer() { Id = 3, Name = "Mabel Knight", Location = "Cape Coast, Ghana" }
                );
        }
    }
}
