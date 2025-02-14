using Microsoft.EntityFrameworkCore;
using ProductService.Entities;

namespace ProductService.Data;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> opt) : base(opt)
    {

    }

    public DbSet<Product> Products { get; set; }
}