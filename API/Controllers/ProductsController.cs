using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
}
