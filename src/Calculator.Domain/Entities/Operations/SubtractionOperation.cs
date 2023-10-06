namespace Calculadora.Domain.Entities.Operations;

public class SubtractionOperation : Operation
{
    public SubtractionOperation(decimal firstNumber, decimal secondNumber)
        : base(firstNumber, secondNumber) { }

    public override decimal Result()
    {
        return FirstNumber - SecondNumber;
    }
}
