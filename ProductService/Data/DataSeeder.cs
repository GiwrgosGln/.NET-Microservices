using ProductService.Entities;

namespace ProductService.Data
{
    public static class DataSeeder
    {
        public static void SeedData(ProductContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { 
                        Id = Guid.NewGuid(), 
                        Title = "Gaming Laptop", 
                        Description = "High-end gaming laptop",
                        Cost = 1299,
                        Quantity = 10
                    },
                    new Product { 
                        Id = Guid.NewGuid(), 
                        Title = "Smartphone", 
                        Description = "Latest model smartphone",
                        Cost = 899,
                        Quantity = 15
                    },
                    new Product { 
                        Id = Guid.NewGuid(), 
                        Title = "Wireless Headphones", 
                        Description = "Noise-cancelling headphones",
                        Cost = 199,
                        Quantity = 20
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
