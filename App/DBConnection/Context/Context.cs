
using Microsoft.EntityFrameworkCore;
using Shared.Models;


namespace DBConnection.Context;

public class TabloidContext : DbContext
{
    public DbSet<Department> department { get; set; }
    public DbSet<Story> story { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        
        optionsBuilder.UseNpgsql($"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=password");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasKey(d => d.Id);
        modelBuilder.Entity<Story>().HasKey(s => s.Id);
    }
}

