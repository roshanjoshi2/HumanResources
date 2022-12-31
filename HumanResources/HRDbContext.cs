using HumanResources.Models;
using Microsoft.EntityFrameworkCore;

namespace HumanResources
{
    public class HRDbContext:DbContext
    {
        public DbSet<Employee> Employees{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HumanResources_Test;Integrated Security=true");
        }

        

    }
}
