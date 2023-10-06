namespace Calculadora.Domain.Entities.Operations;

public class MultiplicationOperation : Operation
{
    public MultiplicationOperation(decimal firstNumber, decimal secondNumber)
        : base(firstNumber, secondNumber) { }

    public override decimal Result()
    {
        return FirstNumber * SecondNumber;
    }
}
