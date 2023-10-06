using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Tests.Domain.Entities.Operations;

public class SubtractionOperationTest
{
    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(2, 2, 0)]
    [InlineData(3, 3, 0)]
    public void ShouldSubtractTwoNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new SubtractionOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.1, 1.1, 0)]
    [InlineData(2.2, 2.2, 0)]
    [InlineData(3.3, 3.3, 0)]
    public void ShouldSubtractTwoDecimalNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new SubtractionOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-1, -1, 0)]
    [InlineData(-2, -2, 0)]
    [InlineData(-3, -3, 0)]
    public void ShouldSubtractTwoNegativeNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    )
    {
        var operation = new SubtractionOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }
}
