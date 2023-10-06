namespace Calculadora.Domain.Entities.Operations;

public abstract class Operation
{
    protected Operation(decimal firstNumber, decimal secondNumber)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
    }

    public decimal FirstNumber { get; private set; }
    public decimal SecondNumber { get; private set; }

    public abstract decimal Result();
}
