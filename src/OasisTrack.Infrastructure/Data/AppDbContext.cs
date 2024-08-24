using Microsoft.EntityFrameworkCore;
using OasisTrack.Core.Entities;

namespace OasisTrack.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Store> Stores { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<Driver> Drivers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Route>()
            .HasOne(r => r.Driver)
            .WithOne(d => d.CurrentRoute)
            .HasForeignKey<Route>(r => r.DriverId)
            .IsRequired(false);
        
        builder.Entity<Driver>()
            .HasOne(r => r.CurrentRoute)
            .WithOne(d => d.Driver)
            .HasForeignKey<Driver>(r => r.CurrentRouteId)
            .IsRequired(false);
    }
}