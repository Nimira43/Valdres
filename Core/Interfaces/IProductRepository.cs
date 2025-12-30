using Core.Entities;

namespace Core.Interfaces;

public class IProductRepository
{
  Task<IReadOnlyList<Product>> GetProductsAsync();
  Task<Product?> GetProductByIdAsync(int id);
}
