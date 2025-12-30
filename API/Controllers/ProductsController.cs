using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IProductRepository repo) : ControllerBase
{
  [HttpGet]
  public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
  {
    return Ok(await repo.GetProductsAsync());
  }

  [HttpGet("{id:int}")]
  public async Task<ActionResult<Product>> GetProduct(int id)
  {
    var product = await repo.GetProductByIdAsync(id);

    if (product == null) return NotFound();

    return product;
  }

  [HttpPost]
  public async Task<ActionResult<Product>> CreateProduct(Product product)
  {
    context.Products.Add(product);

    await context.SaveChangesAsync();

    return product;
  }

  [HttpPut("{id:int}")]
  public async Task<ActionResult> UpdateProduct(int id, Product product)
  {
    if (product.Id != id || !ProductExists(id))
      return BadRequest("Cannot update this product");

    context.Entry(product).State = EntityState.Modified;

    await context.SaveChangesAsync();

    return NoContent();
  }

  [HttpDelete("{id:int}")]
  public async Task<ActionResult> DeleteProduct(int id)
  {
    var product = await context.Products.FindAsync(id);

    if (product == null) return NotFound();

    context.Products.Remove(product);

    await context.SaveChangesAsync();

    return NoContent();
  }

  private bool ProductExists(int id)
  {
    return context.Products.Any(x => x.Id == id);
  }
}