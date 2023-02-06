using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class ShopContext : DbContext
{
    
    public ShopContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<items>();
    }
    public DbSet<items> ShopItem { get; set; }
}
