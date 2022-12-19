using ConsoleApp.Core.Entities;
using ConsoleApp.DataAcsees;

AppDbContext context= new AppDbContext();

Employee employee = new()
{
    Id = 1,
    Name = "Urfan",
    Surname = "Pahlavanov",
    Salaary = 1200
};
await context.Employees.AddAsync(employee);  
await context.SaveChangesAsync();
