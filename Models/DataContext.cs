using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
        // This context class defines properties that will be used to query 
        // the database for Product, Category, and Supplier data
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
