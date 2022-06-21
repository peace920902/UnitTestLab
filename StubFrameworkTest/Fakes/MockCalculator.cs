using StubFrameworkLab;

namespace StubFrameworkTest.Fakes;

public class MockCalculator: ICalculate
{
    /// <summary>
    /// 回傳無條件捨去到整數位的a 跟 b 相加
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public decimal Add(decimal a, decimal b)
    {
        return (int)a + (int)b;
    }

    /// <summary>
    /// 回傳無條件捨去到整數位的a 跟 b 相乘
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public decimal Multiple(decimal a, decimal b)
    {
        return (int)a * (int)b;
    }
}