namespace StubFrameworkLab;

public interface IProductRepository
{
    Product? GetProduct(int id);
}

public class ProductRepository : IProductRepository
{
    private readonly IProductDB _productDb;

    public ProductRepository(IProductDB productDb)
    {
        _productDb = productDb;
    }
    
    public Product? GetProduct(int id)
    {
        return _productDb.Products.Find(x => x.Id == id);
    }
}