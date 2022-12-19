using ConsoleApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.DataAcsees;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Server=DESKTOP-BCRUVMF;Database=ConsoleAppDb;Trusted_connection=True");
    }

    public DbSet<Employee> Employees { get; set; }

}
