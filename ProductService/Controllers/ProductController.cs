using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Services;

namespace ProductService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductController(
        IProductRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProductDto>> GetProducts()
    {
        var products = _repository.GetProducts();

        var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);

        return Ok(productDtos);
    }

    [HttpGet("{id}")]
    public ActionResult<ProductDto> GetProduct(Guid id)
    {
        var product = _repository.GetProduct(id);
        if (product != null)
        {
            return Ok(product);
        }
        return NotFound();
    }
}