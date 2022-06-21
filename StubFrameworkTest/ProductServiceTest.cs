using NSubstitute;
using Shouldly;
using StubFrameworkLab;
using StubFrameworkTest.Fakes;
using Xunit;

namespace StubFrameworkTest;

public class ProductServiceTest
{
    private IProductRepository _productRepository;
    private ILogger _logger;
    private ICalculate _calculate;

    [Fact]
    public void Test_CalculatePrice_Should_100_using_handobj()
    {
        // arrange
        var stubLogger = new StubLogger();
        var stubRepository = new StubRepository();
        var stubCalculator = new StubCalculator();

        IProductService productService = new ProductService(stubRepository, stubLogger, stubCalculator);
        var expected = 100m;
        var input = new ShoppingItem()
        {
            Count = 1,
            ProductId = 1,
        };

        // act
        var actual = productService.CalculatePrice(input);

        // assert
        actual.ShouldBe(100m);
    }
    
    [Fact]
    public void Test_CalculatePrice_Should_200_using_NStub()
    {
        // arrange
        _productRepository = Substitute.For<IProductRepository>();
        _logger = Substitute.For<ILogger>();
        _calculate = Substitute.For<ICalculate>();
        
        IProductService productService = new ProductService(_productRepository, _logger, _calculate);
        _productRepository.GetProduct(Arg.Is(1)).Returns(new Product()
        {
            Price = 600m
        });
        _calculate.Multiple(Arg.Any<decimal>(), Arg.Any<decimal>()).Returns(200m);

        var expected = 200m;
        var input = new ShoppingItem()
        {
            Count = 100,
            ProductId = 1,
        };

        // act
        var actual = productService.CalculatePrice(input);

        // assert
        _logger.Received(1).Log(Arg.Is<string>(s => s.Contains("自由")));
        actual.ShouldBe(expected);
    }
}

public class StubLogger : ILogger
{
    public void Log(string message)
    {
    }
}

public class StubRepository: IProductRepository
{
    public Product? GetProduct(int id)
    {
        return new Product()
        {
            Id = 1,
            Name = "Test",
            Price = 100m
        };
    }
}
