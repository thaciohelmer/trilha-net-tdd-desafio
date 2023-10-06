namespace Calculadora.Domain.Entities.Operations;

public class Addition : Operation
{
    public Addition(decimal firstNumber, decimal secondNumber)
        : base(firstNumber, secondNumber) { }

    public override decimal Result()
    {
        return FirstNumber + SecondNumber;
    }
}
