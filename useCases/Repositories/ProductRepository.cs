namespace Products_API.useCases.Repositories;

using Products_API.useCases.Repositories.Interfaces;

public class ProductRepository : IProductRepository
{

  private readonly List<Product> _Products = new List<Product>() {
    new() {Id = 1, ProductName = "TV", ProductDescription = "Uma televisão muito incrível!", ProductPrice = 1999.99, ProductImageURL = "https://images.samsung.com/is/image/samsung/p6pim/br/un75au7700gxzd/gallery/br-uhd-4k-tv-un75au7700gxzd---532138489?$650_519_PNG$" },
    new() {Id = 2, ProductName = "Mouse", ProductDescription = "Mouse da atualidade!", ProductPrice = 99.99, ProductImageURL = "https://m.media-amazon.com/images/I/712FFQs35IL._AC_SY679_.jpg" },
    new() {Id = 3, ProductName = "Computador", ProductDescription = "Computador para jogos!", ProductPrice = 5999.99, ProductImageURL = "https://images.kabum.com.br/produtos/fotos/sync_mirakl/150578/Computador-Gamer-AMD-10-Core-3-8Ghz-8GB-Radeon-R5-2GB-SSD-e-HD-2TB-Monitor-HDMI-LED-19-5-Kit-Gamer-Skill_1682012321_gg.jpg" }
  };
  
  
  public List<Product> GetAll()
  {
    return this._Products; 
  }

  public Product? GetById(int id = 0)
  {
    return this._Products.FirstOrDefault(prd => prd.Id == id);
  }
}
