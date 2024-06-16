using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;

namespace DBConnection.Context
{
    public class TabloidContext : DbContext
    {
        public DbSet<Department> department { get; init; }
        public DbSet<Story> story { get; init; }
        public DbSet<DepartmentStory> departmentStory { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? 
                                   "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=password"; // Fallback for local development
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("viatabloid");
            modelBuilder.Entity<Department>().HasKey(d => d.id);
            modelBuilder.Entity<Story>().HasKey(s => s.id);
            modelBuilder.Entity<DepartmentStory>().HasKey(ds => ds.id);
        }
    }
}