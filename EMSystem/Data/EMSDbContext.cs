using EMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Data
{
    public class EMSDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EMSDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);

            optionsBuilder.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
           
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDefaultData();
            base.OnModelCreating(modelBuilder);
        }
  
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
