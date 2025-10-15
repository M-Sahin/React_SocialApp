using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    // Parameterless constructor for design-time support
    public AppDbContext() : base()
    {
    }

    public DbSet<Activity> Activities { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // This will be used by EF Design Tools
            optionsBuilder.UseSqlite("Data source=reactapp.db");
        }
    }
}
