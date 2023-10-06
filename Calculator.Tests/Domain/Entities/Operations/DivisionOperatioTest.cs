using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Tests.Domain.Entities.Operations;

public class DivisionOperatioTest
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 1)]
    [InlineData(3, 3, 1)]
    public void ShouldDivideTwoNumbers(decimal firstNumber, decimal secondNumber, decimal expected)
    {
        var operation = new DivisionOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.1, 1.1, 1)]
    [InlineData(2.2, 2.2, 1)]
    [InlineData(3.3, 3.3, 1)]
    public void ShouldDivideTwoDecimalNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new DivisionOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-1, -1, 1)]
    [InlineData(-2, -2, 1)]
    [InlineData(-3, -3, 1)]
    public void ShouldDivideTwoNegativeNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new DivisionOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }
}
