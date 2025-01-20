using Microsoft.EntityFrameworkCore;
using OrderDeliveryApp.Models;

namespace OrderDeliveryApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .Property(o => o.PickupDate)
            .HasColumnType("timestamp with time zone");
    }
}