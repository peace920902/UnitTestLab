using Shouldly;
using StubFrameworkLab;
using Xunit;

namespace StubFrameworkTest.Fakes;

public class CalculateServiceTest
{
    [Fact]
    public void UsingMock()
    {
        // arrange
        var mockObj = new MockCalculator();
        ICalculateService calculateService = new CalculateService(mockObj);
        var excepted = (2m, 4m);

        // act
        var actual = calculateService.Calculate((1.5m, 2.5m), (1.5m, 2.5m));
        
        // assert
        actual.ShouldBe(excepted);
    }
    
    [Fact]
    public void UsingStub()
    {
        // arrange
        var stubObj = new StubCalculator();
        ICalculateService calculateService = new CalculateService(stubObj);
        var excepted = (20.05m, 20.05m);

        // act
        var actual = calculateService.Calculate((1000m, 2.542352345m), (10.543200m, 453523452m));
        
        // assert
        actual.ShouldBe(excepted);
    }
}