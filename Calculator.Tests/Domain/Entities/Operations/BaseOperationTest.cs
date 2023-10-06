using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Tests.Domain.Entities.Operations;

public class BaseOperationTest
{
    [Fact]
    public void ShouldReturnFirstNumber()
    {
        var firstNumber = 1m;
        var secondNumber = 2m;
        var operation = new Addition(firstNumber, secondNumber);

        var actual = operation.FirstNumber;

        Assert.Equal(firstNumber, actual);
    }

    [Fact]
    public void ShouldReturnSecondNumber()
    {
        var firstNumber = 1m;
        var secondNumber = 2m;
        var operation = new Addition(firstNumber, secondNumber);

        var actual = operation.SecondNumber;

        Assert.Equal(secondNumber, actual);
    }
}
