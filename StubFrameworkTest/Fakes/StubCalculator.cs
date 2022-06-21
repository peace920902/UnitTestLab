using StubFrameworkLab;

namespace StubFrameworkTest.Fakes;

public class StubCalculator: ICalculate
{
    /// <summary>
    /// 回傳20.05m
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public decimal Add(decimal a, decimal b)
    {
        return 20.05m;
    }

    /// <summary>
    /// 回傳100m
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public decimal Multiple(decimal a, decimal b)
    {
        return 100m;
    }
}