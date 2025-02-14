using System.ComponentModel.DataAnnotations;

namespace ProductService.Entities;

public class Product
{
    [Key]
    [Required]
    public Guid Id { get; set;}

    [Required]
    [MaxLength(100)]
    public string Title { get; set;}

    [Required]
    [MaxLength(1000)]
    public string Description { get; set;}

    [Required]
    public int Cost { get; set; }

    [Required]
    public int Quantity { get; set;}
}