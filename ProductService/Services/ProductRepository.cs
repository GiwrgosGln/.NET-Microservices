using ProductService.Data;
using ProductService.Entities;

namespace ProductService.Services;

public class ProductRepository : IProductRepository
{
    private readonly ProductContext _context;

    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public void CreateProduct(Product product)
    {
        if(product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        _context.Products.Add(product);
    }

    public Product GetProduct(Guid id)
    {
        return _context.Products.FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<Product> GetProducts()
    {
        return _context.Products.ToList();
    }
}