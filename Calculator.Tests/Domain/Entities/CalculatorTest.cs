using Calculadora.Domain.Entities;
using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Tests;

public class CalculatorTest
{
    [Fact]
    public void ShouldReturnTheLastThreeOperations()
    {
        var calculator = new Calculator();

        var operation1 = new Addition(1, 1);
        var operation2 = new SubtractionOperation(2, 1);
        var operation3 = new MultiplicationOperation(2, 2);
        var operation4 = new DivisionOperation(4, 2);

        calculator.Execute(operation1);

        var result2 = calculator.Execute(operation2);
        var result3 = calculator.Execute(operation3);
        var result4 = calculator.Execute(operation4);

        var expected = new Tuple<Operation, decimal>[]
        {
            new(operation2, result2),
            new(operation3, result3),
            new(operation4, result4)
        };

        var actual = calculator.GetOperationHistory();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldCalculatorOperationLengthBeThree()
    {
        var calculator = new Calculator();

        var operation1 = new Addition(1, 1);
        var operation2 = new SubtractionOperation(2, 1);
        var operation3 = new MultiplicationOperation(2, 2);
        var operation4 = new DivisionOperation(4, 2);

        calculator.Execute(operation1);
        calculator.Execute(operation2);
        calculator.Execute(operation3);
        calculator.Execute(operation4);

        var expected = 3;

        var actual = calculator.GetOperationHistory().Length;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldAddTwoNumbers()
    {
        var calculator = new Calculator();
        var operation = new Addition(1, 1);
        var expected = 2;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldSubtractTwoNumbers()
    {
        var calculator = new Calculator();
        var operation = new SubtractionOperation(1, 1);
        var expected = 0;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldMultiplyTwoNumbers()
    {
        var calculator = new Calculator();
        var operation = new MultiplicationOperation(1, 1);
        var expected = 1;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldDivideTwoNumbers()
    {
        var calculator = new Calculator();
        var operation = new DivisionOperation(1, 1);
        var expected = 1;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldAddTwoDecimalNumbers()
    {
        var calculator = new Calculator();
        var operation = new Addition(1.1m, 1.1m);
        var expected = 2.2m;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldSubtractTwoDecimalNumbers()
    {
        var calculator = new Calculator();
        var operation = new SubtractionOperation(1.1m, 1.1m);
        var expected = 0m;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldMultiplyTwoDecimalNumbers()
    {
        var calculator = new Calculator();
        var operation = new MultiplicationOperation(1.1m, 1.1m);
        var expected = 1.21m;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldDivideTwoDecimalNumbers()
    {
        var calculator = new Calculator();
        var operation = new DivisionOperation(1.1m, 1.1m);
        var expected = 1m;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldAddTwoNegativeNumbers()
    {
        var calculator = new Calculator();
        var operation = new Addition(-1, -1);
        var expected = -2;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldSubtractTwoNegativeNumbers()
    {
        var calculator = new Calculator();
        var operation = new SubtractionOperation(-1, -1);
        var expected = 0;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldMultiplyTwoNegativeNumbers()
    {
        var calculator = new Calculator();
        var operation = new MultiplicationOperation(-1, -1);
        var expected = 1;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldDivideTwoNegativeNumbers()
    {
        var calculator = new Calculator();
        var operation = new DivisionOperation(-1, -1);
        var expected = 1;

        var actual = calculator.Execute(operation);

        Assert.Equal(expected, actual);
    }
}
