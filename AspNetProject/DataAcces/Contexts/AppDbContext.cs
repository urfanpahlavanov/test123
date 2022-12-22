using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAcces.Contexts;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public BbSet<SilideItem> SlideItems { get; set; }
}
