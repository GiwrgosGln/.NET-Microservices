using ProductService.Entities;

namespace ProductService.Services;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
    Product GetProduct(Guid id);
    void CreateProduct(Product product);
}