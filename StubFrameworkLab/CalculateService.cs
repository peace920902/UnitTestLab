namespace StubFrameworkLab;

public interface ICalculateService
{
    (decimal, decimal) Calculate((decimal a, decimal b) pair1, (decimal c, decimal d) pair2);
}

public class CalculateService : ICalculateService
{
    private readonly ICalculate _calculate;

    public CalculateService(ICalculate calculate)
    {
        _calculate = calculate;
    }

    public (decimal, decimal) Calculate((decimal a, decimal b) pair1, (decimal c, decimal d) pair2)
    {
        var item1 = _calculate.Add(pair1.a, pair2.c);
        var item2 = _calculate.Add(pair1.b, pair2.d);

        return (item1, item2);
    }
}