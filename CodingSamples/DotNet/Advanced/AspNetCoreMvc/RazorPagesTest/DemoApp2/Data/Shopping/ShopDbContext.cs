using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data.Shopping;

public class ShopDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
    
}