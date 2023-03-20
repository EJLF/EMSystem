using EMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                  new Employee(1, "Earl Joseph Ferran",DateTime.Now,"earljoseph@gmial.com","09959632422",1),
                  new Employee(2, "Coco Martin", DateTime.Now, "batangQuipo@gmial.com", "09023213749", 4),
                  new Employee(3, "Liza Soberano", DateTime.Now, "lizasoberano@gmial.com", "09023213749", 2)

                  );

            modelBuilder.Entity<Department>().HasData(
                  new Department(1, "Information Technology"),
                  new Department(2, "Human Resources"),
                  new Department(3, "Marketing"),
                  new Department(4, "Network Administration")
                  );
        }
    }
}
