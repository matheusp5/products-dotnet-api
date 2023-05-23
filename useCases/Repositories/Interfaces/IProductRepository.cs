namespace Products_API.useCases.Repositories.Interfaces;

public interface IProductRepository { 

  public List<Product> GetAll();
  public Product? GetById(int id = 0);
}