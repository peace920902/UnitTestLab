namespace StubFrameworkLab;

public interface IProductService
{
    decimal CalculatePrice(ShoppingItem shoppingItem);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly ILogger _logger;
    private readonly ICalculate _calculate;

    public ProductService(IProductRepository productRepository, ILogger logger, ICalculate calculate)
    {
        _productRepository = productRepository;
        _logger = logger;
        _calculate = calculate;
    }
    
    public decimal CalculatePrice(ShoppingItem shoppingItem)
    {
        var product = _productRepository.GetProduct(shoppingItem.ProductId);
        var price = _calculate.Multiple(product!.Price, shoppingItem.Count);

        if (price > 100)
        {
            _logger.Log("財富自由");
        }

        return price;
    }
}