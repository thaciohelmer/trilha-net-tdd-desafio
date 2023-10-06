namespace Calculadora.Domain.Entities.Operations;

public class DivisionOperation : Operation
{
    public DivisionOperation(decimal firstNumber, decimal secondNumber)
        : base(firstNumber, secondNumber) { }

    public override decimal Result()
    {
        return FirstNumber / SecondNumber;
    }
}
