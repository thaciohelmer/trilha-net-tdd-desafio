using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Tests.Domain.Entities.Operations;

public class AdditionOperationTest
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 3, 6)]
    public void ShouldSumTwoNumbers(decimal firstNumber, decimal secondNumber, decimal expected)
    {
        var operation = new Addition(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.1, 1.1, 2.2)]
    [InlineData(2.2, 2.2, 4.4)]
    [InlineData(3.3, 3.3, 6.6)]
    public void ShouldSumTwoDecimalNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new Addition(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-1, -1, -2)]
    [InlineData(-2, -2, -4)]
    [InlineData(-3, -3, -6)]
    public void ShouldSumTwoNegativeDecimalNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new Addition(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }
}
