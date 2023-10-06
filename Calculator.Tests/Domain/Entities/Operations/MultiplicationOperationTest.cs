using Calculadora.Domain.Entities;
using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Tests.Domain.Entities.Operations;

public class MultiplicationOperationTest
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 3, 9)]
    public void ShouldMultiplyTwoNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    ){
        var operation = new MultiplicationOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-1, -1, 1)]
    public void ShouldMultiplyTwoNegativeNumbers(decimal firstNumber, decimal secondNumber, decimal expected)
    {
        var operation = new MultiplicationOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.1, 1.1, 1.21)]
    [InlineData(2.2, 2.2, 4.84)]
    [InlineData(3.3, 3.3, 10.89)]
    public void ShouldMultiplyTwoDecimalNumbers(
        decimal firstNumber,
        decimal secondNumber,
        decimal expected
    ){
        var operation = new MultiplicationOperation(firstNumber, secondNumber);
        var actual = operation.Result();

        Assert.Equal(expected, actual);
    }
}
