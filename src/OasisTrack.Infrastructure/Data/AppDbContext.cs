using Microsoft.EntityFrameworkCore;
using OasisTrack.Core.Entities;

namespace OasisTrack.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Store> Stores { get; set; }
}