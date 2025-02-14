namespace ProductService.Models;

public class ProductDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
    public int Quantity { get; set; } = 0;
}