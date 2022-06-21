namespace StubFrameworkLab;

public interface IProductDB
{
    List<Product> Products { get; set; }
}

public class ProductDB : IProductDB
{
    public List<Product> Products { get; set; } = new()
    {
        new Product
        {
            Id = 1,
            Name = "Apple",
            Price = 30
        },
        new Product
        {
            Id = 2,
            Name = "PineApple",
            Price = 60
        },
        new Product
        {
            Id = 3,
            Name = "Banana",
            Price = 17
        },
        new Product
        {
            Id = 4,
            Name = "Chocolate",
            Price = 50
        },
    };
}