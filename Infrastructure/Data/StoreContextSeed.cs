namespace Infrastructure.Data;

public class StoreContextSeed
{
  public static async Task SeedAsync(StoreContext context)
  {
    if (!context.Products.Any())
    {
      var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");
    }
  }
}
