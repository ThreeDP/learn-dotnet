using Calculator.Services;
namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void SumTwoNumbersFiveAndSix()
    {
        Assert.Equal(11, Calc.Sum("5", "6"));
    }
}