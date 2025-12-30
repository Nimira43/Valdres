using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data;

public class ProductsRepository(StoreContext context) : IProductRepository
{
  public void AddProduct(Product product)
  {
    context.Products.Add(product);
  }

  public void DeleteProduct(Product product)
  {
    context.Products.Remove(product);
  }

  public async Task<Product?> GetProductByIdAsync(int id)
  {
    return await context.Products.FindAsync(id);
  }

  public Task<IReadOnlyList<Product>> GetProductsAsync()
  {
    throw new NotImplementedException();
  }

  public bool ProductExists(int id)
  {
    throw new NotImplementedException();
  }

  public Task<bool> SaveChangesAsync()
  {
    throw new NotImplementedException();
  }

  public void UpdateProduct(Product product)
  {
    throw new NotImplementedException();
  }
}
